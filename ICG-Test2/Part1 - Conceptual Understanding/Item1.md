# Part 1: Conceptual Understanding
> *Answer each question in your own words. Provide examples where helpful.*

### 1. Value Types vs Reference Types
   Explain the fundamental difference in memory allocation between a value type
   (e.g., int, struct) and a reference type (e.g., class, string). Provide a short code snippet that
   demonstrates how modifying one variable affects (or does not affect) another variable
   depending on whether it is a value type or reference type. 

*Answer:*
---
The main difference between value types and reference types is how they are stored in memory and how they behave when 
assigned or passed around.

A value type  stores the actual data directly. When you assign it to another variable, it creates a 
copy of the value. So each variable has its own independent data.

A reference type stores a reference, basically an address, to the actual object in memory. When you assign it to another 
variable, both variables point to the same object, so changes through one variable affect the other.
---

Here are some simple examples of code snippets showcasing the difference between how a reference type and a value type store
data.

```csharp
// VALUE TYPE
int a = 10;
int b = a;

b = 20;

Console.WriteLine(a); // 10
Console.WriteLine(b); // 20
```
> In this case, b is a copy of a, so changing b does not affect a.

```csharp
// REFERENCE TYPE
class Person
{
    public string Name;
}

Person p1 = new Person();
p1.Name = "John";

Person p2 = p1;
p2.Name = "Mike";

Console.WriteLine(p1.Name); // Mike
Console.WriteLine(p2.Name); // Mike
```
> Here, p1 and p2 point to the same object in memory, so modifying p2 also changes p1. 
