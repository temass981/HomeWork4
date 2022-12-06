System.Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число");
int b = int.Parse(Console.ReadLine());
int  Degree(int x, int b){
    int result = (int)Math.Pow(a,b);
    return result;
}
int result = Degree(a,b);
System.Console.WriteLine(result);