using FDMC.Data;
using FDMC.Data.Models;
using FDMC.Models;
using FDMC.Models.Breeds;
using FDMC.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FDMC.Controllers
{
    public class BreedsController : Controller
    {
        private readonly IBreedService breedService;
        private readonly AppFdmcDbContext context;


        public BreedsController(IBreedService breedService, AppFdmcDbContext context)
        {
            this.breedService = breedService;
            this.context = context;

        }
        public IActionResult Index()
        {
            return Redirect("/Breeds/All");
        }
        public async Task<IActionResult> All()
        {
            var breedsModel = await breedService.GetAllBreeds();

            return View(breedsModel);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateBreedFormViewModel breedModel)
        {
            await breedService.CreateBreed(breedModel);

            return Redirect("/Breeds/All");
        }
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            BreedViewModel breed = await breedService.GetBreed(id);

            if (breed == null)
            {
                return NotFound();
            }
            return View(breed);
        }
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BreedViewModel breed = await breedService.GetBreed(id);

            if (breed == null)
            {
                return NotFound();
            }
            return View(breed);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(BreedViewModel breedModel)
        {
            Breed breed = await context.Breeds.FirstOrDefaultAsync(b => b.Id == breedModel.Id);
            if (breed == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                breed.Name = breedModel.Name;
                context.Update(breed);
                context.SaveChangesAsync();
            }
            return Redirect($"/Breeds/Details/{breed.Id}");
        }
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            bool isBreedDeleted = await breedService.DeleteBreed(id);

            if (!isBreedDeleted)
            {
                return NotFound();
            }

            return Redirect("/Breeds/All");
        }
    }
}
