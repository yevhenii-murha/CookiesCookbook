using CookiesCookbook.Repositories;
using CookiesCookbook.Repositories.Strings;
using CookiesCookbook.UserInteraction;
using System.Text;
using System.Threading.Tasks;

namespace CookiesCookbook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////
            const FileFormat Format = FileFormat.Txt;
            const string FileName = "recipes";
            /////////////////////////////////////////

            /////////////////////////////////////////
            string filePath;
            IStringsRepository stringsRepository;
            if (Format == FileFormat.Json)
            {
                filePath = FileName + ".json";
                stringsRepository = new StringsJsonRepository();
            }
            else if (Format == FileFormat.Txt)
            {
                filePath = FileName + ".txt";
                stringsRepository = new StringsTextualRepository();
            }
            
            var ingredientsRegister = new IngredientsRegister();
            var cookiesRecipesApp = new CookiesRecipesApp(
                new RecipesRepository(
                    stringsRepository,
                    ingredientsRegister),
                new RecipesConsoleUserInteraction(
                    ingredientsRegister));
            cookiesRecipesApp.Run(filePath);
        }
    }
}
