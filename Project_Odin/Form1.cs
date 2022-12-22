namespace Project_Odin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Funcao para abir os formularios com parametros de nivel e chamada do Form
        private void abreForm(int nivel, Form f)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= nivel)
                {
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso nao permitido");
                }
            }
            else
            {
                MessageBox.Show("E necessario ter um usuario logado");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}