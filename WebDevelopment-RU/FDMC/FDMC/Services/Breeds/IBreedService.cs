using FDMC.Models.Breeds;

namespace FDMC.Services
{
    public interface IBreedService
    {
        Task<ICollection<BreedViewModel>> GetAllBreeds();
        Task CreateBreed(CreateBreedFormViewModel breedModel);
        Task<bool> DeleteBreed(string id);
        Task<BreedViewModel> GetBreed(string id);
    }
}