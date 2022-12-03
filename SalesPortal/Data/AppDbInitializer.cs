using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SalesPortal.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                
                //Models
                if (!context.Models.Any())
                {
                    context.Models.AddRange(new List<Model>()
                    {
                        new Model()
                        {
                            FullName = "Model 1",
                            Bio = "This is the Bio of the first model",
                            PictureURL = "https://europe.starconnect-ce.i.daimler.com/iris/iris.jpg?COSY-EU-100-1713d0VXqrWFqtyO67PobzIr3eWsrrCsdRRzwQZUnRZbMw3SGtlaStsd2J%25cUfpMqXGEuJSJ0l3CZOB2qM%25bApUnyI5uG5IQC30spkzNBtnm7j86ohKViKw%25vq4r9yLRgnyYaxPbWrH1en%25n8wso3oiZB5gM4FAy2Tg9LQO6PDaPpSeWHXutsd8ZDcUfiMWXGE4JmJ0lgOtOB2Pb2bApeIoI5usKYQC32hOkzNLzkm7jaSthymI9WFGjcUf8%256XGEHaVJ0lUHhOB2Zs8bAp5AXI5uC5MQC3zgFkzN7U9m7sDgubYwR9hDvT9v%25Nj6hVNpLLxdYfqJVf%25XEd9B96N683eUHpi3v1Lf42FmgqPOwX3GkflG&&BKGND=12&IMGT=A27&POV=BE030"

                        },
                        new Model()
                        {
                            FullName = "Model 2",
                            Bio = "This is the Bio of the first model",
                            PictureURL = "https://europe.starconnect-ce.i.daimler.com/iris/iris.jpg?COSY-EU-100-1713d0VXqrWFqtyO67PobzIr3eWsrrCsdRRzwQZUnRZbMw3SGtlaStsd2J%25cUfpMqXGEuJSJ0l3CZOB2qM%25bApUnyI5uG5IQC30spkzNBtnm7j86ohKViKw%25vq4r9yLRgnyYaxPbWrH1en%25n8wso3oiZB5gM4FAy2Tg9LQO6PDaPpSeWHXutsd8ZDcUfiMWXGE4JmJ0lgOtOB2Pb2bApeIoI5usKYQC32hOkzNLzkm7jaSthymI9WFGjcUf8%256XGEHaVJ0lUHhOB2Zs8bAp5AXI5uC5MQC3zgFkzN7U9m7sDgubYwR9hDvT9v%25Nj6hVNpLLxdYfqJVf%25XEd9B96N683eUHpi3v1Lf42FmgqPOwX3GkflG&&BKGND=12&IMGT=A27&POV=BE030"

                        },
                        new Model()
                        {
                            FullName = "Model 3",
                            Bio = "This is the Bio of the first model",
                            PictureURL = "https://europe.starconnect-ce.i.daimler.com/iris/iris.jpg?COSY-EU-100-1713d0VXqrWFqtyO67PobzIr3eWsrrCsdRRzwQZUnRZbMw3SGtlaStsd2J%25cUfpMqXGEuJSJ0l3CZOB2qM%25bApUnyI5uG5IQC30spkzNBtnm7j86ohKViKw%25vq4r9yLRgnyYaxPbWrH1en%25n8wso3oiZB5gM4FAy2Tg9LQO6PDaPpSeWHXutsd8ZDcUfiMWXGE4JmJ0lgOtOB2Pb2bApeIoI5usKYQC32hOkzNLzkm7jaSthymI9WFGjcUf8%256XGEHaVJ0lUHhOB2Zs8bAp5AXI5uC5MQC3zgFkzN7U9m7sDgubYwR9hDvT9v%25Nj6hVNpLLxdYfqJVf%25XEd9B96N683eUHpi3v1Lf42FmgqPOwX3GkflG&&BKGND=12&IMGT=A27&POV=BE030"

                        },
                        new Model()
                        {
                            FullName = "Model 4",
                            Bio = "This is the Bio of the first model",
                            PictureURL = "https://europe.starconnect-ce.i.daimler.com/iris/iris.jpg?COSY-EU-100-1713d0VXqrWFqtyO67PobzIr3eWsrrCsdRRzwQZUnRZbMw3SGtlaStsd2J%25cUfpMqXGEuJSJ0l3CZOB2qM%25bApUnyI5uG5IQC30spkzNBtnm7j86ohKViKw%25vq4r9yLRgnyYaxPbWrH1en%25n8wso3oiZB5gM4FAy2Tg9LQO6PDaPpSeWHXutsd8ZDcUfiMWXGE4JmJ0lgOtOB2Pb2bApeIoI5usKYQC32hOkzNLzkm7jaSthymI9WFGjcUf8%256XGEHaVJ0lUHhOB2Zs8bAp5AXI5uC5MQC3zgFkzN7U9m7sDgubYwR9hDvT9v%25Nj6hVNpLLxdYfqJVf%25XEd9B96N683eUHpi3v1Lf42FmgqPOwX3GkflG&&BKGND=12&IMGT=A27&POV=BE030"

                        },
                        new Model()
                        {
                            FullName = "Model 5",
                            Bio = "This is the Bio of the first model",
                            PictureURL = "https://europe.starconnect-ce.i.daimler.com/iris/iris.jpg?COSY-EU-100-1713d0VXqrWFqtyO67PobzIr3eWsrrCsdRRzwQZUnRZbMw3SGtlaStsd2J%25cUfpMqXGEuJSJ0l3CZOB2qM%25bApUnyI5uG5IQC30spkzNBtnm7j86ohKViKw%25vq4r9yLRgnyYaxPbWrH1en%25n8wso3oiZB5gM4FAy2Tg9LQO6PDaPpSeWHXutsd8ZDcUfiMWXGE4JmJ0lgOtOB2Pb2bApeIoI5usKYQC32hOkzNLzkm7jaSthymI9WFGjcUf8%256XGEHaVJ0lUHhOB2Zs8bAp5AXI5uC5MQC3zgFkzN7U9m7sDgubYwR9hDvT9v%25Nj6hVNpLLxdYfqJVf%25XEd9B96N683eUHpi3v1Lf42FmgqPOwX3GkflG&&BKGND=12&IMGT=A27&POV=BE030"

                        },
                    });
                    context.SaveChanges();
                }
                //Makes
                if (!context.Makes.Any())
                {
                    context.Makes.AddRange(new List<Make>()
                    {
                        new Make()
                        {
                            FullName = "Make",
                            Bio = "This is the Bio of the first Make",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"
                        },
                        new Make()
                        {
                            FullName = "Make",
                            Bio = "This is the Bio of the first Make",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"
                        },
                        new Make()
                        {
                            FullName = "Make",
                            Bio = "This is the Bio of the first Make",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"
                        },
                        new Make()
                        {
                            FullName = "Make",
                            Bio = "This is the Bio of the first Make",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"
                        },
                        new Make()
                        {
                            FullName = "Make",
                            Bio = "This is the Bio of the first Make",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"
                        },
                    });
                    context.SaveChanges();
                }
                //Cars
                if (!context.Cars.Any())
                {
                    context.Cars.AddRange(new List<Car>()
                    {
                        new Car()
                        {
                            Name = "Life",
                            Description = "This is the Life movie description",
                            Price = 145839.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            //StartDate = DateTime.Now.AddDays(-10),
                            //EndDate = DateTime.Now.AddDays(10),
                            MakeId = 1,
                            CarCategory = CarCategory.SUV
                        },
                        new Car()
                        {
                            Name = "Life",
                            Description = "This is the Life movie description",
                            Price = 145839.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            //StartDate = DateTime.Now.AddDays(-10),
                            //EndDate = DateTime.Now.AddDays(10),
                            MakeId = 1,
                            CarCategory = CarCategory.SUV
                        },
                        new Car()
                        {
                            Name = "Life",
                            Description = "This is the Life movie description",
                            Price = 145839.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            //StartDate = DateTime.Now.AddDays(-10),
                            //EndDate = DateTime.Now.AddDays(10),
                            MakeId = 1,
                            CarCategory = CarCategory.SUV
                        },
                        new Car()
                        {
                            Name = "Life",
                            Description = "This is the Life movie description",
                            Price = 145839.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            //StartDate = DateTime.Now.AddDays(-10),
                            //EndDate = DateTime.Now.AddDays(10),
                            MakeId = 1,
                            CarCategory = CarCategory.SUV
                        },
                        new Car()
                        {
                            Name = "Life",
                            Description = "This is the Life movie description",
                            Price = 145839.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            //StartDate = DateTime.Now.AddDays(-10),
                            //EndDate = DateTime.Now.AddDays(10),
                            MakeId = 1,
                            CarCategory = CarCategory.SUV
                        },
                        new Car()
                        {
                            Name = "Life",
                            Description = "This is the Life movie description",
                            Price = 145839.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            //StartDate = DateTime.Now.AddDays(-10),
                            //EndDate = DateTime.Now.AddDays(10),
                            MakeId = 1,
                            CarCategory = CarCategory.SUV
                        },
                    });
                    context.SaveChanges();
                }
                //Models & Cars
                if (!context.Models_Cars.Any())
                {
                    context.Models_Cars.AddRange(new List<Model_Car>()
                    {
                        new Model_Car()
                        {
                            ModelId = 1,
                            CarId = 1
                        },
                        new Model_Car()
                        {
                            ModelId = 1,
                            CarId = 1
                        },

                         new Model_Car()
                        {
                            ModelId = 1,
                            CarId = 1
                        },
                         new Model_Car()
                        {
                            ModelId = 1,
                            CarId = 1
                        },

                        new Model_Car()
                        {
                            ModelId = 1,
                            CarId = 1
                        },
                        new Model_Car()
                        {
                            ModelId = 1,
                            CarId = 1
                        },
                        new Model_Car()
                        {
                            ModelId = 1,
                            CarId = 1
                        },


                        new Model_Car()
                        {
                            ModelId = 1,
                            CarId = 1
                        },
                    });
                    context.SaveChanges();
                }
            }

        }

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@zoesales.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "user@etickets.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}
