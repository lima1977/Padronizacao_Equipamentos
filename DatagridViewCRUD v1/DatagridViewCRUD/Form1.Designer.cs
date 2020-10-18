namespace DatagridViewCRUD
{
	partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.pnlmain = new System.Windows.Forms.Panel();
            this.pnlSearchHeader = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnStaffAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlmain.SuspendLayout();
            this.pnlSearchHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGrid
            // 
            this.pnlGrid.Location = new System.Drawing.Point(10, 215);
            this.pnlGrid.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(827, 167);
            this.pnlGrid.TabIndex = 16;
            this.pnlGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGrid_Paint);
            // 
            // pnlmain
            // 
            this.pnlmain.Controls.Add(this.pnlGrid);
            this.pnlmain.Controls.Add(this.pnlSearchHeader);
            this.pnlmain.Controls.Add(this.pnlTop);
            this.pnlmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlmain.Location = new System.Drawing.Point(20, 60);
            this.pnlmain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlmain.Name = "pnlmain";
            this.pnlmain.Size = new System.Drawing.Size(843, 419);
            this.pnlmain.TabIndex = 17;
            // 
            // pnlSearchHeader
            // 
            this.pnlSearchHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlSearchHeader.Controls.Add(this.pictureBox2);
            this.pnlSearchHeader.Controls.Add(this.btnStaffAdd);
            this.pnlSearchHeader.Controls.Add(this.txtName);
            this.pnlSearchHeader.Controls.Add(this.label3);
            this.pnlSearchHeader.Controls.Add(this.btnSearch);
            this.pnlSearchHeader.Location = new System.Drawing.Point(10, 74);
            this.pnlSearchHeader.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlSearchHeader.Name = "pnlSearchHeader";
            this.pnlSearchHeader.Size = new System.Drawing.Size(827, 127);
            this.pnlSearchHeader.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DatagridViewCRUD.Properties.Resources.bar_code_icon;
            this.pictureBox2.Location = new System.Drawing.Point(2, 16);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // btnStaffAdd
            // 
            this.btnStaffAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnStaffAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStaffAdd.FlatAppearance.BorderSize = 0;
            this.btnStaffAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStaffAdd.ForeColor = System.Drawing.Color.White;
            this.btnStaffAdd.Image = global::DatagridViewCRUD.Properties.Resources.pallet_blue_512;
            this.btnStaffAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffAdd.Location = new System.Drawing.Point(576, 37);
            this.btnStaffAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnStaffAdd.Name = "btnStaffAdd";
            this.btnStaffAdd.Size = new System.Drawing.Size(185, 50);
            this.btnStaffAdd.TabIndex = 7;
            this.btnStaffAdd.Text = "Add Equipamentos";
            this.btnStaffAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStaffAdd.UseVisualStyleBackColor = false;
            this.btnStaffAdd.Click += new System.EventHandler(this.btnStaffAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtName.Location = new System.Drawing.Point(125, 54);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtName.MaxLength = 100;
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(294, 33);
            this.txtName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sku do Produto";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(463, 46);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 33);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Procurar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlTop.Controls.Add(this.label4);
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Location = new System.Drawing.Point(9, 7);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(829, 61);
            this.pnlTop.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(62, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 30);
            this.label4.TabIndex = 20;
            this.label4.Text = "Detalhes do Equipamentamos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DatagridViewCRUD.Properties.Resources.pallet_cardboard_512;
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DatagridViewCRUD.Properties.Resources.pallet_blue_512;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BackImage = global::DatagridViewCRUD.Properties.Resources.pallet_blue_512;
            this.ClientSize = new System.Drawing.Size(883, 499);
            this.Controls.Add(this.pnlmain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "                                  Controle de Padronização de Equipamentos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlmain.ResumeLayout(false);
            this.pnlSearchHeader.ResumeLayout(false);
            this.pnlSearchHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlGrid;
		private System.Windows.Forms.Button btnStaffAdd;
		private System.Windows.Forms.Panel pnlmain;
		private System.Windows.Forms.Panel pnlSearchHeader;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

