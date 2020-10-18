namespace WindowsFormsApp3
{
    partial class Frm_Cad
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dtpDia = new System.Windows.Forms.DateTimePicker();
            this.CBfUNCAO = new System.Windows.Forms.ComboBox();
            this.TxtDepartamento = new System.Windows.Forms.TextBox();
            this.cbLocal = new System.Windows.Forms.ComboBox();
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.mTxtcpf = new System.Windows.Forms.MaskedTextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.Btncadastro = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.mtversao = new MaterialSkin.Controls.MaterialLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpDia
            // 
            this.dtpDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDia.Location = new System.Drawing.Point(433, 166);
            this.dtpDia.Name = "dtpDia";
            this.dtpDia.Size = new System.Drawing.Size(104, 26);
            this.dtpDia.TabIndex = 14;
            // 
            // CBfUNCAO
            // 
            this.CBfUNCAO.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBfUNCAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBfUNCAO.FormattingEnabled = true;
            this.CBfUNCAO.Location = new System.Drawing.Point(316, 106);
            this.CBfUNCAO.Name = "CBfUNCAO";
            this.CBfUNCAO.Size = new System.Drawing.Size(221, 28);
            this.CBfUNCAO.TabIndex = 12;
            this.CBfUNCAO.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // TxtDepartamento
            // 
            this.TxtDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDepartamento.Location = new System.Drawing.Point(24, 238);
            this.TxtDepartamento.MaxLength = 20;
            this.TxtDepartamento.Name = "TxtDepartamento";
            this.TxtDepartamento.Size = new System.Drawing.Size(307, 26);
            this.TxtDepartamento.TabIndex = 10;
            // 
            // cbLocal
            // 
            this.cbLocal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocal.FormattingEnabled = true;
            this.cbLocal.Items.AddRange(new object[] {
            "CD01",
            "CD02",
            "701"});
            this.cbLocal.Location = new System.Drawing.Point(468, 236);
            this.cbLocal.Name = "cbLocal";
            this.cbLocal.Size = new System.Drawing.Size(69, 28);
            this.cbLocal.TabIndex = 4;
            this.cbLocal.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmpresa.FormattingEnabled = true;
            this.cbEmpresa.Items.AddRange(new object[] {
            "DOCA LOG",
            "BRA",
            "D&C",
            "CUSTOMIZA"});
            this.cbEmpresa.Location = new System.Drawing.Point(340, 236);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(112, 28);
            this.cbEmpresa.TabIndex = 3;
            // 
            // TxtNome
            // 
            this.TxtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(24, 166);
            this.TxtNome.MaxLength = 50;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(391, 26);
            this.TxtNome.TabIndex = 1;
            // 
            // mTxtcpf
            // 
            this.mTxtcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTxtcpf.Location = new System.Drawing.Point(163, 105);
            this.mTxtcpf.Mask = "000.000.000-00";
            this.mTxtcpf.Name = "mTxtcpf";
            this.mTxtcpf.Size = new System.Drawing.Size(141, 26);
            this.mTxtcpf.TabIndex = 15;
            // 
            // txtMatricula
            // 
            this.txtMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.Location = new System.Drawing.Point(24, 106);
            this.txtMatricula.MaxLength = 8;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(114, 26);
            this.txtMatricula.TabIndex = 0;
            this.txtMatricula.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Btncadastro
            // 
            this.Btncadastro.BackColor = System.Drawing.Color.Transparent;
            this.Btncadastro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Btncadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.Btncadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btncadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btncadastro.ForeColor = System.Drawing.Color.Azure;
            this.Btncadastro.Location = new System.Drawing.Point(600, 351);
            this.Btncadastro.Name = "Btncadastro";
            this.Btncadastro.Size = new System.Drawing.Size(127, 38);
            this.Btncadastro.TabIndex = 6;
            this.Btncadastro.Text = "Cadastrar";
            this.Btncadastro.UseVisualStyleBackColor = false;
            this.Btncadastro.Click += new System.EventHandler(this.Btncadastro_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.BtnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnLimpar.Location = new System.Drawing.Point(478, 351);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(116, 38);
            this.BtnLimpar.TabIndex = 7;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.Transparent;
            this.BtnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSair.Location = new System.Drawing.Point(356, 351);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(116, 38);
            this.BtnSair.TabIndex = 8;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 42);
            this.panel1.TabIndex = 17;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(12, 270);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(525, 35);
            this.bunifuSeparator1.TabIndex = 18;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            this.bunifuSeparator1.Load += new System.EventHandler(this.bunifuSeparator1_Load);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // mtversao
            // 
            this.mtversao.AutoSize = true;
            this.mtversao.BackColor = System.Drawing.Color.Transparent;
            this.mtversao.Depth = 0;
            this.mtversao.Font = new System.Drawing.Font("Roboto", 11F);
            this.mtversao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mtversao.Location = new System.Drawing.Point(20, 384);
            this.mtversao.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtversao.Name = "mtversao";
            this.mtversao.Size = new System.Drawing.Size(54, 19);
            this.mtversao.TabIndex = 19;
            this.mtversao.Text = "versao";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.delete_sign_96px;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(724, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 30);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.delete_sign_96px;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(687, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 30);
            this.button2.TabIndex = 21;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(-6, 75);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(36, 227);
            this.bunifuSeparator3.TabIndex = 23;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = true;
            this.bunifuSeparator3.Load += new System.EventHandler(this.bunifuSeparator3_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(23, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Matrícula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(159, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Cpf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(312, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Função";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(23, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Nome Competo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(23, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Departamento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(448, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(474, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Local";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(361, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Local";
            // 
            // Frm_Cad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.in_wordpress;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(753, 411);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.bunifuSeparator3);
            this.Controls.Add(this.mtversao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpDia);
            this.Controls.Add(this.mTxtcpf);
            this.Controls.Add(this.CBfUNCAO);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.TxtDepartamento);
            this.Controls.Add(this.Btncadastro);
            this.Controls.Add(this.cbLocal);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.cbEmpresa);
            this.Controls.Add(this.TxtNome);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Cad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE  APIO LOGISTICO";
            this.Load += new System.EventHandler(this.Frm_Cad_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbLocal;
        private System.Windows.Forms.ComboBox cbEmpresa;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.ComboBox CBfUNCAO;
        private System.Windows.Forms.TextBox TxtDepartamento;
        private System.Windows.Forms.DateTimePicker dtpDia;
        private System.Windows.Forms.MaskedTextBox mTxtcpf;
        private System.Windows.Forms.Button Btncadastro;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private MaterialSkin.Controls.MaterialLabel mtversao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

