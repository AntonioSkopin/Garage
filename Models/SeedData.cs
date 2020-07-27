using Garage.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garage.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GarageContext(
                serviceProvider.GetRequiredService<DbContextOptions<GarageContext>>()))
            {
                // Look for any cars
                if (context.Auto.Any())
                {
                    return; // DB has been seeded
                }

                // Add following cars with attributes to Database
                context.Auto.AddRange(
                    new Auto
                    {
                        AutoKenteken = "F-2H1-AA",
                        AutoMerk = "Mercedes",
                        AutoType = "GLA 180",
                        EigenaarNaam = "Hendrik Petersson"
                    },

                    new Auto
                    {
                        AutoKenteken = "AC-809-B",
                        AutoMerk = "Volkswagen",
                        AutoType = "Polo",
                        EigenaarNaam = "Youssef Hamza"
                    },

                    new Auto
                    {
                        AutoKenteken = "99-AC2-D",
                        AutoMerk = "Lexus",
                        AutoType = "Delta",
                        EigenaarNaam = "Damir Miranovic"
                    },

                    new Auto
                    {
                        AutoKenteken = "H-A5B-AA",
                        AutoMerk = "BMW",
                        AutoType = "X5",
                        EigenaarNaam = "Peter Solima"
                    },

                    new Auto
                    {
                        AutoKenteken = "76-APT-J",
                        AutoMerk = "Audi",
                        AutoType = "A3",
                        EigenaarNaam = "Nigel Blokssen"
                    },

                    new Auto
                    {
                        AutoKenteken = "G-32B-GD",
                        AutoMerk = "Lamborghini",
                        AutoType = "Urus",
                        EigenaarNaam = "Mohamed Lemhadi"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
