using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoggingAPI.Context;
using LoggingAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoggingAPI.Controllers
{
    [Route("v1/")]
    [ApiController]
    public class LoggingController : ControllerBase
    {
        private LoggingContext _context;

        public LoggingController(LoggingContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("AddLoggingItems")]
        public ActionResult<LoggingItems> AddLoggingItems(LoggingItems items)
        {
            if (items == null)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Logs.Add(items);
                _context.SaveChanges();
            }
            else
            {
                return BadRequest();
            }

            return items;
        }

        [HttpPost]
        [Route("GetLoggingItems")]
        public ActionResult<LoggingItems> GetLoggingItems()
        {
            var items = _context.Logs.FirstOrDefault();

            return items;
        }
    }
}
