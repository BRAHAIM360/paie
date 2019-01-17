using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Banquee
    {
        public int id_banque;
        public string nom_banque;
        public string adresse;
        public string téléphone;


        public void ajouter_banque()
        {

            using (paieEntities12 dbe = new paieEntities12())
            {
                Banque liste = new Banque()
                {
                    adresse_banque = this.adresse,
                    nom_banque = this.nom_banque,
                    téléphonee = this.téléphone



                };
                dbe.Banques.Add(liste);
                dbe.SaveChanges();
            }
        }
        public void modifier()
        {
            using (paieEntities12 db = new paieEntities12())
            {

                var result = db.Banques.SingleOrDefault(b => b.id_Banque == this.id_banque);
                if (result != null)
                {
                    result.nom_banque = this.nom_banque;
                    result.adresse_banque = this.adresse;
                    result.téléphonee = this.téléphone;

                    db.SaveChanges();


                }
            }
        }
        public void suprimer_banque()
        {
            using (paieEntities12 db = new paieEntities12())
            {
                try
                {
                    var report = (from d in db.Banques  where d.id_Banque == this.id_banque select d).Single();

                    db.Banques.Remove(report);
                    db.SaveChanges();
                }
                catch (InvalidOperationException e)

                {
                    Console.WriteLine(e);

                    return;
                }
            }
        }
    }
}
