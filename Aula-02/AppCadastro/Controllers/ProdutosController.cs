using Microsoft.AspNetCore.Mvc;

namespace MVC2026;

public class ProdutosController : Controller
{
    private List<Produtos> _listaProdutos = new List<Produtos>();
    public ProdutosController()
    {
        _listaProdutos.Add(new Produtos { Id = Guid.NewGuid(), Nome = "Chave de Fenda", Quantidade = 65 });
        _listaProdutos.Add(new Produtos { Id = Guid.NewGuid(), Nome = "Alicate", Quantidade = 99 });
        _listaProdutos.Add(new Produtos { Id = Guid.NewGuid(), Nome = "Martelo", Quantidade = 37 });
        _listaProdutos.Add(new Produtos { Id = Guid.NewGuid(), Nome = "Parafuso", Quantidade = 56 });
        _listaProdutos.Add(new Produtos { Id = Guid.NewGuid(), Nome = "Fita Isolante", Quantidade = 82 });
    }
    public IActionResult Index()
    {
        var Produtos = _listaProdutos;
        return View(Produtos);
    }
}
