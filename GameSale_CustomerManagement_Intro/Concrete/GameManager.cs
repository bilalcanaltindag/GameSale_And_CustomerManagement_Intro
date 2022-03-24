using GameSale_CustomerManagement_Intro.Abstract;
using GameSale_CustomerManagement_Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSale_CustomerManagement_Intro.Concrete
{
    public class GameManager : IGameService
    {
        public void Delete(Games games)
        {
            Console.WriteLine("Oyun Silindi : " + games.GameName);
        }

        public void Save(Games games)
        {
            Console.WriteLine("Oyun Eklendi : " + games.GameName);
        }

        public void Update(Games games)
        {
            Console.WriteLine("Oyun Güncellendi : " + games.GameName);
        }
    }
}
