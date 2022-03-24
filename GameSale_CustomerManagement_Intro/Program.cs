using GameSale_CustomerManagement_Intro.Adapters;
using GameSale_CustomerManagement_Intro.Concrete;
using GameSale_CustomerManagement_Intro.Entities;
using System;

namespace GameSale_CustomerManagement_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer 
            { CustomerId = 1, 
                FirstName = "Bilal", 
                LastName = "Altındağ", 
                BirthDay = new DateTime(1999, 11, 23), 
                NationalityId = "22222222222" 
            };
            Customer customer2 = new Customer
            {
                CustomerId = 2,
                FirstName = "Efe",
                LastName = "Altındağ",
                BirthDay = new DateTime(2004, 06, 19),
                NationalityId = "55555555555"
            };

            Games games1 = new Games { GameId = 1, GameName = "Valorant", GamePrice = 100, GameInStock = 10 };
            Games games2 = new Games { GameId = 2, GameName = "Fifa", GamePrice = 250, GameInStock = 30 };

            Campaign campaign1 = new Campaign { CampaignId = 1, CampaignName = "30 TL İndirim", CampaignPrice = 30, CampaignInStock = 15 };
            Campaign campaign2 = new Campaign { CampaignId = 2, CampaignName = "10 TL İndirim", CampaignPrice = 10, CampaignInStock = 35 };


            CustomerManager customerManager1 = new CustomerManager(new CustomerServiceAdapter());
            customerManager1.Save(customer1);

            CustomerManager customerManager2 = new CustomerManager(new CustomerServiceAdapter());
            customerManager2.Save(customer2);

            Console.WriteLine("\n");

            GameManager gameManager1 = new GameManager();
            gameManager1.Save(games1);

            GameManager gameManager2 = new GameManager();
            gameManager2.Save(games2);

            Console.WriteLine("\n");

            CampaignManager campaignManager1 = new CampaignManager();
            campaignManager1.Save(campaign1);

            CampaignManager campaignManager2 = new CampaignManager();
            campaignManager2.Save(campaign2);

            Console.WriteLine("\n");

            SaleManager sale1 = new SaleManager();
            sale1.Purchase(customer1, games2, campaign2);

            Console.WriteLine("\n");

            SaleManager sale2 = new SaleManager();
            sale2.Purchase(customer2, games1, campaign1);

            Console.WriteLine("\n");

            SaleManager sale3 = new SaleManager();
            sale3.Purchase(customer2, games2, campaign1);

            Console.WriteLine("\n");

        }
    }
}
