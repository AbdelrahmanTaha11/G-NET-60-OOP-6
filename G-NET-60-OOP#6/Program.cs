namespace G_NET_60_OOP_6
{
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
            #endregion

        }
    }
}
