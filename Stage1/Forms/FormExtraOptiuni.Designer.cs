
namespace AbonatiTelefonici
{
    partial class FormExtraOptiuni
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipExtraoptiune = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbExtraOptiuneNumar = new System.Windows.Forms.TextBox();
            this.labelExtraOptiune1 = new System.Windows.Forms.Label();
            this.btnSalvareClient = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNrOrdineExtraoptiune = new System.Windows.Forms.TextBox();
            this.epNecompletat = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbNrOrdineAbonament = new System.Windows.Forms.ComboBox();
            this.btnDisplayBDClient = new System.Windows.Forms.Button();
            this.btnDisplayBDAbonament = new System.Windows.Forms.Button();
            this.btnDisplayBDExtraOptiune = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.epNecompletat)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNrOrdineExtraoptiune
            // 
            this.tbNrOrdineExtraoptiune.Location = new System.Drawing.Point(240, 85);
            this.tbNrOrdineExtraoptiune.Name = "tbNrOrdineExtraoptiune";
            this.tbNrOrdineExtraoptiune.ReadOnly = true;
            this.tbNrOrdineExtraoptiune.Size = new System.Drawing.Size(138, 22);
            this.tbNrOrdineExtraoptiune.TabIndex = 0;
            // 
            // cbNrOrdineAbonament
            // 
            this.cbNrOrdineAbonament.FormattingEnabled = true;
            this.cbNrOrdineAbonament.Location = new System.Drawing.Point(240, 135);
            this.cbNrOrdineAbonament.Name = "cbNrOrdineAbonament";
            this.cbNrOrdineAbonament.Size = new System.Drawing.Size(138, 24);
            this.cbNrOrdineAbonament.TabIndex = 1;
            // 
            // cbTipExtraoptiune
            // 
            this.cbTipExtraoptiune.FormattingEnabled = true;
            this.cbTipExtraoptiune.Items.AddRange(new object[] {
            "Minute Convorbire",
            "Mesaje",
            "Gb Internet"});
            this.cbTipExtraoptiune.Location = new System.Drawing.Point(240, 180);
            this.cbTipExtraoptiune.Name = "cbTipExtraoptiune";
            this.cbTipExtraoptiune.Size = new System.Drawing.Size(138, 24);
            this.cbTipExtraoptiune.TabIndex = 2;
            this.cbTipExtraoptiune.SelectedIndexChanged += new System.EventHandler(this.cbTipExtraoptiune_SelectedIndexChanged);
            // 
            // tbExtraOptiuneNumar
            // 
            this.tbExtraOptiuneNumar.Location = new System.Drawing.Point(240, 224);
            this.tbExtraOptiuneNumar.Name = "tbExtraOptiuneNumar";
            this.tbExtraOptiuneNumar.Size = new System.Drawing.Size(138, 22);
            this.tbExtraOptiuneNumar.TabIndex = 3;
            // 
            // btnSalvareClient
            // 
            this.btnSalvareClient.Location = new System.Drawing.Point(147, 320);
            this.btnSalvareClient.Name = "btnSalvareClient";
            this.btnSalvareClient.Size = new System.Drawing.Size(100, 23);
            this.btnSalvareClient.TabIndex = 4;
            this.btnSalvareClient.Text = "Salveaza";
            this.btnSalvareClient.UseVisualStyleBackColor = true;
            this.btnSalvareClient.Click += new System.EventHandler(this.btnSalvareClient_Click);
            // 
            // btnDisplayBDClient
            // 
            this.btnDisplayBDClient.Location = new System.Drawing.Point(926, 46);
            this.btnDisplayBDClient.Name = "btnDisplayBDClient";
            this.btnDisplayBDClient.Size = new System.Drawing.Size(318, 30);
            this.btnDisplayBDClient.TabIndex = 5;
            this.btnDisplayBDClient.Text = "Display baza de date clienti";
            this.btnDisplayBDClient.UseVisualStyleBackColor = true;
            this.btnDisplayBDClient.Click += new System.EventHandler(this.btnDisplayBDClient_Click);
            // 
            // btnDisplayBDAbonament
            // 
            this.btnDisplayBDAbonament.Location = new System.Drawing.Point(926, 95);
            this.btnDisplayBDAbonament.Name = "btnDisplayBDAbonament";
            this.btnDisplayBDAbonament.Size = new System.Drawing.Size(318, 30);
            this.btnDisplayBDAbonament.TabIndex = 6;
            this.btnDisplayBDAbonament.Text = "Display baza de date abonamente";
            this.btnDisplayBDAbonament.UseVisualStyleBackColor = true;
            this.btnDisplayBDAbonament.Click += new System.EventHandler(this.btnDisplayBDAbonament_Click);
            // 
            // btnDisplayBDExtraOptiune
            // 
            this.btnDisplayBDExtraOptiune.Location = new System.Drawing.Point(926, 148);
            this.btnDisplayBDExtraOptiune.Name = "btnDisplayBDExtraOptiune";
            this.btnDisplayBDExtraOptiune.Size = new System.Drawing.Size(318, 30);
            this.btnDisplayBDExtraOptiune.TabIndex = 7;
            this.btnDisplayBDExtraOptiune.Text = "Display baza de date extra optiune";
            this.btnDisplayBDExtraOptiune.UseVisualStyleBackColor = true;
            this.btnDisplayBDExtraOptiune.Click += new System.EventHandler(this.btnDisplayBDExtraOptiune_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numar ordine Extraoptiune";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Numar ordine Abonament";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tipul de extra optiune";
            // 
            // labelExtraOptiune1
            // 
            this.labelExtraOptiune1.AutoSize = true;
            this.labelExtraOptiune1.Location = new System.Drawing.Point(57, 224);
            this.labelExtraOptiune1.Name = "labelExtraOptiune1";
            this.labelExtraOptiune1.Size = new System.Drawing.Size(50, 17);
            this.labelExtraOptiune1.TabIndex = 11;
            this.labelExtraOptiune1.Text = "Numar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Completati campurile urmatoare";
            // 
            // epNecompletat
            // 
            this.epNecompletat.ContainerControl = this;
            // 
            // FormExtraOptiuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 570);
            this.Controls.Add(this.btnDisplayBDExtraOptiune);
            this.Controls.Add(this.btnDisplayBDAbonament);
            this.Controls.Add(this.btnDisplayBDClient);
            this.Controls.Add(this.cbNrOrdineAbonament);
            this.Controls.Add(this.tbNrOrdineExtraoptiune);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalvareClient);
            this.Controls.Add(this.labelExtraOptiune1);
            this.Controls.Add(this.tbExtraOptiuneNumar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTipExtraoptiune);
            this.Controls.Add(this.label1);
            this.Name = "FormExtraOptiuni";
            this.Text = "FormExtraOptiuni";
            ((System.ComponentModel.ISupportInitialize)(this.epNecompletat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipExtraoptiune;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbExtraOptiuneNumar;
        private System.Windows.Forms.Label labelExtraOptiune1;
        private System.Windows.Forms.Button btnSalvareClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNrOrdineExtraoptiune;
        private System.Windows.Forms.ErrorProvider epNecompletat;
        private System.Windows.Forms.ComboBox cbNrOrdineAbonament;
        private System.Windows.Forms.Button btnDisplayBDClient;
        private System.Windows.Forms.Button btnDisplayBDAbonament;
        private System.Windows.Forms.Button btnDisplayBDExtraOptiune;
    }
}