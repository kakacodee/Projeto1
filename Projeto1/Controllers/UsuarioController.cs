using Microsoft.AspNetCore.Mvc;
using Projeto1.Repositorio;

namespace Projeto1.Controllers
{
    public class UsuarioController : Controller
    {
        //Declarando uma variável privada somente para leitura do tipo do UsuarioRepositorio chamada _usuarioRepositorio
        private readonly UsuarioRepositorio _usuarioRepositorio;
        /*Definindo o construtor parar a classe UsuarioController que vai receber uma
         instância de UsuarioRepositorio */
        public UsuarioController(UsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
            
        }
        public IActionResult Login()
        {   

            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string senha)
        {
            return View();
        }
        public IActionResult Contato()
        {
            return View();
        }
     
    }
}
