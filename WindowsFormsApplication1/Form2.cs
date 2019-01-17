using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        List<Loginn> liste_user = new List<Loginn>();
        public Form2()
        {
            InitializeComponent();
        }
        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (var item in liste_user)
                {
                    if (item.utilisateur != null && item.mot_de_pass != null)
                    {


                        if (item.utilisateur.StartsWith(user.Text) && item.mot_de_pass.StartsWith(mot_passs.Text))
                        {
                            choisire_ent s = new choisire_ent();
                            s.id = item.id;


                            s.Show();
                            this.Hide();
                        }
                    }
                }

                label4.Text = "utilisateur ou le mot de passe incorrect";
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            using (paieEntities12 db = new paieEntities12())

            {
                var query = from it in db.logins

                            select it;

                foreach (login userr in query)
                {
                    liste_user.Add(new Loginn(){id=userr.id,utilisateur=userr.utilisateur,mot_de_pass=userr.mot_de_pass,role=userr.role });
                    
                   

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in liste_user)
            {
                if (!string.IsNullOrEmpty(item.utilisateur)&& !string.IsNullOrEmpty(item.mot_de_pass))
                {

                
                if (item.utilisateur.TrimEnd()==user.Text && item.mot_de_pass.TrimEnd()==mot_passs.Text)
                {
                    choisire_ent s = new choisire_ent();
                        s.id = item.id;
                         s.Show();
                        this.Hide();
                    }
                }
            }

            label4.Text = "utilisateur ou le mot de passe incorrect";



        }

        private void button1_Enter(object sender, EventArgs e)
        {
            
        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
