using Microsoft.AspNetCore.Mvc;
using orientacao_objeto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace orientacao_objeto.Controllers
{
    public class PessoaController : Controller
    {
        public static List<Pessoa> lsPessoa = new List<Pessoa>();
        public IActionResult Index()
        {
            return View(lsPessoa);
        }
        public IActionResult cadastrar()
        {
            return View();
        }
        public IActionResult salvar(Pessoa item)
        {
            lsPessoa.Add(item);
            return RedirectToAction("Index");
        }
    }
}
