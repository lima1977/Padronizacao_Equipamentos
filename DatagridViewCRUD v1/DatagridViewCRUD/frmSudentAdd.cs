using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

using System.Text.RegularExpressions;
using System.Drawing.Imaging;


using System.Runtime.InteropServices;
using System.Drawing.Text;
using MetroFramework;

/// <summary>
/// Author      : Shanu
/// Create date : 2015-12-01
/// Description :Student Register
/// Latest
/// Modifier    : 
/// Modify date : 


namespace DatagridViewCRUD
{
	public partial class frmSudentAdd : MetroFramework.Forms.MetroForm
	{
		#region Attribute
		// ReceptionSystemSrc.Helper.Webcamera.WebCam webcam;
		Boolean keypadOn = false;
		DataGridView Master_shanuDGV = new DataGridView();
		Button btn = new Button();

		Helper.BizClass bizObj = new Helper.BizClass();
		Helper.ShanuDGVHelper objshanudgvHelper = new Helper.ShanuDGVHelper();
		DataSet ds = new DataSet();
		PrivateFontCollection pfc = new PrivateFontCollection();
		Boolean isImageCaptuerd = false;
		int ival = 0;


		string StudentIDS = "";
		#endregion
		#region Form Load
		public frmSudentAdd(string StudentID)
		{
			InitializeComponent();
			StudentIDS = StudentID;
		}
 //-------------------------------------------------------------------------------------------------------------------------------------------------------
		private void frmSudentAdd_Load(object sender, EventArgs e)
		{

			try
			{
			
				isImageCaptuerd = false;
			
				// setFont();
				if (StudentIDS != "0")
				{
					displayVisitorDetails();
				}
			}
			catch (Exception ex)
			{
			}
		}
 //--------------------------------------------------------------------------------------------------------------------------------------------------------
		#endregion
		#region Methods

		private void displayVisitorDetails()
		{
			// lblUserType.Text = VisitorTypes;
			try
			{
				SortedDictionary<string, string> sd = new SortedDictionary<string, string>() { };
				//sd.Add("@searchType", VisitorTypes);
				sd.Add("@std_ID", StudentIDS);

				DataSet ds = new DataSet();

				ds = bizObj.SelectList("USP_StudentID_Select", sd);

				if (ds.Tables[0].Rows.Count > 0)
				{
					txtStudentID.Text = ds.Tables[0].Rows[0]["StdNO"].ToString();
					txtstdName.Text = ds.Tables[0].Rows[0]["StdName"].ToString();
					txtEmail.Text = ds.Tables[0].Rows[0]["Email"].ToString();
					txtphone.Text = ds.Tables[0].Rows[0]["Phone"].ToString();
					txtAddress.Text = ds.Tables[0].Rows[0]["Address"].ToString();

					if (ds.Tables[0].Rows[0]["StdImage"].ToString() != "")
					{
						byte[] bits = new byte[0];
						bits = (byte[])ds.Tables[0].Rows[0]["StdImage"];
						MemoryStream ms = new MemoryStream(bits);
						this.picImage.Image = System.Drawing.Bitmap.FromStream(ms);

						ms = null;

					}

					//txtEmail.Enabled = false;
					//txtMobileNo.Enabled = false;
					//txtStafftId.Enabled = false;
				}
			}
			catch (Exception ex)
			{
			}

		}
     //----------------------------------------------------------------------------------------------------------------------------------------------------
		#endregion
		private void btnCaptuer_Click(object sender, EventArgs e)
		{
			try
			{
				isImageCaptuerd = false;
				OpenFileDialog ofd = new OpenFileDialog();
				ofd.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
				ofd.Title = "Please Upload Image";


				if (ofd.ShowDialog() == DialogResult.OK)
				{
					isImageCaptuerd = true;
					picImage.Image = Image.FromFile(ofd.FileName);
				}
			}
			catch (Exception ex)
			{
			}
		}
       
		private void btnSave_Click(object sender, EventArgs e)
		{

			if (txtstdName.Text.Trim() == "")
			{
                MetroMessageBox.Show(this, "Este campo Nome  nao pode ser vazio", "Padronização de Equipamentos", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
              

                txtstdName.Focus();
				return;
			}

     //----------------------------------------------------------------------------------------------------------------------------------------------------		

            if (txtphone.Text.Trim() == "")
			{
                MetroMessageBox.Show(this, "Este campo  Fone nao pode ser vazio", "Padronização de Equipamentos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtphone.Focus();
				return;
			}
     //----------------------------------------------------------------------------------------------------------------------------------------------------		
            Regex emailRegex = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");

			if (!emailRegex.IsMatch(txtEmail.Text))
			{
                MetroMessageBox.Show(this, "Este campo  Email nao pode ser vazio", "Padronização de Equipamentos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
				return;
			}
     //----------------------------------------------------------------------------------------------------------------------------------------------------
            if (StudentIDS != "0")
			{
				EditStaffDetails();
			}
			else
			{
				AddNewStaffDetails();
			}
		}
        //-------------------------------------------------------------------------------------------------------------------------------------------------
		private void AddNewStaffDetails()
		{
			try
			{
				byte[] ImageData = null;
				string result = "";
				if (isImageCaptuerd == true)
				{
					try
					{
						if (picImage.Image != null)
						{
							ImageData = imgToByteArray(picImage.Image);
						}
					}
					catch (Exception ex)
					{
					}
				}

				SortedDictionary<string, string> sd = new SortedDictionary<string, string>() { };

				DataSet ds = new DataSet();

				ds = bizObj.SP_student_ImageInsert("USP_Student_Insert", txtstdName.Text.Trim(),
				txtEmail.Text.Trim(),
				txtphone.Text.Trim(),
				txtAddress.Text.Trim(),
				ImageData);



				if (ds.Tables[0].Rows.Count > 0)
				{
					result = ds.Tables[0].Rows[0][0].ToString();
					if (result == "Inserted")
					{

                        MetroMessageBox.Show(this, "Equipamento foi registrado com sucesso", "Padronização de Equipamentos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
					}
					else
					{
                        MetroMessageBox.Show(this, "Ops algo deu errado", "Padronização de Equipamentos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
				}

			}
			catch (Exception ex)
			{
			}

		}
     //----------------------------------------------------------------------------------------------------------------------------------------------------
        private void EditStaffDetails()
		{
			try
			{
				byte[] ImageData = null;
				string result = "";
			

				if(picImage.Image!=null)
				{
					try
					{
					ImageData = imgToByteArray(picImage.Image);
					}
					catch (Exception ex)
					{
					}
				}

				SortedDictionary<string, string> sd = new SortedDictionary<string, string>() { };

				DataSet ds = new DataSet();
				int StudentID = Convert.ToInt32(StudentIDS);

				ds = bizObj.SP_student_ImageEdit("USP_Student_Update", StudentID,txtstdName.Text.Trim(),
			    txtEmail.Text.Trim(),
				txtphone.Text.Trim(),
			    txtAddress.Text.Trim(),
			    ImageData);

				if (ds.Tables[0].Rows.Count > 0)
				{
					result = ds.Tables[0].Rows[0][0].ToString();

					if (result == "Updated")
					{
                        MetroMessageBox.Show(this, "Equipamento foi Atualizado com sucesso", "Padronização de Equipamentos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
					else
					{
						MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
				}

			}
			catch (Exception ex)
			{
			}

		}
       //------------------------------------------------------------------------------------------------------------------------------------------
		// Picbox to Byte Convert
		public byte[] imgToByteArray(Image img)
		{
			using (MemoryStream mStream = new MemoryStream())
			{
				img.Save(mStream, img.RawFormat);
				return mStream.ToArray();
			}
		}
        //-----------------------------------------------------------------------------------------------------------------------
		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}
        //------------------------------------------------------------------------------------------------------------------------
        private void PnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCaptuer2_Click(object sender, EventArgs e)
        {
            try
            {
                isImageCaptuerd = false;
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
                ofd.Title = "Please Upload Image";


                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    isImageCaptuerd = true;
                    picImage2.Image = Image.FromFile(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void BtnCaptuer3_Click(object sender, EventArgs e)
        {
            try
            {
                isImageCaptuerd = false;
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
                ofd.Title = "Please Upload Image";


                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    isImageCaptuerd = true;
                    picImage3.Image = Image.FromFile(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LinkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Pb_info1_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<FormInfo1>().Count() > 0)
            {
                MessageBox.Show(" Já está aberto!");
            }
            else
            {

                FormInfo1 FRM1= new FormInfo1();
                FRM1.ShowDialog();
            }

            //https://ecode10.com/artigo/1554/verificar-form-aberto-csharp



        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormInfo2>().Count() > 1)
            {
                MessageBox.Show(" Já está aberto!");
            }
            else
            {

                FormInfo2 FRM2 = new FormInfo2();
                FRM2.ShowDialog();
            }
        }
    }
}
