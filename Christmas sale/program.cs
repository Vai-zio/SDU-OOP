Random rnd = new Random();
int a = 21816000;
double price = 599.95;
bool IsItChristmas = false;
int Dec = 0;
int i = 0;

while(i < 10) {
    int rndtime = rnd.Next(1,13);
    int time = (a/12)*rndtime;
    Dec = a - (a / 12);
    if(time >= Dec) { 
        IsItChristmas = true;
        Console.WriteLine("The new price would then equivulate to :" +(price*0.7));
        }
    Console.WriteLine("IsItChristmas: "+IsItChristmas);
    Console.WriteLine("The generated month was the: "+rndtime);
    Console.WriteLine("");
    i++;
}