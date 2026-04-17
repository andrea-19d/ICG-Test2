# Part 1: Conceptual Understanding
> *Answer each question in your own words. Provide examples where helpful.*

### 5. Interfaces vs Abstract Classes
When would you choose to define an interface rather than an abstract class? Provide a 
concrete example from a real-world application (e.g., logging, payment processing).

*Answer:*

---
You use an interface when you only want to define what something should do, not how it does it. It’s just a contract.

You use an abstract class when you want to share some common logic between classes, not just define methods.

---
I would choose to implement an interface when different classes might behave very differently, but still need the same methods.
Also, in C#, a class can implement multiple interfaces but can only inherit one class, so interfaces give more flexibility.

For example a payment processing 

```csharp
public interface IPaymentProcessor
{
    void Pay(decimal amount);
}
```

```csharp
class PayPalProcessor : IPaymentProcessor
{
    public void Pay(decimal amount)
    {
        Console.WriteLine("Paid with PayPal");
    }
}

class StripeProcessor : IPaymentProcessor
{
    public void Pay(decimal amount)
    {
        Console.WriteLine("Paid with Stripe");
    }
}
```
> Each one works differently, but they all follow the same contract.

