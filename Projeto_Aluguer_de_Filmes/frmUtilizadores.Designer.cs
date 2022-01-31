namespace Gestão_Base_de_Dados
{
    partial class frmUtilizadores
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
            this.btnSair = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lvDados = new System.Windows.Forms.ListView();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnUtili = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnAtivo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnID = new System.Windows.Forms.Button();
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnNascimento = new System.Windows.Forms.Button();
            this.btnTelefone = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(33, 413);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(78, 31);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Voltar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(759, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Procurar";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(740, 424);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(122, 20);
            this.txtPesquisa.TabIndex = 2;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // lvDados
            // 
            this.lvDados.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lvDados.HideSelection = false;
            this.lvDados.Location = new System.Drawing.Point(33, 68);
            this.lvDados.Name = "lvDados";
            this.lvDados.Size = new System.Drawing.Size(836, 319);
            this.lvDados.TabIndex = 19;
            this.lvDados.UseCompatibleStateImageBehavior = false;
            this.lvDados.DoubleClick += new System.EventHandler(this.lvDados_DoubleClick);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(95, 68);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(103, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnUtili
            // 
            this.btnUtili.BackColor = System.Drawing.Color.Yellow;
            this.btnUtili.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtili.Location = new System.Drawing.Point(195, 68);
            this.btnUtili.Name = "btnUtili";
            this.btnUtili.Size = new System.Drawing.Size(131, 23);
            this.btnUtili.TabIndex = 5;
            this.btnUtili.Text = "Utilizador";
            this.btnUtili.UseVisualStyleBackColor = false;
            this.btnUtili.Click += new System.EventHandler(this.btnUtili_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.Location = new System.Drawing.Point(708, 68);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(96, 23);
            this.btnPerfil.TabIndex = 9;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnAtivo
            // 
            this.btnAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtivo.Location = new System.Drawing.Point(801, 68);
            this.btnAtivo.Name = "btnAtivo";
            this.btnAtivo.Size = new System.Drawing.Size(67, 23);
            this.btnAtivo.TabIndex = 10;
            this.btnAtivo.Text = "Ativo";
            this.btnAtivo.UseVisualStyleBackColor = true;
            this.btnAtivo.Click += new System.EventHandler(this.btnAtivo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(314, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(269, 36);
            this.label7.TabIndex = 28;
            this.label7.Text = "Tabela de Utilizadores";
            // 
            // btnID
            // 
            this.btnID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnID.Location = new System.Drawing.Point(33, 68);
            this.btnID.Name = "btnID";
            this.btnID.Size = new System.Drawing.Size(67, 23);
            this.btnID.TabIndex = 3;
            this.btnID.Text = "N.º";
            this.btnID.UseVisualStyleBackColor = true;
            this.btnID.Click += new System.EventHandler(this.btnID_Click);
            // 
            // btnEmail
            // 
            this.btnEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmail.Location = new System.Drawing.Point(320, 68);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(212, 23);
            this.btnEmail.TabIndex = 6;
            this.btnEmail.Text = "Email";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // btnNascimento
            // 
            this.btnNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNascimento.Location = new System.Drawing.Point(531, 68);
            this.btnNascimento.Name = "btnNascimento";
            this.btnNascimento.Size = new System.Drawing.Size(92, 23);
            this.btnNascimento.TabIndex = 7;
            this.btnNascimento.Text = "Nascimento";
            this.btnNascimento.UseVisualStyleBackColor = true;
            this.btnNascimento.Click += new System.EventHandler(this.btnNascimento_Click);
            // 
            // btnTelefone
            // 
            this.btnTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelefone.Location = new System.Drawing.Point(622, 68);
            this.btnTelefone.Name = "btnTelefone";
            this.btnTelefone.Size = new System.Drawing.Size(90, 23);
            this.btnTelefone.TabIndex = 8;
            this.btnTelefone.Text = "Telefone";
            this.btnTelefone.UseVisualStyleBackColor = true;
            this.btnTelefone.Click += new System.EventHandler(this.btnTelefone_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = global::Gestão_Base_de_Dados.Properties.Resources.Lupa;
            this.btnPesquisar.Image = global::Gestão_Base_de_Dados.Properties.Resources.Lupa;
            this.btnPesquisar.Location = new System.Drawing.Point(832, 402);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(17, 16);
            this.btnPesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPesquisar.TabIndex = 18;
            this.btnPesquisar.TabStop = false;
            // 
            // frmUtilizadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(904, 466);
            this.Controls.Add(this.btnTelefone);
            this.Controls.Add(this.btnNascimento);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.btnID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAtivo);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.btnUtili);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lvDados);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSair);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUtilizadores";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admistrador";
            this.Activated += new System.EventHandler(this.frmAdmin_Activated);
            this.Load += new System.EventHandler(this.frmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.PictureBox btnPesquisar;
        private System.Windows.Forms.ListView lvDados;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnUtili;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnAtivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnID;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Button btnNascimento;
        private System.Windows.Forms.Button btnTelefone;
    }
}