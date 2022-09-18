namespace Projeto_Relógio
{
    partial class frmToque
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMusica1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbMusica2 = new System.Windows.Forms.RadioButton();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbMusica3 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMudar = new System.Windows.Forms.Button();
            this.rbNovaMusica = new System.Windows.Forms.RadioButton();
            this.tm1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-8, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(688, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "____________________________________________________";
            // 
            // lblRelogio
            // 
            this.lblRelogio.AutoSize = true;
            this.lblRelogio.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelogio.Location = new System.Drawing.Point(162, 17);
            this.lblRelogio.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRelogio.Name = "lblRelogio";
            this.lblRelogio.Size = new System.Drawing.Size(403, 73);
            this.lblRelogio.TabIndex = 4;
            this.lblRelogio.Text = "Som do alarme";
            this.lblRelogio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMusica1);
            this.groupBox1.Location = new System.Drawing.Point(24, 146);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(680, 169);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // rbMusica1
            // 
            this.rbMusica1.AutoSize = true;
            this.rbMusica1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMusica1.Location = new System.Drawing.Point(56, 69);
            this.rbMusica1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbMusica1.Name = "rbMusica1";
            this.rbMusica1.Size = new System.Drawing.Size(193, 41);
            this.rbMusica1.TabIndex = 0;
            this.rbMusica1.Text = " &Creative ";
            this.rbMusica1.UseVisualStyleBackColor = true;
            this.rbMusica1.Click += new System.EventHandler(this.rbMusica1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbMusica2);
            this.groupBox2.Location = new System.Drawing.Point(24, 327);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(680, 169);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // rbMusica2
            // 
            this.rbMusica2.AutoSize = true;
            this.rbMusica2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMusica2.Location = new System.Drawing.Point(56, 71);
            this.rbMusica2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbMusica2.Name = "rbMusica2";
            this.rbMusica2.Size = new System.Drawing.Size(172, 41);
            this.rbMusica2.TabIndex = 1;
            this.rbMusica2.Text = " &Waking";
            this.rbMusica2.UseVisualStyleBackColor = true;
            this.rbMusica2.Click += new System.EventHandler(this.rbMusica2_Click_1);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(534, 888);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(170, 71);
            this.btnVoltar.TabIndex = 19;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // ofd1
            // 
            this.ofd1.FileName = "ofd";
            this.ofd1.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd1_FileOk);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbMusica3);
            this.groupBox4.Location = new System.Drawing.Point(24, 508);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox4.Size = new System.Drawing.Size(680, 169);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            // 
            // rbMusica3
            // 
            this.rbMusica3.AutoSize = true;
            this.rbMusica3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMusica3.Location = new System.Drawing.Point(56, 67);
            this.rbMusica3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbMusica3.Name = "rbMusica3";
            this.rbMusica3.Size = new System.Drawing.Size(198, 41);
            this.rbMusica3.TabIndex = 3;
            this.rbMusica3.TabStop = true;
            this.rbMusica3.Text = " &Pop Jazz";
            this.rbMusica3.UseVisualStyleBackColor = true;
            this.rbMusica3.Click += new System.EventHandler(this.rbMusica3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMudar);
            this.groupBox3.Controls.Add(this.rbNovaMusica);
            this.groupBox3.Location = new System.Drawing.Point(24, 688);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Size = new System.Drawing.Size(680, 169);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // btnMudar
            // 
            this.btnMudar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMudar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMudar.Location = new System.Drawing.Point(564, 113);
            this.btnMudar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnMudar.Name = "btnMudar";
            this.btnMudar.Size = new System.Drawing.Size(104, 44);
            this.btnMudar.TabIndex = 4;
            this.btnMudar.Text = "&mudar";
            this.btnMudar.UseVisualStyleBackColor = false;
            this.btnMudar.Visible = false;
            this.btnMudar.Click += new System.EventHandler(this.btnMudar_Click);
            // 
            // rbNovaMusica
            // 
            this.rbNovaMusica.AutoSize = true;
            this.rbNovaMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNovaMusica.Location = new System.Drawing.Point(56, 67);
            this.rbNovaMusica.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbNovaMusica.Name = "rbNovaMusica";
            this.rbNovaMusica.Size = new System.Drawing.Size(261, 41);
            this.rbNovaMusica.TabIndex = 3;
            this.rbNovaMusica.TabStop = true;
            this.rbNovaMusica.Text = " &Outra Música";
            this.rbNovaMusica.UseVisualStyleBackColor = true;
            this.rbNovaMusica.Click += new System.EventHandler(this.rbNovaMusica_Click);
            // 
            // tm1
            // 
            this.tm1.Interval = 200;
            this.tm1.Tick += new System.EventHandler(this.tm1_Tick);
            // 
            // frmToque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(728, 983);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRelogio);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmToque";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Som do Alarme";
            this.Activated += new System.EventHandler(this.frmToque_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRelogio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbMusica1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbMusica3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbNovaMusica;
        private System.Windows.Forms.Button btnMudar;
        private System.Windows.Forms.RadioButton rbMusica2;
        private System.Windows.Forms.Timer tm1;
    }
}