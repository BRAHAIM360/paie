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
    public partial class pp : Form
    {
        public pp()
        {
            InitializeComponent();
        }

        private void pp_Load(object sender, EventArgs e)
        {
            using (paieEntities12 dbe = new paieEntities12())
            {

               // ruberique_bulltinBindingSource.DataSource = dbe.ruberique_bulltin.ToList();
                this.reportViewer1.RefreshReport();

            }
          // this.reportViewer1.RefreshReport();
        }
    }
}
