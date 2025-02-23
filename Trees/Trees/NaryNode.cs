
NaryNode<string> NaryTree = new NaryNode<string>("Root");
NaryTree.AddChild("A");
NaryTree.AddChild("B");
NaryTree.AddChild("C");
NaryTree.Children[0].AddChild("D");
NaryTree.Children[0].AddChild("E");
NaryTree.Children[0].Children[0].AddChild("G");
NaryTree.Children[2].AddChild("F");
NaryTree.Children[2].Children[0].AddChild("H");
NaryTree.Children[2].Children[0].AddChild("I");

Console.WriteLine(NaryTree.ToString());

public class NaryNode<T>(T value)
{
    public T Value { get; } = value;
    public List<NaryNode<T>> Children { get; } = new();

    public void AddChild(T value)
    {
        Children.Add(new NaryNode<T>(value));
    }

    public override string ToString()
    {
        return ToString("");
    }

    public string ToString(string spaces)
    {
        var result = spaces + Value?.ToString() + ':';
        if (Children.Count != 0)
        {
            foreach (var child in Children)
            {
                result += "\n" + child.ToString(spaces + "  ");
            }
        }
        return result;
    }
}