using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Viagenstka.Data;
using Viagenstka.Model;

namespace Viagenstka.Controllers{

    [ApiController]
    [Route("cliente/listaclientes")]

    public class ClienteController : ControllerBase {

        private readonly DataContext _dataContext; 

        public ClienteController(DataContext dataContext){
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetViagenstka(){
            return await _dataContext.Viagenstka.ToListAsync();
    }

        [HttpGet("{id}")]
         public async Task<ActionResult<Cliente>> GetClienteById(int id) {
            var cliente = await _dataContext.Viagenstka.FindAsync(id);
            if (cliente == null){
                return NotFound();
            }
            return Ok(cliente);
         }




    }
}