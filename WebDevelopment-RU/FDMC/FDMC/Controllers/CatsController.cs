using FDMC.Data;
using FDMC.Data.Models;
using FDMC.Models;
using FDMC.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FDMC.Controllers
{
    public class CatsController : Controller
    {
        private readonly ICatService catService;
        private readonly AppFdmcDbContext context;


        public CatsController(ICatService catService, AppFdmcDbContext context)
        {
            this.catService = catService;
            this.context = context;
        }
        public IActionResult Index()
        {
            return Redirect("/Cats/All");
        }
        public async Task<IActionResult> All()
        {
            var catsModel = await catService.GetAllCats();

            return View(catsModel);
        }
        public async Task<IActionResult> Create()
        {
            ViewData["BreedId"] = new SelectList(context.Breeds, "Id", "Name");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,Age,ImageUrl,BreedId")] CreateCatViewModel catModel)
        {
            bool isCreated = await catService.CreateCat(catModel);

            if(!isCreated)
            {
                return NotFound();
            }
            ViewData["BreedId"] = new SelectList(context.Breeds, "Id", "Name", catModel.BreedId);
            return Redirect("/Cats/All");
        }
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            CatViewModel cat = await catService.GetCat(id);

            if (cat == null)
            {
                return NotFound();
            }
            return View(cat);
        }
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewData["BreedId"] = new SelectList(context.Breeds, "Id", "Name");

            CatViewModel cat = await catService.GetCat(id);

            if (cat == null)
            {
                return NotFound();
            }
            return View(cat);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditFormCatViewModel catModel)
        {
            Breed breed = context.Breeds.FirstOrDefault(b => b.Id == catModel.BreedId);
            Cat cat = context.Cats.FirstOrDefault(c => c.Id == catModel.Id);
            if (breed == null || cat == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                cat.Name = catModel.Name;
                cat.Age = catModel.Age;
                cat.BreedId = catModel.BreedId;
                cat.ImageUrl = catModel.ImageUrl;
                context.Update(cat);
                context.SaveChanges();
            }
            ViewData["BreedId"] = new SelectList(context.Breeds, "Id", "Name", catModel.BreedId);
            return Redirect($"/Cats/Details/{cat.Id}");
        }
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            bool isCatDeleted = await catService.DeleteCat(id);
           
            if (!isCatDeleted)
            {
                return NotFound();
            }

            return Redirect("/Cats/All");
        }
    }
}
