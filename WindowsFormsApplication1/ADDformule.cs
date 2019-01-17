using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ADDformule : Form
    {
        public int i = 0;
        public int id = 0;
        public formule formu = new formule();
        internal formule formul { get => formu; set => formu = value; }

        public string code = "";
        public Double valeur = 0;
       

        public ADDformule()
        {
            InitializeComponent();
        }

        private void ADDformule_Load(object sender, EventArgs e)
        {
            
            comboBox1.Items.Add("Nombre x Base");
            comboBox1.Items.Add("Nombre x Taux");
            comboBox1.Items.Add("Nombre x Base x Taux");
            comboBox1.Items.Add("Base x taux");
            comboBox1.Items.Add("Nombre / Base");
            comboBox1.Items.Add("Nombre / Taux");
            comboBox1.Items.Add("Nombre / Base / Taux");
            comboBox1.Items.Add("Base / Taux");
            comboBox1.Items.Add("Nombre / Base x Taux");
            comboBox1.Items.Add("Nombre x Base / Taux");
            comboBox1.Items.Add("Taux / Base");
            comboBox1.Items.Add("Taux / Nombre");
            comboBox1.Items.Add("Montant pris tel quel");
            comboBox1.Items.Add("Totalisation");
            if (id != 0)
            {
                comboBox1.SelectedText = formu.equoiation;
                textBox1.Text = formu.nombre.ToString();
                textBox2.Text = formu.Base.ToString();
                textBox3.Text = formu.taux.ToString();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Constant cons = new Constant())
            {
                cons.i = 1;
                cons.ShowDialog(this);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Constant cons = new Constant())
            {
                cons.i = 2;
                cons.ShowDialog(this);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Constant cons = new Constant())
            {
                cons.i = 3;
                cons.ShowDialog(this);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Constant cons = new Constant())
            {
                cons.i = 4;
                cons.ShowDialog(this);

            }
        }

        private void ADDformule_Activated(object sender, EventArgs e)
       {
            if (i == 1)
            {
                textBox1.Text = code;
                
                formu.nombre=valeur ;
               
            }
            else if (i == 2)
            {
                textBox2.Text = code;
                formu.Base = valeur;
            }
            else if (i == 3)
            {
                textBox3.Text = code;
                formu.taux = valeur;
            }
            else if (i == 3)
            {
                textBox4.Text = code;
                formu.montont = valeur;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fiche_Rubriquecs parent = (fiche_Rubriquecs)this.Owner;

            if (id==0)
            {
                formu.equoiation = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);

                parent.Formul = formul;
            }
            else
            {
                formu.equoiation = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);

                parent.Rub.formule = formul;
            }
             
            this.Close();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
           
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
