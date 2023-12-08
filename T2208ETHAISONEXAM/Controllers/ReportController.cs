using Microsoft.AspNetCore.Mvc;
using T2208ETHAISONEXAM.Data;
using T2208ETHAISONEXAM.Models;

namespace T2208ETHAISONEXAM.Controllers
{
    public class ReportController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReportController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Report> reports = new List<Report>();
            var departments = _context.Department.ToList();
            foreach (var item in departments)
            {
                Report report = new Report();
                var employee = _context.Employee.Where(e => e.DepartmentId == item.Id).ToList();
                report.department = item;
                report.employees = employee;
                reports.Add(report);
            }

            return View(reports);
        }
    }
}
