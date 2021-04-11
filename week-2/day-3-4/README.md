# Recursion

What happens when a function calls itself?

## Materials & Resources

| Material                                                                   |      Time |
| :------------------------------------------------------------------------- | --------: |
| [What on Earth is Recursion?](https://www.youtube.com/watch?v=Mv9NEXX1VHc) | till 8:40 |
| [Algorithms: Recursion](https://www.youtube.com/watch?v=KEEKn7Me-ms)       |      5:40 |
| [C# Recursion](https://www.youtube.com/watch?v=wXvJSv3lS1c)                |     16:41 |
| [Fractals](https://www.youtube.com/watch?v=WFtTdf3I6Ug)                    |      4:12 |

### Optional

*If you've got time and/or want to dig deeper, consider the following:*

| Material                                                                    |  Time |
| :-------------------------------------------------------------------------- | ----: |
| [Hanoi-tower](https://www.youtube.com/watch?v=5_6nsViVM00)                  |  7:18 |
| [Benoit BM Mandelbrot: Fractals and the art of roughness][art-of-roughness] | 17:09 |

## Material Review

- Recursion
- Base case

## Workshop

### Factorial with loop

```c#
public static int FactorialWithLoop(int n)
{
    int factorial = 1;
    for (int i = 1; i  < n + 1; i++)
    {
      factorial *= i;
    }
    return factorial;
}
```

### Factorial with recursion

```c#
public static int FactorialWithRecursion(int n)
{
    if (n == 1)
    {
        return 1;
    }
    else
    {
        return n * FactorialWithRecursion(n - 1);
    }
}
```

### Exercises

- [Number adder](numberadder/README.md)
- [Sumdigit](sumdigit/README.md)
- [Power](power/README.md)
- [Bunnies](bunnies/README.md)
- [Bunnies again](bunnies2/README.md)
- [Strings](strings/README.md)
- [Strings again](strings2/README.md)
- [Strings again and again](strings3/README.md)
- [Fibonacci](fibonacci/README.md)
- [Maximum finder](maximum/README.md)
- [Greatest Common Divisor](greatest-common-divisor/README.md)
- [Max Sum](maxsum/README.md)

### Replicate these

- ![squares](assets/squares.png)
- Hexagons\
  ![hexagons](assets/hexagons.png)

[art-of-roughness]: https://www.ted.com/talks/benoit_mandelbrot_fractals_the_art_of_roughness?language=en

![circles](../../assets/azam.gif)
