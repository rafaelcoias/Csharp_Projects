namespace Gestão_Base_de_Dados
{
    partial class frmPremium
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
            this.btnDefinicoes = new System.Windows.Forms.Button();
            this.lblRealizador = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.pbFilme = new System.Windows.Forms.PictureBox();
            this.btnTodos = new System.Windows.Forms.Button();
            this.btnRecentes = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.PictureBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lvDados = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.Button();
            this.lblVazio = new System.Windows.Forms.Label();
            this.lblCheio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDefinicoes
            // 
            this.btnDefinicoes.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnDefinicoes.BackgroundImage = global::Gestão_Base_de_Dados.Properties.Resources.defeniçõesIcon;
            this.btnDefinicoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefinicoes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDefinicoes.Location = new System.Drawing.Point(150, 581);
            this.btnDefinicoes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDefinicoes.Name = "btnDefinicoes";
            this.btnDefinicoes.Size = new System.Drawing.Size(66, 63);
            this.btnDefinicoes.TabIndex = 58;
            this.btnDefinicoes.UseVisualStyleBackColor = false;
            this.btnDefinicoes.Click += new System.EventHandler(this.btnDefinicoes_Click);
            // 
            // lblRealizador
            // 
            this.lblRealizador.AutoSize = true;
            this.lblRealizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRealizador.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblRealizador.Location = new System.Drawing.Point(1022, 271);
            this.lblRealizador.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRealizador.Name = "lblRealizador";
            this.lblRealizador.Size = new System.Drawing.Size(139, 29);
            this.lblRealizador.TabIndex = 71;
            this.lblRealizador.Text = "Realizador";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblData.Location = new System.Drawing.Point(1022, 210);
            this.lblData.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(66, 29);
            this.lblData.TabIndex = 70;
            this.lblData.Text = "Data";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblNome.Location = new System.Drawing.Point(1020, 152);
            this.lblNome.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(83, 29);
            this.lblNome.TabIndex = 69;
            this.lblNome.Text = "Nome";
            // 
            // pbFilme
            // 
            this.pbFilme.Image = global::Gestão_Base_de_Dados.Properties.Resources.aOrigem;
            this.pbFilme.Location = new System.Drawing.Point(774, 152);
            this.pbFilme.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pbFilme.Name = "pbFilme";
            this.pbFilme.Size = new System.Drawing.Size(222, 296);
            this.pbFilme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFilme.TabIndex = 68;
            this.pbFilme.TabStop = false;
            // 
            // btnTodos
            // 
            this.btnTodos.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodos.ForeColor = System.Drawing.Color.Red;
            this.btnTodos.Location = new System.Drawing.Point(748, 490);
            this.btnTodos.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(248, 54);
            this.btnTodos.TabIndex = 60;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = false;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btnRecentes
            // 
            this.btnRecentes.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnRecentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecentes.ForeColor = System.Drawing.Color.Red;
            this.btnRecentes.Location = new System.Drawing.Point(1028, 490);
            this.btnRecentes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRecentes.Name = "btnRecentes";
            this.btnRecentes.Size = new System.Drawing.Size(248, 54);
            this.btnRecentes.TabIndex = 61;
            this.btnRecentes.Text = "Mais Recentes";
            this.btnRecentes.UseVisualStyleBackColor = false;
            this.btnRecentes.Click += new System.EventHandler(this.btnRecentes_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoltar.Location = new System.Drawing.Point(50, 581);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(66, 63);
            this.btnVoltar.TabIndex = 57;
            this.btnVoltar.Text = "←";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = global::Gestão_Base_de_Dados.Properties.Resources.Lupa;
            this.btnPesquisar.Image = global::Gestão_Base_de_Dados.Properties.Resources.Lupa;
            this.btnPesquisar.Location = new System.Drawing.Point(628, 563);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(34, 31);
            this.btnPesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPesquisar.TabIndex = 67;
            this.btnPesquisar.TabStop = false;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(444, 606);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(240, 31);
            this.txtPesquisa.TabIndex = 59;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightCoral;
            this.label5.Location = new System.Drawing.Point(482, 563);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 30);
            this.label5.TabIndex = 66;
            this.label5.Text = "Procurar";
            // 
            // lvDados
            // 
            this.lvDados.BackColor = System.Drawing.Color.Maroon;
            this.lvDados.ForeColor = System.Drawing.SystemColors.Window;
            this.lvDados.HideSelection = false;
            this.lvDados.Location = new System.Drawing.Point(50, 152);
            this.lvDados.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lvDados.Name = "lvDados";
            this.lvDados.Size = new System.Drawing.Size(634, 396);
            this.lvDados.TabIndex = 65;
            this.lvDados.UseCompatibleStateImageBehavior = false;
            this.lvDados.DoubleClick += new System.EventHandler(this.lvDados_DoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(338, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(565, 58);
            this.label7.TabIndex = 64;
            this.label7.Text = "FILMES DISPONÍVEIS";
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.ForeColor = System.Drawing.Color.Yellow;
            this.btnVer.Location = new System.Drawing.Point(1020, 390);
            this.btnVer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(120, 58);
            this.btnVer.TabIndex = 73;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // lblVazio
            // 
            this.lblVazio.AutoSize = true;
            this.lblVazio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVazio.ForeColor = System.Drawing.Color.Gold;
            this.lblVazio.Location = new System.Drawing.Point(1018, 316);
            this.lblVazio.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblVazio.Name = "lblVazio";
            this.lblVazio.Size = new System.Drawing.Size(51, 55);
            this.lblVazio.TabIndex = 74;
            this.lblVazio.Text = "♡";
            this.lblVazio.Click += new System.EventHandler(this.lblVazio_Click);
            // 
            // lblCheio
            // 
            this.lblCheio.AutoSize = true;
            this.lblCheio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheio.ForeColor = System.Drawing.Color.Gold;
            this.lblCheio.Location = new System.Drawing.Point(1016, 327);
            this.lblCheio.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCheio.Name = "lblCheio";
            this.lblCheio.Size = new System.Drawing.Size(54, 37);
            this.lblCheio.TabIndex = 75;
            this.lblCheio.Text = "♥";
            this.lblCheio.Visible = false;
            this.lblCheio.Click += new System.EventHandler(this.lblCheio_Click);
            // 
            // frmPremium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1322, 690);
            this.Controls.Add(this.lblCheio);
            this.Controls.Add(this.lblVazio);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnDefinicoes);
            this.Controls.Add(this.lblRealizador);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.pbFilme);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnRecentes);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvDados);
            this.Controls.Add(this.label7);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPremium";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Premium";
            this.Load += new System.EventHandler(this.frmPremium_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFilme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDefinicoes;
        private System.Windows.Forms.Label lblRealizador;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox pbFilme;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Button btnRecentes;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvDados;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Label lblVazio;
        private System.Windows.Forms.Label lblCheio;
    }
}