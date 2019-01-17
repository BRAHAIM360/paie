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
    public partial class Form1 : Form
    {
        int user;
        int id_ent;

        public Form1(int userr,int id_entt)
        {
            InitializeComponent();

            user = userr;
            id_ent = id_entt;
            if (userr != 1)
            {
                toolStripButton11.Enabled = false;
            }

        }
        public Form1()
        {
            InitializeComponent();

        

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
         
        }
      

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //Form3 f3 = new Form3();
            
          code_wilaya f3 = new code_wilaya();
            f3.id_entt = id_ent;
            f3.ShowDialog();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            
            Liste_rubrique f3 = new Liste_rubrique();
            f3.ShowDialog();

        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (Liste_ent formOptions = new Liste_ent())
            {
               
                formOptions.id = user;
                formOptions.ShowDialog(this);
            }
            
        }
        public void NotifyMe(int ent)
        {
            
            id_ent = ent;
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            Liste_user l = new Liste_user();
            
            l.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            using (Paramétre p = new Paramétre())
            {
                p.ShowDialog();
            }
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
