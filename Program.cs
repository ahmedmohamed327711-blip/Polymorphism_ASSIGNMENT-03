namespace Polymorphism_ASSIGNMENT_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1 — Overloading, Overriding, and Binding

            //a
            //Method Overloading ==> it have the same method name but different parameters.
            //Method Overriding ==> it have the same method name and same parameters but different class or signature.

            //============================================================================================================

            //b
            //static Binding ==> it is a compile time binding, it is also called early binding. It is used in method overloading.
            //dynamic Binding ==> it is a run time binding, it is also called late binding. It is used in method overriding.

            //============================================================================================================

            //  Q2 Sealed Classes and Methods

            //a
            //sealed ==> it is use to prevent inheritance  ||  cannot be inherited,

            //============================================================================================================
            //b
            //sealed method ==> cannot be overridden in child classes.

            //============================================================================================================
            //c
            //No ==> because sealed method cannot be overridden in child classes.

        }
    }
}
