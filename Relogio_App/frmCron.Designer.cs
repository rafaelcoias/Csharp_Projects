namespace Projeto_Relógio
{
    partial class frmCron
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
            this.lblCron = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnVolta = new System.Windows.Forms.Button();
            this.btnRepor = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.tmCron = new System.Windows.Forms.Timer(this.components);
            this.lblMinutos = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.lblMil = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRetomar = new System.Windows.Forms.Button();
            this.lblVolta = new System.Windows.Forms.Label();
            this.lblVolta2 = new System.Windows.Forms.Label();
            this.lblVolta3 = new System.Windows.Forms.Label();
            this.lblVolta6 = new System.Windows.Forms.Label();
            this.lblVolta5 = new System.Windows.Forms.Label();
            this.lblVolta4 = new System.Windows.Forms.Label();
            this.lblVolta9 = new System.Windows.Forms.Label();
            this.lblVolta8 = new System.Windows.Forms.Label();
            this.lblVolta7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCron
            // 
            this.lblCron.AutoSize = true;
            this.lblCron.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCron.Location = new System.Drawing.Point(100, 9);
            this.lblCron.Name = "lblCron";
            this.lblCron.Size = new System.Drawing.Size(168, 37);
            this.lblCron.TabIndex = 1;
            this.lblCron.Text = "Cronómetro";
            this.lblCron.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "____________________________________________________";
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(142, 238);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(85, 45);
            this.btnIniciar.TabIndex = 10;
            this.btnIniciar.Text = "&Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnVolta
            // 
            this.btnVolta.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnVolta.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolta.Location = new System.Drawing.Point(90, 238);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(85, 45);
            this.btnVolta.TabIndex = 11;
            this.btnVolta.Text = "&Marcar";
            this.btnVolta.UseVisualStyleBackColor = false;
            this.btnVolta.Visible = false;
            this.btnVolta.Click += new System.EventHandler(this.btnVolta_Click);
            // 
            // btnRepor
            // 
            this.btnRepor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRepor.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepor.Location = new System.Drawing.Point(90, 238);
            this.btnRepor.Name = "btnRepor";
            this.btnRepor.Size = new System.Drawing.Size(85, 45);
            this.btnRepor.TabIndex = 12;
            this.btnRepor.Text = "&Repor";
            this.btnRepor.UseVisualStyleBackColor = false;
            this.btnRepor.Visible = false;
            this.btnRepor.Click += new System.EventHandler(this.btnRepor_Click);
            // 
            // btnParar
            // 
            this.btnParar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnParar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParar.Location = new System.Drawing.Point(192, 238);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(85, 45);
            this.btnParar.TabIndex = 13;
            this.btnParar.Text = "&Parar";
            this.btnParar.UseVisualStyleBackColor = false;
            this.btnParar.Visible = false;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(267, 454);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(85, 45);
            this.btnVoltar.TabIndex = 14;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // tmCron
            // 
            this.tmCron.Tick += new System.EventHandler(this.tmCron_Tick);
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Font = new System.Drawing.Font("MS PGothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutos.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMinutos.Location = new System.Drawing.Point(83, 127);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(57, 37);
            this.lblMinutos.TabIndex = 15;
            this.lblMinutos.Text = "00";
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Font = new System.Drawing.Font("MS PGothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundos.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSegundos.Location = new System.Drawing.Point(156, 127);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(57, 37);
            this.lblSegundos.TabIndex = 16;
            this.lblSegundos.Text = "00";
            // 
            // lblMil
            // 
            this.lblMil.AutoSize = true;
            this.lblMil.Font = new System.Drawing.Font("MS PGothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMil.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMil.Location = new System.Drawing.Point(229, 127);
            this.lblMil.Name = "lblMil";
            this.lblMil.Size = new System.Drawing.Size(57, 37);
            this.lblMil.TabIndex = 17;
            this.lblMil.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS PGothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(135, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 37);
            this.label4.TabIndex = 18;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS PGothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(208, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 37);
            this.label5.TabIndex = 19;
            this.label5.Text = ":";
            // 
            // btnRetomar
            // 
            this.btnRetomar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRetomar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetomar.Location = new System.Drawing.Point(192, 238);
            this.btnRetomar.Name = "btnRetomar";
            this.btnRetomar.Size = new System.Drawing.Size(85, 45);
            this.btnRetomar.TabIndex = 20;
            this.btnRetomar.Text = "Retomar";
            this.btnRetomar.UseVisualStyleBackColor = false;
            this.btnRetomar.Visible = false;
            this.btnRetomar.Click += new System.EventHandler(this.btnRetomar_Click);
            // 
            // lblVolta
            // 
            this.lblVolta.AutoSize = true;
            this.lblVolta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolta.Location = new System.Drawing.Point(122, 298);
            this.lblVolta.Name = "lblVolta";
            this.lblVolta.Size = new System.Drawing.Size(114, 15);
            this.lblVolta.TabIndex = 22;
            this.lblVolta.Text = "Volta1 -  00 : 00 : 00";
            this.lblVolta.Visible = false;
            // 
            // lblVolta2
            // 
            this.lblVolta2.AutoSize = true;
            this.lblVolta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolta2.Location = new System.Drawing.Point(122, 313);
            this.lblVolta2.Name = "lblVolta2";
            this.lblVolta2.Size = new System.Drawing.Size(114, 15);
            this.lblVolta2.TabIndex = 24;
            this.lblVolta2.Text = "Volta2 -  00 : 00 : 00";
            this.lblVolta2.Visible = false;
            // 
            // lblVolta3
            // 
            this.lblVolta3.AutoSize = true;
            this.lblVolta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolta3.Location = new System.Drawing.Point(122, 328);
            this.lblVolta3.Name = "lblVolta3";
            this.lblVolta3.Size = new System.Drawing.Size(114, 15);
            this.lblVolta3.TabIndex = 25;
            this.lblVolta3.Text = "Volta3 -  00 : 00 : 00";
            this.lblVolta3.Visible = false;
            // 
            // lblVolta6
            // 
            this.lblVolta6.AutoSize = true;
            this.lblVolta6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolta6.Location = new System.Drawing.Point(122, 373);
            this.lblVolta6.Name = "lblVolta6";
            this.lblVolta6.Size = new System.Drawing.Size(114, 15);
            this.lblVolta6.TabIndex = 28;
            this.lblVolta6.Text = "Volta6 -  00 : 00 : 00";
            this.lblVolta6.Visible = false;
            // 
            // lblVolta5
            // 
            this.lblVolta5.AutoSize = true;
            this.lblVolta5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolta5.Location = new System.Drawing.Point(122, 358);
            this.lblVolta5.Name = "lblVolta5";
            this.lblVolta5.Size = new System.Drawing.Size(114, 15);
            this.lblVolta5.TabIndex = 27;
            this.lblVolta5.Text = "Volta5 -  00 : 00 : 00";
            this.lblVolta5.Visible = false;
            // 
            // lblVolta4
            // 
            this.lblVolta4.AutoSize = true;
            this.lblVolta4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolta4.Location = new System.Drawing.Point(122, 343);
            this.lblVolta4.Name = "lblVolta4";
            this.lblVolta4.Size = new System.Drawing.Size(114, 15);
            this.lblVolta4.TabIndex = 26;
            this.lblVolta4.Text = "Volta4 -  00 : 00 : 00";
            this.lblVolta4.Visible = false;
            // 
            // lblVolta9
            // 
            this.lblVolta9.AutoSize = true;
            this.lblVolta9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolta9.Location = new System.Drawing.Point(122, 419);
            this.lblVolta9.Name = "lblVolta9";
            this.lblVolta9.Size = new System.Drawing.Size(114, 15);
            this.lblVolta9.TabIndex = 31;
            this.lblVolta9.Text = "Volta9 -  00 : 00 : 00";
            this.lblVolta9.Visible = false;
            // 
            // lblVolta8
            // 
            this.lblVolta8.AutoSize = true;
            this.lblVolta8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolta8.Location = new System.Drawing.Point(122, 404);
            this.lblVolta8.Name = "lblVolta8";
            this.lblVolta8.Size = new System.Drawing.Size(114, 15);
            this.lblVolta8.TabIndex = 30;
            this.lblVolta8.Text = "Volta8 -  00 : 00 : 00";
            this.lblVolta8.Visible = false;
            // 
            // lblVolta7
            // 
            this.lblVolta7.AutoSize = true;
            this.lblVolta7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolta7.Location = new System.Drawing.Point(122, 389);
            this.lblVolta7.Name = "lblVolta7";
            this.lblVolta7.Size = new System.Drawing.Size(114, 15);
            this.lblVolta7.TabIndex = 29;
            this.lblVolta7.Text = "Volta7 -  00 : 00 : 00";
            this.lblVolta7.Visible = false;
            // 
            // frmCron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(364, 511);
            this.Controls.Add(this.lblVolta9);
            this.Controls.Add(this.lblVolta8);
            this.Controls.Add(this.lblVolta7);
            this.Controls.Add(this.lblVolta6);
            this.Controls.Add(this.lblVolta5);
            this.Controls.Add(this.lblVolta4);
            this.Controls.Add(this.lblVolta3);
            this.Controls.Add(this.lblVolta2);
            this.Controls.Add(this.lblVolta);
            this.Controls.Add(this.btnRetomar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMil);
            this.Controls.Add(this.lblSegundos);
            this.Controls.Add(this.lblMinutos);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnRepor);
            this.Controls.Add(this.btnVolta);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCron);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCron";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cronómetro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCron;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnVolta;
        private System.Windows.Forms.Button btnRepor;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Timer tmCron;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.Label lblMil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRetomar;
        private System.Windows.Forms.Label lblVolta;
        private System.Windows.Forms.Label lblVolta2;
        private System.Windows.Forms.Label lblVolta3;
        private System.Windows.Forms.Label lblVolta6;
        private System.Windows.Forms.Label lblVolta5;
        private System.Windows.Forms.Label lblVolta4;
        private System.Windows.Forms.Label lblVolta9;
        private System.Windows.Forms.Label lblVolta8;
        private System.Windows.Forms.Label lblVolta7;
    }
}