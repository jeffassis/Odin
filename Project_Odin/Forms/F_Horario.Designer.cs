namespace Project_Odin.Forms
{
    partial class F_Horario
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
            this.dgv_horario = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_novo = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.mtb_descricao = new System.Windows.Forms.MaskedTextBox();
            this.cb_diaSemana = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horario)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_horario
            // 
            this.dgv_horario.AllowUserToAddRows = false;
            this.dgv_horario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_horario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_horario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_horario.EnableHeadersVisualStyles = false;
            this.dgv_horario.Location = new System.Drawing.Point(12, 96);
            this.dgv_horario.MultiSelect = false;
            this.dgv_horario.Name = "dgv_horario";
            this.dgv_horario.ReadOnly = true;
            this.dgv_horario.RowHeadersVisible = false;
            this.dgv_horario.RowTemplate.Height = 25;
            this.dgv_horario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_horario.Size = new System.Drawing.Size(355, 336);
            this.dgv_horario.TabIndex = 30;
            this.dgv_horario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_horario_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_fechar);
            this.panel1.Controls.Add(this.bt_delete);
            this.panel1.Controls.Add(this.bt_update);
            this.panel1.Controls.Add(this.bt_novo);
            this.panel1.Controls.Add(this.bt_save);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 439);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 48);
            this.panel1.TabIndex = 31;
            // 
            // bt_fechar
            // 
            this.bt_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_fechar.Image = global::Project_Odin.Properties.Resources.bt_fechar_24;
            this.bt_fechar.Location = new System.Drawing.Point(336, 3);
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
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
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
            this.label1.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(194, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Dia da Semana:";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_id.Location = new System.Drawing.Point(45, 7);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(59, 26);
            this.txt_id.TabIndex = 3;
            this.txt_id.TabStop = false;
            // 
            // mtb_descricao
            // 
            this.mtb_descricao.Enabled = false;
            this.mtb_descricao.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtb_descricao.Location = new System.Drawing.Point(12, 63);
            this.mtb_descricao.Mask = "00:00 - 00:00";
            this.mtb_descricao.Name = "mtb_descricao";
            this.mtb_descricao.Size = new System.Drawing.Size(100, 26);
            this.mtb_descricao.TabIndex = 1;
            this.mtb_descricao.ValidatingType = typeof(System.DateTime);
            // 
            // cb_diaSemana
            // 
            this.cb_diaSemana.Enabled = false;
            this.cb_diaSemana.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_diaSemana.FormattingEnabled = true;
            this.cb_diaSemana.Items.AddRange(new object[] {
            "SEGUNDA-FEIRA",
            "TERÇA-FEIRA",
            "QUARTA-FEIRA",
            "QUINTA-FEIRA",
            "SEXTA-FEIRA",
            "INTERVALO"});
            this.cb_diaSemana.Location = new System.Drawing.Point(194, 62);
            this.cb_diaSemana.Name = "cb_diaSemana";
            this.cb_diaSemana.Size = new System.Drawing.Size(173, 27);
            this.cb_diaSemana.TabIndex = 2;
            // 
            // F_Horario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 487);
            this.Controls.Add(this.cb_diaSemana);
            this.Controls.Add(this.mtb_descricao);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_horario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Horario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horário";
            this.Load += new System.EventHandler(this.F_Horario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_horario;
        private Panel panel1;
        private Button bt_fechar;
        private Button bt_delete;
        private Button bt_update;
        private Button bt_novo;
        private Button bt_save;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_id;
        private MaskedTextBox mtb_descricao;
        private ComboBox cb_diaSemana;
    }
}