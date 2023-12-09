using Microsoft.AspNetCore.Mvc;
using SharedComponents.ViewComponents;

namespace SharedComponents
{
    public class Menu : ViewComponent
    {
        public IViewComponentResult Invoke(List<MenuItem> items)
        {
            return View("Menu", items);
        }
    }
}

