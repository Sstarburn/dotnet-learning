// List<string> 设备清单 = new();

// for(int num = 1;num<=3;num++)
// {
//     设备清单.Add($"CNC-{num:D2}");
// }
// Console.WriteLine(设备清单.Count);
// Console.WriteLine(设备清单[0]);

// foreach(string 名字 in 设备清单)
// {
//     Console.WriteLine($"设备清单{名字}");
// }

// Dictionary<string,string> 状态表 = new();
// 状态表["CNC-01"] ="运行";
// var s = 状态表["CNC-01"];
// if(状态表.ContainsKey("AGV-9")){}
// if(状态表.TryGetValue("AGV-9",out var 状态))
// {
//     Console.WriteLine($"状态：{状态}");
// }

List<string> 设备清单 = new();

while(true)
{
    try
    {
        int result = menu();
        if(result == (int)菜单状态.添加设备)
        {
            添加设备();
        }
        else if(result == (int)菜单状态.列出全部)
        {
            列出全部();
        }
        else if(result == (int)菜单状态.查找设备)
        {
            查找设备();
        }
        else if(result == (int)菜单状态.退出)
        {
            break;
        }

    }
    catch(Exception ex)
    {
        Console.WriteLine($"发生异常：{ex.Message}");
    }

}


int  menu()
{
    int result = 0;
    Console.WriteLine("请选择菜单：");
    Console.WriteLine("1.添加设备");  
    Console.WriteLine("2.列出全部");
    Console.WriteLine("3.查找设备");  
    Console.WriteLine("9.退出");  
    while(!int.TryParse(Console.ReadLine(),out result))
    {
        Console.WriteLine("输入不符合要求，请重新输入数字");
    }


    return result;
}

void 添加设备()
{
    Console.WriteLine("请输入添加设备名称：");
    string good = Console.ReadLine()??"未知设备";
    设备清单.Add(good);
    Console.WriteLine($"已添加设备：{good}");
}

void 列出全部()
{
    Console.WriteLine("设备列表如下:") ;
    int index = 1;
    foreach(string good in 设备清单)
    {
        Console.WriteLine($"{index:D2}:{good}");
        index++;
    }
}

void 查找设备()
{
    Console.WriteLine("请输入要查找的设备名称：");
    string good = Console.ReadLine()??"未知设备";
    if(设备清单.Contains(good))
    {
        Console.WriteLine($"已找到设备：{good}");

    }
    else
    {
        Console.WriteLine($"未找到对应设备：{good}");
    }
}

// void 退出()
// {
//     break;
// }

enum 菜单状态
{
    添加设备 = 1,
    列出全部 = 2,
    查找设备 = 3,
    退出 = 9

}
