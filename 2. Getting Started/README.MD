# **C# - Getting Started** <!-- omit in toc -->

1. [**Project**](#project)
2. [**Solution**](#solution)
3. [**Create a Project**](#create-a-project)
4. [**Run a Project**](#run-a-project)
5. [**Naming Convention**](#naming-convention)
6. [**Console Methods**](#console-methods)
7. [**DataTypes in C#**](#datatypes-in-c)
   1. [**Integer Types**](#integer-types)
      1. [**Signed Integers**](#signed-integers)
      2. [**Unsigned Integers**](#unsigned-integers)
      3. [**Native**](#native)
   2. [**Decimal Types**](#decimal-types)
   3. [**Other Types**](#other-types)
8. [**Variables in C#**](#variables-in-c)
9. [**Type Inference**](#type-inference)
10. [**Array**](#array)
11. [**String Representation**](#string-representation)
12. [**Comments**](#comments)
13. [**Function in C#**](#function-in-c)
14. [**Access Modifiers in C#**](#access-modifiers-in-c)
    1. [**Types of Assess Modifiers**](#types-of-assess-modifiers)
       1. [**Private**](#private)
       2. [**Protected**](#protected)
       3. [**Public**](#public)
       4. [**Internal**](#internal)
       5. [**Protected Internal**](#protected-internal)
       6. [**Private Protected**](#private-protected)
15. [**Namespace in C#**](#namespace-in-c)
16. [**Recognizing constructs in Program**](#recognizing-constructs-in-program)
17. [**Refactoring Code with Visual Studio**](#refactoring-code-with-visual-studio)
18. [**Top Level Statements**](#top-level-statements)
19. [**Global Using**](#global-using)
20. [**Debugging Code with Visual Studio**](#debugging-code-with-visual-studio)
    1. [**Steps**](#steps)
21. [**Visual Studio Features**](#visual-studio-features)
    1. [**Automated Tools**](#automated-tools)
    2. [**Shortcuts**](#shortcuts)

## **Project**

- A project is a collection of files that make up your application.
- It generates a single assembly.

## **Solution**

- A solution is a collection of projects that make up your application.
- It keeps tracks of projects that are dependent on each other.

## **Create a Project**

1. Open Visual Studio.
2. Click on `Create a new project`.
3. Search for `Console Application` template.
4. Enter the name of your project. eg. `MyFirstProgram`
5. Select the .Net framework to be used.
6. Check the `Do not use top-level declarations` checkbox. (If you are on .Net 6 or above)
7. Click on `Create`.
8. A new project will be created with a `Program.cs` file.

```cs
using System;

namespace MyFirstProgram
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }
}
```

## **Run a Project**

1. Click on the `Run` button on the top menu bar.
2. Or press `Ctrl + F5` to run the project without debugging.
3. You will see the output in the `Output` window.

## **Naming Convention**

- Use `PascalCase` for naming classes, methods.
- Use `camelCase` for naming variables, parameters.
- Use `ALL_CAPS` for naming constants.
- Use `PascalCase` for naming files, folders, projects, solutions.

## **Console Methods**

- `Console.WriteLine()` - Writes a line of text to the console.
- `Console.Write()` - Writes text to the console.
- `Console.ReadLine()` - Reads a line of text from the console.
- `Console.ReadKey()` - Reads a key from the console.

```cs
Console.WriteLine("Hello World!");
Console.Write("Hello World!");
Console.ReadLine();
Console.ReadKey();
```

## **DataTypes in C#**

- C# is a strongly typed language.

### **Integer Types**

- An integer is a whole number that can be positive, negative, or zero.
- The size of an integer is measured in bits.
- The range of an integer is the set of values that can be stored in that integer.

#### **Signed Integers**

- Signed integers can store both positive and negative values.
- The first bit of a signed integer is used to store the sign of the integer.
- The remaining bits are used to store the magnitude of the integer.

| C# Type | .Net Type | Size (bits) | Range                                 |
| ------- | --------- | ----------- | ------------------------------------- |
| sbyte   | SByte     | 8           | -128 to 127                           |
| short   | Int16     | 16          | -32,768 to 32,767                     |
| int     | Int32     | 32          | -2<sup>31</sup> to 2<sup>31 - 1</sup> |
| long    | Int64     | 64          | -2<sup>63</sup> to 2<sup>63 - 1</sup> |

#### **Unsigned Integers**

- Unsigned integers can store only positive values.
- All the bits of an unsigned integer are used to store the magnitude of the integer.

| C# Type | .Net Type | Size (bits) | Range                   |
| ------- | --------- | ----------- | ----------------------- |
| byte    | Byte      | 8           | 0 to 255                |
| ushort  | UInt16    | 16          | 0 to 65,535             |
| uint    | UInt32    | 32          | 0 to 2<sup>32 - 1</sup> |
| ulong   | UInt64    | 64          | 0 to 2<sup>64 - 1</sup> |

#### **Native**

- Native integers are the fastest integers.
- Native integers are the default integers in C#.
- Depends on the platform i.e. 32-bit or 64-bit.
- Their size is the same as the size of the processor register i.e. 32 bits on a 32-bit processor and 64 bits on a 64-bit processor.
- Useful for low-level programming.

| C# Type | .Net Type | Size (bits) | Range                                 | Type of Processor | Signed/Unsigned |
| ------- | --------- | ----------- | ------------------------------------- | ----------------- | --------------- |
| nint    | IntPtr    | 32          | -2<sup>31</sup> to 2<sup>31 - 1</sup> | 32-bit            | Signed          |
| nuint   | UIntPtr   | 32          | 0 to 2<sup>32 - 1</sup>               | 32-bit            | Unsigned        |

### **Decimal Types**

- Floating point types are used to store real numbers.
- The size of a floating point type is measured in bits.
- The range of a floating point type is the set of values that can be stored in that floating point type.
- C# treats any number eg. `1.8` as a `double` by default.

| C# Type | .Net Type | Size (bits) | Range                                             | Precision              |
| ------- | --------- | ----------- | ------------------------------------------------- | ---------------------- |
| float   | Single    | 32          | -3.4 x 10<sup>38</sup> to 3.4 x 10<sup>38</sup>   | 6-8 digits precision   |
| double  | Double    | 64          | -1.7 x 10<sup>308</sup> to 1.7 x 10<sup>308</sup> | 15-17 digits precision |
| decimal | Decimal   | 128         | -7.9 x 10<sup>28</sup> to 7.9 x 10<sup>28</sup>   | 28-29 digits precision |

### **Other Types**

| C# Type | .Net Type | Size (bits) | Range                                           | Description            |
| ------- | --------- | ----------- | ----------------------------------------------- | ---------------------- |
| char    | Char      | 16          | U+0000 to U+ffff                                | UTF-16 Unicode         |
| string  | String    | 16          | 0 to approximately 2 billion Unicode characters | Sequence of characters |
| bool    | Boolean   | 8           | True or False                                   | True or False          |

## **Variables in C#**

- A variable is a name given to a storage location in memory.
- A variable can be assigned a value of a particular type.

```cs
int age = 30;
```

- `int` is the type of the variable.
- `age` is the name of the variable.
- `=` is the assignment operator.
- `30` is the value assigned to the variable.
- `;` is the statement terminator.

## **Type Inference**

- The type of a variable can be explicitly specified or it can be inferred by the compiler.
- Type inference is useful when the type of a variable is obvious from the value assigned to it.
- `var` is used to declare a variable whose type is inferred by the compiler.
- It cannot be used to declare fields, parameters, return types, or local variables initialized to null.

```cs
var age = 30;
```

## **Array**

- An array is a data structure that stores a collection of values of the same type.
- We can access an element of an array using its index (Index starts with 0).
- Adding `[]` after the type name makes it an array of that type.
- Values in an array can be declared and initialized in the same statement.

```cs
int[] numbers = { 1, 2, 3 };

Console.WriteLine(numbers[0]); // 1
```

## **String Representation**

- `""` - String literal. Used to represent a single line string.
- `@""` - Verbatim string literal. Used to represent a single/multi line string.
- `$""` - Interpolated string literal. Used to inject values into a string.

```cs
string name = "John";
string path = @"C:\Users\John";
string message = $"Hello {name}";

Console.WriteLine("Name: " + name);   // String concatenation
Console.WriteLine("Name: {0}", name); // String formatting
```

## **Comments**

- Comments are used to explain the code.
- Comments are ignored by the compiler and only used by the developers.
- There are two types of comments in C#.
  - Single-line comments
  - Multi-line comments
  - Documentation comments

```cs
// This is a single-line comment

/*
This is a
multi-line comment
*/

/// <summary>This is a <i>documentation</i> comment</summary>
```

## **Function in C#**

- C# doesn't have `functions`, it has `methods`.
- Methods can be static or non-static.
- Methods are defined inside a class.
- Static methods can be called without creating an instance of the class.
- Methods may or may not take parameters.
- Methods may or may not return a value.
  - `void` is used to specify that a method doesn't return a value.

```cs
class Temperature
{
  static float FahrenheitToCelsius(float temperatureFahrenheit)
  {
    float temperatureCelsius = (temperatureFahrenheit - 32) / 1.8f;
    return temperatureCelsius;
  }
}

// Calling a static method
float temperatureCelsius = Temperature.FahrenheitToCelsius(68);
```

## **Access Modifiers in C#**

- Controls which objects/variables/constants/methods can be accessed in which part of the code.

### **Types of Assess Modifiers**

#### **Private**

- Default access modifier.
- Most restricted.
- Only accessible within the same class, struct or where they are declared.
- Trying to access them outside will give a compile-time error.

```cs
private int variableA = 5;
int variableB = 10;
```

#### **Protected**

- Slightly restricted.
- Only accessible in derived instance of the class.

```cs
protected int variableA = 5;
```

#### **Public**

- Unrestricted.
- Default for enums and interfaces.
- Also means they are least secure and code is exposed to outside world.

```cs
public int variableA = 5;
```

#### **Internal**

- Accessible within the same assembly (.dll) and not in the projects referencing it.

```cs
internal int variableA = 5;
```

#### **Protected Internal**

- Combines advantages of protected and internal.
- They can be protected or internal.
- Used to protect objects in other assemblies and not in the same assemblies.

#### **Private Protected**

- Combines advantages of private and protected.
- Used to restrict objects even in derived classes in other assemblies.

```code
-----------------------------------------------------------------------------------------------------------
|                    |              Same Assembly                     | Different Assembly                |
| Access Modifiers   | ---------------------------------------------- | --------------------------------- |
|                    | Same Class | Derived Class | Non Derived Class | Derived Class | Non Derived Class |
| ------------------ | ---------- | ------------- | ----------------- | ------------- | ----------------- |
| Private            | Yes        | No            | No                | No            | No                |
| Protected          | Yes        | Yes           | No                | Yes           | No                |
| Public             | Yes        | Yes           | Yes               | Yes           | Yes               |
| Internal           | Yes        | Yes           | Yes               | No            | No                |
| Protected Internal | Yes        | Yes           | Yes               | Yes           | No                |
| Private Protected  | Yes        | Yes           | No                | No            | No                |
-----------------------------------------------------------------------------------------------------------
```

## **Namespace in C#**

- A namespace is a container for related classes.
- It is used to organize code and prevent name clashes.
- A namespace can contain other namespaces.
- A namespace can span multiple files.
- By default the name of the namespace is the same as the name of the project.
- Usually namespace are given company/organization names in real-world applications.

```cs
// MyLibrary.cs
namespace MyNameSpace
{
  class MyClass
  {
    public static void MyFunction()
    {
      // Do Something
    }
  }
}
```

```cs
// Program.cs
class Program
{
  static void Main(string[] args)
  {
    MyNameSpace.MyClass.MyFunction();
  }
}
```

- Classes from the namespace can also be used directly without mentioning the namespace name every time you need to use it with `using`.

```cs
using MyNameSpace;

MyClass.MyFunction();
```

## **Recognizing constructs in Program**

```cs
using System;

namespace MyFirstProgram
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }
}
```

- `using System;`
  - This is a `using directive`.
  - It tells the compiler to use the `System` namespace.
- `namespace MyFirstProgram`
  - This is a `namespace`.
  - It is a container for related classes.
- `class Program`
  - This is a `class`.
  - It is a container for related methods.
- `static void Main(string[] args)`
  - This is a `method`.
  - It is a container for related statements.
  - C# programs start executing from the `Main` method.
  - `static` - This is a `modifier`.
  - `void` - This is a `return type`.
  - `Main` - This is the name of the method.
  - `string[] args` - This is a `parameter` of the method which is an `array` of type `string`.
- `Console.WriteLine("Hello World!");`
  - This is a `statement`.
  - It performs an action.
  - `Console` - This is a `class` in the `System` namespace.
  - `WriteLine` - This is a `method` in the `Console` class.
  - `"Hello World!"` - This is a `string` literal used as an argument to the `WriteLine` method.

## **Refactoring Code with Visual Studio**

- Refactoring is the process of changing the structure of the code without changing its behavior.
- This is done to make the code more readable and maintainable.

1. Open the file you want to refactor.
2. Select the code you want to refactor.
3. Right-click on the selected code.
4. Click on `Quick Actions and Refactorings`.
5. Select the refactoring you want to perform.
6. Or press `Ctrl + .` to open the `Quick Actions and Refactorings` menu.

```cs
// Before refactoring
static float FahrenheitToCelsius(float temperatureFahrenheit)
{
  float temperatureCelsius = (temperatureFahrenheit - 32) / 1.8f;
  return temperatureCelsius;
}

// After refactoring with inline variable
static float FahrenheitToCelsius(float temperatureFahrenheit)
{
  return (temperatureFahrenheit - 32) / 1.8f;
}

// After refactoring with inline method
static float FahrenheitToCelsius(float temperatureFahrenheit) => (temperatureFahrenheit - 32) / 1.8f;
```

```cs
// Before refactoring
Console.WriteLine("Comfort Index of: " + location + ": " + ComfortIndex(temperatureFahrenheit, humidity));

// After refactoring with string interpolation
Console.WriteLine($"Comfort Index of: {location}: {ComfortIndex(temperatureFahrenheit, humidity)}");
```

## **Top Level Statements**

- Makes the program structure flat.
- This allows you to skip the things like `namespaces` and `classes`.

```cs
using System;

Console.WriteLine("Hello World");
```

## **Global Using**

- Allows to skip adding `using` statements which are common in multiple files.
- Allows you to add global imports which are accessible in every file.

```cs
Console.WriteLine("Hell World");
```

## **Debugging Code with Visual Studio**

- Debugging is the process of finding and fixing bugs in the code.
- It is done to make sure the code is working as expected.
- Breakpoints are used to pause the execution of the program at a particular line.

### **Steps**

1. Make sure that your solution configuration is set to `Debug`.
2. Click on the line number where you want to add a breakpoint. (A red dot will appear)
3. Click on the `Run` button on the top menu bar or press `F5` to run the project with debugging.
4. The program will pause at the breakpoint.

---

- Use `Step Over` (F10) button to execute the current line and move to the next line.
- Use `Step Into` (F11) button to execute the current line and move to the next line. If the current line is a method call, it will move to the first line of the method.
- Use `Step Out` (Shift + F11) button to execute the current method and move to the next line in the calling method.
- Use `Continue` button to continue the execution of the program until the next breakpoint is encountered.
- Use `Stop` button to stop the execution of the program.

---

- Use `Output` window to view the output of the program.
- Use `Watch` window to view the values of variables.
- Use `Locals` window to view the values of local variables.
- Use `Call Stack` window to view the current call stack.
- Use `Immediate` window to execute code during debugging.
- Use `Breakpoints` window to view and manage breakpoints.

## **Visual Studio Features**

### **Automated Tools**

- Autocomplete (IntelliSense)
- Autocorrect (Quick Actions and Refactorings)
- Code Navigation (Go to Definition, Peek Definition, Find All References)
- Smart Debugging (Breakpoints, Step Into, Step Over, Step Out, Continue, Stop)
- Refactoring
- Code Generation (Constructors, Properties, Methods, Fields, etc.)

### **Shortcuts**

- `Ctrl + .` - Quick Actions and Refactorings
- `Ctrl + K, Ctrl + D` - Format Document
- `Ctrl + K, Ctrl + C` - Comment Selection
- `Ctrl + K, Ctrl + U` - Uncomment Selection
- `Ctrl + Space` - IntelliSense
- `Ctrl + F11`
- `F12` - Go to Definition
- `Ctrl + F12` - Go to Definition
- `Ctrl + R + R` - Rename
