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
    public partial class Constant : Form
    {
        List<Constantt> list_con = new List<Constantt>();
        List<Rubriquee> list_rub = new List<Rubriquee>();
        

        public int i = 0;
        string code = "";
        Double valeur = 0;
        public Constant()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            ADDformule parent = (ADDformule)this.Owner;
            parent.i = i;
            parent.code = code;
            parent.valeur = valeur;

            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.Enabled = true;
            if (dataGridView1.SelectedRows != null && e.ColumnIndex == -1)
            {
                try
                {
                    DataGridViewRow selectrows = dataGridView1.Rows[e.RowIndex];
                   
                            code = selectrows.Cells[0].Value.ToString();
                            valeur = Double.Parse( selectrows.Cells[2].Value.ToString());

                      
                       
                    
                }
                catch (Exception) { }
            }
        }

        private void Constant_Load(object sender, EventArgs e)
        {
            using (paieEntities12 db = new paieEntities12())
            {
               var querry = from it in db.Constantts select it;
                var query = from it in db.rubriques select it;
                var query2 = from it in db.formules select it;

                int row = dataGridView1.Rows.Add();
                formule formu= new formule() ;
                foreach (var new_rub in query)
                {
                    
                    foreach (var item in query2)
                    {
                        if (new_rub.id_rubrique == item.id_rubrique)
                        {
                            formu = item;

                        }
                    }
                    list_rub.Add(new Rubriquee() { id_rubrique = new_rub.id_rubrique, code = new_rub.code, Type = new_rub.sens.GetValueOrDefault(), abrégé = new_rub.abrégé, Libellé = new_rub.libellé, imopsalble = new_rub.imopsalble, montant = new_rub.montant.Value, formule = formu,valeur_ini=new_rub.valeur_initia.GetValueOrDefault() });
                }
                foreach (var item in querry)
                {
                    list_con.Add(item);
                    if (item.Code == null)
                    {
                        dataGridView1.Rows[row].Cells[0].Value = "";
                    }
                    else
                    {
                        dataGridView1.Rows[row].Cells[0].Value = item.Code;
                    }
                    if (item.Intitulé == null)
                    {
                        dataGridView1.Rows[row].Cells[1].Value = "";
                    }
                    else
                    {
                        dataGridView1.Rows[row].Cells[1].Value = item.Intitulé;
                    }
                    if (item.Valeur == null)
                    {
                        dataGridView1.Rows[row].Cells[2].Value = "";
                    }
                    else
                    {
                        dataGridView1.Rows[row].Cells[2].Value = item.Valeur.ToString();
                    }
                }
                data_ajout(list_rub,dataGridView1);



            }
        }
        void data_ajout(List<Rubriquee> liste,DataGridView dataGridView1)
        {

           
            foreach (var item in liste)
            {
                int row = dataGridView1.Rows.Add();
                if (item.abrégé == null)
                {
                    dataGridView1.Rows[row].Cells[0].Value = "";
                }
                else
                {
                    dataGridView1.Rows[row].Cells[0].Value = item.abrégé;
                }
                if (item.Libellé == null)
                {
                    dataGridView1.Rows[row].Cells[1].Value = "";
                }
                else
                {
                    dataGridView1.Rows[row].Cells[1].Value = item.Libellé;
                }
                
                 if (!string.IsNullOrWhiteSpace(item.valeur_ini.ToString())&& item.valeur_ini != 0)
                {
                    dataGridView1.Rows[row].Cells[2].Value = item.valeur_ini.ToString();
                }
                else if (string.IsNullOrWhiteSpace(item.formule.montont.ToString()))
                {
                    dataGridView1.Rows[row].Cells[2].Value = item.formule.montont.ToString();
                }
                 
            }
        }
    }
}
