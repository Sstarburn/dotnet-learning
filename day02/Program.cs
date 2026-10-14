int start = 1;
int end = 101;

int secret = Random.Shared.Next(1,101);//得到 1~100 的随机数
int answer;
int count = 0 ;
int retrytimes = 7;
// Console.WriteLine("随机数："+secret);
Console.WriteLine("如果需要修改范围请输入范围值，例如1，100,输入y进入输入范围");
string again = Console.ReadLine()??"N";
if(again == "y" || again == "Y")
{
    Console.WriteLine("输入起始数字，例如数字1");
    start = Writ_Num();
    Console.WriteLine("输入结束数字，例如数字100");
    end = Writ_Num();
    end += 1;
}
Console.WriteLine($"猜下 在{start}~{end-1} 中猜一个数：");
secret = Random.Shared.Next(start,end);
while(true)
{
    answer = Writ_Num();
    if(count >= retrytimes)
    {
        Console.WriteLine($"超过{retrytimes}次,答案是{secret}");
        break;
    }
    count++;
    if(answer == secret)
    {
        Console.WriteLine("猜中啦，恭喜你~");
        Console.WriteLine("需要再来一局（y/n）");
        again = Console.ReadLine()??"N";

        if(again == "y" || again == "Y")
        {
            count = 0 ;
            Console.WriteLine("如果需要修改范围请输入范围值，例如1，100,输入y进入输入范围");
            again = Console.ReadLine()??"N";
            if(again == "y" || again == "Y")
            {
                Console.WriteLine("输入起始数字，例如数字1");
                start = Writ_Num();
                Console.WriteLine("输入结束数字，例如数字100");
                end = Writ_Num();
                end += 1;
            }
            Console.WriteLine($"猜下 在{start}~{end-1} 中猜一个数：");

            secret = Random.Shared.Next(start,end);
            continue;
        }
        break;
    }
    else if(answer > secret)
    {
        Console.WriteLine("数字大了哦");
        continue;
    }
    else if(answer < secret)
    {
        Console.WriteLine("数字小了哦");
        continue;
    }
    // else if(answer != secret)
    // {
    //     Console.WriteLine("猜错了~请重新输入");
    //     continue;
    // }

}

Console.WriteLine($"一共猜了{count}次~");

int Writ_Num()
{
    int num;
    while(!int.TryParse(Console.ReadLine(),out num))
    {
        Console.WriteLine("输入不符合要求，请重新输入数字");
    }
    return num;
}