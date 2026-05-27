using WebTodo.Data;

namespace WebTodo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            builder.Services.AddDbContext<AppDbContext>();
             
            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");

            app.UseRouting();

            app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
