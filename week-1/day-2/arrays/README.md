# Arrays

## Materials & Resources

| Material                                                              |             Time |
| :-------------------------------------------------------------------- | ---------------: |
| [Introduction to Arrays](https://www.youtube.com/watch?v=7sqUaw4g_iQ) |             9:35 |
| [Arrays](https://www.youtube.com/watch?v=RQ0JHMGiobo)                 | only until 11:10 |
| [Foreach](https://www.youtube.com/watch?v=Vlhcgb9Co4s)                |             7:40 |

### Optional

Additional material, if the above is still unclear.

| Material                                                                     | Time |
| :--------------------------------------------------------------------------- | ---: |
| [Arrays again](https://www.youtube.com/watch?v=3UcJGikWJxs)                  | 7:25 |
| [Jagged/Multidimensional array](https://www.youtube.com/watch?v=T0Zg7kQ3RVE) | 8:11 |

## Material Review

- What is an array? What kind of characteristics does it have?
- How do you *declare* an array?
- How do you set the initial values of an array?
- What is the index of the first element in an array?
- How do you get the total number of elements of an array?
- How do you iterate through the elements of an array? (i.e. go through each
  element one by one)
- How do you sort the elements of an array?
- What is a multi dimensional array?

## Workshop

```c#
using System;

namespace Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 8 };

            // Print the second element of the array
            Console.WriteLine(numbers[1]);

            // Print all the array elements
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.ReadLine();
        }
    }
}
```

### Exercises

- [Third](third/Third.cs)
- [Compare Length](compare-length/CompareLength.cs)
- [Sum elements](sum-elements/SumElements.cs)
- [Change element](change-element/ChangeElement.cs)
- [Increment element](increment-element/IncrementElement.cs)
- [Print all](print-all/PrintAll.cs)
- [Diagonal Matrix](diagonal-matrix/DiagonalMatrix.cs)
- [Double items](double-items/DoubleItems.cs)
- [Colors](colors/Colors.cs)
- [Append a](append-a/AppendA.cs)
- [Swap elements](swap-elements/SwapElements.cs)
- [Sum all elements](sum-all/SumAll.cs)
- [Reverse list](reverse/Reverse.cs)
