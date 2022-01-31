namespace Projeto_EuroMilhoes
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
            this.btnVer = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.cbN1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbox = new System.Windows.Forms.ListBox();
            this.lblSemanas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVer
            // 
            this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.Location = new System.Drawing.Point(291, 194);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(77, 36);
            this.btnVer.TabIndex = 2;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(374, 194);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(79, 36);
            this.btnApagar.TabIndex = 3;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(459, 194);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(84, 36);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // cbN1
            // 
            this.cbN1.BackColor = System.Drawing.SystemColors.Info;
            this.cbN1.FormattingEnabled = true;
            this.cbN1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbN1.Location = new System.Drawing.Point(291, 58);
            this.cbN1.Name = "cbN1";
            this.cbN1.Size = new System.Drawing.Size(252, 21);
            this.cbN1.TabIndex = 11;
            this.cbN1.SelectedIndexChanged += new System.EventHandler(this.cbN1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "   Criar quantas chaves aleatórias ?";
            // 
            // lbox
            // 
            this.lbox.BackColor = System.Drawing.SystemColors.Info;
            this.lbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbox.FormattingEnabled = true;
            this.lbox.ItemHeight = 16;
            this.lbox.Location = new System.Drawing.Point(12, 5);
            this.lbox.Name = "lbox";
            this.lbox.Size = new System.Drawing.Size(270, 212);
            this.lbox.TabIndex = 13;
            // 
            // lblSemanas
            // 
            this.lblSemanas.AutoSize = true;
            this.lblSemanas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemanas.Location = new System.Drawing.Point(403, 99);
            this.lblSemanas.Name = "lblSemanas";
            this.lblSemanas.Size = new System.Drawing.Size(23, 15);
            this.lblSemanas.TabIndex = 14;
            this.lblSemanas.Text = "00";
            // 
            // frmHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(555, 242);
            this.Controls.Add(this.lblSemanas);
            this.Controls.Add(this.lbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbN1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnVer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHistorico";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chaves Aleatórias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox cbN1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbox;
        private System.Windows.Forms.Label lblSemanas;
    }
}