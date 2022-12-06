System.Console.WriteLine("Введите число");
string a =Console.ReadLine();
int Sum(String str){
    int sum = 0;
    for(int i = 0; i<a.Length; i++){
    int number = (int)Char.GetNumericValue(a[i]);
    sum = sum + number;
}
    return sum;
}
int result = Sum(a);
System.Console.WriteLine(result);