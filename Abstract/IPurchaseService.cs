using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface IPurchaseService
    {
        void Purchase(Gamer gamer, Game game);
        void DiscountPurchase(Gamer gamer, Game game, Campaign campaign);
        
    }
}
