namespace Jogo_do_Galo_2._0
{
    partial class frmJogo
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
            this.lblJ2 = new System.Windows.Forms.Label();
            this.lblJ1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVencedor = new System.Windows.Forms.Label();
            this.Pos9 = new System.Windows.Forms.PictureBox();
            this.Pos8 = new System.Windows.Forms.PictureBox();
            this.Pos7 = new System.Windows.Forms.PictureBox();
            this.Pos6 = new System.Windows.Forms.PictureBox();
            this.Pos5 = new System.Windows.Forms.PictureBox();
            this.Pos4 = new System.Windows.Forms.PictureBox();
            this.Pos3 = new System.Windows.Forms.PictureBox();
            this.Pos2 = new System.Windows.Forms.PictureBox();
            this.Pos1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corDeFundoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairDoJogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmVitória = new System.Windows.Forms.Timer(this.components);
            this.lblJogo1 = new System.Windows.Forms.Label();
            this.lblJogo2 = new System.Windows.Forms.Label();
            this.lblResultado1 = new System.Windows.Forms.Label();
            this.lblResultado2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tmIA = new System.Windows.Forms.Timer(this.components);
            this.btnContinuar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pos9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblJ2
            // 
            this.lblJ2.AutoSize = true;
            this.lblJ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJ2.Location = new System.Drawing.Point(219, 394);
            this.lblJ2.Name = "lblJ2";
            this.lblJ2.Size = new System.Drawing.Size(78, 16);
            this.lblJ2.TabIndex = 48;
            this.lblJ2.Text = "Jogador 2";
            // 
            // lblJ1
            // 
            this.lblJ1.AutoSize = true;
            this.lblJ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJ1.Location = new System.Drawing.Point(63, 394);
            this.lblJ1.Name = "lblJ1";
            this.lblJ1.Size = new System.Drawing.Size(82, 16);
            this.lblJ1.TabIndex = 47;
            this.lblJ1.Text = "Jogador 1 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "Menu";
            // 
            // lblVencedor
            // 
            this.lblVencedor.AutoSize = true;
            this.lblVencedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencedor.ForeColor = System.Drawing.Color.Red;
            this.lblVencedor.Location = new System.Drawing.Point(60, 126);
            this.lblVencedor.Name = "lblVencedor";
            this.lblVencedor.Size = new System.Drawing.Size(237, 25);
            this.lblVencedor.TabIndex = 44;
            this.lblVencedor.Text = "O Jogador 1 Ganhou!";
            this.lblVencedor.Visible = false;
            // 
            // Pos9
            // 
            this.Pos9.BackColor = System.Drawing.Color.White;
            this.Pos9.Location = new System.Drawing.Point(240, 282);
            this.Pos9.Name = "Pos9";
            this.Pos9.Size = new System.Drawing.Size(68, 65);
            this.Pos9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pos9.TabIndex = 43;
            this.Pos9.TabStop = false;
            this.Pos9.Tag = "9";
            this.Pos9.Click += new System.EventHandler(this.Posicao_Click);
            // 
            // Pos8
            // 
            this.Pos8.BackColor = System.Drawing.Color.White;
            this.Pos8.Location = new System.Drawing.Point(142, 282);
            this.Pos8.Name = "Pos8";
            this.Pos8.Size = new System.Drawing.Size(68, 65);
            this.Pos8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pos8.TabIndex = 42;
            this.Pos8.TabStop = false;
            this.Pos8.Tag = "8";
            this.Pos8.Click += new System.EventHandler(this.Posicao_Click);
            // 
            // Pos7
            // 
            this.Pos7.BackColor = System.Drawing.Color.White;
            this.Pos7.Location = new System.Drawing.Point(43, 282);
            this.Pos7.Name = "Pos7";
            this.Pos7.Size = new System.Drawing.Size(68, 65);
            this.Pos7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pos7.TabIndex = 41;
            this.Pos7.TabStop = false;
            this.Pos7.Tag = "7";
            this.Pos7.Click += new System.EventHandler(this.Posicao_Click);
            // 
            // Pos6
            // 
            this.Pos6.BackColor = System.Drawing.Color.White;
            this.Pos6.Location = new System.Drawing.Point(240, 183);
            this.Pos6.Name = "Pos6";
            this.Pos6.Size = new System.Drawing.Size(68, 65);
            this.Pos6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pos6.TabIndex = 40;
            this.Pos6.TabStop = false;
            this.Pos6.Tag = "6";
            this.Pos6.Click += new System.EventHandler(this.Posicao_Click);
            // 
            // Pos5
            // 
            this.Pos5.BackColor = System.Drawing.Color.White;
            this.Pos5.Location = new System.Drawing.Point(142, 183);
            this.Pos5.Name = "Pos5";
            this.Pos5.Size = new System.Drawing.Size(68, 65);
            this.Pos5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pos5.TabIndex = 39;
            this.Pos5.TabStop = false;
            this.Pos5.Tag = "5";
            this.Pos5.Click += new System.EventHandler(this.Posicao_Click);
            // 
            // Pos4
            // 
            this.Pos4.BackColor = System.Drawing.Color.White;
            this.Pos4.Location = new System.Drawing.Point(43, 183);
            this.Pos4.Name = "Pos4";
            this.Pos4.Size = new System.Drawing.Size(68, 65);
            this.Pos4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pos4.TabIndex = 38;
            this.Pos4.TabStop = false;
            this.Pos4.Tag = "4";
            this.Pos4.Click += new System.EventHandler(this.Posicao_Click);
            // 
            // Pos3
            // 
            this.Pos3.BackColor = System.Drawing.Color.White;
            this.Pos3.Location = new System.Drawing.Point(240, 86);
            this.Pos3.Name = "Pos3";
            this.Pos3.Size = new System.Drawing.Size(68, 65);
            this.Pos3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pos3.TabIndex = 37;
            this.Pos3.TabStop = false;
            this.Pos3.Tag = "3";
            this.Pos3.Click += new System.EventHandler(this.Posicao_Click);
            // 
            // Pos2
            // 
            this.Pos2.BackColor = System.Drawing.Color.White;
            this.Pos2.Location = new System.Drawing.Point(142, 86);
            this.Pos2.Name = "Pos2";
            this.Pos2.Size = new System.Drawing.Size(68, 65);
            this.Pos2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pos2.TabIndex = 36;
            this.Pos2.TabStop = false;
            this.Pos2.Tag = "2";
            this.Pos2.Click += new System.EventHandler(this.Posicao_Click);
            // 
            // Pos1
            // 
            this.Pos1.BackColor = System.Drawing.Color.White;
            this.Pos1.Location = new System.Drawing.Point(43, 86);
            this.Pos1.Name = "Pos1";
            this.Pos1.Size = new System.Drawing.Size(68, 65);
            this.Pos1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pos1.TabIndex = 35;
            this.Pos1.TabStop = false;
            this.Pos1.Tag = "1";
            this.Pos1.Click += new System.EventHandler(this.Posicao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 36);
            this.label1.TabIndex = 33;
            this.label1.Text = "Jogo do Galo";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçõesToolStripMenuItem,
            this.sairDoJogoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(152, 48);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.corDeFundoToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // corDeFundoToolStripMenuItem
            // 
            this.corDeFundoToolStripMenuItem.Name = "corDeFundoToolStripMenuItem";
            this.corDeFundoToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.corDeFundoToolStripMenuItem.Text = "Cor de Fundo";
            this.corDeFundoToolStripMenuItem.Click += new System.EventHandler(this.corDeFundoToolStripMenuItem_Click);
            // 
            // sairDoJogoToolStripMenuItem
            // 
            this.sairDoJogoToolStripMenuItem.Name = "sairDoJogoToolStripMenuItem";
            this.sairDoJogoToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.sairDoJogoToolStripMenuItem.Text = "Sair do Jogo";
            this.sairDoJogoToolStripMenuItem.Click += new System.EventHandler(this.sairDoJogoToolStripMenuItem_Click);
            // 
            // tmVitória
            // 
            this.tmVitória.Enabled = true;
            this.tmVitória.Interval = 500;
            this.tmVitória.Tick += new System.EventHandler(this.tmVitória_Tick);
            // 
            // lblJogo1
            // 
            this.lblJogo1.AutoSize = true;
            this.lblJogo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogo1.ForeColor = System.Drawing.Color.Teal;
            this.lblJogo1.Location = new System.Drawing.Point(82, 423);
            this.lblJogo1.Name = "lblJogo1";
            this.lblJogo1.Size = new System.Drawing.Size(42, 20);
            this.lblJogo1.TabIndex = 49;
            this.lblJogo1.Text = "I I I ";
            this.lblJogo1.Visible = false;
            // 
            // lblJogo2
            // 
            this.lblJogo2.AutoSize = true;
            this.lblJogo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogo2.ForeColor = System.Drawing.Color.Teal;
            this.lblJogo2.Location = new System.Drawing.Point(235, 423);
            this.lblJogo2.Name = "lblJogo2";
            this.lblJogo2.Size = new System.Drawing.Size(42, 20);
            this.lblJogo2.TabIndex = 50;
            this.lblJogo2.Text = "I I I ";
            this.lblJogo2.Visible = false;
            // 
            // lblResultado1
            // 
            this.lblResultado1.AutoSize = true;
            this.lblResultado1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblResultado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado1.ForeColor = System.Drawing.Color.Teal;
            this.lblResultado1.Location = new System.Drawing.Point(117, 172);
            this.lblResultado1.Name = "lblResultado1";
            this.lblResultado1.Size = new System.Drawing.Size(30, 18);
            this.lblResultado1.TabIndex = 51;
            this.lblResultado1.Text = "I I I";
            this.lblResultado1.Visible = false;
            // 
            // lblResultado2
            // 
            this.lblResultado2.AutoSize = true;
            this.lblResultado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado2.ForeColor = System.Drawing.Color.Teal;
            this.lblResultado2.Location = new System.Drawing.Point(197, 172);
            this.lblResultado2.Name = "lblResultado2";
            this.lblResultado2.Size = new System.Drawing.Size(30, 18);
            this.lblResultado2.TabIndex = 52;
            this.lblResultado2.Text = "I I I";
            this.lblResultado2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(160, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 53;
            this.label3.Text = "---";
            this.label3.Visible = false;
            // 
            // tmIA
            // 
            this.tmIA.Interval = 750;
            this.tmIA.Tick += new System.EventHandler(this.tmIA_Tick);
            // 
            // btnContinuar
            // 
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.Location = new System.Drawing.Point(116, 211);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(118, 37);
            this.btnContinuar.TabIndex = 54;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Visible = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(31, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "---------------------------------------------------------------------------------" +
    "------------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(31, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "---------------------------------------------------------------------------------" +
    "------------";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(116, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 300);
            this.button1.TabIndex = 59;
            this.button1.Tag = "2";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(216, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 300);
            this.button2.TabIndex = 58;
            this.button2.Tag = "3";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(350, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(10, 10);
            this.button3.TabIndex = 57;
            this.button3.Tag = "1";
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(360, 452);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResultado2);
            this.Controls.Add(this.lblResultado1);
            this.Controls.Add(this.lblJogo2);
            this.Controls.Add(this.lblJogo1);
            this.Controls.Add(this.lblJ2);
            this.Controls.Add(this.lblJ1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblVencedor);
            this.Controls.Add(this.Pos9);
            this.Controls.Add(this.Pos8);
            this.Controls.Add(this.Pos7);
            this.Controls.Add(this.Pos6);
            this.Controls.Add(this.Pos5);
            this.Controls.Add(this.Pos4);
            this.Controls.Add(this.Pos3);
            this.Controls.Add(this.Pos2);
            this.Controls.Add(this.Pos1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmJogo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo";
            ((System.ComponentModel.ISupportInitialize)(this.Pos9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJ2;
        private System.Windows.Forms.Label lblJ1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVencedor;
        private System.Windows.Forms.PictureBox Pos9;
        private System.Windows.Forms.PictureBox Pos8;
        private System.Windows.Forms.PictureBox Pos7;
        private System.Windows.Forms.PictureBox Pos6;
        private System.Windows.Forms.PictureBox Pos5;
        private System.Windows.Forms.PictureBox Pos4;
        private System.Windows.Forms.PictureBox Pos3;
        private System.Windows.Forms.PictureBox Pos2;
        private System.Windows.Forms.PictureBox Pos1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairDoJogoToolStripMenuItem;
        private System.Windows.Forms.Timer tmVitória;
        private System.Windows.Forms.Label lblJogo1;
        private System.Windows.Forms.Label lblJogo2;
        private System.Windows.Forms.Label lblResultado1;
        private System.Windows.Forms.Label lblResultado2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corDeFundoToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Timer tmIA;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}