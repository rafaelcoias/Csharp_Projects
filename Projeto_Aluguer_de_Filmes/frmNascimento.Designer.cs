namespace Gestão_Base_de_Dados
{
    partial class frmNascimento
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
            this.btnSair = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sbAno = new System.Windows.Forms.VScrollBar();
            this.lblMes = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sbMes = new System.Windows.Forms.VScrollBar();
            this.lblDia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sbDia = new System.Windows.Forms.VScrollBar();
            this.tmTudo = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSair.Location = new System.Drawing.Point(12, 406);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(78, 32);
            this.btnSair.TabIndex = 50;
            this.btnSair.Text = "Voltar";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(139, 344);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 16);
            this.label9.TabIndex = 61;
            this.label9.Text = "/";
            this.label9.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(283, 344);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 16);
            this.label7.TabIndex = 60;
            this.label7.Text = "/";
            this.label7.Visible = false;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(341, 347);
            this.lblAno.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(35, 13);
            this.lblAno.TabIndex = 59;
            this.lblAno.Text = "2021";
            this.lblAno.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(333, 58);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 58;
            this.label8.Text = "  Ano";
            // 
            // sbAno
            // 
            this.sbAno.LargeChange = 1;
            this.sbAno.Location = new System.Drawing.Point(336, 89);
            this.sbAno.Maximum = 2021;
            this.sbAno.Minimum = 1950;
            this.sbAno.Name = "sbAno";
            this.sbAno.Size = new System.Drawing.Size(46, 244);
            this.sbAno.TabIndex = 57;
            this.sbAno.Value = 2000;
            this.sbAno.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbAno_Scroll);
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(205, 347);
            this.lblMes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(21, 13);
            this.lblMes.TabIndex = 56;
            this.lblMes.Text = "00";
            this.lblMes.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(195, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 55;
            this.label6.Text = " Mês";
            // 
            // sbMes
            // 
            this.sbMes.LargeChange = 1;
            this.sbMes.Location = new System.Drawing.Point(194, 89);
            this.sbMes.Maximum = 12;
            this.sbMes.Minimum = 1;
            this.sbMes.Name = "sbMes";
            this.sbMes.Size = new System.Drawing.Size(46, 244);
            this.sbMes.TabIndex = 54;
            this.sbMes.Value = 1;
            this.sbMes.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbMes_Scroll);
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(69, 344);
            this.lblDia.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(21, 13);
            this.lblDia.TabIndex = 53;
            this.lblDia.Text = "00";
            this.lblDia.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(54, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 52;
            this.label4.Text = "   Dia";
            // 
            // sbDia
            // 
            this.sbDia.LargeChange = 1;
            this.sbDia.Location = new System.Drawing.Point(57, 89);
            this.sbDia.Maximum = 31;
            this.sbDia.Minimum = 1;
            this.sbDia.Name = "sbDia";
            this.sbDia.Size = new System.Drawing.Size(46, 244);
            this.sbDia.TabIndex = 51;
            this.sbDia.Value = 1;
            this.sbDia.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbDia_Scroll);
            // 
            // tmTudo
            // 
            this.tmTudo.Enabled = true;
            this.tmTudo.Interval = 50;
            this.tmTudo.Tick += new System.EventHandler(this.tmTudo_Tick);
            // 
            // frmNascimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(437, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sbAno);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sbMes);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sbDia);
            this.Controls.Add(this.btnSair);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNascimento";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nascimento";
            this.Load += new System.EventHandler(this.frmNascimento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.VScrollBar sbAno;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.VScrollBar sbMes;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.VScrollBar sbDia;
        private System.Windows.Forms.Timer tmTudo;
    }
}