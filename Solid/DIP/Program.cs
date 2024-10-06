var parent = new Person { Name = "John" };
var child1 = new Person() { Name = "Chris" };
var child2 = new Person() { Name = "Mary" };
var relationships = new Relationships();
relationships.AddParentAndChild(parent, child1);
public enum Relationship
{
    Parent, Child, Sibling
}

public class Person
{
    public string Name { get; set; }
}

public class Relationships : IRelationsBrowswer
{
    private List<(Person, Relationship, Person)> relations =
        new List<(Person, Relationship, Person)>();

    public void AddParentAndChild(Person parent, Person child) 
    {
        relations.Add((parent, Relationship.Parent, child));
        relations.Add((child, Relationship.Child, parent));
    }

    public IEnumerable<Person> FindAllChildren(string name)
    {
        return relations.Where(x => x.Item1.Name == "John" && x.Item2 == Relationship.Parent).Select(r => r.Item3);
    }

    public List<(Person, Relationship, Person)> Relations => relations;
}
public interface IRelationsBrowswer
{
    IEnumerable<Person> FindAllChildren(string name);
}
public class Research
{
    public Research(IRelationsBrowswer relationsBrowswer) 
    {
        foreach (var p in relationsBrowswer.FindAllChildren("John"))
        {
            Console.WriteLine($"John has a child" +  p.Name);
        }
    }
}

