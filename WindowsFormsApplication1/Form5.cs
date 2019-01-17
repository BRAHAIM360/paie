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
    public partial class Form5 : Form
    { 
        List<Banque> list_banque;
        Contratt new_contrat;

        private salariée sal;
       
        
        public int id_cont;
        public int id_sal;


        internal salariée Sal { get => sal; set => sal = value; }
        

        public Form5()
        {
            
            
            InitializeComponent();
            
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            Double salaire_base = 0;
            Double taux_h = 0;
            Double taux_j = 0;
            string ccp = "";
            string rip = "";
            string paiment = "";
            string mode_clcu = "";
            mode_clcu = this.mode_calcul.GetItemText(this.mode_calcul.SelectedItem);
            paiment =this.mode_de_versement.GetItemText(this.mode_de_versement.SelectedItem);
            if (!string.IsNullOrWhiteSpace(CCP_RIP.Text))
            {
                if (mode_paiement.Text== "par Banque")
                {
                    rip = CCP_RIP.Text;

                }
                else if(mode_paiement.Text == "Par CCP")
                {
                    ccp = CCP_RIP.Text;
                }
                
            }
           
            int duré = 0;
            try
            {
                salaire_base = Double.Parse(salair_ba.Text);
            }
            catch (System.FormatException)
            {


            }

            try
            {
                taux_h = Double.Parse(Taux_heure.Text);
            }
            catch (System.FormatException)
            {


            }
            try
            {
                taux_j = Double.Parse(Taux_Joure.Text);
            }
            catch (System.FormatException)
            {


            }
            try
            {
                duré = int.Parse(fin_cont.Text);
            }
            catch (System.FormatException)
            {


            }
            string statu = "";
            if (CDD.Checked)
            {
                statu = "CDD";
            }
            else if (CDI.Checked)
            {
                statu = "CDI";
            }
            else if (Apprenti.Checked)
            {
                statu = "Apprenti";
            }
            else if (stagiare.Checked)
            {
                statu = "stagiare";
            }
            else if (CTA.Checked)
            {
                statu = "CTA";
            }
            DateTime date_fine = DateTime.Now.AddMonths(duré);

            if (id_sal == 0)
            {


                new_contrat = new Contratt() { date_embouche = DateTime.Now, base_paie = salaire_base, salair_base = salaire_base, taux_jour = taux_j, taux_heure = taux_h, statu = statu, date_fin = date_fine, mod_calcule = mode_clcu, rémunération = paiment, mode_paiment = mode_paiement.Text, banque = Banque.Text, CCP = ccp, Rip = rip, matrucule = sal.matréculation };
                sal.contra = new_contrat;
                sal.ajouter_salarié();
               






                //parentt.NotifyMe(idd);
                using (Form4 parentt = (Form4)this.Owner)
                {
                    parentt.ab = true;
                    this.Close();
                }
               

                // cancel the closure of the form.

            }
            else
            {
               
                if (paiment == "Chéque" || paiment == "espéce")
                {
                    ccp = "";
                    rip = "";
                    Banque.Text=""; mode_paiement.Text = "";


                }
                new_contrat = new Contratt() { date_embouche = DateTime.Now, base_paie = salaire_base, salair_base = salaire_base, taux_jour = taux_j, taux_heure = taux_h, statu = statu, date_fin = date_fine, mod_calcule = mode_clcu, rémunération = paiment, mode_paiment = mode_paiement.Text, banque = Banque.Text, CCP = ccp, Rip = rip, matrucule = sal.matréculation,id_salarié= sal.contra.id_salarié,id_contrat= sal.contra.id_contrat };



                // If the no button was pressed ...
                

                sal.contra = new_contrat;
               
                sal.ModiferSalarié();



                Form4 parent = (Form4)this.Owner;
                parent.ab = true;
                this.Close();
            }
          

        }

        public void Form5_Load(object sender, EventArgs e)
        {
            Banque.Enabled = false;
            
            using (paieEntities12 dbe = new paieEntities12())

            {
                var query = from it in dbe.Banques

                            select it;

                foreach (Banque newSAL in query)
                {
                    // newSAL.code_postal = 14;
                    //newSAL.num_sécurité_sociale = 4;
                    if (!string.IsNullOrWhiteSpace(newSAL.nom_banque))
                    {
                        
                        string trimmed = newSAL.nom_banque.ToString().TrimEnd();
                        Banque.Items.Add(trimmed);
                    }
 
                }
            }

            mode_de_versement.Items.Add("Virement");
            mode_de_versement.Items.Add("Chéque");
            mode_de_versement.Items.Add("espéce");
            mode_calcul.Items.Add("Par jour");
            mode_calcul.Items.Add("Par heur");
            mode_paiement.Items.Add("par Banque");
            mode_paiement.Items.Add("Par CCP");

         


            if (id_cont!=0)
            {
                if (!string.IsNullOrWhiteSpace(sal.contra.salair_base.ToString()))
                {
                    salair_ba.Text = sal.contra.salair_base.ToString();
                }
                if (!string.IsNullOrWhiteSpace(sal.contra.taux_jour.ToString()))
                {
                    Taux_Joure.Text = sal.contra.taux_jour.ToString();
                }
                if (!string.IsNullOrWhiteSpace(sal.contra.taux_heure.ToString()))
                {
                    Taux_heure.Text = sal.contra.taux_heure.ToString();
                }
                if (!string.IsNullOrWhiteSpace(sal.contra.mode_paiment) )
                {
                    
                    if (sal.contra.mode_paiment.StartsWith("par Banque"))
                    {
                        mode_paiement.SelectedItem = "par Banque";
                        if (!string.IsNullOrWhiteSpace(sal.contra.banque))
                        {
                            Banque.SelectedItem = sal.contra.banque;
                        }
                        if (!string.IsNullOrWhiteSpace(sal.contra.Rip))
                        {
                            CCP_RIP.Text = sal.contra.Rip.ToString().TrimEnd();
                        }
                    }
                        
                    else if (sal.contra.mode_paiment.StartsWith("Par CCP"))
                    {
                      
                        mode_paiement.SelectedItem = "Par CCP";
                        if (!string.IsNullOrWhiteSpace(sal.contra.CCP))
                        {
                            CCP_RIP.Text = sal.contra.CCP.ToString().TrimEnd();
                        }
                    }
	               
                }
                if (!string.IsNullOrWhiteSpace(sal.contra.mod_calcule))
                {
                    if (sal.contra.mod_calcule.StartsWith("Par jour"))
                    {
                        mode_calcul.SelectedItem = "Par jour";
                    }

                    else if (sal.contra.mod_calcule.StartsWith("Par heur"))
                    {
                        mode_calcul.SelectedItem = "Par heur";
                    }

                }
                if (!string.IsNullOrWhiteSpace(sal.contra.statu))
                {
                   
                    radio_modif(sal.contra.statu.ToString(), "CDI", CDI); radio_modif(sal.contra.statu.ToString(), "CDD", CDD); radio_modif(sal.contra.statu.ToString(), "Appren", Apprenti); radio_modif(sal.contra.statu.ToString(), "stagi", stagiare); radio_modif(sal.contra.statu.ToString(), "CTA", CTA);
                }
                if (!string.IsNullOrWhiteSpace(sal.contra.rémunération))
                {
                    if (sal.contra.rémunération.StartsWith("Virement"))
                    {
                        mode_de_versement.SelectedItem = "Virement";
                    }

                    else if (sal.contra.rémunération.StartsWith("Chéque"))
                    {
                        mode_de_versement.SelectedItem = "Chéque";
                    }

                    else if (sal.contra.rémunération.StartsWith("espéce"))
                    {
                        mode_de_versement.SelectedItem = "espéce";
                    }
                   
                }
                Random rnd = new Random();
                int nb = rnd.Next(1, 24);
                fin_cont.Text = nb.ToString();
                   




            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ajouter_banque f = new Ajouter_banque();
            f.formm(this);
            f.ShowDialog(this);
        }
        public void radio_modif(string valeurdata, string valeurcomparé, RadioButton radio)
        {
            if (valeurdata.StartsWith(valeurcomparé))
            {
                radio.Checked = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form4 parent = (Form4)this.Owner;
            parent.NotifyMe(true);
            this.Close();
        }

        private void mode_paiement_TextChanged(object sender, EventArgs e)
        {
                    
        }

        private void mode_paiement_TextUpdate(object sender, EventArgs e)
        {

            if (e.ToString() == "Par CCP")
            {
                Banque.Enabled = false;
            }
        }

        private void mode_paiement_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void mode_paiement_SelectedValueChanged(object sender, EventArgs e)
        {
            if (mode_paiement.Text == "Par CCP")
            {
                Banque.Enabled = false;
            }
            else if (mode_paiement.Text == "par Banque")
            {
                Banque.Enabled = true;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 parent = (Form4)this.Owner;
            parent.NotifyMe(false);
            this.Close();
             
        }

        private void mode_de_versement_SelectedValueChanged(object sender, EventArgs e)
        {
            if (mode_de_versement.Text == "Virement")
            {
                mode_paiement.Enabled = true;
                CCP_RIP.Enabled = true;

            }
            else
            {
                mode_paiement.Enabled = false;
                CCP_RIP.Enabled = false;
                Banque.Enabled = false;
            }

        }
    }
}
