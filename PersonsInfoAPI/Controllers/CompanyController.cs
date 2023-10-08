using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonsInfoAPI.IBusinessLogic;
using PersonsInfoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsInfoAPI.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        ICompanyLogic companyLogic;

        public CompanyController(ICompanyLogic _companyLogic)
        {
            companyLogic = _companyLogic;
        }

        [Route("api/AddCompany")]
        [HttpPost]
        public bool AddCompany(Company company)
        {
            return companyLogic.AddCompany(company);
        }

        [Route("api/DeleteCompany/{id}")]
        [HttpDelete]
        public bool DeleteCompany(int id)
        {
            return companyLogic.DeleteCompany(id);
        }

        [Route("api/GetCompanies")]
        [HttpGet]
        public List<Company> GetCompanies()
        {
            return companyLogic.GetCompanies();
        }

        [Route("api/GetCompanyById/{id}")]
        [HttpGet]
        public Company GetCompanyById(int id)
        {
            return companyLogic.GetCompanyById(id);
        }

        [Route("api/UpdateCompany")]
        [HttpPut]
        public bool UpdateCompany(Company company)
        {
            return companyLogic.UpdateCompany(company);
        }
    }
}
