using Model;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;

namespace Pt3c_DataBase
{
    public partial class Form1 : Form
    {
        TiendaDao dao = new TiendaDao();
        private List<Cliente> clientes = new List<Cliente>();

        private MySqlConnection con;
        private DbConect dbConnect;
        public Form1()
        {
            InitializeComponent();
        }

        private void lLISTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarDatosEnListView();
        }

        private void getNom()
        {
            clientes = dao.getNombre();
            listBox1.Items.Clear();
            foreach (Cliente c in clientes)
            {
                listBox1.Items.Add(c.Nomclient);
            }

        }

        private void getDataTel()
        {
            clientes = dao.getTelefono();
            comboBox1.Items.Clear();
            foreach (Cliente c in clientes)
            {
                comboBox1.Items.Add(c.Telefon);
                comboBox1.SelectedIndex = 0;
            }
        }

        private void MostrarDatosEnListView()
        {
            //limpiamos los datos para que no se repitan
            listView1.Clear();
            //añadimos las columnas para mostrar en el listview
            listView1.Columns.Add("Nombre");
            listView1.Columns.Add("Adreça", 150);
            listView1.Columns.Add("Poblacio", 250);
            listView1.Columns.Add("Telefon", 100);
            listView1.Columns.Add("Email", 125);
            //llamamos al dao para mostrar los datos 
            clientes = dao.getAll();

            //recorremos la base de datos
            foreach (Cliente c in clientes)
            {
                ListViewItem item = new ListViewItem();
                item.Text = c.Nomclient;
                item.SubItems.Add(c.Adreça);
                item.SubItems.Add(c.Poblacio);
                item.SubItems.Add(c.Telefon);
                item.SubItems.Add(c.EmailContacte);
                listView1.Items.Add(item);
            }
        }

        private void dETALLESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            getNom();
            dataComand();
            getDataTel();
        }


        private void dataComand()
        {
            string nombreCliente = "";

            if(listBox1.SelectedItem != null)
            {
                nombreCliente= listBox1.SelectedItem.ToString();
            }

            DataSet ds = new DataSet();
            ds = dao.comandasConNombre(nombreCliente);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDataComanda();

        }
        private void getDataComanda()
        {
            // Obtenir la informació seleccionada del ListBox
            string nombreCliente = "";

            if (listBox1.SelectedItem != null)
            {
                nombreCliente = (string)listBox1.SelectedItem;
            }
            // Filtrar les comandes del client desitjat a partir d'una font de dades
            DataSet ds = new DataSet();
            ds = dao.comandasConNombre(nombreCliente);
            // Assignar el resultat del filtre a la propietat DataSource de la DataGrid
            dataGridView1.DataSource = ds.Tables[0].DefaultView;

        }


    }
}