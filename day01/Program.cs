int time;
int goal;
Console.WriteLine("你好，你叫什么名字呀？");
String name = Console.ReadLine()??"陌生人";
Console.WriteLine($"你好呀~{name}");
while(true)
{

    Console.WriteLine("今天打算学习多久呀？");
    while(!int.TryParse(Console.ReadLine(),out  time))
     {
        Console.WriteLine("今天打算学习多久呀？");
        // Console.ReadLine();
     }
     Console.WriteLine("目标打算是多少分数？");
    while(!int.TryParse(Console.ReadLine(),out  goal))
     {
        Console.WriteLine("目标打算是多少分数？");
        // Console.ReadLine();
     }
    
    Console.WriteLine($"{name},今天打算学习{time}小时，目标{goal}分，开工！");
    break;
}

