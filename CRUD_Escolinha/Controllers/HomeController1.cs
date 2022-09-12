using Microsoft.AspNetCore.Mvc;

namespace CRUD_Escolinha.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Cadastro_Herois()
        {
            return View();
        }
    }
}
