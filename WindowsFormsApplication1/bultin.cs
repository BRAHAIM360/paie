using Microsoft.Reporting.WinForms;
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
    public partial class bultin : Form
    {
        string nom_ent;
        string activité_ent;
        string adresse_ent;
        string registre_comerce;
        string téléphone_ent;
        string eamail_ent;
        string mois_année_bultin;
        string nom_sal;
        string prénom_sal;
        string matricule_sal;
        string date_embouche;
        string situiation_fam;
        string numm_ss_sal;
        string num_ccp_rip;
        string mode_vérsement;
        public string net_a_apyer;
        public List<ruberique_bulltin> liste_rub = new List<ruberique_bulltin>();
        public bultin(string nom_ent, string activité_ent, string adresse_ent, string registre_comerce, string téléphone_ent, string eamail_ent, string mois_année_bultin, string nom_sal, string prénom_sal, string matricule_sal, string date_embouche, string situiation_fam, string numm_ss_sal, string num_ccp_rip, string mode_vérsement)
        {
            InitializeComponent();
            this.nom_ent = nom_ent;
            this.activité_ent = activité_ent;
            this.adresse_ent = adresse_ent;
            this.registre_comerce = registre_comerce;
            this.téléphone_ent = téléphone_ent;
            this.eamail_ent = eamail_ent;
            this.mois_année_bultin = mois_année_bultin;
            this.nom_sal = nom_sal;
            this.prénom_sal = prénom_sal;
            this.matricule_sal = matricule_sal;
            this.date_embouche = date_embouche;
            this.situiation_fam = situiation_fam;
            this.numm_ss_sal = numm_ss_sal;
            this.num_ccp_rip = num_ccp_rip;

            this.mode_vérsement = mode_vérsement;

        }
        public bultin()
        {
            InitializeComponent();
        }

        private void bultin_Load(object sender, EventArgs e)
        {
            //net_a_payer


            ReportDataSource rds = new ReportDataSource("DataSet1", liste_rub);
            //ReportViewer1.LocalReport.DataSources.Clear();
            ReportParameter[] para = new ReportParameter[]
            {
            new ReportParameter("nom_ent",nom_ent),
            new ReportParameter("Activité_ent",activité_ent),
            new ReportParameter("Adresse_ent",adresse_ent),
            new ReportParameter("registre_comerce",registre_comerce),
            new ReportParameter("téléphone_ent",téléphone_ent),
            new ReportParameter("Email_ent",eamail_ent),
            new ReportParameter("mois_et_année",mois_année_bultin),
            new ReportParameter("prénom_sal",prénom_sal),
            new ReportParameter("Nom_sal",nom_sal),
            new ReportParameter("Matricule_sal",matricule_sal),
            new ReportParameter("situlation_fam_sal",situiation_fam),
            new ReportParameter("Numéro_ss_sal",numm_ss_sal),
            new ReportParameter("ccp_rip",num_ccp_rip),
            new ReportParameter("mode_virment_sal",mode_vérsement),
            new ReportParameter("net_a_payer",net_a_apyer),

           };
            
         
            this.reportViewer1.LocalReport.SetParameters(para);

            // ReportDataSource datasource = new ReportDataSource("Employees", dsEmployees.Tables[0]);
            reportViewer1.LocalReport.DataSources.Add(rds);
            //ruberique_bulltinBindingSource.DataSource = liste_rub;
            this.reportViewer1.RefreshReport();




            /* using (paieEntities12 dbe = new paieEntities12())
             {

                 ruberique_bulltinBindingSource.DataSource = liste_rub;
                 this.reportViewer1.RefreshReport();

             }*/
        }
    }
}
