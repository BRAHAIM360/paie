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
    public partial class choisire_ent : Form
    {
        List<entreprisee> list_ent = new List<entreprisee>();
        public int id;
        
        public choisire_ent()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void choisire_ent_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

            string[] tab = new string[12];
            int i = 0;
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)

            {


                tab[i] = cell.Value.ToString();
                i++;
            }
            int l=0;
            if (tab[10] != null)
            {
                l = Int32.Parse(tab[10]);
                
            }
            Form1 s = new Form1(id,l);
           
            s.Show();
            this.Hide();
               

          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            société s = new société();
            s.id_userr = id;
            s.ShowDialog();
        }

        private void choisire_ent_Activated(object sender, EventArgs e)
        {
            button1.Enabled = false;
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
            else
            {
              
                using (paieEntities12 dbe = new paieEntities12())

                {
                    
                     var query = from it in dbe.Entreprises.Where(b => b.id_user == id).ToList() select it;
                    
                    foreach (Entreprise new_ent in query)
                    {

                     
                        list_ent.Add(new entreprisee() { id_ent = new_ent.id_entreprise, form_Juriduique = new_ent.form_juriduique, activité = new_ent.Activité, Adresse = new_ent.adresse, code_postal = new_ent.code_postal, Téléphone = new_ent.téléphone, email = new_ent.email, Identifiant_Fiscal = new_ent.Identifiant_Fiscal, fax = new_ent.fax, Nom_Ent = new_ent.nom_ent, rejistre_comerce = new_ent.rejistre_comerce, Ville = new_ent.Ville, id_user = new_ent.id_user.GetValueOrDefault() });

                    }


                    DataAjoute(dataGridView1, list_ent);

                }
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e,MouseEventArgs s)
        {

           
            if (dataGridView1.SelectedRows != null && e.ColumnIndex == -1)
            {
                button1.Enabled = true;
                if (s.Button == MouseButtons.Right)
                {
                    MessageBox.Show("azeaezsqd");
                    ContextMenuStrip menue = new ContextMenuStrip();
                    menue.Items.Add("del").Name = "del";
                    menue.Show(dataGridView1, new Point(s.X, s.Y));
                }
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            //if (dataGridView1.SelectedRows != null && e.ColumnIndex == -1)
            //{
            //    button1.Enabled = true;
            //    MessageBox.Show("azeaezsqd");
            //    //if (s.Button == MouseButtons.Right)
            //    //{
            //    //    
            //    //    ContextMenuStrip menue = new ContextMenuStrip();
            //    //    menue.Items.Add("del").Name = "del";
            //    //    menue.Show(dataGridView1, new Point(s.X, s.Y));
            //    //}
            //}
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
         //dataGridView1.ColumnIndex
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows != null && e.ColumnIndex == -1)
            {
                button1.Enabled = true;
                
                if (e.Button == MouseButtons.Right)
                {

                    ContextMenuStrip menue = new ContextMenuStrip();
                    menue.Items.Add("del").Name = "del";
                    menue.Show(dataGridView1, new Point(e.X, e.Location.Y));
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
