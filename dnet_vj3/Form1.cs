using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dnet_vj3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ajkula morskiPas = new Ajkula();
            morskiPas._datumUlova = dateTimePicker1.Value;
            int dani = morskiPas.ProsloOdUlova();
            string je_nije;
            if (radioButton1.Checked)
            {
                je_nije = "je";
            }
            else
            {
                je_nije = "nije";
            }

            MessageBox.Show(String.Format($"Morski pas je vrste: {comboBox1.SelectedItem}, ulovljen je prije {dani} dana, težine {textBox1.Text} kg i opasan {je_nije} po ljude!"));
        }
    }
}
