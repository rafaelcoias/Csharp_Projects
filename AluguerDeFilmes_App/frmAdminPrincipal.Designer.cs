namespace Gestão_Base_de_Dados
{
    partial class frmAdminPrincipal
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
            this.btnUtilizadores = new System.Windows.Forms.Button();
            this.btnFilmes = new System.Windows.Forms.Button();
            this.btnAlugueres = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(168, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(294, 36);
            this.label7.TabIndex = 29;
            this.label7.Text = "Bem-Vindo  Admistrador";
            // 
            // btnUtilizadores
            // 
            this.btnUtilizadores.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUtilizadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtilizadores.Location = new System.Drawing.Point(38, 109);
            this.btnUtilizadores.Name = "btnUtilizadores";
            this.btnUtilizadores.Size = new System.Drawing.Size(152, 49);
            this.btnUtilizadores.TabIndex = 1;
            this.btnUtilizadores.Text = "Ver Tabela de Utilizadores";
            this.btnUtilizadores.UseVisualStyleBackColor = false;
            this.btnUtilizadores.Click += new System.EventHandler(this.btnUtilizadores_Click);
            // 
            // btnFilmes
            // 
            this.btnFilmes.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnFilmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilmes.Location = new System.Drawing.Point(442, 109);
            this.btnFilmes.Name = "btnFilmes";
            this.btnFilmes.Size = new System.Drawing.Size(152, 49);
            this.btnFilmes.TabIndex = 3;
            this.btnFilmes.Text = "Ver Filmes Disponíveis";
            this.btnFilmes.UseVisualStyleBackColor = false;
            this.btnFilmes.Click += new System.EventHandler(this.btnFilmes_Click);
            // 
            // btnAlugueres
            // 
            this.btnAlugueres.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAlugueres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlugueres.Location = new System.Drawing.Point(238, 109);
            this.btnAlugueres.Name = "btnAlugueres";
            this.btnAlugueres.Size = new System.Drawing.Size(152, 49);
            this.btnAlugueres.TabIndex = 2;
            this.btnAlugueres.Text = "Ver Tabela de Alugueres";
            this.btnAlugueres.UseVisualStyleBackColor = false;
            this.btnAlugueres.Click += new System.EventHandler(this.btnAlugueres_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(12, 190);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 28);
            this.btnVoltar.TabIndex = 41;
            this.btnVoltar.Text = "Sair";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmAdminPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(649, 230);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAlugueres);
            this.Controls.Add(this.btnFilmes);
            this.Controls.Add(this.btnUtilizadores);
            this.Controls.Add(this.label7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdminPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admistrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUtilizadores;
        private System.Windows.Forms.Button btnFilmes;
        private System.Windows.Forms.Button btnAlugueres;
        private System.Windows.Forms.Button btnVoltar;
    }
}