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
    public partial class Liste_user : Form
    {
        List<Loginn> list_user = new List<Loginn>();
        public Liste_user()
        {
            InitializeComponent();
        }

        private void Liste_user_Activated(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            dataGridView1.Rows.Clear();
            dataGridView1.AllowUserToAddRows = false;
            list_user.Clear();


            using (paieEntities12 db = new paieEntities12())

            {
                var query = from it in db.logins select it;

                foreach (login new_log in query)
                {

                    list_user.Add(new Loginn { id = new_log.id, utilisateur = new_log.utilisateur, mot_de_pass = new_log.mot_de_pass, role = new_log.role });

                }


                DataAjoute(dataGridView1, list_user);

            }


        }
        private void DataAjoute(DataGridView dataGridView1, List<Loginn> liste)
        {
            foreach (var user in list_user)
            {
                //int row = dataGridView1.NewRowIndex;
                int row = dataGridView1.Rows.Add();
                if (user.utilisateur == null)
                {
                    dataGridView1.Rows[row].Cells[0].Value = "";
                }
                else
                {
                    dataGridView1.Rows[row].Cells[0].Value = user.utilisateur;

                }
                if (user.mot_de_pass == null)
                {
                    dataGridView1.Rows[row].Cells[1].Value = "";
                }
                else
                {
                    dataGridView1.Rows[row].Cells[1].Value = user.mot_de_pass;

                }
                if (user.role == null)
                {
                    dataGridView1.Rows[row].Cells[2].Value = "";
                }
                else
                {
                    dataGridView1.Rows[row].Cells[2].Value = user.role;

                }
                dataGridView1.Rows[row].Cells[3].Value = user.id;

            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == -1)
            {
                button2.Enabled = true; button3.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] tab = new string[4];
            int i = 0;
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)

            {


                tab[i] = cell.Value.ToString();
                i++;
            }
            const string message = "etes vous sur de vouloir supprimer ce utilisateur";
            const string caption = "Validation";

            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OKCancel,
                                         MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.OK)
            {



                
                
               list_user[0].suprimer_user(Int32.Parse(tab[3]));
                MessageBox.Show(tab[3]);
                // cancel the closure of the form.

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_user a = new Add_user();
            a.id = 0;
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string[] tab = new string[4];
            int i = 0;
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)

            {


                tab[i] = cell.Value.ToString();
                i++;
            }
            Add_user a = new Add_user();
            a.id =Int32.Parse(tab[3]);
            Loginn us = new Loginn() {utilisateur=tab[0],mot_de_pass=tab[1],role=tab[2] };
            a.User= us;
            a.ShowDialog();
        }

        private void Liste_user_Load(object sender, EventArgs e)
        {

        }
    }
}
