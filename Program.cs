// See https://aka.ms/new-console-template for more information

Console.WriteLine("Spock: What's your name?");
string fname = Console.ReadLine();
Console.WriteLine(fname + ": " + fname);

Console.WriteLine("Spock: So your name is " + fname);
Console.WriteLine("Spock: " + fname + " Who?");
string lname = Console.ReadLine();
Console.WriteLine(fname + ": " + lname);
Console.WriteLine(fname + ": " + fname + " " + lname);
Console.WriteLine("Spock: Where do you come from, " + fname + " " + lname + "?");
string planet = Console.ReadLine();
Console.WriteLine(fname + ": " + planet);
if (planet == "Earth")
{
    Console.WriteLine("Spock: My Mother is from Earth too\n"+fname+": But ... but your ears-\nSpock: I get that a lot. My father is Vulcan");
    Console.WriteLine(fname+": Nice to meet you sir. I have great things about you. I have to go now.");
    Console.WriteLine("Spock: Live long and prosper.");
    Console.WriteLine(fname+": Peace and long life.");



}
else
{
    Console.WriteLine("Spock: " + planet + ", is that a planet?");
    Console.WriteLine(fname + ": No, its a moon?");
    Console.WriteLine("Spock: Fascinating. What planet does it orbit?");
    Console.WriteLine(fname+": Saturn. Nice to meet you sir. I have great things about you. I have to go now.");
    Console.WriteLine("Spock: Live long and prosper.");
    Console.WriteLine(fname+": Peace and long life.");






}













