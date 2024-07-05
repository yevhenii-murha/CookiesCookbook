﻿using CookiesCookbook.Recipes;
using CookiesCookbook.Recipes.Ingredients;
using CookiesCookbook.Repositories.Strings;
using System.Collections.Generic;

namespace CookiesCookbook.Repositories
{
    public class RecipesRepository : IRecipesRepository
    {
        private readonly IStringsRepository _stringsRepository;
        private readonly IIngredientsRegister _ingredientsRegister;

        public RecipesRepository(IStringsRepository stringsRepository, IIngredientsRegister ingredientsRegister)
        {
            _stringsRepository = stringsRepository;
            _ingredientsRegister = ingredientsRegister;
        }

        public List<Recipe> Read(string filePath)
        {
            List<string> recipesFromFile = _stringsRepository.Read(filePath);
            var recipes = new List<Recipe>();

            foreach(var recipeFromFile in recipesFromFile)
            {
                var recipe = RecipeFromString(recipeFromFile);
                recipes.Add(recipe);
            }

            return recipes;
        }

        private Recipe RecipeFromString(string recipeFromFile)
        {
            var textualIds = recipeFromFile.Split(',');
            var ingredients = new List<Ingredient>();

            foreach(var textualId in textualIds)
            {
                var id = int.Parse(textualId);
                var ingredient = _ingredientsRegister.GetById(id);
                ingredients.Add(ingredient);
            }

            return new Recipe(ingredients);
        }

        public void Write(string filePath, List<Recipe> allRecipes)
        {
            var recipesAsStrings = new List<string>();
            foreach (var recipe in allRecipes)
            {
                var allIds = new List<int>();
                foreach (var ingredient in recipe.Ingredients)
                {
                    allIds.Add(ingredient.Id);
                }
                recipesAsStrings.Add(string.Join(",", allIds));
            }
            _stringsRepository.Write(filePath, recipesAsStrings);
        }
    }
}
