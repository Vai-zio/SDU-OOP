Random rnd = new Random();
bool state = false;

for (int i = 0; i < 10; i++) {
int dice = rnd.Next(1, 7);
if(dice >= 3) {
    state = true; 
    Console.WriteLine("Is the dice 3 or above?: " + state);
    Console.WriteLine("The dice roll was: " + dice);
};
if(dice < 3) {
    state = false;
    Console.WriteLine("Is the dice 3 or above?: " + state);
    Console.WriteLine("The dice roll was: " + dice); 
};
};