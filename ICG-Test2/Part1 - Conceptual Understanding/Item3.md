# Part 1: Conceptual Understanding
> *Answer each question in your own words. Provide examples where helpful.*

### 3. IEnumerable<T> and Deferred Execution
   What does deferred execution mean in the context of LINQ? Write a short LINQ query that
   demonstrates this behavior. Explain at what moment the query actually runs. 
   
*Answer:*

---
Deferred execution in LINQ means that the query is not executed immediately when it’s defined, but only when you actually 
iterate over the results. 
In other words, LINQ just builds a query definition first, and only runs it when you enumerate it. 
For example with:
- foreach, 
- .ToList(), 
- .Count(), 
- etc.
---
An example of this behavior could be showcased in the following code:

```csharp
var numbers = new List<int> { 1, 2, 3, 4 };

var query = numbers.Where(x =>
{
    Console.WriteLine($"Filtering {x}");
    return x > 2;
});

// No output yet — query not executed

numbers.Add(5);

foreach (var n in query)
{
    Console.WriteLine($"Result: {n}");
}
```
---
> LINQ queries using IEnumerable<T> are executed lazily, meaning they run only when you enumerate them, not when you define them.