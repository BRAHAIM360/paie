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
    public partial class Form4 : Form
    {
        public int id_ent;
        public int indexe;
        public Boolean ab = true;

        string photos = "";
        private salariée modifier_sal = new salariée();
        String path = AppDomain.CurrentDomain.BaseDirectory + @"..\..\image\";

        private Contratt contrattt = new Contratt();
        internal salariée Modifier_sal { get => modifier_sal; set => modifier_sal = value; }
        internal Contratt Contrat { get => contrattt; set => contrattt = value; }

        public void modifier_sall() { }

        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string numéro__ss = "";
            string Nom_sala = "";
            string prénom_sala = "";
            string matruculee = "";
            string lieu_naisss = "";
            string téléphone = "";
            int personns_charge = 0;
            int enfant_scoo = 0;
            string nationalitéé = "";
            string adresseee = "";
            string wilaya_naisss = "";
            string prénom_péree = "";
            string nom_méree = "";
            string prénom_méree = "";
            string emaile = "";
            string nom_conjoinee = "";


            if (!string.IsNullOrWhiteSpace(Prénom_mére.Text))
            {
                prénom_méree = Prénom_mére.Text;


            }
            if (!string.IsNullOrWhiteSpace(numéro_sécurité_sociale.Text))
            {
                numéro__ss = numéro_sécurité_sociale.Text;


            }
            if (!string.IsNullOrWhiteSpace(Numéro_tél.Text))
            {
                téléphone = Numéro_tél.Text;


            }






            try
            {
                enfant_scoo = Int32.Parse(enfant_scolariser.Text);
            }
            catch (FormatException)
            {


            }
            try
            {
                personns_charge = Int32.Parse(personns_char.Text);
            }
            catch (FormatException)
            {

            }
            if (!string.IsNullOrWhiteSpace(Nom.Text))
            {
                Nom_sala = Nom.Text;


            }
            if (!string.IsNullOrWhiteSpace(prénom.Text))
            {
                prénom_sala = prénom.Text;


            }
            if (!string.IsNullOrWhiteSpace(Matrucule.Text))
            {
                matruculee = Matrucule.Text;


            }
            if (!string.IsNullOrWhiteSpace(Lieu_naiss.Text))
            {
                lieu_naisss = Lieu_naiss.Text;


            }

            if (!string.IsNullOrWhiteSpace(nationalité.Text))
            {
                nationalitéé = nationalité.Text;


            }
            if (!string.IsNullOrWhiteSpace(Adresse.Text))
            {
                adresseee = Adresse.Text;


            }
            if (!string.IsNullOrWhiteSpace(wilaya_naiss.Text))
            {
                wilaya_naisss = wilaya_naiss.Text;


            }
            if (!string.IsNullOrWhiteSpace(prénom_pére.Text))
            {
                prénom_péree = prénom_pére.Text;


            }
            if (!string.IsNullOrWhiteSpace(email.Text))
            {
                emaile = email.Text;


            }
            if (!string.IsNullOrWhiteSpace(nom_conjoine.Text))
            {
                nom_conjoinee = nom_conjoine.Text;


            }



            string sexe = "";
            if (Masculin.Checked)
            {
                sexe = Masculin.Text;
            }
            else if (Féminin.Checked)
            {
                sexe = Féminin.Text;
            }
            string Situation_famil = "";
            if (Marié.Checked)
            {
                Situation_famil = Marié.Text;
            }
            else if (Veuf.Checked)
            {
                Situation_famil = Veuf.Text;
            }
            else if (Célibataire.Checked)
            {
                Situation_famil = Célibataire.Text;
            }
            else if (Divorcé.Checked)
            {
                Situation_famil = Divorcé.Text;
            }
            string Situation_conjoin = "";
            if (Au_foyer.Checked)
            {
                Situation_conjoin = Au_foyer.Text;
            }
            else if (travaille.Checked)
            {
                Situation_conjoin = travaille.Text;
            }



            if (indexe == 0)
            {
                Form5 f = new Form5();
                salariée sal = new salariée() { matréculation = matruculee, Nom_salarié = Nom_sala, Prénom_Salarié = prénom_sala, Date_Naiss = Date_naiss.Value, Lieu_naiss = lieu_naisss, Numéro_SS = numéro__ss, Sexe = sexe, Situation_familliale = Situation_famil, Num_Téléphone = téléphone, etat_salarié = "actif", nationalité = nationalitéé, adresse = adresseee, wilaya_naiss = wilaya_naisss, prénom_pair = prénom_péree, nom_mére = nom_méree, prénom_mére = prénom_méree, code_postale = 3100, personns_charge = personns_charge, nb_enfant_sco = enfant_scoo, nom_conjoine = nom_conjoinee, situation_conjoine = Situation_conjoin, email = emaile, photoo = photos, id_ent = id_ent };

                f.Sal = sal;
                f.id_sal = 0;

                f.id_cont = 0;


                f.ShowDialog(this);
                this.Close();
            }
            else
            {

                salariée sal = new salariée() { id_salarié = indexe, matréculation = matruculee, Nom_salarié = Nom_sala, Prénom_Salarié = prénom_sala, Date_Naiss = Date_naiss.Value, Lieu_naiss = lieu_naisss, Numéro_SS = numéro__ss, Sexe = sexe, Situation_familliale = Situation_famil, Num_Téléphone = téléphone, etat_salarié = "actif", nationalité = nationalitéé, adresse = adresseee, wilaya_naiss = wilaya_naisss, prénom_pair = prénom_péree, nom_mére = nom_méree, prénom_mére = prénom_méree, code_postale = 3100, personns_charge = personns_charge, nb_enfant_sco = enfant_scoo, nom_conjoine = nom_conjoinee, situation_conjoine = Situation_conjoin, email = emaile, photoo = photos, id_ent = modifier_sal.id_ent, contra = modifier_sal.contra };



                using (Form5 f = new Form5())
                {
                    // passing this in ShowDialog will set the .Owner 
                    // property of the child form

                    f.Sal = sal;
                    f.id_sal = indexe;

                    f.id_cont = indexe;




                    f.ShowDialog(this);

                    if (ab)
                    {
                        this.Close();

                    }
                    else
                    {
                        this.Show();
                    }
                }





            }






        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap myBitmap = new Bitmap(169, 184);
            this.saveFileDialog1.FileName = Application.ExecutablePath;
            if (this.saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                myBitmap.Save(this.saveFileDialog1.FileName);

            }
        }

        public void NotifyMe(Boolean a)
        {

            ab = a;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Image i = Image.FromFile(path + @"\photos.png");
            pictureBox1.BackgroundImage = i;
            if (indexe != 0)
            {



                pictureBox1.BackgroundImage = i;
                try
                {
                    Date_naiss.Value = modifier_sal.Date_Naiss;
                }
                catch (System.ArgumentOutOfRangeException es)
                {


                }

                //Date_naiss = modifier_sal.Date_Naiss.ToString("dd/MM/yyyy HH:mm:ss");
                if (!string.IsNullOrWhiteSpace(modifier_sal.Nom_salarié))
                {
                    Nom.Text = modifier_sal.Nom_salarié.ToString().TrimEnd();
                }
                if (!string.IsNullOrWhiteSpace(modifier_sal.Prénom_Salarié))
                {
                    prénom.Text = modifier_sal.Prénom_Salarié.ToString().TrimEnd();
                }
                if (!string.IsNullOrWhiteSpace(modifier_sal.matréculation))
                {
                    Matrucule.Text = modifier_sal.matréculation.ToString().TrimEnd();
                }

                if (!string.IsNullOrWhiteSpace(modifier_sal.Numéro_SS))
                {
                    numéro_sécurité_sociale.Text = modifier_sal.Numéro_SS.ToString().TrimEnd();
                }

                if (!string.IsNullOrWhiteSpace(modifier_sal.Num_Téléphone))
                {
                    Numéro_tél.Text = modifier_sal.Num_Téléphone.ToString().TrimEnd();
                }

                if (!string.IsNullOrWhiteSpace(modifier_sal.nom_conjoine))
                {
                    nom_conjoine.Text = modifier_sal.nom_conjoine.ToString().TrimEnd();
                }
                if (!string.IsNullOrWhiteSpace(modifier_sal.Lieu_naiss))
                {
                    Lieu_naiss.Text = modifier_sal.Lieu_naiss.ToString().TrimEnd();
                }

                if (!string.IsNullOrWhiteSpace(modifier_sal.nationalité))
                {
                    nationalité.Text = modifier_sal.nationalité.ToString().TrimEnd();
                }
                if (!string.IsNullOrWhiteSpace(modifier_sal.wilaya_naiss))
                {
                    wilaya_naiss.Text = modifier_sal.wilaya_naiss.ToString().TrimEnd();
                }
                if (!string.IsNullOrWhiteSpace(modifier_sal.prénom_pair))
                {
                    prénom_pére.Text = modifier_sal.prénom_pair.ToString().TrimEnd();
                }
                if (!string.IsNullOrWhiteSpace(modifier_sal.nom_mére))
                {
                    Nom_mére.Text = modifier_sal.nom_mére.ToString().TrimEnd();
                }
                if (!string.IsNullOrWhiteSpace(modifier_sal.prénom_mére))
                {
                    Prénom_mére.Text = modifier_sal.prénom_mére.ToString().TrimEnd();
                }
                if (!string.IsNullOrWhiteSpace(modifier_sal.email))
                {
                    email.Text = modifier_sal.email.ToString().TrimEnd();
                }
                if (!string.IsNullOrWhiteSpace(modifier_sal.adresse))
                {
                    Adresse.Text = modifier_sal.adresse.ToString().TrimEnd();

                }
                personns_char.Text = modifier_sal.personns_charge.ToString();
                enfant_scolariser.Text = modifier_sal.nb_enfant_sco.ToString();


                if (!string.IsNullOrWhiteSpace(modifier_sal.photoo))
                {
                    i = Image.FromFile(path + @"/" + modifier_sal.photoo);
                    Size s = new Size(169, 184);
                    pictureBox1.BackgroundImage = resize(i, s);
                }

                if (!string.IsNullOrWhiteSpace(modifier_sal.Sexe))
                {
                    radio_modif(modifier_sal.Sexe.ToString(), "Mascu", Masculin); radio_modif(modifier_sal.Sexe.ToString(), "Fémin", Féminin);          //SEX
                    
                }
                if (!string.IsNullOrWhiteSpace(modifier_sal.Situation_familliale))
                {
                    radio_modif(modifier_sal.Situation_familliale.ToString(), "Mari", Marié); radio_modif(modifier_sal.Situation_familliale.ToString(), "Divor", Divorcé); radio_modif(modifier_sal.Situation_familliale.ToString(), "Veuf", Veuf); radio_modif(modifier_sal.Situation_familliale.ToString(), "Célibat", Célibataire);//sutuiation familiale
                }

                if (!string.IsNullOrWhiteSpace(modifier_sal.situation_conjoine))
                {
                    
                    radio_modif(modifier_sal.situation_conjoine.ToString(), "Au", Au_foyer); radio_modif(modifier_sal.situation_conjoine.ToString(), "trava", travaille);
                }

            }
      
   

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                photos = openFileDialog1.SafeFileName;
                try
                {
                    System.IO.File.Copy(openFileDialog1.FileName, path + openFileDialog1.SafeFileName);
                    Image i = Image.FromFile(openFileDialog1.FileName);
                    Size s = new Size(169, 184);
                    pictureBox1.BackgroundImage = resize(i, s);

                }
                catch (System.IO.IOException)
                {


                }
            }
                
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void radio_modif(string valeurdata, string valeurcomparé, RadioButton radio)
        {
            if (valeurdata.StartsWith(valeurcomparé))
            {
                radio.Checked = true;
            }
        }
       
    }
}


