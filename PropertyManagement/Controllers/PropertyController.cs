using Microsoft.AspNetCore.Mvc;
using PropertyManagement.Data;

namespace PropertyManagement.Controllers
{
    public class PropertyController : Controller
    {
        private readonly ApplicationDbContext _db;
        public PropertyController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var List = _db.Properties.ToList();
            return View(List);
        }
    }
}
