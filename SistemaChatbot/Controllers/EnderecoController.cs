using Microsoft.AspNetCore.Mvc;
using SistemaChatbot.Models;

namespace SistemaChatbot.Controllers
{
    public class EnderecoController : Controller
    {
        // GET: Exibe o formulário de busca
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // POST: Recebe os dados da View via Model Binding e redireciona
        [HttpPost]
        public IActionResult Salvar(EnderecoModel model)
        {
            // Aqui os dados do ViaCEP + Número digitado já estão mapeados no objeto 'model'
            // Redirecionamos para a tela de Sucesso enviando os dados informados
            return View("Resultado", model);
        }
    }
}