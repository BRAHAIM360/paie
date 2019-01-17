using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Base : Rubriquee
    {
        public Base() { }
        public void ajouter()
        {
            using (paieEntities12 db = new paieEntities12())
            {
                double x = 0;
                if (Double.IsNaN(valeur_ini))
                {
                    x = valeur_ini;
                }
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
                    valeur_initia = x,





                };

                if (Double.IsNaN(valeur_ini))
                {

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

                double x = 0;
                if (Double.IsNaN(valeur_ini))
                {
                    x = valeur_ini;
                }
                if (result != null)
                {
                    result.code = this.code;
                    result.libellé = this.Libellé;
                    result.abrégé = this.abrégé;
                    result.montant = this.montant;
                    result.Type_val = Typee;
                    valeur_ini = x;

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
