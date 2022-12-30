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
    public partial class F_BoletimFinal : Form
    {
        public F_BoletimFinal()
        {
            InitializeComponent();
        }

        private void F_BoletimFinal_Load(object sender, EventArgs e)
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
        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
            BuscarNome();
        }

        private void BuscarNome()
        {
            DataTable dt = new DataTable();
            var vcon = Banco.ConexaoBanco();
            var cmd = vcon.CreateCommand();
            string sql = @"
                SELECT DISTINCT(tbd.nome) as 'DISCIPLINA',
                    (select AVG(nota) from tb_nota as n1 where n1.aluno_id=tba.id_aluno and n1.disciplina_id=tbd.id_disciplina and n1.bimestre_id=1) as 'BIMESTRE 1',
                    (select AVG(nota) from tb_nota as n1 where n1.aluno_id=tba.id_aluno and n1.disciplina_id=tbd.id_disciplina and n1.bimestre_id=2) as 'BIMESTRE 2',
                    (select AVG(nota) from tb_nota as n1 where n1.aluno_id=tba.id_aluno and n1.disciplina_id=tbd.id_disciplina and n1.bimestre_id=3) as 'BIMESTRE 3',
                    (select AVG(nota) from tb_nota as n1 where n1.aluno_id=tba.id_aluno and n1.disciplina_id=tbd.id_disciplina and n1.bimestre_id=4) as 'BIMESTRE 4',
                        ((select nota from tb_nota as n1 where n1.aluno_id=tba.id_aluno and n1.disciplina_id=tbd.id_disciplina and n1.bimestre_id=1) +
                        (select nota from tb_nota as n1 where n1.aluno_id=tba.id_aluno and n1.disciplina_id=tbd.id_disciplina and n1.bimestre_id=2) +
                        (select nota from tb_nota as n1 where n1.aluno_id=tba.id_aluno and n1.disciplina_id=tbd.id_disciplina and n1.bimestre_id=3) +
                        (select nota from tb_nota as n1 where n1.aluno_id=tba.id_aluno and n1.disciplina_id=tbd.id_disciplina and n1.bimestre_id=4))/4 as 'MÉDIA'
                FROM
                    tb_nota as tbn
                INNER JOIN
                    tb_aluno tba ON tba.id_aluno=tbn.aluno_id 
                INNER JOIN
                    tb_disciplina as tbd ON tbd.id_disciplina=tbn.disciplina_id 
                INNER JOIN
                    tb_bimestre as tbb ON tbb.id_bimestre=tbn.bimestre_id
                WHERE
                    tbn.aluno_id=@id_aluno
                GROUP BY
                    tbd.nome, tba.id_aluno,tbd.id_disciplina,tbn.bimestre_id
            ";
            cmd = new SQLiteCommand(sql, vcon);
            cmd.Parameters.AddWithValue("@id_aluno", cb_aluno.SelectedValue);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            vcon.Close();
            dgv_boletimFinal.DataSource = dt;

            dgv_boletimFinal.Columns[0].Width = 110;
            dgv_boletimFinal.Columns[1].Width = 93;
            dgv_boletimFinal.Columns[2].Width = 93;
            dgv_boletimFinal.Columns[3].Width = 93;
            dgv_boletimFinal.Columns[4].Width = 93;
            dgv_boletimFinal.Columns[5].Width = 70;
        }
    }
}
