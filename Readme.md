# .NET Training Project

This repository contains my C# and .NET learning journey, organized day-by-day with practical implementations and exercises.

---

## 📚 Project Structure

### **Day 1: Fundamentals**
**Folder:** `Day1Fundamentals/`

**Topics Covered:**
- Basic C# syntax and structure
- Variable declarations and data types
- Basic input/output operations
- Simple calculations and conversions

**Implemented Programs:**
- `PrintingName.cs` - Basic console output
- `Age.cs` - Age calculator
- `Circle.cs` - Calculate and print area of circle
- `CheckEvenorOdd.cs` - Check if a number is even or odd
- `Primecheck.cs` - Prime number checker
- `Feettocenti.cs` - Feet to centimeter conversion

**Key Learnings:**
- Understanding the Main method as entry point
- Working with Console.WriteLine() and Console.ReadLine()
- Basic arithmetic operations
- Type conversion and parsing

---

### **Day 2: Conditions and Loops**
**Folder:** `Day2ConditionsAndLoops/`

**Topics Covered:**
- Conditional statements (if-else, switch)
- Loops (for, while, do-while, foreach)
- Control flow statements (break, continue, goto)
- Nested loops and pattern printing
- Complex logical operations

**Implemented Programs:**
- `SimpleCalculator.cs` - Basic calculator with switch statement
- `LeapYearCheck.cs` - Leap year validation
- `GradeDescription.cs` - Grade system implementation
- `HeightCategory.cs` - Height categorization
- `AdmissionEligibility.cs` - Eligibility checker
- `LargestofThree.cs` - Find largest among three numbers
- `VowelorConsonant.cs` - Character classification
- `QuadrantFinder.cs` - Coordinate quadrant finder
- `TriangleType.cs` - Triangle classification
- `ValidDateCheck.cs` - Date validation
- `ProfitorLoss.cs` - Calculate profit or loss
- `ATMWithdrawal.cs` - ATM simulation with multiple conditions
- `MenuSystem.cs` - Menu-driven program
- `RockPaperScissors.cs` - Game implementation
- `GuessingGame.cs` - Number guessing game
- `SearchWithGoto.cs` - Demonstration of goto statement
- `ContinueUsage.cs` - Continue statement examples
- `PrimeNumber.cs` - Prime number generation
- `FibonacciSeries.cs` - Fibonacci sequence generator
- `ArmstrongNumber.cs` - Armstrong number checker
- `StrongNumber.cs` - Strong number verification
- `SumOfDigits.cs` - Sum of digits calculator
- `ReverseAndPalindrome.cs` - String reversal and palindrome check
- `FactorialLargeNumbers.cs` - Factorial calculation for large numbers
- `GCDandLCM.cs` - GCD and LCM calculator
- `BinaryToDecimal.cs` - Binary to decimal converter
- `QuadraticEquation.cs` - Quadratic equation solver
- `PascalsTriangle.cs` - Pascal's triangle generator
- `DiamondPattern.cs` - Diamond pattern printing

**Key Learnings:**
- Decision-making in programs
- Loop control and iteration
- Pattern printing techniques
- Mathematical algorithms
- Game logic implementation
- Complex conditional logic

---

### **Day 3: Inheritance**
**Folder:** `Day3InHeritance/`

**Topics Covered:**
- Object-Oriented Programming basics
- Inheritance concepts
- Base and derived classes
- Method overriding
- Polymorphism fundamentals

**Implemented Programs:**
- `Person.cs` - Base Person class
- `Student.cs` - Student class inheriting from Person
- `Employee.cs` - Employee class implementation
- `Competion.cs` & `CompetionWon.cs` - Competition hierarchy
- Helper classes for displaying details

**Key Learnings:**
- Understanding class hierarchies
- Implementing inheritance using `: base class`
- Accessing base class members
- Code reusability through inheritance
- Polymorphic behavior

---

### **Day 4: Advanced Inheritance & Exception Handling**
**Folder:** `Day4InHeritanceAndTryCatch/`

**Topics Covered:**
- Advanced inheritance scenarios
- Constructor chaining
- The `this` keyword
- Exception handling (try-catch-finally)
- Custom exception scenarios
- Method overriding with validation

**Implemented Programs:**
- `Visitor.cs` - Constructor with validation and exceptions
- `AddtwoNumbersusingConstructor.cs` - Constructor-based operations
- `ExField.cs` - Field access examples
- `Emp.cs` - Employee with exception handling
- `Account.cs` - Account management with inheritance
- `Father.cs` - Method overriding example

**Key Learnings:**
- Constructor chaining with `this()`
- Proper exception handling patterns
- Input validation
- Creating meaningful exception messages
- Overriding methods in derived classes

---

### **Day 5: Class Libraries & Abstract Classes**
**Folder:** `Day5ClassLibAndAbstract/`

**Topics Covered:**
- Creating and using class libraries
- Abstract classes and methods
- Separation of concerns
- Project references
- Abstract method implementation

**Implemented Programs:**
- `Employee1.cs` - Employee with abstract implementation
- References to:
  - `MathsLib` - Mathematical operations library
  - `ScienceLib` - Science-related calculations
  - `PaymentLib` - Payment processing abstractions

**Class Libraries Created:**
- **CommonLib** - Contains `LoginAbs.cs` (abstract login class)
- **MathsLib** - Mathematical utility functions
- **ScienceLib** - Science calculations
- **PaymentLib** - Payment processing (UPI, Card, etc.)

**Key Learnings:**
- Creating reusable class libraries (.csproj files)
- Adding project references using `dotnet sln add`
- Abstract classes cannot be instantiated
- Abstract methods must be implemented in derived classes
- Code organization and modularity
- `UpiPayment` implementation example

---

### **Day 6: Interfaces & Multiple Inheritance**
**Folder:** `Day6InterfaceAndMultipleInheritance/`

**Topics Covered:**
- Interface definition and implementation
- Multiple interface inheritance
- Explicit interface implementation
- Interface naming conventions
- Resolving naming conflicts

**Implemented Programs:**
- `Interface.cs` - Interface examples
- `Printer` class - Implementing printer interface
- `Visitor` class - Multiple interface implementation
- `IVegEatter` & `INonVegEatter` interfaces
- `HOD` class - Hierarchical implementation

**Key Learnings:**
- Interfaces define contracts
- Classes can implement multiple interfaces (multiple inheritance)
- Explicit interface implementation for method name conflicts
- Using interface references to call specific implementations
- Interface naming convention (prefix with 'I')

---

### **Day 7: Arrays & Collections**
**Folder:** `Day7ArraysCollections/`

**Topics Covered:**
- Array fundamentals
- Jagged arrays (array of arrays)
- Collections framework
- List, Dictionary, HashSet
- Explicit interface implementation with multiple interfaces
- String manipulation

**Implemented Programs:**
- `Birds.cs` - Multiple interface implementation with `HybridBird`
- `JackedArray.cs` - Jagged array examples
- `Collections.cs` - Various collection types
- `PasswordGenerator.cs` - String manipulation with vowel removal and inversion

**Key Learnings:**
- Single vs multi-dimensional arrays
- Jagged arrays for irregular data structures
- Collection types and their use cases
- Explicit interface implementation for same method names
- Using interface references to access explicit implementations
- String processing and LINQ operations

---

### **Day 8: Data Modeling & Separation**
**Folder:** `Day8/`

**Topics Covered:**
- Project structure organization
- Data layer separation
- Model classes
- Data access patterns
- Namespace organization

**Implemented Structure:**
- `Model/` folder:
  - `Student.cs` - Student model
  - `Section.cs` - Section model
  - `StudentsSection.cs` - Relationship model
- `Data/` folder:
  - `DataBank.cs` - Student data repository
  - `DataSection.cs` - Section data repository

**Key Learnings:**
- Separating concerns (Model, Data, Business Logic)
- Creating model classes
- Data access layer patterns
- Working with collections of objects
- Iterating through data structures

---

### **Day 9: Indexers, Properties & Advanced Features**
**Folder:** `Day9Indexer/`

**Topics Covered:**
- Indexers (array-like access to objects)
- Properties with private setters
- Partial classes
- Static classes and members
- Encapsulation patterns

**Implemented Programs:**
- `MyData.cs` - Basic indexer implementation
- `Student.cs` - Indexer with student book collection
- `ExampleForPrivateSet.cs` - Private set property example
- `PartialClassExampleFile1.cs` & `PartialClassExampleFile2.cs` - Partial class demonstration
- `StaticClassExample.cs` - Static class with static constructor

**Key Learnings:**
- Indexers allow array-like syntax: `object[index]`
- Properties can have different access levels (public get, private set)
- Partial classes split class definition across multiple files
- Static classes cannot be instantiated
- Static constructors initialize static members
- Static members are shared across all instances

---

## 🛠️ Technologies Used

- **Language:** C# (.NET)
- **Framework:** .NET SDK
- **IDE:** Visual Studio Code
- **Build Tool:** dotnet CLI

---

## 🚀 How to Run

1. **Prerequisites:**
   - Install [.NET SDK](https://dotnet.microsoft.com/download)

2. **Build the solution:**
   ```bash
   dotnet build dotnet_training.sln
   ```

3. **Run a specific day's project:**
   ```bash
   cd Day1Fundamentals
   dotnet run
   ```

4. **For projects using class libraries:**
   - Ensure project references are added
   - Build the solution before running individual projects

---

## 📝 Notes

- Each day's folder contains a `Program.cs` with example calls (often commented out)
- Uncomment specific method calls in `Program.cs` to run different examples
- Class libraries are shared across multiple day projects
- Solution file (`dotnet_training.sln`) ties all projects together

---

## 🎯 Learning Objectives Achieved

✅ C# fundamentals and syntax  
✅ Control structures and loops  
✅ Object-oriented programming principles  
✅ Inheritance and polymorphism  
✅ Exception handling  
✅ Abstract classes and interfaces  
✅ Collections and arrays  
✅ Code organization and architecture  
✅ Static and partial classes  
✅ Indexers and advanced properties  

---

## 📌 Future Enhancements

- LINQ queries and advanced operations
- Asynchronous programming (async/await)
- File I/O operations
- Database connectivity (ADO.NET, Entity Framework)
- API development (ASP.NET Core)
- Unit testing
- Design patterns implementation

---

**Author:** Thiluck  
**Last Updated:** December 29, 2025