using static System.Console;

class Program
{
    static void Main()
    {
        Task5(); 
    }
    static void Task5()
    {
      ReadIntegers();
    }

    static void ReadIntegers(){
        var stack = new MyStack();
        int size = 3, count = 1;
        WriteLine("Enter 3 numbers: ");
        while(count <= size){
            Write($"Enter a number: ");
            if(int.TryParse(ReadLine(), out int num))
            {
                stack.Push(num);
                count ++;
            }
            else{
                WriteLine($"Invalid input: {num}");
            }             
        }
        WriteLine("The entered numbers in reverse order: ");
        while(stack.Count > 0){
            Write(stack.Peek() + " ");
            stack.Pop();
        }
    }  
}

class MyStack // Create Stack
{
    private LinkedList<int> _stack;
    public int Count{ get => _stack.Count;}
    public MyStack(){ _stack = new LinkedList<int>(); }
    public void Push(int e){
        _stack.AddFirst(e); // Insert item to the top
    }
    public int Peek(){
        if(Count == 0){
            throw new InvalidOperationException("Empty Stack");
        }
        return _stack.First(); // Get the top item value
    }
    public int Pop(){
        int e = Peek(); // this could trigger exception if the stack is empty
        _stack.RemoveFirst(); // Deletes the top item
        return e;
    }
}