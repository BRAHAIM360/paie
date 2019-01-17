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
    public partial class Ajouter_banque : Form
    {
        Form ff;
        public Ajouter_banque()
        {
            
            InitializeComponent();
        }
        public void formm(Form f) { ff = f; }

        private void button1_Click(object sender, EventArgs e)
        {
            Banquee b = new Banquee { nom_banque=nom.Text.ToString(),téléphone=téléphone.Text.ToString(), adresse=Adresse.Text.ToString() };
            b.ajouter_banque();
            MessageBox.Show("la banque et bien ajouter");
            this.Hide();
            
            var myParent = (Form5)this.Owner;
            
            myParent.Form5_Load(sender,e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ajouter_banque_Load(object sender, EventArgs e)
        {

        }
    }
}
