using AccesoDatos;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public class ClienteNegocio
    {
        public List<Cliente> ListarCliente()
        {
            ClienteDatos datos = new ClienteDatos();
            List<Cliente> lista = datos.Listar();
            return lista;
        }
        public Cliente ListarClientexID(int id)
        {
            ClienteDatos datos = new ClienteDatos();
            Cliente cli = datos.Listar().Where(c => c.id == id).SingleOrDefault();
            return cli;
        }

    }
}
