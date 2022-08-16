using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary>
/// Public Class Obj 
/// </summary>
public class Obj
{
    public static void Print(object myObj)
    {
        TypeInfo object_type = myObj.GetType().GetTypeInfo();

        Console.WriteLine(object_type.Name + " Properties:");
        foreach (PropertyInfo x in object_type.GetProperties())
        {
            Console.WriteLine(x.Name);
        }

        Console.WriteLine(object_type.Name + " Methods:");
        foreach (MethodInfo y in object_type.GetMethods())
        {
            Console.WriteLine(y.Name);
        }
    }
}
