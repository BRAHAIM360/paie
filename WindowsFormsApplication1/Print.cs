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
    public partial class Print : Form
    {
        public List<ruberique_bulltin> liste_rub = new List<ruberique_bulltin>();
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
        string num_ss_sal;
        string num_ccp_rip;

        string mode_vérsement;
        public string Net_a_pyer;

        public Print(string nom_ent, string activité_ent, string adresse_ent, string registre_comerce, string téléphone_ent, string eamail_ent, string mois_année_bultin, string nom_sal, string prénom_sal, string matricule_sal, string date_embouche, string situiation_fam, string numm_ss_sal, string num_ccp_rip, string mode_vérsement)
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
            this.num_ss_sal = numm_ss_sal;
            this.num_ccp_rip = num_ccp_rip;
            

            this.mode_vérsement = mode_vérsement;

        }

        private void Print_Load(object sender, EventArgs e)
        {
            using (paieEntities12 dbe = new paieEntities12())
            {

                ruberique_bulltinBindingSource.DataSource = dbe.rubriques.ToList();
                this.reportViewer1.RefreshReport();

            }

            //Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            //{
               
            //        new Microsoft.Reporting.WinForms.ReportParameter("nom_ent",nom_ent),
            //new Microsoft.Reporting.WinForms.ReportParameter("Activité_ent",activité_ent),
            //new Microsoft.Reporting.WinForms.ReportParameter("Adresse_ent",adresse_ent),
            //new Microsoft.Reporting.WinForms.ReportParameter("registre_comerce_ent",registre_comerce),
            //new Microsoft.Reporting.WinForms.ReportParameter("téléphone_ent",téléphone_ent),
            //new Microsoft.Reporting.WinForms.ReportParameter("Email_ent",eamail_ent),
            //new Microsoft.Reporting.WinForms.ReportParameter("mois_et_année_bultin",mois_année_bultin),
            //new Microsoft.Reporting.WinForms.ReportParameter("prénom_sal",prénom_sal),
            //new Microsoft.Reporting.WinForms.ReportParameter("Nom_sal",nom_sal),
            //new Microsoft.Reporting.WinForms.ReportParameter("date_embouche",date_embouche), 
            //new Microsoft.Reporting.WinForms.ReportParameter("Matricule",matricule_sal),
            //new Microsoft.Reporting.WinForms.ReportParameter("situlation_fam_sal",situiation_fam),

            //new Microsoft.Reporting.WinForms.ReportParameter("ccp_rip",num_ccp_rip),
            //new Microsoft.Reporting.WinForms.ReportParameter("mode_virment_sal",mode_vérsement),
            //new Microsoft.Reporting.WinForms.ReportParameter("Net_a_payer",Net_a_pyer),
            //new Microsoft.Reporting.WinForms.ReportParameter("Numéro_ss_sal",num_ss_sal),

            //};
            //ruberique_bulltinBindingSource.DataSource = liste_rub;

          // this.reportViewer1.LocalReport.SetParameters(para);
            //using (paieEntities dbe = new paieEntities())
            //{


            //    this.reportViewer1.RefreshReport();

            //}
            this.reportViewer1.RefreshReport();

          //  this.reportViewer1.RefreshReport();
        }
    }
}
