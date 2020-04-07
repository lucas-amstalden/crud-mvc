using Microsoft.Ajax.Utilities;
using PrimeiroCrudMVC.Data;
using PrimeiroCrudMVC.Models;
using PrimeiroCrudMVC.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PrimeiroCrudMVC.UnitOfWork
{
    public class UnitOfWorkApp : DbContext
    {
        ContextApp context = new ContextApp();
        Repository.Repository<Product> productRepository;

        public Repository<Product> ProductRepository
        {
            get
            {
                if(productRepository == null)
                {
                    productRepository = new Repository<Product>(context);
                }
                return productRepository;
            }
        }

        public void Commit()
        {
            context.SaveChanges();
        }
    }
}