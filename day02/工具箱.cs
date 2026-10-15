static class 工具箱
{
    public static  int 读整数()
    {
        int num;
        while(!int.TryParse(Console.ReadLine(),out num))
        {
            Console.WriteLine("输入不符合要求，请重新输入数字");
        }
        return num;
    }
    
}