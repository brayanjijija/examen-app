using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen_app
{
    public partial class PrincipalFrm : Form
    {
        public PrincipalFrm()
        {
            InitializeComponent();
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            AutoresFrm frm = new AutoresFrm();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
