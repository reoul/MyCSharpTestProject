using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MyUtil
{
    public static class AttributeUtil
    {
        public static IEnumerable<CustomAttributeData> GetCustomAttributesData<TClass>()
        where TClass : class
        {
            return typeof(TClass).GetCustomAttributesData();
        }

        public static TAttribute? GetCustomAttribute<TClass, TAttribute>(bool inherit = true)
            where TClass : class
            where TAttribute : Attribute
        {
            if (typeof(TClass).IsDefined(typeof(TAttribute)) == false)
                return null;
            return typeof(TClass).GetCustomAttribute<TAttribute>(inherit);
        }

        public static object[] GetCustomAttributes<TClass>(bool inherit = true)
            where TClass : class
        {
            return typeof(TClass).GetCustomAttributes(inherit);
        }

        public static IEnumerable<TAttribute> GetCustomAttributes<TClass, TAttribute>(bool inherit = true)
            where TClass : class
            where TAttribute : Attribute
        {
            if (typeof(TClass).IsDefined(typeof(TAttribute)) == false)
                return Enumerable.Empty<TAttribute>();
            return typeof(TClass).GetCustomAttributes<TAttribute>(inherit);
        }
    }
}
