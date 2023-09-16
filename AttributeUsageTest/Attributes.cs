using System;

namespace MyAttributeTest
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class AllowMultipleAttribute : Attribute
    {
        public string Name { get; set; }

        public override string ToString() => $"[{nameof(AllowMultipleAttribute)}] {Name}";
    }

    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public class DenyMultipleAttribute : Attribute
    {
        public string Name { get; set; }

        public override string ToString() => $"[{nameof(DenyMultipleAttribute)}] {Name}";
    }

    [AttributeUsage(AttributeTargets.All, Inherited = true)]
    public class InheritedTrueAttribute : Attribute
    {
        public string Name { get; set; }

        public override string ToString() => $"[{nameof(InheritedTrueAttribute)}] {Name}";
    }

    [AttributeUsage(AttributeTargets.All, Inherited = false)]
    public class InheritedFalseAttribute : Attribute
    {
        public string Name { get; set; }

        public override string ToString() => $"[{nameof(InheritedFalseAttribute)}] {Name}";
    }

    [AttributeUsage(AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    public abstract class BaseAttribute : Attribute { }

    // 아래 AttributeUsage를 지우면 BaseAttribute에 지정된 AttributeUsage(AttributeTargets.Struct)로 인해 Error 발생
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class DerivedAttribute : BaseAttribute { }
}