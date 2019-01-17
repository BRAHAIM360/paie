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
    public partial class bulltin_model : Form
    {
        List<rubrique> liste_rub_actif = new List<rubrique>();
        List<rubrique> liste_rub_no_actif = new List<rubrique>();
        List<rubrique> liste_rub = new List<rubrique>();

        public bulltin_model()
        {
            InitializeComponent();
        }

        private void bulltin_model_Load(object sender, EventArgs e)
        {
            romplire();

        }
        public void changer_etat(bool etat, int id)
        {
            if (etat)
            {

                using (paieEntities12 db = new paieEntities12())
                {
                    var resultt = db.rubriques.SingleOrDefault(b => b.id_rubrique == id);
                    if (resultt != null)
                    {
                        resultt.etat = false;
                        db.Entry(resultt).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                   

                }
            }
            else
            {
                using (paieEntities12 db = new paieEntities12())
                {
                    var resultt = db.rubriques.SingleOrDefault(b => b.id_rubrique == id);
                    if (resultt != null)
                    {
                        resultt.etat = true;
                        db.Entry(resultt).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                   

                }
            }
        }
        void ajoute(DataGridView datagrid,List<rubrique> lise_rub)
        {
            foreach (var rub in lise_rub)
            {
              
                int row = datagrid.Rows.Add();
                if (!string.IsNullOrEmpty(rub.code))
                {
                    datagrid.Rows[row].Cells[0].Value = rub.code;
                }
                if (!string.IsNullOrEmpty(rub.libellé))
                {
                    datagrid.Rows[row].Cells[1].Value = rub.libellé;
                }
                if (!string.IsNullOrEmpty(rub.id_rubrique.ToString()))
                {
                    datagrid.Rows[row].Cells[2].Value = rub.id_rubrique.ToString();
                }


            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows != null && e.ColumnIndex == -1)
            {
                DataGridViewRow selectrows = dataGridView1.Rows[e.RowIndex];
                // MessageBox.Show(selectrows.Cells[2].Value.ToString());
               
                int i= Int32.Parse(selectrows.Cells[2].Value.ToString());
                foreach (var item in liste_rub_no_actif)
                {
                     
                    if (item.id_rubrique == i)
                    {
                        changer_etat(false, item.id_rubrique);
                       
                        romplire();
                        
                        break;

                    }
                }
            }
            
        }
            private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (dataGridView2.SelectedRows != null && e.ColumnIndex == -1)
            {
                DataGridViewRow selectrows = dataGridView2.Rows[e.RowIndex];
                // MessageBox.Show(selectrows.Cells[2].Value.ToString());

                int i = Int32.Parse(selectrows.Cells[2].Value.ToString());
                foreach (var item in liste_rub_actif)
                {

                    if (item.id_rubrique == i)
                    {
                        changer_etat(true, item.id_rubrique);

                        romplire();
                      
                        break;

                    }
                }
            }
        }
       void romplire()
        {
            liste_rub_no_actif.Clear();
            liste_rub_actif.Clear();
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            using (paieEntities12 db = new paieEntities12())
            {
                var query = from it in db.rubriques select it;
                foreach (var item in query)
                {
                    liste_rub.Add(item);
                    if (item.etat.GetValueOrDefault())
                    {
                        liste_rub_actif.Add(item);
                    }
                    else
                    {
                        liste_rub_no_actif.Add(item);
                    }
                }
            }
            ajoute(dataGridView1, liste_rub_no_actif);
            ajoute(dataGridView2, liste_rub_actif);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
