namespace Project_Odin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Cadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.responsáveisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_nomeUsuario = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_acesso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cadastro,
            this.lOGINToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Cadastro
            // 
            this.Cadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunosToolStripMenuItem,
            this.responsáveisToolStripMenuItem,
            this.professoresToolStripMenuItem});
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(66, 20);
            this.Cadastro.Text = "Cadastro";
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alunosToolStripMenuItem.Text = "Alunos";
            // 
            // responsáveisToolStripMenuItem
            // 
            this.responsáveisToolStripMenuItem.Name = "responsáveisToolStripMenuItem";
            this.responsáveisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.responsáveisToolStripMenuItem.Text = "Responsável";
            this.responsáveisToolStripMenuItem.Click += new System.EventHandler(this.responsáveisToolStripMenuItem_Click);
            // 
            // professoresToolStripMenuItem
            // 
            this.professoresToolStripMenuItem.Name = "professoresToolStripMenuItem";
            this.professoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.professoresToolStripMenuItem.Text = "Professores";
            // 
            // lOGINToolStripMenuItem
            // 
            this.lOGINToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logONToolStripMenuItem,
            this.logOFFToolStripMenuItem});
            this.lOGINToolStripMenuItem.Name = "lOGINToolStripMenuItem";
            this.lOGINToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.lOGINToolStripMenuItem.Text = "LOGIN";
            // 
            // logONToolStripMenuItem
            // 
            this.logONToolStripMenuItem.Name = "logONToolStripMenuItem";
            this.logONToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.logONToolStripMenuItem.Text = "LogON";
            this.logONToolStripMenuItem.Click += new System.EventHandler(this.logONToolStripMenuItem_Click);
            // 
            // logOFFToolStripMenuItem
            // 
            this.logOFFToolStripMenuItem.Name = "logOFFToolStripMenuItem";
            this.logOFFToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.logOFFToolStripMenuItem.Text = "LogOFF";
            this.logOFFToolStripMenuItem.Click += new System.EventHandler(this.logOFFToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_nomeUsuario);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lbl_acesso);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 530);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 31);
            this.panel1.TabIndex = 1;
            // 
            // lbl_nomeUsuario
            // 
            this.lbl_nomeUsuario.AutoSize = true;
            this.lbl_nomeUsuario.Location = new System.Drawing.Point(122, 11);
            this.lbl_nomeUsuario.Name = "lbl_nomeUsuario";
            this.lbl_nomeUsuario.Size = new System.Drawing.Size(22, 15);
            this.lbl_nomeUsuario.TabIndex = 4;
            this.lbl_nomeUsuario.Text = "---";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project_Odin.Properties.Resources.user_logado;
            this.pictureBox2.Location = new System.Drawing.Point(101, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_acesso
            // 
            this.lbl_acesso.AutoSize = true;
            this.lbl_acesso.Location = new System.Drawing.Point(82, 10);
            this.lbl_acesso.Name = "lbl_acesso";
            this.lbl_acesso.Size = new System.Drawing.Size(13, 15);
            this.lbl_acesso.TabIndex = 2;
            this.lbl_acesso.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Acesso:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_Odin.Properties.Resources.led_red;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem Cadastro;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox2;
        public PictureBox pictureBox1;
        public Label lbl_acesso;
        public Label lbl_nomeUsuario;
        private ToolStripMenuItem lOGINToolStripMenuItem;
        private ToolStripMenuItem logONToolStripMenuItem;
        private ToolStripMenuItem logOFFToolStripMenuItem;
        private ToolStripMenuItem alunosToolStripMenuItem;
        private ToolStripMenuItem responsáveisToolStripMenuItem;
        private ToolStripMenuItem professoresToolStripMenuItem;
    }
}