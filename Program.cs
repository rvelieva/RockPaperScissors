
    internal class RockPperScissorsGame
{
    static void GameEnglish()
    {
        string rock = "Rock";
        string scissors = "Scisssors";
        string paper = "Paper";
        Console.Write("Choose rock[r], paper[p], scissor[s]: ");
        string playerMove = Console.ReadLine();
        if (playerMove == "r" || playerMove == "rock" || playerMove == "Rock")
        {
            playerMove = rock;
        }
        else if (playerMove == "p" || playerMove == "Paper" || playerMove == "paper")
        {
            playerMove = paper;
        }
        else if (playerMove == "s" || playerMove == "scissors" || playerMove == "Scissors")
        {
            playerMove = scissors;
        }
        else
        {
            Console.WriteLine("Invalid move. Try again...");
            return;
        }

        Random r = new Random();
        int computerRandomNum = r.Next(1, 4);
        string computerMove = "";
        switch (computerRandomNum)
        {
            case 1:
                computerMove = rock;
                break;
            case 2:
                computerMove = scissors;
                break;
            case 3:
                computerMove = paper;
                break;
        }
        Console.WriteLine($"Your choise {playerMove}");
        Console.WriteLine($"Computer choise {computerMove}");
        if ((playerMove == rock && computerMove == scissors) || (playerMove == paper && computerMove == rock) || (playerMove == scissors && computerMove == paper))
            Console.WriteLine("You win!");
        else if ((playerMove == rock && computerMove == paper) || (playerMove == paper && computerMove == scissors) || (playerMove == scissors && computerMove == rock))
            Console.WriteLine("You lose!");
        else
            Console.WriteLine("Draw!");


    }
    static void English()
    {
        GameEnglish();
        string playerAnswear = "";
        while (true)
        {
            Console.Write("Do you want to play again:");
            playerAnswear = Console.ReadLine();
            if (playerAnswear == "yes" || playerAnswear == "Yes")
            {
                GameEnglish();
            }
            else if (playerAnswear == "no" || playerAnswear == "No") 
                break;
        }
        Console.WriteLine("Thank you for the play!");
    }
    static void GameBulgarian()
    {
        string rock = "Камък";
        string scissors = "Ножица";
        string paper = "Хартия";
        Console.Write("Избери камък[к], хартия[х], ножица[н]: ");
        string playerMove = Console.ReadLine();
        if (playerMove == "к" || playerMove == "камък" || playerMove == "Камък")
        {
            playerMove = rock;
        }
        else if (playerMove == "х" || playerMove == "Хартия" || playerMove == "хартия")
        {
            playerMove = paper;
        }
        else if (playerMove == "н" || playerMove == "ножица" || playerMove == "Ножица")
        {
            playerMove = scissors;
        }
        else
        {
            Console.WriteLine("Невалидно. Пробвай пак...");
            return;
        }

        Random r = new Random();
        int computerRandomNum = r.Next(1, 4);
        string computerMove = "";
        switch (computerRandomNum)
        {
            case 1:
                computerMove = rock;
                break;
            case 2:
                computerMove = scissors;
                break;
            case 3:
                computerMove = paper;
                break;
        }
        Console.WriteLine($"Ти избра {playerMove}");
        Console.WriteLine($"Компютърът избра {computerMove}");
        if ((playerMove == rock && computerMove == scissors) || (playerMove == paper && computerMove == rock) || (playerMove == scissors && computerMove == paper))
            Console.WriteLine("Ти спечели!");
        else if ((playerMove == rock && computerMove == paper) || (playerMove == paper && computerMove == scissors) || (playerMove == scissors && computerMove == rock))
            Console.WriteLine("Ти загуби!");
        else
            Console.WriteLine("Равенство!");


    }

    static void Bulgarian()
    {
        GameBulgarian();
        string playerAnswear = "";
        while (true)
        {
            Console.Write("Искаш ли да играеш пак:");
            playerAnswear = Console.ReadLine();
            if (playerAnswear == "да" || playerAnswear == "Да")
            {
                GameEnglish();
            }
            else if (playerAnswear == "не" || playerAnswear == "Не")
            {
                break;
            }
        }
        Console.WriteLine("Благодаря ти за играта!");
    }
    static void Main()
    {
        Console.WriteLine("Choose language (Избери език)");
        Console.Write("English Български - ");
        string language = Console.ReadLine();
        while(language!= "English"&& language != "english"&& language != "Български" && language != "български")
        {
            Console.WriteLine("Невалиден език. Invalid language");
            Console.Write("Опитай отново Try again - ");
            language = Console.ReadLine();

        }
        if (language == "English"|| language == "english")
            English();
        else if (language == "Български" || language == "български")
            Bulgarian();

    }
}
