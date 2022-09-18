namespace Gestão_Base_de_Dados
{
    partial class frmFavoritos
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lvDados = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(60, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(269, 29);
            this.label7.TabIndex = 32;
            this.label7.Text = "FILMES FAVORITOS";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(32, 312);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(96, 33);
            this.btnVoltar.TabIndex = 33;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lvDados
            // 
            this.lvDados.BackColor = System.Drawing.Color.Maroon;
            this.lvDados.ForeColor = System.Drawing.SystemColors.Window;
            this.lvDados.HideSelection = false;
            this.lvDados.Location = new System.Drawing.Point(32, 82);
            this.lvDados.Name = "lvDados";
            this.lvDados.Size = new System.Drawing.Size(319, 208);
            this.lvDados.TabIndex = 34;
            this.lvDados.UseCompatibleStateImageBehavior = false;
            this.lvDados.DoubleClick += new System.EventHandler(this.lvDados_DoubleClick);
            // 
            // frmFavoritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(385, 366);
            this.Controls.Add(this.lvDados);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label7);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFavoritos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Favoritos";
            this.Load += new System.EventHandler(this.frmFavoritos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ListView lvDados;
    }
}