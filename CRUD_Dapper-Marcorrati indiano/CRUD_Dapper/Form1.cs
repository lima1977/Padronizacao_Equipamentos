using Dapper;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace CRUD_Dapper
{
   //http://www.macoratti.net/17/07/cshp_metdap1.htm
  // http://www.macoratti.net/17/07/cshp_metdap2.htm

    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
   
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DISCOVERY-PC;Initial Catalog=Cadastro;User ID=sa;Password=0800");
            int FuncionarioID = 0;
             

        public Form1()
        {
            InitializeComponent();
            this.StyleManager = msmMain;
            msmMain.Theme = MetroFramework.MetroThemeStyle.Dark;
            mtversao.Text = vers.versao;
            txthoraoficial.Text = DateTime.Today.ToString("dd/MM/yyyy");
            txthoraoficial.Enabled = false;

        }

  
        private void Form1_Load(object sender, EventArgs e)
        {
           
                try
                {
                    FillDataGridView();
                    //limpar();
                    lbl_contagem.Text = dvg1.Rows.Count.ToString();

                }
                catch (Exception ex)
                {

                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
        }
    //-------------------------------------------------------------------------------------------------------------------------------------------------
        private void btnProcurar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg|PNG|*.png", ValidateNames = true })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    picFoto.Image = Image.FromFile(ofd.FileName);
                    Funcionario ofunci = funcionarioBindingSource.Current as Funcionario;
                    if (ofunci != null)
                        ofunci.ImagemUrl = ofd.FileName;
                }
            }
        }
    //-----------------------------------------------------------------------------------------------------------------------------------------------------------
        void LimpaControles()
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
            }
        }
    //-----------------------------------------------------------------------------------------------------------------------------------------------------------
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
           // oStatus = EntityState.Added;
            picFoto.Image = null;
            pContainer.Enabled = true;
            funcionarioBindingSource.Add(new Funcionario());
            funcionarioBindingSource.MoveLast();
            txtNome.Focus();
        }
    //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pContainer.Enabled = false;
            funcionarioBindingSource.ResetBindings(false);
            this.Form1_Load(sender,e);
        }
     //-----------------------------------------------------------------------------------------------------------------------------------------------------------
        private void btnEditar_Click(object sender, EventArgs e)
        {
            //oStatus = EntityState.Changed;
            pContainer.Enabled = true;
            txtNome.Focus();
        }

        private void gdAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Funcionario ofunci = funcionarioBindingSource.Current as Funcionario;
                if (ofunci != null)
                {
                    if (!string.IsNullOrEmpty(ofunci.ImagemUrl))
                        picFoto.Image = Image.FromFile(ofunci.ImagemUrl);
                }
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            ///oStatus = EntityState.Deleted;
            if (MetroFramework.MetroMessageBox.Show(this, "Tem certeza que deseja Excluir este registro", "Excluir ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                   
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            lbl_contagem.Text = dvg1.Rows.Count.ToString();
            try
           {
                if(sqlCon.State == ConnectionState.Closed);
                    sqlCon.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@FuncionarioID", FuncionarioID);
                param.Add("@Matricula", txtMatricula.Text.Trim());
                param.Add("@Nome", txtNome.Text.Trim());
                param.Add("@Cpf", txtCpf.Text.Trim());
                param.Add("@Nasc", txtNasc.Text.Trim());
                param.Add("@Email", txtEmail.Text.Trim());
                param.Add("@Rg", txtRg.Text.Trim());
                param.Add("@Estacivil", cbEstadoCivil.Text.Trim());
                param.Add("@Sexo", cbSexo.Text.Trim());
                param.Add("@Filhos", cbFilhos.Text.Trim());
                param.Add("@Pcd", cbPcd.Text.Trim());
                param.Add("@Dificiencia", txtDificiencia.Text.Trim());
                param.Add("@Endereco", txtEndereco.Text.Trim());
                param.Add("@Numero", txtNumero.Text.Trim());
                param.Add("@Bairro", txtBairro.Text.Trim());
                param.Add("@Cidade", txtCidade.Text.Trim());


           }
           catch (Exception ex)
           {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
            finally
           {
                sqlCon.Close();
           }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------
        void FillDataGridView()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@SearchText", txtPesquisar.Text.Trim());
            List<Cad> list = sqlCon.Query<Cad>("CadViewAllSearch", param, commandType:
                CommandType.StoredProcedure).ToList<Cad>();
            dvg1.DataSource = list;
            dvg1.Columns[0].Visible = false;

        }
        //----------------------------------------------------------------------------
        class Cad
        {
            public int FuncionarioID { get; set; }
            public int Matricula { get; set; }
            public string Nome { get; set; }
            public string Cpf { get; set; }
            public string Nasc { get; set; }
            public string Email { get; set; }
            public string Rg { get; set; }
            public string Estadocivil { get; set; }
            public string Sexo { get; set; }
            public string Filhos { get; set; }
            public string Pcd { get; set; }
            public string Deficiencia { get; set; }
            public string Endereco { get; set; }
            public string Numero { get; set; }

            public string Bairro { get; set; }
            public string Cidade { get; set; }
            public string Comple { get; set; }
            public string Cep { get; set; }
            public string Uf { get; set; }
            public string Telefone { get; set; }
            public string Celular { get; set; }
            public string Departamento { get; set; }
            public string Cargo { get; set; }
            public string Empresa { get; set; }
            public string Adimissao { get; set; }
            public string Situacao { get; set; }
            public string Datacad { get; set; }
            public string Supervisor { get; set; }
            public string Coordenador { get; set; }
            public string Turno { get; set; }
            public string Fretado { get; set; }
            public string Obs { get; set; }
            public string ImagemUrl { get; set; }


        }
        //----------------------------------------------------------------------------









        private void gdFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picFoto_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_Click(object sender, EventArgs e)
        {

        }

        private void txtEndereco_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void funcionarioBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void metroLabel17_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel20_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel21_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void txtCelular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCargo_Click(object sender, EventArgs e)
        {

        }

        private void txtDepartamento_Click(object sender, EventArgs e)
        {

        }

        private void txtNasc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void metroLabel27_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel28_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void metroLabel30_Click(object sender, EventArgs e)
        {

        }

        private void txtID_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void funcionarioBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView();

            }
            catch (Exception ex)
            {

                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
