namespace ZeroyxzCusts.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ZeroyxzCusts.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ZeroyxzCusts.Models.ZeroyxzCustsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ZeroyxzCusts.Models.ZeroyxzCustsContext context)
        {
            context.Customers.AddOrUpdate(p => p.Name,
         new Customer
        {
            Name = "Debra Garcia",
            Address = "1234 Main St",
            City = "Redmond",
            County = "WA",
            PostCode = "10999",
            Email = "debra@example.com",
            Twitter = "debra_example"
        },
         new Customer
         {
             Name = "Thorsten Weinrich",
             Address = "5678 1st Ave W",
             City = "Redmond",
             County = "WA",
             PostCode = "10999",
             Email = "thorsten@example.com",
             Twitter = "thorsten_example"
         },
         new Customer
         {
             Name = "Yuhong Li",
             Address = "9012 State st",
             City = "Redmond",
             County = "WA",
             PostCode = "10999",
             Email = "yuhong@example.com",
             Twitter = "yuhong_example"
         },
         new Customer
         {
             Name = "Jon Orton",
             Address = "3456 Maple St",
             City = "Redmond",
             County = "WA",
             PostCode = "10999",
             Email = "jon@example.com",
             Twitter = "jon_example"
         },
         new Customer
         {
             Name = "Diliana Alexieva-Bosseva",
             Address = "7890 2nd Ave E",
             City = "Redmond",
             County = "WA",
             PostCode = "10999",
             Email = "diliana@example.com",
             Twitter = "diliana_example"
         }
         );
        }
    }
}
