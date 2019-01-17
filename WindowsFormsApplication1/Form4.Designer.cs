namespace WindowsFormsApplication1
{
    partial class Form4
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
            this.prénom = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.MaskedTextBox();
            this.Matrucule = new System.Windows.Forms.TextBox();
            this.numéro_sécurité_sociale = new System.Windows.Forms.TextBox();
            this.Lieu_naiss = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Date_naiss = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labell = new System.Windows.Forms.Label();
            this.wilaya_naiss = new System.Windows.Forms.TextBox();
            this.nationalité = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Féminin = new System.Windows.Forms.RadioButton();
            this.Masculin = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.nom_conjoine = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.prénom_pére = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Nom_mére = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Veuf = new System.Windows.Forms.RadioButton();
            this.Marié = new System.Windows.Forms.RadioButton();
            this.Célibataire = new System.Windows.Forms.RadioButton();
            this.Divorcé = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.travaille = new System.Windows.Forms.RadioButton();
            this.Au_foyer = new System.Windows.Forms.RadioButton();
            this.enfant_scolariser = new System.Windows.Forms.TextBox();
            this.personns_char = new System.Windows.Forms.TextBox();
            this.Prénom_mére = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.Numéro_tél = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Adresse = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // prénom
            // 
            this.prénom.Location = new System.Drawing.Point(297, 63);
            this.prénom.Name = "prénom";
            this.prénom.Size = new System.Drawing.Size(100, 20);
            this.prénom.TabIndex = 0;
            this.prénom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(118, 60);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(100, 20);
            this.Nom.TabIndex = 1;
            // 
            // Matrucule
            // 
            this.Matrucule.Location = new System.Drawing.Point(158, 90);
            this.Matrucule.Name = "Matrucule";
            this.Matrucule.Size = new System.Drawing.Size(67, 20);
            this.Matrucule.TabIndex = 2;
            // 
            // numéro_sécurité_sociale
            // 
            this.numéro_sécurité_sociale.Location = new System.Drawing.Point(208, 218);
            this.numéro_sécurité_sociale.Name = "numéro_sécurité_sociale";
            this.numéro_sécurité_sociale.Size = new System.Drawing.Size(118, 20);
            this.numéro_sécurité_sociale.TabIndex = 3;
            // 
            // Lieu_naiss
            // 
            this.Lieu_naiss.Location = new System.Drawing.Point(158, 161);
            this.Lieu_naiss.Name = "Lieu_naiss";
            this.Lieu_naiss.Size = new System.Drawing.Size(100, 20);
            this.Lieu_naiss.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Matruculation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "numéro sécurité sociale";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "date_naissance";
            // 
            // Date_naiss
            // 
            this.Date_naiss.CustomFormat = "dd/MM/yyyy";
            this.Date_naiss.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_naiss.Location = new System.Drawing.Point(168, 124);
            this.Date_naiss.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.Date_naiss.MinDate = new System.DateTime(1900, 12, 31, 0, 0, 0, 0);
            this.Date_naiss.Name = "Date_naiss";
            this.Date_naiss.Size = new System.Drawing.Size(90, 20);
            this.Date_naiss.TabIndex = 10;
            this.Date_naiss.Value = new System.DateTime(1900, 12, 31, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Lieu_naissacne";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 524);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Numéro téléphone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "nationalité";
            // 
            // labell
            // 
            this.labell.AutoSize = true;
            this.labell.Location = new System.Drawing.Point(268, 359);
            this.labell.Name = "labell";
            this.labell.Size = new System.Drawing.Size(63, 13);
            this.labell.TabIndex = 15;
            this.labell.Text = "wilaya naiss";
            // 
            // wilaya_naiss
            // 
            this.wilaya_naiss.Location = new System.Drawing.Point(358, 359);
            this.wilaya_naiss.Name = "wilaya_naiss";
            this.wilaya_naiss.Size = new System.Drawing.Size(100, 20);
            this.wilaya_naiss.TabIndex = 14;
            // 
            // nationalité
            // 
            this.nationalité.Location = new System.Drawing.Point(158, 356);
            this.nationalité.Name = "nationalité";
            this.nationalité.Size = new System.Drawing.Size(100, 20);
            this.nationalité.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Féminin);
            this.groupBox1.Controls.Add(this.Masculin);
            this.groupBox1.Location = new System.Drawing.Point(358, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 38);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexe";
            // 
            // Féminin
            // 
            this.Féminin.AutoSize = true;
            this.Féminin.Location = new System.Drawing.Point(124, 15);
            this.Féminin.Name = "Féminin";
            this.Féminin.Size = new System.Drawing.Size(61, 17);
            this.Féminin.TabIndex = 1;
            this.Féminin.TabStop = true;
            this.Féminin.Text = "Féminin";
            this.Féminin.UseVisualStyleBackColor = true;
            // 
            // Masculin
            // 
            this.Masculin.AutoSize = true;
            this.Masculin.Location = new System.Drawing.Point(51, 13);
            this.Masculin.Name = "Masculin";
            this.Masculin.Size = new System.Drawing.Size(67, 17);
            this.Masculin.TabIndex = 0;
            this.Masculin.TabStop = true;
            this.Masculin.Text = "Masculin";
            this.Masculin.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 417);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "prénom pére";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // nom_conjoine
            // 
            this.nom_conjoine.Location = new System.Drawing.Point(315, 281);
            this.nom_conjoine.Name = "nom_conjoine";
            this.nom_conjoine.Size = new System.Drawing.Size(158, 20);
            this.nom_conjoine.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(239, 472);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "dans l\'enfant et scolariser";
            // 
            // prénom_pére
            // 
            this.prénom_pére.Location = new System.Drawing.Point(153, 414);
            this.prénom_pére.Name = "prénom_pére";
            this.prénom_pére.Size = new System.Drawing.Size(65, 20);
            this.prénom_pére.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(239, 284);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "nom conjointe ";
            // 
            // Nom_mére
            // 
            this.Nom_mére.Location = new System.Drawing.Point(298, 417);
            this.Nom_mére.Name = "Nom_mére";
            this.Nom_mére.Size = new System.Drawing.Size(87, 20);
            this.Nom_mére.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Veuf);
            this.groupBox2.Controls.Add(this.Marié);
            this.groupBox2.Controls.Add(this.Célibataire);
            this.groupBox2.Controls.Add(this.Divorcé);
            this.groupBox2.Location = new System.Drawing.Point(66, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 73);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Situation familliale";
            // 
            // Veuf
            // 
            this.Veuf.AutoSize = true;
            this.Veuf.Location = new System.Drawing.Point(87, 19);
            this.Veuf.Name = "Veuf";
            this.Veuf.Size = new System.Drawing.Size(47, 17);
            this.Veuf.TabIndex = 32;
            this.Veuf.TabStop = true;
            this.Veuf.Text = "Veuf";
            this.Veuf.UseVisualStyleBackColor = true;
            // 
            // Marié
            // 
            this.Marié.AutoSize = true;
            this.Marié.Location = new System.Drawing.Point(6, 19);
            this.Marié.Name = "Marié";
            this.Marié.Size = new System.Drawing.Size(51, 17);
            this.Marié.TabIndex = 27;
            this.Marié.TabStop = true;
            this.Marié.Text = "Marié";
            this.Marié.UseVisualStyleBackColor = true;
            // 
            // Célibataire
            // 
            this.Célibataire.AutoSize = true;
            this.Célibataire.Location = new System.Drawing.Point(87, 42);
            this.Célibataire.Name = "Célibataire";
            this.Célibataire.Size = new System.Drawing.Size(74, 17);
            this.Célibataire.TabIndex = 29;
            this.Célibataire.TabStop = true;
            this.Célibataire.Text = "Célibataire";
            this.Célibataire.UseVisualStyleBackColor = true;
            // 
            // Divorcé
            // 
            this.Divorcé.AutoSize = true;
            this.Divorcé.Location = new System.Drawing.Point(6, 42);
            this.Divorcé.Name = "Divorcé";
            this.Divorcé.Size = new System.Drawing.Size(62, 17);
            this.Divorcé.TabIndex = 28;
            this.Divorcé.TabStop = true;
            this.Divorcé.Text = "Divorcé";
            this.Divorcé.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.travaille);
            this.groupBox3.Controls.Add(this.Au_foyer);
            this.groupBox3.Location = new System.Drawing.Point(490, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(119, 73);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "situation conjoine";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // travaille
            // 
            this.travaille.AutoSize = true;
            this.travaille.Location = new System.Drawing.Point(6, 47);
            this.travaille.Name = "travaille";
            this.travaille.Size = new System.Drawing.Size(61, 17);
            this.travaille.TabIndex = 31;
            this.travaille.TabStop = true;
            this.travaille.Text = "travaille";
            this.travaille.UseVisualStyleBackColor = true;
            // 
            // Au_foyer
            // 
            this.Au_foyer.AutoSize = true;
            this.Au_foyer.Location = new System.Drawing.Point(6, 19);
            this.Au_foyer.Name = "Au_foyer";
            this.Au_foyer.Size = new System.Drawing.Size(67, 17);
            this.Au_foyer.TabIndex = 30;
            this.Au_foyer.TabStop = true;
            this.Au_foyer.Text = "Au_foyer";
            this.Au_foyer.UseVisualStyleBackColor = true;
            // 
            // enfant_scolariser
            // 
            this.enfant_scolariser.Location = new System.Drawing.Point(397, 465);
            this.enfant_scolariser.Name = "enfant_scolariser";
            this.enfant_scolariser.Size = new System.Drawing.Size(39, 20);
            this.enfant_scolariser.TabIndex = 27;
            // 
            // personns_char
            // 
            this.personns_char.Location = new System.Drawing.Point(191, 469);
            this.personns_char.Name = "personns_char";
            this.personns_char.Size = new System.Drawing.Size(36, 20);
            this.personns_char.TabIndex = 28;
            // 
            // Prénom_mére
            // 
            this.Prénom_mére.Location = new System.Drawing.Point(496, 420);
            this.Prénom_mére.Name = "Prénom_mére";
            this.Prénom_mére.Size = new System.Drawing.Size(100, 20);
            this.Prénom_mére.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(62, 472);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "personns charge";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(394, 420);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Prénom mére";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(224, 417);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Nom mére";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(355, 528);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Email";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(463, 521);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 20);
            this.email.TabIndex = 34;
            // 
            // Numéro_tél
            // 
            this.Numéro_tél.Location = new System.Drawing.Point(191, 521);
            this.Numéro_tél.Name = "Numéro_tél";
            this.Numéro_tél.Size = new System.Drawing.Size(100, 20);
            this.Numéro_tél.TabIndex = 35;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(68, 559);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 13);
            this.label16.TabIndex = 36;
            this.label16.Text = "Adresse";
            // 
            // Adresse
            // 
            this.Adresse.Location = new System.Drawing.Point(159, 556);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(167, 20);
            this.Adresse.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::WindowsFormsApplication1.Properties.Resources._1492638320_Check;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(213, 615);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 39);
            this.button1.TabIndex = 38;
            this.button1.Text = "Suivant";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(309, 522);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 13);
            this.label17.TabIndex = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(440, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 169);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::WindowsFormsApplication1.Properties.Resources._1492638307_Remove;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(340, 615);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 39);
            this.button2.TabIndex = 42;
            this.button2.Text = "Annuler";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 679);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Adresse);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Numéro_tél);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Prénom_mére);
            this.Controls.Add(this.personns_char);
            this.Controls.Add(this.enfant_scolariser);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Nom_mére);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.prénom_pére);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nom_conjoine);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labell);
            this.Controls.Add(this.wilaya_naiss);
            this.Controls.Add(this.nationalité);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Date_naiss);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lieu_naiss);
            this.Controls.Add(this.numéro_sécurité_sociale);
            this.Controls.Add(this.Matrucule);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.prénom);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter salarié";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox prénom;
        private System.Windows.Forms.MaskedTextBox Nom;
        private System.Windows.Forms.TextBox Matrucule;
        private System.Windows.Forms.TextBox numéro_sécurité_sociale;
        private System.Windows.Forms.TextBox Lieu_naiss;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker Date_naiss;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labell;
        private System.Windows.Forms.TextBox wilaya_naiss;
        private System.Windows.Forms.TextBox nationalité;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Féminin;
        private System.Windows.Forms.RadioButton Masculin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nom_conjoine;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox prénom_pére;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Nom_mére;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton Veuf;
        private System.Windows.Forms.RadioButton Marié;
        private System.Windows.Forms.RadioButton Célibataire;
        private System.Windows.Forms.RadioButton Divorcé;
        private System.Windows.Forms.RadioButton travaille;
        private System.Windows.Forms.RadioButton Au_foyer;
        private System.Windows.Forms.TextBox enfant_scolariser;
        private System.Windows.Forms.TextBox personns_char;
        private System.Windows.Forms.TextBox Prénom_mére;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox Numéro_tél;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Adresse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
    }
}