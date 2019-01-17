using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class bultinecs : Form
    {
        public bultinecs()
        {
            InitializeComponent();
        }

        private void bultinecs_Load(object sender, EventArgs e)
        {
            using (paieEntities dbe = new paieEntities())
            {

                ruberique_bulltinBindingSource.DataSource = dbe.rubriques.ToList();
                this.reportViewer1.RefreshReport();

            }
        }
    }
}
