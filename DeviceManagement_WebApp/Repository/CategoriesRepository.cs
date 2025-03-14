﻿using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System.Linq;

namespace DeviceManagement_WebApp.Repository
{
    public class CategoriesRepository : GenericRepository<Category>, ICategoriesRepository
    {
        public CategoriesRepository(ConnectedOfficeContext context) : base(context)
        {
        }

        public Category GetMostRecentService()
        {
            return _context.Category.OrderByDescending(category => category.DateCreated).FirstOrDefault();
        }
    }
}
