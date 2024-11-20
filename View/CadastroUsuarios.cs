using Gestao_de_Eventos_.Model;
using Gestao_de_Eventos_.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestao_de_Eventos_
{


    public partial class CadastroUsuarios : Form
    {
        private RepositorioGenerico<Usuario> repositorio_Generico = new RepositorioGenerico<Usuario>();
        public CadastroUsuarios()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {



            Usuario usuario = new Usuario()
            {
                nome = guna2TextBox1.Text,
                email = guna2TextBox2.Text,
                tipo = guna2ComboBox1.SelectedText.ToString(),

            };

            repositorio_Generico.Adicionar(usuario);

            MessageBox.Show("Usuário cadastrado com sucesso!");
            guna2TextBox1.Clear();
            guna2TextBox2.Clear();
            guna2ComboBox1.Items.Clear();






        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show(); 
            this.Close(); 
        }
    }
}
