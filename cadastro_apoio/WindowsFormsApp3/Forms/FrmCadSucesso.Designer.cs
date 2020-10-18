namespace WindowsFormsApp3
{
    partial class FrmCadSucesso
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnOk = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.Btncadastro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnOk);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(-8, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 188);
            this.panel1.TabIndex = 35;
            // 
            // BtnOk
            // 
            this.BtnOk.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnOk.FlatAppearance.BorderSize = 0;
            this.BtnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnOk.Location = new System.Drawing.Point(249, 143);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(82, 36);
            this.BtnOk.TabIndex = 31;
            this.BtnOk.Text = "Ok";
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.positivo_png_5;
            this.pictureBox1.Location = new System.Drawing.Point(125, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.Capturada_5321;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.BtnSair);
            this.panel3.Controls.Add(this.BtnLimpar);
            this.panel3.Controls.Add(this.Btncadastro);
            this.panel3.Location = new System.Drawing.Point(4, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(74, 182);
            this.panel3.TabIndex = 29;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp3.Properties.Resources.logout;
            this.pictureBox3.Location = new System.Drawing.Point(100, 450);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.Transparent;
            this.BtnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSair.Location = new System.Drawing.Point(2, 354);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(134, 49);
            this.BtnSair.TabIndex = 9;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.BtnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnLimpar.Location = new System.Drawing.Point(1, 303);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(134, 49);
            this.BtnLimpar.TabIndex = 10;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            // 
            // Btncadastro
            // 
            this.Btncadastro.BackColor = System.Drawing.Color.Transparent;
            this.Btncadastro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Btncadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.Btncadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btncadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btncadastro.ForeColor = System.Drawing.Color.Azure;
            this.Btncadastro.Location = new System.Drawing.Point(1, 252);
            this.Btncadastro.Name = "Btncadastro";
            this.Btncadastro.Size = new System.Drawing.Size(134, 49);
            this.Btncadastro.TabIndex = 11;
            this.Btncadastro.Text = "Cadastrar";
            this.Btncadastro.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(84, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 53);
            this.label2.TabIndex = 32;
            this.label2.Text = "Registro cadastrado \r\ncom sucesso!!!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmCadSucesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.in_wordpress;
            this.ClientSize = new System.Drawing.Size(330, 185);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadSucesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadSucesso";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button Btncadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnOk;
    }
}