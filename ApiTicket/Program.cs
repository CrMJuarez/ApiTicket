using ApiTicket.Funciones;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PostApi solicitud = new PostApi();
            //solicitud.getApi();
            solicitud.postApi();
            
            Console.ReadKey();
        }
    }
}
