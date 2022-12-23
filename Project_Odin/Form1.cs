namespace Project_Odin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            F_Login f_login = new F_Login(this);
            f_login.ShowDialog();
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

        private void logONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void logOFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_acesso.Text = "0";
            lbl_nomeUsuario.Text = "---";
            pictureBox1.Image = Properties.Resources.led_red;

            Globais.nivel = 0;
            Globais.logado = false;
        }

        private void responsáveisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Responsavel f_Responsavel = new F_Responsavel();
            abreForm(1, f_Responsavel);
        }
    }
}