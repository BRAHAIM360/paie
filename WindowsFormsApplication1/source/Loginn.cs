using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Loginn
    {
        public int id;
        public string utilisateur;
        public string mot_de_pass;
        public string role;
        public Loginn() { }
        public void ajouter_user (){
            using (paieEntities12 db = new paieEntities12())
            {

                login liste = new login()
                {
                    utilisateur = this.utilisateur,
                    mot_de_pass=this.mot_de_pass,
                    role=this.role
                    };
                try
                {
                    db.logins.Add(liste);
                    db.SaveChanges();
                    const string message = "l'Usilisateur est ajouter avec succès";
                    const string caption = "Form Closing";

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
        public void modifier_user(int id) {
            using (paieEntities12 db = new paieEntities12())
            {

                var result = db.logins.SingleOrDefault(b => b.id == id);
                if (result != null)
                {
                    result.utilisateur = this.utilisateur;
                    result.mot_de_pass = this.mot_de_pass;
                    result.role = this.role;



                    try
                    {
                        db.SaveChanges();
                        const string message = "l'Utilisateur est modifier avec succès";
                        const string caption = "Form Closing";

                        MessageBox.Show(message, caption,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Question);
                    }
                    catch (System.Data.Entity.Validation.DbEntityValidationException e)
                    {
                        MessageBox.Show(e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                   ;


                }


            }
        }
        public void suprimer_user(int id)
        {
            using (paieEntities12 db = new paieEntities12())
            {

                try
                {
                    var report = (from d in db.logins where d.id == id select d).Single();

                    db.logins.Remove(report);
                    db.SaveChanges();
                    const string message = "l'Usilisateur est supprimer avec succès";
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
