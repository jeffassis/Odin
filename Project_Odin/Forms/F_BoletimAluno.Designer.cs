namespace Project_Odin.Forms
{
    partial class F_BoletimAluno
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_boletimAluno = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_imprimir = new System.Windows.Forms.Button();
            this.cb_aluno = new System.Windows.Forms.ComboBox();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.cb_bimestre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_boletimAluno)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_boletimAluno
            // 
            this.dgv_boletimAluno.AllowUserToAddRows = false;
            this.dgv_boletimAluno.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_boletimAluno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_boletimAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_boletimAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_boletimAluno.EnableHeadersVisualStyles = false;
            this.dgv_boletimAluno.Location = new System.Drawing.Point(24, 173);
            this.dgv_boletimAluno.MultiSelect = false;
            this.dgv_boletimAluno.Name = "dgv_boletimAluno";
            this.dgv_boletimAluno.ReadOnly = true;
            this.dgv_boletimAluno.RowHeadersVisible = false;
            this.dgv_boletimAluno.RowTemplate.Height = 25;
            this.dgv_boletimAluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_boletimAluno.Size = new System.Drawing.Size(321, 225);
            this.dgv_boletimAluno.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_imprimir);
            this.groupBox1.Controls.Add(this.cb_aluno);
            this.groupBox1.Controls.Add(this.bt_buscar);
            this.groupBox1.Controls.Add(this.cb_bimestre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 144);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Boletim Aluno";
            // 
            // bt_imprimir
            // 
            this.bt_imprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_imprimir.Image = global::Project_Odin.Properties.Resources.imprimir_24;
            this.bt_imprimir.Location = new System.Drawing.Point(262, 93);
            this.bt_imprimir.Name = "bt_imprimir";
            this.bt_imprimir.Size = new System.Drawing.Size(36, 36);
            this.bt_imprimir.TabIndex = 5;
            this.bt_imprimir.UseVisualStyleBackColor = true;
            // 
            // cb_aluno
            // 
            this.cb_aluno.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_aluno.FormattingEnabled = true;
            this.cb_aluno.Location = new System.Drawing.Point(16, 39);
            this.cb_aluno.Name = "cb_aluno";
            this.cb_aluno.Size = new System.Drawing.Size(229, 27);
            this.cb_aluno.TabIndex = 4;
            // 
            // bt_buscar
            // 
            this.bt_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_buscar.Image = global::Project_Odin.Properties.Resources.pesquisar_24;
            this.bt_buscar.Location = new System.Drawing.Point(262, 30);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(36, 36);
            this.bt_buscar.TabIndex = 3;
            this.bt_buscar.UseVisualStyleBackColor = true;
            this.bt_buscar.Click += new System.EventHandler(this.bt_buscar_Click);
            // 
            // cb_bimestre
            // 
            this.cb_bimestre.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_bimestre.FormattingEnabled = true;
            this.cb_bimestre.Location = new System.Drawing.Point(16, 102);
            this.cb_bimestre.Name = "cb_bimestre";
            this.cb_bimestre.Size = new System.Drawing.Size(229, 27);
            this.cb_bimestre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bimestre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aluno:";
            // 
            // F_BoletimAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 415);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_boletimAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_BoletimAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boletim Aluno";
            this.Load += new System.EventHandler(this.F_BoletimAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_boletimAluno)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_boletimAluno;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private ComboBox cb_bimestre;
        private Button bt_buscar;
        private ComboBox cb_aluno;
        private Button bt_imprimir;
    }
}