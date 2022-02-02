using lojavirtual.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lojavirtual.Controllers
{
    public class ProdutoController : Controller
    {
        public ActionResult Visualizar()
        {
           Produto produto = GetProduto();

            return View(produto);
            //return new ContentResult() { Content = " <h3>Produto -> Visualizar</h3>", ContentType = "text/html"} ;
        }

        private Produto GetProduto()
        {
            return new Produto()
            {
                Id = 1,
                Nome = "Xbox x",
                Descricao = "Jogos em 4K",
                Valor = 3500.00M

            };
        }
    }
}
