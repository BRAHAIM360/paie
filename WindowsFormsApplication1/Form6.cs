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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
           {
                    new Microsoft.Reporting.WinForms.ReportParameter("lol","azeazeae"),
           };
     
            
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.RefreshReport();
        }
    }
}
