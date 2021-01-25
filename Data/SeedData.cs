using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CarPro.Models;
using System;
using System.Linq;

namespace CarPro.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {

                if (!context.Lot.Any())
                {
                    context.Lot.AddRange(
                        new Lot
                        {
                            Name = "Car Lot 1",
                            Address = "405 harbor Ln",
                            ZipCode = "02354",
                            PhoneNum = "709-243-5678",
                            Manager = "Lacey Birtch"
                        },
                        new Lot
                        {
                            Name = "Car Lot 2",
                            Address = "406 harbor Ln",
                            ZipCode = "02354",
                            PhoneNum = "815-000-0000",
                            Manager = "Kevin Feige"
                        }
                    );
                    context.SaveChanges();
                }


                if (!context.Cars.Any())
                {
                    var lotId = context.Lot.FirstOrDefault(l => l.Name == "Car Lot 1").Id;

                    context.Cars.AddRange(
                        new Car
                        {
                            LotId = lotId,
                            Make = "Hyundai",
                            Model = "Tiburon",
                            Year = 2018,
                            Mileage = 50000,
                            Price = 11000,
                            Color = "Blue",
                            DriveTrain = "2WD"
                        },

                        new Car
                        {
                            LotId = lotId,
                            Make = "Honda",
                            Model = "Civic",
                            Year = 2007,
                            Mileage = 500000,
                            Price = 4500,
                            Color = "Rebecca Purple",
                            DriveTrain = "2WD"
                        },

                        new Car
                        {
                            LotId = lotId,
                            Make = "Mitsubishi ",
                            Model = "Lancer",
                            Year = 2008,
                            Mileage = 200000,
                            Price = 5900,
                            Color = "Gold",
                            DriveTrain = "4WD"
                        },

                        new Car
                        {
                            LotId = lotId,
                            Make = "DMC",
                            Model = "Delorean",
                            Year = 1982,
                            Mileage = 888888,
                            Price = 100000,
                            Color = "Grey",
                            DriveTrain = "4WD"
                        },

                        new Car
                        {
                            LotId = lotId,
                            Make = "Chevy",
                            Model = "Impala",
                            Year = 1967,
                            Mileage = 800000,
                            Price = 4567,
                            Color = "Black",
                            DriveTrain = "4WD"
                        }
                    );
                    context.SaveChanges();
                }

            }
        }
    }
}