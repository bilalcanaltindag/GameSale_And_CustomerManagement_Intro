using GameSale_CustomerManagement_Intro.Abstract;
using GameSale_CustomerManagement_Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSale_CustomerManagement_Intro.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerCheckService _customerCheckService;

        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }    

        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri Silindi : " + customer.FirstName + " " + customer.LastName);
        }

        public void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                Console.WriteLine("Yeni Müşteri Eklendi : " + customer.FirstName + " " + customer.LastName);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Müşteri Güncellendi : " + customer.FirstName + " " + customer.LastName);
        }

        public bool CheckIfRealPerson(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}

