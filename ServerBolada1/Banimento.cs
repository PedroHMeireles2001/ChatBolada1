using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ServerBolada1
{
    public class Banimento
    {
        public static List<Banimento> Banimentos = new List<Banimento>();
        public string Admin;
        public string ip;
        public string motivo;

        public Banimento(string admin, string ip)
        {
            this.Admin = admin;
            this.ip = ip;
            Banimentos.Add(this);
        }
        public Banimento(string admin, string ip,string motivo)
        {
            this.Admin = admin;
            this.ip = ip;
            this.motivo = motivo;
            Banimentos.Add(this);
        }

        public static Banimento isBanido(UsuarioServer usr)
        {
            foreach (Banimento ban in Banimentos)
            {
                if (ban.ip == usr.GetIPAddress())
                {
                    return ban;
                }
            }
            return null;
        }
    }
}
