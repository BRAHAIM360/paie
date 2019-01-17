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
    public partial class Add_user : Form
    {
        public int id;
        private Loginn user;

        internal Loginn User { get => user; set => user = value; }

        public Add_user()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text==textBox3.Text)
            {
                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    if (id==0)
                    {
                        Loginn b = new Loginn { utilisateur = textBox1.Text, mot_de_pass = textBox2.Text, role = comboBox1.Text };
                        b.ajouter_user();
                        this.Close();
                    }
                    else
                    {
                        Loginn b = new Loginn { utilisateur = textBox1.Text, mot_de_pass = textBox2.Text, role = comboBox1.Text };
                        b.modifier_user(id);
                        this.Close();
                    }
                   
                }

               
            }
            else
            {
                MessageBox.Show(" les mots de passe ne sont pas identiques");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_user_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("user");
            comboBox1.Items.Add("admin");
            comboBox1.SelectedItem="user";
            if (id!=0)
            {
               textBox1.Text= user.utilisateur;
               textBox2.Text = user.mot_de_pass;
               textBox3.Text = user.mot_de_pass;
                if (user.role.StartsWith("admin"))
                {
                    comboBox1.SelectedItem = "admin";
                }
              
            }
        }
    }
}
