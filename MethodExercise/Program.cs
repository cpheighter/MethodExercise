using MethodExercise;

Console.WriteLine("What is your name?");
string name = Console.ReadLine();
Console.WriteLine("What is your age?");
string age = Console.ReadLine();
Console.WriteLine("Enter a color");
string color1 = Console.ReadLine();
Console.WriteLine("Enter a 2nd color");
string color2 = Console.ReadLine();
Console.WriteLine("What is your favorite artist?");
string artist = Console.ReadLine();

Console.WriteLine("There once was a man named " + name + ". He was " + age + " years old. He really liked the name " + name + ". But didnt like being " + age);
Console.WriteLine(name + " made a poem to his favorite band:");
Console.WriteLine("Roses are " + color1);
Console.WriteLine("Violets are " + color2);
Console.WriteLine("I Love " + artist + ". How about you?");

//---------------------------------------------------------------------------------
var total = MathMethod.AddAnything(1, 2, 3);
Console.WriteLine(total);

/*Console.WriteLine(MathMethod.SubtractAnything(50, 10, 20));
Console.WriteLine(MathMethod.MultiplyAnything(10, 2, 5));
Console.WriteLine(MathMethod.DivideAnything(10, 2, 1));*/
