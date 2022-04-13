using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiProyecto.Entities;
using MiProyecto.Infrastructure;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiProyecto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoItemsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ToDoItemsController(ApplicationDbContext context)
        {
            _context = context;
        }


        /// <summary>
        /// Gets all the TodoItems
        /// </summary>
        /// <returns>
        /// A collection of <see cref="ToDoItem"/> available
        /// </returns>
        /// <response code="200">Found successfully.</response>
        /// <response code="401">Your user account does not contain the authorization required to access this API end-point</response>
        /// <response code="403">Your user account does not have permission to access this resource</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<ToDoItem>))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized, Type = null)]
        [ProducesResponseType(StatusCodes.Status403Forbidden, Type = null)]
        public async Task<ActionResult> GetAll()
        {
            var result = await _context.ToDoItems.ToListAsync();
            return new OkObjectResult(result);
        }


       

    }
}
