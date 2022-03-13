using FDMC.Data;
using FDMC.Data.Models;
using FDMC.Models;
using Microsoft.EntityFrameworkCore;

namespace FDMC.Services
{
    public class CatService : ICatService
    {
        private readonly AppFdmcDbContext context;

        public CatService(AppFdmcDbContext context)
        {
            this.context = context;
        }

        public async Task<bool> CreateCat(CreateCatViewModel catModel)
        {
            Breed breed = await context.Breeds.FirstOrDefaultAsync(b => b.Id == catModel.BreedId);
            if (breed == null)
            {
                return false;
            }
            Cat newCat = new Cat()
            {
                Name = catModel.Name,
                Age = catModel.Age,
                BreedId = catModel.BreedId,
                Breed = breed,
                ImageUrl = catModel.ImageUrl
            };

            context.Add(newCat);
            await context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteCat(string id)
        {
            Cat cat = await context.Cats
               .Include(c => c.Breed)
               .FirstOrDefaultAsync(m => m.Id == id);

            if (cat != null)
            {
                context.Cats.Remove(cat);
                await context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<ICollection<CatViewModel>> GetAllCats()
        {

            ICollection<CatViewModel> listOfCats = await context.Cats.Select(x => new CatViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Age = x.Age,
                BreedId = x.BreedId,
                Breed = x.Breed,
                ImageUrl = x.ImageUrl
            }).ToListAsync();

            return listOfCats;
        }

        public async Task<CatViewModel> GetCat(string id)
        {
            Cat cat = await context.Cats.Include(c => c.Breed).FirstOrDefaultAsync(c => c.Id == id);
            CatViewModel catViewModel;
            if (cat != null)
            {
                catViewModel = new CatViewModel
                {
                    Id = cat.Id,
                    Name = cat.Name,
                    Age = cat.Age,
                    BreedId = cat.BreedId,
                    Breed = cat.Breed,
                    ImageUrl = cat.ImageUrl
                };
                return catViewModel;
            }
            return null;
        }
    }
}
