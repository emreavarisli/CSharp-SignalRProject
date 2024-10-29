using Microsoft.AspNetCore.Mvc;

namespace SignalRUI.ViewComponents.LayoutComponents
{
	public class _LayoutSidebarComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
