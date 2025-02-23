/*
BinaryNode<string> binaryTree = new BinaryNode<string>("Root");
binaryTree.AddLeft("A");
var a = binaryTree.LeftNode;
binaryTree?.LeftNode?.AddLeft("C");
binaryTree?.LeftNode?.AddRight("D");

binaryTree?.AddRight("B");
binaryTree?.RightNode?.AddRight("E");
binaryTree?.RightNode?.RightNode?.AddLeft("F");

Console.WriteLine(binaryTree);
Console.WriteLine(binaryTree?.LeftNode);

FindValue(binaryTree, "Root");
FindValue(binaryTree, "E");
FindValue(binaryTree, "F");
FindValue(binaryTree, "Q");

// Find D in the A subtree.
FindValue(a, "D");



void FindValue(BinaryNode<string> root, string target)
{
    BinaryNode<string> node = root.FindNode(target);
    if (node == null)
        Console.WriteLine(string.Format("Value {0} not found", target));
    else
        Console.WriteLine(string.Format("Found {0}", node.Value));
}

public class BinaryNode<T>(T value)
    {
        public T Value { get; } = value;
        public BinaryNode<T>? LeftNode { get; set; }
        public BinaryNode<T>? RightNode { get; set; }

        public void AddLeft(T value)
        {
            LeftNode = new BinaryNode<T>(value);
        }

        public void AddRight(T value)
        {
            RightNode = new BinaryNode<T>(value);
        }

        public override string ToString()
        {
            return ToString("");
        }

        public string ToString(string spaces)
        {
            var result = spaces + Value?.ToString() + ':';
            if (LeftNode != null)
            {
                result += "\n";
                result += LeftNode.ToString(spaces + "  ");
            } 
            else if (RightNode != null)
            {
                result += "\n" + spaces + "  None";
            }

            if (RightNode != null)
            {
                result += "\n";
                result += RightNode.ToString(spaces + "  ");
            }
            else if (LeftNode != null)
            {
                result += "\n" + spaces + "  None";
            }

            return result;
        }

    public BinaryNode<T>? FindNode(T value)
    {
        if (Value != null && Value.Equals(value))
        {
            return this;
        }

        if (LeftNode != null)
        {
            var leftSearch = LeftNode.FindNode(value);
            if (leftSearch != null)
            {
                return leftSearch;
            }
        }
        if (RightNode != null)
        {
            var rightSearch = RightNode.FindNode(value);
            if (rightSearch != null)
            {
                return rightSearch;
            }
        }
        return null;
    }
}
*/