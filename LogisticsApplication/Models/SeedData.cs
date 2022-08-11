using LogisticsApplication.Data;
using Microsoft.EntityFrameworkCore;

namespace LogisticsApplication.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LogisticsApplicationContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<LogisticsApplicationContext>>()))
            {
                // Look for any movies.
                if (context.Order.Any())
                {
                    return;   // DB has been seeded
                }

                context.Order.AddRange(
                    new Order
                    {
                        SenderCity = "Нижний Новгород",
                        SenderAddress = "Социалистическая улица, 40",
                        ReceiverCity = "Владивосток",
                        ReceiverAddress = "Советский проспект, 60",
                        CargoWeight = 30.5,
                        CargoPickUpDate = DateTime.Parse("2022-2-12")
                    },

                    new Order
                    {
                        SenderCity = "Москва",
                        SenderAddress = "Улица 1905 года, 4",
                        ReceiverCity = "Санкт-Петербург",
                        ReceiverAddress = "Суворовский проспект, 60",
                        CargoWeight = 40,
                        CargoPickUpDate = DateTime.Parse("2022-2-20")
                    }
                )   ;
                context.SaveChanges();
            }
        }
    }
}
