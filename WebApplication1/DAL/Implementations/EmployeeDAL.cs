using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL.Contracts;
using WebApplication1.Models;

namespace WebApplication1.DAL.Implementations
{
    public class EmployeeDAL : IEmployeeDAL
    {
        private readonly CompanyContext _context;


        public EmployeeDAL(CompanyContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            return _context.Employees.Find(id);
        }

        public bool Save(Employee department)
        {
            throw new NotImplementedException();
        }
    }
}
