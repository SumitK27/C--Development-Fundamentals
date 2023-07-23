# **Controlling Program Flow in C#** <!-- omit in toc -->

1. [**Program Flow**](#program-flow)
2. [**Operators**](#operators)
   1. [**Arithmetic Operators**](#arithmetic-operators)
   2. [**Assignment Operators**](#assignment-operators)
   3. [**Comparison Operators**](#comparison-operators)
   4. [**Logical Operators**](#logical-operators)
3. [**Statements**](#statements)
4. [**Types of Statements**](#types-of-statements)
   1. [**Declaration Statements (Local Variables)**](#declaration-statements-local-variables)
   2. [**Expression Statements**](#expression-statements)
      1. [**Expression vs Statements**](#expression-vs-statements)
   3. [**Selection Statements (If-Else, Switch)**](#selection-statements-if-else-switch)
      1. [**If-Else**](#if-else)
      2. [**Switch**](#switch)
      3. [**Ternary**](#ternary)
      4. [**Switch Expression**](#switch-expression)
      5. [**Switch with When**](#switch-with-when)
      6. [**Switch with Type Matching**](#switch-with-type-matching)
   4. [**Iteration Statements (Loops)**](#iteration-statements-loops)
      1. [**For**](#for)
      2. [**Foreach**](#foreach)
      3. [**While**](#while)
      4. [**Do-While**](#do-while)
   5. [**Exception Handling Statements**](#exception-handling-statements)

## **Program Flow**

- Order and conditions under which different parts of application execute.

## **Operators**

- `operator` - performs an action on one or more operands.
- `operand` - value that operator acts on.

```cs
1 + 2 // 1 and 2 are operands and + is operator
```

### **Arithmetic Operators**

- Used to perform arithmetic operations on operands.
- `+` operator is used to add two operands.
- `-` operator is used to subtract two operands.
- `*` operator is used to multiply two operands.
- `/` operator is used to divide two operands.
- `%` operator is used to get remainder of division of two operands.

```cs
int a = 10;
int b = 20;

Console.WriteLine(a + b); // 30
Console.WriteLine(a - b); // -10
Console.WriteLine(a * b); // 200
Console.WriteLine(a / b); // 0
Console.WriteLine(a % b); // 10
```

### **Assignment Operators**

- Used to assign values to variables.
- `=` operator is used to assign value to variable.
- `+=` operator is used to add value to variable.
- `-=` operator is used to subtract value from variable.
- `*=` operator is used to multiply value to variable.
- `/=` operator is used to divide value from variable.
- `%=` operator is used to get remainder of division of value from variable.

```cs
int a = 10;
int b = 20;

a += b; // a = a + b
a -= b; // a = a - b
a *= b; // a = a * b
a /= b; // a = a / b
a %= b; // a = a % b
```

### **Comparison Operators**

- Used to compare two operands.
- `==` operator is used to check if two operands are equal.
- `!=` operator is used to check if two operands are not equal.
- `>` operator is used to check if left operand is greater than right operand.
- `<` operator is used to check if left operand is less than right operand.
- `>=` operator is used to check if left operand is greater than or equal to right operand.
- `<=` operator is used to check if left operand is less than or equal to right operand.

```cs
int a = 10;
int b = 20;

Console.WriteLine(a == b); // False
Console.WriteLine(a != b); // True
Console.WriteLine(a > b); // False
Console.WriteLine(a < b); // True
Console.WriteLine(a >= b); // False
Console.WriteLine(a <= b); // True
```

### **Logical Operators**

- Used to combine two or more conditions.
- `&&` operator is used to check if two conditions are true.
- `||` operator is used to check if either of two conditions is true.
- `!` operator is used to check if condition is false.

```cs
int a = 10;
int b = 20;

Console.WriteLine(a > 0 && b > 0); // True
Console.WriteLine(a > 0 || b > 0); // True
Console.WriteLine(!(a > 0)); // False
```

## **Statements**

- Basic instruction that that executes to take action.
- They can be written using a combination of keywords, operators, method calls, and other programming elements.
- In C# statements are written using C# keywords and Expressions.
- C# statements ends with a semicolon `;` or a block of code enclosed in curly braces `{}`.

```cs
int a; // Declaration statement
```

## **Types of Statements**

### **Declaration Statements (Local Variables)**

- Used to declare local variables.
- `var` statement is used to declare an implicitly typed local variable.
- `const` statement is used to declare a constant.
- `readonly` statement is used to declare a read-only field.

```cs
var name = "John";
const int age = 30;
readonly int height = 180;
```

### **Expression Statements**

- Sequence of operators and operands that specifies a computation.
- Used to evaluate expressions, calculate values or executing methods.
- It returns a value.
- Expressions are not the statements themselves, but they are part of the statements.

```cs
5       // 5 is an expression that evaluates to value 5
3 * 2   // 3 and 2 are operands and * is operator
number + 1  // number and 1 are operands and + is operator
new Survey() // new is operator and Survey() is operand
```

#### **Expression vs Statements**

| Expression            | Statement                               |
| --------------------- | --------------------------------------- |
| 5                     | var a = 5;                              |
| isLoggedIn && isAdmin | bool hasAccess = isLoggedIn && isAdmin; |
| new Survey()          | var survey = new Survey();              |
| Console.WriteLine()   | Console.WriteLine();                    |

### **Selection Statements (If-Else, Switch)**

- Used to select different paths of execution based on some condition.

#### **If-Else**

- Selects a path to execute based on a boolean condition.
- `if` statement is used to execute a block of code if a specified condition is true.
- `else` statement is used to execute a block of code if the same condition is false. It is optional.
- `else if` statement is used to specify a new condition if the first condition is false. It is optional.

```cs
bool isWeekend = false;

if (isWeekend)
{
    Console.WriteLine("It is weekend");
}
else
{
    Console.WriteLine("It is not weekend");
}
```

#### **Switch**

- `switch` statement is used to select one of many code blocks to be executed.
- Selects a path based on pattern matching with a value.
- `case` statement is used to specify a pattern to match with the value.
- `default` statement is used to specify a block of code to be executed if no case matches the specified value.
- `break` statement is used to exit the switch statement.
- You can stack multiple cases together.

```cs
int day = 3;

switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Invalid day");
        break;
}

switch (day)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Weekday");
        break;
    case 6:
    case 7:
        Console.WriteLine("Weekend");
        break;
    default:
        Console.WriteLine("Invalid day");
        break;
}
```

#### **Ternary**

- `ternary` operator is used to select one of two expressions based on a boolean condition.
- It is a short form of if-else statement.
- They are used for assigning values to variables.

```cs
int a = 10;

string result = a > 0 ? "Positive" : "Negative";
```

#### **Switch Expression**

- `switch` expression is used to select one of many expressions to be executed.
- It is a short form of switch statement.

```cs
int day = 3;

string result = day switch
{
    1 => "Monday",
    2 => "Tuesday",
    3 => "Wednesday",
    4 => "Thursday",
    5 => "Friday",
    6 => "Saturday",
    7 => "Sunday",
    _ => "Invalid day"
};
```

```cs
int day = 3;

string result = day switch
{
    >= 1 and <= 5 => "Weekday",
    >= 6 and <= 7 => "Weekend",
    _ => "Invalid day"
};
```

#### **Switch with When**

- `switch` statement can be used with `when` clause to specify additional conditions.

```cs
int discount = 25;

switch (discount)
{
  case int id when id < 10:
    Console.WriteLine("Less than 10");
    break;
  case int id when id >= 10 && id < 20:
    Console.WriteLine("Between 10 and 20");
    break;
  case int id when id >= 20 && id < 30:
    Console.WriteLine("Between 20 and 30");
    break;
}
```

#### **Switch with Type Matching**

```cs
Shape myShape = new Rectangle() { width = 20 };

switch (myShape) {
  case Square s when shape.width < 10:
    // returns false
    break;
  case Rectangle r when shape.width > 10:
    // returns true
    break;
  case Circle c when c.diameter > 10:
    // returns false
    break;
}
// returns false
```

### **Iteration Statements (Loops)**

- Used to repeatedly execute a block of code until a specified condition is true.

#### **For**

- `for` statement is used to execute a block of code a specified number of times.
- For loop has three parts: initialization, condition and iterator.

```cs
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
```

#### **Foreach**

- `foreach` statement is used to iterate through the items in a collection.
- It is used to iterate through the items in an array or any collection that implements IEnumerable interface.

```cs
int[] numbers = { 1, 2, 3, 4, 5 };

foreach (var number in numbers)
{
    Console.WriteLine(number);
}
```

#### **While**

- `while` statement is used to execute a block of code as long as a specified condition is true.
- It is used when number of iterations are not known.

```cs
int i = 0;

while (i < 10)
{
    Console.WriteLine(i);
    i++;
}
```

#### **Do-While**

- `do-while` statement is used to execute a block of code once, and then repeatedly execute the block as long as a specified condition is true.
- It is used when number of iterations are not known.

```cs
int i = 0;

do
{
    Console.WriteLine(i);
    i++;
} while (i < 10);
```

### **Exception Handling Statements**

- Used to catch and address issues in the program.

```cs
try
{
    // Code that may raise exceptions
}
catch (Exception ex)
{
    // Code to handle exceptions
}
finally
{
    // Code to be executed regardless of exception
}
```
