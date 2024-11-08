 var builder = WebApplication.CreateBuilder(args);
 builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();
        //dotnet watch --project "MeetingApp/MeetingApp.csproj"

        app.MapControllerRoute(
        name: "Default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
        );


        app.Run();
    