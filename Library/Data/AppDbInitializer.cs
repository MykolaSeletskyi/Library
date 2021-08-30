using Library.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Publishers.Any())
                {
                    context.Publishers.AddRange(
                        new Publisher()
                        {
                            Name = "Publisher 1"
                        },
                        new Publisher()
                        {
                            Name = "Publisher 2"
                        },
                        new Publisher()
                        {
                            Name = "Publisher 3"
                        },
                        new Publisher()
                        {
                            Name = "Publisher 4"
                        },
                        new Publisher()
                        {
                            Name = "Publisher 5"
                        },
                        new Publisher()
                        {
                            Name = "Publisher 6"
                        },
                        new Publisher()
                        {
                            Name = "Publisher 7"
                        },
                        new Publisher()
                        {
                            Name = "Publisher 8"
                        },
                        new Publisher()
                        {
                            Name = "Publisher 10"
                        },
                        new Publisher()
                        {
                            Name = "Publisher 11"
                        },
                        new Publisher()
                        {
                            Name = "Publisher 12"
                        },
                        new Publisher()
                        {
                            Name = "Publisher 13"
                        },
                        new Publisher()
                        {
                            Name = "Publisher 14"
                        }
                    );

                    context.SaveChanges();
                }
            }
        }
    }
}
