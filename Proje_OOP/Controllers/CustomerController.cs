using Microsoft.AspNetCore.Mvc;
using Proje_OOP.Entity;
using Proje_OOP.ProjeContext;

namespace Proje_OOP.Controllers
{
    public class CustomerController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var values = context.Customers.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            if(customer.Name.Length>=6 && customer.City != "" && customer.City.Length >= 3)
            {
                context.Add(customer);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.message = "Hatalı kullanım";
                return View();
            }
            
        }
        public IActionResult DeleteCustomer(int id) {
            var value = context.Customers.Where(x => x.Id == id).FirstOrDefault();
            context.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult UpdateCustomer(int id)
        {
            var value = context.Customers.Where(x=>x.Id == id).FirstOrDefault();
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCustomer(Customer customer)
        {
            var value = context.Customers.Where(x=>x.Id==customer.Id).FirstOrDefault();
            value.Name = customer.Name;
            value.City = customer.City;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
 