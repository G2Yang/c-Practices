using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Comanda
    {
        int idComanda;
        int idClient;
        DateTime fecha;
        String formaPago;
        double descuento;
        Boolean enviado;

        public Comanda()
        {
        }

        public Comanda(int idComanda, int idClient, DateTime fecha, string formaPago, double descuento, bool enviado)
        {
            this.idComanda = idComanda;
            this.idClient = idClient;
            this.Fecha = fecha;
            this.formaPago = formaPago;
            this.descuento = descuento;
            this.enviado = enviado;
        }

        public int IdComanda { get => idComanda; set => idComanda = value; }
        public int IdClient { get => idClient; set => idClient = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string FormaPago { get => formaPago; set => formaPago = value; }
        public double Descuento { get => descuento; set => descuento = value; }
        public bool Enviado { get => enviado; set => enviado = value; }

    }
}
