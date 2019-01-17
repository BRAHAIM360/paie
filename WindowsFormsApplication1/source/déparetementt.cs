using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.source
{
    class déparetementt
    {
        public string nom_dépar;
        public string chéfe_départ;

        public déparetementt(string nom_dépar, string chéfe_départ)
        {
            this.nom_dépar = nom_dépar;
            this.chéfe_départ = chéfe_départ;
        }
        public void ajouter_dép()
        {

            using (paieEntities12 db = new paieEntities12())
            {
                Départemetent liste = new Départemetent()
                {
                    chéf_département = this.chéfe_départ,
                    nom_départ = this.nom_dépar
                };
                db.Départemetent.Add(liste);
                db.SaveChanges();

            }
        }
        public void modifier_dépa(int id)
        {
            using (paieEntities12 db = new paieEntities12())
            {

                var result = db.Départemetent.SingleOrDefault(b => b.id_département == id);
                if (result != null)
                {
                    result.nom_départ = this.nom_dépar;
                    result.chéf_département = this.chéfe_départ;

                    db.SaveChanges();


                }


            }
        }
        public void suprimer_départ(int id)
        {
            using (paieEntities12 db = new paieEntities12())
            {

                try
                {
                    var report = (from d in db.Départemetent where d.id_département == id select d).Single();

                    db.Départemetent.Remove(report);
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
