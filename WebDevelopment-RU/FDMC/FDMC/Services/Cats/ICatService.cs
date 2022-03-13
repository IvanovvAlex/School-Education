using FDMC.Models;

namespace FDMC.Services
{
    public interface ICatService
    {
        Task<ICollection<CatViewModel>> GetAllCats();
        Task<bool> CreateCat(CreateCatViewModel catModel);
        Task<bool> DeleteCat(string id);
        Task<CatViewModel> GetCat(string id);
    }
}