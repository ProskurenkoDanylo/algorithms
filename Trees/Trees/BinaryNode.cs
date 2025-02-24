
//BinaryNode<string> binaryTree = new BinaryNode<string>("Root");
//binaryTree.AddLeft("A");
//var a = binaryTree.LeftNode;
//binaryTree?.LeftNode?.AddLeft("C");
//binaryTree?.LeftNode?.AddRight("D");

//binaryTree?.AddRight("B");
//binaryTree?.RightNode?.AddRight("E");
//binaryTree?.RightNode?.RightNode?.AddLeft("F");

//Console.WriteLine(binaryTree);
//Console.WriteLine(binaryTree?.LeftNode);

//FindValue(binaryTree, "Root");
//FindValue(binaryTree, "E");
//FindValue(binaryTree, "F");
//FindValue(binaryTree, "Q");

//Find D in the A subtree.
//FindValue(a, "D");



//void FindValue(BinaryNode<string> root, string target)
//{
//    BinaryNode<string> node = root.FindNode(target);
//    if (node == null)
//        Console.WriteLine(string.Format("Value {0} not found", target));
//    else
//        Console.WriteLine(string.Format("Found {0}", node.Value));
//}

//string result;
//result = "Preorder:      ";
//foreach (BinaryNode<string> node in binaryTree.TraversePreorder())
//{
//    result += string.Format("{0} ", node.Value);
//}

//string resultPostOrder;
//resultPostOrder = "PostOrder:      ";
//foreach (BinaryNode<string> node in binaryTree.TraversePostorder())
//{
//    resultPostOrder += string.Format("{0} ", node.Value);
//}

//string resultInOrder;
//resultInOrder = "InOrder:      ";
//foreach (BinaryNode<string> node in binaryTree.TraverseInorder())
//{
//    resultInOrder += string.Format("{0} ", node.Value);
//}

//string resultBreadthFirst;
//resultBreadthFirst = "BreadthFirst:      ";
//foreach (BinaryNode<string> node in binaryTree.TraverseBreadthFirst())
//{
//    resultBreadthFirst += string.Format("{0} ", node.Value);
//}

//Console.WriteLine(result);
//Console.WriteLine(resultPostOrder);
//Console.WriteLine(resultInOrder);
//Console.WriteLine(resultBreadthFirst);

//public class BinaryNode<T>(T value)
//{
//    public T Value { get; } = value;
//    public BinaryNode<T>? LeftNode { get; set; }
//    public BinaryNode<T>? RightNode { get; set; }

//    public void AddLeft(T value)
//    {
//        LeftNode = new BinaryNode<T>(value);
//    }

//    public void AddRight(T value)
//    {
//        RightNode = new BinaryNode<T>(value);
//    }

//    public override string ToString()
//    {
//        return ToString("");
//    }

//    public string ToString(string spaces)
//    {
//        var result = spaces + Value?.ToString() + ':';
//        if (LeftNode != null)
//        {
//            result += "\n";
//            result += LeftNode.ToString(spaces + "  ");
//        }
//        else if (RightNode != null)
//        {
//            result += "\n" + spaces + "  None";
//        }

//        if (RightNode != null)
//        {
//            result += "\n";
//            result += RightNode.ToString(spaces + "  ");
//        }
//        else if (LeftNode != null)
//        {
//            result += "\n" + spaces + "  None";
//        }

//        return result;
//    }

//    public BinaryNode<T>? FindNode(T value)
//    {
//        if (Value != null && Value.Equals(value))
//        {
//            return this;
//        }

//        if (LeftNode != null)
//        {
//            var leftSearch = LeftNode.FindNode(value);
//            if (leftSearch != null)
//            {
//                return leftSearch;
//            }
//        }
//        if (RightNode != null)
//        {
//            var rightSearch = RightNode.FindNode(value);
//            if (rightSearch != null)
//            {
//                return rightSearch;
//            }
//        }
//        return null;
//    }

//    public List<BinaryNode<T>> TraversePreorder()
//    {
//        List<BinaryNode<T>> nodes = new() { this };
//        if (RightNode == null && LeftNode == null)
//        {
//            return new List<BinaryNode<T>> { this };
//        }
//        if (LeftNode != null)
//        {
//            nodes.AddRange(LeftNode.TraversePreorder());
//        }
//        if (RightNode != null)
//        {
//            nodes.AddRange(RightNode.TraversePreorder());
//        }
//        return nodes;
//    }

//    public List<BinaryNode<T>> TraversePostorder()
//    {
//        List<BinaryNode<T>> nodes = new() { };
//        if (LeftNode != null)
//        {
//            nodes.AddRange(LeftNode.TraversePostorder());
//        }
//        if (RightNode != null)
//        {
//            nodes.AddRange(RightNode.TraversePostorder());
//        }
//        nodes.Add(this);
//        return nodes;
//    }

//    public List<BinaryNode<T>> TraverseInorder()
//    {
//        List<BinaryNode<T>> nodes = new() { };
//        if (LeftNode != null)
//        {
//            nodes.AddRange(LeftNode.TraverseInorder());
//        }
//        nodes.Add(this);
//        if (RightNode != null)
//        {
//            nodes.AddRange(RightNode.TraverseInorder());
//        }
//        return nodes;
//    }

//    public List<BinaryNode<T>> TraverseBreadthFirst()
//    {
//        List<BinaryNode<T>> nodes = new() { };
//        Queue<BinaryNode<T>> queue = new();
//        queue.Enqueue(this);
//        while (queue.Count > 0)
//        {
//            BinaryNode<T> node = queue.Dequeue();
//            nodes.Add(node);
//            if (node.LeftNode != null)
//            {
//                queue.Enqueue(node.LeftNode);
//            }
//            if (node.RightNode != null)
//            {
//                queue.Enqueue(node.RightNode);
//            }
//        }
//        return nodes;
//    }
//}
