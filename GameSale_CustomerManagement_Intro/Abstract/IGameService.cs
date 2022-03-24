using GameSale_CustomerManagement_Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSale_CustomerManagement_Intro.Abstract
{
    public interface IGameService
    {
        void Save(Games games);
        void Update(Games games);
        void Delete(Games games);
    }
}
