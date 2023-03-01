public class NodeStudent {
    public int Data { get; set; }
    public NodeStudent? Right { get; private set; }
    public NodeStudent? Left { get; private set; }

    public NodeStudent(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        //TODO 1: Make sure that the Value gets put on the correct side of the tree!
    }

    public bool Contains(int value) {
        // TODO Start Problem 2
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