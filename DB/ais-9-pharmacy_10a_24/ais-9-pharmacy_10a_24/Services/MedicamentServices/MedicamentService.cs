using ais_9_pharmacy_10a_24.Data;
using ais_9_pharmacy_10a_24.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ais_9_pharmacy_10a_24.Services.MedicamentServices
{
    public class MedicamentService : IMedicamentService
    {
        private AppDbContext context;
        public MedicamentService(AppDbContext context)
        {
            this.context = context;
        }

        public bool Create(string name, decimal price, int quantity, DateTime expiryDate, string type)
        {
            try
            {
                Medicament newMedicament = new Medicament();
                newMedicament.Name = name;
                newMedicament.Price = price;
                newMedicament.Quantity = quantity;
                newMedicament.ExpiryDate = expiryDate;
                newMedicament.Type = type;

                context.Medicaments.Add(newMedicament);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(string name)
        {
            try
            {
                Medicament medicament = context.Medicaments.FirstOrDefault(x => x.Name == name);
                if (medicament == null)
                {
                    return false;
                }
                context.Medicaments.Remove(medicament);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Edit(string name, decimal price, int quantity, DateTime expiryDate, string type)
        {
            try
            {
                Medicament medicament = context.Medicaments.FirstOrDefault(x => x.Name == name);
                if(medicament == null)
                {
                    return false;
                }
                medicament.Name = name;
                medicament.Price = price;
                medicament.Quantity = quantity;
                medicament.ExpiryDate = expiryDate;
                medicament.Type = type;

                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public ICollection<Medicament> GetAll()
        {
            return context.Medicaments.ToList();
        }

        public ICollection<Medicament> GetTheNewest()
        {
            Medicament oldest = context.Medicaments.OrderByDescending(p => p.ExpiryDate).First();

            return new List<Medicament> { oldest };
        }

        public ICollection<Medicament> SearchByDate(DateTime date)
        {
            return context.Medicaments.Where(m => m.ExpiryDate < date).ToList();
        }

        public ICollection<Medicament> SearchByName(string name)
        {
            return context.Medicaments.Where(m => m.Name == name).ToList();
        }
        public ICollection<Medicament> Sort()
        {
            return context.Medicaments.OrderBy(x => x.Price).ToList();
        }

        public ICollection<Medicament> GetTheMostExpensiveWithExpiredDate()
        {
            Medicament medicament =  context.Medicaments.Where(x => x.ExpiryDate < DateTime.Now.Date).OrderByDescending(x => x.Price).First();

            return new List<Medicament> { medicament };

        }

        public decimal GetTotalAmountOfMoney()
        {
            List<Medicament> medicamentList = context.Medicaments.ToList();

            decimal totalAmount = 0m;

            foreach (var item in medicamentList)
            {
                totalAmount += (item.Price * item.Quantity);
            }

            return totalAmount;
        }
    }
}
