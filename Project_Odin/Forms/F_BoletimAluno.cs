using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Odin.Forms
{
    public partial class F_BoletimAluno : Form
    {
        DataTable dt = new DataTable();
        public F_BoletimAluno()
        {
            InitializeComponent();
        }

        private void F_BoletimAluno_Load(object sender, EventArgs e)
        {
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

        }

        private void BuscarNome()
        {
            DataTable dt = new DataTable();
            var vcon = Banco.ConexaoBanco();
            var cmd = vcon.CreateCommand();
            string sql = @"
                SELECT
                    tbd.nome as 'DISCIPLINA',
                    tbb.nome_bimestre as 'BIMESTRE',
                        (select
                            nota
                         from
                            tb_nota as n1
                         where
                            n1.aluno_id=tba.id_aluno
                         and
                            n1.disciplina_id=tbd.id_disciplina
                         and
                            n1.bimestre_id=tbb.id_bimestre) as 'NOTA'
                from
                    tb_nota as tbn
                INNER JOIN
                    tb_aluno as tba ON tba.id_aluno=aluno_id
                INNER JOIN
                    tb_disciplina as tbd ON tbd.id_disciplina=disciplina_id
                INNER JOIN
                    tb_bimestre as tbb ON tbb.id_bimestre=bimestre_id
                WHERE
                    tbn.aluno_id=@id_aluno
                and
                    tbn.bimestre_id=@bimestre
                Group by
                    tbd.nome,
                    tba.id_aluno,
                    tbd.id_disciplina,
                    tbn.bimestre_id,
                    tbb.nome_bimestre
            ";
            cmd = new SQLiteCommand(sql, vcon);
            cmd.Parameters.AddWithValue("@id_aluno", cb_aluno.SelectedValue);
            cmd.Parameters.AddWithValue("@bimestre", cb_bimestre.SelectedValue);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            vcon.Close();
            dgv_boletimAluno.DataSource = dt;

            dgv_boletimAluno.Columns[0].Width = 150;
            dgv_boletimAluno.Columns[1].Width = 110;
            dgv_boletimAluno.Columns[2].Width = 52;
        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
            BuscarNome();
        }
    }
}
