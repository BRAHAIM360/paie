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
    public partial class société : Form
    {
        public int ajouter_modifier ;
        public int id_userr;
       
        public void modif(string Nom_Ent, string form_Juriduique, string activité, string rejistre_comerce, string Identifiant_Fiscal, string Téléphone, string Adresse , string code_postal, string Ville, string email,string fax)
        {
            Nom.Text =Nom_Ent.ToString().TrimEnd(); Adressee.Text = Adresse.ToString().TrimEnd(); téléphone.Text = Téléphone.ToString().TrimEnd(); Forme_Juridiquee.Text = form_Juriduique.ToString().TrimEnd(); Email.Text = email.ToString().TrimEnd(); Activité.Text = activité.ToString().TrimEnd(); registre_commerce.Text = rejistre_comerce.ToString().TrimEnd(); identifiant.Text = Identifiant_Fiscal.ToString().TrimEnd(); code_postall.Text = code_postal.ToString().TrimEnd(); Villee.Text = Ville.ToString().TrimEnd(); Fax.Text = fax.ToString().TrimEnd();
        }
        public société()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            
            string Nom_Ent = "";

            string Adresse = "";

            string Téléphone = "";

            string form_Juriduique = "";

            string email = "";
            string activité = "";
            string rejistre_comerce = "";
            string Identifiant_Fiscal = "";
            string code_postal = "";
            string Ville = "";
            string fax = "";
           
            if (!string.IsNullOrWhiteSpace(Nom.Text))
            {
                Nom_Ent = Nom.Text;
            }
            if (!string.IsNullOrWhiteSpace(Adressee.Text))
            {
                Adresse = Adressee.Text;
            }
            if (!string.IsNullOrWhiteSpace(téléphone.Text))
            {
                Téléphone = téléphone.Text;
            }
            if (!string.IsNullOrWhiteSpace(Forme_Juridiquee.Text))
            {
                form_Juriduique = Forme_Juridiquee.Text;
            }
            if (!string.IsNullOrWhiteSpace(Email.Text))
            {
                email = Email.Text;
            }
            if (!string.IsNullOrWhiteSpace(Activité.Text))
            {
                activité = Activité.Text;
            }
            if (!string.IsNullOrWhiteSpace(registre_commerce.Text))
            {
                rejistre_comerce = registre_commerce.Text;
            }
            if (!string.IsNullOrWhiteSpace(identifiant.Text))
            {
                Identifiant_Fiscal = identifiant.Text;
            }
            if (!string.IsNullOrWhiteSpace(code_postall.Text))
            {
                code_postal = code_postall.Text;
            }
            if (!string.IsNullOrWhiteSpace(Villee.Text))
            {
                Ville = Villee.Text;
            }
            if (!string.IsNullOrWhiteSpace(Fax.Text))
            {
                fax = Fax.Text;
            }
            if (ajouter_modifier == 0)
            {
                entreprisee ent = new entreprisee() { Nom_Ent = Nom_Ent, activité = activité.ToString(), Téléphone = Téléphone, form_Juriduique = form_Juriduique, email = email, Identifiant_Fiscal = Identifiant_Fiscal, rejistre_comerce = rejistre_comerce, fax = fax, Adresse = Adresse, code_postal = code_postal, Ville = Ville, id_user = id_userr };
                ent.Ajouter_Ent();
                MessageBox.Show("entreprise est ajouter avec succés");
                this.Close();
            }
            else
            {
                MessageBox.Show(ajouter_modifier.ToString());
                entreprisee ent = new entreprisee() { Nom_Ent = Nom_Ent, activité = activité, Téléphone = Téléphone, form_Juriduique = form_Juriduique, email = email, Identifiant_Fiscal = Identifiant_Fiscal, rejistre_comerce = rejistre_comerce, fax = fax, Adresse = Adresse, code_postal = code_postal, Ville = Ville, id_user = id_userr };
                MessageBox.Show(ent.activité);
                ent.ModiferEN(ajouter_modifier);
               
               
            //    if (ent.ModiferEN(ajouter_modifier))
            //{
            //    MessageBox.Show("la société est modifier avec succés");
            //}
            //else
            //{
            //    MessageBox.Show("la société n'est pas ajouter");
            //}
            
           
           
                this.Close();
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void société_Load(object sender, EventArgs e)
        {

        }
    }
}
