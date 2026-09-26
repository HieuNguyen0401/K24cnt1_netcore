using Microsoft.EntityFrameworkCore;
using NguyenNgocHieu2410900032_exam.Models;
namespace NguyenNgocHieu2410900032_exam
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
   var connectionString = builder.Configuration.GetConnectionString("NnhStudent2410900032DbContext") ?? throw new InvalidOperationException("Connection string 'NnhStudent2410900032DbContext' not found.");

   builder.Services.AddDbContext<NnhStudent2410900032DbContext>(options => options.UseSqlServer(connectionString));

			// Add services to the container.
			builder.Services.AddControllersWithViews();

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

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");

			app.Run();
		}
	}
}
