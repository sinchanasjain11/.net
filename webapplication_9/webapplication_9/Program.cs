namespace webapplication_9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.UseStaticFiles();

          
            app.MapGet("/",context =>
            {
                context.Response.Redirect("/index.html");
                return Task.CompletedTask;
                });

            app.Run();
        }
    }
}
