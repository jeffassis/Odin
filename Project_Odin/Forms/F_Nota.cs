using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Project_Odin.Forms
{
    public partial class F_Nota : Form
    {
        string idSelecionado;
        DataTable dt = new DataTable();
        public F_Nota()
        {
            InitializeComponent();
        }

        private void F_Nota_Load(object sender, EventArgs e)
        {
            // Popular comboBox Aluno
            string queryAluno = @"
                SELECT
                    id_aluno,
                    nome_aluno
                FROM
                    tb_aluno
                ORDER BY
                    nome_aluno
            ";
            cb_aluno.Items.Clear();
            cb_aluno.DataSource = Banco.dql(queryAluno);
            cb_aluno.DisplayMember = "nome_aluno";
            cb_aluno.ValueMember = "id_aluno";

            // Popular comboBox Disciplina
            string queryDisc = @"
                SELECT
                    id_disciplina,
                    nome
                FROM
                    tb_disciplina
                ORDER BY
                    nome
            ";
            cb_disciplina.Items.Clear();
            cb_disciplina.DataSource = Banco.dql(queryDisc);
            cb_disciplina.DisplayMember = "nome";
            cb_disciplina.ValueMember = "id_disciplina";

            // Popular comboBox Bimestre
            string queryBimestre = @"
                SELECT
                    id_bimestre,
                    nome_bimestre
                FROM
                    tb_bimestre
                ORDER BY
                    id_bimestre
            ";
            cb_bimestre.Items.Clear();
            cb_bimestre.DataSource = Banco.dql(queryBimestre);
            cb_bimestre.DisplayMember = "nome_bimestre";
            cb_bimestre.ValueMember = "id_bimestre";
        }

        // Popula o DataGridView com aluno pesquisado no cb_aluno
        private void BuscarNome()
        {
            DataTable dt = new DataTable();
            var vcon = Banco.ConexaoBanco();
            var cmd = vcon.CreateCommand();
            string sql = @"SELECT
                    tbn.id as 'ID',
                    tba.nome_aluno as 'NOME',
                    tbb.nome_bimestre as 'BIMESTRE',
                    tbd.nome as 'DISCIPLINA',
                    tbn.tipo as 'TIPO',
                    tbn.nota as 'NOTA'
                FROM
                    tb_nota as tbn
                INNER JOIN
                    tb_aluno as tba ON tba.id_aluno = tbn.aluno_id
                INNER JOIN
                    tb_bimestre as tbb ON tbb.id_bimestre = tbn.bimestre_id
                INNER JOIN
                    tb_disciplina as tbd ON tbd.id_disciplina = tbn.disciplina_id
                WHERE
                    tba.nome_aluno
                LIKE
                    @nome
                ORDER BY
                    nome_aluno
            ";
            cmd = new SQLiteCommand(sql, vcon);
            cmd.Parameters.AddWithValue("@nome", cb_aluno.Text + "%");
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            vcon.Close();
            dgv_nota.DataSource = dt;

            dgv_nota.Columns[0].Width = 30;
            dgv_nota.Columns[1].Width = 180;
            dgv_nota.Columns[2].Width = 140;
            dgv_nota.Columns[3].Width = 80;
            dgv_nota.Columns[4].Width = 90;
            dgv_nota.Columns[5].Width = 60;
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            cb_aluno.SelectedIndex= -1;
            cb_disciplina.SelectedIndex = -1;
            cb_bimestre.SelectedIndex = -1;
            cb_tipoNota.SelectedIndex = -1;
            txt_nota.Clear();
            cb_aluno.Focus();
            bt_save.Enabled = true;
            bt_update.Enabled = false;
            bt_delete.Enabled = false;
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            // Verifica se está vazio
            if (cb_aluno.Text == "" || txt_nota.Text == "" || cb_disciplina.Text == "")
            {
                MessageBox.Show("Os campos não podem ser vazios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_aluno.Focus();
                return;
            }
            // Verifica se o username já existe
            string addNota = "";
            string verificaNota = @"
                SELECT 
                    aluno_id
                FROM
                    tb_nota 
                WHERE
                    aluno_id='"+cb_aluno.SelectedValue+"' and disciplina_id="+cb_disciplina.SelectedValue+" and bimestre_id="+cb_bimestre.SelectedValue;
            dt = Banco.dql(verificaNota);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Nota já Lançada!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                addNota = @"INSERT INTO tb_nota (nota, tipo, bimestre_id, aluno_id, disciplina_id) 
                VALUES("+txt_nota.Text+", '"+cb_tipoNota.Text+"', "+cb_bimestre.SelectedValue+", "+cb_aluno.SelectedValue+", "+cb_disciplina.SelectedValue+")";
                MessageBox.Show("Nota Lançada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Banco.dml(addNota);
            // Atualiza novamente o DGV
            addNota = @"SELECT
                    tbn.id as 'ID',
                    tba.nome_aluno as 'NOME',
                    tbb.nome_bimestre as 'BIMESTRE',
                    tbd.nome as 'DISCIPLINA',
                    tbn.tipo as 'TIPO',
                    tbn.nota as 'NOTA'
                FROM
                    tb_nota as tbn
                INNER JOIN
                    tb_aluno as tba ON tba.id_aluno = tbn.aluno_id
                INNER JOIN
                    tb_bimestre as tbb ON tbb.id_bimestre = tbn.bimestre_id
                INNER JOIN
                    tb_disciplina as tbd ON tbd.id_disciplina = tbn.disciplina_id
                ORDER BY
                    nome_aluno";
            dgv_nota.DataSource = Banco.dql(addNota);
            Limpar();
            bt_save.Enabled = false;
            bt_delete.Enabled = false;
            bt_update.Enabled = false;
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            // Verifica se está vazio
            string addAtualiza;
            if (cb_aluno.Text == "" || txt_nota.Text == "" || cb_disciplina.Text == "")
            {
                MessageBox.Show("Os campos não podem ser vazios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_aluno.Focus();
                return;
            }
            else
            {
                addAtualiza = @"
                    UPDATE tb_nota SET
                        nota=" + txt_nota.Text + ", tipo='" + cb_tipoNota.Text + "', bimestre_id=" + cb_bimestre.SelectedValue + "," +
                        " aluno_id=" + cb_aluno.SelectedValue + ", disciplina_id=" + cb_disciplina.SelectedValue + " WHERE id=" + idSelecionado;
                MessageBox.Show("Nota Lançada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Banco.dml(addAtualiza);
            // Atualiza novamente o DGV
            addAtualiza = @"SELECT
                    tbn.id as 'ID',
                    tba.nome_aluno as 'NOME',
                    tbb.nome_bimestre as 'BIMESTRE',
                    tbd.nome as 'DISCIPLINA',
                    tbn.tipo as 'TIPO',
                    tbn.nota as 'NOTA'
                FROM
                    tb_nota as tbn
                INNER JOIN
                    tb_aluno as tba ON tba.id_aluno = tbn.aluno_id
                INNER JOIN
                    tb_bimestre as tbb ON tbb.id_bimestre = tbn.bimestre_id
                INNER JOIN
                    tb_disciplina as tbd ON tbd.id_disciplina = tbn.disciplina_id
                ORDER BY
                    nome_aluno";
            dgv_nota.DataSource = Banco.dql(addAtualiza);
            Limpar();
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
                string vquery = "DELETE FROM tb_nota WHERE id=" + idSelecionado;
                Banco.dml(vquery);
                dgv_nota.Rows.Remove(dgv_nota.CurrentRow);


                cb_aluno.SelectedIndex = -1;
                txt_nota.Clear();
                cb_disciplina.SelectedIndex = -1;
                cb_bimestre.SelectedIndex = -1;
                cb_tipoNota.SelectedIndex = -1;
                cb_aluno.Focus();
                Limpar();
                bt_save.Enabled = false;
            }
        }

        private void dgv_nota_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;
            if (contlinhas > 0)
            {
                idSelecionado = dgv_nota.Rows[dgv_nota.SelectedRows[0].Index].Cells[0].Value.ToString();
                string query = @"
                    SELECT
                        tba.nome_aluno,
                        tbn.disciplina_id,
                        tbn.bimestre_id,
                        tbn.tipo,
                        tbn.nota
                    FROM
                        tb_nota as tbn
                    INNER JOIN
                        tb_aluno as tba ON tba.id_aluno=tbn.aluno_id
                    WHERE
                        tbn.id=" + idSelecionado;
                DataTable dt = Banco.dql(query);
                cb_aluno.Text = dt.Rows[0].Field<string>("nome_aluno");
                cb_disciplina.SelectedValue = dt.Rows[0].Field<Int64>("disciplina_id");
                cb_bimestre.SelectedValue = dt.Rows[0].Field<Int64>("bimestre_id");
                cb_tipoNota.Text = dt.Rows[0].Field<string>("tipo");
                txt_nota.Text = dt.Rows[0].Field<Int64>("nota").ToString();

                bt_delete.Enabled = true;
                bt_update.Enabled = true;
                bt_save.Enabled = false;
            }
        }

        private void cb_aluno_TextChanged(object sender, EventArgs e)
        {
            BuscarNome();
        }

        private void Limpar()
        {
            cb_aluno.SelectedIndex= -1;
            cb_disciplina.SelectedIndex= -1;
            cb_bimestre.SelectedIndex= -1;
            cb_tipoNota.SelectedIndex= -1;
            txt_nota.Clear();
        }
    }
}
