using GameProjectDemo.Abstract;
using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class PurchaseManager : IPurchaseService
    {
        public void DiscountPurchase(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(gamer.Name +" purchased " +game.GameName + " with " + campaign.DiscountRate + " discount." );
        }

        public void Purchase(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.Name + " purchased " + game.GameName+ ".");
        }

    }
}
