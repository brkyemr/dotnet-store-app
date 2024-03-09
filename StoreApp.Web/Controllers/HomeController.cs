using Microsoft.AspNetCore.Mvc;
using StoreApp.Data.Abstract;
using StoreApp.Web.Models;

namespace StoreApp.Web.Controllers;

public class HomeController:Controller
{

    private IStoreRepository _storeRepository;

    public int pageSize = 3;
    public HomeController(IStoreRepository storeRepository)
    {
        _storeRepository = storeRepository;
    }

    //normalde Data projesinde olan entity i burada kullanabilmemiz için map'leme yaptık bu projenin içerisinde Product=>Product
    //localhost:5103/products/page/2
    public IActionResult Index(int page = 1)
    {
        var products = _storeRepository
        .Products
        .Skip((page - 1 ) * pageSize)
        .Select(p => new ProductViewModel
        {
            Id = p.Id,
            Name = p.Name,
            Description = p.Description,
            Price = p.Price
        }).Take(pageSize);


        return View(new ProductListViewModel {
            Products = products,
            PageInfo = new PageInfo{
                ItemsPerPage = pageSize,
                TotalItems = _storeRepository.Products.Count()
            }
        });
    }
}


