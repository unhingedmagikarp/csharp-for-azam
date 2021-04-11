# Object Oriented Programming

## Materials & Resources

### Materials

Before starting the materials do this little exercise:
[Doable homework](homework/README.md)

| Material                                                                          |  Time |
| :-------------------------------------------------------------------------------- | ----: |
| [Classes and Objects](https://www.youtube.com/watch?v=FCjoioi6xvM)                |  4:33 |
| [Object Oriented Programming Basics](https://www.youtube.com/watch?v=0K2EsvAz5Pg) |  8:08 |
| [Fields](https://www.youtube.com/watch?v=jcHBfa36gz0)                             |  3:44 |
| [Constructor](https://www.youtube.com/watch?v=MyWBU6IKl5U)                        |  6:19 |
| [Static vs Non Static](https://www.youtube.com/watch?v=86ymhq54V5k)               | 13:33 |
| [This keyword](https://www.youtube.com/watch?v=m8hRUP1WL28)                       |  2:28 |

### Optional

| Material                                                   |  Time |
| :--------------------------------------------------------- | ----: |
| [Overloading](https://www.youtube.com/watch?v=F9ygaxxbbz4) | 11:17 |
| [Static(reading)][1]                                       |  3:00 |

## Material Review

### Encapsulation

- What is OOP?
  <!--
    OOP is a programming paradigm that is built upon the concept of objects
    that encapsulate data (fields) and behavior (methods). The program is
    built in a way that objects can interact with each other.
  -->
- Do we have other paradigms?
  <!--
    Yes, we have different paradigms. Moreover languages can follow more
    paradigms.
    eg.: functional, procedural etc..
  -->
- Is OOP the best?
  <!--
    No, there is no best paradigm. It depends on the given problem, environment
    and sometimes taste.
    comparison: Stateful - Stateless
  -->
- What is a class?
  <!--
    It is a blueprint. It tells what makes something a "thing".
    The Bird is a class,
      - it tells us that each bird has wings, feet but they don't have any teeth
        or battery
      - they can fly, eat but they can't write or drive a car.
    You can use that blueprint to create different instances of that class.
    Eg.: A white eagle or a black falcon, etc...
    They will behave the same but their properties will differ.
    Think of them as real blueprints: you can build white, red any colored house
    from the same blueprint, you can change even the windows, but the sizes will
    be the same and you can enter the building the same way.
    Since it is one concept, one thing, it always has a singular name!!!
  -->
- What is the constructor?
  <!--
    This will be called when you create a new instance of the class by using the
    new keyword.
    All classes have a default empty constructor w/o any parameters. If you
    want to do something during the instantiation, you have to define your own
    constructor.
    You can define more constructors so your class can be instantiated in
    different ways.
    Usually we assign value to the instance variables, we initialize the
    instance in the constructor. We shouldn't have any side effect in the
    constructor.
  -->
- What does the `this` keyword mean?
  <!--
    It references to the instance.
    You can use it to access its fields and methods.
  -->
- What is the difference between classes and instances?
  <!--
    Person is the class, You are the instance.
    Person is a concept, You are one concrete example of that concept.
  -->
- What are fields, properties?
  <!--
    These are the properties each instance must own. They may have different
    values in each instance.
    Eg.: Each Person has
      - hair color
      - length
      - weight
      - eye color
    These properties hold the attributions of the instance.
  -->
- What are methods?
  <!--
    These are those actions that can be performed by the instance.
    For example a Person can
      - eat(Food)
      - drive(Car)
      - hit(Person)
      - sleep()
    These actions will change the instance's current state or will interact with
    other objects/instances.
  -->
- What are members?
  <!--
    Fields and methods inside classes are often referred to as "Class Members"
  -->
- What is `private` and `public`?
  <!--
    These are access modifiers.
    If you set a property or method to private, it won't be visible for the outer
    world. It is accessible only within the class.
     - You need getters and setters to modify their values
     - Public means there is no restriction on the property, anybody can access it
  -->
- What is encapsulation?
  <!--
    In order to keep the internal consistency of your objects,
    you have to hide their internal state.
      - When a Car is driven, the fuelLevel is decreasing and the runKms is
      increasing. If the runKms would be public you would be able to change it
      without lowering the fuelLevel.
      - If you have a bank account you need a transaction to change the balance.
        If the balance would be public it could be edited without any history.
    Sometimes you want to hide a complex system from the user, because he/she
    doesn't want (and does not need to) to deal with implementation details.
     - You don't know how an ArrayList stores its values. You just call the
       functions on it.
  -->
- How does the SRP come up in OOP?
  <!--
    Single Responsibility Principle means that one thing must do only one thing.
    This is not the right definition but it is a good start.
    In OOP each class must deal with only one topic/responsibility.
    It should not write files and calculate complex logic.
    Indicators of violation may be that the class has too many properties and/or
    methods.
  -->
- What is a class variable?
  <!--
    It is a variable that is defined on the class and cannot be accessed by the instances.
    Remember: there is only one piece of the class.
    By defining a variable on the class we will have only one variable.
    Each instance can use the same value so if one changes it all the other
    instances will have the new value too.
    Eg. A counter which counts how many instances have been created from the
    class.
  -->
- What does the `static` keyword do?
  <!--
    This is how you can create class variables. You can use the "this"
    keyword for methods as well.
  -->
- How can I use classes from other files?
  <!--
    By importing them into your source file with the "using" keyword
  -->

## Workshop

### Data Structure

```csharp
class Bicycle
{
    string cadence;
    int gear;
    int speed;
}
```

```csharp
class FamilyMember
{
    string name;
    int age;
    string surname;
}
```

- [Post-it](post-it/README.md)
- [BlogPost](blog-post/README.md)

### Encapsulation and Constructor

```csharp
using System;

namespace PracticeTask
{
    class Program
    {
        public class Human
        {
            public string Name;
            public int Age;
            public int IQ;

            public Human(string name, int age, int iq)
            {
                Name = name;
                Age = age;
                IQ = iq;
            }

            public bool IsSmart()
            {
                return IQ > 100;
            }

            public bool IsNameLess()
            {
                return Name == "unkown" || Name == "";
            }

            public void BeSmarter()
            {
                IQ += 20;
            }
        }

        static void Main(string[] args)
        {
            var human = new Human("John", 37, 95);

            Console.WriteLine("Is our human nameless? " + human.IsNameLess());
            Console.WriteLine("Our human is {0} and he is {1} old", human.Name, human.Age);
            Console.WriteLine("Is our human smart: " + human.IsSmart());

            human.BeSmarter();
            Console.WriteLine("Is our human smart now? " + human.IsSmart());

            Console.ReadLine();
        }
    }
}
```

- [Animal](animal/README.md)
- [Sharpie](sharpie/README.md)
- [Counter](counter/README.md)

### Use Class

```csharp
using System;

namespace PracticeTask
{
    public class FishTank
    {
        public static int FishCount = 0;

        public string Status;

        public FishTank()
        {
            Status = "There is no fish in the tank!";
        }

        public static void Add()
        {
            FishCount++;
            Console.WriteLine("There is {0} fish in the tank.", FishCount);
        }

        public void HowMuchIsTheFish()
        {
            Console.WriteLine("Hyper! Hyper!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var tank = new FishTank();
            Console.WriteLine(tank.Status);

            FishTank.Add();

            tank.HowMuchIsTheFish();

            Console.ReadLine();
        }
    }
}
```

- [Pokemon](pokemon/Pokemon.cs), [Main](pokemon/Program.cs)
- [Fleet of Things](fleet-of-things/FleetOfThings.cs),
  [Fleet](fleet-of-things/Fleet.cs), [Thing](fleet-of-things/Thing.cs)
- [Dice set](dice-set/DiceSet.cs), [Main](dice-set/Program.cs)
- [Dominoes](dominoes/Dominoes.cs), [Domino](dominoes/Domino.cs)

### Complex Architectures

- [Teachers and Students](teachers-and-students/README.md)
- [Petrol Station](petrol-station/README.md)

### Classes as Fields

```csharp
class Page
{
    public string Content;
}

class Book
{
    List<Page> Pages;

    public Book()
    {
        Pages = new List<Page>();
    }

    public void Add(Page page)
    {
        Pages.Add(page);
    }

    public int CountBlankPages()
    {
        int counter = 0;
        foreach (var page in Pages)
        {
            if (!page.Content.Any())
            {
                counter++;
            }
        }

        return counter;
    }
}
```

- [Sharpie Set](sharpie-set/README.md)
- [Farm](farm/README.md)
- [Blog](blog/README.md)

### All together

- [Pirates](pirates/README.md) *exam*
- Redo the 5 trees homework (with classes)

[1]: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members

![circles](../../assets/azam.gif)
