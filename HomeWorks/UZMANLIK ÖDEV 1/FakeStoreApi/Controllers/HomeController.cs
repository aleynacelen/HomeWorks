using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Json;
using FakeStoreApi.Models;
using FakeStoreApiMVC.Models;


namespace FakeStoreApiMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly HttpClient _httpClient;

      
        public HomeController(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://fakestoreapi.com/");
        }

        public async Task<IActionResult> Index()
        {
            var products = await _httpClient.GetFromJsonAsync<List<Product>>("products");
            return View(products);
        }

        public async Task<IActionResult> Details(int id)
        {
            var product = await _httpClient.GetFromJsonAsync<Product>($"products/{id}");
            return View(product);
        }

        public async Task<IActionResult> Categories()
        {
            var categories = await _httpClient.GetFromJsonAsync<List<string>>("products/categories");
            return View(categories);
        }

        public async Task<IActionResult> ProductsByCategory(string category)
        {
            var products = await _httpClient.GetFromJsonAsync<List<Product>>($"products/category/{category}");
            return View("Index", products);
        }

        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(Product newProduct)
        {
            var response = await _httpClient.PostAsJsonAsync("products", newProduct);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}

