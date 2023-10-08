using PersonsInfoAPI.IBusinessLogic;
using PersonsInfoAPI.IRepository;
using PersonsInfoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoAPI.BusinessLogic
{
    public class CompanyLogic : ICompanyLogic
    {
        ICompanyRepo companyRepo;

        public CompanyLogic(ICompanyRepo _companyRepo)
        {
            companyRepo = _companyRepo;
        }
        public bool AddCompany(Company company)
        {
            return companyRepo.AddCompany(company);
        }

        public bool DeleteCompany(int id)
        {
            return companyRepo.DeleteCompany(id);
        }

        public List<Company> GetCompanies()
        {
            return companyRepo.GetCompanies();
        }

        public Company GetCompanyById(int id)
        {
            return companyRepo.GetCompanyById(id);
        }

        public bool UpdateCompany(Company company)
        {
            return companyRepo.UpdateCompany(company);
        }
    }
}
