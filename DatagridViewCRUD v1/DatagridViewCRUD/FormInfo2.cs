using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatagridViewCRUD
{
    public partial class FormInfo2 : MetroFramework.Forms.MetroForm
    {
        public FormInfo2()
        {
            InitializeComponent();
        }

        private void FormInfo2_Load(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            FormInfo1 FRM2 = new FormInfo1();
            FRM2.ShowDialog();
        }
    }
}
