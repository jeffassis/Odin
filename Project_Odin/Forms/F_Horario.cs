using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Odin.Forms
{
    public partial class F_Horario : Form
    {
        string queryDGV = "";
        string idSelecionado = "";
        DataTable dt = new DataTable();
        public F_Horario()
        {
            InitializeComponent();
        }

        private void F_Horario_Load(object sender, EventArgs e)
        {
            queryDGV = @"select 
                            id_horario as 'ID',
                            descricao_horario as 'HORARIO',
                            dia_semana as 'DIA SEMANA'
                          from
                            tb_horario
            ";
            dgv_horario.DataSource = Banco.dql(queryDGV);
            dgv_horario.Columns[0].Width = 30;
            dgv_horario.Columns[1].Width = 130;
            dgv_horario.Columns[2].Width = 180;

            //idSelecionado = dgv_horario.Rows[0].Cells[0].Value.ToString();
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            mtb_descricao.Clear();
            cb_diaSemana.SelectedIndex= -1;
            mtb_descricao.Enabled= true;
            cb_diaSemana.Enabled= true;
            bt_update.Enabled = false;
            bt_delete.Enabled = false;
            bt_save.Enabled = true;
            mtb_descricao.Focus();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            // Verifica se está vazio
            if (mtb_descricao.Text == "" || cb_diaSemana.Text == "")
            {
                MessageBox.Show("Os campos não podem ser vazios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtb_descricao.Focus();
                return;
            }
            // Verifica se o Horario já existe
            string VerificaHora = "SELECT descricao_horario FROM tb_horario WHERE descricao_horario='" + mtb_descricao.Text + "' and dia_semana='"+cb_diaSemana.Text+"'";
            dt = Banco.dql(VerificaHora);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Horário já cadastrado!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string addHora = String.Format(@"
                        INSERT INTO
                            tb_horario
                            (descricao_horario, dia_semana)
                        VALUES('{0}','{1}')", mtb_descricao.Text, cb_diaSemana.Text);
                MessageBox.Show("Dados inseridos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Banco.dml(addHora);
            }
            // Atualiza novamente o DGV
            queryDGV = @"select 
                            id_horario as 'ID',
                            descricao_horario as 'HORARIO',
                            dia_semana as 'DIA SEMANA'
                          from
                            tb_horario";
            dgv_horario.DataSource = Banco.dql(queryDGV);
            
            txt_id.Clear();
            cb_diaSemana.SelectedIndex= -1;
            mtb_descricao.Clear();
            mtb_descricao.Enabled= false;
            cb_diaSemana.Enabled= false;
            bt_save.Enabled = false;
            bt_delete.Enabled = false;
            bt_update.Enabled = false;
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            // Verifica se está vazio
            if (mtb_descricao.Text == "" || cb_diaSemana.Text == "")
            {
                MessageBox.Show("Os campos não podem ser vazios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtb_descricao.Focus();
                return;
            }
            else
            {
                string addHora = String.Format(@"
                        UPDATE
                            tb_horario
                        SET
                            descricao_horario='{0}',
                            dia_semana='{1}'
                        WHERE
                            id_horario={2}
                ", mtb_descricao.Text, cb_diaSemana.Text, txt_id.Text);
                MessageBox.Show("Dados inseridos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Banco.dml(addHora);
            }
            // Atualiza novamente o DGV
            queryDGV = @"select 
                            id_horario as 'ID',
                            descricao_horario as 'HORARIO',
                            dia_semana as 'DIA SEMANA'
                          from
                            tb_horario";
            dgv_horario.DataSource = Banco.dql(queryDGV);

            txt_id.Clear();
            cb_diaSemana.SelectedIndex = -1;
            mtb_descricao.Clear();
            mtb_descricao.Enabled = false;
            cb_diaSemana.Enabled = false;
            bt_save.Enabled = false;
            bt_delete.Enabled = false;
            bt_update.Enabled = false;
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            // Cria um Dialogo para confirmar a exclusao de dados
            DialogResult res = MessageBox.Show("Confirma exclusão?", "Excluir?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string vquery = "DELETE FROM tb_horario WHERE id_horario=" + idSelecionado;
                Banco.dml(vquery);
                dgv_horario.Rows.Remove(dgv_horario.CurrentRow);
            }
            bt_save.Enabled = false;
            bt_delete.Enabled = false;
            bt_update.Enabled = false;
            txt_id.Clear();
            mtb_descricao.Clear();
            cb_diaSemana.SelectedIndex = -1;
        }

        private void dgv_horario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if (contlinhas > 0)
            {
                idSelecionado = dgv_horario.Rows[dgv_horario.SelectedRows[0].Index].Cells[0].Value.ToString();
                string query = @"
                        SELECT
                            *
                        FROM 
                            tb_horario                           
                        WHERE
                            id_horario=" + idSelecionado;
                DataTable dt = Banco.dql(query);
                txt_id.Text = dt.Rows[0].Field<Int64>("id_horario").ToString();
                mtb_descricao.Text = dt.Rows[0].Field<string>("descricao_horario");
                cb_diaSemana.Text = dt.Rows[0].Field<string>("dia_Semana");

                bt_delete.Enabled = true;
                bt_update.Enabled = true;
                bt_save.Enabled = false;
                mtb_descricao.Enabled= true;
                cb_diaSemana.Enabled= true;

                // Para manter o espaço na tabela
                dgv_horario.Columns[1].Width = 130;
            }
        }
    }
}
