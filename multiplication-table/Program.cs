Random rnd = new Random();

int size = rnd.Next(1,31);
int[] array = new int[size];
for (int i = 0; i < size; i++) 
{
    try {
        array[i] = 3*i;
        Console.WriteLine(array[i]);
}   catch(IndexOutOfRangeException) {
        Console.WriteLine("Oopsie!"); } 
}
Console.WriteLine("Array size is: "+size);

//Note for some reason it doesn't write the last one, don't know why