# Cookies Cookbook

This project implements a simple console application for managing cookie recipes. Users can create, view, and store cookie recipes in either JSON or text format.

## Features

- **Recipe Management**: Create new cookie recipes by selecting ingredients from a predefined list.
- **Storage Options**: Recipes can be saved in JSON or text format based on user preference.
- **Ingredient Selection**: Choose ingredients from a list that includes various types of flour, butter, chocolate, and more.
- **User Interaction**: Interactive console prompts guide users through recipe creation and viewing.

## Structure

The project is structured into several components:

- **Recipes**: Classes and interfaces related to managing recipes (`Recipe`, `RecipesRepository`).
- **Ingredients**: Ingredients used in recipes (`Ingredient`, `IngredientsRegister`).
- **User Interaction**: Console interaction with users (`RecipesConsoleUserInteraction`).
- **Repositories**: Interfaces and implementations for storing and retrieving recipes (`IRecipesRepository`, `StringsJsonRepository`, `StringsTextualRepository`).
- **Utilities**: Helper classes and enums (`FileFormat`).

## Usage

To run the application:

1. Clone the repository.
2. Build the project using Visual Studio or `dotnet build`.
3. Run the executable. The application will prompt you to create a new recipe or view existing ones.
4. Follow the console prompts to interact with the application.
