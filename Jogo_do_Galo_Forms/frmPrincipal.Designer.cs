namespace Jogo_do_Galo_2._0
{
    partial class frmPrincipal
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblJ2 = new System.Windows.Forms.Label();
            this.lblJ1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.jogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contraIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jogoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.melhorDe3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.melhorDe5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peçasDeJogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corDeFundoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dificuldadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fácilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difícilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairDoJogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSair = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAviso = new System.Windows.Forms.Label();
            this.lblAviso2 = new System.Windows.Forms.Label();
            this.tmJogo = new System.Windows.Forms.Timer(this.components);
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 30);
            this.label2.TabIndex = 48;
            this.label2.Text = "Menu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 72);
            this.label1.TabIndex = 47;
            this.label1.Text = "Jogo do Galo";
            // 
            // lblJ2
            // 
            this.lblJ2.AutoSize = true;
            this.lblJ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJ2.Location = new System.Drawing.Point(142, 454);
            this.lblJ2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblJ2.Name = "lblJ2";
            this.lblJ2.Size = new System.Drawing.Size(135, 30);
            this.lblJ2.TabIndex = 50;
            this.lblJ2.Text = "Jogador 2";
            // 
            // lblJ1
            // 
            this.lblJ1.AutoSize = true;
            this.lblJ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJ1.Location = new System.Drawing.Point(142, 296);
            this.lblJ1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblJ1.Name = "lblJ1";
            this.lblJ1.Size = new System.Drawing.Size(143, 30);
            this.lblJ1.TabIndex = 49;
            this.lblJ1.Text = "Jogador 1 ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jogoToolStripMenuItem,
            this.configuraçõesToolStripMenuItem,
            this.sairDoJogoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(301, 162);
            // 
            // jogoToolStripMenuItem
            // 
            this.jogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contraIAToolStripMenuItem,
            this.multiplayerToolStripMenuItem});
            this.jogoToolStripMenuItem.Name = "jogoToolStripMenuItem";
            this.jogoToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.jogoToolStripMenuItem.Text = "Jogar";
            // 
            // contraIAToolStripMenuItem
            // 
            this.contraIAToolStripMenuItem.Name = "contraIAToolStripMenuItem";
            this.contraIAToolStripMenuItem.Size = new System.Drawing.Size(270, 44);
            this.contraIAToolStripMenuItem.Text = "Contra IA";
            this.contraIAToolStripMenuItem.Click += new System.EventHandler(this.contraIAToolStripMenuItem_Click);
            // 
            // multiplayerToolStripMenuItem
            // 
            this.multiplayerToolStripMenuItem.Name = "multiplayerToolStripMenuItem";
            this.multiplayerToolStripMenuItem.Size = new System.Drawing.Size(270, 44);
            this.multiplayerToolStripMenuItem.Text = "Multiplayer";
            this.multiplayerToolStripMenuItem.Click += new System.EventHandler(this.multiplayerToolStripMenuItem_Click);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jogoToolStripMenuItem1,
            this.peçasDeJogoToolStripMenuItem,
            this.corDeFundoToolStripMenuItem,
            this.dificuldadeToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // jogoToolStripMenuItem1
            // 
            this.jogoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jogoToolStripMenuItem2,
            this.melhorDe3ToolStripMenuItem,
            this.melhorDe5ToolStripMenuItem});
            this.jogoToolStripMenuItem1.Name = "jogoToolStripMenuItem1";
            this.jogoToolStripMenuItem1.Size = new System.Drawing.Size(359, 44);
            this.jogoToolStripMenuItem1.Text = "Jogo";
            // 
            // jogoToolStripMenuItem2
            // 
            this.jogoToolStripMenuItem2.Name = "jogoToolStripMenuItem2";
            this.jogoToolStripMenuItem2.Size = new System.Drawing.Size(280, 44);
            this.jogoToolStripMenuItem2.Text = "1 Jogo";
            this.jogoToolStripMenuItem2.Click += new System.EventHandler(this.jogoToolStripMenuItem2_Click);
            // 
            // melhorDe3ToolStripMenuItem
            // 
            this.melhorDe3ToolStripMenuItem.Name = "melhorDe3ToolStripMenuItem";
            this.melhorDe3ToolStripMenuItem.Size = new System.Drawing.Size(280, 44);
            this.melhorDe3ToolStripMenuItem.Text = "Melhor de 3";
            this.melhorDe3ToolStripMenuItem.Click += new System.EventHandler(this.melhorDe3ToolStripMenuItem_Click);
            // 
            // melhorDe5ToolStripMenuItem
            // 
            this.melhorDe5ToolStripMenuItem.Name = "melhorDe5ToolStripMenuItem";
            this.melhorDe5ToolStripMenuItem.Size = new System.Drawing.Size(280, 44);
            this.melhorDe5ToolStripMenuItem.Text = "Melhor de 5";
            this.melhorDe5ToolStripMenuItem.Click += new System.EventHandler(this.melhorDe5ToolStripMenuItem_Click);
            // 
            // peçasDeJogoToolStripMenuItem
            // 
            this.peçasDeJogoToolStripMenuItem.Name = "peçasDeJogoToolStripMenuItem";
            this.peçasDeJogoToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.peçasDeJogoToolStripMenuItem.Text = "Peças de Jogo";
            this.peçasDeJogoToolStripMenuItem.Click += new System.EventHandler(this.peçasDeJogoToolStripMenuItem_Click);
            // 
            // corDeFundoToolStripMenuItem
            // 
            this.corDeFundoToolStripMenuItem.Name = "corDeFundoToolStripMenuItem";
            this.corDeFundoToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.corDeFundoToolStripMenuItem.Text = "Cor de Fundo";
            this.corDeFundoToolStripMenuItem.Click += new System.EventHandler(this.corDeFundoToolStripMenuItem_Click);
            // 
            // dificuldadeToolStripMenuItem
            // 
            this.dificuldadeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fácilToolStripMenuItem,
            this.difícilToolStripMenuItem});
            this.dificuldadeToolStripMenuItem.Name = "dificuldadeToolStripMenuItem";
            this.dificuldadeToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.dificuldadeToolStripMenuItem.Text = "Dificuldade";
            // 
            // fácilToolStripMenuItem
            // 
            this.fácilToolStripMenuItem.Name = "fácilToolStripMenuItem";
            this.fácilToolStripMenuItem.Size = new System.Drawing.Size(209, 44);
            this.fácilToolStripMenuItem.Text = "Fácil";
            this.fácilToolStripMenuItem.Click += new System.EventHandler(this.fácilToolStripMenuItem_Click);
            // 
            // difícilToolStripMenuItem
            // 
            this.difícilToolStripMenuItem.Name = "difícilToolStripMenuItem";
            this.difícilToolStripMenuItem.Size = new System.Drawing.Size(209, 44);
            this.difícilToolStripMenuItem.Text = "Difícil";
            this.difícilToolStripMenuItem.Click += new System.EventHandler(this.difícilToolStripMenuItem_Click);
            // 
            // sairDoJogoToolStripMenuItem
            // 
            this.sairDoJogoToolStripMenuItem.Name = "sairDoJogoToolStripMenuItem";
            this.sairDoJogoToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.sairDoJogoToolStripMenuItem.Text = "Sair do Jogo";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(546, 613);
            this.btnSair.Margin = new System.Windows.Forms.Padding(6);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(150, 54);
            this.btnSair.TabIndex = 52;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 32);
            this.label3.TabIndex = 53;
            this.label3.Text = "Início";
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(182, 233);
            this.lblAviso.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(341, 29);
            this.lblAviso.TabIndex = 54;
            this.lblAviso.Text = "Máx. de Caractéres Atingido";
            this.lblAviso.Visible = false;
            // 
            // lblAviso2
            // 
            this.lblAviso2.AutoSize = true;
            this.lblAviso2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso2.ForeColor = System.Drawing.Color.Red;
            this.lblAviso2.Location = new System.Drawing.Point(182, 233);
            this.lblAviso2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAviso2.Name = "lblAviso2";
            this.lblAviso2.Size = new System.Drawing.Size(321, 29);
            this.lblAviso2.TabIndex = 55;
            this.lblAviso2.Text = "Escreva no mínimo 1 Letra";
            this.lblAviso2.Visible = false;
            // 
            // tmJogo
            // 
            this.tmJogo.Tick += new System.EventHandler(this.tmJogo_Tick);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(356, 296);
            this.tb1.Margin = new System.Windows.Forms.Padding(6);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(228, 31);
            this.tb1.TabIndex = 56;
            this.tb1.Text = "Jogador 1";
            // 
            // tb2
            // 
            this.tb2.ContextMenuStrip = this.contextMenuStrip1;
            this.tb2.Location = new System.Drawing.Point(356, 446);
            this.tb2.Margin = new System.Windows.Forms.Padding(6);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(228, 31);
            this.tb2.TabIndex = 57;
            this.tb2.Text = "Jogador 2";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(720, 690);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.lblAviso2);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblJ2);
            this.Controls.Add(this.lblJ1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Início";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblJ2;
        private System.Windows.Forms.Label lblJ1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contraIAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peçasDeJogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corDeFundoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairDoJogoToolStripMenuItem;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Label lblAviso2;
        private System.Windows.Forms.Timer tmJogo;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.ToolStripMenuItem jogoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jogoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem melhorDe3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem melhorDe5ToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem dificuldadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fácilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem difícilToolStripMenuItem;
    }
}

