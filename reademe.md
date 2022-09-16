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