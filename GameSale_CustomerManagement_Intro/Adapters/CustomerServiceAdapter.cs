using GameSale_CustomerManagement_Intro.Abstract;
using GameSale_CustomerManagement_Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSale_CustomerManagement_Intro.Adapters
{
    public class CustomerServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            if ((customer.NationalityId != null && customer.NationalityId.Length == 11) && (customer.FirstName != null) && (customer.LastName != null) && (customer.BirthDay.Year != null))
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
