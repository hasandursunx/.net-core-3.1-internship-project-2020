using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yoceyder.WebUI.Entity;

namespace Yoceyder.WebUI.Repository.Concrete.EntityFramework
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.GetRequiredService<YoceyderContext>();

            context.Database.Migrate();

            if (!context.Parents.Any())
            {
                var parents = new[]
                {
                    new Parent() {Vasi_Tc="51538470384" , Vasi_AdiSoyadi = "Hasan Dursun"},
                    new Parent() {Vasi_Tc="61635236987" , Vasi_AdiSoyadi = "Didem Turan"},
                    new Parent() {Vasi_Tc="71735632147" , Vasi_AdiSoyadi = "Nefise Öztürk "}
                };

                context.Parents.AddRange(parents);

                context.SaveChanges();
            }
        }
    }
}
