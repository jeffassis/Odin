using Project_Odin.Forms;

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
            pane_top.BackColor = Color.FromArgb(240, 240, 240);
            pane_direita.BackColor = Color.FromArgb(215, 215, 215);
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

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Aluno f_Aluno = new F_Aluno();
            abreForm(1, f_Aluno);
        }

        private void gestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Usuario f_usuario = new F_Usuario();
            abreForm(2, f_usuario);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_Aluno f_Aluno = new F_Aluno();
            abreForm(1, f_Aluno);
        }

        private void notasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_Nota f_nota = new F_Nota();
            abreForm(1, f_nota);
        }

        private void bt_nota_Click(object sender, EventArgs e)
        {
            F_Nota f_nota = new F_Nota();
            abreForm(1, f_nota);
        }

        private void horariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Horario f_horario = new F_Horario();
            abreForm(1, f_horario);
        }
    }
}