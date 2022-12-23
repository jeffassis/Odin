namespace Project_Odin
{
    partial class F_Responsavel
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_parentesco = new System.Windows.Forms.ComboBox();
            this.mtb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.dgv_responsavel = new System.Windows.Forms.DataGridView();
            this.bt_novo = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_rg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_responsavel)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nome.Location = new System.Drawing.Point(12, 94);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(256, 25);
            this.txt_nome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome Completo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "RG:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(139, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefone:";
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtb_telefone.Location = new System.Drawing.Point(139, 207);
            this.mtb_telefone.Mask = "(99) 00000-0000";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(133, 25);
            this.mtb_telefone.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Parentesco:";
            // 
            // cb_parentesco
            // 
            this.cb_parentesco.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_parentesco.FormattingEnabled = true;
            this.cb_parentesco.Items.AddRange(new object[] {
            "Mãe",
            "Pai",
            "Responsável"});
            this.cb_parentesco.Location = new System.Drawing.Point(12, 207);
            this.cb_parentesco.Name = "cb_parentesco";
            this.cb_parentesco.Size = new System.Drawing.Size(121, 25);
            this.cb_parentesco.TabIndex = 4;
            // 
            // mtb_cpf
            // 
            this.mtb_cpf.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtb_cpf.Location = new System.Drawing.Point(139, 149);
            this.mtb_cpf.Mask = "000.000.000-00";
            this.mtb_cpf.Name = "mtb_cpf";
            this.mtb_cpf.Size = new System.Drawing.Size(129, 25);
            this.mtb_cpf.TabIndex = 3;
            // 
            // dgv_responsavel
            // 
            this.dgv_responsavel.AllowUserToAddRows = false;
            this.dgv_responsavel.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_responsavel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_responsavel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_responsavel.EnableHeadersVisualStyles = false;
            this.dgv_responsavel.Location = new System.Drawing.Point(284, 26);
            this.dgv_responsavel.MultiSelect = false;
            this.dgv_responsavel.Name = "dgv_responsavel";
            this.dgv_responsavel.ReadOnly = true;
            this.dgv_responsavel.RowHeadersVisible = false;
            this.dgv_responsavel.RowTemplate.Height = 25;
            this.dgv_responsavel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_responsavel.Size = new System.Drawing.Size(424, 257);
            this.dgv_responsavel.TabIndex = 11;
            this.dgv_responsavel.SelectionChanged += new System.EventHandler(this.dgv_aluno_SelectionChanged);
            // 
            // bt_novo
            // 
            this.bt_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_novo.Image = global::Project_Odin.Properties.Resources.bt_novo_24;
            this.bt_novo.Location = new System.Drawing.Point(12, 3);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(36, 36);
            this.bt_novo.TabIndex = 0;
            this.toolTip1.SetToolTip(this.bt_novo, "Novo Registro");
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
            this.toolTip1.SetToolTip(this.bt_save, "Salvar dados");
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_update
            // 
            this.bt_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_update.Image = global::Project_Odin.Properties.Resources.bt_update_24;
            this.bt_update.Location = new System.Drawing.Point(97, 3);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(36, 36);
            this.bt_update.TabIndex = 2;
            this.toolTip1.SetToolTip(this.bt_update, "Atualizar dados");
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_delete.Image = global::Project_Odin.Properties.Resources.bt_delete;
            this.bt_delete.Location = new System.Drawing.Point(139, 3);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(36, 36);
            this.bt_delete.TabIndex = 8;
            this.toolTip1.SetToolTip(this.bt_delete, "Remover dados");
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_fechar
            // 
            this.bt_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_fechar.Image = global::Project_Odin.Properties.Resources.bt_fechar_24;
            this.bt_fechar.Location = new System.Drawing.Point(672, 3);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(36, 36);
            this.bt_fechar.TabIndex = 9;
            this.toolTip1.SetToolTip(this.bt_fechar, "Fechar");
            this.bt_fechar.UseVisualStyleBackColor = true;
            this.bt_fechar.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_fechar);
            this.panel1.Controls.Add(this.bt_delete);
            this.panel1.Controls.Add(this.bt_update);
            this.panel1.Controls.Add(this.bt_novo);
            this.panel1.Controls.Add(this.bt_save);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 292);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 48);
            this.panel1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(139, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "CPF:";
            // 
            // txt_rg
            // 
            this.txt_rg.Location = new System.Drawing.Point(12, 151);
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(121, 23);
            this.txt_rg.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cadastro de Responsável";
            // 
            // F_Responsavel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 340);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_rg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_responsavel);
            this.Controls.Add(this.mtb_cpf);
            this.Controls.Add(this.cb_parentesco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtb_telefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Responsavel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Responsável";
            this.Load += new System.EventHandler(this.F_Responsavel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_responsavel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txt_nome;
        private Label label1;
        private Label label2;
        private Label label3;
        private MaskedTextBox mtb_telefone;
        private Label label4;
        private ComboBox cb_parentesco;
        private MaskedTextBox mtb_cpf;
        private DataGridView dgv_responsavel;
        private Button bt_novo;
        private Button bt_save;
        private Button bt_update;
        private Button bt_delete;
        private Button bt_fechar;
        private Panel panel1;
        private Label label5;
        private TextBox txt_rg;
        private Label label6;
        private ToolTip toolTip1;
    }
}