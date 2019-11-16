using BikeShop.Data.Models;
using BikeShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShop.Mocks
{
    public class MockCategory : IBikesCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { Name = "Шосейники", Description = "Легкі велосипеди для рівної дороги"},
                    new Category { Name = "Гірські", Description = "Міцні велосипеди для бездоріжжя"}
                }; 
            }
        }
    }
}
