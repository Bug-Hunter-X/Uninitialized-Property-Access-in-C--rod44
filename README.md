# Uninitialized Property Access in C#

This repository demonstrates a common C# bug: accessing a class member variable before it has been assigned a value.  This can lead to unexpected behavior or runtime exceptions, making debugging challenging.  The `bug.cs` file contains the problematic code, while `bugSolution.cs` provides a corrected version.

**Problem:**
In the `MyClass` class, the `MyProperty` is accessed within the `MyMethod` before it's been explicitly assigned a value.  This results in undefined behavior; the value read will be the default value of the type (0 for `int` in this case), which might not be the intended behavior.

**Solution:**
The solution initializes `MyProperty` either in the constructor or directly before access within `MyMethod`. This ensures that a predictable value is consistently used. 