using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreSecondProject.Components.Layout
{
    public class LayoutHeaderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int bookCount)
        {

            return View(bookCount);
        }
    }
}
