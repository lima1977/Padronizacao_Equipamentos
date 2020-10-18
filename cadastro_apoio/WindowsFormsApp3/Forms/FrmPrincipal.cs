using System;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dapper;
using DGVPrinterHelper;



namespace WindowsFormsApp3
{
    public partial class FrmPrincipal : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=P1041047\SQLEXPRESS14;Initial Catalog=APOIO;User ID=sa;Password=samu1803@");


       //SqlConnection sqlCon = new SqlConnection(@"Data Source=DISCOVERY-PC;Initial Catalog=CrudCadastro;User ID=sa;Password=0800");



        int ID = 0;
        public FrmPrincipal()
        {
            InitializeComponent();

            mtversao.Text = vers.versao;
            TxtDatacad.Text = DateTime.Today.ToString("dd/MM/yyyy");
            TxtDatacad.Enabled = false;

        }

        //--------------------------------------------------
      

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //LoginRede = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            //LblNomedamaquina.Text = UserHostName.resquest;



            try
            {
                FillDataGridView();
                limpar();
                lbl_contagem.Text = dvg1.Rows.Count.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        //------------------------------------------------------------------------
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //----------------------------------------------------------------------------------------  
        private void Btncadastro_Click(object sender, EventArgs e)
        {
            lbl_contagem.Text = dvg1.Rows.Count.ToString();

            try
            {


                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@ID", ID);
                param.Add("@CPF", mTxtcpf.Text.Trim());
                param.Add("@MATRICULA", txtMatricula.Text.Trim());
                param.Add("@NOME", TxtNome.Text.Trim());
                param.Add("@DEPARTAMENTO", TxtDepartamento.Text.Trim());
                param.Add("@FUNCAO", CBfUNCAO.Text.Trim());
                param.Add("@EMPRESA", cbEmpresa.Text.Trim());
                param.Add("@LOCAL", cbLocal.Text.Trim());
                param.Add("@STATUS", TxtStatus.Text.Trim());
                param.Add("@DATA", TxtDatacad.Text.Trim());
                sqlCon.Execute("CadAddOrEdit", param, commandType: CommandType.StoredProcedure);
                FillDataGridView();
                limpar();
                // PAREI NO 21:05 DO VIDEO
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            //----------------------------------------------------------------------------

            ///FrmCadSucesso CadSuceeso = new FrmCadSucesso();
            //CadSuceeso.ShowDialog();



        }
        //----------------------------------------------------------------------------
        void FillDataGridView()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@SearchText", TxtPesquisar.Text.Trim());
            List<Cad> list = sqlCon.Query<Cad>("CadViewAllSearch", param, commandType:
                CommandType.StoredProcedure).ToList<Cad>();
            dvg1.DataSource = list;
            dvg1.Columns[0].Visible = false;

        }
        //----------------------------------------------------------------------------
        class Cad
        {
            public int ID { get; set; }
            public String CPF { get; set; }
            public String MATRICULA { get; set; }
            public String NOME { get; set; }
            public String DEPARTAMENTO { get; set; }
            public String FUNCAO { get; set; }
            public String EMPRESA { get; set; }
            public String LOCAL { get; set; }
            public String STATUS { get; set; }
            //public TIME(7) DATA { get; set; }


        }
        //----------------------------------------------------------------------------
        private void BtnLimpar_Click(object sender, EventArgs e)
        {

        }
        //----------------------------------------------------------------------------
        private void BtnSair_Click(object sender, EventArgs e)
        {

            FrmQuerSair QuerSair = new FrmQuerSair();
            QuerSair.ShowDialog();
        }
        //-----------------------------------------------------------------------------
        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            FrmUsuLogado logado = new FrmUsuLogado();
            logado.Show();

        }

        private void CbLocal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //----------------------------------------------------------------
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }
        //---------------------------------------------------------
        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "CADASTRO DE APOIO LOGISTICO";
            printer.SubTitle = string.Format("Date:{0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Controle Logistico";
            printer.FooterSpacing = 3;
            printer.PrintDataGridView(dvg1);
        }

        private void CBfUNCAO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //--------------------------------------------------------------
        private void Dvg1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
               if (dvg1.CurrentRow.Index != 1)
                {
                    ID = Convert.ToInt32(dvg1.CurrentRow.Cells[0].Value.ToString());
                    mTxtcpf.Text =dvg1.CurrentRow.Cells[1].Value.ToString();
                    txtMatricula.Text = dvg1.CurrentRow.Cells[2].Value.ToString();
                    TxtNome.Text = dvg1.CurrentRow.Cells[3].Value.ToString();
                    TxtDepartamento.Text = dvg1.CurrentRow.Cells[4].Value.ToString();
                    CBfUNCAO.Text = dvg1.CurrentRow.Cells[5].Value.ToString();
                    cbEmpresa.Text = dvg1.CurrentRow.Cells[6].Value.ToString();
                    cbLocal.Text = dvg1.CurrentRow.Cells[7].Value.ToString();
                    TxtStatus.Text = dvg1.CurrentRow.Cells[8].Value.ToString();
                   TxtDatacad.Text = dvg1.CurrentRow.Cells[9].Value.ToString();

                    Btnexcluir.Enabled = false;
                    Btncadastro.Text = "Editar";

          



                   // parei no minuto 28:40



                 










                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            limpar();
        }
        //--------------------------------------------------------------

        void limpar()
        {
            mTxtcpf.Text = "";
            txtMatricula.Text = "";
            TxtNome.Text = "";
            TxtDepartamento.Text = "";
            CBfUNCAO.Text = "";
            cbEmpresa.Text ="";
            cbLocal.Text = "";
            TxtStatus.Text = "";
            TxtDatacad.Text = "";

         ID = 0;
         
            Btncadastro.Text = "Cadastrado";
            Btnexcluir.Enabled = false;
        }

        private void LblNomedamaquina_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
