using LibraryManage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using LibraryManage;

using System.Diagnostics;

namespace LibraryManage.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly LibraryRepository _repository;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            _repository = new LibraryRepository(connectionString);
        }

        public IActionResult Index()
        {
            var books = _repository.GetBooks();
            return View(books);
        }

       
        public IActionResult Members()
        {
            var members = _repository.GetMembers();
            return View(members);
        }

        public IActionResult Loans()
        {
            var loans = _repository.GetLoans();
            return View(loans);
        }

        // Implementing  actions for Create, Edit, Delete, are left
    }

}
