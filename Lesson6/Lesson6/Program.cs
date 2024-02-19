
var intStack = new Lesson6.Stack<int>();
var doubleStack = new Lesson6.Stack<double>();
var stringStack  = new Lesson6.Stack<string>();
Console.WriteLine("int Stack check");
intStack.Push(0);
intStack.Push(10);
intStack.Push(5555);
while (!intStack.IsEmpty())
{
    Console.WriteLine(intStack.Peek());
    Console.WriteLine(intStack.Pop());
}
try
{
    intStack.Peek();
}
catch(Exception e)
{
    Console.WriteLine($"{e.Message}");
}
Console.WriteLine("double Stack check");
doubleStack.Push(0.5);
doubleStack.Push(1/2);
doubleStack.Push(5555.0);
while (!doubleStack.IsEmpty())
{
    Console.WriteLine(doubleStack.Peek());
    Console.WriteLine(doubleStack.Pop());
}
try
{
    doubleStack.Peek();
}
catch (Exception e)
{
    Console.WriteLine($"{e.Message}");
}
Console.WriteLine("string Stack check");
stringStack.Push("i");
stringStack.Push("love");
stringStack.Push("u");
while (!stringStack.IsEmpty())
{
    Console.WriteLine(stringStack.Peek());
    Console.WriteLine(stringStack.Pop());
}
try
{
    stringStack.Peek();
}
catch (Exception e)
{
    Console.WriteLine($"{e.Message}");
}