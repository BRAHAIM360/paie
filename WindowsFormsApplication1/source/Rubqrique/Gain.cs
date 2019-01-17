using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Gain : Rubriquee
    {
       


        public void ajouter()
        {
            using (paieEntities12 db = new paieEntities12())
            {

                rubrique liste = new rubrique()
                {

                    code = this.code,
                    libellé = this.Libellé,
                    abrégé = this.abrégé,
                    imopsalblee = this.imprimable,
                    montant = this.montant,
                    imopsalble = this.imopsalble,
                    cotisable = this.cotisable,
                    compt = this.compt,
                    sens = true,
                    Type_val = Typee,




                };
                if (formule != null)
                {

                
                var query = from it in db.rubriques.OrderByDescending((x => x.id_rubrique)).ToList() select it;
                int i = query.First().id_rubrique;
                formule lise2 = new formule()
                {
                    id_rubrique = i + 1,
                    Base = formule.Base,
                    taux = formule.taux,
                    nombre = formule.nombre,
                    montont = formule.montont,
                    equoiation=formule.equoiation



                };
                    db.formules.Add(lise2);
                }
                else if (Double.IsNaN(valeur_ini))
                {
                    var query = from it in db.rubriques.OrderByDescending((x => x.id_rubrique)).ToList() select it;
                    int i = query.First().id_rubrique;
                    formule lise2 = new formule()
                    {
                        id_rubrique = i + 1,
                        montont = valeur_ini,



                    };
                }
                try
                {
                    
                    db.rubriques.Add(liste);
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

        
 
        public void modifier(int id)
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
                    result.imopsalble = this.imopsalble;
                    result.montant = this.montant;
                    resultt.equoiation = formule.equoiation;
                    resultt.Base = formule.Base;
                    resultt.taux = formule.taux;
                    resultt.nombre = formule.nombre;
                    resultt.montont = formule.montont;
                    result.Type_val = Typee;

                    try
                    {

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
        
    }
}
