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
        string vqueryDGV;
        DataTable dt = new DataTable();
        public F_Nota()
        {
            InitializeComponent();
        }

        private void F_Nota_Load(object sender, EventArgs e)
        {
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
                    nome_bimestre
            ";
            cb_bimestre.Items.Clear();
            cb_bimestre.DataSource = Banco.dql(queryBimestre);
            cb_bimestre.DisplayMember = "nome_bimestre";
            cb_bimestre.ValueMember = "id_bimestre";
        }

        // Popula o DataGridView com aluno pesquisado no txt_nome
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
            cmd.Parameters.AddWithValue("@nome", txt_nome.Text + "%");
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            vcon.Close();
            dgv_nota.DataSource = dt;

            dgv_nota.Columns[0].Width= 30;
            dgv_nota.Columns[1].Width= 170;
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
            BuscarNome();
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            cb_disciplina.SelectedIndex = -1;
            cb_bimestre.SelectedIndex = -1;
            cb_tipoNota.SelectedIndex = -1;
            txt_nota.Clear();
            txt_nome.Focus();
            bt_save.Enabled = true;
            bt_update.Enabled = false;
            bt_delete.Enabled = false;
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            // Verifica se está vazio
            if (txt_nome.Text == "" || txt_nota.Text == "" || cb_disciplina.Text == "")
            {
                MessageBox.Show("Os campos não podem ser vazios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nome.Focus();
                return;
            }
            // Verifica se o username já existe
            string addAluno = "";
            string verificaNota = @"
                SELECT 
                    aluno_id
                FROM
                    tb_nota as tbn
                inner join
                    tb_aluno as tba ON id_aluno=aluno_id  
                WHERE
                    tba.nome_aluno='"+txt_nome.Text+"' and tbn.disciplina_id="+cb_disciplina.SelectedValue+" and tbn.bimestre_id="+cb_bimestre.SelectedValue+" and tbn.nota="+txt_nota.Text;
            dt = Banco.dql(verificaNota);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Nota já Lançada!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                addAluno = @"INSERT INTO tb_user (nota, tipo, bimestre_id, aluno_id, disciplina_id) 
                            VALUES("+txt_nota.Text+", '"+cb_tipoNota.Text+"', "+cb_bimestre.SelectedValue+", "+txt_nome.Text+", "+cb_disciplina.SelectedValue+")";
            }
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

                txt_nome.Clear();
                txt_nota.Clear();
                cb_disciplina.SelectedIndex = -1;
                cb_bimestre.SelectedIndex = -1;
                cb_tipoNota.SelectedIndex = -1;
                txt_nome.Focus();
                bt_save.Enabled = false;
        }   }

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
                txt_nome.Text = dt.Rows[0].Field<string>("nome_aluno");
                cb_disciplina.SelectedValue = dt.Rows[0].Field<Int64>("disciplina_id");
                cb_bimestre.SelectedValue = dt.Rows[0].Field<Int64>("bimestre_id");
                cb_tipoNota.Text = dt.Rows[0].Field<string>("tipo");
                txt_nota.Text = dt.Rows[0].Field<Int64>("nota").ToString();

                bt_delete.Enabled = true;
                bt_save.Enabled = false;
            }
        }
    }
}
