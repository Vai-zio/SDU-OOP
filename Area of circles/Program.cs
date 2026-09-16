double pi = 3.141592;
int[] radius = {1,3,5};
for(int i = 0; i < radius.Length; i++) {
    Console.WriteLine("The radius of circle "+(i+1)+" is equal to: "+((double)pi*radius[i]));
}