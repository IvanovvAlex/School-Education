using FDMC.Data;
using FDMC.Data.Models;
using FDMC.Models.Breeds;
using Microsoft.EntityFrameworkCore;

namespace FDMC.Services
{
    public class BreedService : IBreedService
    {
        private readonly AppFdmcDbContext context;

        public BreedService(AppFdmcDbContext context)
        {
            this.context = context;
        }
        public async Task CreateBreed(CreateBreedFormViewModel breedModel)
        {
            Breed newBreed = new Breed()
            {
                Name = breedModel.Name,
            };
            context.Add(newBreed);
            await context.SaveChangesAsync();
        }

        public async Task<bool> DeleteBreed(string id)
        {
            Breed breed = await context.Breeds
                          .FirstOrDefaultAsync(m => m.Id == id);

            if (breed != null)
            {
                context.Breeds.Remove(breed);
                await context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<ICollection<BreedViewModel>> GetAllBreeds()
        {
            ICollection<BreedViewModel> breeds = await context.Breeds.Select(x => new BreedViewModel
            {
                Id = x.Id,
                Name = x.Name
            }).ToListAsync();

            return breeds;
        }

        public async Task<BreedViewModel> GetBreed(string id)
        {
            Breed breed = await context.Breeds.FirstOrDefaultAsync(c => c.Id == id);
            BreedViewModel breedViewModel;
            if (breed != null)
            {
                breedViewModel = new BreedViewModel
                {
                    Id = breed.Id,
                    Name = breed.Name,
                };
                return breedViewModel;
            }
            return null;
        }
    }
}
