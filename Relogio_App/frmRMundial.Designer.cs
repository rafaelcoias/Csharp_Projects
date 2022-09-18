namespace Projeto_Relógio
{
    partial class frmRMundial
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
            this.lblRelogio = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDiaL = new System.Windows.Forms.Label();
            this.lblLondres = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDiaM = new System.Windows.Forms.Label();
            this.lblMadrid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblDiaN = new System.Windows.Forms.Label();
            this.lblNova = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblDiaT = new System.Windows.Forms.Label();
            this.lblToquio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tmLondres = new System.Windows.Forms.Timer(this.components);
            this.tmMadrid = new System.Windows.Forms.Timer(this.components);
            this.tmNova = new System.Windows.Forms.Timer(this.components);
            this.tmToquio = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "____________________________________________________";
            // 
            // lblRelogio
            // 
            this.lblRelogio.AutoSize = true;
            this.lblRelogio.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelogio.Location = new System.Drawing.Point(65, 9);
            this.lblRelogio.Name = "lblRelogio";
            this.lblRelogio.Size = new System.Drawing.Size(230, 37);
            this.lblRelogio.TabIndex = 4;
            this.lblRelogio.Text = "Relógio Mundial";
            this.lblRelogio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(260, 462);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(92, 37);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDiaL);
            this.groupBox1.Controls.Add(this.lblLondres);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(24, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 88);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // lblDiaL
            // 
            this.lblDiaL.AutoSize = true;
            this.lblDiaL.Location = new System.Drawing.Point(26, 57);
            this.lblDiaL.Name = "lblDiaL";
            this.lblDiaL.Size = new System.Drawing.Size(42, 13);
            this.lblDiaL.TabIndex = 24;
            this.lblDiaL.Text = "01 / 01";
            // 
            // lblLondres
            // 
            this.lblLondres.AutoSize = true;
            this.lblLondres.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLondres.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLondres.Location = new System.Drawing.Point(166, 38);
            this.lblLondres.Name = "lblLondres";
            this.lblLondres.Size = new System.Drawing.Size(120, 21);
            this.lblLondres.TabIndex = 20;
            this.lblLondres.Text = "00 : 00 : 00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Londres";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDiaM);
            this.groupBox2.Controls.Add(this.lblMadrid);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(24, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 88);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // lblDiaM
            // 
            this.lblDiaM.AutoSize = true;
            this.lblDiaM.Location = new System.Drawing.Point(26, 58);
            this.lblDiaM.Name = "lblDiaM";
            this.lblDiaM.Size = new System.Drawing.Size(42, 13);
            this.lblDiaM.TabIndex = 22;
            this.lblDiaM.Text = "01 / 01";
            // 
            // lblMadrid
            // 
            this.lblMadrid.AutoSize = true;
            this.lblMadrid.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMadrid.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMadrid.Location = new System.Drawing.Point(166, 35);
            this.lblMadrid.Name = "lblMadrid";
            this.lblMadrid.Size = new System.Drawing.Size(120, 21);
            this.lblMadrid.TabIndex = 21;
            this.lblMadrid.Text = "00 : 00 : 00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Madrid";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblDiaN);
            this.groupBox3.Controls.Add(this.lblNova);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(24, 262);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 88);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // lblDiaN
            // 
            this.lblDiaN.AutoSize = true;
            this.lblDiaN.Location = new System.Drawing.Point(26, 58);
            this.lblDiaN.Name = "lblDiaN";
            this.lblDiaN.Size = new System.Drawing.Size(42, 13);
            this.lblDiaN.TabIndex = 23;
            this.lblDiaN.Text = "01 / 01";
            // 
            // lblNova
            // 
            this.lblNova.AutoSize = true;
            this.lblNova.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNova.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNova.Location = new System.Drawing.Point(166, 37);
            this.lblNova.Name = "lblNova";
            this.lblNova.Size = new System.Drawing.Size(120, 21);
            this.lblNova.TabIndex = 22;
            this.lblNova.Text = "00 : 00 : 00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nova Iorque";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblDiaT);
            this.groupBox4.Controls.Add(this.lblToquio);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(24, 356);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(312, 88);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            // 
            // lblDiaT
            // 
            this.lblDiaT.AutoSize = true;
            this.lblDiaT.Location = new System.Drawing.Point(26, 57);
            this.lblDiaT.Name = "lblDiaT";
            this.lblDiaT.Size = new System.Drawing.Size(42, 13);
            this.lblDiaT.TabIndex = 24;
            this.lblDiaT.Text = "01 / 01";
            // 
            // lblToquio
            // 
            this.lblToquio.AutoSize = true;
            this.lblToquio.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToquio.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblToquio.Location = new System.Drawing.Point(166, 38);
            this.lblToquio.Name = "lblToquio";
            this.lblToquio.Size = new System.Drawing.Size(120, 21);
            this.lblToquio.TabIndex = 23;
            this.lblToquio.Text = "00 : 00 : 00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Toquio";
            // 
            // tmLondres
            // 
            this.tmLondres.Enabled = true;
            this.tmLondres.Tick += new System.EventHandler(this.tmLondres_Tick);
            // 
            // tmMadrid
            // 
            this.tmMadrid.Enabled = true;
            this.tmMadrid.Tick += new System.EventHandler(this.tmMadrid_Tick);
            // 
            // tmNova
            // 
            this.tmNova.Enabled = true;
            this.tmNova.Tick += new System.EventHandler(this.tmNova_Tick);
            // 
            // tmToquio
            // 
            this.tmToquio.Enabled = true;
            this.tmToquio.Tick += new System.EventHandler(this.tmToquio_Tick);
            // 
            // frmRMundial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(364, 511);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRelogio);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRMundial";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relógio Mundial";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRelogio;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLondres;
        private System.Windows.Forms.Label lblMadrid;
        private System.Windows.Forms.Label lblNova;
        private System.Windows.Forms.Label lblToquio;
        private System.Windows.Forms.Timer tmLondres;
        private System.Windows.Forms.Timer tmMadrid;
        private System.Windows.Forms.Timer tmNova;
        private System.Windows.Forms.Timer tmToquio;
        private System.Windows.Forms.Label lblDiaL;
        private System.Windows.Forms.Label lblDiaM;
        private System.Windows.Forms.Label lblDiaN;
        private System.Windows.Forms.Label lblDiaT;
    }
}