using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSRecuperarUsuarios.Models;

namespace WSRecuperarUsuarios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly DB_UserContext _db;

        public UsuarioController(DB_UserContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Get()
        {
            using (_db)
            {
                var lst = _db.Usuarios.ToList();
                return Ok(lst);
            }
            
        }
    }
}
