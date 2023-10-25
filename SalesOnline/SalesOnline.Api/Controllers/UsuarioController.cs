using Microsoft.AspNetCore.Mvc;
using SalesOnline.Api.Models.Module_Usuario;
using SalesOnline.Domain.Entities;
using SalesOnline.Infraestructure.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SalesOnline.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }

        [HttpGet("GetUsuariosByUsuarioid")]
        public IActionResult GetUsuariosByUsuarioid(int Usuarioid)
        {
            var Usuarios = this.usuarioRepository.GetUsuariosByidUsuario(Usuarioid);
            return Ok(Usuarios);
        }

        // GET: api/<UsuarioController>
        [HttpGet]
        public IActionResult GetUsuarios()
        {
            var usuario = this.usuarioRepository.GetEntities().Select(Usuario => new UsuarioGetAllModel()
            {
                Usuarioid = Usuario.idUsuario,
                ChanageDate = Usuario.fechaRegistro,
                IdUsuarioCreacion = Usuario.IdUsuarioCreacion,
                clave = Usuario.clave,
                nombreCompleto = Usuario.nombreCompleto,
                correo = Usuario.correo,
                idRol = Usuario.idRol                
            }).ToList();

            return Ok(usuario);
        }

        // GET api/<UsuarioController>/5
        [HttpGet("GetUsuario")]
        public IActionResult GetUsuario(int id)
        {
            var usuario = this.usuarioRepository.GetEntity(id);
            return Ok(usuario);
        }
        [HttpPost("SaveUsuario")]
        public IActionResult Post([FromBody] UsuarioAddModel usuarioAdd)
        {

            Usuario usuario = new Usuario()
            {
                fechaRegistro = usuarioAdd.fechaRegistro,
                IdUsuarioCreacion = usuarioAdd.ChangeUser,
                clave = usuarioAdd.clave,
                nombreCompleto = usuarioAdd.nombreCompleto,
                correo = usuarioAdd.correo,
                idRol = usuarioAdd.idRol
            };
            this.usuarioRepository.Save(usuario);

            return Ok();
        }


        // POST api/<UsuarioController>
        [HttpPost("UpdateUsuario")]
        public IActionResult Put([FromBody] UsuarioUpdateModel UsuarioUpdate)
        {
            Usuario usuario = new Usuario()
            {
                fechaRegistro = UsuarioUpdate.fechaRegistro,
                IdUsuarioCreacion = UsuarioUpdate.ChangeUser,
                clave = UsuarioUpdate.clave,
                nombreCompleto = UsuarioUpdate.nombreCompleto,
                correo = UsuarioUpdate.correo,
                idRol = UsuarioUpdate.idRol
            };

            this.usuarioRepository.Update(usuario);

            return Ok();
        }
    }

   

}
