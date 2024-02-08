using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager :ISupplierService
    {
        private IApplicantService _applicantService; //ihtiyaç duyulan sınıfı new lemek yerine interfacesini yazıyoruz.

        public PttManager(IApplicantService applicantService) // ctor, new yapıldığı an ilk bu çalışır.
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Person person)
        {
            if (_applicantService.CheckPerson(person) == true)
            {
                Console.WriteLine(person.FirstName + " İçin maske verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + " İçin maske verilemedi !!!");
            }
        }
    }
}
