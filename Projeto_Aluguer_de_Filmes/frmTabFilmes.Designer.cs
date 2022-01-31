namespace Gestão_Base_de_Dados
{
    partial class frmTabFilmes
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
            this.label7 = new System.Windows.Forms.Label();
            this.btnAno = new System.Windows.Forms.Button();
            this.btnID = new System.Windows.Forms.Button();
            this.btnDuracao = new System.Windows.Forms.Button();
            this.btnTitulo = new System.Windows.Forms.Button();
            this.lvDados = new System.Windows.Forms.ListView();
            this.btnRealizador = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.PictureBox();
            this.btnFav = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisar)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(271, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 36);
            this.label7.TabIndex = 29;
            this.label7.Text = "Tabela de Filmes";
            // 
            // btnAno
            // 
            this.btnAno.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAno.Location = new System.Drawing.Point(534, 81);
            this.btnAno.Name = "btnAno";
            this.btnAno.Size = new System.Drawing.Size(81, 23);
            this.btnAno.TabIndex = 5;
            this.btnAno.Text = "Ano";
            this.btnAno.UseVisualStyleBackColor = false;
            this.btnAno.Click += new System.EventHandler(this.btnAno_Click);
            // 
            // btnID
            // 
            this.btnID.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnID.Location = new System.Drawing.Point(57, 81);
            this.btnID.Name = "btnID";
            this.btnID.Size = new System.Drawing.Size(69, 23);
            this.btnID.TabIndex = 1;
            this.btnID.Text = "N.º";
            this.btnID.UseVisualStyleBackColor = false;
            this.btnID.Click += new System.EventHandler(this.btnID_Click);
            // 
            // btnDuracao
            // 
            this.btnDuracao.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDuracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuracao.Location = new System.Drawing.Point(265, 81);
            this.btnDuracao.Name = "btnDuracao";
            this.btnDuracao.Size = new System.Drawing.Size(121, 23);
            this.btnDuracao.TabIndex = 3;
            this.btnDuracao.Text = "Duração";
            this.btnDuracao.UseVisualStyleBackColor = false;
            this.btnDuracao.Click += new System.EventHandler(this.btnDuracao_Click);
            // 
            // btnTitulo
            // 
            this.btnTitulo.BackColor = System.Drawing.Color.Yellow;
            this.btnTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitulo.Location = new System.Drawing.Point(124, 81);
            this.btnTitulo.Name = "btnTitulo";
            this.btnTitulo.Size = new System.Drawing.Size(143, 23);
            this.btnTitulo.TabIndex = 2;
            this.btnTitulo.Text = "Título";
            this.btnTitulo.UseVisualStyleBackColor = false;
            this.btnTitulo.Click += new System.EventHandler(this.btnTitulo_Click);
            // 
            // lvDados
            // 
            this.lvDados.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lvDados.HideSelection = false;
            this.lvDados.Location = new System.Drawing.Point(57, 81);
            this.lvDados.Name = "lvDados";
            this.lvDados.Size = new System.Drawing.Size(558, 319);
            this.lvDados.TabIndex = 34;
            this.lvDados.UseCompatibleStateImageBehavior = false;
            this.lvDados.DoubleClick += new System.EventHandler(this.lvDados_DoubleClick);
            // 
            // btnRealizador
            // 
            this.btnRealizador.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRealizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizador.Location = new System.Drawing.Point(384, 81);
            this.btnRealizador.Name = "btnRealizador";
            this.btnRealizador.Size = new System.Drawing.Size(152, 23);
            this.btnRealizador.TabIndex = 4;
            this.btnRealizador.Text = "Realizador";
            this.btnRealizador.UseVisualStyleBackColor = false;
            this.btnRealizador.Click += new System.EventHandler(this.btnRealizador_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(496, 445);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(122, 20);
            this.txtPesquisa.TabIndex = 11;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(515, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Procurar";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(58, 432);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(78, 31);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Voltar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnEditar.BackgroundImage = global::Gestão_Base_de_Dados.Properties.Resources.editar2;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditar.Location = new System.Drawing.Point(651, 257);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(61, 59);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminar.BackgroundImage = global::Gestão_Base_de_Dados.Properties.Resources.eliminar;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(651, 169);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(61, 59);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnAdicionar.BackgroundImage = global::Gestão_Base_de_Dados.Properties.Resources.adicionar3;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdicionar.Location = new System.Drawing.Point(651, 83);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(61, 59);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = global::Gestão_Base_de_Dados.Properties.Resources.Lupa;
            this.btnPesquisar.Image = global::Gestão_Base_de_Dados.Properties.Resources.Lupa;
            this.btnPesquisar.Location = new System.Drawing.Point(588, 423);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(17, 16);
            this.btnPesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPesquisar.TabIndex = 38;
            this.btnPesquisar.TabStop = false;
            // 
            // btnFav
            // 
            this.btnFav.BackColor = System.Drawing.Color.White;
            this.btnFav.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnFav.Location = new System.Drawing.Point(651, 341);
            this.btnFav.Name = "btnFav";
            this.btnFav.Size = new System.Drawing.Size(61, 59);
            this.btnFav.TabIndex = 9;
            this.btnFav.Text = "♥";
            this.btnFav.UseVisualStyleBackColor = false;
            this.btnFav.Click += new System.EventHandler(this.btnFav_Click);
            // 
            // frmTabFilmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(745, 487);
            this.Controls.Add(this.btnFav);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRealizador);
            this.Controls.Add(this.btnAno);
            this.Controls.Add(this.btnID);
            this.Controls.Add(this.btnDuracao);
            this.Controls.Add(this.btnTitulo);
            this.Controls.Add(this.lvDados);
            this.Controls.Add(this.label7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTabFilmes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filmes";
            this.Activated += new System.EventHandler(this.frmTabFilmes_Activated);
            this.Load += new System.EventHandler(this.frmTabFilmes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAno;
        private System.Windows.Forms.Button btnID;
        private System.Windows.Forms.Button btnDuracao;
        private System.Windows.Forms.Button btnTitulo;
        private System.Windows.Forms.ListView lvDados;
        private System.Windows.Forms.Button btnRealizador;
        private System.Windows.Forms.PictureBox btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnFav;
    }
}