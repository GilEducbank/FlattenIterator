using Example;
using System;
using System.Reflection;

/*
        var type = typeof(StaticClassExample);
        foreach(var item in type.GetFields())
        {
            Console.WriteLine("im here");
            var v = item.GetValue(null);
            Console.WriteLine(v);
        }

        var nestedTypes = type.GetNestedTypes();
        foreach (var item in nestedTypes)
        {
            foreach (var str in item.GetFields())
            {
                Console.WriteLine(str.GetValue(null));
            }
        }
*/
var nestedList = new NestedClassIterator(typeof(StaticClassExample)).NestedList;
foreach (var item in nestedList)
{
    Console.WriteLine(item);
}





