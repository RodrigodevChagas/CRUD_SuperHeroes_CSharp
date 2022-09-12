using CRUD_Escolinha.Models;
using CRUD_Escolinha.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Escolinha.Controllers
{
    public class CadastroController : Controller
    {
        private readonly IHeroisRepositorio _heroisRepositorio;

        public CadastroController(IHeroisRepositorio heroisRepositorio)
        {
            _heroisRepositorio = heroisRepositorio;
        }

        public IActionResult Index()
        {
            var herois = _heroisRepositorio.BuscarTodos();
            return View(herois);
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult Apagar()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Criar(Cadastro_Herois herois)
        {
            _heroisRepositorio.Adicionar(herois);
            return RedirectToAction("Index");
        }
        //[HttpPut]
        //public IActionResult Editar()
        //{
        //    return View();
        //}
        //[HttpDelete]
        //public IActionResult Apagar()
        //{
        //    return View();
        //}
    }
}
