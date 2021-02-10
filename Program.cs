using GameProjectDemo.Concrete;
using GameProjectDemo.Entity;
using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager1 = new GamerManager(new ValidationManager());
            Gamer gamer1 = new Gamer() {Id = 1, Name = "Demet", Surname = "Özkaya", BirthYear = 1992 };
            GamerManager gamerManager2 = new GamerManager(new ValidationManager());
            Gamer gamer2 = new Gamer() { Id = 2, Name = "Feyza", Surname = "Özcan", BirthYear = 2001 };

            Game game1 = new Game() {GameName="GTA5" , GameNumber = 1 , GamePrice=200 };
            Game game2 = new Game() { GameName = "Need For Speed", GameNumber = 2, GamePrice = 150 };
            Game game3 = new Game() { GameName = "FIFA", GameNumber = 3, GamePrice = 250 };
           
            Campaign campaign1 = new Campaign() { CampaignNumber = 14, CampaignValidationDate = "2021, 12 , 6", DiscountRate="%50" };
            Campaign campaign2 = new Campaign() { CampaignNumber = 16, CampaignValidationDate = "2021, 11 , 6" , DiscountRate ="%25"};

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            campaignManager.Delete(campaign1);
            campaignManager.Delete(campaign2);
            campaignManager.Update(campaign1);
            campaignManager.Update(campaign2);
            Console.WriteLine();

            PurchaseManager purchaseManager = new PurchaseManager();
            purchaseManager.DiscountPurchase(gamer2 , game2 , campaign1);
            purchaseManager.Purchase(gamer1, game3);

        }
    }
}
