using Microsoft.AspNetCore.Mvc;
using UniversalAPI.PersonalExpenseTracker.Model;
using UniversalAPI.PersonalExpenseTracker.BL;
using System.Net;

namespace UniversalAPI.PersonalExpenseTracker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonalExpenseTrackerController : Controller
    {
        public IExpenseDetailsHandler _expenseDetailsHandler;
        public PersonalExpenseTrackerController(IExpenseDetailsHandler expenseDetailsHandler)
        {
            _expenseDetailsHandler = expenseDetailsHandler;
        }

        [Route("Backup")]
        [HttpPost]
        public ExpenseDetails BackupExpenseDetails(ExpenseDetails expenseDetail)
        {
            _expenseDetailsHandler.AddExpenseDetail(expenseDetail);
            return null;
        }

        [Route("Health")]
        [HttpGet]
        public IActionResult Health()
        {
            return Ok();
        }
    }
}
