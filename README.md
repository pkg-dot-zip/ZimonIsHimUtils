<p align="center">
  <a href="https://github.com/ZimonIsHim/ZimonIsHimUtils" rel="noopener">
 <img width=200px height=200px src="https://i.imgur.com/1CWWMG5.png" alt="Project logo"></a>
</p>

<h3 align="center">ZimonIsHimUtils</h3>

<div align="center">

  [![Stars](https://img.shields.io/github/stars/ZimonIsHim/ZimonIsHimUtils)](https://github.com/ZimonIsHim/ZimonIsHimUtils/stargazers)
  [![NuGet](https://img.shields.io/nuget/dt/ZimonIsHimUtils)](https://www.nuget.org/packages/ZimonIsHimUtils/)
  [![NuGet Version](https://img.shields.io/nuget/v/ZimonIsHimUtils)](https://www.nuget.org/packages/ZimonIsHimUtils/)
  [![Last Commit](https://img.shields.io/github/last-commit/ZimonIsHim/ZimonIsHimUtils)](https://github.com/ZimonIsHim/ZimonIsHimUtils/commits/development)
  [![License](https://img.shields.io/github/license/ZimonIsHim/ZimonIsHimUtils)](/LICENSE)

</div>

---

<p align="center"> Personal project in which I create useful as well as weird and/or illegal extension methods.
    <br> 
</p>

## 📝 Table of Contents
- [About](#about)
- [Authors](#authors)

## 🧐 About <a name = "about"></a>
Personal project in which I create useful as well as weird and/or illegal extension methods

## ✍️ Authors <a name = "authors"></a>
- [@ZimonIsHim](https://github.com/ZimonIsHim) - Idea, Initial work, general development & management

## Example usage <a name = "example"></a>
```csharp
internal static void Example()
        {
            IList<int> list = new List<int> {1, 5, 6};
            list.Each(PrintTestI); // ForEach() method replacement for IEnumerable (instead of List).

            30.DoFor(PrintTest); // Run action 30 times.
            30.DoFor(PrintTestI); // Run action 30 times and pass iteration as parameter.

            bool aBoolean = false;
            aBoolean.Flip(); // Flips the boolean; turns true into false and vice versa.

            RunOperationOnAction(PrintTest);
        }

        private static void RunOperationOnAction(Action action)
        {
            action.DoFor(21); // Run action 21 times.
        }

        private static void PrintTestI(int i) => Console.WriteLine($"Hello {i}");
        private static void PrintTest() => Console.WriteLine("Hello");
```
