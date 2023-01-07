using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Shop.Data;
using Shop.Data.Models;
using Shop.Service;
using Shop.Web.Controllers;
using Shop.Web.Models.Account;
using System;
using System.IO;
using Xunit;

namespace TestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.Development.json")
                .Build();
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            var connectionString = configuration.GetConnectionString("MSSqlConnection");
            builder.UseSqlServer(connectionString);
            ApplicationDbContext context = new ApplicationDbContext(builder.Options);

            FoodService foodService = new FoodService(context);
            Food food = foodService.GetById(1);
            //Eggplant
            Assert.Equal(20, food.InStock);


        }

        [Fact]
        public void Test2()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.Development.json")
                .Build();
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            var connectionString = configuration.GetConnectionString("MSSqlConnection");
            builder.UseSqlServer(connectionString);
            ApplicationDbContext context = new ApplicationDbContext(builder.Options);

            FoodService foodService = new FoodService(context);
            Food food = foodService.GetById(1);
            //Eggplant
            Assert.Equal("Eggplant", food.Name);
        }
        [Fact]
        public void Test3()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.Development.json")
                .Build();
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            var connectionString = configuration.GetConnectionString("MSSqlConnection");
            builder.UseSqlServer(connectionString);
            ApplicationDbContext context = new ApplicationDbContext(builder.Options);

            FoodService foodService = new FoodService(context);
            Food food = foodService.GetById(1);
            
            Assert.Equal("Vegetable", food.Category.Name);
        }

    }
}
