Random rnd = new Random(); //import random library 
int clow = 0; // current lowest
int[] array = new int[rnd.Next(10,26)]; //random int between 10 and 25
//This creates an array consisting of only zeros
Console.WriteLine("We are working with an array of a size: "+array.Length);
Console.WriteLine("The randomly generated array is as follows:");
// Array creation and printing
for(int i = 0; i < array.Length; i++) {
    array[i] = rnd.Next(-101,101); 
    Console.Write("|" + array[i]);
}
    Console.WriteLine("|"); //end statement to close the loop

//Highest negative number finder
for(int n = 0; n < array.Length;n++) { //foreach loop to find highest negative value
    try {
    //Console.Write("|"+array[n]); Debugging
    if(array[n] < clow) {
        clow = array[n];
    }
    } catch(IndexOutOfRangeException) {Console.WriteLine("IndexError");} //Debugging
}
//Console.WriteLine("|"); //end statement to close the loop //Debug for earlier on line 15
int index = Array.IndexOf(array, clow);
Console.WriteLine("The lowest value in the generated array is: "+clow+" and its on index: "+index);

//made in 15 min