using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.DataBaseContext
{
    public class DataContext : DbContext
    {
        public DbSet<Ad> Ads { get; set; }
        public DbSet<Address> Addeesses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Cutomers { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<GpsLoation> GpsLocations { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Pay> Pays { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<User> users { get; set; }
    }
}
