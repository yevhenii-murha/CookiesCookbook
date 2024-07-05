using CookiesCookbook.App;
using CookiesCookbook.Repositories;
using CookiesCookbook.Repositories.Strings;
using CookiesCookbook.Services;
using CookiesCookbook.UserInteraction;
using System.Text;
using System.Threading.Tasks;

namespace CookiesCookbook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fileMetadata = new FileMetadata(FileFormat.Txt, "recipes");

            string filePath = fileMetadata.FilePath;

            IStringsRepository stringsRepository = StringsRepositoryFactory.CreateRepository(fileMetadata.Format);

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
