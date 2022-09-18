namespace Projeto_Relógio
{
    partial class frmAlarme
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblAlarme = new System.Windows.Forms.Label();
            this.sbHoras = new System.Windows.Forms.VScrollBar();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sbMinutos = new System.Windows.Forms.VScrollBar();
            this.label4 = new System.Windows.Forms.Label();
            this.sbDia = new System.Windows.Forms.VScrollBar();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sbMes = new System.Windows.Forms.VScrollBar();
            this.lblAno = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sbAno = new System.Windows.Forms.VScrollBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tmTudo = new System.Windows.Forms.Timer(this.components);
            this.btnMudarSom = new System.Windows.Forms.Button();
            this.tm1 = new System.Windows.Forms.Timer(this.components);
            this.btnDescrição = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(688, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "____________________________________________________";
            // 
            // lblAlarme
            // 
            this.lblAlarme.AutoSize = true;
            this.lblAlarme.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlarme.Location = new System.Drawing.Point(248, 17);
            this.lblAlarme.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAlarme.Name = "lblAlarme";
            this.lblAlarme.Size = new System.Drawing.Size(216, 73);
            this.lblAlarme.TabIndex = 4;
            this.lblAlarme.Text = "Alarme";
            this.lblAlarme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sbHoras
            // 
            this.sbHoras.LargeChange = 1;
            this.sbHoras.Location = new System.Drawing.Point(26, 175);
            this.sbHoras.Maximum = 23;
            this.sbHoras.Name = "sbHoras";
            this.sbHoras.Size = new System.Drawing.Size(46, 598);
            this.sbHoras.TabIndex = 6;
            this.sbHoras.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbHoras_Scroll);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(540, 883);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(6);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(164, 67);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "Horas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "  Minutos";
            // 
            // sbMinutos
            // 
            this.sbMinutos.LargeChange = 1;
            this.sbMinutos.Location = new System.Drawing.Point(164, 175);
            this.sbMinutos.Maximum = 59;
            this.sbMinutos.Name = "sbMinutos";
            this.sbMinutos.Size = new System.Drawing.Size(46, 598);
            this.sbMinutos.TabIndex = 11;
            this.sbMinutos.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbMinutos_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(328, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 30);
            this.label4.TabIndex = 14;
            this.label4.Text = "  Dia";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // sbDia
            // 
            this.sbDia.LargeChange = 1;
            this.sbDia.Location = new System.Drawing.Point(334, 175);
            this.sbDia.Maximum = 31;
            this.sbDia.Minimum = 1;
            this.sbDia.Name = "sbDia";
            this.sbDia.Size = new System.Drawing.Size(46, 598);
            this.sbDia.TabIndex = 13;
            this.sbDia.Value = 1;
            this.sbDia.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbDia_Scroll);
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.Location = new System.Drawing.Point(52, 808);
            this.lblHoras.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(25, 26);
            this.lblHoras.TabIndex = 15;
            this.lblHoras.Text = "0";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutos.Location = new System.Drawing.Point(194, 808);
            this.lblMinutos.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(25, 26);
            this.lblMinutos.TabIndex = 16;
            this.lblMinutos.Text = "0";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(362, 808);
            this.lblDia.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(25, 26);
            this.lblDia.TabIndex = 17;
            this.lblDia.Text = "0";
            this.lblDia.Click += new System.EventHandler(this.lblDia_Click);
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(500, 808);
            this.lblMes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(25, 26);
            this.lblMes.TabIndex = 20;
            this.lblMes.Text = "0";
            this.lblMes.Click += new System.EventHandler(this.lblMes_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(466, 131);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 30);
            this.label6.TabIndex = 19;
            this.label6.Text = "  Mês";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // sbMes
            // 
            this.sbMes.LargeChange = 1;
            this.sbMes.Location = new System.Drawing.Point(472, 175);
            this.sbMes.Maximum = 12;
            this.sbMes.Minimum = 1;
            this.sbMes.Name = "sbMes";
            this.sbMes.Size = new System.Drawing.Size(46, 598);
            this.sbMes.TabIndex = 18;
            this.sbMes.Value = 1;
            this.sbMes.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbMes_Scroll);
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(622, 808);
            this.lblAno.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(64, 26);
            this.lblAno.TabIndex = 23;
            this.lblAno.Text = "2021";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(606, 131);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 30);
            this.label8.TabIndex = 22;
            this.label8.Text = "  Ano";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // sbAno
            // 
            this.sbAno.LargeChange = 1;
            this.sbAno.Location = new System.Drawing.Point(612, 175);
            this.sbAno.Maximum = 2050;
            this.sbAno.Minimum = 2021;
            this.sbAno.Name = "sbAno";
            this.sbAno.Size = new System.Drawing.Size(46, 598);
            this.sbAno.TabIndex = 21;
            this.sbAno.Value = 2021;
            this.sbAno.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbAno_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(134, 802);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 30);
            this.label5.TabIndex = 24;
            this.label5.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(586, 802);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 30);
            this.label7.TabIndex = 25;
            this.label7.Text = "/";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(444, 802);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 30);
            this.label9.TabIndex = 26;
            this.label9.Text = "/";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // tmTudo
            // 
            this.tmTudo.Enabled = true;
            this.tmTudo.Interval = 50;
            this.tmTudo.Tick += new System.EventHandler(this.tmTudo_Tick);
            // 
            // btnMudarSom
            // 
            this.btnMudarSom.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMudarSom.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMudarSom.Location = new System.Drawing.Point(24, 883);
            this.btnMudarSom.Margin = new System.Windows.Forms.Padding(6);
            this.btnMudarSom.Name = "btnMudarSom";
            this.btnMudarSom.Size = new System.Drawing.Size(232, 67);
            this.btnMudarSom.TabIndex = 27;
            this.btnMudarSom.Text = "&Mudar Música";
            this.btnMudarSom.UseVisualStyleBackColor = false;
            this.btnMudarSom.Click += new System.EventHandler(this.btnMudarSom_Click);
            // 
            // tm1
            // 
            this.tm1.Interval = 200;
            this.tm1.Tick += new System.EventHandler(this.tm1_Tick);
            // 
            // btnDescrição
            // 
            this.btnDescrição.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDescrição.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescrição.Location = new System.Drawing.Point(288, 883);
            this.btnDescrição.Margin = new System.Windows.Forms.Padding(6);
            this.btnDescrição.Name = "btnDescrição";
            this.btnDescrição.Size = new System.Drawing.Size(218, 67);
            this.btnDescrição.TabIndex = 28;
            this.btnDescrição.Text = "&Descrição";
            this.btnDescrição.UseVisualStyleBackColor = false;
            this.btnDescrição.Click += new System.EventHandler(this.btnDescrição_Click);
            // 
            // frmAlarme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(728, 983);
            this.Controls.Add(this.btnDescrição);
            this.Controls.Add(this.btnMudarSom);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sbAno);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sbMes);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.lblMinutos);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sbDia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sbMinutos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.sbHoras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAlarme);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlarme";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarme";
            this.Activated += new System.EventHandler(this.frmAlarme_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAlarme_FormClosing);
            this.Load += new System.EventHandler(this.frmAlarme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAlarme;
        private System.Windows.Forms.VScrollBar sbHoras;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.VScrollBar sbMinutos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.VScrollBar sbDia;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.VScrollBar sbMes;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.VScrollBar sbAno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer tmTudo;
        private System.Windows.Forms.Button btnMudarSom;
        private System.Windows.Forms.Timer tm1;
        private System.Windows.Forms.Button btnDescrição;
    }
}