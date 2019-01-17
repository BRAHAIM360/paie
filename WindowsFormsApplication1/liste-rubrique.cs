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
    public partial class Liste_rubrique : Form
    {
        List<Rubriquee> list_rub = new List<Rubriquee>();
        List<formule> formu = new List<formule>();
        
        public Liste_rubrique()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fiche_Rubriquecs f = new fiche_Rubriquecs();
            f.id = 0;
            f.ShowDialog();
        }

        private void Liste_rubrique_Load(object sender, EventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] tab = new string[11];
            int i = 0;
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)

            {

                if (cell.Value == null)
                {
                    tab[i] = "";
                }
                else
                {
                    tab[i] = cell.Value.ToString();
                }
                i++;
            }




            const string message = "etes vous sur de vouloir supprimer cette rubrique";
            const string caption = "Validation";

            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OKCancel,
                                         MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.OK)
            {
                list_rub[0].suprimer_rub(Int32.Parse(tab[9]));
                
               

            }


        }

        private void Liste_rubrique_Activated(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.AllowUserToAddRows = false;
            list_rub.Clear();
            


            using (paieEntities12 db = new paieEntities12())

            {
                var query = from it in db.rubriques select it;
                var queryy= from it in db.formules select it;
                formule formu = new formule() ;
                foreach (rubrique new_rub in query)
                {
                    foreach (var item in queryy)
                    {
                        if (new_rub.id_rubrique ==item.id_rubrique)
                        {
                            formu = item;
                           
                        }
                    }
                   
                    

                        list_rub.Add(new Rubriquee() { id_rubrique = new_rub.id_rubrique, code = new_rub.code, Type = new_rub.sens.GetValueOrDefault(), abrégé = new_rub.abrégé, Libellé = new_rub.libellé, imopsalble = new_rub.imopsalble, montant = new_rub.montant.Value, formule = formu, cotisable = new_rub.cotisable.GetValueOrDefault(),imprimable=new_rub.imopsalblee ,Typee=new_rub.Type_val});

                    
                   


                }




            }
            DataAjoute(dataGridView1, list_rub);
            





        }
        private void DataAjoute(DataGridView dataGridView1, List<Rubriquee> liste)
        {
            foreach (var rub in liste)
            {
                //int row = dataGridView1.NewRowIndex;
                int row = dataGridView1.Rows.Add();
                if (!string.IsNullOrWhiteSpace(rub.code))
                {
                    dataGridView1.Rows[row].Cells[0].Value = rub.code.ToString();
                }
                if (!string.IsNullOrWhiteSpace(rub.Libellé))
                {
                    dataGridView1.Rows[row].Cells[1].Value = rub.Libellé.ToString();
                }
                if (!string.IsNullOrWhiteSpace(rub.Typee))
                {
                    dataGridView1.Rows[row].Cells[2].Value = rub.Typee.ToString();
                }
                if (rub.cotisable)
                {
                    dataGridView1.Rows[row].Cells[3].Value = "OUI";
                }
                else
                {
                    dataGridView1.Rows[row].Cells[3].Value = "NON";
                }
                if (!string.IsNullOrWhiteSpace(rub.imopsalble))
                {
                    dataGridView1.Rows[row].Cells[4].Value = rub.imopsalble.ToString();
                }
                if (!string.IsNullOrWhiteSpace(rub.formule.equoiation))
                {
                    dataGridView1.Rows[row].Cells[5].Value = rub.formule.equoiation.ToString();
                }
                if (!string.IsNullOrWhiteSpace(rub.imprimable))
                {
                    dataGridView1.Rows[row].Cells[6].Value = rub.imprimable;
                }
               
                    dataGridView1.Rows[row].Cells[7].Value = "oui";
                    dataGridView1.Rows[row].Cells[9].Value = rub.id_rubrique.ToString();



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] tab = new string[11];
            int i = 0;
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)

            {

                if (cell.Value == null)
                {
                    tab[i] = "";
                }
                else
                {
                    tab[i] = cell.Value.ToString();
                }
                i++;
            }
            int x;
             
            if (tab[9] != null)
            {

            
            fiche_Rubriquecs f = new fiche_Rubriquecs();
            try
            {
                f.id = Int32.Parse(tab[9]);
            }
            catch (Exception)
            {

                
            }
            
            foreach (var item in list_rub.ToList())
            {
                
                    if (Int32.Parse(tab[9]) == item.id_rubrique)
                    {
                        f.Rub = item;

                    }
                    
               
                
            }
                f.ShowDialog();
            }

        }
    }
}
