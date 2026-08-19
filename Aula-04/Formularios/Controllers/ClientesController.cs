using Microsoft.AspNetCore.Mvc;

namespace MVC2026;

public class ClientesController : Controller
{
    public IActionResult Cadastrar()
    {
        return View();
    }
}
