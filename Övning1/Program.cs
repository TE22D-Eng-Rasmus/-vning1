

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
    string tal = Console.ReadLine();
    int a = int.Parse(tal);
tid++;
}