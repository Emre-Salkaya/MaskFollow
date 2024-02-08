using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PharmacyManager : ISupplierService
    {
        public IApplicantService _applicantService;

        public PharmacyManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }


        public void GiveMask(Person person)
        {
            if (_applicantService.CheckPerson(person) == true)
            {
                Console.WriteLine(person.FirstName + "İçin maske verildi");
            }
        }
    }
}
