using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatCommom
{
    public class Usuario
    {
        
        public string nick { get; set; }
        public string discriminator { get; set; }
        
        public Usuario(string nick, string discriminator)
        {
            this.nick = nick;
            this.discriminator = discriminator;
        }

        public string getNickWithDiscriminator()
        {
            return this.nick + "#" + this.discriminator;
        }
    }
}
