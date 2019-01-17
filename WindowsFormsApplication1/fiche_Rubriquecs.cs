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
    public partial class fiche_Rubriquecs : Form
    {
        public int id;
        private Rubriquee rub = new Rubriquee();
        private List<String> codee = new List<String>();
        private formule formul = new formule();
        

        internal formule Formul { get => formul; set => formul = value; }
        internal Rubriquee Rub { get => rub; set => rub = value; }

        public fiche_Rubriquecs()
        {
            InitializeComponent();
        }

        private void fiche_Rubriquecs_Load(object sender, EventArgs e)
        {

            using (paieEntities12 db = new paieEntities12())

            {
                var query = from it in db.rubriques select it;

                foreach (rubrique new_code in query)
                {
                    codee.Add(new_code.code.ToString().Trim());

                }




                }
                imprimable.Items.Add("si non NULL");
            imprimable.Items.Add("NON");
            imprimable.Items.Add("OUI");
            imprimable.SelectedItem = "si non NULL";
            sens.Items.Add("Retenue(-)");
            sens.Items.Add("Gain(+)");
            sens.Items.Add("Taux");
            sens.Items.Add("Nombre");
            sens.Items.Add("Base");
            sens.SelectedItem = "Gain(+)";
            cotisable.Items.Add("OUI");
            cotisable.Items.Add("NON");
            cotisable.SelectedItem = "OUI";
            Imposable.Items.Add("imposable a IRG");
            Imposable.Items.Add("imposable par pourssontage");
            Imposable.Items.Add("non imposable");
            Imposable.SelectedItem = "imposable a IRG";

            Imposable.SelectedItem = "Montant";
            if (id !=0)
            {
                code.Text = Rub.code;
                libellé.Text = Rub.Libellé;
                abrégé.Text = Rub.abrégé;
                imprimable.SelectedItem = rub.imprimable;
                
                compt.SelectedItem = Rub.compt;
                if (!string.IsNullOrEmpty(Rub.formule.equoiation))
                {
                    
                    comboBox3.SelectedItem = Rub.formule.equoiation;
                }
              
               
                if (Rub.Type)
                {
                    sens.SelectedItem = "Gain(+)";
                }
                else
                {
                    sens.SelectedItem = "Retenue(-)";
                }
                if (Rub.cotisable)
                {
                    cotisable.SelectedItem = "OUI";
                }
                else
                {
                    cotisable.SelectedItem = "NON";
                }
                Imposable.SelectedItem = Rub.imopsalble;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codeee = "";
            
            string abrégéé = "";
            string imprimableee = "";
            string libeléé = "";
            string comptee = "";
            string senss = "";
            Boolean cotisablee=true;
            string imposablee = "";
            Double valeur_ini = 0;
            string typee = "";
            
            if (!string.IsNullOrWhiteSpace(code.Text))
            {
                codeee = code.Text.ToString().TrimEnd();
            }
            if (!string.IsNullOrWhiteSpace(abrégé.Text))
            {
                abrégéé = abrégé.Text;
            }
          
            if (!string.IsNullOrWhiteSpace(libellé.Text))
            {
                libeléé = libellé.Text;
            }
            
          
         

            if (!string.IsNullOrWhiteSpace(valeur_initialisation.Text))
            {
                try
                {
                    valeur_ini = Double.Parse(valeur_initialisation.Text);
                }
                catch (Exception)
                {


                }

            }
            imposablee= this.Imposable.GetItemText(this.Imposable.SelectedItem);
            comptee = this.compt.GetItemText(this.compt.SelectedItem);
            typee= this.sens.GetItemText(this.sens.SelectedItem);
            senss = this.sens.GetItemText(this.sens.SelectedItem);
            imprimableee = this.imprimable.GetItemText(this.imprimable.SelectedItem);
          
            
            if (this.cotisable.GetItemText(this.cotisable.SelectedItem) == "OUI")
            {
                cotisablee = true;
            }
            else if (this.cotisable.GetItemText(this.cotisable.SelectedItem) == "NON")
            {
                cotisablee = false;
            }
            Boolean b = true;
            foreach (var item in codee)
            {
                if (item.StartsWith(codeee))
                {
                    b = false;
                }
            }
            if (b)
            {

                
                if (id == 0)
                {


                    if (senss == "Gain(+)")
                    {
                        
                        Gain rub = new Gain() { code = codeee, abrégé = abrégéé, Libellé = libeléé, imopsalble = imposablee, cotisable = cotisablee, imprimable = imprimableee, montant = valeur_ini, Typee = typee, formule = Formul };
                      
                        rub.ajouter();

                    }
                    else if (senss == "Retenue(-)")
                    {
                        Retenue rub = new Retenue() { code = codeee, abrégé = abrégéé, Libellé = libeléé, imprimable = imprimableee, montant = valeur_ini, Typee = typee, formule = Formul };
                        
                        rub.ajouter();
                    }
                    else if (senss == "Taux")
                    {
                        Taux rub = new Taux() { code = codeee, abrégé = abrégéé, Libellé = libeléé, imprimable = imprimableee, montant = valeur_ini, Typee = typee };
                        rub.ajouter();
                    }
                    else if (senss == "Nombre")
                    {
                        Nombre rub = new Nombre() { code = codeee, abrégé = abrégéé, Libellé = libeléé, imprimable = imprimableee, montant = valeur_ini, Typee = typee };
                        rub.ajouter();
                    }
                    else if (senss == "Base")
                    {
                        Base rub = new Base() { code = codeee, abrégé = abrégéé, Libellé = libeléé, imprimable = imprimableee, montant = valeur_ini, Typee = typee };
                        rub.ajouter();
                    }
                }
                else
                {
                    if (senss == "Gain(+)")
                    {

                       
                        Gain rub = new Gain() { code = codeee, abrégé = abrégéé, Libellé = libeléé, imopsalble = imposablee, cotisable = cotisablee, imprimable = imprimableee, montant = valeur_ini, Typee = typee,formule=Rub.formule};
                       
                        rub.modifier(id);

                    }
                    else if (senss == "Retenue(-)")
                    {
                       
                        Retenue rub = new Retenue() { code = codeee, abrégé = abrégéé, Libellé = libeléé, imprimable = imprimableee, montant = valeur_ini, Typee = typee , formule = Rub.formule };
                        rub.modifier(id);
                    }
                    else if (senss == "Taux")
                    {
                        Taux rub = new Taux() { code = codeee, abrégé = abrégéé, Libellé = libeléé, imprimable = imprimableee, montant = valeur_ini, Typee = typee };
                        rub.modifier(id);
                    }
                    else if (senss == "Nombre")
                    {
                        Nombre rub = new Nombre() { code = codeee, abrégé = abrégéé, Libellé = libeléé, imprimable = imprimableee, montant = valeur_ini, Typee = typee };
                        rub.modifier(id);
                    }
                    else if (senss == "Base")
                    {
                        Base rub = new Base() { code = codeee, abrégé = abrégéé, Libellé = libeléé, imprimable = imprimableee, montant = valeur_ini, Typee = typee };
                        rub.modifier(id);
                    }

                }
               

                this.Close();
            }
            else
            {
                MessageBox.Show("le code existe déjà");
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

        private void button3_Click(object sender, EventArgs e)
        {
        
            using (ADDformule a = new ADDformule())
            {
                if (id==0)
                {
                    a.id = 0;
                    a.ShowDialog(this);
                }
                else
                {

                    a.id = id;
                    a.formu = Rub.formule;
                    a.ShowDialog(this);
                }
                

            }
            
           

        }

        private void fiche_Rubriquecs_Activated(object sender, EventArgs e)
        {
            if (formul != null)
            {
            if (formul.equoiation != null)
            {
                    comboBox3.Items.Add(formul.equoiation);
                comboBox3.SelectedItem = formul.equoiation;
               // MessageBox.Show(formul.equoiation);
            }
            }

            //else
            if (Rub!=null)
            {
                if (Rub.formule != null)
                {
                    if (Rub.formule.equoiation != null)
                    {
                        comboBox3.Items.Add(Rub.formule.equoiation);
                        comboBox3.SelectedItem = Rub.formule.equoiation;
                        
                    }
                }

            }
            
            

            
        }

        private void sens_TextUpdate(object sender, EventArgs e)
        {
            
        }

        private void sens_SelectedValueChanged(object sender, EventArgs e)
        {
            
            if (sens.Text == "Taux" || sens.Text == "Nombre" || sens.Text == "Base" || sens.Text == "Retenue(-)")
            {
                cotisable.Enabled = false;
                Imposable.Enabled = false;
              
            }
            else
            {
                cotisable.Enabled = true;
                Imposable.Enabled = true;
                
            }
        }
    }
}
