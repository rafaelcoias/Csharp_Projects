namespace Gestão_Base_de_Dados
{
    partial class frmAluguer
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
            this.lvDados = new System.Windows.Forms.ListView();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnRecentes = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnBaratos = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblRealizador = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDefinicoes = new System.Windows.Forms.Button();
            this.pbFilme = new System.Windows.Forms.PictureBox();
            this.btnPesquisar = new System.Windows.Forms.PictureBox();
            this.lblCheio = new System.Windows.Forms.Label();
            this.lblVazio = new System.Windows.Forms.Label();
            this.btnTrailer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisar)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(193, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(301, 29);
            this.label7.TabIndex = 30;
            this.label7.Text = "FILMES DISPONÍVEIS";
            // 
            // lvDados
            // 
            this.lvDados.BackColor = System.Drawing.Color.Maroon;
            this.lvDados.ForeColor = System.Drawing.SystemColors.Window;
            this.lvDados.HideSelection = false;
            this.lvDados.Location = new System.Drawing.Point(49, 79);
            this.lvDados.Name = "lvDados";
            this.lvDados.Size = new System.Drawing.Size(319, 208);
            this.lvDados.TabIndex = 31;
            this.lvDados.UseCompatibleStateImageBehavior = false;
            this.lvDados.DoubleClick += new System.EventHandler(this.lvDados_DoubleClick);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(246, 315);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(122, 20);
            this.txtPesquisa.TabIndex = 3;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightCoral;
            this.label5.Location = new System.Drawing.Point(265, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "Procurar";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoltar.Location = new System.Drawing.Point(49, 302);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(33, 33);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "←";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnRecentes
            // 
            this.btnRecentes.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnRecentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecentes.ForeColor = System.Drawing.Color.Red;
            this.btnRecentes.Location = new System.Drawing.Point(398, 307);
            this.btnRecentes.Name = "btnRecentes";
            this.btnRecentes.Size = new System.Drawing.Size(124, 28);
            this.btnRecentes.TabIndex = 5;
            this.btnRecentes.Text = "Mais Recentes";
            this.btnRecentes.UseVisualStyleBackColor = false;
            this.btnRecentes.Click += new System.EventHandler(this.btnRecentes_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.Red;
            this.btnComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.ForeColor = System.Drawing.Color.White;
            this.btnComprar.Location = new System.Drawing.Point(538, 255);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(124, 28);
            this.btnComprar.TabIndex = 7;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnBaratos
            // 
            this.btnBaratos.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnBaratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaratos.ForeColor = System.Drawing.Color.Red;
            this.btnBaratos.Location = new System.Drawing.Point(538, 305);
            this.btnBaratos.Name = "btnBaratos";
            this.btnBaratos.Size = new System.Drawing.Size(124, 28);
            this.btnBaratos.TabIndex = 6;
            this.btnBaratos.Text = "Mais Baratos";
            this.btnBaratos.UseVisualStyleBackColor = false;
            this.btnBaratos.Click += new System.EventHandler(this.btnBaratos_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodos.ForeColor = System.Drawing.Color.Red;
            this.btnTodos.Location = new System.Drawing.Point(398, 255);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(124, 28);
            this.btnTodos.TabIndex = 4;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = false;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblNome.Location = new System.Drawing.Point(534, 79);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 15);
            this.lblNome.TabIndex = 53;
            this.lblNome.Text = "Nome";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblData.Location = new System.Drawing.Point(535, 109);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(37, 15);
            this.lblData.TabIndex = 54;
            this.lblData.Text = "Data";
            // 
            // lblRealizador
            // 
            this.lblRealizador.AutoSize = true;
            this.lblRealizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRealizador.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblRealizador.Location = new System.Drawing.Point(535, 141);
            this.lblRealizador.Name = "lblRealizador";
            this.lblRealizador.Size = new System.Drawing.Size(77, 15);
            this.lblRealizador.TabIndex = 55;
            this.lblRealizador.Text = "Realizador";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = System.Drawing.Color.Yellow;
            this.lblPreco.Location = new System.Drawing.Point(535, 208);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(49, 16);
            this.lblPreco.TabIndex = 56;
            this.lblPreco.Text = "Preço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(574, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 57;
            this.label1.Text = "€";
            // 
            // btnDefinicoes
            // 
            this.btnDefinicoes.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnDefinicoes.BackgroundImage = global::Gestão_Base_de_Dados.Properties.Resources.defeniçõesIcon;
            this.btnDefinicoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefinicoes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDefinicoes.Location = new System.Drawing.Point(99, 302);
            this.btnDefinicoes.Name = "btnDefinicoes";
            this.btnDefinicoes.Size = new System.Drawing.Size(33, 33);
            this.btnDefinicoes.TabIndex = 2;
            this.btnDefinicoes.UseVisualStyleBackColor = false;
            this.btnDefinicoes.Click += new System.EventHandler(this.btnDefinicoes_Click);
            // 
            // pbFilme
            // 
            this.pbFilme.Image = global::Gestão_Base_de_Dados.Properties.Resources.aOrigem;
            this.pbFilme.Location = new System.Drawing.Point(411, 79);
            this.pbFilme.Name = "pbFilme";
            this.pbFilme.Size = new System.Drawing.Size(111, 154);
            this.pbFilme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFilme.TabIndex = 52;
            this.pbFilme.TabStop = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = global::Gestão_Base_de_Dados.Properties.Resources.Lupa;
            this.btnPesquisar.Image = global::Gestão_Base_de_Dados.Properties.Resources.Lupa;
            this.btnPesquisar.Location = new System.Drawing.Point(338, 293);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(17, 16);
            this.btnPesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPesquisar.TabIndex = 47;
            this.btnPesquisar.TabStop = false;
            // 
            // lblCheio
            // 
            this.lblCheio.AutoSize = true;
            this.lblCheio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheio.ForeColor = System.Drawing.Color.Gold;
            this.lblCheio.Location = new System.Drawing.Point(619, 212);
            this.lblCheio.Name = "lblCheio";
            this.lblCheio.Size = new System.Drawing.Size(53, 20);
            this.lblCheio.TabIndex = 58;
            this.lblCheio.Text = "       ♥";
            this.lblCheio.Visible = false;
            this.lblCheio.Click += new System.EventHandler(this.lblCheio_Click);
            // 
            // lblVazio
            // 
            this.lblVazio.AutoSize = true;
            this.lblVazio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVazio.ForeColor = System.Drawing.Color.Gold;
            this.lblVazio.Location = new System.Drawing.Point(648, 208);
            this.lblVazio.Name = "lblVazio";
            this.lblVazio.Size = new System.Drawing.Size(26, 29);
            this.lblVazio.TabIndex = 59;
            this.lblVazio.Text = "♡";
            this.lblVazio.Click += new System.EventHandler(this.lblVazio_Click);
            // 
            // btnTrailer
            // 
            this.btnTrailer.AutoSize = true;
            this.btnTrailer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrailer.ForeColor = System.Drawing.Color.Cyan;
            this.btnTrailer.Location = new System.Drawing.Point(535, 174);
            this.btnTrailer.Name = "btnTrailer";
            this.btnTrailer.Size = new System.Drawing.Size(49, 15);
            this.btnTrailer.TabIndex = 60;
            this.btnTrailer.Text = "Trailer";
            this.btnTrailer.Click += new System.EventHandler(this.btnTrailer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(619, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 58;
            this.label2.Text = "       ♥";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.lblCheio_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(648, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 29);
            this.label3.TabIndex = 59;
            this.label3.Text = "♡";
            this.label3.Click += new System.EventHandler(this.lblVazio_Click);
            // 
            // frmAluguer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(686, 362);
            this.Controls.Add(this.btnTrailer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblVazio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCheio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDefinicoes);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblRealizador);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.pbFilme);
            this.Controls.Add(this.btnBaratos);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.btnRecentes);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvDados);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAluguer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aluguer";
            this.Activated += new System.EventHandler(this.frmAluguer_Activated);
            this.Load += new System.EventHandler(this.frmAluguer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFilme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lvDados;
        private System.Windows.Forms.PictureBox btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnRecentes;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnBaratos;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.PictureBox pbFilme;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblRealizador;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Button btnDefinicoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCheio;
        private System.Windows.Forms.Label lblVazio;
        private System.Windows.Forms.Label btnTrailer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}