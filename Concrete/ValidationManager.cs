using GameProjectDemo.Abstract;
using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class ValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id == 1 && gamer.Name == "Demet" && gamer.Surname=="Özkaya" && gamer.BirthYear==1992)
            {
                return true;
            }
            else if (gamer.Id == 2 && gamer.Name == "Feyza" && gamer.Surname == "Özcan" && gamer.BirthYear == 2001)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
