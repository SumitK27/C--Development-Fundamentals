# **Type System in C#** <!-- omit in toc -->

1. [**Data Types**](#data-types)
   1. [**Value Data Types**](#value-data-types)
   2. [**Reference Data Types**](#reference-data-types)
   3. [**Predefined Types**](#predefined-types)
   4. [**Custom Types**](#custom-types)
2. [**Type Conversion**](#type-conversion)
   1. [**Implicit Conversion**](#implicit-conversion)
   2. [**Explicit Conversion**](#explicit-conversion)
      1. [**Casting**](#casting)
      2. [**Helpers**](#helpers)
3. [**Typing**](#typing)
   1. [**Implicit**](#implicit)
   2. [**Explicit**](#explicit)
4. [**Default Values**](#default-values)
5. [**Members of Permeative Types**](#members-of-permeative-types)
   1. [**Integers and Doubles**](#integers-and-doubles)
   2. [**Character**](#character)
   3. [**DateTime**](#datetime)
   4. [**TimeSpan**](#timespan)
   5. [**String**](#string)
      1. [**Declaration**](#declaration)
      2. [**Members**](#members)
      3. [**Concatenation**](#concatenation)
      4. [**Escaping**](#escaping)
      5. [**Verbatim**](#verbatim)
      6. [**Compare**](#compare)
      7. [**Immutability**](#immutability)
      8. [**String Builder**](#string-builder)
      9. [**Parsing**](#parsing)
         1. [**TryParse**](#tryparse)
6. [**Methods**](#methods)
   1. [**Declaration**](#declaration-1)
   2. [**Overloading**](#overloading)
7. [**Passing Parameter Values**](#passing-parameter-values)
   1. [**By Value**](#by-value)
   2. [**By Reference**](#by-reference)
      1. [**Ref**](#ref)
      2. [**Out**](#out)
   3. [**Params**](#params)
   4. [**Optional Parameters**](#optional-parameters)
   5. [**Named Arguments**](#named-arguments)
8. [**Expression-bodied Syntax**](#expression-bodied-syntax)
9. [**Common Type System (CTS)**](#common-type-system-cts)
10. [**Custom Types**](#custom-types-1)
    1. [**Adding Custom Types (Packages)**](#adding-custom-types-packages)
11. [**Base Class Library**](#base-class-library)
12. [**Types in CTS**](#types-in-cts)
    1. [**Enumeration**](#enumeration)
       1. [**Default Values**](#default-values-1)
       2. [**Explicit Values**](#explicit-values)
    2. [**Structure**](#structure)
    3. [**Class**](#class)
    4. [**Interface**](#interface)
    5. [**Delegate**](#delegate)

## **Data Types**

- C# is a strongly typed language.
- Types are the building blocks of C# programs.
- Types can be see in a simplest variable declaration to a complex class.
- Every variable has a type.
- Expression too returns value of a type.
- Compiler ensures that once a type is defined it remains the same throughout the program.
- Data Type controls where the data should be stored and how much memory should be allocated to it.
- Data Type also mentions the range of values that can be stored in the variable.
- Operations are also dependent on the Data Type.
- All data types are derived from `System.Object` class.

### **Value Data Types**

- Value Data Types are stored in the stack.
- Variables created with Value Data Types directly contain the value.
- Predefined:
  - Integer
  - Boolean
  - Float
  - Double
- User Defined:
  - Struct
  - Enum
  - Tuple

### **Reference Data Types**

- Reference Data Types are stored in the heap.
- They contains the reference to the value.
- Predefined:
  - String
  - Array
  - Object
- User Defined:
  - Class
  - Interface
  - Delegate

### **Predefined Types**

- C# has a set of predefined types.
- `bool` - Boolean type is used to store true or false values.
- `int` - Integer type is used to store whole numbers.
- `float` - Floating point type is used to store real numbers.
- `char` - Character type is used to store single character.
- `byte` - Byte type is used to store 8 bit unsigned integer.
- `short` - Short type is used to store 16 bit signed integer.
- `object` - Object type is used to store any type of value.
- `string` - String type is used to store sequence of characters.
- `DateTime` - DateTime type is used to store date and time.
- `TimeSpan` - TimeSpan type is used to store time interval.

### **Custom Types**

## **Type Conversion**

- Process of converting one type to another.
- Used when there is a need to assign a value of one type to another type.

### **Implicit Conversion**

- Done by the compiler.
- Done when there is no loss of information or has no possibility of throwing an exception.

```cs
int intNumber = 10;
double doubleNumber = intNumber;
```

### **Explicit Conversion**

- Done by the programmer.
- Done when there is a possibility of loss of information or throwing an exception.

#### **Casting**

- Casting is used to convert one type to another.
- Can be done using casting operator or `Convert` class.

```cs
double doubleNumber = 10.5;
int intNumber = (int)doubleNumber;
```

#### **Helpers**

```cs
double doubleNumber = 10.5;
int integerNumber = (int)Convert.ChangeType(doubleNumber, typeof(int));
```

## **Typing**

- Typing is the process of assigning a type to a variable.
- Typing can be done implicitly or explicitly.

### **Implicit**

- Done by the compiler.
- Done when there is no loss of information or has no possibility of throwing an exception.
- `var` keyword is used to implicitly type a variable.

```cs
var a = 123; // a will be an integer
var b = false; // b will be a boolean
var c = 'a'; // c will be a character
var d = 11.0; // d will be a double
```

### **Explicit**

- Done by the programmer.
- Done when there is a possibility of loss of information or throwing an exception.
- Type is explicitly mentioned while declaring the variable.

```cs
int a = 123;
bool b = false;
char c = 'a';
double d = 11.0;
```

## **Default Values**

- All value types are initialized to a default value.
- Default values are assigned to variables that are not initialized.

```cs
int defaultInt; // 0
bool defaultBool; // false
```

## **Members of Permeative Types**

- All primitive types have members.
- Members are properties and methods.
- Members are accessed using dot operator.

### **Integers and Doubles**

- `MinValue` - Minimum value that can be stored in the variable.
- `MaxValue` - Maximum value that can be stored in the variable.

```cs
int minInt = int.MinValue;
int maxInt = int.MaxValue;

double minDouble = double.MinValue;
double maxDouble = double.MaxValue;

Console.WriteLine($"Minimum Integer: {minInt}"); // -2147483648
Console.WriteLine($"Maximum Integer: {maxInt}"); // 2147483647
Console.WriteLine($"Minimum Double: {minDouble}"); // -1.79769313486232E+308
Console.WriteLine($"Maximum Double: {maxDouble}"); // 1.79769313486232E+308
```

### **Character**

- `ToUpper` - Converts the character to upper case.
- `IsWhiteSpace` - Checks if the character is white space.
- `IsDigit` - Checks if the character is digit.
- `IsLetter` - Checks if the character is letter.
- `IsLetterOrDigit` - Checks if the character is letter or digit.
- `IsPunctuation` - Checks if the character is punctuation.
- `IsNumber` - Checks if the character is number.
- `IsSeparator` - Checks if the character is separator.
- `IsSymbol` - Checks if the character is symbol.

```cs
char character = 'a';
char upperCaseCharacter = char.ToUpper(character);
bool isWhiteSpace = char.IsWhiteSpace(character);v
bool isDigit = char.IsDigit(character);
bool isLetter = char.IsLetter(character);
bool isLetterOrDigit = char.IsLetterOrDigit(character);
bool isPunctuation = char.IsPunctuation(character);
bool isNumber = char.IsNumber(character);
bool isSeparator = char.IsSeparator(character);
bool isSymbol = char.IsSymbol(character);

Console.WriteLine($"Character: {character}"); // a
Console.WriteLine($"Upper Case Character: {upperCaseCharacter}"); // A
Console.WriteLine($"Is White Space: {isWhiteSpace}"); // False
Console.WriteLine($"Is Digit: {isDigit}"); // False
Console.WriteLine($"Is Letter: {isLetter}"); // True
Console.WriteLine($"Is Letter or Digit: {isLetterOrDigit}"); // True
Console.WriteLine($"Is Punctuation: {isPunctuation}"); // False
Console.WriteLine($"Is Number: {isNumber}"); // False
Console.WriteLine($"Is Separator: {isSeparator}"); // False
Console.WriteLine($"Is Symbol: {isSymbol}"); // False
```

### **DateTime**

- DateTime is used to store date and time.
- `Today` - Returns today's date.
- `AddDays` - Adds days to the date.
- `DayOfWeek` - Returns the day of the week.
- `IsDaylightSavingTime` - Checks if the date is in daylight saving time.
- `ToLongDateString` - Returns the date in long date string format.
- `ToShortTimeString` - Returns the time in short time string format.
- `ToShortDateString` - Returns the date in short date string format.
- `ToLongTimeString` - Returns the time in long time string format.

```cs
DateTime date = new DateTime(2023, 07, 24);
DateTime today = DateTime.Today;
DateTime twoDaysInFuture = date.AddDays(2);
DayOfWeek dayOfWeek = date.DayOfWeek;
bool isDST = date.IsDaylightSavingTime();

Console.WriteLine($"Date: {date}"); // 7/24/2023 12:00:00 AM
Console.WriteLine($"Today: {today}"); // 7/22/2021 12:00:00 AM
Console.WriteLine($"Two Days in Future: {twoDaysInFuture}"); // 7/26/2023 12:00:00 AM
Console.WriteLine($"Day of Week: {dayOfWeek}"); // Monday
Console.WriteLine($"Is Daylight Saving Time: {isDST}"); // False
```

### **TimeSpan**

- TimeSpan is used to store time interval.
- `Add` - Adds time interval to the time.
- `Subtract` - Subtracts time interval from the time.
- `FromDays` - Creates a TimeSpan from the specified number of days.
- `FromHours` - Creates a TimeSpan from the specified number of hours.
- `FromMinutes` - Creates a TimeSpan from the specified number of minutes.
- `FromSeconds` - Creates a TimeSpan from the specified number of seconds.
- `FromMilliseconds` - Creates a TimeSpan from the specified number of milliseconds.
- `FromTicks` - Creates a TimeSpan from the specified number of ticks.
- `ToString` - Returns the string representation of the time interval.

```cs
DateTime startHour = DateTime.Now;
TimeSpan workTime = new TimeSpan(8, 35, 0);
DateTime endHour = startHour.Add(workTime);

Console.WriteLine($"Start Hour: {startHour}"); // 7/22/2021 10:00:00 AM
Console.WriteLine($"Work Time: {workTime}"); // 08:35:00
Console.WriteLine($"End Hour: {endHour}"); // 7/22/2021 6:35:00 PM
Console.WriteLine($"Long Date String: {startHour.ToLongDateString()}"); // Thursday, July 22, 2021
Console.WriteLine($"Short Time String: {endHour.ToShortTimeString()}"); // 6:35 PM
```

### **String**

- String is a collection of characters.
- String is a reference type and is immutable.
- `string` is an alias for `System.String` class.

#### **Declaration**

- String can be declared using `string` keyword.

```cs
string hello = "Hello";
string empty = string.Empty;
var implicitStr = "Implicit String";
string nullStr = null;
string declaredStr;

Console.WriteLine($"Hello: {hello}");
Console.WriteLine($"Empty: {empty}");
Console.WriteLine($"Implicit String: {implicitStr}");
Console.WriteLine($"Null String: {nullStr}");
Console.WriteLine($"Declared String: {declaredStr}");
```

#### **Members**

- `Length` - Returns the length of the string.
- `ToUpper` - Converts the string to upper case.
- `ToLower` - Converts the string to lower case.
- `Contains` - Checks if the string contains the specified string.
- `Replace` - Replaces the specified string with the specified string.
- `Substring` - Returns the substring of the string.
- Chain of methods can be used to perform multiple operations on the string.

```cs
Console.WriteLine($"Length: {hello.Length}"); // 5
Console.WriteLine($"ToUpper: {hello.ToUpper()}"); // HELLO
Console.WriteLine($"ToLower: {hello.ToLower()}"); // hello
Console.WriteLine($"Contains: {hello.Contains("ll")}"); // true
Console.WriteLine($"Replace: {hello.Replace("ll", "LL")}"); // HeLLo
Console.WriteLine($"Substring: {hello.Substring(1, 2)}"); // el
Console.WriteLine($"Chain: {hello.ToUpper().Replace("LL", "ll").Substring(1, 2)}"); // EL
```

#### **Concatenation**

- Concatenation is the process of combining two strings.
- `+` operator is used to concatenate strings.
- `string.Concat` method is used to concatenate strings.
- String interpolation is used to concatenate strings.
- `string.Format` method is used to concatenate strings.

```cs
Console.WriteLine($"Concatenation: {hello + " World"}"); // Hello World
Console.WriteLine($"Concatenation: {string.Concat(hello, " World")}"); // Hello World
Console.WriteLine($"Interpolation: {hello} World"); // Hello World
Console.WriteLine($"Interpolation: {string.Format("{0} World", hello)}"); // Hello World
```

#### **Escaping**

- Escape characters are used to escape special characters.
- Escape characters are prefixed with `\`.
- Escape characters are used to escape double quotes, single quotes, backslash, new line, carriage return, tab, vertical tab, alert, backspace, form feed, and unicode characters.
- They can also be used to define file path.

```cs
Console.WriteLine($"Double Quotes: \""); // "
Console.WriteLine($"Single Quotes: \'"); // '
Console.WriteLine($"Backslash: \\"); // \
Console.WriteLine($"New Line: \n"); // New Line
Console.WriteLine($"Carriage Return: \r"); // Carriage Return
Console.WriteLine($"Tab: \t"); // Tab
Console.WriteLine($"Vertical Tab: \v"); // Vertical Tab
Console.WriteLine($"Alert: \a"); // Alert
Console.WriteLine($"Backspace: \b"); // Backspace
Console.WriteLine($"Form Feed: \f"); // Form Feed
Console.WriteLine($"Unicode: \u0061"); // a
Console.WriteLine($"File Path: C:\\Users\\"); // C:\Users\
```

#### **Verbatim**

- Verbatim strings are prefixed with `@`.
- Used to ignore escape characters.

```cs
Console.WriteLine(@"Verbatim: \n"); // Verbatim: \n
Console.WriteLine(@"Verbatim: """); // Verbatim: "
Console.WriteLine(@"Verbatim: C:\Users\"); // Verbatim: C:\Users\
```

#### **Compare**

- Compares two strings.
- Returns 0 if both strings are equal.
- Returns 1 if first string is greater than second string.
- Returns -1 if first string is less than second string.

```cs
Console.WriteLine($"Compare: {"Hello" == "Hello"}"); // 0
Console.WriteLine($"Compare: {string.Compare("Hello", "Hello")}"); // 0
Console.WriteLine($"Compare: {string.Compare("Hello", "World")}"); // -1
Console.WriteLine($"Compare: {string.Compare("World", "Hello")}"); // 1
Console.WriteLine($"Compare: {"Hello".CompareTo("Hello")}"); // 0
Console.WriteLine($"Compare: {"Hello".Equals("Hello")}"); // True
```

#### **Immutability**

- String is immutable.
- Once a string is created it cannot be modified.
- Any operation on the string will create a new string.
- String is stored in the heap.
- Can be garbage collected when there are no references to it.
- Can have performance issues when there are too many string operations.

```cs
string hello = "Hello";
string world = "World";
string helloWorld = hello + " " + world;

Console.WriteLine($"Hello: {hello}"); // Hello
Console.WriteLine($"World: {world}"); // World
Console.WriteLine($"Hello World: {helloWorld}"); // Hello World
```

#### **String Builder**

- String Builder is used to perform string operations.
- String Builder is mutable.
- Used for more performance critical string operations.
- Can be used in loops, methods, and other places where string operations are performed.
- `System.Text` namespace is used to access String Builder class.

```cs
StringBuilder stringBuilder = new StringBuilder();
stringBuilder.Append("Hello");
stringBuilder.Append(" ");
stringBuilder.Append("World");

Console.WriteLine($"String Builder: {stringBuilder}"); // Hello World

stringBuilder.Replace("World", "C#");
stringBuilder.Insert(0, "Hi ");
stringBuilder.AppendLine("!");

Console.WriteLine($"String Builder: {stringBuilder}"); // Hi Hello C#!
```

#### **Parsing**

- Parsing is the process of converting string to other types.
- `int.Parse` method is used to convert string to integer.
- `double.Parse` method is used to convert string to double.
- `bool.Parse` method is used to convert string to boolean.
- `DateTime.Parse` method is used to convert string to DateTime.
- `TimeSpan.Parse` method is used to convert string to TimeSpan.

```cs
string intStr = "123";
string doubleStr = "123.45";
string boolStr = "true";
string dateTimeStr = "07/24/2023";
string timeSpanStr = "08:35:00";

int intNumber = int.Parse(intStr); // 123
double doubleNumber = double.Parse(doubleStr); // 123.45
bool boolValue = bool.Parse(boolStr); // True
DateTime dateTime = DateTime.Parse(dateTimeStr); // 7/24/2023 12:00:00 AM
TimeSpan timeSpan = TimeSpan.Parse(timeSpanStr); // 08:35:00
```

##### **TryParse**

- Used to check if the string can be converted to the specified type.

```cs
string intStr = "123";
string doubleStr = "123.45";
string boolStr = "true";
string dateTimeStr = "07/24/2023";
string timeSpanStr = "08:35:00";

int intNumber;
double doubleNumber;
bool boolValue;
DateTime dateTime;
TimeSpan timeSpan;

bool isInt = int.TryParse(intStr, out intNumber); // True
bool isDouble = double.TryParse(doubleStr, out doubleNumber); // True
bool isBool = bool.TryParse(boolStr, out boolValue); // True
bool isDateTime = DateTime.TryParse(dateTimeStr, out dateTime); // True
bool isTimeSpan = TimeSpan.TryParse(timeSpanStr, out timeSpan); // True

var cultureInfo = new CultureInfo("nl-BE");
string birthDateString = "28 Maart 1984";//Dutch, spoken in Belgium
var birthDate = DateTime.Parse(birthDateString, cultureInfo);
Console.WriteLine($"Birth Date: {birthDate}"); // 3/28/1984 12:00:00 AM
```

## **Methods**

- Codeblocks used to perform operations.
- Defined in a class or struct.
- Can receive parameters and optionally return a value.
- Used to make code readable and reusable.

### **Declaration**

```cs
public string SayHello(string name)
{
    return "Hello " + name + "!";
}

Console.WriteLine(SayHello("World")); // Hello World!
```

- `public` - Access modifier.
- `string` - Return type.
- `SayHello` - Method name.
- `name` - Parameter.
- `"Hello " + name + "!"` - Method body.
- `return` - Return statement.
- `SayHello("World")` - Method call.

### **Overloading**

- Multiple methods with same name but different parameters.
- Can have different number of parameters or different types of parameters.
- Return type is not considered while overloading.

```cs
public string SayHello()
{
    return "Hello World!";
}

public string SayHello(string name)
{
    return "Hello " + name + "!";
}

public string SayHello(string firstName, string lastName)
{
    return "Hello " + firstName + " " + lastName + "!";
}

Console.WriteLine(SayHello()); // Hello World!
Console.WriteLine(SayHello("Niko")); // Hello Niko!
Console.WriteLine(SayHello("Niko", "Bellic")); // Hello Niko Bellic!
```

## **Passing Parameter Values**

### **By Value**

- Default way of passing a value as parameter.
- Copy is created and passed to the method.
- Value is directly passed to the method.

```cs
public void Add(int number)
{
    number += 10;
}

int number = 10;
Add(number);
Console.WriteLine(number); // 10
```

### **By Reference**

- Reference of the variable is passed to the method.
- No copy is created.
- Changes made in the method will be reflected in the variable.
- Before calling the method the variable must be initialized.

#### **Ref**

- `ref` keyword is used to pass a value by reference.

```cs
public void Add(ref int number)
{
    number += 10;
}

int number = 10;
Add(ref number);
Console.WriteLine(number); // 20
```

#### **Out**

- `out` keyword is used to pass a value by reference.
- Initialization of the variable is not required.
- Multiple values can be returned from a method.

```cs
public void Add(int number1, int number2, out int result)
{
    result = number1 + number2;
}

int number1 = 10;
int number2 = 20;
int result;
Add(number1, number2, out result);
Console.WriteLine(result); // 30
```

### **Params**

- Used to pass variable number of arguments to a method.
- `params` keyword is used.
- `params` keyword must be the last parameter.
- `params` keyword can be used only once in a method.
- `params` keyword can be used with `ref` and `out` keywords.

```cs
public void Add(params int[] numbers)
{
    int result = 0;
    foreach (int number in numbers)
    {
        result += number;
    }
    Console.WriteLine(result);
}

Add(1, 2, 3, 4, 5); // 15
Add(1, 2, 3, 4, 5, 6, 7, 8, 9, 10); // 55
```

### **Optional Parameters**

- Used to pass optional parameters to a method.
- Specifies default values for one or more parameters.
- Caller can omit the optional parameters.
- Optional parameters must be the last parameters.

```cs
public void Add(int number1, int number2 = 10)
{
    int result = number1 + number2;
    Console.WriteLine(result);
}

Add(10); // 20
Add(10, 20); // 30
```

### **Named Arguments**

- Used to pass arguments by name.
- Arguments can be passed in any order.
- Arguments can be skipped.

```cs
public void Add(int number1, int number2)
{
    int result = number1 + number2;
    Console.WriteLine(result);
}

Add(number2: 10, number1: 20); // 30
Add(number1: 10, number2: 20); // 30
Add(10, number2: 20); // 30
Add(number1: 10, 20); // Error
```

## **Expression-bodied Syntax**

- Used to write methods in a single line.

```cs
public int Add(int number1, int number2) => number1 + number2;

Console.WriteLine(Add(10, 20)); // 30
```

## **Common Type System (CTS)**

- CTS is a collection of data types.
- CTS is used to ensure that all data types are compatible with each other.
- It is specific to .NET Framework and common to all languages that target .NET Framework.
- Defines how type definitions and values are represented in the memory.

## **Custom Types**

- Custom types are user defined types.
- Used to create or represent complex types.
- Contains data, functionality, and behavior.
- Some are known types and some comes from assemblies.
- Organized in namespaces.
- Only the types within the namespaces are brought and not the nested namespaces.

```
  System
  |- System.Web
  |- System.IO
  |- System.Windows
  |- System.Data
      |- System.Data.SqlTypes
      |- System.Data.Common
```

- Use Object Browser to view the types in an assembly. View -> Object Browser.

### **Adding Custom Types (Packages)**

- Custom packages can be installed using NuGet Package Manager.
  1. Right click on the project.
  2. Select Manage NuGet Packages.
  3. Search for the package.
  4. Click on Install.
- Custom packages can be installed using Package Manager Console.
  1. Tools -> NuGet Package Manager -> Package Manager Console.
  2. Run the following command.
     ```
     Install-Package <Package Name>
     ```
- Custom packages can be installed using .NET CLI.
  1. Open the terminal.
  2. Run the following command.
     ```
     dotnet add package <Package Name>
     ```
- Custom packages can be installed using PackageReference.

  1. Right click on the project.
  2. Select Edit Project File.
  3. Add the following code.
     ```xml
     <ItemGroup>
         <PackageReference Include="<Package Name>" Version="<Version Number>" />
     </ItemGroup>
     ```

- Packages installed are listed in Project -> Dependencies -> Packages.

## **Base Class Library**

- BCL is a collection of classes.
- Used to perform common tasks.
- Some of them are:
  - List<T>
  - Exception
  - Console
  - File
  - Directory
  - DateTime
  - Debug
  - Enumerable
  - DataAdapter
  - DbConnection
  - HttpClient
  - Icon
  - Bitmap
  - Attachment
  - Brush

## **Types in CTS**

### **Enumeration**

- Used to create a set of named constants.
- Improves code readability.
- Uses `enum` keyword.
- Value type.

#### **Default Values**

- Enum assigns default values to the constants.
- Integer values which starts from 0.
-

```cs
enum Days
{
    Sunday, // 0
    Monday, // 1
    Tuesday, // 2
    Wednesday, // 3
    Thursday, // 4
    Friday, // 5
    Saturday // 6
}

Console.WriteLine($"Sunday: {(int)Days.Sunday}"); // 0
```

#### **Explicit Values**

- Enum can be assigned explicit values.
- Explicit values can be of any type.
- Explicit values can be assigned to some or all constants.

```cs
enum Days
{
    Sunday = 1,
    Monday = 2,
    Tuesday = 3,
    Wednesday = 4,
    Thursday = 5,
    Friday = 6,
    Saturday = 7
}

Console.WriteLine($"Sunday: {(int)Days.Sunday}"); // 1
Days day = Days.Sunday;
Console.WriteLine($"Day: {day}"); // Sunday
```

### **Structure**

- Used to create a custom data structure.
- Mostly used for small data structures.
- Are value types.
- Can be instantiated using `new` keyword.
- Can contain data, members and methods.

```cs
struct Point
{
    public int X; // public field
    public int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Move(int x, int y)
    {
        X += x;
        Y += y;
    }
}

Point point = new Point(10, 20);
point.Move(10, 20);
Console.WriteLine($"X: {point.X}"); // 20

Point point2;
point2.X = 10;
point2.Y = 20;
Console.WriteLine($"X: {point2.X}"); // 10
```

### **Class**

- Most commonly used custom type.

### **Interface**

### **Delegate**
