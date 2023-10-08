using PersonsInfoAPI.IRepository;
using PersonsInfoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoAPI.Repository
{
    public class CompanyRepo : ICompanyRepo
    {
        PersonsInfoContext personsInfoContext = new PersonsInfoContext();

        public List<Company> GetCompanies()
        {
            return personsInfoContext.Companies.ToList();
        }

        public Company GetCompanyById(int id)
        {
            var data = personsInfoContext.Companies.Where(s => s.Id == id).FirstOrDefault();
            return data;
        }

        public bool AddCompany(Company company)
        {
            personsInfoContext.Companies.Add(company);
            personsInfoContext.SaveChanges();
            return true;
        }

        public bool UpdateCompany(Company company)
        {
            personsInfoContext.Companies.Update(company);
            personsInfoContext.SaveChanges();
            return true;
        }

        public bool DeleteCompany(int id)
        {
            var data = personsInfoContext.Companies.Where(s => s.Id == id).FirstOrDefault();
            personsInfoContext.Companies.Remove(data);
            personsInfoContext.SaveChanges();
            return true;
        }
    }
}
