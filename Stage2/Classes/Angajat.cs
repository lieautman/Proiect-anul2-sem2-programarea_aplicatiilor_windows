﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonatiTelefonici
{
    public enum TipUser
    {
        Regular,
        Manager,
        Admin
    }
    public class Angajat:Persoana,ICloneable
    {
        public string username { get; set; }
        public TipUser tipUser { get; set; }

        TipUser stringToEnum(string s)
        {
            TipUser buffer = (TipUser)Enum.Parse(typeof(TipUser), s);
            return buffer;
        }

        public Angajat() : base()
        {
            username = "";
            tipUser = 0;
        }
        public Angajat(Persoana p)
        {
            this.nume = p.nume;
            this.prenume = p.prenume;
            this.email = p.email;
        }
        public Angajat(string nume, string prenume, string email, string username, string tipUser) : base(nume, prenume, email)
        {
            this.username = username;
            this.tipUser = stringToEnum(tipUser);
        }
        public override string ToString()
        {
            return this.username + " " + this.tipUser + " " + this.nume + " " + this.prenume + " " + this.email;
        }

        public new object Clone()
        {
            Angajat clona = new Angajat((Persoana)base.Clone());
            clona.username = this.username;
            clona.tipUser = this.tipUser;
            return clona;
        }
    }
}
