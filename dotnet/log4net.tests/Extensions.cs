using System;
using System.IO;
using System.Reflection;

namespace log4net.Tests
{
    internal static class Extensions
    {
        public static void Close(this FileStream fileStream) => fileStream.Dispose();

        public static void Close(this StreamReader streamReader) => streamReader.Dispose();

        public static ConstructorInfo GetConstructor(this Type type, BindingFlags bindingAttr, object binder, Type[] types, object[] modifiers)
        {
            return type.GetConstructor(types);
        }

        public static MethodInfo GetMethod(this Type type, string name, BindingFlags bindingAttr, object binder, Type[] types, object[] modifiers)
        {
            return type.GetMethod(name, types);
        }
    }
}
