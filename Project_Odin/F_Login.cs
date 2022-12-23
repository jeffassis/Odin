using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Odin
{
    public partial class F_Login : Form
    {
        Form1 form1;
        DataTable dt = new DataTable();
        public F_Login(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        // Funcao de validacao da entrada de user no sistema 
        private void bt_entrar_Click(object sender, EventArgs e)
        {
            string username = txt_usuario.Text;
            string senha = txt_senha.Text;

            // Verifica se os campos estão vazios
            if (username == "" || senha == "")
            {
                MessageBox.Show("Campos não podem ser vazios!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_usuario.Focus();
                return;
            }

            // Criação da query e passagem de parametros para os widgets do Menu Principal
            string sql = "SELECT * FROM tb_user WHERE username='"+username+"' AND senha_user='"+senha+"'";
            dt = Banco.dql(sql);
            if (dt.Rows.Count == 1)
            {
                form1.lbl_acesso.Text = dt.Rows[0].ItemArray[5].ToString();
                form1.lbl_nomeUsuario.Text = dt.Rows[0].Field<string>("nome_user");
                form1.pictureBox1.Image = Properties.Resources.led_green;

                Globais.nivel = int.Parse(dt.Rows[0].Field<Int64>("nivel_user").ToString());
                Globais.logado = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Funcao para fechar a Janela de Login
        private void bt_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
