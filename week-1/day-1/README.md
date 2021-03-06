# Expressions and Control Flow

Get into *real* programming, installing a development environment and then running our first programs.

| Material | Time |
|:---------|-----:|
|[C# wiki](https://en.wikipedia.org/wiki/C_Sharp_(programming_language))|-|
|[Install Guide](https://www.youtube.com/watch?v=IwxkVL5DGg8)|6:28|

## Materials

| Material | Time |
|:---------|-----:|
|[Programming Basics: Statements & Functions](https://www.youtube.com/watch?v=l26oaHV7D40)|only until 7:34|
|[Declaring Variables](https://www.youtube.com/watch?v=jB3cWjnWpwc)|20:25|
|[Console Input/Output](https://www.youtube.com/watch?v=wrl_OOgAjj0)|4:52|
|[Boolean Operators and variables](https://www.youtube.com/watch?v=u0JPMd8KSaU)|9:23|
|[If, Else and Else If Statements](https://www.youtube.com/watch?v=cIaMFKxxHj8)|5:44|
|[Switch statement](https://www.youtube.com/watch?v=soKhwNYxs2I)|7:55|
|[While and Do... While Loops](https://www.youtube.com/watch?v=A5P8sQSOWgI)|7:57|
|[For Loop](https://www.youtube.com/watch?v=IuTDC7FkPRI)|8:42|
|[Operators](https://www.tutorialspoint.com/csharp/csharp_operators.htm)|Miscellaneous and Bitwise Operators are not needed |

## Optional materials

| Material | Time |
|:---------|-----:|
|[Boolean Logic & Logic Gates](https://www.youtube.com/watch?v=gI-qXk7XojA)|10:06|
|[Algorithms: Bit Manipulation](https://www.youtube.com/watch?v=NLKQEOgBAnw)|9:05|

## Material Review

- What is a programming language?
- What type of programming language is C#?
- What do we need to write a program?
  <!-- a text editor, Visual Studio -->
- What is a statement?
  <!-- syntactic unit that expresses some action to be carried out -->
- What is a variable?
- What is variable declaration?
- What is variable assignment?
- What kind of variable types do you know?
  <!-- byte, int, float, boolean, char, String -->
- What is an operator?
- What type of operators do you know?
  <!--

    arithmetic operators:
      additive (+),
      subtraction (-),
      multiplication (*),
      division (/),
      remainder (%)

    unary operators:
      increment (++),
      decrement (--),
      logical complement (!)

    equality and relational operators:
      equal to (==),
      not equal to (!=),
      greater than (>),
      greater than or equal to (>=),
      less than (<),
      less than or equal to (<=)

    conditional operators:
      conditional-AND (&&),
      conditional-OR (||)
    -->

- What is the *Hello World!* application?
- What is string concatenation?
- What is a *block*?
- What is an *if* statement?
- What is a *for-loop* statement?
- What is a *while-loop* statement?
- What is a *do-loop* statement?
- What is a *switch* statement?
- How can you get input from the user via command line?

## Workshop

### Printing to the terminal window

#### Hello World

```csharp
using System;

namespace PracticeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

```

#### Exercises
 -  [01 - HelloMe](hello-me/HelloMe.cs)
 -  [02 - HumptyDumpty](humpty-dumpty/HumptyDumpty.cs)
 -  [03 - HelloOthers](hello-others/HelloOthers.cs)

### Types

#### Print values with different types

```csharp
using System;

namespace PracticeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(42);

            Console.Write(3.1415);

            Console.Read();
        }
    }
}

```

#### Integers

```csharp
using System;

namespace PracticeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(42);

            Console.Write(3.1415);

            // maximum and minimum value
            // a simple integer is represented in 4 bytes (32bit)

            // maximum value:  2 147 483 647
            Console.WriteLine(2147483647);

            // minimum value: -2 147 483 648
            Console.WriteLine(-2147483648);

            Console.ReadLine();
        }
    }
}
```

#### Number Operations

```csharp
using System;

namespace PracticeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(2 + 2);
            Console.WriteLine(7 - 2);
            Console.WriteLine(3 * 2);
            Console.WriteLine(5 / 2);
            Console.WriteLine(7 % 2);
            Console.WriteLine(7 / 2.0);

            Console.ReadLine();
        }
    }
}
```

#### Booleans

```csharp
using System;

namespace PracticeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //true, false
            Console.WriteLine(true);
            Console.WriteLine(false);

            //negation
            Console.WriteLine(!true);
            Console.WriteLine(!false);

            //and
            Console.WriteLine(true && true);
            Console.WriteLine(true && false);
            Console.WriteLine(false && true);
            Console.WriteLine(false && false);

            //or
            Console.WriteLine(true || true);
            Console.WriteLine(true || false);
            Console.WriteLine(false || true);
            Console.WriteLine(false || false);

            Console.ReadLine();
        }
    }
}
```

#### Strings

```csharp
using System;

namespace PracticeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // string and special characters
            Console.WriteLine("hello");
            Console.WriteLine("don't");
            Console.WriteLine("She said, \"you deserva a treat\" ");

            // string Operators
            // Concatination
            Console.WriteLine("hand" + "some");

            // concat string with number
            Console.WriteLine("My favourite number is: " + 8);

            Console.ReadLine();
        }
    }
}

```

#### Exercises

 -  [04 - IntroduceYourself](introduce-yourself/IntroduceYourself.cs)
 -  [05 - TwoNumbers](two-numbers/TwoNumbers.cs)
 -  [06 - CodingHours](coding-hours/CodingHours.cs)

### Variables

#### Creating different variables for each type

```csharp
using System;

namespace PracticeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // string
            string greeting = "Hello my friend";
            Console.WriteLine(greeting);

            // boolean
            bool running = true;
            Console.WriteLine(running);

            // whole number
            int a = 11;
            Console.WriteLine(a);

            // floating point number
            double pi = 3.141592;
            Console.WriteLine(pi);

            // declaring a variable
            int number;

            // assigning a variable, (define its value)
            number = 12;

            // mutate a variable, (redefine its value)
            number = 23;

            Console.ReadLine();
        }
    }
}

```

#### Arithmetic Assignment Operators

```csharp
using System;

namespace PracticeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            a += 4;
            // prints 16
            Console.WriteLine(a);

            int b = 12;
            b -= 4;
            // prints 8
            Console.WriteLine(b);

            int c = 12;
            // prints 12
            Console.WriteLine(c++);
            // prints 13
            Console.WriteLine(c);

            int d = 12;
            // prints 13
            Console.WriteLine(++d);
             // prints 13
            Console.WriteLine(d);

            int e = 12;
            // prints 12
            Console.WriteLine(e--);
            // prints 11
            Console.WriteLine(e);

            int f = 12;
            // prints 11
            Console.WriteLine(--f);
             // prints 11
            Console.WriteLine(f);

            int g = 12;
            g *= 3;
            // prints 36
            Console.WriteLine(g);

            int h = 12;
            h /= 3;
            // prints 4
            Console.WriteLine(h);

            int i = 12;
            i %= 7;
            // prints 5
            Console.WriteLine(i);

            Console.ReadLine();
        }
    }
}
```

#### Exercises
 -  [07 - FavoriteNumber](favorite-number/FavoriteNumber.cs)
 -  [08 - Swap](swap/Swap.cs)
 -  [09 - Bmi](bmi/Bmi.cs)
 -  [10 - DefineBasicInfo](define-basic-info/DefineBasicInfo.cs)
 -  [11 - VariableMutation](variable-mutation/VariableMutation.cs)
 -  [12 - Cuboid](cuboid/Cuboid.cs)
 -  [13 - SecondsInADay](seconds-in-a-day/SecondsInADay.cs)

### User input (scanner)

```csharp
namespace PracticeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user what is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, " + name);
            Console.WriteLine("How old are you? ");

            string age = Console.ReadLine();
            Console.WriteLine(age + " is a nice age");

            Console.ReadLine();

        }
    }
}
```
#### Exercises
 -  [14 - HelloUser](hello-user/HelloUser.cs)
 -  [15 - MileToKmConverter](mile-to-km-converter/MileToKmConverter.cs)
 -  [16 - AnimalsAndLegs](animals-and-legs/AnimalsAndLegs.cs)
 -  [17 - AverageOfInput](average-of-input/AverageOfInput.cs)

### Conditionals

```csharp
using System;

namespace PracticeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 13;

            if (a == 13)
            {
                // this block will run
                Console.WriteLine("Yaaay! The value of the \"a\" variable is 13");
            }

            if (a == 8)
            {
                // this block will NOT run
                Console.WriteLine("Yaaay! The value of the \"a\" variable is 8");
            }


            int b = 20;

            if (b < 10)
            {
                // this block will NOT run
                Console.WriteLine("Yaaay! The value of the \"b\" variable is lower than 10");
            }
            else
            {
                // this block will run
                Console.WriteLine("Yaaay! The value of the \"b\" variable is higher than 10");
            }


            int c = 15;

            if (c < 10)
            {
                // this block will NOT run
                Console.WriteLine("Yaaay! The value of the \"b\" variable is lower than 10");
            }
            else if (c < 20)
            {
                // this block will run
                Console.WriteLine("Yaaay! The value of the \"b\" variable is higher than 10 but less then 20");
            }
            else
            {
                // this block will NOT run
                Console.WriteLine("Yaaay! The value of the \"b\" variable is higher than 10");
            }


            bool thirsty = true;
            bool hungry = false;

            if (thirsty && hungry)
            {
                Console.WriteLine("Lunch time!");
            }
            else if (thirsty || hungry)
            {
                Console.WriteLine("Snack time!");
            }
            else
            {
                Console.WriteLine("No food for you, little fatty.");
            }

            Console.ReadLine();
        }
    }
}

```

#### Exercises

 -  [18 - OddEven](odd-even/OddEven.cs)
 -  [19 - OneTwoALot](one-two-a-lot/OneTwoALot.cs)
 -  [20 - PrintBigger](print-bigger/PrintBigger.cs)
 -  [21 - PartyIndicator](party-indicator/PartyIndicator.cs)
 -  [22 - ConditionalVariableMutation](conditional-variable-mutation/ConditionalVariableMutation.cs)

### Switch statement

```csharp
using System;

namespace PracticeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select coffee size: 1=small, 2=medium, 3=large");
            string input = Console.ReadLine();
            int price = 0;

            switch (input)
            {
                case "1":
                case "small":
                    price = 5;
                    break;
                case "2":
                case "medium":
                    price = 7;
                    break;
                case "3":
                case "large":
                    price = 9;
                    break;
                default:
                    Console.Error.WriteLine("Invalid size. Please try again.");
                    return;
            }

            Console.WriteLine($"Price: ${price}");
        }
    }
}
```

#### Exercises
 -  [36 - Calculator](calculator/Calculator.cs)

### Loops

```csharp
using System;

namespace PracticeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("while loop");
            int a = 0;
            while (a < 10)
            {
                Console.WriteLine(a++);
            }

            Console.WriteLine("\n\n do while loop:");
            int b = 0;
            do
            {
                Console.WriteLine(b++);
            } while (b < 10);

            Console.WriteLine("\n\n for loop:");
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
```

#### Exercises

 -  [23 - IWontCheatOnTheExams](i-wont-cheat-on-the-exams/IWontCheatOnTheExams.cs)
 -  [24 - PrintEven](print-even/PrintEven.cs)
 -  [25 - MultiplicationTable](multiplication-table/MultiplicationTable.cs)
 -  [26 - CountFromTo](count-from-to/CountFromTo.cs)
 -  [27 - FizzBuzz](fizz-buzz/FizzBuzz.cs)
 -  [28 - DrawTriangle](draw-triangle/DrawTriangle.cs)
 -  [29 - DrawPyramid](draw-pyramid/DrawPyramid.cs)
 -  [30 - DrawDiamond](draw-diamond/DrawDiamond.cs)
 -  [31 - DrawSquare](draw-square/DrawSquare.cs)
 -  [32 - DrawDiagonal](draw-diagonal/DrawDiagonal.cs)
 -  [33 - GuessTheNumber](guess-the-number/GuessTheNumber.cs)
 -  [34 - ParametricAverage](parametric-average/ParametricAverage.cs)
 -  [35 - DrawChessTable](draw-chess-table/DrawChessTable.cs)
 -  [Find the substring](substr/SubStr.cs)
