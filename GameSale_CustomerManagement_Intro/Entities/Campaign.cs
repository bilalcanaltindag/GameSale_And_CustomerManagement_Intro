using GameSale_CustomerManagement_Intro.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSale_CustomerManagement_Intro.Entities
{
    public class Campaign:IEntity
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public int CampaignPrice { get; set; }
        public int CampaignInStock { get; set; }
    }
}
