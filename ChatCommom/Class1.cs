using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChatCommom
{
    public class Class1
    {
        public static string separator = "|-|-|";
        public static bool isValidServer(string server)
        {
            string[] splits = server.Split(':');
            if (splits.Length == 2)
            {
                try
                {
                    Convert.ToInt32(splits[1]);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }
        public static IPAddress getIp(string ip)
        {
            try
            {
                return IPAddress.Parse(ip);
            }
            catch
            {
                return null;
            }
        }
        public static bool isValidNumber(string num)
        {
            try
            {
                Convert.ToInt32(num);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool ping(TcpClient client)
        {
            return true;
        }
        public static void sendmessage(TcpClient cliente, string msg)
        {
            StreamWriter sw = new StreamWriter(cliente.GetStream());
            sw.WriteLine(msg);
            sw.Flush();
        }

        //public static string[] getArgs(string[] msgs)
        //{
        //    string[] args = new string[msgs.Length - 2];
        //    for(int i = 2;i < msgs.Length; i++)
        //    {
        //        args[i] 
        //    }
        //    return args;
        //}
    }
}
