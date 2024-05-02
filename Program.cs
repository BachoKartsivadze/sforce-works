

Random rnd = new Random();
int guessNumber = 0;
string hint = "";
Console.WriteLine("input range minimum");
int lower =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input range maximum");
int higher =  Convert.ToInt32(Console.ReadLine());
while(true) {
    guessNumber = (higher + lower)/2;
    Console.WriteLine($"is your number {guessNumber}?");
    Console.WriteLine($"write {"yes"}, {"<"} or {">"} ");
    hint = Console.ReadLine();
    if (hint == "yes") {
        Console.WriteLine("END");
        return;
    }
    if (hint == "<") {
        higher = guessNumber-1;
    }
    if (hint == ">") {
        lower = guessNumber+1;
    }

}
