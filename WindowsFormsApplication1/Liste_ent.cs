using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Liste_ent : Form
    {
        
        public int id=0;
        public Liste_ent()
        {
            InitializeComponent();
        }
        List<entreprisee> list_ent= new List<entreprisee>();

        private void button1_Click(object sender, EventArgs e)
        {
            société s = new société();
            s.ajouter_modifier = 0;
            s.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] tab = new string[12];
            int i = 0;
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)

            {


                tab[i] = cell.Value.ToString();
                i++;
            }
            société s = new société();
            if (!(tab[10] == null))
            {
                s.ajouter_modifier = Int32.Parse(tab[10]);

            }
            
            
            s.modif(tab[0], tab[1], tab[2], tab[3], tab[4], tab[5], tab[6], tab[7], tab[8], tab[9], tab[10]);
            s.ShowDialog();

        }

        private void Liste_ent_Load(object sender, EventArgs e)
        {

           
        }
        private void DataAjoute(DataGridView dataGridView1, List<entreprisee> liste)
        {
            foreach (var ent in liste)
            {
                //int row = dataGridView1.NewRowIndex;
                int row = dataGridView1.Rows.Add();
                if (ent.Nom_Ent == null)
                {
                    dataGridView1.Rows[row].Cells[0].Value = "";
                }
                else
                {
                    dataGridView1.Rows[row].Cells[0].Value = ent.Nom_Ent.ToString();
                }
                if (ent.form_Juriduique == null)
                {
                    dataGridView1.Rows[row].Cells[1].Value = "";
                }
                else
                {
                    dataGridView1.Rows[row].Cells[1].Value = ent.form_Juriduique.ToString();
                }
                if (ent.activité == null)
                {
                    dataGridView1.Rows[row].Cells[2].Value = "";
                }
                else
                {
                    dataGridView1.Rows[row].Cells[2].Value = ent.activité.ToString();
                }
                if (ent.rejistre_comerce == null)
                {
                    dataGridView1.Rows[row].Cells[3].Value = "";
                }
                else
                {
                    dataGridView1.Rows[row].Cells[3].Value = ent.rejistre_comerce.ToString();
                }
                if (ent.Identifiant_Fiscal == null)
                {
                    dataGridView1.Rows[row].Cells[4].Value = "";
                }
                else
                {
                    dataGridView1.Rows[row].Cells[4].Value = ent.Identifiant_Fiscal.ToString();
                }
                if (ent.Téléphone == null)
                {
                    dataGridView1.Rows[row].Cells[5].Value = "";
                }
                else
                {
                    dataGridView1.Rows[row].Cells[5].Value = ent.Téléphone.ToString();
                }
                if (ent.Adresse == null)
                {
                    dataGridView1.Rows[row].Cells[6].Value = "";
                }
                else
                {
                    dataGridView1.Rows[row].Cells[6].Value = ent.Adresse.ToString();
                }
                if (ent.code_postal == null)
                {
                    dataGridView1.Rows[row].Cells[7].Value = "";
                }
                else
                {
                    dataGridView1.Rows[row].Cells[7].Value = ent.code_postal.ToString();
                }
                if (ent.Ville == null)
                {
                    dataGridView1.Rows[row].Cells[8].Value = "";
                }
                else
                {
                    dataGridView1.Rows[row].Cells[8].Value = ent.Ville.ToString();
                }
                if (ent.fax == null)
                {
                    dataGridView1.Rows[row].Cells[9].Value = "";
                }
                else
                {
                    dataGridView1.Rows[row].Cells[9].Value = ent.fax.ToString();
                }
                if (ent.id_ent.ToString() == null)
                {
                    dataGridView1.Rows[row].Cells[10].Value = "";
                }
                else
                {
                    dataGridView1.Rows[row].Cells[10].Value = ent.id_ent.ToString();
                }
               // dataGridView1.Rows[row].Visible = false;
                
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == -1)
            {
                button2.Enabled = true; button3.Enabled = true; button4.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] tab = new string[12];
            int i = 0;
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)

            {


                tab[i] = cell.Value.ToString();
                i++;
            }
            const string message = "etes vous sur de vouloir supprimer cette société";
            const string caption = "Validation";
            
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OKCancel,
                                         MessageBoxIcon.Question);

           
            if (result == DialogResult.OK)
            {
               
                
              
               
                entreprisee er = new entreprisee();
                er.suprimer_ENT(Int32.Parse(tab[10]));
                this.Liste_ent_Activated(sender,e);
               

            }
           
            

        }

        
       

        private void Liste_ent_Activated(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            dataGridView1.Rows.Clear();
            dataGridView1.AllowUserToAddRows = false;
            list_ent.Clear();
            if (id == 1)
            {
                using (paieEntities12 db = new paieEntities12())

                {
                    var query = from it in db.Entreprises select it;

                    foreach (Entreprise new_ent in query)
                    {


                        list_ent.Add(new entreprisee() { id_ent = new_ent.id_entreprise, form_Juriduique = new_ent.form_juriduique, activité = new_ent.Activité, Adresse = new_ent.adresse, code_postal = new_ent.code_postal, Téléphone = new_ent.téléphone, email = new_ent.email, Identifiant_Fiscal = new_ent.Identifiant_Fiscal, fax = new_ent.fax, Nom_Ent = new_ent.nom_ent, rejistre_comerce = new_ent.rejistre_comerce, Ville = new_ent.Ville, id_user = new_ent.id_user.GetValueOrDefault() });

                    }


                    DataAjoute(dataGridView1, list_ent);

                }

            }
            else { 
                using (paieEntities12 db = new paieEntities12())

                {
                    var query = from it in db.Entreprises.Where(i => i.id_user == id).ToList() select it;

                    foreach (Entreprise new_ent in query)
                    {


                        list_ent.Add(new entreprisee() { id_ent = new_ent.id_entreprise, form_Juriduique = new_ent.form_juriduique, activité = new_ent.Activité, Adresse = new_ent.adresse, code_postal = new_ent.code_postal, Téléphone = new_ent.téléphone, email = new_ent.email, Identifiant_Fiscal = new_ent.Identifiant_Fiscal, fax = new_ent.fax, Nom_Ent = new_ent.nom_ent, rejistre_comerce = new_ent.rejistre_comerce, Ville = new_ent.Ville, id_user = new_ent.id_user.GetValueOrDefault() });

                    }


                    DataAjoute(dataGridView1, list_ent);

                }
        }
                
        }

        private void button4_Click(object sender, EventArgs e)
        {

           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
           
        }



        private void button4_Click_2(object sender, EventArgs e)
        {
            string[] tab = new string[12];
            int i = 0;
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)

            {


                tab[i] = cell.Value.ToString();
                i++;
            }
            Form1 parent = (Form1)this.Owner;

            parent.NotifyMe((Int32.Parse(tab[10])));
            MessageBox.Show("la société est changer");
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(this.bmp,0,0);
        }
        Bitmap bmp;
        private void button5_Click_1(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width,this.Size.Height,g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0,this.Size);
            printPreviewDialog1.ShowDialog();
        }
    }
}
