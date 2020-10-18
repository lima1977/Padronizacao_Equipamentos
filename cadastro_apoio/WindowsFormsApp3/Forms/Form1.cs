using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
   

        public partial class Frm_Cad : Form
    {
        public Frm_Cad()
        {
            InitializeComponent();
            mtversao.Text = vers.versao;
            
          
        }

        private void Frm_Cad_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaterialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel6_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //mTxtcpf = String.Empty()
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public string conString = "Data Source=P1041047\\SQLEXPRESS14;Initial Catalog=APOIO1200;User ID=sa;Password=0800";
        private void Btncadastro_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open) 
            {
                //string q = "INSERT INTO Cadastro(MATRICULA,NOME)VALUES('" + txtMatricula.Text.ToString() + "','" + TxtNome.Text.ToString() + "')";

                string q = "INSERT INTO Cadastro(MATRICULA,CPF,NOME, DEPARTAMENTO,FUNCAO, EMPRESA,CD)VALUES('" + txtMatricula.Text.ToString() + "','" + mTxtcpf.Text.ToString() + "','" + TxtNome.Text.ToString() + "','" + TxtDepartamento.Text.ToString() + "','" + CBfUNCAO.Text.ToString() + "','" + cbEmpresa.Text.ToString() + "','" + cbLocal.Text.ToString() + "')";







                SqlCommand cmd = new SqlCommand(q,con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Os dados foram salvo no banco de dados com sucesso .!!!!");
                // AQUI LIMPA OS CAMPOS APOS INSERIR OS DADOS
                txtMatricula.Text = String.Empty;
                mTxtcpf.Text = String.Empty;
                TxtDepartamento.Text = String.Empty;
                TxtNome.Text = String.Empty;
                cbEmpresa.Text = String.Empty;
                cbLocal.Text = String.Empty;
                CBfUNCAO.Text = String.Empty;
         


                TxtNome.Focus();
            }
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel7_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuSeparator3_Load(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }
    }
}
