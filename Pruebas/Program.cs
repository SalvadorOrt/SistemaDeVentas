using AccesoDatos;
using Datos;
using LogicaDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    public class Program
    {
        static void Main(string[] args)
        {
            ClienteNegocio datos = new ClienteNegocio();
            List<Cliente> lista = datos.ListarCliente();
           foreach (var item in lista)
            {
                Console.WriteLine(item.nombre+" "+item.cedula);
            }
           Console.ReadKey();
        }
    }
}
