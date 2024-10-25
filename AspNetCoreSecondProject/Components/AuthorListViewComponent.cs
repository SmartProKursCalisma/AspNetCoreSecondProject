using AspNetCoreSecondProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreSecondProject.Components
{
    public class AuthorListViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Author> authors = new List<Author>
            {
                new(){Name = "Melih Ömer",Surname = "KAMAR",Nickname="kamar",BookCount=123},
                new(){Name = "Mustafa",Surname = "BAYÇÖL",Nickname="baycol",BookCount=12},
                new(){Name = "EfeCan",Surname = "CÖRÜT",Nickname="corut",BookCount=125},
                new(){Name = "Berkant",Surname = "YILMAZ",Nickname="yilmaz",BookCount=1234},
                new(){Name = "Eylem",Surname = "BAKCA",Nickname="Ariel Prenses",BookCount=55}
            };
            return View(authors);
        }
    }
}
