using Microsoft.AspNetCore.Mvc;

namespace SignalRUI.ViewComponents.LayoutComponents
{
    public class _LayoutScriptComponentsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
