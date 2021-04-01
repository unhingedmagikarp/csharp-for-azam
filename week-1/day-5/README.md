# File manipulation exercises

## Materials & Resources

| Material                                                                                                              |  Time |
| :-------------------------------------------------------------------------------------------------------------------- | ----: |
| [Very Basic File read and write](https://www.youtube.com/watch?v=kGZD_k1M938)                                         |  5:09 |
| [File read and write](https://channel9.msdn.com/Series/C-Sharp-Fundamentals-Development-for-Absolute-Beginners/while-Iterations-and-Reading-Data-from-a-Text-File-11)                                                                               | 11:38 |
| [using keyword](https://www.youtube.com/watch?v=Dxbbtx-8MKw)                                                          |  5:35 |
| [exceptions](https://www.youtube.com/watch?v=DzUFm2FNeyo)                                                             |  6:56 |
| [exceptions(reading)](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/exceptions/exception-handling) |  3:00 |
| [File read with exception and fun](https://www.youtube.com/watch?v=LkpODZE2vmk)               |  5:26 |
| [Runtime vs Compile time](https://stackoverflow.com/questions/846103/runtime-vs-compile-time) |  1:30 |
| [File read and write advanced](https://www.youtube.com/watch?v=HKqMqFJr4SY)                     | 20:44 |

## Material Review

- `Files`
- `ReadAllLines()` / `ReadAllText()`
- `WriteAllLines()` / `WriteAllText()`
- `StreamWriter`
- `StreamReader`
- `using`
- `Dispose()`
- Compile time error
- Runtime error
- Syntax error
- Semantic error
- Exceptions
- Exception types
- `try`
- `catch`
- `throw`
- `finally`
- `Parse()`
- `@` and `\`

## Workshop

### Exceptions

```c#
using System;

namespace Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            int divisor = int.Parse(Constole.ReadLine());
            // If the input value for divisor was 0 the program breaks
            int result = 12 / divisor;
            // The program doesn't reach this line if the input was 0
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
```

The result if the input value was zero:

```text
Exception unhandled!
System.DivideByZeroException: 'Attempted to divide by zero.'
```

Handle the exception:

```csharp
using System;

namespace Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            try  // Prevents the program breaking when attempting dividing by zero
            {
                int divisor = int.Parse(Console.ReadLine());
                // If the input value for divisor was 0 the program breaks
                int result = 12 / divisor;
                // The program doesn't reach this line if the input was 0
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                // This line only runs if the input was 0
                Console.WriteLine("Can't divide by zero!");
            }
            catch (Exception e)
            {
                // This line only runs if uncatched exception generated
                Console.WriteLine("uuups, some serious thing happened!");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
```

#### Practice

- [Divide by zero](divide-by-zero/DivideByZero.cs)

### Reading files

```csharp
using System;
using System.IO;

namespace Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"./assets/lorem-ipsum.txt";
            try
            {
                // Reads the content from `lorem-ipsum.txt` in the `assets` folder line by line to a string List
                string[] content = File.ReadAllLines(path);
                // Prints the first line of the file
                Console.WriteLine(content[0]);
            }
            catch (Exception)
            {
                Console.WriteLine("Uh-oh, could not read the file!");
            }

            Console.ReadLine();
        }
    }
}
```

#### Practice

- [Print each line](print-each-line/PrintEachLine.cs)
- [Count lines](count-lines/CountLines.cs)

### Writing files

```csharp
using System;
using System.IO;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"./lorem-ipsum.txt";
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("Hello from the file!");
            }
        }
    }
}
```

#### Practice

- [Write single line](write-single-line/WriteSingleLine.cs)
- [Write multiple lines](write-multiple-lines/WriteMultipleLines.cs)
- [Copy file](copy-file/CopyFile.cs)

### Exercises

- [Doubled](decrypt-doubled/Doubled.cs), source file is
  [here](assets/duplicated-chars.txt)
- [Reversed lines](decrypt-reversed-lines/ReversedLines.cs), source file is
  [here](assets/reversed-lines.txt)
- [Reversed order](decrypt-reversed-order/ReversedOrder.cs), source file is
  [here](assets/reversed-order.txt)
- [Logs](logs/Logs.cs), source file is [here](assets/log.txt)
- [Tic-Tac-Toe](tic-tac-toe/TicTacToe.cs), source files are
  [win-o.txt](assets/win-o.txt), [win-x.txt](assets/win-x.txt),
  [draw.txt](assets/draw.txt)
- [Births](birthdates/Births.cs), source file is [here](assets/births.csv)
- [Encoded lines](decrypt-encoded/EncodedLines.cs), source file is
  [here](assets/encoded-lines.txt)
- [Lottery](lottery/Lottery.cs), source file is [here](assets/lottery.csv)
- [Licence Plate](create-licence-plate/licence-plate.md), source file is [here](assets/words.txt)
