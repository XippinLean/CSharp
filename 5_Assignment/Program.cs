
Console.WriteLine("Hello, welcome to Brandon Currington Cuts Barber Shop. My name is Brandon Currington, let's get you cut.");

string answer = Console.ReadLine();
bool BrandonYes = false;




if (answer == "Sure")
{
    BrandonYes = true;

}

if (BrandonYes == true)
{
    Console.WriteLine("Alright, for sure. Do you want the Brandon Currington Special Cut?");
    answer = Console.ReadLine();
}

if (answer == "no")
{
    BrandonYes = false;
}


if (BrandonYes == false)
{
    Console.WriteLine("I'm dissapointed.");
    Console.ReadLine();
}

if (answer == "yes")
{
    BrandonYes = true;
}

if (BrandonYes == true)
{
    Console.WriteLine("Ait, let get you cut: *Starts cutting your hair*");
    Console.ReadLine();
}

Console.WriteLine("How you want your fade dawg? 1-7 millimeters OG");
int inputFromConsole;
int UserAnswerFromConsole = 0;
bool KeepAsking = true;

do{
    inputFromConsole  = int.Parse(Console.ReadLine());
    int castString = Convert.ToInt32(inputFromConsole);

    switch (castString)
    {
        case 1:
            Console.WriteLine(1);
            KeepAsking = false;
            UserAnswerFromConsole = 1;
            break;
        case 2:
            Console.WriteLine(2);
            KeepAsking = false;
            UserAnswerFromConsole = 2;
            break;
        case 3:
            Console.WriteLine(3);
            KeepAsking = false;
            UserAnswerFromConsole = 3;
            break;
        case 4:
            Console.WriteLine(4);
            KeepAsking = false;
            UserAnswerFromConsole = 4;
            break;
        case 5:
            Console.WriteLine(5);
            KeepAsking = false;
            UserAnswerFromConsole = 5;
            break;
        case 6:
            Console.WriteLine(6);
            KeepAsking = false;
            UserAnswerFromConsole = 6;
            break;
        case 7:
            Console.WriteLine(7);
            KeepAsking = false;
            UserAnswerFromConsole = 7;
            break;
        default:
            Console.WriteLine("That's not between 1 and 7 millimeters fool. Pick a right choice");
            break;
    }

} while (KeepAsking);

Console.WriteLine("Okay, " + UserAnswerFromConsole + " is what we're gonna go with.");
Thread.Sleep(1500);
Console.WriteLine("Brandon Currington Pop Quiz!, what's 9 + 10?");

string[] stringArr = new string[2];
stringArr[0] = "19";
stringArr[1] = "21";
Console.WriteLine("*You have 2 options* " + stringArr[0] + " " + stringArr[1]);

string answer1 = Console.ReadLine();
if (answer1 == stringArr[0])
{
    Console.WriteLine("You is quick with the math");
}

else
{
    Console.WriteLine("You stoopid");
}
Console.ReadLine();


int RecursiveFibonacci(int first, int second, int count)
{
    count--;   
      int nextnumber = first + second;
    first = second;
    second = nextnumber; 

    if(count == 0) {
        return nextnumber;


    }else{
        return RecursiveFibonacci(first, second, count);
    }
}

int lastFibo = RecursiveFibonacci(1,1,69);
Console.WriteLine("The 69th number in Fibonacci is " + lastFibo + " Did you know that? You get all kinds of facts here at Brandons Barber Shop!");
Console.ReadLine(); 



