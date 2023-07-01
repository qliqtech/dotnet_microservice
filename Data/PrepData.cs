namespace PlatformService.Data
{
    public static class PrepData
    {
        public static void PrepPopulation(IApplicationBuilder app) {

            using (var serviceScope = app.ApplicationServices.CreateScope()) {

                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());    
            }

        
        }

        public static void SeedData(AppDbContext context) {

            if (!context.Platform.Any())
            {
                Console.WriteLine("--> Seeding Data...");

                context.Platform.AddRange(
                    new Models.Platform(){Name = "Dot Net", Publisher = "Microsoft", Cost = "Free"},
                    new Models.Platform(){Name = "SQL Server Express", Publisher = "Microsoft", Cost = "Free" },
                    new Models.Platform(){Name = "Kubernetes", Publisher = "Cloud Native Computing Foundation", Cost = "Free" }

                    );
            }
            else{
                Console.WriteLine("--> We already have data");
            }

        }
    }

   
}
