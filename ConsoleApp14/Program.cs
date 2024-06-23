using System;

class BaseClass
{
    public int value = 5;
    public void PublicMethod()
    {
        Console.WriteLine("Public method called.");
    }

    internal int internalValue = 10;
    internal void InternalMethod()
    {
        Console.WriteLine("Internal method called.");
    }

    protected internal int protectedInternalValue = 15;
    protected internal void ProtectedInternalMethod()
    {
        Console.WriteLine("Protected internal method called.");
    }

    protected int protectedValue = 20;
    protected void ProtectedMethod()
    {
        Console.WriteLine("Protected method called.");
    }
}

class DerivedClass : BaseClass
{
    static void Main(string[] args)
    {
        BaseClass baseObj = new BaseClass();
        Console.WriteLine("Public field value: {0}", baseObj.value);
        baseObj.PublicMethod();

        Console.WriteLine("Internal field value: {0}", baseObj.internalValue);
        baseObj.InternalMethod();

        Console.WriteLine("Protected internal field value: {0}", baseObj.protectedInternalValue);
        baseObj.ProtectedInternalMethod();

        DerivedClass derivedObj = new DerivedClass();
        Console.WriteLine("Protected field accessed from derived class: {0}", derivedObj.protectedValue);
        derivedObj.ProtectedMethod();
        Console.Read();
    }
}