using Grandion_Fast_Food.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Grandion_Fast_Food.Components
{
    public class CategoriaMenu : ViewComponent
    {
        private readonly ICategoriarepository _categoriaRepository;

        public CategoriaMenu(ICategoriarepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categorias = _categoriaRepository.Categorias.OrderBy(c => c.CategoriaNome);
            return View(categorias);

        }
    }
}