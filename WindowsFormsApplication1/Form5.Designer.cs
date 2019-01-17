namespace WindowsFormsApplication1
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.CCP_RIP = new System.Windows.Forms.TextBox();
            this.Banque = new System.Windows.Forms.ComboBox();
            this.mode_paiement = new System.Windows.Forms.ComboBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.Taux_Joure = new System.Windows.Forms.TextBox();
            this.Taux_heure = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.salair_ba = new System.Windows.Forms.TextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.mode_calcul = new System.Windows.Forms.ComboBox();
            this.mode_de_versement = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.fin_cont = new System.Windows.Forms.TextBox();
            this.fin_conteee = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.Apprenti = new System.Windows.Forms.RadioButton();
            this.CDD = new System.Windows.Forms.RadioButton();
            this.CTA = new System.Windows.Forms.RadioButton();
            this.stagiare = new System.Windows.Forms.RadioButton();
            this.CDI = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.groupBox13.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.linkLabel1);
            this.groupBox13.Controls.Add(this.label25);
            this.groupBox13.Controls.Add(this.label24);
            this.groupBox13.Controls.Add(this.label23);
            this.groupBox13.Controls.Add(this.CCP_RIP);
            this.groupBox13.Controls.Add(this.Banque);
            this.groupBox13.Controls.Add(this.mode_paiement);
            this.groupBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox13.Location = new System.Drawing.Point(69, 306);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(292, 128);
            this.groupBox13.TabIndex = 12;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Mode de paiment et RIB";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(207, 65);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(79, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ajouter banque";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(7, 99);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(78, 13);
            this.label25.TabIndex = 8;
            this.label25.Text = "CCP/ RIB n°";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(5, 65);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(50, 13);
            this.label24.TabIndex = 7;
            this.label24.Text = "Banque";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(6, 32);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(95, 13);
            this.label23.TabIndex = 6;
            this.label23.Text = "Mode paimment";
            // 
            // CCP_RIP
            // 
            this.CCP_RIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CCP_RIP.Enabled = false;
            this.CCP_RIP.Location = new System.Drawing.Point(105, 94);
            this.CCP_RIP.Name = "CCP_RIP";
            this.CCP_RIP.Size = new System.Drawing.Size(98, 22);
            this.CCP_RIP.TabIndex = 1;
            this.CCP_RIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Banque
            // 
            this.Banque.Enabled = false;
            this.Banque.FormattingEnabled = true;
            this.Banque.Location = new System.Drawing.Point(105, 60);
            this.Banque.Name = "Banque";
            this.Banque.Size = new System.Drawing.Size(98, 24);
            this.Banque.TabIndex = 1;
            // 
            // mode_paiement
            // 
            this.mode_paiement.Enabled = false;
            this.mode_paiement.FormattingEnabled = true;
            this.mode_paiement.Location = new System.Drawing.Point(105, 24);
            this.mode_paiement.Name = "mode_paiement";
            this.mode_paiement.Size = new System.Drawing.Size(98, 24);
            this.mode_paiement.TabIndex = 0;
            this.mode_paiement.SelectedIndexChanged += new System.EventHandler(this.mode_paiement_SelectedIndexChanged);
            this.mode_paiement.TextUpdate += new System.EventHandler(this.mode_paiement_TextUpdate);
            this.mode_paiement.SelectedValueChanged += new System.EventHandler(this.mode_paiement_SelectedValueChanged);
            this.mode_paiement.TextChanged += new System.EventHandler(this.mode_paiement_TextChanged);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.Taux_Joure);
            this.groupBox10.Controls.Add(this.Taux_heure);
            this.groupBox10.Controls.Add(this.label3);
            this.groupBox10.Controls.Add(this.label1);
            this.groupBox10.Controls.Add(this.label2);
            this.groupBox10.Controls.Add(this.salair_ba);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(378, 180);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(227, 237);
            this.groupBox10.TabIndex = 9;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "salaire ";
            // 
            // Taux_Joure
            // 
            this.Taux_Joure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Taux_Joure.Location = new System.Drawing.Point(107, 158);
            this.Taux_Joure.Name = "Taux_Joure";
            this.Taux_Joure.Size = new System.Drawing.Size(100, 22);
            this.Taux_Joure.TabIndex = 17;
            this.Taux_Joure.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Taux_heure
            // 
            this.Taux_heure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Taux_heure.Location = new System.Drawing.Point(107, 101);
            this.Taux_heure.Name = "Taux_heure";
            this.Taux_heure.Size = new System.Drawing.Size(100, 22);
            this.Taux_heure.TabIndex = 16;
            this.Taux_heure.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Taux Joure";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Taux heure";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Salair  de base";
            // 
            // salair_ba
            // 
            this.salair_ba.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.salair_ba.Location = new System.Drawing.Point(107, 41);
            this.salair_ba.Name = "salair_ba";
            this.salair_ba.Size = new System.Drawing.Size(100, 22);
            this.salair_ba.TabIndex = 0;
            this.salair_ba.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.mode_calcul);
            this.groupBox11.Controls.Add(this.mode_de_versement);
            this.groupBox11.Controls.Add(this.label20);
            this.groupBox11.Controls.Add(this.label19);
            this.groupBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.Location = new System.Drawing.Point(69, 180);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(292, 100);
            this.groupBox11.TabIndex = 10;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "mode";
            // 
            // mode_calcul
            // 
            this.mode_calcul.FormattingEnabled = true;
            this.mode_calcul.Location = new System.Drawing.Point(149, 33);
            this.mode_calcul.Name = "mode_calcul";
            this.mode_calcul.Size = new System.Drawing.Size(123, 24);
            this.mode_calcul.TabIndex = 5;
            // 
            // mode_de_versement
            // 
            this.mode_de_versement.FormattingEnabled = true;
            this.mode_de_versement.Location = new System.Drawing.Point(149, 70);
            this.mode_de_versement.Name = "mode_de_versement";
            this.mode_de_versement.Size = new System.Drawing.Size(123, 24);
            this.mode_de_versement.TabIndex = 3;
            this.mode_de_versement.SelectedValueChanged += new System.EventHandler(this.mode_de_versement_SelectedValueChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(10, 73);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(122, 13);
            this.label20.TabIndex = 4;
            this.label20.Text = "Mode de vérsement ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(10, 33);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 13);
            this.label19.TabIndex = 3;
            this.label19.Text = "Mode de calcul";
            // 
            // fin_cont
            // 
            this.fin_cont.Location = new System.Drawing.Point(451, 109);
            this.fin_cont.Name = "fin_cont";
            this.fin_cont.Size = new System.Drawing.Size(53, 20);
            this.fin_cont.TabIndex = 5;
            // 
            // fin_conteee
            // 
            this.fin_conteee.AutoSize = true;
            this.fin_conteee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fin_conteee.Location = new System.Drawing.Point(303, 109);
            this.fin_conteee.Name = "fin_conteee";
            this.fin_conteee.Size = new System.Drawing.Size(136, 13);
            this.fin_conteee.TabIndex = 3;
            this.fin_conteee.Text = "Durée contrat par mois";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.Apprenti);
            this.groupBox8.Controls.Add(this.CDD);
            this.groupBox8.Controls.Add(this.CTA);
            this.groupBox8.Controls.Add(this.stagiare);
            this.groupBox8.Controls.Add(this.CDI);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(67, 69);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(181, 79);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Satut";
            // 
            // Apprenti
            // 
            this.Apprenti.AutoSize = true;
            this.Apprenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apprenti.Location = new System.Drawing.Point(58, 52);
            this.Apprenti.Name = "Apprenti";
            this.Apprenti.Size = new System.Drawing.Size(72, 17);
            this.Apprenti.TabIndex = 4;
            this.Apprenti.TabStop = true;
            this.Apprenti.Text = "Apprenti";
            this.Apprenti.UseVisualStyleBackColor = true;
            // 
            // CDD
            // 
            this.CDD.AutoSize = true;
            this.CDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDD.Location = new System.Drawing.Point(11, 53);
            this.CDD.Name = "CDD";
            this.CDD.Size = new System.Drawing.Size(51, 17);
            this.CDD.TabIndex = 3;
            this.CDD.TabStop = true;
            this.CDD.Text = "CDD";
            this.CDD.UseVisualStyleBackColor = true;
            // 
            // CTA
            // 
            this.CTA.AutoSize = true;
            this.CTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTA.Location = new System.Drawing.Point(128, 19);
            this.CTA.Name = "CTA";
            this.CTA.Size = new System.Drawing.Size(49, 17);
            this.CTA.TabIndex = 2;
            this.CTA.TabStop = true;
            this.CTA.Text = "CTA";
            this.CTA.UseVisualStyleBackColor = true;
            // 
            // stagiare
            // 
            this.stagiare.AutoSize = true;
            this.stagiare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stagiare.Location = new System.Drawing.Point(60, 19);
            this.stagiare.Name = "stagiare";
            this.stagiare.Size = new System.Drawing.Size(70, 17);
            this.stagiare.TabIndex = 1;
            this.stagiare.TabStop = true;
            this.stagiare.Text = "stagiare";
            this.stagiare.UseVisualStyleBackColor = true;
            // 
            // CDI
            // 
            this.CDI.AutoSize = true;
            this.CDI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDI.Location = new System.Drawing.Point(11, 19);
            this.CDI.Name = "CDI";
            this.CDI.Size = new System.Drawing.Size(46, 17);
            this.CDI.TabIndex = 0;
            this.CDI.TabStop = true;
            this.CDI.Text = "CDI";
            this.CDI.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::WindowsFormsApplication1.Properties.Resources.left_arrow;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(279, 453);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 44);
            this.button3.TabIndex = 15;
            this.button3.Text = "Retour";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::WindowsFormsApplication1.Properties.Resources._1492642551_Remove;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(387, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 44);
            this.button2.TabIndex = 14;
            this.button2.Text = "Annuler";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::WindowsFormsApplication1.Properties.Resources._1492638320_Check;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(174, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 44);
            this.button1.TabIndex = 13;
            this.button1.Text = "OK";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 522);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.fin_cont);
            this.Controls.Add(this.fin_conteee);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ridiger la contrat";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        public System.Windows.Forms.TextBox CCP_RIP;
        private System.Windows.Forms.ComboBox Banque;
        private System.Windows.Forms.ComboBox mode_paiement;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox salair_ba;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.ComboBox mode_calcul;
        private System.Windows.Forms.ComboBox mode_de_versement;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox fin_cont;
        private System.Windows.Forms.Label fin_conteee;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RadioButton Apprenti;
        private System.Windows.Forms.RadioButton CDD;
        private System.Windows.Forms.RadioButton CTA;
        private System.Windows.Forms.RadioButton stagiare;
        private System.Windows.Forms.RadioButton CDI;
        public System.Windows.Forms.TextBox Taux_Joure;
        public System.Windows.Forms.TextBox Taux_heure;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}