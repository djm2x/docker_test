using System;
using System.Collections.Generic;
using Bogus;
using Microsoft.EntityFrameworkCore;
namespace Models
{
    public static class DataSeeding
    {
        public static string lang = "fr";
        public static Faker f = new Faker();

        public static ModelBuilder Users(this ModelBuilder modelBuilder)
        {
            int id = 1;
            var roles = new[] { "sa", "admin", "user" };

            var faker = new Faker<User>(DataSeeding.lang)
                .CustomInstantiator(f => new User { Id = id++ })
                .RuleFor(o => o.Email, f => id - 1 == 1 ? "sa@angular.io" : f.Internet.Email())
                .RuleFor(o => o.Password, f => "123")
                ;
            modelBuilder.Entity<User>().HasData(faker.Generate(10));
            return modelBuilder;
        }


    }
}