using Gestao_de_Eventos_.Model;
using Gestao_de_Eventos_.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestao_de_Eventos_
{
    public partial class CadastroEventos : Form
    {
        private RepositorioGenerico<Evento> repositorioEventos = new RepositorioGenerico<Evento>();

        public CadastroEventos()
        {
            InitializeComponent();
        }

        private void CadastroEventos_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Evento evento = new Evento()
            {
                titulo = guna2TextBox1.Text,
                descricao = guna2TextBox2.Text,
                datahora = guna2DateTimePicker1.Value,
                criadorpor = guna2ComboBox1.SelectedItem.ToString()


            };

            repositorioEventos.Adicionar(evento);

            MessageBox.Show("Evento cadastrado com sucesso!");
            guna2TextBox1.Clear();
            guna2TextBox2.Clear();
            guna2ComboBox1.Items.Clear();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show(); 
            this.Close();
        }
    }
}
