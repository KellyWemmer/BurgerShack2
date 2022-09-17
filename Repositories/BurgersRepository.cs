
//Repository is how you access your data
using System.Collections.Generic;
using BurgerShack2.db;
using BurgerShack2.Models;

namespace BurgerShack2.Repositories
{
    public class BurgersRepository
    {
        internal List<Burger> GetBurgers()
        {
            return Db.Burgers;
        }
    }
}