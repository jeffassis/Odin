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
    public partial class F_Responsavel : Form
    {
        string vqueryDGV = "";
        string idSelecionado = "";
        DataTable dt = new DataTable();
        public F_Responsavel()
        {
            InitializeComponent();
        }

        private void F_Responsavel_Load(object sender, EventArgs e)
        {
            vqueryDGV = @"SELECT id_responsavel as 'ID', nome as 'NOME COMPLETO', rg as 'RG', cpf as 'CPF', telefone as 'TELEFONE', parentesco as 'PARENTESCO' FROM tb_responsavel
                        ORDER BY nome";
            dgv_responsavel.DataSource = Banco.dql(vqueryDGV);
            dgv_responsavel.Columns[0].Width= 30;
            dgv_responsavel.Columns[1].Width= 160;
            dgv_responsavel.Columns[2].Width= 80;
            dgv_responsavel.Columns[3].Width= 92;
            dgv_responsavel.Columns[4].Width= 95;
            dgv_responsavel.Columns[5].Width= 90;
            idSelecionado = dgv_responsavel.Rows[0].Cells[0].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_rg.Clear();
            mtb_cpf.Clear();
            mtb_telefone.Clear();
            cb_parentesco.SelectedIndex= -1;
            txt_nome.Focus();
            bt_save.Enabled=true;
            bt_delete.Enabled=false;
            bt_update.Enabled=false;
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            // Verifica se está vazio
            if (txt_nome.Text == "" || txt_rg.Text == "" || mtb_cpf.Text == "" || cb_parentesco.Text == "" || mtb_telefone.Text == "")
            {
                MessageBox.Show("Os campos não podem ser vazios","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nome.Focus();
                return;
            }
            // Verifica se o responsavel já existe
            string addResp = "";
            string verificaResp = "SELECT nome FROM tb_responsavel WHERE nome='" + txt_nome.Text + "'";
            dt = Banco.dql(verificaResp);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Responsável já existe!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                addResp = "INSERT INTO tb_responsavel (nome, rg, cpf, telefone, parentesco) " +
                    "VALUES('"+txt_nome.Text+"', '"+txt_rg.Text+"', '"+mtb_cpf.Text+"', '"+mtb_telefone.Text+"', '"+cb_parentesco.Text+"')";
                MessageBox.Show("Dados inseridos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Banco.dml(addResp);
            // Atualiza novamente o DGV
            addResp = @"SELECT id_responsavel as 'ID', nome as 'NOME COMPLETO', rg as 'RG', cpf as 'CPF', telefone as 'TELEFONE', parentesco as 'PARENTESCO'
                    FROM tb_responsavel ORDER BY nome";
            dgv_responsavel.DataSource = Banco.dql(addResp);
            bt_save.Enabled=false;
            bt_update.Enabled = false;
            bt_delete.Enabled = false;
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            // Verifica se está vazio
            string addResp = "";
            if (txt_nome.Text == "" || txt_rg.Text == "" || mtb_cpf.Text == "" || cb_parentesco.Text == "" || mtb_telefone.Text == "")
            {
                MessageBox.Show("Os campos não podem ser vazios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nome.Focus();
                return;
            }            
            else
            {
                addResp = @"UPDATE tb_responsavel SET nome='" + txt_nome.Text + "', rg='" + txt_rg.Text + "', cpf='" + mtb_cpf.Text + "', telefone='" + mtb_telefone.Text
                                + "', parentesco='" + cb_parentesco.Text + "' WHERE id_responsavel=" + idSelecionado;
                MessageBox.Show("Dados atualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Banco.dml(addResp);
            // Atualiza novamente o DGV
            addResp = @"SELECT id_responsavel as 'ID', nome as 'NOME COMPLETO', rg as 'RG', cpf as 'CPF', telefone as 'TELEFONE', parentesco as 'PARENTESCO'
                    FROM tb_responsavel ORDER BY nome";
            dgv_responsavel.DataSource = Banco.dql(addResp);
            bt_save.Enabled = false;
            bt_update.Enabled = false;
            bt_delete.Enabled = false;
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            // Cria um Dialogo para confirmar a exclusao de dados
            DialogResult res = MessageBox.Show("Confirma exclusão?", "Excluir?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string vquery = "DELETE FROM tb_responsavel WHERE id_responsavel=" + idSelecionado;
                Banco.dml(vquery);
                dgv_responsavel.Rows.Remove(dgv_responsavel.CurrentRow);
            }
            bt_save.Enabled = false;
            bt_update.Enabled = false;
            bt_delete.Enabled = false;
        }

        private void dgv_responsavel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if (contlinhas > 0)
            {
                idSelecionado = dgv_responsavel.Rows[dgv_responsavel.SelectedRows[0].Index].Cells[0].Value.ToString();
                string query = @"SELECT nome, rg, cpf, telefone, parentesco FROM tb_responsavel WHERE id_responsavel=" + idSelecionado;
                DataTable dt = Banco.dql(query);
                txt_nome.Text = dt.Rows[0].Field<string>("nome");
                txt_rg.Text = dt.Rows[0].Field<string>("rg");
                mtb_cpf.Text = dt.Rows[0].Field<string>("cpf");
                mtb_telefone.Text = dt.Rows[0].Field<string>("telefone");
                cb_parentesco.Text = dt.Rows[0].Field<string>("parentesco");

                dgv_responsavel.Columns[1].Width = 160;
                bt_delete.Enabled = true;
                bt_update.Enabled = true;
                bt_save.Enabled = false;
            }
        }
    }
}
