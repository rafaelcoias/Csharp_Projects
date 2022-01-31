namespace Gestão_Base_de_Dados
{
    partial class frmAlterarPass
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
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.txtConfrm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.tmPasse = new System.Windows.Forms.Timer(this.components);
            this.btnRegistar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.tmPasse1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // pb1
            // 
            this.pb1.BackgroundImage = global::Gestão_Base_de_Dados.Properties.Resources.Lupa;
            this.pb1.Image = global::Gestão_Base_de_Dados.Properties.Resources.Ver;
            this.pb1.Location = new System.Drawing.Point(227, 66);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(17, 17);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 27;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(28, 65);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(218, 20);
            this.txtPassword.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(24, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Password";
            // 
            // pb2
            // 
            this.pb2.BackgroundImage = global::Gestão_Base_de_Dados.Properties.Resources.Lupa;
            this.pb2.Image = global::Gestão_Base_de_Dados.Properties.Resources.Ver;
            this.pb2.Location = new System.Drawing.Point(227, 147);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(17, 16);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 30;
            this.pb2.TabStop = false;
            this.pb2.Click += new System.EventHandler(this.pb2_Click);
            // 
            // txtConfrm
            // 
            this.txtConfrm.Location = new System.Drawing.Point(28, 145);
            this.txtConfrm.Name = "txtConfrm";
            this.txtConfrm.PasswordChar = '●';
            this.txtConfrm.Size = new System.Drawing.Size(218, 20);
            this.txtConfrm.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(24, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Confirmar Password";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(175, 27);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(71, 20);
            this.txt1.TabIndex = 31;
            this.txt1.Visible = false;
            // 
            // tmPasse
            // 
            this.tmPasse.Interval = 2000;
            this.tmPasse.Tick += new System.EventHandler(this.tmPasse_Tick);
            // 
            // btnRegistar
            // 
            this.btnRegistar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistar.Location = new System.Drawing.Point(47, 187);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(63, 30);
            this.btnRegistar.TabIndex = 48;
            this.btnRegistar.Text = "Salvar";
            this.btnRegistar.UseVisualStyleBackColor = false;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(167, 187);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(63, 30);
            this.btnSair.TabIndex = 49;
            this.btnSair.Text = "Voltar";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // tmPasse1
            // 
            this.tmPasse1.Interval = 2000;
            this.tmPasse1.Tick += new System.EventHandler(this.tmPasse1_Tick);
            // 
            // frmAlterarPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(277, 243);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.txtConfrm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlterarPass";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Password";
            this.Load += new System.EventHandler(this.frmAlterarPass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.TextBox txtConfrm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Timer tmPasse;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Timer tmPasse1;
    }
}