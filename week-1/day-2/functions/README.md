# Functions

Dive deeper into *real* programming and learn how to reuse code.

## Materials & Resources

| Material                                                                 |  Time |
| :----------------------------------------------------------------------- | ----: |
| [Methods & Using Functions](https://www.youtube.com/watch?v=QwygwfqOHsI) | 17:07 |
| [Debugging in VisualStudio](https://www.youtube.com/watch?v=7ab4z9u7Q_I) | 16:15 |

## Material Review

- Why do programmers use functions?
- What is code duplication?
  - Why is code duplication undesirable?
  - How can you reduce code duplication?
- How do you pass parameters to a function?
- How do you return a value from a function?
- How can you use functions to make your code more readable?
- What are local variables?

### Debugging

- What to do when you're stuck with a runtime error?
- How do you set a breakpoint?
- How do you go through your code line by line?
- How do you check the current values of the variables?

## Workshop

```csharp
using System;

namespace Example
{
    class Program
    {
        public static void GreetingFunction()
        {
            Console.WriteLine("hello");
        }

        public static void Main(string[] args)
        {
            GreetingFunction();
            Console.ReadLine();
        }
    }
}
```

### Exercises

- [PrintParams](print-params/PrintParams.cs)
- [Doubling](doubling/Doubling.cs)
- [Greeter function](greet/Greet.cs)
- [Append a](append-a-func/AppendAFunc.cs)
- [Summing](sum/Sum.cs)
- [Factorial](factorio/Factorio.cs)

### Hard Ones

[Arrays workshop](../arrays/cs.md) is a prerequisite for the following
exercises.

- [Find part of an integer](subint/SubInt.cs)
- [Unique](unique/Unique.cs)
- [Anagram](anagram/README.md)
- [Palindrome builder](palindrome-builder/README.md)
- [Palindrome searcher](palindrome-searcher/README.md)
- [Sort that list](bubble/Bubble.cs)

![circles](../../../assets/azam.gif)
