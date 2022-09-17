
using System.Collections.Generic;
using BurgerShack2.Models;

namespace BurgerShack2.db
{
    public static class Db 
    {
        public static List<Burger> Burgers { get; set;} = new List<Burger>(){
            new Burger("Canada Burger", "beef", "Cheddar", 2, true, 1),
            new Burger("Nebraska Burger", "chicken", "Provolone", 3, false, 2),
            new Burger("Vermont Burger", "Buffalo", "American", 1, true, 3)
        };
    }

}