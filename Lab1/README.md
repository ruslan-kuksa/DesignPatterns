# Project Documentation

## Programming Principles Demonstrated

### 1. DRY (Don't Repeat Yourself)
- **Implementation**: Avoidance of code duplication. Using common methods for duplicate code.

### 2. KISS (Keep It Simple, Stupid)
- **Implementation**: The project simplicity in understanding the code. The methods isn't complicated than they have to be.

### 3. SOLID Principles
- **Single Responsibility Principle**: Each class has a single responsibility, e.g., `Warehouse` manages product storage.
    - [Warehouse.cs](ClassLibrary/Warehouse.cs)
- **Open/Closed Principle**: Classes like `Money` `Product` `Warehouse` are open for extension but closed for modification by providing functionalities via interfaces.
    - [IMoney.cs](ClassLibrary/IMoney.cs)
    - [IProduct.cs](ClassLibrary/IProduct.cs)
    - [IWarehouse.cs](ClassLibrary/IWarehouse.cs)
- **Liskov Substitution Principle**: There don't have specific implementations or replacements to fully appreciate this principle.
- **Interface Segregation Principle**: There don't have specific implementations.
- **Dependency Inversion Principle**: High-level modules like `Reporting` depend on abstractions `IWarehouse` and `IProduct` rather than concrete classes.
    - [Reporting.cs](ClassLibrary/Reporting.cs)

### 4. YAGNI (You Aren't Gonna Need It)
- **Implementation**: The system implements features that are strictly required, such as handling products and their inventory without additional unused features.

### 5. Composition Over Inheritance
- **Implementation**: Composition is used over inheritance with `Warehouse` and `Product` classes using instances of interfaces rather than inheriting from other classes.
    - [Warehouse.cs](ClassLibrary/Warehouse.cs)
    - [Product.cs](ClassLibrary/Product.cs)

### 6. Program to Interfaces not Implementations
- **Implementation**: The use of interfaces `IMoney`, `IProduct`, `IWarehouse` ensures that the system components rely on abstractions rather than concrete implementations.
    - [IMoney.cs](ClassLibrary/IMoney.cs)
    - [IProduct.cs](ClassLibrary/IProduct.cs)
    - [IWarehouse.cs](ClassLibrary/IWarehouse.cs)
    - [Reporting.cs](ClassLibrary/Reporting.cs)
### 7. Fail Fast
- **Implementation**: The system uses checks and exceptions to quickly fail when incorrect data is input, as seen in `SetMoney` in the `Money` class and in the `Product`.
    - [Money.cs: SetMoney method](ClassLibrary/Money.cs#L22)
    - [Product.cs: ReducePrice method](ClassLibrary/Product.cs#L27)