using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaTeste
{
    public partial class Form1 : Form
    {
        List<Pessoa> pessoas;

        public Form1()
        {
            InitializeComponent();

            pessoas = new List<Pessoa>();

            comboEmpresa.Items.Add("Empresa1");
            comboEmpresa.Items.Add("Empresa2");
            comboEmpresa.Items.Add("Empresa3");

            comboEmpresa.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha o campo nome.");
                txtNome.Focus();
                return;
            }

            if (txtCPF.Text == "   ,   ,   -")
            {
                MessageBox.Show("Preencha o campo CPF.");
                txtCPF.Focus();
                return;
            }

            Pessoa p = new Pessoa();
            p.Nome = txtNome.Text;
            p.CPF = txtCPF.Text;
            p.Empresa = comboEmpresa.SelectedItem.ToString();


            pessoas.Add(p);

            btnLimpar_Click(btnLimpar, EventArgs.Empty);

            Listar();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int indice = lista.SelectedIndex = 0;
            pessoas.RemoveAt(indice);
            Listar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = " ";
            txtCPF.Text = " ";
            comboEmpresa.SelectedIndex = 0;
            txtNome.Focus();
        }

        private void Listar()
        {
            lista.Items.Clear();

            foreach (Pessoa p in pessoas)
            {
                lista.Items.Add(p.texto1);
                lista.Items.Add(p.Nome);
                lista.Items.Add(p.texto2);
                lista.Items.Add(p.CPF);
                lista.Items.Add(p.texto3);
                lista.Items.Add(p.Empresa);
                lista.Items.Add(p.texto4);
            }
        }
    }
}
