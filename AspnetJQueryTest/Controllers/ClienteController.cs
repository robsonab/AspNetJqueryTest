using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspnetJQueryTest.Models;

namespace AspnetJQueryTest.Controllers
{
    public class ClienteController : Controller
    {
        private static List<Cliente> clientes;

        public static List<Cliente> Clientes
        {
            get
            {
                if (clientes == null)
                    IniciarClientes();
                return Context.Clientes;
            }
            set { Context.Clientes = value; }
        }

        private static void IniciarClientes()
        {
            clientes = new List<Cliente>();
            clientes.Add(new Cliente() { Codigo = 1, Nome = "Cliente 001", Telefone = "3322-1144" });
            clientes.Add(new Cliente() { Codigo = 2, Nome = "Cliente 002", Telefone = "1234-5678" });
            clientes.Add(new Cliente() { Codigo = 3, Nome = "Cliente 003", Telefone = "9988-7766" });
        }

        public ActionResult List()
        {
            return PartialView(Context.Clientes);
        }
    }
}