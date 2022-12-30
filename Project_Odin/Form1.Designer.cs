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
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.MenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.responsáveisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPedagogico = new System.Windows.Forms.ToolStripMenuItem();
            this.turmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.documentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.declaraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boletimAlunoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.boletimFinalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boletimAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFinanceiro = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.logONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_acesso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_nomeUsuario = new System.Windows.Forms.Label();
            this.pane_top = new System.Windows.Forms.Panel();
            this.bt_nota = new System.Windows.Forms.Button();
            this.bt_aluno = new System.Windows.Forms.Button();
            this.pane_direita = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pane_top.SuspendLayout();
            this.pane_direita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastro,
            this.MenuPedagogico,
            this.MenuRelatorio,
            this.MenuFinanceiro,
            this.MenuUsuario,
            this.MenuLogin});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(884, 24);
            this.MenuBar.TabIndex = 0;
            this.MenuBar.Text = "menuStrip1";
            // 
            // MenuCadastro
            // 
            this.MenuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunosToolStripMenuItem,
            this.responsáveisToolStripMenuItem,
            this.professoresToolStripMenuItem});
            this.MenuCadastro.Image = global::Project_Odin.Properties.Resources.menuCadastro;
            this.MenuCadastro.Name = "MenuCadastro";
            this.MenuCadastro.Size = new System.Drawing.Size(88, 20);
            this.MenuCadastro.Text = "Cadastros";
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.Image = global::Project_Odin.Properties.Resources.aluno;
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.alunosToolStripMenuItem.Text = "Alunos";
            this.alunosToolStripMenuItem.Click += new System.EventHandler(this.alunosToolStripMenuItem_Click);
            // 
            // responsáveisToolStripMenuItem
            // 
            this.responsáveisToolStripMenuItem.Image = global::Project_Odin.Properties.Resources.responsavel;
            this.responsáveisToolStripMenuItem.Name = "responsáveisToolStripMenuItem";
            this.responsáveisToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.responsáveisToolStripMenuItem.Text = "Responsável";
            this.responsáveisToolStripMenuItem.Click += new System.EventHandler(this.responsáveisToolStripMenuItem_Click);
            // 
            // professoresToolStripMenuItem
            // 
            this.professoresToolStripMenuItem.Image = global::Project_Odin.Properties.Resources.professor;
            this.professoresToolStripMenuItem.Name = "professoresToolStripMenuItem";
            this.professoresToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.professoresToolStripMenuItem.Text = "Professores";
            // 
            // MenuPedagogico
            // 
            this.MenuPedagogico.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.turmasToolStripMenuItem,
            this.disciplinasToolStripMenuItem,
            this.horariosToolStripMenuItem,
            this.notasToolStripMenuItem1});
            this.MenuPedagogico.Image = global::Project_Odin.Properties.Resources.pedagogico;
            this.MenuPedagogico.Name = "MenuPedagogico";
            this.MenuPedagogico.Size = new System.Drawing.Size(95, 20);
            this.MenuPedagogico.Text = "Pedagógico";
            // 
            // turmasToolStripMenuItem
            // 
            this.turmasToolStripMenuItem.Image = global::Project_Odin.Properties.Resources.turma;
            this.turmasToolStripMenuItem.Name = "turmasToolStripMenuItem";
            this.turmasToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.turmasToolStripMenuItem.Text = "Turmas";
            // 
            // disciplinasToolStripMenuItem
            // 
            this.disciplinasToolStripMenuItem.Image = global::Project_Odin.Properties.Resources.disciplina;
            this.disciplinasToolStripMenuItem.Name = "disciplinasToolStripMenuItem";
            this.disciplinasToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.disciplinasToolStripMenuItem.Text = "Disciplinas";
            // 
            // horariosToolStripMenuItem
            // 
            this.horariosToolStripMenuItem.Image = global::Project_Odin.Properties.Resources.clock;
            this.horariosToolStripMenuItem.Name = "horariosToolStripMenuItem";
            this.horariosToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.horariosToolStripMenuItem.Text = "Horários";
            this.horariosToolStripMenuItem.Click += new System.EventHandler(this.horariosToolStripMenuItem_Click);
            // 
            // notasToolStripMenuItem1
            // 
            this.notasToolStripMenuItem1.Image = global::Project_Odin.Properties.Resources.notas;
            this.notasToolStripMenuItem1.Name = "notasToolStripMenuItem1";
            this.notasToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.notasToolStripMenuItem1.Text = "Notas";
            this.notasToolStripMenuItem1.Click += new System.EventHandler(this.notasToolStripMenuItem1_Click);
            // 
            // MenuRelatorio
            // 
            this.MenuRelatorio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentosToolStripMenuItem,
            this.notasToolStripMenuItem});
            this.MenuRelatorio.Image = global::Project_Odin.Properties.Resources.menuReports;
            this.MenuRelatorio.Name = "MenuRelatorio";
            this.MenuRelatorio.Size = new System.Drawing.Size(89, 20);
            this.MenuRelatorio.Text = "Relatórios";
            // 
            // documentosToolStripMenuItem
            // 
            this.documentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.declaraçãoToolStripMenuItem,
            this.historicosToolStripMenuItem});
            this.documentosToolStripMenuItem.Name = "documentosToolStripMenuItem";
            this.documentosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.documentosToolStripMenuItem.Text = "Documentos";
            // 
            // declaraçãoToolStripMenuItem
            // 
            this.declaraçãoToolStripMenuItem.Name = "declaraçãoToolStripMenuItem";
            this.declaraçãoToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.declaraçãoToolStripMenuItem.Text = "Declaração";
            // 
            // historicosToolStripMenuItem
            // 
            this.historicosToolStripMenuItem.Name = "historicosToolStripMenuItem";
            this.historicosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.historicosToolStripMenuItem.Text = "Historicos";
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boletimAlunoToolStripMenuItem1,
            this.boletimFinalToolStripMenuItem,
            this.boletimAlunoToolStripMenuItem});
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.notasToolStripMenuItem.Text = "Notas";
            // 
            // boletimAlunoToolStripMenuItem1
            // 
            this.boletimAlunoToolStripMenuItem1.Name = "boletimAlunoToolStripMenuItem1";
            this.boletimAlunoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.boletimAlunoToolStripMenuItem1.Text = "Boletim Aluno";
            this.boletimAlunoToolStripMenuItem1.Click += new System.EventHandler(this.boletimAlunoToolStripMenuItem1_Click);
            // 
            // boletimFinalToolStripMenuItem
            // 
            this.boletimFinalToolStripMenuItem.Name = "boletimFinalToolStripMenuItem";
            this.boletimFinalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.boletimFinalToolStripMenuItem.Text = "Boletim Final";
            this.boletimFinalToolStripMenuItem.Click += new System.EventHandler(this.boletimFinalToolStripMenuItem_Click);
            // 
            // boletimAlunoToolStripMenuItem
            // 
            this.boletimAlunoToolStripMenuItem.Name = "boletimAlunoToolStripMenuItem";
            this.boletimAlunoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.boletimAlunoToolStripMenuItem.Text = "Por Disciplina";
            // 
            // MenuFinanceiro
            // 
            this.MenuFinanceiro.Image = global::Project_Odin.Properties.Resources.financeiro;
            this.MenuFinanceiro.Name = "MenuFinanceiro";
            this.MenuFinanceiro.Size = new System.Drawing.Size(91, 20);
            this.MenuFinanceiro.Text = "Financeiro";
            // 
            // MenuUsuario
            // 
            this.MenuUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestãoDeUsuáriosToolStripMenuItem});
            this.MenuUsuario.Image = global::Project_Odin.Properties.Resources.menuUser;
            this.MenuUsuario.Name = "MenuUsuario";
            this.MenuUsuario.Size = new System.Drawing.Size(82, 20);
            this.MenuUsuario.Text = "Usuários";
            // 
            // gestãoDeUsuáriosToolStripMenuItem
            // 
            this.gestãoDeUsuáriosToolStripMenuItem.Image = global::Project_Odin.Properties.Resources.users;
            this.gestãoDeUsuáriosToolStripMenuItem.Name = "gestãoDeUsuáriosToolStripMenuItem";
            this.gestãoDeUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.gestãoDeUsuáriosToolStripMenuItem.Text = "Gestão de Usuários";
            this.gestãoDeUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeUsuáriosToolStripMenuItem_Click);
            // 
            // MenuLogin
            // 
            this.MenuLogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MenuLogin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logONToolStripMenuItem,
            this.logOFFToolStripMenuItem});
            this.MenuLogin.Image = global::Project_Odin.Properties.Resources.sair2;
            this.MenuLogin.Name = "MenuLogin";
            this.MenuLogin.Size = new System.Drawing.Size(66, 20);
            this.MenuLogin.Text = "Login";
            // 
            // logONToolStripMenuItem
            // 
            this.logONToolStripMenuItem.Image = global::Project_Odin.Properties.Resources.logON;
            this.logONToolStripMenuItem.Name = "logONToolStripMenuItem";
            this.logONToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.logONToolStripMenuItem.Text = "LogON";
            this.logONToolStripMenuItem.Click += new System.EventHandler(this.logONToolStripMenuItem_Click);
            // 
            // logOFFToolStripMenuItem
            // 
            this.logOFFToolStripMenuItem.Image = global::Project_Odin.Properties.Resources.logOFF;
            this.logOFFToolStripMenuItem.Name = "logOFFToolStripMenuItem";
            this.logOFFToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.logOFFToolStripMenuItem.Text = "LogOFF";
            this.logOFFToolStripMenuItem.Click += new System.EventHandler(this.logOFFToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_Odin.Properties.Resources.led_red;
            this.pictureBox1.Location = new System.Drawing.Point(91, 254);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_acesso
            // 
            this.lbl_acesso.AutoSize = true;
            this.lbl_acesso.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_acesso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_acesso.Location = new System.Drawing.Point(69, 259);
            this.lbl_acesso.Name = "lbl_acesso";
            this.lbl_acesso.Size = new System.Drawing.Size(16, 17);
            this.lbl_acesso.TabIndex = 2;
            this.lbl_acesso.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(23, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nível:";
            // 
            // lbl_nomeUsuario
            // 
            this.lbl_nomeUsuario.AutoSize = true;
            this.lbl_nomeUsuario.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nomeUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_nomeUsuario.Location = new System.Drawing.Point(69, 229);
            this.lbl_nomeUsuario.Name = "lbl_nomeUsuario";
            this.lbl_nomeUsuario.Size = new System.Drawing.Size(20, 17);
            this.lbl_nomeUsuario.TabIndex = 4;
            this.lbl_nomeUsuario.Text = "---";
            // 
            // pane_top
            // 
            this.pane_top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pane_top.BackColor = System.Drawing.SystemColors.Control;
            this.pane_top.Controls.Add(this.bt_nota);
            this.pane_top.Controls.Add(this.bt_aluno);
            this.pane_top.Location = new System.Drawing.Point(0, 27);
            this.pane_top.Name = "pane_top";
            this.pane_top.Size = new System.Drawing.Size(688, 75);
            this.pane_top.TabIndex = 2;
            // 
            // bt_nota
            // 
            this.bt_nota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_nota.FlatAppearance.BorderSize = 0;
            this.bt_nota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_nota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_nota.Image = global::Project_Odin.Properties.Resources.notas_64;
            this.bt_nota.Location = new System.Drawing.Point(80, 5);
            this.bt_nota.Name = "bt_nota";
            this.bt_nota.Size = new System.Drawing.Size(70, 65);
            this.bt_nota.TabIndex = 1;
            this.bt_nota.UseVisualStyleBackColor = true;
            this.bt_nota.Click += new System.EventHandler(this.bt_nota_Click);
            // 
            // bt_aluno
            // 
            this.bt_aluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_aluno.FlatAppearance.BorderSize = 0;
            this.bt_aluno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_aluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_aluno.Image = global::Project_Odin.Properties.Resources.aluno_64;
            this.bt_aluno.Location = new System.Drawing.Point(4, 5);
            this.bt_aluno.Name = "bt_aluno";
            this.bt_aluno.Size = new System.Drawing.Size(70, 65);
            this.bt_aluno.TabIndex = 0;
            this.bt_aluno.UseVisualStyleBackColor = true;
            this.bt_aluno.Click += new System.EventHandler(this.button1_Click);
            // 
            // pane_direita
            // 
            this.pane_direita.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pane_direita.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pane_direita.Controls.Add(this.pictureBox1);
            this.pane_direita.Controls.Add(this.label7);
            this.pane_direita.Controls.Add(this.label1);
            this.pane_direita.Controls.Add(this.lbl_acesso);
            this.pane_direita.Controls.Add(this.lbl_nomeUsuario);
            this.pane_direita.Controls.Add(this.label6);
            this.pane_direita.Controls.Add(this.pictureBox4);
            this.pane_direita.Controls.Add(this.label5);
            this.pane_direita.Controls.Add(this.pictureBox3);
            this.pane_direita.Controls.Add(this.label4);
            this.pane_direita.Controls.Add(this.label3);
            this.pane_direita.Controls.Add(this.label2);
            this.pane_direita.Location = new System.Drawing.Point(685, 26);
            this.pane_direita.Name = "pane_direita";
            this.pane_direita.Size = new System.Drawing.Size(200, 539);
            this.pane_direita.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(9, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Usuário:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(-3, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "______________________";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Project_Odin.Properties.Resources.menuUser1;
            this.pictureBox4.Location = new System.Drawing.Point(10, 166);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(-4, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "______________________";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Project_Odin.Properties.Resources.clock;
            this.pictureBox3.Location = new System.Drawing.Point(9, 34);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(70, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "23/12/2022";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(8, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "DATA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(74, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "13:00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pane_direita);
            this.Controls.Add(this.pane_top);
            this.Controls.Add(this.MenuBar);
            this.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.MenuBar;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pane_top.ResumeLayout(false);
            this.pane_direita.ResumeLayout(false);
            this.pane_direita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip MenuBar;
        private ToolStripMenuItem MenuCadastro;
        private Label label1;
        public PictureBox pictureBox1;
        public Label lbl_acesso;
        public Label lbl_nomeUsuario;
        private ToolStripMenuItem MenuLogin;
        private ToolStripMenuItem logONToolStripMenuItem;
        private ToolStripMenuItem logOFFToolStripMenuItem;
        private ToolStripMenuItem alunosToolStripMenuItem;
        private ToolStripMenuItem responsáveisToolStripMenuItem;
        private ToolStripMenuItem professoresToolStripMenuItem;
        private ToolStripMenuItem MenuRelatorio;
        private ToolStripMenuItem MenuUsuario;
        private ToolStripMenuItem gestãoDeUsuáriosToolStripMenuItem;
        private Panel pane_top;
        private Panel pane_direita;
        private Label label3;
        private Label label2;
        private Button bt_aluno;
        private Label label4;
        private PictureBox pictureBox3;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox4;
        private Label label7;
        private ToolStripMenuItem documentosToolStripMenuItem;
        private ToolStripMenuItem declaraçãoToolStripMenuItem;
        private ToolStripMenuItem historicosToolStripMenuItem;
        private ToolStripMenuItem notasToolStripMenuItem;
        private ToolStripMenuItem boletimAlunoToolStripMenuItem;
        private ToolStripMenuItem boletimAlunoToolStripMenuItem1;
        private ToolStripMenuItem boletimFinalToolStripMenuItem;
        private ToolStripMenuItem MenuPedagogico;
        private ToolStripMenuItem MenuFinanceiro;
        private ToolStripMenuItem turmasToolStripMenuItem;
        private ToolStripMenuItem disciplinasToolStripMenuItem;
        private ToolStripMenuItem horariosToolStripMenuItem;
        private ToolStripMenuItem notasToolStripMenuItem1;
        private Button bt_nota;
    }
}