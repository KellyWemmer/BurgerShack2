using System.Collections.Generic;
using BurgerShack2.Models;
using BurgerShack2.Repositories;


namespace BurgerShack2.Services//Container
{
    public class BurgersService//default is internal. A public class will have access in the assembly it is part of and all other assemblies where it is referenced.
    {
        //states that it will have a repo
        private readonly BurgersRepository _burgerRepo; //Private readonly means you can't inadvertently change it from another part of that class after it is initialized. The readonly modifier ensures the field can only be given a value during its initialization or in its class constructor.
        

        public BurgersService(BurgersRepository burgerRepo)//the constructor here actually assigns a repo
        {
            _burgerRepo = burgerRepo;
        }

        internal List<Burger> GetBurgers()
        {
            List<Burger> burgers = _burgerRepo.GetBurgers();
            return burgers;
        }
        

    }
}