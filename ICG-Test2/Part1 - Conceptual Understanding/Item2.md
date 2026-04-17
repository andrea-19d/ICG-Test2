# Part 1: Conceptual Understanding
> *Answer each question in your own words. Provide examples where helpful.*

### 2. Const vs readonly
What is the difference between a const field and a readonly field? Give a scenario where
using const would be inappropriate and readonly would be required.

*Answer:*

---
The key difference between const and readonly is when the value is assigned and how flexible it is.

A *const field* is a compile-time constant. Its value must be known at compile time and is implicitly static. You can’t 
change it anywhere, not even in a constructor.

A *readonly field* is assigned at runtime, but only once. You can set it either at declaration or inside the constructor. 
After that, it becomes immutable.
---
A great example showcasing where the const and readonly field can be instantiated are in the following example:

```csharp
class Example
{
    public const int MaxValue = 100; // compile-time constant

    public readonly int MinValue;

    // Constructor 
    public Example(int min)
    {
        MinValue = min; // assigned at runtime
    }
}
```
---
### When const is inappropriate:
In the example below you cannot use const because the Environment.GetEnvironmentVariable() is evaluated at runtime, not 
compile time.

```csharp
class Config
{
    public readonly string ConnectionString;

    public Config()
    {
        ConnectionString = Environment.GetEnvironmentVariable("DB_CONN");
    }
}
```