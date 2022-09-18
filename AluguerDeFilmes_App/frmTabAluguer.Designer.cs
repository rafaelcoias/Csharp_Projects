namespace Gestão_Base_de_Dados
{
    partial class frmTabAluguer
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
            this.btnPesquisar = new System.Windows.Forms.PictureBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPreco = new System.Windows.Forms.Button();
            this.btnID = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.btnFilme = new System.Windows.Forms.Button();
            this.btnUtilizador = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisar)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(250, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 36);
            this.label7.TabIndex = 29;
            this.label7.Text = "Tabela de Alugueres";
            // 
            // lvDados
            // 
            this.lvDados.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lvDados.HideSelection = false;
            this.lvDados.Location = new System.Drawing.Point(48, 84);
            this.lvDados.Name = "lvDados";
            this.lvDados.Size = new System.Drawing.Size(656, 319);
            this.lvDados.TabIndex = 30;
            this.lvDados.UseCompatibleStateImageBehavior = false;
            this.lvDados.DoubleClick += new System.EventHandler(this.lvDados_DoubleClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = global::Gestão_Base_de_Dados.Properties.Resources.Lupa;
            this.btnPesquisar.Image = global::Gestão_Base_de_Dados.Properties.Resources.Lupa;
            this.btnPesquisar.Location = new System.Drawing.Point(674, 416);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(17, 16);
            this.btnPesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPesquisar.TabIndex = 33;
            this.btnPesquisar.TabStop = false;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(582, 438);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(122, 20);
            this.txtPesquisa.TabIndex = 31;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(601, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Procurar";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(48, 429);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(78, 31);
            this.btnVoltar.TabIndex = 34;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnPreco
            // 
            this.btnPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreco.Location = new System.Drawing.Point(419, 84);
            this.btnPreco.Name = "btnPreco";
            this.btnPreco.Size = new System.Drawing.Size(142, 23);
            this.btnPreco.TabIndex = 38;
            this.btnPreco.Text = "Preço do Aluguer";
            this.btnPreco.UseVisualStyleBackColor = true;
            this.btnPreco.Click += new System.EventHandler(this.btnPreco_Click);
            // 
            // btnID
            // 
            this.btnID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnID.Location = new System.Drawing.Point(48, 84);
            this.btnID.Name = "btnID";
            this.btnID.Size = new System.Drawing.Size(69, 23);
            this.btnID.TabIndex = 35;
            this.btnID.Text = "N.º";
            this.btnID.UseVisualStyleBackColor = true;
            this.btnID.Click += new System.EventHandler(this.btnID_Click);
            // 
            // btnData
            // 
            this.btnData.BackColor = System.Drawing.Color.Yellow;
            this.btnData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnData.Location = new System.Drawing.Point(282, 84);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(141, 23);
            this.btnData.TabIndex = 37;
            this.btnData.Text = "Data do Aluguer";
            this.btnData.UseVisualStyleBackColor = false;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnFilme
            // 
            this.btnFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilme.Location = new System.Drawing.Point(116, 84);
            this.btnFilme.Name = "btnFilme";
            this.btnFilme.Size = new System.Drawing.Size(168, 23);
            this.btnFilme.TabIndex = 36;
            this.btnFilme.Text = "Nome do Filme";
            this.btnFilme.UseVisualStyleBackColor = true;
            this.btnFilme.Click += new System.EventHandler(this.btnFilme_Click);
            // 
            // btnUtilizador
            // 
            this.btnUtilizador.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUtilizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtilizador.Location = new System.Drawing.Point(558, 84);
            this.btnUtilizador.Name = "btnUtilizador";
            this.btnUtilizador.Size = new System.Drawing.Size(145, 23);
            this.btnUtilizador.TabIndex = 39;
            this.btnUtilizador.Text = "Utilizador";
            this.btnUtilizador.UseVisualStyleBackColor = false;
            this.btnUtilizador.Click += new System.EventHandler(this.btnUtilizador_Click);
            // 
            // frmTabAluguer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(751, 478);
            this.Controls.Add(this.btnUtilizador);
            this.Controls.Add(this.btnPreco);
            this.Controls.Add(this.btnID);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.btnFilme);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvDados);
            this.Controls.Add(this.label7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTabAluguer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alugueres";
            this.Load += new System.EventHandler(this.frmTabAluguer_Load);
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
        private System.Windows.Forms.Button btnPreco;
        private System.Windows.Forms.Button btnID;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnFilme;
        private System.Windows.Forms.Button btnUtilizador;
    }
}