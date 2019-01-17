using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Contratt
    {
        public int id_contrat;
       
        public string matrucule;
        public DateTime date_embouche;
        public Double base_paie;

        public string frequancePaie;


        public int id_salarié;

        public string mode_reglement;

        public double salair_base;

        public double taux_jour;

        public double taux_heure;
        public string statu ;
        public DateTime date_fin ;
        public DateTime date_sotie;
        public string mod_calcule ;
        public string rémunération ;
        public double montont_exoneration ;
        public string mode_paiment ;
        public string banque ;
        public string CCP ;
        public string Rip ;
        public string exoneration_de_irg ;
        public Contratt()
        { }
            public Contratt(DateTime date_embouche, string frequancePaie, int base_paie, int id_salarié, string mode_reglement, double salair_base, double taux_jour, double taux_heure)
        {
            this.date_embouche = date_embouche;

            this.frequancePaie = frequancePaie;

            this.base_paie = base_paie;

            this.id_salarié = id_salarié;

            this.mode_reglement = mode_reglement;

            this.salair_base = salair_base;

            this.taux_jour = taux_jour;

            this.taux_heure = taux_heure;
        }

        public void Rédiger_une_contrat(int id)
        {
            using (paieEntities12 db = new paieEntities12())
            {
                contrat nouvelle_contrat = new contrat()
                {

                    date_embouche = this.date_embouche,
                    frequnce_Paie = this.frequancePaie,
                    base_paie = this.base_paie,

                    mode_reglement = this.mode_reglement,
                    salair_base = this.salair_base,
                    taux_heure = this.taux_heure,
                    taux_jour = this.taux_jour,
                    statu = this.statu,
                    date_fin = this.date_fin,
                    date_sotie = this.date_sotie,
                    mod_calcule = this.mod_calcule,
                    rémunération = this.rémunération,
                    montont_exoneration = this.montont_exoneration,
                    mode_paiment = this.mode_paiment,
                    banque = this.banque,
                    CCP = this.CCP,
                    Rip = this.Rip,
                    exoneration_de_irg = this.exoneration_de_irg,
                    id_salarié =id,

                };
                db.contrats.Add(nouvelle_contrat);
                try
                {
                    db.SaveChanges();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException e)
                {
                    MessageBox.Show(e.ToString());
                    
                }
               

            }
        }

        public void suprimer_contrat(int id_cont)
        {
            using (paieEntities12 db = new paieEntities12())
            {

                try
                {

                    var report = (from d in db.contrats where d.id_contrat == id_cont select d).Single();

                    db.contrats.Remove(report);
                    db.SaveChanges();
                }
                catch (InvalidOperationException e)

                {
                    Console.WriteLine(e);

                    return;
                }

            }

        }

        public void modifier_contrat(int id_cont)
        {
            using (paieEntities12 db = new paieEntities12())
            {


                var result = db.contrats.SingleOrDefault(b => b.id_contrat == id_cont);
                if (result != null)
                {

                    result.date_embouche = this.date_embouche;
                    result.frequnce_Paie = this.frequancePaie;
                    result.base_paie = this.base_paie;
                    result.id_salarié = this.id_salarié;
                    result.mode_reglement = this.mode_reglement;
                    result.salair_base = this.salair_base;
                    result.taux_heure = this.taux_heure;
                    result.taux_jour = this.taux_jour;
                    result.statu = this.statu;
                    result.date_fin = this.date_fin;
                    result.date_sotie = this.date_sotie;
                    result.mod_calcule = this.mod_calcule;
                    result.rémunération = this.rémunération;
                    result.montont_exoneration = this.montont_exoneration;
                    result.mode_paiment = this.mode_paiment;
                    result.banque = this.banque;
                    result.CCP = this.CCP;
                    result.Rip = this.Rip;
                    result.exoneration_de_irg = this.exoneration_de_irg;
                   
                    try
                    {
                        db.SaveChanges();
                        
                    }
                    catch (Exception)
                    {

                    }
                    


                }


            }
        }
    }
}
