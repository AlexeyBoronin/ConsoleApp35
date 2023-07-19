//MessageHandler handler = delegate (string mes)//Main
//{
//    Console.WriteLine(mes);
//};
//handler("Hello world");

/*ShowMessange("hello", delegate (string mes)
{
    Console.WriteLine(mes);
});
MessageHandler handler = delegate
{
    Console.WriteLine("Анонимный метод");
};
handler("hello world!");
Operation operation = delegate (int x, int y)
{
    return x+y;
};
int result = operation(4, 5);
Console.WriteLine(result);
int z = 9;
Operation operation1 = delegate (int x, int y)
{
    return x + y + z;
};
result= operation1(4, 5);
Console.WriteLine(result);
var hello = () =>
{
    Console.WriteLine("Hello");
    Console.WriteLine("World");
};//лямбда-выражение
hello();
hello();
hello();
Operation1 sum = ( x, y) => Console.WriteLine($"{x}+{y}={x + y}");
sum(1, 2);
sum(22, 77);
string test = "Test";
MessageHandler print=message=>Console.WriteLine(message);
print(test);
print("Welcome");
var sum1 = (int x, int y) => x + y;
int sumResualt = sum1(4, 5);
Console.WriteLine(sumResualt);

Operation multipy = (x, y) => x * y;
int multiplyResualt= multipy(4, 5);
Console.WriteLine(multiplyResualt);*/
int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int result1 = Sum(integers, x => x > 5);
Console.WriteLine(result1);

int result2=Sum(integers,x=>x%2==0);
Console.WriteLine(result2);
Console.WriteLine("**********************************");
Operation operation = SelectOperation(OperationType.Add);
Console.WriteLine(operation(10,4));
operation = SelectOperation(OperationType.Subtract);
Console.WriteLine(operation(20,6));
operation = SelectOperation(OperationType.Multiply);
Console.WriteLine(operation(14,5));
//CLASS
int Sum(int[]number, IsEqual func)
{
    int result = 0;
    foreach(int i in number)
    {
        if(func(i))
            result+=i;
    }
    return result;
}

Operation SelectOperation(OperationType opType)
{
    switch(opType)
    { 
        case OperationType.Add:return (x,y)=> x + y;
        case OperationType.Subtract:return (x,y)=> x - y;
        default : return (x,y)=> x * y;
            
    }
}
static void ShowMessange(string messange, MessageHandler handler)
{
    handler(messange);
}
enum OperationType
{Add,Subtract,Multiply }

delegate bool IsEqual(int x);
delegate void MessageHandler(string message);
delegate int Operation(int x,  int y);
delegate void Operation1(int x, int y);
delegate void Message();