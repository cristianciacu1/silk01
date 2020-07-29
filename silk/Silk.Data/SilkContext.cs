using Microsoft.EntityFrameworkCore;
using Silk.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Silk.Data
{
    public class SilkContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientAdress> ClientAdresses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }
        public DbSet<Order> Orders { get; set; }

        public SilkContext(DbContextOptions<SilkContext> options) : base(options)
        {

        }
    }
}
