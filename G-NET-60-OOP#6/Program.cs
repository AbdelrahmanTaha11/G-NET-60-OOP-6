namespace G_NET_60_OOP_6;

internal class Program
{
    static void Main(string[] args)
    {
        #region Part01
        #region Question01
        //Q1: What is abstraction in OOP? How is it different from encapsulation?
        //    Give a real - world example(not from the session)
        //        that shows the difference between the two.


        // Abstraction:
        // Abstraction means showing only the essential features of an object
        // while hiding the complex implementation details.
        // It focuses on "what the object does", not "how it does it".

        // Encapsulation:
        // Encapsulation means wrapping data and methods inside a class
        // and protecting the data by controlling access using properties
        // or access modifiers (private, public, etc.).
        // It focuses on protecting the object's data.

        // Difference:
        // - Abstraction hides implementation details.
        // - Encapsulation hides and protects data from direct access.

        // Real-world example:
        // ATM Machine
        // Abstraction:
        // When you withdraw money, you only use the buttons and screen.
        // You don't need to know how the bank processes your request internally.

        // Encapsulation:
        // Your bank account balance is protected.
        // You cannot change it directly; it can only be updated through
        // valid operations like Deposit() or Withdraw().



        #endregion

        #region Question02
        /*Q2 : What is the difference between an abstract class and an interface? 
         * Give at least four differences.
         * When would you choose one over the other?
         */



        // 1. Abstract Class:
        // Can contain both abstract methods and implemented methods.
        // Interface:
        // Contains only method/property/event declarations (contract).

        // 2. Abstract Class:
        // Can have fields and constructors.
        // Interface:
        // Cannot have instance fields or constructors.

        // 3. Abstract Class:
        // A class can inherit from only one abstract class.
        // Interface:
        // A class can implement multiple interfaces.

        // 4. Abstract Class:
        // Used when related classes share common code and behavior.
        // Interface:
        // Used to define a common capability that different classes can implement.

        // When to use an Abstract Class:
        // Use it when classes have a common base with shared data and implementation.

        // When to use an Interface:
        // Use it when different, unrelated classes need to provide the same functionality
        // without sharing implementation.

        #endregion

        #region Question03
        //a) Can you write: Appliance a = new Appliance("LG"); ? Why or why not?
        //b) What is the difference between the three methods: PowerConsumption(), Status(), and Label()? Why did the designer make each one abstract, virtual, or concrete?
        //c) If you call Status() on a Toaster object, what will it return? Why?


        // Reason:
        // Appliance is an abstract class.
        // Abstract classes cannot be instantiated directly.
        // They are only used as a base class for derived classes.

        // b)

        // PowerConsumption()
        // - Abstract method.
        // - It has no implementation in the base class.
        // - Every derived class MUST override it because each appliance
        //   has a different power consumption.

        // Status()
        // - Virtual method.
        // - It has a default implementation: "Standby".
        // - Derived classes can override it if they need different behavior.
        // - WashingMachine overrides it, but Toaster does not.

        // Label()
        // - Concrete (normal) method.
        // - It already has a complete implementation.
        // - All appliances use the same logic to create the label,
        //   so there is no need to override it.

        // c)
        // Calling Status() on a Toaster object will return:
        //
        // "Standby"
        //
        // Reason:
        // Toaster does not override the virtual Status() method,
        // so it uses the default implementation from the Appliance class.


        #endregion

        #region Question04
        /*a) What is a partial class? Why would a developer split Calculator into two files?
            b) What is a partial method? What happens if the OnCalculated() implementation in Calculator.Logging.cs is deleted — will the code still compile? Why?
            c) What is an extension method? What are the three rules for writing one?
            d) What will the following code print?
            Calculator calc = new Calculator();
            double result = calc.Add(19.5, 0.5);
            Console.WriteLine(result.ToCurrency());
            */


        // a)
        // Partial Class:
        // A partial class allows one class to be split across multiple files.
        // The compiler combines all parts into a single class.
        //
        // Why split Calculator into two files?
        // - Makes large classes easier to organize.
        // - Allows multiple developers to work on the same class.
        // - Separates the main logic from extra features such as logging.

        // b)
        // Partial Method:
        // A partial method is declared in one part of a partial class
        // and can be implemented in another part.
        //
        // If the OnCalculated() implementation is deleted,
        // the code will still compile.
        //
        // Why?
        // Because partial methods are optional.
        // If no implementation exists, the compiler removes both
        // the method declaration and its calls.

        // c)
        // Extension Method:
        // An extension method allows you to add new methods to an existing type
        // without modifying its source code or creating a derived class.
        //
        // Three rules:
        // 1. It must be inside a static class.
        // 2. The method itself must be static.
        // 3. The first parameter must use the 'this' keyword
        //    to specify the type being extended.

        // d)
        // Output:
        //
        // Log: result = 20
        // $20.00
        //
        // Explanation:
        // Add(19.5, 0.5) returns 20.
        // OnCalculated() prints the log message.
        // ToCurrency() formats the result as "$20.00".


        #endregion

        #endregion


        #region Part02
        Cinema cinema = new Cinema();


        Ticket t1 = new StandardTicket("Inception", 80, "A5");
        Ticket t2 = new VIPTicket("Avengers", 200, true, 50);
        Ticket t3 = new IMAXTicket("Dune", 130, true);

        t1.Book();
        t2.Book();
        t3.Book();

        cinema.AddTicket(t1);
        cinema.AddTicket(t2);
        cinema.AddTicket(t3);

        cinema.PrintTickets();

        Console.WriteLine();
        Console.WriteLine("--- Polymorphism: Final Price per Ticket ---");

        Ticket[] tickets = { t1, t2, t3 };

        foreach (Ticket ticket in tickets)
        {
            Console.WriteLine($"{ticket.GetType().Name} => Final Price: {ticket.CalculateFinalPrice():F2}");
        }

        Console.WriteLine();
        Console.WriteLine("--- Extension Method: Receipt ---");
        Console.WriteLine(t2.GenerateReceipt());

        Console.WriteLine();
        Console.WriteLine("--- Extension Method: Total Revenue ---");
        Console.WriteLine($"Total Revenue: {tickets.TotalRevenue():F2}");

        cinema.Close();


        #endregion


    }
}
