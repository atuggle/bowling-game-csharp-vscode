# Bowling Game Kata in C#

## Summary

This practice coding example is one I have done many times before, this time I plan to focus using VS Code and the command line dotnet build and test runner all from vs code.

Muscle memory I hope to improve doing this kata:

- Using dotnet command line
- creating git commits early and often
- Using vs code shortcuts
- learning xunit

## Steps

1. Initalize git repository
2. Create first Test
3. Make first test pass
4. Refactor where needed
5. Push to remote repository
6. Repeat steps 1-4 as needed till done

## Command lines used to scaffold this project

- `dotnet new console -n bowlinggame.kata -f net6.0`
  - Changed output type to 'library' in bowlinggame.kata.csproj
- `dotnet new xunit -o bowlinggame.Tests`
- `dotnet add ./bowlinggame.Tests/bowlinggame.Tests.csproj reference ./bowlinggame.kata/bowlinggame.kata.csproj`
- `dotnet new sln -o BowlingGameKata` (Move sln file to root folder and delete subfolder BowlingGameKata)
- `dotnet sln add ./bowlinggame.kata/bowlinggame.kata.csproj ./bowlinggame.Tests/bowlinggame.Tests.csproj`

### Take-aways

- Should have created the sln file first
- Should have created the project as a library not console app
- Need to learn how to get VS Code to show Xunit Assert intellisense
- Extension "**.NET Core Test Explorer**" is pretty cool

## How to compile and run tests for this repository

- build: `dotnet build`
- run: `dotnet run`
- test: `dotnet test`

## Helpful links

- [Totorial: Create a .NET tool using the .NET CLI](https://docs.microsoft.com/en-us/dotnet/core/tools/global-tools-how-to-create#:~:text=Create%20a%20project%201%20Open%20a%20command%20prompt,3%20Navigate%20to%20the%20microsoft.botsay%20folder.%20cd%20microsoft.botsay)