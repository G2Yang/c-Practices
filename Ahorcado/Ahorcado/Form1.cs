using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Media;
using System.Net.Mail;
using System.Timers;

namespace Ahorcado
{
    public partial class Form1 : Form
    {
        List<string> palabras = new List<string>();
        List<TextBox> myTextBoxes = new List<TextBox>();
        int escogido;
        int fallos = 0;
        int s;
        int ganado = 0;
        int timeleft;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Load("./Ahorcado/0fallo.png");
            rellenar();
            aleatorio_llenar();

            timer1.Interval = 1000;
            timer1.Start();
            timeleft = 60;
            timerBox.Text = "Tiempo: " + timeleft;
            timer1.Tick += OnTimedEvent;
        }

        private void OnTimedEvent(object sender, EventArgs e)
        {
            timeleft--;

            if (timeleft < 5)
            {
                String path = "./Ahorcado/pres.jpg";
                BackgroundImage = Image.FromFile(path);
                timerBox.Text = "Tiempo: " + timeleft;

            }
            if(timeleft <= 0){
                String path = "./Ahorcado/lose.png";
                pictureBox1.Load(path);
                timer1.Stop();
                newGameBar.Enabled = true;
            }
            else
            {
                timerBox.Text = "Tiempo: " + timeleft;
            }
        }

        private void buttPrueba_Click(object sender, EventArgs e)
        {
            Button bit = (Button)sender;
            bit.Enabled = false;
            char letra = oneToChar(bit);

            String fras = palabras[escogido];
            char[] let = fras.ToCharArray();
            JuegoEnSi(letra,let,fras);
        }

        private void JuegoEnSi(char letra, char[] let,String fras)
        {

            if (let.Contains(letra))
            {
                for (int i = 0; i < fras.Length; i++)
                {
                    if (letra == let[i])
                    {
                        myTextBoxes[i].Text = letra.ToString();
                        sound(2,true);
                        ganado++;

                        if (ganado == let.Length)
                        {
                            QuitarBotones();
                            ShowWinLose.Enabled = true; 
                            ShowWinLose.Visible = true;
                            ShowWinLose.Text = "You Win";
                            exitButton.Visible = true;
                            newGameBar.Enabled = true;
                            resetButton.Visible = true;
                            sound(1,true);
                            checkWords(let, fras);
                        }
                    }
                }
            }
            else
            {
                if (fallos < 5)
                {
                    fallos++;
                    String path = "./Ahorcado/" + fallos + "fallo.png";
                    pictureBox1.Load(path);
                    sound(2,false);
                }
                else
                {
                    QuitarBotones();
                    ShowWinLose.Enabled = true;
                    ShowWinLose.Visible = true;
                    ShowWinLose.Text = "You Lose";
                    newGameBar.Enabled = true;
                    exitButton.Visible = true;
                    resetButton.Visible = true;
                    String path = "./Ahorcado/lose.png";
                    pictureBox1.Load(path);
                    sound(1,false);
                    checkWords(let, fras);

                }
            }
        }

        private void QuitarBotones()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button && c != resetButton || c is Button && c != exitButton)
                {
                    c.Visible = false;
                }
            }
        }

        private void checkWords(char[] let, String fras)
        {
            for (int i = 0; i < fras.Length; i++)
            {
                String pru = myTextBoxes[i].Text.ToString();
                Boolean a = String.IsNullOrEmpty(pru);
                if (a == true)
                {
                    myTextBoxes[i].BackColor = Color.Red;
                    myTextBoxes[i].Text = let[i].ToString();
                }
                else
                {
                    myTextBoxes[i].BackColor = Color.Green;
                }
            }
            
        } //cambia de color si no ha acertado a rojo y pone lo que no has adivinado

        private void reset_Click(object sender, EventArgs e)
        {
            ShowWinLose.Enabled = false;
            ShowWinLose.Visible = false;
            resetButton.Visible = false;

            Application.Restart();
        } // resetear la aplicacion 

        private void sound(int opci,Boolean win)
        {
            if (opci == 1)
            {
                if (win == true)
                {
                    SoundPlayer simpleSound = new SoundPlayer("./Ahorcado/win.wav");
                    simpleSound.Play();
                }
                else
                {
                    SoundPlayer simpleSound = new SoundPlayer("./Ahorcado/scream.wav");
                    simpleSound.Play();
                }
            }
            else if (opci == 2)
            {
                if (win == true)
                {
                    SoundPlayer simpleSound = new SoundPlayer("./Ahorcado/click.wav");
                    simpleSound.Play();
                }
                else
                {
                    SoundPlayer simpleSound = new SoundPlayer("./Ahorcado/foxycoming.wav");
                    simpleSound.Play();
                }
            }

        } //los sonidos de ganar y perder

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private char oneToChar(Button bit)
        {
            String beta = bit.Text;
            char[] a = beta.ToCharArray();
            char letra = a[0];
            return letra;
        }

        private void rellenar() //rellena la lista de nombres
        {
            
            palabras.Add("GATO");
            palabras.Add("PERRO");
            palabras.Add("GALLO");
            palabras.Add("GANSO");
            palabras.Add("MARIPOSA");
            palabras.Add("MARSUPIAL");
            palabras.Add("POLILLA");
            palabras.Add("FLORES");
        }

        private void aleatorio_llenar() //escoger una frase a mostrar
        {

            Random random = new Random();

            int palabra_random = random.Next(0,palabras.Count);


            string frase = palabras[palabra_random];

            
            MessageBox.Show(frase);
            loadLabels(frase);
            escogido =  palabra_random;
        }

        private void loadLabels(String frase)
        {
            int x = 0;
            for (int i = 0; i < frase.Length; i++)
            {
               
                TextBox t = new TextBox();
                t.Location = new System.Drawing.Point(250 + x, 300);
               
                x += 40;
                t.Size = new System.Drawing.Size(30, 10);
                t.ReadOnly = true;

                myTextBoxes.Add(t);

                Controls.Add(t);

            }




        }  // añade los text box de de las letras

        private void cerrando(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Estas seguro?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado != DialogResult.Yes)
            {
                e.Cancel = true;
                Application.Exit();
            }
            
        }


        private void sortirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newGameBar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void obrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los ficheros (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                        String[] content = fileContent.Split(new char[] {'\n'});

                        for (int i = 0; i < content.Length; i++)
                        {
                            palabras.Add(content[i]);
                        }
                        
                    }
                }
            }
        }

        private void camarasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile("./Ahorcado/camaras.png");
        }

        private void tuberiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile("./Ahorcado/ventilacion.jpg");
        }

        private void salaDeVigilanciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile("./Ahorcado/office.jpg");
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile("./Ahorcado/background.jpg");
        }

        private void tempsMaximToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormtTiempo form = new FormtTiempo();
            form.ShowDialog();
        }
    }
}