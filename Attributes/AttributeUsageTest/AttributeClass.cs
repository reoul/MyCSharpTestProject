namespace MyAttributeTest
{
    public abstract class AttributeClass { }


    [AllowMultiple(Name = "BaseClass_1")]
    [AllowMultiple(Name = "BaseClass_2")]
    [DenyMultiple(Name = "BaseClass")]
    [InheritedTrue(Name = "BaseClass")]
    [InheritedFalse(Name = "BaseClass")]
    [Derived]
    [Derived]
    public class BaseClass : AttributeClass { }


    [AllowMultiple(Name = "DerivedClass")]
    [DenyMultiple(Name = "DerivedClass")]
    public class DerivedClass : BaseClass { }
}