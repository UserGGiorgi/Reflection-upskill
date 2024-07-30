using System.Reflection;

[assembly: CLSCompliant(true)]

namespace Reflection;

public static class ReflectionOperations
{
    public static string GetTypeName(object obj)
    {
        throw new NotImplementedException();
    }

    public static string GetFullTypeName<T>()
    {
        throw new NotImplementedException();
    }

    public static string GetAssemblyQualifiedName<T>()
    {
        throw new NotImplementedException();
    }

    public static string[] GetPrivateInstanceFields(object obj)
    {
        throw new NotImplementedException();
    }

    public static string[] GetPublicStaticFields(object obj)
    {
        throw new NotImplementedException();
    }

    public static string?[] GetInterfaceDataDetails(object obj)
    {
        throw new NotImplementedException();
    }

    public static string?[] GetConstructorsDataDetails(object obj)
    {
        throw new NotImplementedException();
    }

    public static string?[] GetTypeMembersDataDetails(object obj)
    {
        throw new NotImplementedException();
    }

    public static string?[] GetMethodDataDetails(object obj)
    {
        throw new NotImplementedException();
    }

    public static string?[] GetPropertiesDataDetails(object obj)
    {
        throw new NotImplementedException();
    }
}
