using Grandion_Fast_Food.Repositores;
using Microsoft.AspNetCore.Mvc;

namespace Grandion_Fast_Food.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {
         

            var lanches = _lancheRepository.Lanches;
            return View(lanches);
        }   
    }
}
