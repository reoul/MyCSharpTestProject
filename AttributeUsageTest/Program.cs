using MyAttributeTest;
using MyUtil;
using System;

public class Program
{
    static void Main(string[] args)
    {
        foreach (var attribute in AttributeUtil.GetCustomAttributes<DerivedClass, AllowMultipleAttribute>())
            Console.WriteLine(attribute.ToString());

        foreach (var attribute in AttributeUtil.GetCustomAttributes<DerivedClass, DenyMultipleAttribute>())
            Console.WriteLine(attribute.ToString());

        foreach (var attribute in AttributeUtil.GetCustomAttributes<DerivedClass, InheritedTrueAttribute>())
            Console.WriteLine(attribute.ToString());

        foreach (var attribute in AttributeUtil.GetCustomAttributes<DerivedClass, InheritedFalseAttribute>())
            Console.WriteLine(attribute.ToString());

        foreach (var attribute in AttributeUtil.GetCustomAttributes<DerivedClass, DerivedAttribute>())
            Console.WriteLine(attribute.ToString());
    }
}
