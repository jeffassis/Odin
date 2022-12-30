namespace Project_Odin.Forms
{
    partial class F_BoletimFinal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_boletimFinal = new System.Windows.Forms.DataGridView();
            this.cb_aluno = new System.Windows.Forms.ComboBox();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.lbl_aluno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_boletimFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_boletimFinal
            // 
            this.dgv_boletimFinal.AllowUserToAddRows = false;
            this.dgv_boletimFinal.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_boletimFinal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_boletimFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_boletimFinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_boletimFinal.EnableHeadersVisualStyles = false;
            this.dgv_boletimFinal.Location = new System.Drawing.Point(12, 74);
            this.dgv_boletimFinal.MultiSelect = false;
            this.dgv_boletimFinal.Name = "dgv_boletimFinal";
            this.dgv_boletimFinal.ReadOnly = true;
            this.dgv_boletimFinal.RowHeadersVisible = false;
            this.dgv_boletimFinal.RowTemplate.Height = 25;
            this.dgv_boletimFinal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_boletimFinal.Size = new System.Drawing.Size(555, 225);
            this.dgv_boletimFinal.TabIndex = 32;
            // 
            // cb_aluno
            // 
            this.cb_aluno.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_aluno.FormattingEnabled = true;
            this.cb_aluno.Location = new System.Drawing.Point(12, 36);
            this.cb_aluno.Name = "cb_aluno";
            this.cb_aluno.Size = new System.Drawing.Size(284, 27);
            this.cb_aluno.TabIndex = 35;
            // 
            // bt_buscar
            // 
            this.bt_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_buscar.Image = global::Project_Odin.Properties.Resources.pesquisar_24;
            this.bt_buscar.Location = new System.Drawing.Point(311, 27);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(36, 36);
            this.bt_buscar.TabIndex = 34;
            this.bt_buscar.UseVisualStyleBackColor = true;
            this.bt_buscar.Click += new System.EventHandler(this.bt_buscar_Click);
            // 
            // lbl_aluno
            // 
            this.lbl_aluno.AutoSize = true;
            this.lbl_aluno.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_aluno.Location = new System.Drawing.Point(12, 14);
            this.lbl_aluno.Name = "lbl_aluno";
            this.lbl_aluno.Size = new System.Drawing.Size(131, 19);
            this.lbl_aluno.TabIndex = 33;
            this.lbl_aluno.Text = "Consulte o aluno:";
            // 
            // F_BoletimFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 311);
            this.Controls.Add(this.cb_aluno);
            this.Controls.Add(this.bt_buscar);
            this.Controls.Add(this.lbl_aluno);
            this.Controls.Add(this.dgv_boletimFinal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_BoletimFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boletim Final";
            this.Load += new System.EventHandler(this.F_BoletimFinal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_boletimFinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_boletimFinal;
        private ComboBox cb_aluno;
        private Button bt_buscar;
        private Label lbl_aluno;
    }
}