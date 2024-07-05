using CookiesCookbook.Recipes;
using CookiesCookbook.Recipes.Ingredients;
using System.Collections.Generic;

namespace CookiesCookbook.UserInteraction
{
    public interface IRecipesUserInteraction
    {
        void ShowMessage(string message);
        void Exit();
        void PrintExistingRecipes(IEnumerable<Recipe> allRecipes);
        void PromptToCreateRecipe();
        IEnumerable<Ingredient> ReadIngredientsFromUser();
    }
}
