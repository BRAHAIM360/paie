using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class salariée
    {
        
        public string photoo;
        public int id_salarié;
        public string matréculation;

        public String Nom_salarié;

        public String Prénom_Salarié;

        public DateTime Date_Naiss;

        public String Lieu_naiss;

        public string Numéro_SS;
        public int id_ent;
        public String Sexe;
        public Contratt contra;
        

        public String Situation_familliale;
        public List<Bulltin_paieeee> historique_bulltin;








        public string etat_salarié;
        public string nationalité;
        public string Num_Téléphone;
        public string adresse;
        public string wilaya_naiss;
        public string prénom_pair;
        public string nom_mére;
        public string prénom_mére;
        public int code_postale;
       // public int nb_enfant;
        public int nb_enfant_sco;
        public int personns_charge;



        public string état_sal;

        public string nom_conjoine;
        public string situation_conjoine;

        public string code_wilaya;
        
        public string email;


        public salariée()
        {
        }

        public salariée(string matréculation, String Nom_salarié, String Prénom_Salarié, DateTime Date_Naiss, String Lieu_naiss, string Numéro_SS, String Sexe, String Situation_familliale, string Num_Téléphone, string etat_salarié, string nationalité, string adresse, string wilaya_naiss, string prénom_pair, string nom_mére, string prénom_mére, int code_postale, int perssone_charege, int nb_enfant_sco,string nom_conjoinee,string Situation_conjoin,string email, string photoo,int id_entt)
        {

            this.matréculation = matréculation;
            this.Nom_salarié = Nom_salarié;
            this.Prénom_Salarié = Prénom_Salarié;
            this.Date_Naiss = Date_Naiss;
            this.Lieu_naiss = Lieu_naiss;
            this.Numéro_SS = Numéro_SS;
            this.Sexe = Sexe;
            this.Situation_familliale = Situation_familliale;
            
            this.Num_Téléphone = Num_Téléphone;
            this.photoo = photoo;
            this.prénom_mére = prénom_mére;
            
            this.etat_salarié = etat_salarié;
            this.nationalité = nationalité;
            this.adresse = adresse;
            this.wilaya_naiss = wilaya_naiss;
            this.prénom_pair = prénom_pair;
            this.nom_mére = nom_mére;
            this.code_postale = code_postale;
            
            this.nb_enfant_sco = nb_enfant_sco;
            this.personns_charge = perssone_charege;
            this.nom_conjoine = nom_conjoinee;
            this.situation_conjoine = Situation_conjoin;
            this.email = email;
            this.id_ent = id_entt;
            


        }

        public void ajouter_salarié()

        {
            using (paieEntities12 db = new paieEntities12())
            {

                salariés liste = new salariés()
                {
                    matruculation = this.matréculation,
                    nom = this.Nom_salarié,
                    prénom = this.Prénom_Salarié,
                    dat_naiss = this.Date_Naiss,
                    lieu_naiss = this.Lieu_naiss,
                    num_sécurité_socialeee = this.Numéro_SS,
                    sexe = this.Sexe,
                    situation_famille = this.Situation_familliale,
                    code_postal = this.code_postale,
                    nationalité = this.nationalité,
                    adresse_compléte = this.adresse,
                    wilaya_naiss = this.wilaya_naiss,
                    prénom_pére = this.prénom_pair,
                    nom_mére = this.nom_mére,
                    dans_enfant_scolarisé = this.nb_enfant_sco,

                    Personnes_charge = this.personns_charge,

                    état_sal = this.etat_salarié,
                    nom_conjoin = this.nom_conjoine,
                    situation_conjoin = this.situation_conjoine,
                    code_wilaya = this.code_wilaya,
                    email = this.email,
                    photos = this.photoo,
                    id_ent = this.id_ent,
                    prénom_mére = this.prénom_mére
                    




            };

                contrat nouvelle_contrat = new contrat()
                {

                    date_embouche = this.contra.date_embouche,
                    frequnce_Paie = this.contra.frequancePaie,
                    base_paie = this.contra.base_paie,

                    mode_reglement = this.contra.mode_reglement,
                    salair_base = this.contra.salair_base,
                    taux_heure = this.contra.taux_heure,
                    taux_jour = this.contra.taux_jour,
                    statu = this.contra.statu,
                    date_fin = this.contra.date_fin,
                    date_sotie = this.contra.date_sotie,
                    mod_calcule = this.contra.mod_calcule,
                    rémunération = this.contra.rémunération,
                    montont_exoneration = this.contra.montont_exoneration,
                    mode_paiment = this.contra.mode_paiment,
                    banque = this.contra.banque,
                    CCP = this.contra.CCP,
                    Rip = this.contra.Rip,
                    exoneration_de_irg = this.contra.exoneration_de_irg,
                    id_salarié = contra.id_salarié,

                };
               
                try
                {
                    db.contrats.Add(nouvelle_contrat);
                    db.salariés.Add(liste);
                    db.SaveChanges();
                    const string message = "le salarié est ajouter avec succès";
                    const string caption = "Message";

                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Question);
                  
                }

                catch (System.Data.Entity.Validation.DbEntityValidationException e)
                {
                    MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    

                }
               
            }
        }
        public void ModiferSalarié()
        { 
            using (paieEntities12 db = new paieEntities12())
            {

                var resultt = db.contrats.SingleOrDefault(b => b.id_salarié == id_salarié);
                
                var result = db.salariés.SingleOrDefault(b => b.id_salarié == id_salarié);
               
                if (result != null)
                {
                    result.matruculation = this.matréculation;
                    result.nom = this.Nom_salarié;
                    result.prénom = this.Prénom_Salarié;
                    result.dat_naiss = this.Date_Naiss;
                    result.lieu_naiss = this.Lieu_naiss;
                    result.num_sécurité_socialeee = this.Numéro_SS;
                    result.sexe = this.Sexe;
                    result.situation_famille = this.Situation_familliale;
                    result.code_postal = this.code_postale;
                    result.nationalité = this.nationalité;
                    result.adresse_compléte = this.adresse;
                    result.wilaya_naiss = this.wilaya_naiss;
                    result.prénom_pére = this.prénom_pair;
                    result.nom_mére = this.nom_mére;
                    result.Personnes_charge = this.personns_charge;
                    result.état_sal = this.etat_salarié;
                    result.nom_conjoin = this.nom_conjoine;
                    result.situation_conjoin = this.situation_conjoine;
                    result.code_wilaya = this.code_wilaya;
                    result.email = this.email;
                    result.prénom_mére = this.prénom_mére;
                    result.photos = this.photoo;
                    db.salariés.Attach(result);
                    db.Entry(result).State = EntityState.Modified;
                  
                }

                    if (resultt != null)
                    {
                       
                        resultt.date_embouche = this.contra.date_embouche;
                        resultt.frequnce_Paie = this.contra.frequancePaie;
                        resultt.base_paie = this.contra.base_paie;
                        resultt.id_salarié = this.contra.id_salarié;
                        resultt.mode_reglement = this.contra.mode_reglement;
                        resultt.salair_base = this.contra.salair_base;
                        resultt.taux_heure = this.contra.taux_heure;
                        resultt.taux_jour = this.contra.taux_jour;
                        resultt.statu = this.contra.statu;
                        resultt.date_fin = this.contra.date_fin;
                        resultt.date_sotie = this.contra.date_sotie;
                        resultt.mod_calcule = this.contra.mod_calcule;
                        resultt.rémunération = this.contra.rémunération;
                        resultt.montont_exoneration = this.contra.montont_exoneration;
                        resultt.mode_paiment = this.contra.mode_paiment;
                        resultt.banque = this.contra.banque;
                        resultt.CCP = this.contra.CCP;
                        resultt.Rip = this.contra.Rip;
                        resultt.exoneration_de_irg = this.contra.exoneration_de_irg;
                       
                        db.contrats.Attach(resultt);
                    db.Entry(resultt).State = EntityState.Modified;
                  
                    }

                    try
                    {


                   
                    db.SaveChanges();
                        const string message = "le salarié est modifier avec succès";
                        const string caption = "Message";

                        MessageBox.Show(message, caption,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Question);
                    }
                    catch (System.Data.Entity.Validation.DbEntityValidationException e)
                    {
                        MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    catch(Exception e)
                    {
                        MessageBox.Show(e.ToString());
                    }



               


            }
        }



        public void SuprimerSalarié(int id)
        {
            using (paieEntities12 db = new paieEntities12())
            {

                try
                {
                    var report = (from d in db.salariés where d.id_salarié == id select d).Single();
                    var reportt = (from d in db.contrats where d.id_salarié == id select d).Single();

                    db.contrats.Remove(reportt);
                    db.salariés.Remove(report);
                    db.SaveChanges();
                    const string message = "le salarié est supprimer avec succès";
                    const string caption = "Form Closing";

                   MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Question);
                }
                catch (InvalidOperationException e)

                {
                    MessageBox.Show(e.ToString());
                }





            }
        }
    }
}

