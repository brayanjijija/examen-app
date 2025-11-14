using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using examen_app.Modelos;

namespace examen_app
{
    public partial class AutoresFrm : Form
    {
        public AutoresFrm()
        {
            InitializeComponent();
        }

        private void AutoresFrm_Load(object sender, EventArgs e)
        {
            dgDatos.DataSource = Autore.Obtener();
        }
    }
}
