Random rnd = new Random();
int r = rnd.Next(30, 50);
int duplicate = 0;
int dupamount = 0;
string[] deck = new string[r];
string[] cn = ["2","3","4","5","6","7","8","9","10","J","Q","K","A"];
string[] s = ["H","D","S","C"];

for (int i = 0; i < r ; i++)
{
    duplicate = 0;
    
    Card card = new Card(cn[rnd.Next(13)], s[rnd.Next(4)]);
    Console.WriteLine("New Card: "+card.Suit+""+card.Rank);
    if (i == 0)
    {
        deck[i] = card.Suit+card.Rank;
    }

    for (int id = 0; id < deck.Length ; id++)
    {
        
        if (card.Suit+card.Rank == deck[id])
        {
            Console.Write("Duplicate: ");
            Console.WriteLine(card.Suit+card.Rank);
            duplicate++;
            dupamount++;
        }
    }
    if (duplicate == 0) {deck[i-dupamount] = card.Suit+card.Rank;}
}

for (int number = 0; number < deck.Length; number++)
{
    Console.WriteLine("Deck card: "+number+" is: "+deck[number]);
    //deck adds empty spaces
}

class Card
{
    public string Rank { get; set; }
    public string Suit { get; set; }

    public Card(string rank, string suit)
    {
        Rank = rank;
        Suit = suit;
    }
}


