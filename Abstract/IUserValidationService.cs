using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface IUserValidationService
    {
        bool Validate(Gamer gamer);
        
    }
}
