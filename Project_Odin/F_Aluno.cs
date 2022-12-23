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
    public partial class F_Aluno : Form
    {
        string queryDGV = "";
        string idSelecionado = "";
        public F_Aluno()
        {
            InitializeComponent();
        }

        private void F_Aluno_Load(object sender, EventArgs e)
        {
            // Popular comboBox Responsavel
            string queryResponsavel = @"
                SELECT
                    id_responsavel,
                    nome
                FROM
                    tb_responsavel
                ORDER BY
                    id_responsavel
            ";
            cb_responsavel.Items.Clear();
            cb_responsavel.DataSource = Banco.dql(queryResponsavel);
            cb_responsavel.DisplayMember = "nome";
            cb_responsavel.ValueMember = "id_responsavel";

            queryDGV = @"select 
                            id_aluno as 'ID',
                            nome_aluno as 'Aluno',
                            endereco_aluno as 'Endereço',
                            data_nasc as 'Nascimento',
                            telefone_aluno as 'Telefone'
                          from
                            tb_aluno
            ";
            dgv_aluno.DataSource = Banco.dql(queryDGV);
            dgv_aluno.Columns[0].Width = 30;
            dgv_aluno.Columns[1].Width = 180;
            dgv_aluno.Columns[2].Width = 160;
            dgv_aluno.Columns[3].Width = 90;
            dgv_aluno.Columns[4].Width = 90;

            idSelecionado = dgv_aluno.Rows[0].Cells[0].Value.ToString();
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            // Limpa os campos e habilita salvar
            txt_nome.Clear();
            txt_email.Clear();
            txt_endereco.Clear();
            txt_bairro.Clear();
            mtb_cep.Clear();
            date_nascimento.Value = DateTime.Today;
            mtb_telefone.Clear();
            cb_sangue.SelectedIndex= -1;
            cb_responsavel.SelectedIndex= -1;
            txt_nome.Focus();
            bt_save.Enabled = true;
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            // Query para inserir dados
            string query = "";
            if (txt_nome.Text == "" || cb_responsavel.Text == "")
            {
                MessageBox.Show("Os campos não podem ser vazios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                query = @"
                    INSERT INTO
                        tb_aluno
                            (nome_aluno, email_aluno, endereco_aluno, bairro_aluno, cep_aluno, data_nasc, telefone_aluno, sangue_aluno, responsavel_id)
                    VALUES('"+txt_nome.Text+"', '"+txt_email.Text+"', '"+txt_endereco.Text+"', '"+txt_bairro.Text+"', '"+mtb_cep.Text+"', '"+date_nascimento.Text+"', '"+mtb_telefone.Text+"', " +
                    "'"+cb_sangue.Text+"', "+cb_responsavel.SelectedValue+")";
                MessageBox.Show("Dados inseridos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Banco.dml(query);
            // Atualiza novamente o DGV
            queryDGV = @"select 
                            id_aluno as 'ID',
                            nome_aluno as 'Aluno',
                            endereco_aluno as 'Endereço',
                            data_nasc as 'Nascimento',
                            telefone_aluno as 'Telefone'
                          from
                            tb_aluno";
            dgv_aluno.DataSource = Banco.dql(queryDGV);
            bt_save.Enabled = false;
        }

        private void dgv_aluno_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if (contlinhas > 0)
            {
                idSelecionado = dgv_aluno.Rows[dgv_aluno.SelectedRows[0].Index].Cells[0].Value.ToString();
                string query = @"
                        SELECT
                            nome_aluno,
                            email_aluno,
                            endereco_aluno, 
                            bairro_aluno, 
                            cep_aluno, 
                            data_nasc, 
                            telefone_aluno, 
                            sangue_aluno,
                            responsavel_id
                        FROM 
                            tb_aluno                           
                        WHERE id_aluno=" + idSelecionado;
                DataTable dt = Banco.dql(query);
                txt_nome.Text = dt.Rows[0].Field<string>("nome_aluno");
                txt_email.Text = dt.Rows[0].Field<string>("email_aluno");
                txt_endereco.Text = dt.Rows[0].Field<string>("endereco_aluno");
                txt_bairro.Text = dt.Rows[0].Field<string>("bairro_aluno");
                mtb_cep.Text = dt.Rows[0].Field<string>("cep_aluno");
                date_nascimento.Text = dt.Rows[0].Field<string>("data_nasc");
                mtb_telefone.Text = dt.Rows[0].Field<string>("telefone_aluno");
                cb_sangue.Text = dt.Rows[0].Field<string>("sangue_aluno");                
                cb_responsavel.SelectedValue = dt.Rows[0].Field<Int64>("responsavel_id").ToString();                

                // Para manter o espaço na tabela
                dgv_aluno.Columns[1].Width = 180;
            }
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            // Query para atualizar dados
            string query = "";
            if (txt_nome.Text == "" || cb_responsavel.Text == "")
            {
                MessageBox.Show("Os campos não podem ser vazios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult res = MessageBox.Show("Confirma Atualização?", "Atualizar dados?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    query = @"
                        UPDATE tb_aluno SET
                            nome_aluno='" + txt_nome.Text + "', email_aluno='"+txt_email.Text+"', endereco_aluno='"+txt_endereco.Text+"', bairro_aluno='"+txt_bairro.Text+"'," +
                            " cep_aluno='"+mtb_cep.Text+"', data_nasc='"+date_nascimento.Text+"', telefone_aluno='"+mtb_telefone.Text+"', sangue_aluno='"+cb_sangue.Text+"' " +
                            ", responsavel_id="+cb_responsavel.SelectedValue +" WHERE id_aluno=" + idSelecionado;
                    MessageBox.Show("Dados atualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            Banco.dml(query);
            // Atualiza novamente o DGV
            query = @"select 
                            id_aluno as 'ID',
                            nome_aluno as 'Aluno',
                            endereco_aluno as 'Endereço',
                            data_nasc as 'Nascimento',
                            telefone_aluno as 'Telefone'
                          from
                            tb_aluno";
            dgv_aluno.DataSource = Banco.dql(query);
            bt_save.Enabled = false;
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            // Cria um Dialogo para confirmar a exclusao de dados
            DialogResult res = MessageBox.Show("Confirma exclusão?", "Excluir?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string vquery = "DELETE FROM tb_aluno WHERE id_aluno=" + idSelecionado;
                Banco.dml(vquery);
                dgv_aluno.Rows.Remove(dgv_aluno.CurrentRow);

                // Limpa os campos e habilita salvar
                txt_nome.Clear();
                txt_email.Clear();
                txt_endereco.Clear();
                txt_bairro.Clear();
                mtb_cep.Clear();
                date_nascimento.Value = DateTime.Today;
                mtb_telefone.Clear();
                cb_sangue.SelectedIndex = -1;
                cb_responsavel.SelectedIndex = -1;
                txt_nome.Focus();
            }
        }
    }
}
