using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class code_wilaya : Form
    {
        string mod_réglement = "";
        public int id_entt;
        int id_contrat = 0;
        int g = 0;
        int t1 = 42;
        int t2 = 50;
        int t3 = 45;


        int id_sal;
        List<bultin_paie> liste_bultin = new List<bultin_paie>();

        List<Rubriquee> list_rub = new List<Rubriquee>();
        List<salariée> listeSAl = new List<salariée>();
        List<Contratt> listeContrat = new List<Contratt>();
        public static String path = AppDomain.CurrentDomain.BaseDirectory + @"..\..\image\";
        private string matruculee;
        Double ss = 0;
        List<baréme_IRG> baréme_irg = new List<baréme_IRG>();
        public Image im = Image.FromFile(path + "photos.png"); // read in image
        Size s = new Size(169, 184);
        public code_wilaya()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void code_wilaya_Load(object sender, EventArgs e)
        {
            label5.Image = resize(im, s); 
            
            comboBox1.Items.Add("janvier");
            comboBox1.Items.Add("février");
            comboBox1.Items.Add("mars");
            comboBox1.Items.Add("mars");
            comboBox1.Items.Add("mai");
            comboBox1.Items.Add("juin");
            comboBox1.Items.Add("juillet");
            comboBox1.Items.Add("aout");
            comboBox1.Items.Add("septembre");
            comboBox1.Items.Add("octobre");
            comboBox1.Items.Add("novembre");
            comboBox1.Items.Add("décembre");
            comboBox1.SelectedItem = ("mai");
            for (int i = 2011; i < 2020; i++)
            {
                comboBox2.Items.Add(i.ToString());
                comboBox3.Items.Add(i.ToString());
            }
            comboBox2.SelectedItem = ("2017");
            comboBox3.SelectedItem = ("2017");
            comboBox4.Items.Add("janvier");
            comboBox4.Items.Add("février");
            comboBox4.Items.Add("mars");
            comboBox4.Items.Add("mars");
            comboBox4.Items.Add("mai");
            comboBox4.Items.Add("juin");
            comboBox4.Items.Add("juillet");
            comboBox4.Items.Add("aout");
            comboBox4.Items.Add("septembre");
            comboBox4.Items.Add("octobre");
            comboBox4.Items.Add("novembre");
            comboBox4.Items.Add("décembre");
            comboBox4.SelectedItem = ("mai");




            using (paieEntities12 db = new paieEntities12())
            {
                var query = from it in db.rubriques select it;
                var queryy = from it in db.formules select it;
                var queryyy = db.Barém_cnas.SingleOrDefault(b => b.id == 2);
                var queryyyy = from it in db.baréme_IRG select it;
                foreach (var item in queryyyy)
                {
                    baréme_irg.Add(item);
                }

                ss = queryyy.Montant.Value;
                formule formu = new formule();
                foreach (rubrique new_rub in query)
                {
                    foreach (var item in queryy)
                    {
                        if (new_rub.id_rubrique == item.id_rubrique)
                        {
                            formu = item;

                        }
                    }



                    list_rub.Add(new Rubriquee() { id_rubrique = new_rub.id_rubrique, code = new_rub.code, Type = new_rub.sens.GetValueOrDefault(), abrégé = new_rub.abrégé, Libellé = new_rub.libellé, imopsalble = new_rub.imopsalble, montant = new_rub.montant.Value, formule = formu, cotisable = new_rub.cotisable.GetValueOrDefault(), imprimable = new_rub.imopsalblee, Typee = new_rub.Type_val, etat = new_rub.etat.GetValueOrDefault() });





                }
            }

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CTA_CheckedChanged(object sender, EventArgs e)
        {

        }



        public void radio_modif(string valeurdata, string valeurcomparé, RadioButton radio)
        {
            if (valeurdata.StartsWith(valeurcomparé))
            {
                radio.Checked = true;
            }
        }






        private void dataGridView1_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //MessageBox.Show("right click");
                ContextMenuStrip menu = new ContextMenuStrip();

                int position_souri = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                int position_sourii = dataGridView1.HitTest(e.X, e.Y).ColumnIndex;



                if (position_souri == -1)
                {

                    menu.Items.Add("del").Name = "del";
                    //menu.ItemClicked  // menu.ItemClicked("flle").name = delle";


                    menu.Show(dataGridView1, new Point(e.X, e.Y));

                }
                else
                {

                    ContextMenuStrip menue = new ContextMenuStrip();
                    menue.Items.Add("del").Name = "del";
                    menue.Show(dataGridView1, new Point(e.X, e.Y));
                }



            }

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataAjoute(DataGridView dataGridView1, List<salariée> liste)
        {
            foreach (var les_salariés in liste)
            {
                //int row = dataGridView1.NewRowIndex;
                int row = dataGridView1.Rows.Add();
                if (les_salariés.matréculation == null)
                {
                    dataGridView1.Rows[row].Cells[0].Value = "";
                }
                else
                {
                    dataGridView1.Rows[row].Cells[0].Value = les_salariés.matréculation;
                }
                if (les_salariés.Nom_salarié == null)
                {
                    dataGridView1.Rows[row].Cells[1].Value = "";
                }
                else
                {
                    dataGridView1.Rows[row].Cells[1].Value = les_salariés.Nom_salarié;
                }
                if (les_salariés.Prénom_Salarié == null)
                {
                    dataGridView1.Rows[row].Cells[2].Value = "";
                }
                else
                {
                    dataGridView1.Rows[row].Cells[2].Value = les_salariés.Prénom_Salarié;
                }
                if (les_salariés.Date_Naiss == null)
                {
                    dataGridView1.Rows[row].Cells[3].Value = "";
                }
                else
                {
                    dataGridView1.Rows[row].Cells[3].Value = les_salariés.Date_Naiss;
                }
                if (les_salariés.Lieu_naiss == null)
                {
                    dataGridView1.Rows[row].Cells[4].Value = "";
                }
                else
                {
                    dataGridView1.Rows[row].Cells[4].Value = les_salariés.Lieu_naiss;
                }
                if (les_salariés.Numéro_SS == null)
                {
                    dataGridView1.Rows[row].Cells[5].Value = "";
                }
                else
                {
                    dataGridView1.Rows[row].Cells[5].Value = les_salariés.Numéro_SS;
                }
                if (les_salariés.Sexe == null)
                {
                    dataGridView1.Rows[row].Cells[6].Value = "";
                }
                else
                {
                    dataGridView1.Rows[row].Cells[6].Value = les_salariés.Sexe;
                }
                if (les_salariés.Situation_familliale == null)
                {
                    dataGridView1.Rows[row].Cells[7].Value = "";
                }
                else
                {
                    dataGridView1.Rows[row].Cells[7].Value = les_salariés.Situation_familliale;
                }
                if (les_salariés.nationalité != null)
                {
                    dataGridView1.Rows[row].Cells[8].Value = "";
                }
                else
                {
                    dataGridView1.Rows[row].Cells[8].Value = les_salariés.nationalité;
                }
                if (les_salariés.adresse == null)
                {
                    dataGridView1.Rows[row].Cells[9].Value = "";
                }
                else
                {
                    dataGridView1.Rows[row].Cells[9].Value = les_salariés.adresse;
                }
                if (les_salariés.wilaya_naiss == null)
                {
                    dataGridView1.Rows[row].Cells[10].Value = "";
                }
                else
                {
                    dataGridView1.Rows[row].Cells[10].Value = les_salariés.wilaya_naiss;
                }
                if (les_salariés.code_postale == null)
                {
                    dataGridView1.Rows[row].Cells[11].Value = "";
                }
                else
                {
                    dataGridView1.Rows[row].Cells[11].Value = les_salariés.code_postale;
                }

                if (les_salariés.id_salarié == null)
                {
                    dataGridView1.Rows[row].Cells[12].Value = "";
                }
                else
                {
                    dataGridView1.Rows[row].Cells[12].Value = les_salariés.id_salarié;
                }





            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form4 f3 = new Form4();
            f3.id_ent = id_entt;
            f3.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public static Image resize(Image image, Size newsise)
        {
            Image new_image = new Bitmap(newsise.Height, newsise.Width);
            using (Graphics GFX = Graphics.FromImage((Bitmap)new_image))
            {
                GFX.DrawImage(image, new Rectangle(Point.Empty, newsise));
            }
            return new_image;
        }

        private void dataGridView1_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            inisialiser();

            if (dataGridView1.SelectedRows != null && e.ColumnIndex == -1)
            {

                int i = 0;
                button2.Enabled = true; button3.Enabled = true;
                label5.Image = resize(im, s); // put image on label
                this.Controls.Add(label5);
                Masculin.Checked = false; Féminin.Checked = false; Marié.Checked = false; Divorcé.Checked = false; Célibataire.Checked = false; Veuf.Checked = false; actif.Checked = false; suspandu.Checked = false; départ.Checked = false;

                try
                {
                    DataGridViewRow selectrows = dataGridView1.Rows[e.RowIndex];
                    foreach (var item in listeSAl)
                    {



                        if (item.id_salarié == Int32.Parse(selectrows.Cells[12].Value.ToString()))
                        {
                            g = i;


                        }
                        i++;


                    }
                    matrucule.Text = listeSAl[g].matréculation;
                    nom.Text = listeSAl[g].Nom_salarié;
                    prénom.Text = listeSAl[g].Prénom_Salarié;
                    id_sal = listeSAl[g].id_salarié;
                    panel3.Enabled = true;
                    if (listeSAl[g].Sexe != null)
                    {
                        radio_modif(listeSAl[g].Sexe.ToString(), "Mascu", Masculin); radio_modif(listeSAl[g].Sexe.ToString(), "Fémin", Féminin);          //SEX
                    }
                    if (listeSAl[g].Situation_familliale != null)
                    {
                        radio_modif(listeSAl[g].Situation_familliale.ToString(), "Mari", Marié); radio_modif(listeSAl[g].Situation_familliale.ToString(), "Divor", Divorcé); radio_modif(listeSAl[g].Situation_familliale.ToString(), "Veuf", Veuf); radio_modif(listeSAl[g].Situation_familliale.ToString(), "Célibat", Célibataire);//sutuiation familiale
                    }
                    if (listeSAl[g].etat_salarié != null)
                    {
                        radio_modif(listeSAl[g].etat_salarié.ToString(), "actif", actif); radio_modif(listeSAl[g].etat_salarié.ToString(), "suspandu", suspandu); radio_modif(listeSAl[g].etat_salarié.ToString(), "départ", départ);
                    }

                    nom_conjoint.Text = listeSAl[g].nom_conjoine.ToString();
                    person_charge.Text = listeSAl[g].personns_charge.ToString();
                    enfant_scolariser.Text = listeSAl[g].nb_enfant_sco.ToString();
                    date_naiss.Text = listeSAl[g].Date_Naiss.ToString();
                    lieu_naiss.Text = listeSAl[g].Lieu_naiss.ToString();

                    try
                    {
                        Image im = Image.FromFile(path + listeSAl[g].photoo); // read in image
                        Size s = new Size(169, 184);
                        // Bitmap objBitmap = new Bitmap(i, new Size(200, 171));
                        //label5.Size = new Size(i.Width, i.Height); //set label to correct size
                        label5.Image = resize(im, s); // put image on label
                        this.Controls.Add(label5);
                    }
                    catch (Exception)
                    {


                    }
                    if (listeSAl[g].situation_conjoine != null)
                    {
                        radio_modif(listeSAl[g].situation_conjoine.ToString(), "Au", Au_foyer); radio_modif(listeSAl[g].situation_conjoine.ToString(), "trava", travaille);
                    }
                    if (listeSAl[g].adresse != null)
                    {
                        adresse.Text = listeSAl[g].adresse.ToString();
                    }
                    if (listeSAl[g].code_wilaya != null)
                    {
                        code.Text = listeSAl[g].code_wilaya.ToString();
                    }
                    if (listeSAl[g].Num_Téléphone != null)
                    {
                        téléph_portable.Text = listeSAl[g].Num_Téléphone.ToString();
                    }
                    if (listeSAl[g].email != null)
                    {
                        email.Text = listeSAl[g].email.ToString();
                    }


                }
                catch (System.ArgumentOutOfRangeException ez)
                {

                    MessageBox.Show(ez.ToString());
                }


                //matrucule.Text = selectrows.Cells[0].Value.ToString();




                //adresse.Text = matruculee.ToString();

                //contrat




                if (listeSAl[g].contra.statu != null)
                {
                    id_contrat = i;
                    radio_modif(listeSAl[g].contra.statu.ToString(), "CDI", CDI); radio_modif(listeSAl[g].contra.statu.ToString(), "CDD", CDD); radio_modif(listeSAl[g].contra.statu.ToString(), "Appren", Apprenti); radio_modif(listeSAl[g].contra.statu.ToString(), "stagi", stagiare); radio_modif(listeSAl[g].contra.statu.ToString(), "CTA", CTA);
                }
                if (listeSAl[g].contra.date_embouche != null)
                {
                    date_ent.Text = listeSAl[g].contra.date_embouche.ToString();
                }
                if (listeSAl[g].contra.date_sotie != null)
                {
                    date_sort.Text = listeSAl[g].contra.date_sotie.ToString();
                }
                if (listeSAl[g].contra.date_fin != null)
                {
                    fin_cont.Text = listeSAl[g].contra.date_fin.ToString();
                }
                if (listeSAl[g].contra.rémunération != null)
                {
                    rénumération.Text = listeSAl[g].contra.rémunération.ToString();
                }
                if (listeSAl[g].contra.mod_calcule != null)
                {
                    mode_calcul.Text = listeSAl[g].contra.mod_calcule.ToString();
                }
                if (listeSAl[g].contra.salair_base != null)
                {
                    salair_ba.Text = listeSAl[g].contra.salair_base.ToString();
                }
                if (listeSAl[g].contra.mode_paiment != null)
                {
                    mode_paiement.Text = listeSAl[g].contra.mode_paiment.ToString();
                }
                if (listeSAl[g].contra.banque != null)
                {
                    Banque.Text = listeSAl[g].contra.banque.ToString();
                }
                if (!string.IsNullOrWhiteSpace(listeSAl[g].contra.CCP))
                {
                    CCP_RIP.Text = listeSAl[g].contra.CCP.ToString();
                }
                else if (!string.IsNullOrWhiteSpace(listeSAl[g].contra.Rip))
                {
                    CCP_RIP.Text = listeSAl[g].contra.Rip.ToString();
                }
                if (listeSAl[g].contra.exoneration_de_irg != null)
                {
                    radio_modif(listeSAl[g].contra.exoneration_de_irg.ToString(), "non", non); radio_modif(listeSAl[g].contra.exoneration_de_irg.ToString(), "Motant", Montant); radio_modif(listeSAl[g].contra.exoneration_de_irg.ToString(), "Taux", Taux);
                }
                if (listeSAl[g].contra.montont_exoneration != null)
                {
                    montont.Text = listeSAl[g].contra.montont_exoneration.ToString();
                }
                mod_réglement = listeSAl[g].contra.rémunération;

            }
            dataGridView2.Rows.Clear();
            textBox6.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            foreach (var item in listeSAl[g].historique_bulltin)
            {
                if (item.bultin.mois.StartsWith(comboBox1.Text) && item.bultin.année.StartsWith(this.comboBox2.Text))
                {

                    afichier_bulltin(dataGridView2, item);

                }
            }




        }

        private void code_wilaya_Activated(object sender, EventArgs e)
        {
            inisialiser();
            panel3.Enabled = false;
            dataGridView2.Rows.Clear();
            textBox6.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            button2.Enabled = false;

            button3.Enabled = false;
            label5.Image = resize(im, s);
            this.Controls.Add(label5);
            dataGridView1.Rows.Clear();
            listeSAl.Clear();
            listeContrat.Clear();


            using (paieEntities12 db = new paieEntities12())

            {
                var query = from it in db.salariés.Where(i => i.id_ent == id_entt).ToList() select it;






                foreach (salariés newSAL in query)
                {
                    Contratt cont = new Contratt();
                    try
                    {

                        var query2 = (from d in db.contrats where d.id_salarié == newSAL.id_salarié select d).Single();
                        if (query2 != null)
                        {
                            cont = new Contratt() { id_contrat = query2.id_contrat, date_embouche = query2.date_embouche.GetValueOrDefault(), frequancePaie = query2.frequnce_Paie, base_paie = query2.base_paie.GetValueOrDefault(), id_salarié = query2.id_salarié.GetValueOrDefault(), mode_reglement = query2.rémunération, salair_base = query2.salair_base.GetValueOrDefault(), taux_jour = query2.taux_heure.GetValueOrDefault(), taux_heure = query2.taux_heure.GetValueOrDefault(), statu = query2.statu, date_fin = query2.date_fin.GetValueOrDefault(), date_sotie = query2.date_sotie.GetValueOrDefault(), mod_calcule = query2.mod_calcule, rémunération = query2.rémunération, montont_exoneration = query2.montont_exoneration.GetValueOrDefault(), mode_paiment = query2.mode_paiment, banque = query2.banque, CCP = query2.CCP, Rip = query2.Rip, exoneration_de_irg = query2.exoneration_de_irg };

                        }
                    }
                    catch (Exception)
                    {

                    }




                    var query3 = from it in db.bultin_paie.Where(b => b.id_salarié == newSAL.id_salarié) select it;

                    List<Bulltin_paieeee> historique_bulltine = new List<Bulltin_paieeee>();

                    foreach (var item in query3)
                    {

                        var query4 = from it in db.ruberique_bulltin.Where(b => b.id_bulltin == item.id_bulltin).ToList() select it;
                        historique_bulltine.Add(new Bulltin_paieeee() { bultin = item, lise_rub = query4.ToList() });
                        //sqdq


                    }
                    try
                    {

                        listeSAl.Add(new salariée() { id_salarié = newSAL.id_salarié, Nom_salarié = newSAL.nom, matréculation = newSAL.matruculation, Prénom_Salarié = newSAL.prénom, Date_Naiss = newSAL.dat_naiss.GetValueOrDefault(), Lieu_naiss = newSAL.lieu_naiss, Numéro_SS = newSAL.num_sécurité_socialeee, Sexe = newSAL.sexe, Situation_familliale = newSAL.situation_famille, Num_Téléphone = newSAL.téléphone, etat_salarié = newSAL.état_sal, nationalité = newSAL.nationalité, adresse = newSAL.adresse_compléte, wilaya_naiss = newSAL.wilaya_naiss, prénom_pair = newSAL.prénom_pére, nom_mére = newSAL.nom_mére, personns_charge = newSAL.Personnes_charge.GetValueOrDefault(), nb_enfant_sco = newSAL.dans_enfant_scolarisé.GetValueOrDefault(), état_sal = newSAL.état_sal, nom_conjoine = newSAL.nom_conjoin, situation_conjoine = newSAL.situation_conjoin, code_wilaya = newSAL.code_wilaya, email = newSAL.email, photoo = newSAL.photos.TrimEnd(), contra = cont, historique_bulltin = historique_bulltine });

                    }
                    catch (Exception)
                    {


                    }
                }



                DataAjoute(dataGridView1, listeSAl);



            }


        }
        public void NotifyMe(int ent)
        {

            id_entt = ent;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();

            f.Modifier_sal = listeSAl[g];


            f.id_ent = id_entt;
            f.indexe = listeSAl[g].id_salarié;
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] tab = new string[13];
            int i = 0;
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)

            {

                tab[i] = cell.Value.ToString();


                i++;
            }




            const string message = "etes vous sur de vouloir supprimer ce salarié";
            const string caption = "Validation";

            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OKCancel,
                                         MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.OK)
            {
                listeSAl[0].SuprimerSalarié(Int32.Parse(tab[12]));
                code_wilaya parent = (code_wilaya)this.Owner;

            }







        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            calcule_paie(1, 1, 4, 1, comboBox3.Text, comboBox4.Text);

        }
        private void calcule_paie(int nb_jour_abs, int nb_heure_sup50, int nb_heure_sup75, int nb_heure_sup100, string année, string mois)
        {
            List<ruberique_bulltin> rubee = new List<ruberique_bulltin>();
            double i = 0, j = 0;
            bultin_paie bultin = new bultin_paie();
            foreach (var item in list_rub)
            {

                if (item.Typee.StartsWith("Gain(+)") && item.etat && item.cotisable)
                {

                    i += item.formule.montont.Value;
                    rubee.Add(new ruberique_bulltin { nbr_base = Math.Round(item.formule.nombre.GetValueOrDefault(), 2).ToString(), taux = Math.Round(item.formule.taux.GetValueOrDefault(), 2).ToString(), gain = Math.Round(item.formule.montont.GetValueOrDefault(), 2).ToString(), code = item.code.TrimEnd(), libellé = item.Libellé.TrimEnd() });

                }

            }


            bultin.salair_poste = Math.Round(i, 2);
            rubee.Add(new ruberique_bulltin { nbr_base = Math.Round(i, 2).ToString(), code = "500", libellé = "SALAIRE DE POSTE" });


            rubee.Add(new ruberique_bulltin { nbr_base = Math.Round(i, 2).ToString(), taux = Math.Round(ss, 2).ToString(), retenue = Math.Round((i * ss / 100), 2).ToString(), code = "510", libellé = "SECURITE SOCIEALE" });
            i = i - (i * ss / 100);
            bultin.Total_Retenu = Math.Round(i - (i * ss / 100), 2);


            foreach (var item in list_rub)
            {

                if (item.Typee.StartsWith("Gain(+)") && item.etat && !item.cotisable)
                {

                    i += item.montant;
                    rubee.Add(new ruberique_bulltin { nbr_base = Math.Round(item.formule.nombre.GetValueOrDefault(), 2).ToString(), taux = Math.Round(item.formule.taux.GetValueOrDefault(), 2).ToString(), gain = Math.Round(item.formule.montont.GetValueOrDefault(), 2).ToString(), code = item.code.TrimEnd(), libellé = item.Libellé });

                }

            }
            bultin.id_salarié = id_sal;

            rubee.Add(new ruberique_bulltin { nbr_base = Math.Round(i, 2).ToString(), code = "550", libellé = "NET IMPOSABLE" });
            rubee.Add(new ruberique_bulltin { nbr_base = Math.Round(i, 2).ToString(), taux = Math.Round(clcule_irgg(i), 2).ToString(), retenue = Math.Round(i * clcule_irgg(i) / 100, 2).ToString(), code = "570", libellé = "IRG" });
            bultin.Total_Retenu += Math.Round(i * clcule_irgg(i) / 100, 2);
            bultin.net_imposable = Math.Round(i, 2);
            bultin.net_a_apyer = Math.Round(i - (i * clcule_irgg(i) / 100), 2);
            bultin.mois = mois;
            bultin.année = année;
            bultin.mode_reglement = mod_réglement;
            int R;
            using (paieEntities12 dbe = new paieEntities12())
            {

                var query = from it in dbe.bultin_paie.OrderByDescending((x => x.id_bulltin)).ToList() select it;

                R = query.First().id_bulltin + 1;



                foreach (var item in rubee)
                {
                    // rubee[1].id_bulltin = R;
                    // MessageBox.Show(rubee[1].code + "  " + rubee[1].gain + "  " + rubee[1].libellé + "  " + rubee[1].nbr_base + "  " + rubee[1].taux + "  " + rubee[1].retenue);
                    item.id_bulltin = R;
                  //   MessageBox.Show(item.code + "  " + item.gain + "  " + item.libellé + "  " + item.nbr_base + "  " + item.taux + "  " + item.retenue);

                    dbe.ruberique_bulltin.Add(item);


                }
                dbe.bultin_paie.Add(bultin);

                dbe.SaveChanges();
                MessageBox.Show("le bulltin et bien ajouter avec succés");
            }




        }
        private Double clcule_irgg(double net_imposable)
        {
            foreach (var item in baréme_irg)
            {
                if (item.valeur_inferieur < net_imposable && net_imposable <= item.valeur_supérieur)
                {
                    return item.Montant.GetValueOrDefault();
                }
            }
            return 0;

        }
        private void entity(ruberique_bulltin rubee)
        {

            using (paieEntities12 dbee = new paieEntities12())
            {

                dbee.ruberique_bulltin.Add(rubee);


                MessageBox.Show(rubee.code + "  " + rubee.gain + "  " + rubee.libellé + "  " + rubee.nbr_base + "  " + rubee.taux + "  " + rubee.retenue);
                dbee.SaveChanges(); dbee.SaveChanges();
                MessageBox.Show("le bulltin et bien ajouter avec succés");
                try
                {


                }
                catch (DbEntityValidationException dbEx)
                {
                }
            }
        }
        void afichier_bulltin(DataGridView datagrid, Bulltin_paieeee bultin)
        {
            button4.Enabled = true;
            foreach (var rub_paie in bultin.lise_rub)
            {
                //int row = dataGridView1.NewRowIndex;
                int row = datagrid.Rows.Add();
                if (!string.IsNullOrEmpty(rub_paie.code))
                {
                    datagrid.Rows[row].Cells[0].Value = rub_paie.code;
                }
                if (!string.IsNullOrEmpty(rub_paie.libellé))
                {
                    datagrid.Rows[row].Cells[1].Value = rub_paie.libellé;
                }
                if (!string.IsNullOrEmpty(rub_paie.nbr_base))
                {
                    datagrid.Rows[row].Cells[2].Value = rub_paie.nbr_base;
                }
                if (!string.IsNullOrEmpty(rub_paie.taux))
                {
                    datagrid.Rows[row].Cells[3].Value = rub_paie.taux;
                }
                if (!string.IsNullOrEmpty(rub_paie.gain))
                {
                    datagrid.Rows[row].Cells[4].Value = rub_paie.gain;
                }
                if (!string.IsNullOrEmpty(rub_paie.retenue))
                {
                    datagrid.Rows[row].Cells[5].Value = rub_paie.retenue;
                }

            }
            textBox6.Text = bultin.bultin.salair_poste.GetValueOrDefault().ToString();
            textBox3.Text = bultin.bultin.net_imposable.GetValueOrDefault().ToString();
            textBox4.Text = bultin.bultin.Total_Retenu.GetValueOrDefault().ToString();
            textBox5.Text = bultin.bultin.net_a_apyer.GetValueOrDefault().ToString();

        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            button4.Enabled = false;
            if (id_sal != 0)
            {
                dataGridView2.Rows.Clear();
                textBox6.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                foreach (var item in listeSAl[g].historique_bulltin)
                {
                    if (item.bultin.mois.StartsWith(comboBox1.Text) && item.bultin.année.StartsWith(this.comboBox2.Text))
                    {

                        afichier_bulltin(dataGridView2, item);

                    }
                }
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

            button4.Enabled = false;
            if (id_sal != 0)
            {

                //  MessageBox.Show("zeaaezea");


                dataGridView2.Rows.Clear();
                textBox6.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                foreach (var item in listeSAl[g].historique_bulltin)
                {
                    if (item.bultin.mois.StartsWith(comboBox1.Text) && item.bultin.année.StartsWith(this.comboBox2.Text))
                    {

                        afichier_bulltin(dataGridView2, item);

                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (bulltin_model b = new bulltin_model())
            {
                b.ShowDialog();

            }

        }
        void inisialiser()
        {

            Masculin.Checked = false;
            Féminin.Checked = false;
            Marié.Checked = false;
            Divorcé.Checked = false;
            Veuf.Checked = false;
            Célibataire.Checked = false;
            Au_foyer.Checked = false;
            travaille.Checked = false;
            CDD.Checked = false;
            CDI.Checked = false;
            CTA.Checked = false;
            stagiare.Checked = false;
            Apprenti.Checked = false;
            date_ent.Text = "";
            lieu_naiss.Text = "";
            nom_conjoint.Text = "";
            enfant_scolariser.Text = "";
            person_charge.Text = "";
            adresse.Text = "";
            code.Text = "";
            téléph_fix.Text = "";
            téléph_portable.Text = "";
            email.Text = "";
            date_naiss.Text = "";
            date_sort.Text = "";
            fin_cont.Text = "";
            mode_calcul.Text = "";
            mode_paiement.Text = "";
            rénumération.Text = "";
            salair_ba.Text = "";
            Banque.Text = "";
            CCP_RIP.Text = "";



        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            entreprisee ent = new entreprisee();
            using (paieEntities12 db = new paieEntities12())
            {
                var query = (from d in db.Entreprises where d.id_entreprise == id_entt select d).Single();

                ent.Nom_Ent = query.nom_ent;
                ent.activité = query.Activité;
                ent.Adresse = query.adresse;
                ent.email = query.email;
                ent.rejistre_comerce = query.rejistre_comerce;
                ent.Téléphone = query.téléphone;

            }
            string ccp_rip = "5444454225424";
          //  MessageBox.Show(ent.Nom_Ent + ent.activité + ent.Adresse.TrimEnd() + ent.rejistre_comerce.TrimEnd() + ent.Téléphone.TrimEnd() + ent.email.TrimEnd());
            using (bultin im = new bultin(ent.Nom_Ent, ent.activité, ent.Adresse.TrimEnd(), ent.rejistre_comerce.TrimEnd(), ent.Téléphone.TrimEnd(), ent.email.TrimEnd(), comboBox1.Text + " " + comboBox2.Text, listeSAl[g].Nom_salarié.TrimEnd(), listeSAl[g].Prénom_Salarié.TrimEnd(), listeSAl[g].matréculation.TrimEnd(), listeSAl[g].contra.date_embouche.ToString("MM/dd/yyyy").TrimEnd(), listeSAl[g].Situation_familliale.TrimEnd(), listeSAl[g].Numéro_SS.TrimEnd(), ccp_rip.TrimEnd(), listeSAl[g].contra.rémunération.TrimEnd()))
            {



                foreach (var item in listeSAl[g].historique_bulltin)
                {
                    if (item.bultin.mois.StartsWith(comboBox1.Text) && item.bultin.année.StartsWith(this.comboBox2.Text))
                    {
                        //MessageBox.Show(item.lise_rub. .libellé + " " liste_rub[0].libellé + " " + liste_rub[0].libellé);
                     //   bultin.lise_rub
                           // item.lise_rub
                        im.liste_rub = item.lise_rub;
                        im.net_a_apyer = item.bultin.net_a_apyer.ToString();

                    }
                }
                im.ShowDialog();
            }
    }

        private void button8_Click(object sender, EventArgs e)
        {
            //entreprisee ent = new entreprisee();
            //using (paieEntities db = new paieEntities())
            //{
            //    var query = (from d in db.Entreprises where d.id_entreprise == id_entt select d).Single();

            //    ent.Nom_Ent = query.nom_ent;
            //    ent.activité = query.Activité;
            //    ent.Adresse = query.adresse;
            //    ent.email = query.email;
            //    ent.rejistre_comerce = query.rejistre_comerce;
            //    ent.Téléphone = query.téléphone;

            //}
            //string ccp_rip = "";

            //using (Print im = new Print(ent.Nom_Ent, ent.activité, ent.Adresse, ent.rejistre_comerce, ent.Téléphone, ent.email, comboBox1.Text + " " + comboBox2.Text, listeSAl[g].Nom_salarié, listeSAl[g].Prénom_Salarié, listeSAl[g].matréculation, listeSAl[g].contra.date_embouche.ToString("MM/dd/yyyy"), listeSAl[g].Situation_familliale, listeSAl[g].Numéro_SS,"644648448664", listeSAl[g].contra.rémunération))
            //{



            //    foreach (var item in listeSAl[g].historique_bulltin)
            //    {
            //        if (item.bultin.mois.StartsWith(comboBox1.Text) && item.bultin.année.StartsWith(this.comboBox2.Text))
            //        {

            //            im.liste_rub = item.lise_rub;
            //            im.Net_a_pyer = item.bultin.net_a_apyer.ToString();

            //        }
            //    }
            //    im.ShowDialog();
            //}
            pp p = new pp();
            p.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}