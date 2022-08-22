
Console.WriteLine("Hello, welcome to Brandon Currington Cuts Barber Shop. My name is Brandon Currington, let's get you cut.");

string answer = Console.ReadLine();
bool BrandonYes = false; 


   

if (answer == "Sure") {
     BrandonYes = true;

}

if (BrandonYes == true) {
    Console.WriteLine("Alright, for sure. Do you want the Brandon Currington Special Cut?");
    answer = Console.ReadLine();
}

if (answer == "no") {
    BrandonYes = false;
}


if (BrandonYes == false ) {
    Console.WriteLine("I'm dissapointed.");
    Console.ReadLine();
}

if (answer == "yes") {
    BrandonYes = true;
}

if (BrandonYes == true) {
    Console.WriteLine("Ait, let get you cut: *Starts cutting your hair*");
    Console.ReadLine();
}

Console.WriteLine("How you want your fade dawg? 1-7 millimeters OG");
string inputFromConsole = Console.ReadLine();
int day = int.Parse(inputFromConsole);
string UserAnswerFromConsole = "";

switch (day) 
{
  case 1:
    Console.WriteLine("1mm");
    UserAnswerFromConsole = "1mm";
    break;
  case 2:
    Console.WriteLine("2mm");
    UserAnswerFromConsole = "2mm";
    break;
  case 3:
    Console.WriteLine("3mm");
    UserAnswerFromConsole = "3mm";
    break;
  case 4:
    Console.WriteLine("4mm");
    UserAnswerFromConsole = "5mm";
    break;
  case 5:
    Console.WriteLine("5mm");
    UserAnswerFromConsole = "5mm";
    break;
  case 6:
    Console.WriteLine("6mm");
    UserAnswerFromConsole = "6mm";
    break;
  case 7:
    Console.WriteLine("7mm");
    UserAnswerFromConsole = "7mm";
    break;
  default:
    Console.WriteLine("That's not between 1 and 7 millimeters fool.");
    break;
}

{

Console.WriteLine("Okay, " + UserAnswerFromConsole + " is what we're gonna go with.");
Thread.Sleep(1500);
Console.WriteLine("Brandon Currington Pop Quiz!, what's 9 + 10?");
Console.ReadLine();
}

if(9+10 == 21)
{
Console.WriteLine("You're stupid.");
Console.ReadLine();
}
else if(9+10 == 19)
{
  Console.WriteLine("You're quick with the mathematics homie.");
  Console.ReadLine();
}

