
int [] ArrayR(int size){
    int [] a = new int [size];
    for(int i=0; i<a.Length; i++){
        a[i]=new Random().Next(0,10);
    }
    return a;
}

void Out(int [] array){
    for (int i=0; i<array.Length; i++){
        System.Console.WriteLine(array[i]);
    }
}
int [] result = ArrayR(8);
Out(result);