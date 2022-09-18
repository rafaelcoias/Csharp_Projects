namespace Gestão_Base_de_Dados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblUtilizador = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPasse = new System.Windows.Forms.TextBox();
            this.lblPasse = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.tmInicio = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUtilizador
            // 
            this.lblUtilizador.AutoSize = true;
            this.lblUtilizador.BackColor = System.Drawing.Color.Black;
            this.lblUtilizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilizador.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUtilizador.Location = new System.Drawing.Point(254, 177);
            this.lblUtilizador.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUtilizador.Name = "lblUtilizador";
            this.lblUtilizador.Size = new System.Drawing.Size(107, 37);
            this.lblUtilizador.TabIndex = 0;
            this.lblUtilizador.Text = "Nome";
            this.lblUtilizador.Visible = false;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(550, 177);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(316, 31);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.Visible = false;
            // 
            // txtPasse
            // 
            this.txtPasse.Location = new System.Drawing.Point(550, 287);
            this.txtPasse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPasse.Name = "txtPasse";
            this.txtPasse.PasswordChar = '●';
            this.txtPasse.Size = new System.Drawing.Size(316, 31);
            this.txtPasse.TabIndex = 2;
            this.txtPasse.Visible = false;
            // 
            // lblPasse
            // 
            this.lblPasse.AutoSize = true;
            this.lblPasse.BackColor = System.Drawing.Color.Black;
            this.lblPasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPasse.Location = new System.Drawing.Point(254, 287);
            this.lblPasse.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPasse.Name = "lblPasse";
            this.lblPasse.Size = new System.Drawing.Size(236, 37);
            this.lblPasse.TabIndex = 4;
            this.lblPasse.Text = "Palavra-Passe";
            this.lblPasse.Visible = false;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(370, 413);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(156, 62);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Visible = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // gb1
            // 
            this.gb1.BackColor = System.Drawing.Color.Black;
            this.gb1.Controls.Add(this.label7);
            this.gb1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gb1.Location = new System.Drawing.Point(344, 19);
            this.gb1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb1.Name = "gb1";
            this.gb1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gb1.Size = new System.Drawing.Size(470, 100);
            this.gb1.TabIndex = 8;
            this.gb1.TabStop = false;
            this.gb1.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(42, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(359, 54);
            this.label7.TabIndex = 49;
            this.label7.Text = "FAÇA O LOGIN";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(614, 413);
            this.btnSair.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(156, 62);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Visible = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnRegistar
            // 
            this.btnRegistar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistar.Location = new System.Drawing.Point(972, 23);
            this.btnRegistar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(156, 62);
            this.btnRegistar.TabIndex = 5;
            this.btnRegistar.Text = "Registar";
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Visible = false;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // tmInicio
            // 
            this.tmInicio.Interval = 2000;
            this.tmInicio.Tick += new System.EventHandler(this.tmInicio_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-48, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(240, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1152, 519);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblPasse);
            this.Controls.Add(this.txtPasse);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblUtilizador);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUtilizador;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPasse;
        private System.Windows.Forms.Label lblPasse;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.Timer tmInicio;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
    }
}

