Console.WriteLine("Hrajete hru o uhadnoti random cisla");

int getGuessedNumber() => Random.Shared.Next(1, 101);
int guessedNumber = getGuessedNumber();
bool end = false;
while (!end)
{
    Console.WriteLine("Zkuste napsat cislo a odpovim jestli je vyssi, nizsi nebo rovne");
    string input = Console.ReadLine();
    int guess=0;
    if (Int32.TryParse(input,out guess))
    {
        if (guess < guessedNumber)
        {
            Console.WriteLine("Cislo je vyssi");
            continue;
        }
        if (guess > guessedNumber)
        {
            Console.WriteLine("Cislo je nizsi");
            continue;
        }
        if (guess == guessedNumber)
        {
            Console.WriteLine("Cislo bylo uhadnuto!!!!!\n Bylo vygenerovano nove\nPokud chcete ukoncit hru napiste konec");
             guessedNumber = getGuessedNumber();

        }

    }

    if (input == "konec")
    {
        Console.WriteLine("Hra se ukoncuje");
        end = true;
        continue;
    } else
        Console.WriteLine("Nezadal jste cislo nebo konec");

}



