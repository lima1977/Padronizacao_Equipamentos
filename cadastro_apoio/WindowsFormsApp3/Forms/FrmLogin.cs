using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domian;
using System.Threading;

namespace WindowsFormsApp3
{
    public partial class FrmLogin : Form
    {
        //-------------------------------------------------------------------------------------------
        public FrmLogin()
        {


            Thread  t = new Thread(new ThreadStart(Splash));
            t.Start();
            String str = string.Empty;
            for(int i = 0; i < 100000;i++)
            {

                str += i.ToString();
            }
            t.Abort();

            InitializeComponent();


            void Splash()
            {
                SplashScreen.SplashForm Frm = new SplashScreen.SplashForm();
                Frm.AppName = "Controle de Cadastro  Apoio";
             
                Application.Run(Frm);
                //Frm.Icon = Properties.Resources.app;
                Frm.ShowIcon = true;
                Frm.ShowInTaskbar = true;
            }
            //--------------------------------------------------------------------------------
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
         //------------------------------------------------------------------------------------------
        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text != "USUARIO") { 
            
                if (txtLogin.Text != "SENHA") {
                    UserModel user = new UserModel();
                    var validlogin = user.LoginUser(txtLogin.Text, txtSenha.Text);
                    if(validlogin == true)
                    {
                        FrmPrincipal CADASTROS = new FrmPrincipal();
                        CADASTROS.Show();
                        this.Hide();
                    }
                    else
                    {
                        MsgError("Login ou Senha Incorreto.\n Favor tente novamente.");
                        txtSenha.Clear();
                        txtSenha.Clear();
                        txtLogin.Focus();
                     
                    }
                }
                else MsgError("Favor entre com Login");

            }
            else MsgError("Favor entre com Senha");

             // parei no video 17:20


        }
        private void MsgError(string msg)
        {
            lblErrormsg.Text = "" + msg;
            lblErrormsg.Visible = true;

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
           // this.BackColor = Color.White;
            //this.TransparencyKey = Color.White;
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
