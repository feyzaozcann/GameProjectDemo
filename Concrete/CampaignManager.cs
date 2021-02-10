using GameProjectDemo.Abstract;
using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class CampaignManager : ICampaigneService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign Added!");
         
            Console.WriteLine("Campaigne Number:" +campaign.CampaignNumber + "  " + "Discount Rate:" + campaign.DiscountRate);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine();
            Console.WriteLine("Campaign "+campaign.CampaignNumber + " is expired.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine();
            Console.WriteLine("Campaigne number "+campaign.CampaignNumber +" is updated!" + "  " + "Discount Rate:" + campaign.DiscountRate);
        }
    }
}
