using GameSale_CustomerManagement_Intro.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSale_CustomerManagement_Intro.Entities
{
    public class Games:IEntity
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public int GamePrice { get; set; }
        public int GameInStock { get; set; }
    }
}
