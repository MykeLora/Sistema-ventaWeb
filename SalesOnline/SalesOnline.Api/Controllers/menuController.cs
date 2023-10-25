
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SalesOnline.Infraestructure.Interfaces;


namespace SalesOnline.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MenuController : ControllerBase
    {
        private readonly IMenuRepository MenuRepository;
        
        public MenuController(IMenuRepository MenuRepository)
        {
            this.MenuRepository = MenuRepository;
           
        }


        [HttpGet("Getnombre")]
        public IActionResult Getnombre(int id)
        {
            var nombre = this.MenuRepository.GetEntity(id);
            return Ok(nombre);
        }

        [HttpGet("Geticono")]
        public IActionResult Geticono(int id)
        {
            var icono = this.MenuRepository.GetEntity(id);
            return Ok(icono);
        }
        [HttpGet("Geturl")]
        public IActionResult Geturl(int id)
        {
            var url = this.MenuRepository.GetEntity(id);
            return Ok(url);
        }

        [HttpGet("GetidMenu")]
        public IActionResult GetidMenu(int id)
        {
            var idMenu = this.MenuRepository.GetEntity(id);
            return Ok(idMenu);
        }
    }
}
