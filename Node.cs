public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        //TODO 1: Make sure that the Value gets put on the correct side of the tree!
        if (value < Data) {
            // Insert to the left
            if (Left is null) 
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if(value > Data) {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        // TODO Start Problem 2
        if(value == Data) {
            return true; 
        }

        if(value < Data && Left is not null) {
            if(Left.Data == value) {
                return true;
            }
            else {
                Left.Contains(value);
            }
        }
        
        else if(value > Data && Right is not null) {
            if(Right.Data == value) {
                return true; 
            }
            else {
                Right.Contains(value);
            }
        }
        return false;
    }

    public int GetHeight() {
        if(Left is null && Right is null) {
            //Console.WriteLine("Here!");
            return 1; 
        }
        
        else {   
            int rightHeight = 1; 
            int leftHeight = 1;  
            
            if(Left is not null) {
                leftHeight += Left.GetHeight();
            }
            
            if (Right is not null) {
                rightHeight += Right.GetHeight(); 
            }
            
            if(rightHeight > leftHeight) {
                return rightHeight;
            }
            else {
                return leftHeight;
            } 
        }  
    }
}