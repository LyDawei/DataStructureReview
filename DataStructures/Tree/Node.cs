namespace DataStructureReview
{
    public class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int data)
        {
            Left = null;
            Right = null;
            Data = data;
        }

        public bool Add(int data)
        {
            if (Data == data)
            {
                return false;
            }
            else if (data < Data)
            {
                if (Left == null)
                {
                    Left = new Node(data);
                    return true;
                }
                else
                {
                    return Left.Add(data);
                }
            }
            else if (data > Data)
            {
                if (Right == null)
                {
                    Right = new Node(data);
                    return true;
                }
                else
                {
                    return Right.Add(data);
                }
            }

            return false;
        }

        public bool Exists(int data)
        {
            if (Data == data) return true;

            if (data < Data)
            {
                if (Left != null)
                {
                    return Left.Exists(Left.Data);
                }
                return false;
            }

            if (data > Data)
            {
                if (Right != null)
                {
                    return Right.Exists(Right.Data);
                }
                return false;
            }
            return false;
        }

        public bool Remove(int value, Node parent)
        {
            // Delete Leaves
            if (value < Data)
            {
                if (Left != null)
                {
                    return Left.Remove(value, this);
                }
                else
                {
                    return false;
                }
            }
            else if (value > Data)
            {
                if (Right != null)
                {
                    return Right.Remove(value, this);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (Left != null && Right != null)
                {
                    Data = Right.MinValue();
                    Right.Remove(Data, this);
                }
                else if (parent.Left == this)
                {
                    parent.Left = Left != null ? Left : Right;
                }
                else if (parent.Right == this)
                {
                    parent.Right = Left != null ? Left : Right;
                }
                return true;
            }
        }

        public int MinValue()
        {
            if (Left == null)
            {
                return Data;
            }
            else
            {
                return Left.MinValue();
            }
        }


    }
}