public class MyQueue {
    public Stack<int> stackFirst;
    public Stack<int> stackSecond;

    public MyQueue() {
        stackFirst = new Stack<int>();
        stackSecond = new Stack<int>();
    }
    
    public void Push(int x) {
        
        
        while(stackFirst.Count!=0)
        {
            
            stackSecond.Push(stackFirst.Pop());
            
        }
        stackFirst.Push(x);
        
        while(stackSecond.Count!=0) {
            stackFirst.Push(stackSecond.Pop());
        }
        
        
    }
    
    public int Pop() {
        return stackFirst.Pop();
        
    }
    
    public int Peek() {
       return stackFirst.Peek();
        
    }
    
    public bool Empty() {
        return (stackFirst.Count==0);
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */