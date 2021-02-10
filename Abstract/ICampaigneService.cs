using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Entity;

namespace GameProjectDemo.Abstract
{
    public interface ICampaigneService
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);

    }
}
