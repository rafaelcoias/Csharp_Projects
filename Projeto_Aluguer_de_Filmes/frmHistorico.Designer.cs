namespace Gestão_Base_de_Dados
{
    partial class frmHistorico
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
            this.btnAntigo = new System.Windows.Forms.Button();
            this.btnRecente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(233, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(295, 58);
            this.label7.TabIndex = 32;
            this.label7.Text = "HISTÓRICO";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(56, 625);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(192, 63);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lvDados
            // 
            this.lvDados.BackColor = System.Drawing.Color.Maroon;
            this.lvDados.ForeColor = System.Drawing.SystemColors.Window;
            this.lvDados.HideSelection = false;
            this.lvDados.Location = new System.Drawing.Point(56, 187);
            this.lvDados.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lvDados.Name = "lvDados";
            this.lvDados.Size = new System.Drawing.Size(634, 396);
            this.lvDados.TabIndex = 58;
            this.lvDados.UseCompatibleStateImageBehavior = false;
            this.lvDados.DoubleClick += new System.EventHandler(this.lvDados_DoubleClick);
            // 
            // btnAntigo
            // 
            this.btnAntigo.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnAntigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAntigo.ForeColor = System.Drawing.Color.Red;
            this.btnAntigo.Location = new System.Drawing.Point(530, 598);
            this.btnAntigo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAntigo.Name = "btnAntigo";
            this.btnAntigo.Size = new System.Drawing.Size(164, 54);
            this.btnAntigo.TabIndex = 3;
            this.btnAntigo.Text = "Antigos";
            this.btnAntigo.UseVisualStyleBackColor = false;
            this.btnAntigo.Click += new System.EventHandler(this.btnAntigo_Click);
            // 
            // btnRecente
            // 
            this.btnRecente.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnRecente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecente.ForeColor = System.Drawing.Color.Red;
            this.btnRecente.Location = new System.Drawing.Point(364, 598);
            this.btnRecente.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRecente.Name = "btnRecente";
            this.btnRecente.Size = new System.Drawing.Size(164, 54);
            this.btnRecente.TabIndex = 2;
            this.btnRecente.Text = "Recentes";
            this.btnRecente.UseVisualStyleBackColor = false;
            this.btnRecente.Click += new System.EventHandler(this.btnRecente_Click);
            // 
            // frmHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(754, 746);
            this.Controls.Add(this.btnRecente);
            this.Controls.Add(this.btnAntigo);
            this.Controls.Add(this.lvDados);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label7);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHistorico";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histórico";
            this.Load += new System.EventHandler(this.frmHistorico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ListView lvDados;
        private System.Windows.Forms.Button btnAntigo;
        private System.Windows.Forms.Button btnRecente;
    }
}