namespace _26_DynamicPropertiesViewModel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            //app.MapControllerRoute(
            //   "Corporative",
            //   "Carparativ-satislar",
            //  new   {controller= "home", action= "CorporativeSales" }
            //   );

            app.MapControllerRoute(
                "default",
                "{controller=home}/{action=index}/{Id?}"
                );



            app.Run();
        }
    }
}
