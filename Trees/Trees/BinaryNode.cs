BinaryNode<string> binaryTree = new BinaryNode<string>("Root");
binaryTree.AddLeft("A");
binaryTree?.LeftNode?.AddLeft("C");
binaryTree?.LeftNode?.AddRight("D");

binaryTree?.AddRight("B");
binaryTree?.RightNode?.AddRight("E");
binaryTree?.RightNode?.RightNode?.AddLeft("F");

Console.WriteLine(binaryTree);
Console.WriteLine(binaryTree?.LeftNode);

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
    }
