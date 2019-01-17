using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace WindowsFormsApplication1
{
    class entreprisee
    {
        public int id_ent;
        public string Nom_Ent;

        public String Adresse;

        public string Téléphone;

        public string form_Juriduique;

        public string email;
        public string activité;
        public string rejistre_comerce;
        public string Identifiant_Fiscal;
        public string code_postal;
        public string Ville;
        public string fax;
        public int id_user;
        public entreprisee() { }
        public entreprisee(string Nom_Ent, String Adresse, int Téléphone, string form_Juriduique, string email)
        {
            this.Nom_Ent = Nom_Ent;
            this.Adresse = Adresse;
            //this.Téléphone = Téléphone;
            this.form_Juriduique = form_Juriduique;
            this.email = email;
        }



        public void Ajouter_Ent()
        {
            using (paieEntities12 db = new paieEntities12())
            {
                Entreprise liste = new Entreprise()
                {
                    nom_ent = this.Nom_Ent,
                    adresse = this.Adresse,
                    téléphone = this.Téléphone,
                    form_juriduique = this.form_Juriduique,
                    email = this.email,
                    Activité = this.activité,
                    rejistre_comerce = this.rejistre_comerce,
                    Identifiant_Fiscal = this.Identifiant_Fiscal,
                    code_postal=this.code_postal,
                    Ville=this.Ville,
                    fax=this.fax,
                    id_user=id_user



    };
                db.Entreprises.Add(liste);
                db.SaveChanges();

            }

        }


        public Boolean ModiferEN(int id)
        {
            using (paieEntities12 dbe = new paieEntities12())
            {

                var result = dbe.Entreprises.SingleOrDefault(b => b.id_entreprise == id);
                if (result != null)
                {
                    result.nom_ent = this.Nom_Ent;
                    result.adresse = this.Adresse;
                    result.form_juriduique = this.form_Juriduique;
                    result.téléphone = this.Téléphone;
                    result.email = this.email;
                    result.Activité = this.activité;
                    result.rejistre_comerce = this.rejistre_comerce;
                    result.Identifiant_Fiscal = this.Identifiant_Fiscal;
                    result.code_postal = this.code_postal;
                    result.Ville = this.Ville;
                    result.fax = this.fax;
                    try
                    {
                        dbe.Entreprises.Attach(result);
                        dbe.Entry(result).State = EntityState.Modified;
                        dbe.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        
                    }
                    //try
                    //{

                    //    dbe.SaveChanges();
                    //    MessageBox.Show("la socité et bien modifier");
                    //    return true;
                    //}
                    //catch (DbEntityValidationException ex)
                    //{
                    //    MessageBox.Show(ex.ToString());

                    //    return false;
                    //}



                }

                return true;
            }
        }
        public void suprimer_ENT(int id)
        {

            using (paieEntities12 db = new paieEntities12())
            {

                try
                {
                    var report = (from d in db.Entreprises where d.id_entreprise == id select d).Single();

                    db.Entreprises.Remove(report);
                    db.SaveChanges();
                }
                
                catch (InvalidOperationException e)

                {
                    MessageBox.Show(e.ToString());
                       

                    return;
                }



                

            }
        }
    }
}
