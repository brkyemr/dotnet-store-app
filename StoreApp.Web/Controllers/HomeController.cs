using Microsoft.AspNetCore.Mvc;
using StoreApp.Data.Abstract;
using StoreApp.Web.Models;

namespace StoreApp.Web.Controllers;

public class HomeController:Controller
{

    private IStoreRepository _storeRepository;

    public HomeController(IStoreRepository storeRepository)
    {
        _storeRepository = storeRepository;
    }

    //normalde Data projesinde olan entity i burada kullanabilmemiz için map'leme yaptık bu projenin içerisinde Product=>Product
    public IActionResult Index()
    {
        var products = _storeRepository.Products.Select(p => new ProductViewModel
        {
            Id = p.Id,
            Name = p.Name,
            Description = p.Description,
            Price = p.Price
        }).ToList();


        return View(new ProductListViewModel {
            Products = products
        });
    }
}


