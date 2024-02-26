﻿using System.Reflection;
public class SimpleClassExample
{
  public static void Main()
  {
    Type t = typeof(SimpleClass);
    BindingFlags flags = BindingFlags.Instance | BindingFlags.Static |
   BindingFlags.Public |
    BindingFlags.NonPublic |
   BindingFlags.FlattenHierarchy;
    MemberInfo[] members = t.GetMembers(flags);
    Console.WriteLine($"Type {t.Name} has {members.Length} members: ");
    foreach (MemberInfo member in members)
    {
      string access = "";
      string stat = "";
      var method = member as MethodBase;
      if (method != null)
      {
        if (method.IsPublic)
          access = " Public";
        else if (method.IsPrivate)
          access = " Private";
        else if (method.IsFamily)
          access = " Protected";
        else if (method.IsAssembly)
          access = " Internal";
        else if (method.IsFamilyOrAssembly)
          access = " Protected Internal ";
        if (method.IsStatic) stat = " Static";
      }
      string output = $"{member.Name} ({member.MemberType}): {access} {stat}, Declared by {member.DeclaringType}";
      Console.WriteLine(output);
    }
  }
}
public class SimpleClass
{ }
