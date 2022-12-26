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
    public partial class F_Usuario : Form
    {
        string vqueryDGV = "";
        string idSelecionado = "";
        DataTable dt = new DataTable();
        public F_Usuario()
        {
            InitializeComponent();
        }

        private void F_Usuario_Load(object sender, EventArgs e)
        {
            vqueryDGV = @"SELECT id_user as 'ID', nome_user as 'NOME', status_user as 'STATUS', nivel_user as 'NIVEL' FROM tb_user ORDER BY nome_user";
            dgv_user.DataSource = Banco.dql(vqueryDGV);
            dgv_user.Columns[0].Width = 30;
            dgv_user.Columns[1].Width = 170;
            dgv_user.Columns[2].Width = 60;
            dgv_user.Columns[3].Width = 40;
            //idSelecionado = dgv_user.Rows[0].Cells[0].Value.ToString();
        }

        private void dgv_aluno_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_usuario.Clear();
            txt_senha.Clear();
            cb_status.Text = "";
            n_nivel.Value = 0;
            txt_nome.Focus();
            bt_save.Enabled = true;
            bt_update.Enabled = false;
            bt_delete.Enabled = false;
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            // Verifica se está vazio
            if (txt_nome.Text == "" || txt_senha.Text == "" || cb_status.Text == "")
            {
                MessageBox.Show("Os campos não podem ser vazios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nome.Focus();
                return;
            }
            // Verifica se o username já existe
            string addUser = "";
            string verificaUser = "SELECT username FROM tb_user WHERE username='"+txt_usuario.Text+"'";
            dt = Banco.dql(verificaUser);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Username já existe!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                addUser = @"INSERT INTO tb_user (nome_user, username, senha_user, status_user, nivel_user) 
                            VALUES('"+txt_nome.Text+"', '"+txt_usuario.Text+"', '"+txt_senha.Text+"', '"+cb_status.Text+"', "+n_nivel.Value+")";
                MessageBox.Show("Dados inseridos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Banco.dml(addUser);
            // Atualiza novamente o DGV
            addUser = @"SELECT id_user as 'ID', nome_user as 'NOME',status_user as 'STATUS', nivel_user as 'NIVEL' FROM tb_user
                        ORDER BY nome_user";
            dgv_user.DataSource = Banco.dql(addUser);
            bt_save.Enabled = false;
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            // Verifica se está vazio
            string nome = txt_nome.Text;
            string senha = txt_senha.Text;
            string addUser = "";
            if (nome == "" || senha == "" || cb_status.Text == "")
            {
                MessageBox.Show("Os campos não podem ser vazios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nome.Focus();
                return;
            }            
            else
            {
                addUser = @"UPDATE tb_user SET nome_user='"+txt_nome.Text+"', username='"+txt_usuario.Text+"', senha_user='"+txt_senha.Text+"', status_user='"+cb_status.Text+"'" +
                    ", nivel_user="+n_nivel.Value+" WHERE id_user="+idSelecionado;
                MessageBox.Show("Dados atualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Banco.dml(addUser);
            // Atualiza novamente o DGV
            addUser = @"SELECT id_user as 'ID', nome_user as 'NOME',status_user as 'STATUS', nivel_user as 'NIVEL' FROM tb_user
                        ORDER BY nome_user";
            dgv_user.DataSource = Banco.dql(addUser);
            bt_save.Enabled = false;
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            // Cria um Dialogo para confirmar a exclusao de dados
            DialogResult res = MessageBox.Show("Confirma exclusão?", "Excluir?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string vquery = "DELETE FROM tb_user WHERE id_user=" + idSelecionado;
                Banco.dml(vquery);
                dgv_user.Rows.Remove(dgv_user.CurrentRow);

                txt_nome.Clear();
                txt_usuario.Clear();
                txt_senha.Clear();
                cb_status.Text = "";
                n_nivel.Value = 0;
                txt_nome.Focus();
                bt_save.Enabled = false;
            }
        }

        private void dgv_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if (contlinhas > 0)
            {
                idSelecionado = dgv_user.Rows[dgv_user.SelectedRows[0].Index].Cells[0].Value.ToString();
                string query = @"SELECT nome_user, username, senha_user, status_user, nivel_user FROM tb_user WHERE id_user=" + idSelecionado;
                DataTable dt = Banco.dql(query);
                txt_nome.Text = dt.Rows[0].Field<string>("nome_user");
                txt_usuario.Text = dt.Rows[0].Field<string>("username");
                txt_senha.Text = dt.Rows[0].Field<string>("senha_user");
                cb_status.Text = dt.Rows[0].Field<string>("status_user");
                n_nivel.Value = dt.Rows[0].Field<Int64>("nivel_user");

                dgv_user.Columns[1].Width = 170;

                bt_save.Enabled = false;
                bt_update.Enabled = true;
                bt_delete.Enabled = true;
            }
        }
    }
}
