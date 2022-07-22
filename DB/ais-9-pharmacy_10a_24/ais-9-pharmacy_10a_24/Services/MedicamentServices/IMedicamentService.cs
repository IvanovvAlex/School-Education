using ais_9_pharmacy_10a_24.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ais_9_pharmacy_10a_24.Services.MedicamentServices
{
    public interface IMedicamentService
    {
        public ICollection<Medicament> GetAll();
        public ICollection<Medicament> GetTheNewest();
        public ICollection<Medicament> GetTheMostExpensiveWithExpiredDate();
        public decimal GetTotalAmountOfMoney();
        public ICollection<Medicament> SearchByName(string name);
        public ICollection<Medicament> SearchByDate(DateTime date);
        public ICollection<Medicament> Sort();

        public bool Create(string name, decimal price, int quantity, DateTime expiryDate, string type);
        public bool Edit(string name, decimal price, int quantity, DateTime expiryDate, string type);
        public bool Delete(string name);
    }
}
