using Microsoft.AspNetCore.Mvc;

namespace MVC2026;

public class CadastroController : Controller
{
    public IActionResult Aluno()
    {
        return View();
    }
}