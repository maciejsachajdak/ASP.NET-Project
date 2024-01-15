using System.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project.Areas.Identity.Data;
using Project.Data;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var connectionString = builder.Configuration.GetConnectionString("ApplicationDBContextConnection") ??
                               throw new InvalidOperationException(
                                   "Connection string 'ApplicationDBContextConnection' not found.");

        builder.Services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(connectionString));

        builder.Services.AddDbContext<AnotherDBContext>(options =>
            options.UseSqlServer(connectionString));

        builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
            .AddRoles<IdentityRole>().AddEntityFrameworkStores<ApplicationDBContext>();


        // Add services to the container.
        builder.Services.AddControllersWithViews();

        builder.Services.AddRazorPages();


        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }


        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();


        app.UseEndpoints(endpoints => { endpoints.MapRazorPages(); });


        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
        app.MapRazorPages();

        using (var scope = app.Services.CreateScope())
        {
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            var roles = new[] { "Admin", "Member" };

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
        }

        using (var scope = app.Services.CreateScope())
        {
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            string email = "darekadminadmin@admin.com";
            string password = "Darek123!";

            if (await userManager.FindByEmailAsync(email) == null)
            {
                var user = new ApplicationUser();
                user.Login = "DarekAdmin";
                user.name = "Darek";
                user.surname = "Radwan";
                user.address = "Darkowo";
                user.club = 2;
                user.sex = "Male";
                user.birthdate = DateOnly.Parse("03-02-2000");
                user.Email = "darekadminadmin@admin.com";
                user.UserName = user.Login;
                user.Role = "Admin";

                await userManager.CreateAsync(user, password);

                await userManager.AddToRoleAsync(user, user.Role);
            }
        }

        using (var scope = app.Services.CreateScope())
        {
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            string email = "andrzejek@member.com";
            string password = "Andrzej123!";

            if (await userManager.FindByEmailAsync(email) == null)
            {
                var user = new ApplicationUser();
                user.Login = "Andrzejek";
                user.name = "Andrzej";
                user.surname = "Sarkowicz";
                user.address = "Andrzejkowiczowo";
                user.club = 3;
                user.sex = "Male";
                user.birthdate = DateOnly.Parse("15-05-2001");
                user.Email = "andrzejek@member.com";
                user.UserName = user.Login;
                user.Role = "Member";

                await userManager.CreateAsync(user, password);

                await userManager.AddToRoleAsync(user, user.Role);
            }
        }

        using (var scope = app.Services.CreateScope())
        {
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            string email = "mikolajradwan@user.com";
            string password = "Radwan2137!";

            if (await userManager.FindByEmailAsync(email) == null)
            {
                var user = new ApplicationUser();
                user.Login = "Radwan";
                user.name = "Mikołaj";
                user.surname = "Radwan";
                user.address = "Warszawa";
                user.club = 4;
                user.sex = "Male";
                user.birthdate = DateOnly.Parse("13-06-2000");
                user.Email = "mikolajradwan@user.com";
                user.UserName = user.Login;
                user.Role = "Member";

                await userManager.CreateAsync(user, password);

                await userManager.AddToRoleAsync(user, user.Role);
            }
        }

        app.Run();
    }
}