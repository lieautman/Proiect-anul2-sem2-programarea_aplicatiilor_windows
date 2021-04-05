﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//for file-binary formatter
using System.Runtime.Serialization.Formatters.Binary;

namespace AbonatiTelefonici
{
    public partial class FormClient : Form
    {
        string clientPath = Directory.GetCurrentDirectory() + "/ClientiDB.dat";
        string abonamentPath = Directory.GetCurrentDirectory() + "/AbonamenteDB.dat";
        string extraOptiunePath = Directory.GetCurrentDirectory() + "/ExtraoptiuneDB.dat";
        public FormClient()
        {
            InitializeComponent();


            if (File.Exists(clientPath))
            {
                //citit din fisier si setat text
                using (StreamReader readtext = new StreamReader(clientPath))
                {
                    string linie;
                    linie = readtext.ReadLine();
                    while (linie != null)
                    {
                        tbNrOrdine.Text = (Int32.Parse(linie.Substring(0, 1))+1).ToString();
                        linie = readtext.ReadLine();
                    }
                }
            }
            else
            {
                tbNrOrdine.Text = 1.ToString();
            }
        }

        private void btnSalvareClient_Click(object sender, EventArgs e)
        {
            if (tbCNP.Text == "" || tbNume.Text == "" || tbPrenume.Text == "" || cbNationalitate.Text == "")
                epNecompletat.SetError(btnSalvareClient, "Va rugam completati toate campurile!");
            else if (tbCNP.Text.Length != 13)
                epNecompletat.SetError(tbCNP, "Va rugam introduceti in CNP de 13 caractere (valid)!");
            else
            {
                try
                {
                    epNecompletat.Clear();
                    Client client = new Client();
                    client.NrOrdine = Convert.ToInt32(tbNrOrdine.Text);
                    client.CNP = tbCNP.Text;
                    client.nume = tbNume.Text;
                    client.prenume = tbPrenume.Text;
                    client.nationalitate = cbNationalitate.Text;
                    client.plata = cbPlata.Text;


                    //de scris in fisier
                    using (StreamWriter writetext = new StreamWriter(clientPath, true))
                    {
                        writetext.WriteLine(client.ToString());
                    }

                    MessageBox.Show("Clientul a fost salvat!");

                    //resetez nr de ordine #spagetti code
                    using (StreamReader readtext = new StreamReader(clientPath))
                    {
                        string linie;
                        linie = readtext.ReadLine();
                        while (linie != null)
                        {
                            tbNrOrdine.Text = (Int32.Parse(linie.Substring(0, 1)) + 1).ToString();
                            linie = readtext.ReadLine();
                        }
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDisplayBDClient_Click(object sender, EventArgs e)
        {
            if (File.Exists(clientPath))
            {
                BdClienti frm = new BdClienti();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Nu avem Bd clienti!");
            }
        }

        private void btnDisplayBDAbonament_Click(object sender, EventArgs e)
        {
            if (File.Exists(abonamentPath))
            {
                BdAbonament frm = new BdAbonament();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Nu avem Bd abonament!");
            }
        }

        private void btnDisplayBDExtraOptiune_Click(object sender, EventArgs e)
        {
            if (File.Exists(extraOptiunePath))
            {
                BdExtraOptiune frm = new BdExtraOptiune();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Nu avem Bd extra optiune!");
            }
        }
    }
}