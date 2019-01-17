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
    public partial class Paramétre : Form
    {
        public Paramétre()
        {
            InitializeComponent();
        }
         List <baréme_IRG> barém = new List<baréme_IRG>();
        List<Barém_cnas> baréme = new List<Barém_cnas>();
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Paramétre_Load(object sender, EventArgs e)
        {
            using (paieEntities12 db = new paieEntities12())
            {
                var querry = from it in db.baréme_IRG select it;
                var querry2 = from it in db.Barém_cnas select it;
                foreach (var item in querry)
                {
                    barém.Add(item);
                }
                foreach (var item in querry2)
                {
                    baréme.Add(item);
                }
                
            }
            textBox1.Text = barém[0].valeur_inferieur.ToString();
            textBox2.Text = barém[0].valeur_supérieur.ToString();
            textBox3.Text = barém[0].Montant.ToString();
            textBox4.Text = barém[1].valeur_inferieur.ToString();
            textBox5.Text = barém[1].valeur_supérieur.ToString();
            textBox6.Text = barém[1].Montant.ToString();
            textBox7.Text = barém[2].valeur_inferieur.ToString();
            textBox8.Text = barém[2].valeur_supérieur.ToString();
            textBox9.Text = barém[2].Montant.ToString();
            textBox10.Text = barém[3].valeur_inferieur.ToString();
            textBox11.Text = barém[3].valeur_supérieur.ToString();
            textBox12.Text = barém[3].Montant.ToString();
            textBox13.Text = baréme[0].Montant.ToString();
            textBox14.Text = baréme[1].Montant.ToString();


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string message = "etes vous sur de vouloir sauvegardé";
            const string caption = "Validation";

            var resul = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OKCancel,
                                         MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (resul == DialogResult.OK)
            {
                using (paieEntities12 db = new paieEntities12())
                {
                    var result = db.Barém_cnas.SingleOrDefault(b => b.id == 1);
                    if (result != null)
                    {
                        result.Montant = double.Parse(textBox13.Text);
                    }
                    var result2 = db.Barém_cnas.SingleOrDefault(b => b.id == 2);
                    if (result2 != null)
                    {
                        result2.Montant = double.Parse(textBox14.Text);
                    }
                    var result3 = db.baréme_IRG.SingleOrDefault(b => b.id == 1);
                    if (result3 != null)
                    {
                        result3.valeur_inferieur = double.Parse(textBox1.Text);
                        result3.valeur_supérieur = double.Parse(textBox2.Text);
                        result3.Montant = double.Parse(textBox3.Text);
                    }
                    var result4 = db.baréme_IRG.SingleOrDefault(b => b.id == 2);
                    if (result4 != null)
                    {
                        result4.valeur_inferieur = double.Parse(textBox4.Text);
                        result4.valeur_supérieur = double.Parse(textBox5.Text);
                        result4.Montant = double.Parse(textBox6.Text);
                    }
                    var result5 = db.baréme_IRG.SingleOrDefault(b => b.id == 3);
                    if (result5 != null)
                    {
                        result5.valeur_inferieur = double.Parse(textBox7.Text);
                        result5.valeur_supérieur = double.Parse(textBox8.Text);
                        result5.Montant = double.Parse(textBox9.Text);
                    }
                    var result6 = db.baréme_IRG.SingleOrDefault(b => b.id == 4);
                    if (result6 != null)
                    {
                        result6.valeur_inferieur = double.Parse(textBox10.Text);
                        result6.valeur_supérieur = double.Parse(textBox11.Text);
                        result6.Montant = double.Parse(textBox12.Text);

                    }

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("les donné son savgarder avec seccés");
                    }
                    catch
                    {
                    }
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            const string message = "etes vous sur de vouloir re définire les paramétre par défaut";
            const string caption = "Validation";

            var resul = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OKCancel,
                                         MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (resul == DialogResult.OK)
            {



                using (paieEntities12 db = new paieEntities12())
                {
                    var result = db.Barém_cnas.SingleOrDefault(b => b.id == 1);
                    if (result != null)
                    {
                        result.Montant = 25;
                    }
                    var result2 = db.Barém_cnas.SingleOrDefault(b => b.id == 2);
                    if (result2 != null)
                    {
                        result2.Montant = 9;
                    }
                    var result3 = db.baréme_IRG.SingleOrDefault(b => b.id == 1);
                    if (result3 != null)
                    {
                        result3.valeur_inferieur = 0;
                        result3.valeur_supérieur = 12000;
                        result3.Montant = 0;
                    }
                    var result4 = db.baréme_IRG.SingleOrDefault(b => b.id == 2);
                    if (result4 != null)
                    {
                        result4.valeur_inferieur = 12000;
                        result4.valeur_supérieur = 36000;
                        result4.Montant = 20;
                    }
                    var result5 = db.baréme_IRG.SingleOrDefault(b => b.id == 3);
                    if (result5 != null)
                    {
                        result5.valeur_inferieur = 36000;
                        result5.valeur_supérieur = 144000;
                        result5.Montant = 30;
                    }
                    var result6 = db.baréme_IRG.SingleOrDefault(b => b.id == 4);
                    if (result6 != null)
                    {
                        result6.valeur_inferieur = 144000;
                        result6.valeur_supérieur = 999999999;
                        result6.Montant = 35;

                    }

                    try
                    {
                        db.SaveChanges();
                    }
                    catch (Exception)
                    {


                    }
                    barém.Clear();
                    baréme.Clear();
                    var querry = from it in db.baréme_IRG select it;
                    var querry2 = from it in db.Barém_cnas select it;
                    foreach (var item in querry)
                    {
                        barém.Add(item);
                    }
                    foreach (var item in querry2)
                    {
                        baréme.Add(item);
                    }

                    textBox1.Text = barém[0].valeur_inferieur.ToString();
                    textBox2.Text = barém[0].valeur_supérieur.ToString();
                    textBox3.Text = barém[0].Montant.ToString();
                    textBox4.Text = barém[1].valeur_inferieur.ToString();
                    textBox5.Text = barém[1].valeur_supérieur.ToString();
                    textBox6.Text = barém[1].Montant.ToString();
                    textBox7.Text = barém[2].valeur_inferieur.ToString();
                    textBox8.Text = barém[2].valeur_supérieur.ToString();
                    textBox9.Text = barém[2].Montant.ToString();
                    textBox10.Text = barém[3].valeur_inferieur.ToString();
                    textBox11.Text = barém[3].valeur_supérieur.ToString();
                    textBox12.Text = barém[3].Montant.ToString();
                    textBox13.Text = baréme[0].Montant.ToString();
                    textBox14.Text = baréme[1].Montant.ToString();
                }
            }
        }
    }
}
