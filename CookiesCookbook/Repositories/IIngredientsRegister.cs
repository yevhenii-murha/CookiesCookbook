using CookiesCookbook.Recipes.Ingredients;
using System.Collections.Generic;

namespace CookiesCookbook.Repositories
{
    public interface IIngredientsRegister
    {
        IEnumerable<Ingredient> All { get; }

        Ingredient GetById(int id);
    }
}
