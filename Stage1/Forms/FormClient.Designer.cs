
namespace AbonatiTelefonici
{
    partial class FormClient
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
            this.components = new System.ComponentModel.Container();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.tbCNP = new System.Windows.Forms.TextBox();
            this.labelCNP = new System.Windows.Forms.Label();
            this.labelNume = new System.Windows.Forms.Label();
            this.labelPrenume = new System.Windows.Forms.Label();
            this.labelNationalitate = new System.Windows.Forms.Label();
            this.btnSalvareClient = new System.Windows.Forms.Button();
            this.labelNrOrdine = new System.Windows.Forms.Label();
            this.tbNrOrdine = new System.Windows.Forms.TextBox();
            this.epNecompletat = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbNationalitate = new System.Windows.Forms.ComboBox();
            this.labelTitlu = new System.Windows.Forms.Label();
            this.btnDisplayBDClient = new System.Windows.Forms.Button();
            this.cbPlata = new System.Windows.Forms.ComboBox();
            this.labelPlata = new System.Windows.Forms.Label();
            this.btnDisplayBDAbonament = new System.Windows.Forms.Button();
            this.btnDisplayBDExtraOptiune = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.epNecompletat)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(194, 185);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(100, 22);
            this.tbNume.TabIndex = 2;
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(194, 229);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(100, 22);
            this.tbPrenume.TabIndex = 3;
            // 
            // tbCNP
            // 
            this.tbCNP.Location = new System.Drawing.Point(194, 145);
            this.tbCNP.Name = "tbCNP";
            this.tbCNP.Size = new System.Drawing.Size(100, 22);
            this.tbCNP.TabIndex = 1;
            // 
            // labelCNP
            // 
            this.labelCNP.AutoSize = true;
            this.labelCNP.Location = new System.Drawing.Point(34, 148);
            this.labelCNP.Name = "labelCNP";
            this.labelCNP.Size = new System.Drawing.Size(36, 17);
            this.labelCNP.TabIndex = 11;
            this.labelCNP.Text = "CNP";
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Location = new System.Drawing.Point(34, 188);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(45, 17);
            this.labelNume.TabIndex = 12;
            this.labelNume.Text = "Nume";
            // 
            // labelPrenume
            // 
            this.labelPrenume.AutoSize = true;
            this.labelPrenume.Location = new System.Drawing.Point(34, 234);
            this.labelPrenume.Name = "labelPrenume";
            this.labelPrenume.Size = new System.Drawing.Size(65, 17);
            this.labelPrenume.TabIndex = 13;
            this.labelPrenume.Text = "Prenume";
            // 
            // labelNationalitate
            // 
            this.labelNationalitate.AutoSize = true;
            this.labelNationalitate.Location = new System.Drawing.Point(34, 277);
            this.labelNationalitate.Name = "labelNationalitate";
            this.labelNationalitate.Size = new System.Drawing.Size(87, 17);
            this.labelNationalitate.TabIndex = 14;
            this.labelNationalitate.Text = "Nationalitate";
            // 
            // btnSalvareClient
            // 
            this.btnSalvareClient.Location = new System.Drawing.Point(101, 372);
            this.btnSalvareClient.Name = "btnSalvareClient";
            this.btnSalvareClient.Size = new System.Drawing.Size(100, 23);
            this.btnSalvareClient.TabIndex = 6;
            this.btnSalvareClient.Text = "Salveaza";
            this.btnSalvareClient.UseVisualStyleBackColor = true;
            this.btnSalvareClient.Click += new System.EventHandler(this.btnSalvareClient_Click);
            // 
            // labelNrOrdine
            // 
            this.labelNrOrdine.AutoSize = true;
            this.labelNrOrdine.Location = new System.Drawing.Point(34, 108);
            this.labelNrOrdine.Name = "labelNrOrdine";
            this.labelNrOrdine.Size = new System.Drawing.Size(74, 17);
            this.labelNrOrdine.TabIndex = 10;
            this.labelNrOrdine.Text = "Nr. Ordine";
            // 
            // tbNrOrdine
            // 
            this.tbNrOrdine.Location = new System.Drawing.Point(194, 105);
            this.tbNrOrdine.Name = "tbNrOrdine";
            this.tbNrOrdine.ReadOnly = true;
            this.tbNrOrdine.Size = new System.Drawing.Size(100, 22);
            this.tbNrOrdine.TabIndex = 0;
            // 
            // epNecompletat
            // 
            this.epNecompletat.ContainerControl = this;
            // 
            // cbNationalitate
            // 
            this.cbNationalitate.FormattingEnabled = true;
            this.cbNationalitate.Items.AddRange(new object[] {
            "Bulgara",
            "Moldoveana",
            "Romana",
            "Serba",
            "Ucrainiana",
            "Ungara"});
            this.cbNationalitate.Location = new System.Drawing.Point(194, 268);
            this.cbNationalitate.Name = "cbNationalitate";
            this.cbNationalitate.Size = new System.Drawing.Size(100, 24);
            this.cbNationalitate.Sorted = true;
            this.cbNationalitate.TabIndex = 4;
            // 
            // labelTitlu
            // 
            this.labelTitlu.AutoSize = true;
            this.labelTitlu.Location = new System.Drawing.Point(64, 59);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(208, 17);
            this.labelTitlu.TabIndex = 9;
            this.labelTitlu.Text = "Completati campurile urmatoare";
            // 
            // btnDisplayBDClient
            // 
            this.btnDisplayBDClient.Location = new System.Drawing.Point(926, 46);
            this.btnDisplayBDClient.Name = "btnDisplayBDClient";
            this.btnDisplayBDClient.Size = new System.Drawing.Size(318, 30);
            this.btnDisplayBDClient.TabIndex = 7;
            this.btnDisplayBDClient.Text = "Display baza de date clienti";
            this.btnDisplayBDClient.UseVisualStyleBackColor = true;
            this.btnDisplayBDClient.Click += new System.EventHandler(this.btnDisplayBDClient_Click);
            // 
            // cbPlata
            // 
            this.cbPlata.FormattingEnabled = true;
            this.cbPlata.Items.AddRange(new object[] {
            "Numerar",
            "Card",
            "Ambele"});
            this.cbPlata.Location = new System.Drawing.Point(194, 317);
            this.cbPlata.Name = "cbPlata";
            this.cbPlata.Size = new System.Drawing.Size(100, 24);
            this.cbPlata.TabIndex = 5;
            // 
            // labelPlata
            // 
            this.labelPlata.AutoSize = true;
            this.labelPlata.Location = new System.Drawing.Point(37, 323);
            this.labelPlata.Name = "labelPlata";
            this.labelPlata.Size = new System.Drawing.Size(110, 17);
            this.labelPlata.TabIndex = 14;
            this.labelPlata.Text = "Metoda de plata";
            // 
            // btnDisplayBDAbonament
            // 
            this.btnDisplayBDAbonament.Location = new System.Drawing.Point(926, 95);
            this.btnDisplayBDAbonament.Name = "btnDisplayBDAbonament";
            this.btnDisplayBDAbonament.Size = new System.Drawing.Size(318, 30);
            this.btnDisplayBDAbonament.TabIndex = 15;
            this.btnDisplayBDAbonament.Text = "Display baza de date abonamente";
            this.btnDisplayBDAbonament.UseVisualStyleBackColor = true;
            this.btnDisplayBDAbonament.Click += new System.EventHandler(this.btnDisplayBDAbonament_Click);
            // 
            // btnDisplayBDExtraOptiune
            // 
            this.btnDisplayBDExtraOptiune.Location = new System.Drawing.Point(926, 148);
            this.btnDisplayBDExtraOptiune.Name = "btnDisplayBDExtraOptiune";
            this.btnDisplayBDExtraOptiune.Size = new System.Drawing.Size(318, 30);
            this.btnDisplayBDExtraOptiune.TabIndex = 16;
            this.btnDisplayBDExtraOptiune.Text = "Display baza de date extra optiune";
            this.btnDisplayBDExtraOptiune.UseVisualStyleBackColor = true;
            this.btnDisplayBDExtraOptiune.Click += new System.EventHandler(this.btnDisplayBDExtraOptiune_Click);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 557);
            this.Controls.Add(this.btnDisplayBDExtraOptiune);
            this.Controls.Add(this.btnDisplayBDAbonament);
            this.Controls.Add(this.labelPlata);
            this.Controls.Add(this.cbPlata);
            this.Controls.Add(this.btnDisplayBDClient);
            this.Controls.Add(this.labelTitlu);
            this.Controls.Add(this.cbNationalitate);
            this.Controls.Add(this.tbNrOrdine);
            this.Controls.Add(this.labelNrOrdine);
            this.Controls.Add(this.btnSalvareClient);
            this.Controls.Add(this.labelNationalitate);
            this.Controls.Add(this.labelPrenume);
            this.Controls.Add(this.labelNume);
            this.Controls.Add(this.labelCNP);
            this.Controls.Add(this.tbCNP);
            this.Controls.Add(this.tbPrenume);
            this.Controls.Add(this.tbNume);
            this.Name = "FormClient";
            this.Text = "Formular Client";
            ((System.ComponentModel.ISupportInitialize)(this.epNecompletat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.TextBox tbCNP;
        private System.Windows.Forms.Label labelCNP;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelPrenume;
        private System.Windows.Forms.Label labelNationalitate;
        private System.Windows.Forms.Button btnSalvareClient;
        private System.Windows.Forms.Label labelNrOrdine;
        private System.Windows.Forms.TextBox tbNrOrdine;
        private System.Windows.Forms.ErrorProvider epNecompletat;
        private System.Windows.Forms.ComboBox cbNationalitate;
        private System.Windows.Forms.Label labelTitlu;
        private System.Windows.Forms.Button btnDisplayBDClient;
        private System.Windows.Forms.Label labelPlata;
        private System.Windows.Forms.ComboBox cbPlata;
        private System.Windows.Forms.Button btnDisplayBDAbonament;
        private System.Windows.Forms.Button btnDisplayBDExtraOptiune;
    }
}

