namespace NnhLesson01
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			var app = builder.Build();

			app.MapGet("/", () => "Hello Nguyễn Ngọc Hiếu ");

			app.Run();
		}
	}
}
