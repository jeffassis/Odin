namespace Project_Odin.Forms
{
    partial class F_Nota
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_nota = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_novo = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nota = new System.Windows.Forms.TextBox();
            this.cb_bimestre = new System.Windows.Forms.ComboBox();
            this.cb_disciplina = new System.Windows.Forms.ComboBox();
            this.cb_tipoNota = new System.Windows.Forms.ComboBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nota)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_nota
            // 
            this.dgv_nota.AllowUserToAddRows = false;
            this.dgv_nota.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_nota.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_nota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nota.EnableHeadersVisualStyles = false;
            this.dgv_nota.Location = new System.Drawing.Point(13, 125);
            this.dgv_nota.MultiSelect = false;
            this.dgv_nota.Name = "dgv_nota";
            this.dgv_nota.ReadOnly = true;
            this.dgv_nota.RowHeadersVisible = false;
            this.dgv_nota.RowTemplate.Height = 25;
            this.dgv_nota.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_nota.Size = new System.Drawing.Size(615, 230);
            this.dgv_nota.TabIndex = 10;
            this.dgv_nota.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nota_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_fechar);
            this.panel1.Controls.Add(this.bt_delete);
            this.panel1.Controls.Add(this.bt_update);
            this.panel1.Controls.Add(this.bt_novo);
            this.panel1.Controls.Add(this.bt_save);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 374);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 48);
            this.panel1.TabIndex = 30;
            // 
            // bt_fechar
            // 
            this.bt_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_fechar.Image = global::Project_Odin.Properties.Resources.bt_fechar_24;
            this.bt_fechar.Location = new System.Drawing.Point(591, 3);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(36, 36);
            this.bt_fechar.TabIndex = 9;
            this.bt_fechar.UseVisualStyleBackColor = true;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_delete.Enabled = false;
            this.bt_delete.Image = global::Project_Odin.Properties.Resources.bt_delete;
            this.bt_delete.Location = new System.Drawing.Point(139, 3);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(36, 36);
            this.bt_delete.TabIndex = 8;
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_update
            // 
            this.bt_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_update.Enabled = false;
            this.bt_update.Image = global::Project_Odin.Properties.Resources.bt_update_24;
            this.bt_update.Location = new System.Drawing.Point(97, 3);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(36, 36);
            this.bt_update.TabIndex = 2;
            this.bt_update.UseVisualStyleBackColor = true;
            // 
            // bt_novo
            // 
            this.bt_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_novo.Image = global::Project_Odin.Properties.Resources.bt_novo_24;
            this.bt_novo.Location = new System.Drawing.Point(12, 3);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(36, 36);
            this.bt_novo.TabIndex = 0;
            this.bt_novo.UseVisualStyleBackColor = true;
            this.bt_novo.Click += new System.EventHandler(this.bt_novo_Click);
            // 
            // bt_save
            // 
            this.bt_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_save.Enabled = false;
            this.bt_save.Image = global::Project_Odin.Properties.Resources.bt_save_24;
            this.bt_save.Location = new System.Drawing.Point(54, 3);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(36, 36);
            this.bt_save.TabIndex = 1;
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Aluno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(139, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Bimestre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Disciplina:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(492, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Tipo de Nota:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(498, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 35;
            this.label5.Text = "Nota:";
            // 
            // txt_nota
            // 
            this.txt_nota.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nota.Location = new System.Drawing.Point(553, 90);
            this.txt_nota.Name = "txt_nota";
            this.txt_nota.Size = new System.Drawing.Size(74, 29);
            this.txt_nota.TabIndex = 36;
            // 
            // cb_bimestre
            // 
            this.cb_bimestre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_bimestre.FormattingEnabled = true;
            this.cb_bimestre.Location = new System.Drawing.Point(139, 92);
            this.cb_bimestre.Name = "cb_bimestre";
            this.cb_bimestre.Size = new System.Drawing.Size(174, 29);
            this.cb_bimestre.TabIndex = 38;
            // 
            // cb_disciplina
            // 
            this.cb_disciplina.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_disciplina.FormattingEnabled = true;
            this.cb_disciplina.Location = new System.Drawing.Point(12, 92);
            this.cb_disciplina.Name = "cb_disciplina";
            this.cb_disciplina.Size = new System.Drawing.Size(121, 29);
            this.cb_disciplina.TabIndex = 39;
            // 
            // cb_tipoNota
            // 
            this.cb_tipoNota.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_tipoNota.FormattingEnabled = true;
            this.cb_tipoNota.Items.AddRange(new object[] {
            "Provas",
            "Recuperação"});
            this.cb_tipoNota.Location = new System.Drawing.Point(492, 37);
            this.cb_tipoNota.Name = "cb_tipoNota";
            this.cb_tipoNota.Size = new System.Drawing.Size(135, 29);
            this.cb_tipoNota.TabIndex = 40;
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nome.Location = new System.Drawing.Point(12, 37);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(301, 25);
            this.txt_nome.TabIndex = 41;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // F_Nota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 422);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.cb_tipoNota);
            this.Controls.Add(this.cb_disciplina);
            this.Controls.Add(this.cb_bimestre);
            this.Controls.Add(this.txt_nota);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_nota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Nota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançamento de Notas";
            this.Load += new System.EventHandler(this.F_Nota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nota)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_nota;
        private Panel panel1;
        private Button bt_fechar;
        private Button bt_delete;
        private Button bt_update;
        private Button bt_novo;
        private Button bt_save;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_nota;
        private ComboBox cb_bimestre;
        private ComboBox cb_disciplina;
        private ComboBox cb_tipoNota;
        private TextBox txt_nome;
    }
}