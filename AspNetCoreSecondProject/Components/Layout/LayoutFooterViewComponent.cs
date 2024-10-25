using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreSecondProject.Components.Layout
{
    public class LayoutFooterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
