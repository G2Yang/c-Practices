using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcado
{
    public partial class FormtTiempo : Form
    {
        public FormtTiempo()
        {
            InitializeComponent();
        }

        private void FormtTiempo_Load(object sender, EventArgs e)
        {

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }
        public void getNewTime()
        {
            int new_time = 0;
            new_time = (int)numericUpDown1.Value;
            MessageBox.Show(new_time.ToString());
        }
    }
}
