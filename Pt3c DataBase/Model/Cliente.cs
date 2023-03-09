using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cliente
    {
        int idClient;
        String nomclient;
        String cognom;
        String adreça;
        String poblacio;
        String telefon;
        String responsable;
        String emailContacte;

        public Cliente()
        {
        }

        public Cliente(string nomclient)
        {
            this.nomclient = nomclient;
        }

        public Cliente(string nomclient, string telefon)
        {
            this.nomclient = nomclient;
            this.telefon = telefon;
        }

        public Cliente(int idClient, string nomclient)
        {
            this.idClient = idClient;
            this.nomclient = nomclient;
        }


        public Cliente(string nomclient, string adreça, string poblacio, string telefon, string emailContacte)
        {
            this.Nomclient = nomclient;
            this.Adreça = adreça;
            this.Poblacio = poblacio;
            this.Telefon = telefon;
            this.EmailContacte = emailContacte;
        }


        public int IdClient { get => idClient; set => idClient = value; }
        public string Nomclient { get => nomclient; set => nomclient = value; }
        public string Cognom { get => cognom; set => cognom = value; }
        public string Adreça { get => adreça; set => adreça = value; }
        public string Poblacio { get => poblacio; set => poblacio = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Responsable { get => responsable; set => responsable = value; }
        public string EmailContacte { get => emailContacte; set => emailContacte = value; }

    }
}

