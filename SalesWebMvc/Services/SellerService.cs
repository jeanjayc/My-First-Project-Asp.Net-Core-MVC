﻿using SalesWebMvc.Models;
using SalesWebMvc.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Sellers> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Sellers obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
