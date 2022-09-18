namespace Projeto_EuroMilhoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.lblPremio = new System.Windows.Forms.Label();
            this.btnResultado = new System.Windows.Forms.Button();
            this.btnProxima = new System.Windows.Forms.Button();
            this.btnApostar = new System.Windows.Forms.Button();
            this.lblNumeros = new System.Windows.Forms.Label();
            this.lblEstrelas = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSemanas = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(154, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prémio da Semana";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblPremio
            // 
            this.lblPremio.AutoSize = true;
            this.lblPremio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPremio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPremio.Location = new System.Drawing.Point(22, 16);
            this.lblPremio.Name = "lblPremio";
            this.lblPremio.Size = new System.Drawing.Size(250, 37);
            this.lblPremio.TabIndex = 1;
            this.lblPremio.Text = "00 ´ 000 ´ 000 €";
            // 
            // btnResultado
            // 
            this.btnResultado.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnResultado.Location = new System.Drawing.Point(12, 185);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(128, 45);
            this.btnResultado.TabIndex = 3;
            this.btnResultado.Text = "Ver Resultado";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // btnProxima
            // 
            this.btnProxima.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProxima.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProxima.Location = new System.Drawing.Point(401, 185);
            this.btnProxima.Name = "btnProxima";
            this.btnProxima.Size = new System.Drawing.Size(142, 45);
            this.btnProxima.TabIndex = 1;
            this.btnProxima.Tag = "";
            this.btnProxima.Text = "Próxima Semana";
            this.btnProxima.UseVisualStyleBackColor = true;
            this.btnProxima.Click += new System.EventHandler(this.btnProxima_Click);
            // 
            // btnApostar
            // 
            this.btnApostar.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApostar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnApostar.Location = new System.Drawing.Point(12, 146);
            this.btnApostar.Name = "btnApostar";
            this.btnApostar.Size = new System.Drawing.Size(87, 33);
            this.btnApostar.TabIndex = 2;
            this.btnApostar.Tag = "";
            this.btnApostar.Text = "Apostar";
            this.btnApostar.UseVisualStyleBackColor = true;
            this.btnApostar.Click += new System.EventHandler(this.btnApostar_Click);
            // 
            // lblNumeros
            // 
            this.lblNumeros.AutoSize = true;
            this.lblNumeros.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNumeros.Location = new System.Drawing.Point(169, 132);
            this.lblNumeros.Name = "lblNumeros";
            this.lblNumeros.Size = new System.Drawing.Size(207, 14);
            this.lblNumeros.TabIndex = 5;
            this.lblNumeros.Text = "Números da Sorte :  00 00 00 00 00";
            this.lblNumeros.Visible = false;
            // 
            // lblEstrelas
            // 
            this.lblEstrelas.AutoSize = true;
            this.lblEstrelas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstrelas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEstrelas.Location = new System.Drawing.Point(169, 146);
            this.lblEstrelas.Name = "lblEstrelas";
            this.lblEstrelas.Size = new System.Drawing.Size(102, 14);
            this.lblEstrelas.TabIndex = 6;
            this.lblEstrelas.Text = "Estrelas :   00 00";
            this.lblEstrelas.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSair.Location = new System.Drawing.Point(503, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(50, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPremio);
            this.groupBox1.Location = new System.Drawing.Point(132, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 63);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btnSemanas
            // 
            this.btnSemanas.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSemanas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSemanas.Location = new System.Drawing.Point(456, 146);
            this.btnSemanas.Name = "btnSemanas";
            this.btnSemanas.Size = new System.Drawing.Size(87, 33);
            this.btnSemanas.TabIndex = 9;
            this.btnSemanas.Tag = "";
            this.btnSemanas.Text = "Chaves";
            this.btnSemanas.UseVisualStyleBackColor = true;
            this.btnSemanas.Click += new System.EventHandler(this.btnSemanas_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(555, 242);
            this.Controls.Add(this.btnSemanas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblEstrelas);
            this.Controls.Add(this.lblNumeros);
            this.Controls.Add(this.btnApostar);
            this.Controls.Add(this.btnProxima);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EuroMilhões";
            this.Activated += new System.EventHandler(this.frmPrincipal_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPremio;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Button btnProxima;
        private System.Windows.Forms.Button btnApostar;
        private System.Windows.Forms.Label lblNumeros;
        private System.Windows.Forms.Label lblEstrelas;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSemanas;
    }
}

