

using AspNetCoreSecondProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreSecondProject.Components
{
    public class AuthorInfoViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            Author author = new Author
            {
                Name = "Eylem",
                BookCount = 50,
                Nickname = "Ariel Prenses",
                Surname = "BAKCA"
            };
            return View(author);
        }
    }
}
