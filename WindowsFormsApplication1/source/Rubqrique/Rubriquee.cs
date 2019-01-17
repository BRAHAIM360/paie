using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Rubriquee
    {

        public int id_rubrique;
        public string code;

        public String Libellé;

        public Boolean Type;
        public String Typee;

        public string abrégé;
        public int compt;
        public double valeur_ini;


        public string imprimable;
        public Boolean etat;

        // public Formulee formul;

        public double montant;
        public string imopsalble;
        public Boolean cotisable;
        public formule formule;





        public void ajouter_rub()
        {

            using (paieEntities12 db = new paieEntities12())
            {

                rubrique liste = new rubrique()
                {
                    code = this.code,
                    libellé = this.Libellé,
                    abrégé = this.abrégé,
                    imopsalblee = this.imprimable,
                    montant = this.montant

                };
                var query = from it in db.rubriques.OrderByDescending((x => x.id_rubrique)).ToList() select it;
                int i = query.First().id_rubrique;
                formule lise2 = new formule()
                {
                    id_rubrique = i + 1,
                    Base = formule.Base,
                    taux = formule.taux,
                    nombre = formule.nombre,
                    montont = formule.montont,
                    equoiation = formule.equoiation,



                };

                try
                {
                    db.rubriques.Add(liste);
                    db.formules.Add(lise2);
                    db.SaveChanges();
                    const string message = "la rubrique est bien ajouter avec succès";
                    const string caption = "Message";

                    MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Question);
                }

                catch (System.Data.Entity.Validation.DbEntityValidationException e)
                {
                    MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
        }



        public void modifier_rub(int id)
        {

            using (paieEntities12 db = new paieEntities12())
            {

                var result = db.rubriques.SingleOrDefault(b => b.id_rubrique == id);
                var resultt = db.formules.SingleOrDefault(b => b.id_rubrique == id);
                if (result != null && resultt != null)
                {
                    result.code = this.code;
                    result.libellé = this.Libellé;
                    result.abrégé = this.abrégé;
                    result.imopsalblee = this.imprimable;
                    result.montant = this.montant;
                    resultt.equoiation = formule.equoiation;
                    resultt.Base = formule.Base;
                    resultt.taux = formule.taux;
                    resultt.nombre = formule.nombre;
                    resultt.montont = formule.montont;


                    try
                    {
                        db.formules.Attach(resultt);
                        db.rubriques.Attach(result);
                        //db.Entry(resultt).State = EntityState.Modified;

                        //db.Entry(result).State = EntityState.Modified;
                        db.SaveChanges();
                        const string message = "la rubrique est bien modifier avec succès";
                        const string caption = "Message";

                        MessageBox.Show(message, caption,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Question);
                    }

                    catch (System.Data.Entity.Validation.DbEntityValidationException e)
                    {
                        MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }


            }

        }

        public void suprimer_rub(int id)
        {
            using (paieEntities12 db = new paieEntities12())
            {

                try
                {
                    var report = (from d in db.rubriques where d.id_rubrique == id select d).Single();
                    var reportt = (from d in db.formules where d.id_rubrique == id select d).Single();

                    db.formules.Remove(reportt);
                    db.rubriques.Remove(report);
                    db.SaveChanges();
                    const string message = "la rubrique est bien été suprimer avec succès";
                    const string caption = "Message";

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
        public void calcule_montant()
        {
            try
            {

           
            if (formule.equoiation.StartsWith("Nombre x Base"))
            {
                formule.montont = formule.nombre * formule.Base;
            }
            else if (formule.equoiation.StartsWith("Nombre x Taux"))
            {
                formule.montont = formule.nombre * formule.taux;
            }
            else if (formule.equoiation.StartsWith("Nombre x Base x Taux"))
            {
                formule.montont = formule.nombre * formule.Base * formule.taux;
            }
            else if (formule.equoiation.StartsWith("Base x taux"))
            {
                formule.montont = formule.Base * formule.taux;
            }
            else if (formule.equoiation.StartsWith("Nombre / Base"))
            {
                formule.montont = formule.nombre / formule.Base;
            }
            else if (formule.equoiation.StartsWith("Nombre / Taux"))
            {
                formule.montont = formule.nombre / formule.taux;
            }
            else if (formule.equoiation.StartsWith("Nombre x Base / Taux"))
            {
                formule.montont = (formule.nombre * formule.Base) / formule.taux;
            }
            else if (formule.equoiation.StartsWith("Nombre / Base x Taux"))
            {
                formule.montont = formule.nombre / formule.Base * formule.taux;
            }
            else if (formule.equoiation.StartsWith("Taux / Base"))
            {
                formule.montont = formule.taux / formule.Base;
            }
            }
            catch (Exception)
            {

               
            }

        }
    }
}
