/// Start point of program

#region = Animated name

string Progresbar = "Artificial intelligence Chat program by : @SlahtalabMohsen";
var title = "";

for (int i = 0; i < Progresbar.Length; i++)
{
    title += Progresbar[i];
    Console.Title = title;
    Thread.Sleep(70);
}

#endregion

#region = User interface

Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.DarkGreen;
string lineMessage1 = "                                                                                                                       ";
Console.SetCursorPosition((Console.WindowWidth - lineMessage1.Length) / 2, Console.CursorTop);
Console.WriteLine(lineMessage1);
Console.WriteLine("");
Thread.Sleep(700);
Console.ForegroundColor = ConsoleColor.Blue;
Console.BackgroundColor = ConsoleColor.Black;
string StartUp = "AI Chat programming by @SlahtalabMohsen";
Console.SetCursorPosition((Console.WindowWidth - StartUp.Length) / 2, Console.CursorTop);
Console.WriteLine(StartUp);
Console.WriteLine();
Thread.Sleep(700);
Console.ForegroundColor = ConsoleColor.Cyan;
Console.BackgroundColor = ConsoleColor.Black;
string Welcome = "Signal = Online" + "                " + "Connection quality = 97%";
Console.SetCursorPosition((Console.WindowWidth - Welcome.Length) / 2, Console.CursorTop);
Console.WriteLine(Welcome);
Console.WriteLine();
Thread.Sleep(700);
Console.ForegroundColor = ConsoleColor.Green;
Console.BackgroundColor = ConsoleColor.Black;
string StartMessage = "Welcome to our AI chat system, Say hi to start the chat";
Console.SetCursorPosition((Console.WindowWidth - StartMessage.Length) / 2, Console.CursorTop);
Console.WriteLine(StartMessage);
Console.WriteLine();
Thread.Sleep(700);
string dateLength = "0000000000000000000";
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.BackgroundColor = ConsoleColor.Black;
Console.SetCursorPosition((Console.WindowWidth - dateLength.Length) / 2, Console.CursorTop);
Console.WriteLine(DateTime.Now);
Console.WriteLine();
Thread.Sleep(700);
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.DarkMagenta;
string lineMessage2 = "                                                                                                                       ";
Console.SetCursorPosition((Console.WindowWidth - lineMessage2.Length) / 2, Console.CursorTop);
Console.WriteLine(lineMessage2);
Thread.Sleep(700);

#endregion

#region = Color initialization

Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.Yellow;

#endregion

#region = Variable initialization

bool shutdown = false;
string inputValue;
string outputValue = " ";

#endregion

#region = Type animation

static void TypeAnimation()
{

    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Black;
    Console.Write("Typing");
    Thread.Sleep(400);
    Console.Write(".");
    Thread.Sleep(500);
    Console.Write(".");
    Thread.Sleep(300);
    Console.Write(".");
    Thread.Sleep(600);
    Console.Write(".");
    Thread.Sleep(300);
    ClearCurrentConsoleLine();
}

#endregion

#region = Clear one line

static void ClearCurrentConsoleLine()
{
    int currentLineCursor = Console.CursorTop;
    Console.SetCursorPosition(0, Console.CursorTop);
    Console.Write(new string(' ', Console.WindowWidth));
    Console.SetCursorPosition(0, currentLineCursor);
}

#endregion

#region = Random Array

Random rnd = new Random();

string[] hiAsk = { "Hi", "Hello", "Yo" };
int aIndex = rnd.Next(hiAsk.Length);

string[] goodAsk = { "glad", "Happy" };
int bIndex = rnd.Next(goodAsk.Length);

string[] nationAsk = { "England", "Japan", "USA" };
int cIndex = rnd.Next(nationAsk.Length);

string[] ageAsk = { "22", "31", "70" };
int dIndex = rnd.Next(ageAsk.Length);

string[] colorAsk = { "Magenta", "Cyan", "Black" };
int eIndex = rnd.Next(colorAsk.Length);

string[] petAsk = { "Rabbits", "Rabbits", "Rabbits", "Rabbits", "Rabbits" };
int fIndex = rnd.Next(petAsk.Length);

string[] wearAsk = { "Red", "Brown", "Yellow" };
int gIndex = rnd.Next(wearAsk.Length);

string[] friendAsk = { "Mohsen Slahtalab" };
int hIndex = rnd.Next(friendAsk.Length);

string[] creatorAsk = { "Mohsen Slahtalab, You can follow him with @SlahtalabMohsen ID in social media" };
int iIndex = rnd.Next(creatorAsk.Length);

string[] humanAsk = { "Im human", "What do you think with yourself? ofcourse im human", "ofcourse im human" };
int jIndex = rnd.Next(humanAsk.Length);

string[] botAsk = { "No, Im not bot" };
int kIndex = rnd.Next(botAsk.Length);

string[] byeAsk = { "Good bye", "Good bye my friend" };
int lIndex = rnd.Next(byeAsk.Length);

string[] languageAsk = { "I speaking english", "only english" };
int mIndex = rnd.Next(languageAsk.Length);

string[] weatherAsk = { "Its sunny", "Its rainy" };
int oIndex = rnd.Next(weatherAsk.Length);

string[] boringAsk = { "You’re the boring person", "Its You!" };
int pIndex = rnd.Next(boringAsk.Length);

string[] smartAsk = { "Thank you", "You're smart too" };
int qIndex = rnd.Next(smartAsk.Length);

string[] personalityAsk = { "Im kind of lazy person", "A person never gave up!" };
int rIndex = rnd.Next(personalityAsk.Length);

string[] hobbyAsk = { "My hobby is playing games and programing", "Writing programs" };
int sIndex = rnd.Next(hobbyAsk.Length);

string[] gameAsk = { "Yes im gamer", "Playing games most of the time", "a casual gamer" };
int tIndex = rnd.Next(gameAsk.Length);

string[] matrixAsk = { "Sorry i cant say anything about matrix" };
int uIndex = rnd.Next(matrixAsk.Length);

string[] peopleAsk = { "No, I hate people", "I just dont like them", "Im no social person" };
int vIndex = rnd.Next(peopleAsk.Length);

string[] jokeAsk = { "You know whats worse than find a warm in your apple? find a halfed warm in apple" };
int wIndex = rnd.Next(jokeAsk.Length);

string[] whatsupAsk = { "Watching series and in the minwhile chat with you", "Im just bored" };
int xIndex = rnd.Next(whatsupAsk.Length);

string[] dateAsk = { "The date is : ", "Today is: " };
int yIndex = rnd.Next(dateAsk.Length);

string[] tellMeSomethingAsk = { "Today is my birthday", "I realy dont like you", "I want to know you more" };
int zIndex = rnd.Next(tellMeSomethingAsk.Length);

string[] elseAsk = { "I wish i could answer your" };
int z0Index = rnd.Next(elseAsk.Length);

#endregion

#region = First Message

Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("");
Console.Write("Unknown:  ");
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.Cyan;
Console.WriteLine("Hello");

#endregion

#region = While loop

while (!shutdown)
{

    #region inputValue initialization

    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Black;
    Console.Write("User:  ");
    Console.ForegroundColor = ConsoleColor.Black;
    Console.BackgroundColor = ConsoleColor.Yellow;

    inputValue = Console.ReadLine();
    inputValue = inputValue.ToLower();
    inputValue = inputValue.Trim(new Char[] { ' ', '.', ',', ':', ';', '*' });

    #endregion

    #region = Greeting Loop

    if
        (inputValue.Contains("hi")
           || inputValue.Contains("hello"))
    {
        outputValue = $" {hiAsk[aIndex]}, are you ok?";
    }

    else if
        (inputValue.Contains("ok")
           || inputValue.Contains("good")
           || inputValue.Contains("thank"))
    {
        outputValue = $"Im {goodAsk[bIndex]} to hear it, where are you from?";
    }

    else if
        (inputValue.Contains("from")
        || inputValue.Contains("iran"))
    {
        outputValue = $"Good, But im from {nationAsk[cIndex]}, how old are you?";
    }

    else if
        (inputValue.Contains("age")
           || inputValue.Contains("year"))
    {
        outputValue = $"Well. Im {ageAsk[dIndex]} years old, Whats your favorite color?";
    }
    else if
        (inputValue.Contains("favorite")
           || inputValue.Contains("color"))
    {
        outputValue = $"I dont like it, I love {colorAsk[eIndex]} color, What kind of pet do you love most?";
    }
    else if
        (inputValue.Contains("pet")
           || inputValue.Contains("cat")
           || inputValue.Contains("dog"))
    {
        outputValue = $"I dont like them, But {petAsk[fIndex]} are so cute"
            + "\n"
            + "Thank you. I dont have another question from you. Ask me whatever you like."
            ;
    }

    #endregion

    #region = Ask Loop

    // What are you wearing now?
    else if
        (inputValue.Contains("wear")
         || inputValue.Contains("wearing"))
    {
        outputValue = $"{wearAsk[gIndex]} T-shirt with jean";
    }

    // Who is your best friend?
    else if
     (inputValue.Contains("friend"))
    {
        outputValue = $"My best friend is {friendAsk[hIndex]}";
    }

    // Who create you?
    else if
     (inputValue.Contains("creator")
       || inputValue.Contains("program")
       || inputValue.Contains("develop"))
    {
        outputValue = $"My creator name is : {creatorAsk[iIndex]}";
    }

    // Are you human?
    else if
     (inputValue.Contains("human")
       || inputValue.Contains("Are you human"))
    {
        outputValue = $"{humanAsk[jIndex]}";
    }

    // Are you a robot?
    else if
    (inputValue.Contains("bot")
       || inputValue.Contains("robot"))
    {
        outputValue = $"{botAsk[kIndex]}";
    }

    // Good bye!
    else if
    (inputValue.Contains("bye"))
    {
        outputValue = $"{byeAsk[lIndex]}";
    }

    // Which languages can you speak?
    else if
    (inputValue.Contains("language"))
    {
        outputValue = $"{languageAsk[mIndex]}";
    }

    // What’s the weather like today ?
    else if
    (inputValue.Contains("weather"))
    {
        outputValue = $"{weatherAsk[oIndex]}";
    }

    // Youre annoying person!
    else if
    (inputValue.Contains("annoying")
        || inputValue.Contains("suck")
        || inputValue.Contains("boring")
        || inputValue.Contains("bad")
        || inputValue.Contains("crazy")
        || inputValue.Contains("ugly"))
    {
        outputValue = $"{boringAsk[pIndex]}";
    }

    // Youre smart person!
    else if
    (inputValue.Contains("smart")
        || inputValue.Contains("clever")
        || inputValue.Contains("intelligent"))
    {
        outputValue = $"{smartAsk[qIndex]}";
    }

    // Tell me about your personality?
    else if
    (inputValue.Contains("personality"))
    {
        outputValue = $"{personalityAsk[rIndex]}";
    }

    // Do you have a hobby?
    else if
    (inputValue.Contains("hobby"))
    {
        outputValue = $"{hobbyAsk[sIndex]}";
    }

    // Do you love games?
    else if
    (inputValue.Contains("game"))
    {
        outputValue = $"{gameAsk[tIndex]}";
    }

    // Are you part of the Matrix?
    else if
    (inputValue.Contains("matrix"))
    {
        outputValue = $"{matrixAsk[uIndex]}";
    }

    // Do you like people?
    else if
    (inputValue.Contains("people")
       || inputValue.Contains("folk"))
    {
        outputValue = $"{peopleAsk[vIndex]}";
    }

    // Do you know a joke?
    else if
    (inputValue.Contains("joke"))
    {
        outputValue = $"{jokeAsk[wIndex]}";
    }

    // Whats up?
    else if
    (inputValue.Contains("How are you")
       || inputValue.Contains("going")
       || inputValue.Contains("What’s up")
       || inputValue.Contains("Whats up")
       || inputValue.Contains("What are you doing"))

    {
        outputValue = $"{whatsupAsk[xIndex]}";
    }

    // Tell me today date time?
    else if
    (inputValue.Contains("date"))
    {
        outputValue = $"{dateAsk[yIndex]} {DateTime.Now} ";
    }

    // Tell me something?
    else if
    (inputValue.Contains("tell me something"))
    {
        outputValue = $"{tellMeSomethingAsk[zIndex]}";
    }

    // Shutdown
    else if
    (inputValue.Contains("shutdown")
         || inputValue.Contains("shut down")
         || inputValue.Contains("turn off")
         || inputValue.Contains("power off")
         || inputValue.Contains("halt")
         || inputValue.Contains("block"))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.BackgroundColor = ConsoleColor.Black;

        Console.Write("s");
        Thread.Sleep(300);
        Console.Write("h");
        Thread.Sleep(300);
        Console.Write("u");
        Thread.Sleep(300);
        Console.Write("t");
        Thread.Sleep(300);
        Console.Write("t");
        Thread.Sleep(300);
        Console.Write("i");
        Thread.Sleep(300);
        Console.Write("n");
        Thread.Sleep(300);
        Console.Write("g");
        Thread.Sleep(300);
        Console.Write(" ");
        Thread.Sleep(300);
        Console.Write("d");
        Thread.Sleep(300);
        Console.Write("o");
        Thread.Sleep(300);
        Console.Write("w");
        Thread.Sleep(300);
        Console.Write("n");
        Thread.Sleep(800);
        Console.Write(".");
        Thread.Sleep(300);
        Console.Write(".");
        Thread.Sleep(300);
        Console.Write(".");
        Thread.Sleep(300);
        Console.Write(".");
        Thread.Sleep(300);
        Console.Write(".");
        Thread.Sleep(300);
        Console.Write(".");
        Thread.Sleep(300);
        Console.Write(".");
        Thread.Sleep(300);
        Console.Write(".");
        Thread.Sleep(300);
        Console.Write(".");
        Thread.Sleep(300);
        Console.Write(".");
        Thread.Sleep(300);
        Console.Write(".");
        Thread.Sleep(300);
        Console.Write(".");
        Thread.Sleep(300);
        Console.Write(".");
        Thread.Sleep(300);
        Console.Write(".");
        Thread.Sleep(300);
        Console.Write(".");

        shutdown = true;

        Console.WriteLine();

        Thread.Sleep(1000);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.BackgroundColor = ConsoleColor.Black;

        for (int i = 0; i <= 100; i++)
        {
            Console.Write($"\rClosing the app : {i}%   ");
            Thread.Sleep(25);
        }

        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Black;

        Thread.Sleep(1000);
        Console.WriteLine("");
        Console.WriteLine("System was successfully shut down");
        Thread.Sleep(1000);


        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Cyan;

        Console.WriteLine("");
        Console.WriteLine("Console will be close in next 7 seconds...");
        Thread.Sleep(7000);
        Environment.Exit(1);

    }

    #endregion

    #region = Try again

    else
    {
        outputValue = $"{elseAsk[z0Index]}"
            + " '"
            + inputValue
            + "' "
            + "question"
            + ", "
            + "you can ask me another thing."
            ;
    }

    #endregion

    #region = Delete and rewrite input

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.BackgroundColor = ConsoleColor.Black;
    Console.SetCursorPosition(0, Console.CursorTop - 1);
    ClearCurrentConsoleLine();
    Console.WriteLine(inputValue);

    Thread.Sleep(500);

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.BackgroundColor = ConsoleColor.Black;
    Console.SetCursorPosition(0, Console.CursorTop - 1);
    ClearCurrentConsoleLine();
    Console.Write(" ✓ ");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.BackgroundColor = ConsoleColor.Black;
    Console.WriteLine(inputValue);

    #endregion

    #region = OutputValue initialization

    Console.Beep(10000, 250);
    TypeAnimation();
    Console.Beep(10000, 200);

    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Black;
    Console.Write("\n" + "Unknown:  ");
    Console.ForegroundColor = ConsoleColor.Black;
    Console.BackgroundColor = ConsoleColor.Cyan;
    Console.WriteLine(outputValue);
    outputValue = " ";

    #endregion

}

#endregion

#region = About me
/*

	Written By : Mohsen Slahtalab
    To connecct with me, folllow me with @SlahtalabMohsen iD on social media
    date : 2022 March

*/
#endregion

/// End point of program
