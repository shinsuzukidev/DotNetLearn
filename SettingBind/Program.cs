using Microsoft.Extensions.Configuration;

namespace SettingBind
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("__start!");

            // appsetting.jsonをモデルにバインド
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            Console.WriteLine(configuration["Title"]);
            Console.WriteLine(configuration.GetConnectionString("MainDB"));


            // モデルにマッピング
            var appSettings = configuration.Get<AppSettings>();
            Console.WriteLine(appSettings!.Title);
            Console.WriteLine(appSettings.ConnectionStrings.MainDB);





            Console.WriteLine("__end!");
        }
    }
}
