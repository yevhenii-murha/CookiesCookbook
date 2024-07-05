using CookiesCookbook.Recipes;
using System.Collections.Generic;

namespace CookiesCookbook.Repositories
{
    public interface IRecipesRepository
    {
        List<Recipe> Read(string filePath);
        void Write(string filePath, List<Recipe> allRecipes);
    }
}
