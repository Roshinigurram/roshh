using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.BLL.Contracts;

namespace WebApplication1.Controllers
{
    public class employeescontroller : Controller
    {
        
            private readonly IEmployeeBLL _bll;

        public employeescontroller(IEmployeeBLL bll)
            {
                _bll = bll ?? throw new ArgumentNullException(nameof(bll));
    }

    public IActionResult Index()
            {
                var employees = _bll.GetAll();
                return View(employees);
            }
        }
        
}
