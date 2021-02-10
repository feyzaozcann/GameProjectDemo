using GameProjectDemo.Abstract;
using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager()
        {
        }

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Registered.");
            }
            else
            {
                Console.WriteLine("Registration failed.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Registration Deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Registration Updated");
        }
    }


}
