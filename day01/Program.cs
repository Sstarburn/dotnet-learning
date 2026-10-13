
Console.WriteLine("你好，你叫什么名字呀？");
String name = Console.ReadLine()??"陌生人";
Console.WriteLine($"你好呀~{name}");
while(true)
{
    Console.WriteLine("今天打算学习多久呀？");
    int time = int.TryParse(Console.ReadLine(),out int t)?t:0;
    Console.WriteLine("目标打算是多少分数？");
    int goat = int.TryParse(Console.ReadLine(),out int g)?g:0;
    Console.WriteLine($"{name},今天打算学习{time}小时，目标{goat}分，开工！");
    break;
}

