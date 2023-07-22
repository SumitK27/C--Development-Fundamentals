# **C# - The Big Picture** <!-- omit in toc -->

1. [**C#**](#c)
2. [**Different types of Language Architectures**](#different-types-of-language-architectures)
   1. [**1. Native/Compiled**](#1-nativecompiled)
      1. [**Process**](#process)
      2. [**Pros**](#pros)
      3. [**Cons**](#cons)
   2. [**2. Interpreted/Dynamic (REPL)**](#2-interpreteddynamic-repl)
      1. [**Process**](#process-1)
      2. [**Pros**](#pros-1)
      3. [**Cons**](#cons-1)
   3. [**3. Managed/Execution Engine**](#3-managedexecution-engine)
      1. [**Process**](#process-2)
      2. [**Pros**](#pros-2)


## **C#**
- General purpose, object oriented Language
- Strongly/Statically Typed Language
- Made for combining the advantages of C++(Performance) and Java (Cross-Platform)
- Resilient to change
- Runtime type safety
- Made open-source since 2014
- Used for developing
  - Desktop Apps
  - Web Apps
  - Games
  - PowerShell Intelligence
  - AI

## **Different types of Language Architectures**

### **1. Native/Compiled**
- Example: C, C++, Rust, Go

#### **Process**
1. Code is written in a text file.
2. The text file is compiled with the help of compiler.
3. Compiler generates a CPU specific native binary code for the system.
4. Binary file is executed by the CPu.

#### **Pros**
- Errors are recognized at compilation.
- Has higher performance.

#### **Cons**
- Compile-time strongly typed, lacks at run-time.
- Manual memory management needed.
- Need to compile multiple times to keep the version compatible with different types of systems.

### **2. Interpreted/Dynamic (REPL)**
- Example: Python, Ruby, JavaScript

#### **Process**
1. Code is written in text file.
2. Text file is sent to interpreter.
3. Interpreted to Binary file.
4. Sent to CPU for execution.

#### **Pros**
- Loose/dynamic typing
- Run-time type conversion
- Automatic memory management

#### **Cons**
- Code is interpreted each time it is being executed.
- Slow performance

### **3. Managed/Execution Engine**

- Example: C#, F#, VB.NET

#### **Process**
1. Code is written in text file.
2. Text file is sent to compiler and compiled to Intermediate Language (IL) code also known as Assembly (.dll or .exe) by CLR (Common Language Runtime).
3. IL code is sent to JIT (Just In Time) compiler (EE) to generate native code.
4. Native code is sent to CPU for execution.

#### **Pros**
- Strongly Typed. 
- Run-time safety check.
- Garbage collection.
- Native code performance.
- Code from IL to Binary is compiled only once.
