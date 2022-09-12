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
        public IActionResult Editar(int id)
        {
            var heroi = _heroisRepositorio.ListarPorId(id);
            return View(heroi);
        }
        public IActionResult Apagar(int id)
        {
            _heroisRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }
        
        [HttpPost]
        public IActionResult Criar(Cadastro_Herois herois)
        {
            _heroisRepositorio.Adicionar(herois);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Editar(Cadastro_Herois heroi)
        {
            _heroisRepositorio.Editar(heroi);
            return RedirectToAction("Index");
        }
        public IActionResult ApagarConfirmacao()
        {
            return View();
        }
    }
}
