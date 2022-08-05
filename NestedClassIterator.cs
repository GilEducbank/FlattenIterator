namespace Example;

public class NestedClassIterator
{
    public List<string> NestedList { get; }
    public NestedClassIterator(Type type)
    {
        NestedList = new List<string>();

        Flatten(NestedList, type);
    }
    private void Flatten(List<string> nestedList, Type type)
    {
        var constantsStringsInCurrentClass = type.GetFields()
            .Select(item => item.GetValue(null).ToString());

        foreach (var item in constantsStringsInCurrentClass)
        {
            nestedList.Add(item);
        }

        var constantClassesInCurrentClass = type.GetNestedTypes();
        foreach (var item in constantClassesInCurrentClass)
        {
            Flatten(nestedList, item);
        }
    }
}