using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sistema_Cadastro
{
    public partial class Form1 : Form
    {
        private List<Pessoa> pessoas;

        public Form1()
        {
            InitializeComponent();

            pessoas = new List<Pessoa>();

            comboBox1.Items.Add("Casado");
            comboBox1.Items.Add("Solteiro");
            comboBox1.Items.Add("Separado");
            comboBox1.Items.Add("Viuvo");

            comboBox1.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void Listar()
        {
            Lista.Items.Clear();

            foreach (Pessoa p in pessoas)
            {
                Lista.Items.Add(p.Nome);
            }
        }
    }
}
