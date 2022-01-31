namespace Projeto_Relógio
{
    partial class frmPrincipal
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
            this.lblRelogio = new System.Windows.Forms.Label();
            this.tmHora = new System.Windows.Forms.Timer(this.components);
            this.lblHoras = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.rbOff = new System.Windows.Forms.RadioButton();
            this.rbOn = new System.Windows.Forms.RadioButton();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblDiaMes = new System.Windows.Forms.Label();
            this.lblHorasMinutos = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSair2 = new System.Windows.Forms.Button();
            this.tmAbrir = new System.Windows.Forms.Timer(this.components);
            this.tmFechar = new System.Windows.Forms.Timer(this.components);
            this.lblData = new System.Windows.Forms.Label();
            this.tmData = new System.Windows.Forms.Timer(this.components);
            this.tmAlarme = new System.Windows.Forms.Timer(this.components);
            this.btnCron = new System.Windows.Forms.Button();
            this.tmTSino = new System.Windows.Forms.Timer(this.components);
            this.tmTAlarme = new System.Windows.Forms.Timer(this.components);
            this.btnRMundial = new System.Windows.Forms.Button();
            this.tm1 = new System.Windows.Forms.Timer(this.components);
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRelogio
            // 
            this.lblRelogio.AutoSize = true;
            this.lblRelogio.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelogio.Location = new System.Drawing.Point(252, 17);
            this.lblRelogio.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRelogio.Name = "lblRelogio";
            this.lblRelogio.Size = new System.Drawing.Size(224, 73);
            this.lblRelogio.TabIndex = 0;
            this.lblRelogio.Text = "Relógio";
            this.lblRelogio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmHora
            // 
            this.tmHora.Enabled = true;
            this.tmHora.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("MS PGothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHoras.Location = new System.Drawing.Point(212, 156);
            this.lblHoras.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(292, 74);
            this.lblHoras.TabIndex = 2;
            this.lblHoras.Text = "00:00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-8, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(688, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "____________________________________________________";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSair.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(538, 344);
            this.btnSair.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(164, 67);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAbrir.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.Location = new System.Drawing.Point(24, 344);
            this.btnAbrir.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(70, 67);
            this.btnAbrir.TabIndex = 5;
            this.btnAbrir.Text = "↓";
            this.btnAbrir.UseVisualStyleBackColor = false;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.rbOff);
            this.gb1.Controls.Add(this.rbOn);
            this.gb1.Controls.Add(this.btnEditar);
            this.gb1.Controls.Add(this.lblDiaMes);
            this.gb1.Controls.Add(this.lblHorasMinutos);
            this.gb1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb1.Location = new System.Drawing.Point(26, 306);
            this.gb1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb1.Name = "gb1";
            this.gb1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb1.Size = new System.Drawing.Size(678, 283);
            this.gb1.TabIndex = 6;
            this.gb1.TabStop = false;
            this.gb1.Text = "Alarme";
            this.gb1.Visible = false;
            // 
            // rbOff
            // 
            this.rbOff.AutoSize = true;
            this.rbOff.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOff.Location = new System.Drawing.Point(548, 48);
            this.rbOff.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbOff.Name = "rbOff";
            this.rbOff.Size = new System.Drawing.Size(97, 44);
            this.rbOff.TabIndex = 13;
            this.rbOff.Text = "&Off";
            this.rbOff.UseVisualStyleBackColor = true;
            this.rbOff.Click += new System.EventHandler(this.rbOff_Click);
            // 
            // rbOn
            // 
            this.rbOn.AutoSize = true;
            this.rbOn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOn.Location = new System.Drawing.Point(422, 48);
            this.rbOn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbOn.Name = "rbOn";
            this.rbOn.Size = new System.Drawing.Size(92, 44);
            this.rbOn.TabIndex = 12;
            this.rbOn.Text = "&On";
            this.rbOn.UseVisualStyleBackColor = true;
            this.rbOn.Click += new System.EventHandler(this.rbOn_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(564, 227);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(102, 44);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblDiaMes
            // 
            this.lblDiaMes.AutoSize = true;
            this.lblDiaMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaMes.Location = new System.Drawing.Point(58, 177);
            this.lblDiaMes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDiaMes.Name = "lblDiaMes";
            this.lblDiaMes.Size = new System.Drawing.Size(155, 29);
            this.lblDiaMes.TabIndex = 10;
            this.lblDiaMes.Text = "01 / 01 / 2021";
            this.lblDiaMes.Visible = false;
            // 
            // lblHorasMinutos
            // 
            this.lblHorasMinutos.AutoSize = true;
            this.lblHorasMinutos.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasMinutos.Location = new System.Drawing.Point(80, 117);
            this.lblHorasMinutos.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHorasMinutos.Name = "lblHorasMinutos";
            this.lblHorasMinutos.Size = new System.Drawing.Size(120, 40);
            this.lblHorasMinutos.TabIndex = 2;
            this.lblHorasMinutos.Text = "00 : 00";
            this.lblHorasMinutos.Visible = false;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(24, 617);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(70, 67);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "↑";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSair2
            // 
            this.btnSair2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSair2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair2.Location = new System.Drawing.Point(538, 617);
            this.btnSair2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSair2.Name = "btnSair2";
            this.btnSair2.Size = new System.Drawing.Size(164, 67);
            this.btnSair2.TabIndex = 8;
            this.btnSair2.Text = "&Sair";
            this.btnSair2.UseVisualStyleBackColor = false;
            this.btnSair2.Click += new System.EventHandler(this.btnSair2_Click);
            // 
            // tmAbrir
            // 
            this.tmAbrir.Interval = 80;
            this.tmAbrir.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // tmFechar
            // 
            this.tmFechar.Interval = 80;
            this.tmFechar.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(284, 244);
            this.lblData.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(155, 29);
            this.lblData.TabIndex = 9;
            this.lblData.Text = "01 / 01 / 2021";
            // 
            // tmData
            // 
            this.tmData.Enabled = true;
            this.tmData.Tick += new System.EventHandler(this.tmData_Tick);
            // 
            // tmAlarme
            // 
            this.tmAlarme.Enabled = true;
            this.tmAlarme.Interval = 500;
            this.tmAlarme.Tick += new System.EventHandler(this.tmAlarme_Tick);
            // 
            // btnCron
            // 
            this.btnCron.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCron.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCron.Location = new System.Drawing.Point(114, 617);
            this.btnCron.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCron.Name = "btnCron";
            this.btnCron.Size = new System.Drawing.Size(198, 67);
            this.btnCron.TabIndex = 10;
            this.btnCron.Text = "&Cronómetro";
            this.btnCron.UseVisualStyleBackColor = false;
            this.btnCron.Click += new System.EventHandler(this.btnCron_Click);
            // 
            // tmTSino
            // 
            this.tmTSino.Interval = 60000;
            this.tmTSino.Tick += new System.EventHandler(this.tmT_Tick);
            // 
            // tmTAlarme
            // 
            this.tmTAlarme.Interval = 45000;
            this.tmTAlarme.Tick += new System.EventHandler(this.tmTAlarme_Tick);
            // 
            // btnRMundial
            // 
            this.btnRMundial.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRMundial.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRMundial.Location = new System.Drawing.Point(324, 617);
            this.btnRMundial.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRMundial.Name = "btnRMundial";
            this.btnRMundial.Size = new System.Drawing.Size(198, 67);
            this.btnRMundial.TabIndex = 11;
            this.btnRMundial.Text = "&Rel. Mundial";
            this.btnRMundial.UseVisualStyleBackColor = false;
            this.btnRMundial.Click += new System.EventHandler(this.btnRMundial_Click);
            // 
            // tm1
            // 
            this.tm1.Interval = 200;
            this.tm1.Tick += new System.EventHandler(this.tm1_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(728, 444);
            this.Controls.Add(this.btnRMundial);
            this.Controls.Add(this.btnCron);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.btnSair2);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.lblRelogio);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relógio";
            this.Activated += new System.EventHandler(this.frmPrincipal_Activated);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRelogio;
        private System.Windows.Forms.Timer tmHora;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSair2;
        private System.Windows.Forms.Timer tmAbrir;
        private System.Windows.Forms.Timer tmFechar;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Timer tmData;
        private System.Windows.Forms.Label lblHorasMinutos;
        private System.Windows.Forms.Label lblDiaMes;
        private System.Windows.Forms.Timer tmAlarme;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCron;
        private System.Windows.Forms.Timer tmTSino;
        private System.Windows.Forms.Timer tmTAlarme;
        private System.Windows.Forms.Button btnRMundial;
        private System.Windows.Forms.Timer tm1;
        private System.Windows.Forms.RadioButton rbOff;
        private System.Windows.Forms.RadioButton rbOn;
    }
}

