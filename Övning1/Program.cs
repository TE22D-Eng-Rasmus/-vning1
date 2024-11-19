

if (6 >= 3)
{
    Console.WriteLine("Hello World");
}


string username = "";
string password = "";
while (!(username == "kalleanka" && password == "12345"))
{

    username = Console.ReadLine();
    password = Console.ReadLine();
    if (username == "kalleanka" && password == "12345")
    {
        Console.WriteLine("Welcome");
    }
    else Console.WriteLine("Wrong username or password");
}

int i = 0;
while (i <= 32)
{
    Console.WriteLine("Hello World");
    i++;
}


int tid = 0;
while (tid <= 5)
{
    Console.WriteLine("Välj ett nummer");
    string tal = Console.ReadLine();
    int a = int.Parse(tal);
    tid++;
    if (a > 5)
    {
        Console.WriteLine("högre än 5!");
    }

}

while (!int.TryParse(Console.ReadLine(), out int result)) ;



int r = Random.Shared.Next(51);
int guess = 100;
string g = "";

Console.WriteLine("guess the number!");

while (!(guess == r))
{
    // g = Console.ReadLine();
    // guess = int.Parse(g);
    
while(!int.TryParse(g, out guess)){
    g = Console.ReadLine();
}
    guess = int.Parse(g);

    if (guess < r)
    {
     Console.WriteLine("Wrong! Guess was to low");
    }

    else if (guess > r)
    {
     Console.WriteLine("Wrong! Guess was to high");
    }

    else if (guess == r)
    {
     Console.WriteLine($"Right the answer was {r}");
     Console.ReadLine();
    }
    g = Console.ReadLine();
    guess = int.Parse(g);
}