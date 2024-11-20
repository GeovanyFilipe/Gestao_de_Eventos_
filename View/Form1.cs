namespace Gestao_de_Eventos_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            CadastroUsuarios cadastroUsuarios = new CadastroUsuarios();
            cadastroUsuarios.ShowDialog();
            

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Inscricaoestudantes inscricaoestudantes=new Inscricaoestudantes();
            inscricaoestudantes.ShowDialog();
            
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            CadastroEventos cadastroEventos=new CadastroEventos();
            cadastroEventos.ShowDialog();
           
        }
    }
}
