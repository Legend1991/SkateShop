using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SkateShop.Models
{
    public class SampleData: DropCreateDatabaseIfModelChanges<SkateShopEntities>
    {
        protected override void Seed(SkateShopEntities context)
        {
            var categories = new List<Category>
            {
                new Category { Name = "Скейтборды в сборе" },
                new Category { Name = "Деки" },
                new Category { Name = "Амортизаторы" },
                new Category { Name = "Ключи" },
                new Category { Name = "Подшипники" },
                new Category { Name = "Подвески" },
                new Category { Name = "Колеса" }
            };

            new List<Item>
            {
                new Item { Title = "Threat Cast Red 7.5 (19.1 см)", Category = categories.Single(g => g.Name == "Скейтборды в сборе"), Price = 1148, ItemPhotoUrl = "/Content/Images/skate1.gif" },
                new Item { Title = "Blind Mint R7 Green/White Complete 32 in 8.25 (20.9 см)", Category = categories.Single(g => g.Name == "Скейтборды в сборе"), Price = 1493, ItemPhotoUrl = "/Content/Images/skate2.gif" },
                new Item { Title = "Cliche Handwritten Rasta Bottom Splice R7 Complete 31.5 in 7.75 (19.5 см)", Category = categories.Single(g => g.Name == "Скейтборды в сборе"), Price = 1344, ItemPhotoUrl = "/Content/Images/skate3.gif" },
                new Item { Title = "Plan B Rodriguez Checkers Prolite Complete 7.625 (19.4 см)", Category = categories.Single(g => g.Name == "Скейтборды в сборе"), Price = 1611, ItemPhotoUrl = "/Content/Images/skate4.gif" },
                new Item { Title = "Mystery Orange Heart Orange Complete 8.5 (21.6 см)", Category = categories.Single(g => g.Name == "Скейтборды в сборе"), Price = 1302, ItemPhotoUrl = "/Content/Images/skate5.gif" },

                new Item { Title = "Enjoi Enjoi On Steroids Os Turquoise 31,5 In 7,75 (19,7 см)", Category = categories.Single(g => g.Name == "Деки"), Price = 771, ItemPhotoUrl = "/Content/Images/deck1.gif" },
                new Item { Title = "Almost Word Mark Sg Plus Red/White 31,9 In 8,0 (20,3 см)", Category = categories.Single(g => g.Name == "Деки"), Price = 630, ItemPhotoUrl = "/Content/Images/deck2.gif" },
                new Item { Title = "LE OG Logo Green 32 in 8.0 (20.3 см)", Category = categories.Single(g => g.Name == "Деки"), Price = 630, ItemPhotoUrl = "/Content/Images/deck3.gif" },
                new Item { Title = "Almost Daewon Og Bamboo Impact 31,9 In 8,1 (20,6 см)", Category = categories.Single(g => g.Name == "Деки"), Price = 771, ItemPhotoUrl = "/Content/Images/deck4.gif" },
                new Item { Title = "Cliche Mad Brains R7 Rasta 31,8 In 7,9 (20,1 см)", Category = categories.Single(g => g.Name == "Деки"), Price = 659, ItemPhotoUrl = "/Content/Images/deck5.gif" },

                new Item { Title = "Independent Low Hard 96A Black", Category = categories.Single(g => g.Name == "Амортизаторы"), Price = 65, ItemPhotoUrl = "/Content/Images/damper1.gif" },
                new Item { Title = "Shortys Doh-Doh 88A Blue", Category = categories.Single(g => g.Name == "Амортизаторы"), Price = 36, ItemPhotoUrl = "/Content/Images/damper2.gif" },
                new Item { Title = "Shortys Doh-Doh 93A Yellow", Category = categories.Single(g => g.Name == "Амортизаторы"), Price = 10, ItemPhotoUrl = "/Content/Images/damper3.gif" },

                new Item { Title = "Industrial Skate Tool Black", Category = categories.Single(g => g.Name == "Ключи"), Price = 133, ItemPhotoUrl = "/Content/Images/wrench1.gif" },
                new Item { Title = "Card Tool", Category = categories.Single(g => g.Name == "Ключи"), Price = 94, ItemPhotoUrl = "/Content/Images/wrench2.gif" },
                new Item { Title = "Пресс для подшипников Independent", Category = categories.Single(g => g.Name == "Ключи"), Price = 727, ItemPhotoUrl = "/Content/Images/wrench3.gif" },

                new Item { Title = "Flip Hkd Abec-7 (8 Pack)", Category = categories.Single(g => g.Name == "Подшипники"), Price = 204, ItemPhotoUrl = "/Content/Images/bearing1.gif" },
                new Item { Title = "SS Bearings 3", Category = categories.Single(g => g.Name == "Подшипники"), Price = 78, ItemPhotoUrl = "/Content/Images/bearing2.gif" },
                new Item { Title = "Rush Abec-3 Bearings", Category = categories.Single(g => g.Name == "Подшипники"), Price = 133, ItemPhotoUrl = "/Content/Images/bearing3.gif" },

                new Item { Title = "Independent St10 Silver 139 Standart 8 (20.3 см)", Category = categories.Single(g => g.Name == "Подвески"), Price = 303, ItemPhotoUrl = "/Content/Images/truck1.gif" },
                new Item { Title = "Tensor Mag Lo Slider Purple/Silver 5,0 (19,5 см)", Category = categories.Single(g => g.Name == "Подвески"), Price = 389, ItemPhotoUrl = "/Content/Images/truck2.gif" },
                new Item { Title = "Tensor Mag Light Lo Tens Fades Brezinski 5,0 (19,5 см)", Category = categories.Single(g => g.Name == "Подвески"), Price = 389, ItemPhotoUrl = "/Content/Images/truck3.gif" },

                new Item { Title = "Phase One Team 56mm 96A", Category = categories.Single(g => g.Name == "Колеса"), Price = 196, ItemPhotoUrl = "/Content/Images/wheel1.gif" },
                new Item { Title = "Chocolate Dark Chocolate 52mm 99A", Category = categories.Single(g => g.Name == "Колеса"), Price = 269, ItemPhotoUrl = "/Content/Images/wheel2.gif" },
                new Item { Title = "Cliche Woodcut Green/Black 54 mm 100A", Category = categories.Single(g => g.Name == "Колеса"), Price = 209, ItemPhotoUrl = "/Content/Images/wheel3.gif" },
                new Item { Title = "Speed Demons Bubble Gum Softie Green/Pink 65 mm 83A", Category = categories.Single(g => g.Name == "Колеса"), Price = 350, ItemPhotoUrl = "/Content/Images/wheel4.gif" }
            }.ForEach(a => context.Items.Add(a));
        }
    }
}