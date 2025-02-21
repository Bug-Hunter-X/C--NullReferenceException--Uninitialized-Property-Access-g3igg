# C# NullReferenceException: Uninitialized Property Access

This repository demonstrates a common C# error: a `NullReferenceException` caused by accessing a property that hasn't been initialized.  The `Bug.cs` file shows the problematic code, while `BugSolution.cs` presents a corrected version.

**Problem:**
In C#, if you attempt to use a property of a class before it has been assigned a value, it can result in a `NullReferenceException`.  This often happens with reference types (classes, strings, etc.), where the property defaults to `null`.

**Solution:**
The best way to avoid this is to ensure that the property is always initialized before use. You can do this by:
* Assigning a default value in the property declaration.
* Initializing the property in the class constructor.
* Checking for `null` before accessing the property (although this adds complexity and is less elegant).