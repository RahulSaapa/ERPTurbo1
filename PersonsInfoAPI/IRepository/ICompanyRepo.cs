using PersonsInfoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoAPI.IRepository
{
    public interface ICompanyRepo
    {
        public List<Company> GetCompanies();
        public Company GetCompanyById(int id);
        public bool AddCompany(Company company);
        public bool UpdateCompany(Company company);
        public bool DeleteCompany(int id);

    }
}
