## REFERENCE FUNDAMENTALS

Classes are reference types. That means that when we create a new instance of a class and store it in a variable, the variable is a reference to the object.

You can imagine references like directions to a house: they tell you where to find the house, but they are not the house itself!

---
## References vs. Values
To better grasp the idea of reference types, let’s look at the other kind of type: value types. While reference-type variables refer to a place in memory, value-type variables hold the actual data.

`int` is a value type, so the variable `num` holds the value 6: `int num = 6;`


Reference types, on the other hand, refer to a location in memory. Every class is a reference type, so the variable `diss` refers to a location in memory that has the `Dissertation `object:
`Dissertation diss = new Dissertation(50);`


Every “primitive” data type is a value type, including:

- `int`
- `double`
- `bool`
- `char`

Revisiting our metaphor: a reference is like directions to a house, which “points” to a house. It isn’t the actual house. A value type is the house itself!


While reference-type variables refer to a place in memory, value-type variables hold the actual data.

---
## Reference vs. Value Comparison
When we compare value types with ==, the C# compiler performs a value comparison. For example, this prints true because the value 6 is equal to the value 6:

```
int int1 = 6;
int int2 = 6;
Console.WriteLine(int1 == int2);
// Output: true
```


When we compare reference types with `==`, the C# compiler performs a referential comparison, which means it checks if two variables refer to the same memory location. For example, this prints `false `because `d1` and `d2` refer to two different locations in memory (even though they contain objects with the same values):

```
Dissertation d1 = new Dissertation(50);
Dissertation d2 = new Dissertation(50);
Console.WriteLine(d1 == d2);
// Output: false
```

We constructed two different `Dissertation` objects which happened to have the same values. Each reference (`d1` and `d2`) point to different objects, so they are not equal.

---
## References of Different Types

Before going any further, let’s remind ourselves that `Dissertation `implements `IFlippable`, which has the `CurrentPage` property and `Flip() `method. You’ll need this info in a minute.

In our previous example both references to the `Dissertation` object were of type `Dissertation`:

```
Dissertation diss1 = new Dissertation();
Dissertation diss2 = diss1;
```

Whenever we use `diss1` and `diss2` we can handle the `Dissertation` object as if it were a `Dissertation `type. Since `Dissertation `also implements the `IFlippable` interface, we can reference it that way too:

```
Dissertation diss = new Dissertation(50);
IFlippable fdiss = diss;
```

Now diss and fdiss refer to the same object, but fdiss is an IFlippable reference, so it can ONLY use IFlippable functionality:

```
diss.Flip();
fdiss.Flip();
Console.WriteLine(diss.Define());
// This causes an error!
Console.WriteLine(fdiss.Define());
```

This last line causes an error because `Define()` is not a method in the `IFlippable` interface. The other lines do NOT cause errors because they use members that both `IFlippable` and `Dissertation` have.

This rule also applies to base classes too, so we can refer to a `Dissertation` object as `Book`.

```
Dissertation diss = new Dissertation(50);
Book bdiss = diss;
Console.WriteLine(diss.Title);
Console.WriteLine(bdiss.Title);
diss.Define();
// This causes an error!
bdiss.Define();
```

Title is defined for` Book`, so no error is thrown there. `Define()`, however, is not defined for the `Book` class, so we can’t use it with `Book` references.
