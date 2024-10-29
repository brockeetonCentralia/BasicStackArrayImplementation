ArrayStack<int> stack = new ArrayStack<int>(5);

stack.Push(157);
stack.Push(201);
stack.Push(300);

Console.WriteLine($"Top element is {stack.Peek()}");

stack.Pop(); 
stack.Pop();

Console.WriteLine($"Top element is {stack.Peek()}");

Console.WriteLine($"Is stack empty? {stack.IsEmpty()}");

stack.Pop();

Console.WriteLine($"Top element is {stack.Peek()}");
Console.WriteLine($"Is stack empty? {stack.IsEmpty()}");

class ArrayStack<T>
{
    private T[] _stack;
    private int _top;

    public ArrayStack(int size)
    {
        _stack = new T[size];
        _top = -1;
    }
    public void Push(T item)
    {
        if (_top == _stack.Length - 1)
        {
            Console.WriteLine("Stack is full.");
            return;
        }
        _stack[++_top] = item;
        Console.WriteLine($"Pushed {item} to stack.");
    }
    public T Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty.");
            return default;
        }
        T item = _stack[_top--]; 
        Console.WriteLine($"Popped {item} from stack.");
        return item;
    }
    public T Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty.");
            return default;
        }
        return _stack[_top];
    }
    public bool IsEmpty() => _top == -1;
}

