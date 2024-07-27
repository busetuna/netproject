using Basics.ModelExpressionProvider;
using Microsoft.AspNetCore.Mvc;
namespace netproject.Controllers

{
    public class EmployeeController : Controller
    {
        public IActionResult Index1()
        {
            string message = $"Hello {DateTime.Now.ToString()}";
            return View("Index1" , message);
        }

        public ViewResult Index2()
        {
            var names = new String[]
            {
                "Ahmet",
                "Mehmet",
                "Can"
            };
            return View(names);
        }

        public IActionResult Index3()
        {
            var list = new List<Employee>()
            {
                new Employee() { Id = 1, FirstName = "Buse" , LastName = "Tuna" , Age = 22},
                new Employee() { Id = 2, FirstName = "Esra" , LastName = "Tuna" , Age = 32}
            };
            return View("Index3"  , list);
        }
    }
}