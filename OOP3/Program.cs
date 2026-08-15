using System.Timers;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 Part1

            //(A)What is the difference between Method Overloading and Method Overriding?

            //      Method Overloading means having multiple methods with the same name but different parameters.
            //Method Overriding means providing a new implementation for an inherited method in a derived class.

            //           (B) What is the difference between Static Binding and Dynamic Binding?


            //            Static Binding determines the method to be executed at compile time.
            //Dynamic Binding determines the method to be executed at runtime.


            #region Q2 

            //       (A)     What is the purpose of the sealed keyword when applied to a class?


            //The sealed keyword prevents other classes from inheriting from that class.

            //       (B)What is the difference between a sealed class and a sealed method?


            //A sealed class prevents inheritance, while a sealed method prevents further overriding in derived classes.

//          (C)  Can a sealed method be overridden? Why?


//No, a sealed method cannot be overridden because the sealed keyword prevents further overriding in derived classes.

            #endregion

            #endregion


        }
    }
}
