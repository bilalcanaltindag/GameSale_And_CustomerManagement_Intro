using GameSale_CustomerManagement_Intro.Abstract;
using GameSale_CustomerManagement_Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSale_CustomerManagement_Intro.Concrete
{
    public class SaleManager
    {
        public void Purchase(Customer customer, Games games, Campaign campaign)
        {
            games.GamePrice -= campaign.CampaignPrice;

            Console.WriteLine("Tebrikler! " + customer.FirstName + " " + customer.LastName + " " + 
                campaign.CampaignName + " Kampanyasını Kullanarak " + games.GameName + " Oyunu İçin " + campaign.CampaignName 
                + " KAZANDINIZ! \n" + " Ve Ürünü " + games.GamePrice + " TL" + " 'Ye Satın Aldınız");

            campaign.CampaignInStock -= 1;
            games.GameInStock -= 1;

            Console.WriteLine("Kalan Ürün Adedi : " + games.GameInStock + " Kalan Kampanya Adedi : " + campaign.CampaignInStock); 
        }
    }
}
