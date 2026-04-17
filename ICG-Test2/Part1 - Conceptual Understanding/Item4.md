# Part 1: Conceptual Understanding
> *Answer each question in your own words. Provide examples where helpful.*


### 4. Exception Handling Best Practices
   You encounter the following pattern in code:
```csharp
    catch (Exception ex)
    {
        throw ex;
    }
```
What is wrong with this? What should be written instead, and why? 

*Answer:*

---
The problem with this code is that it loses the original error location. When you use throw ex, the stack trace 
gets reset, so it looks like the error happened in the catch block instead of where it actually started.

A better way would be to place only throw so that we can preserve the stack trace. In this way we can see the exact line 
and method where the error occured, thus making it the recommended practice for debugging and logging. 