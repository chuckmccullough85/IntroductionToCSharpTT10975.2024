int wholeNum = -20;
long bigNum = 22_678_123;
uint positive = 223;
var pif = 3.14f;
double pid = 3.141567896;
decimal money = 0;

char c = 'c';
string text = "This is a string";

Console.WriteLine($@"I wrote a program in C# and here is some data:
wholeNum: {wholeNum},
bigNum: {bigNum},
positive: {positive},
pif: {pif},
pid: {pid},
c: {c},
and text: {text}.
Have a nice day!");

Console.WriteLine($"""
   Oh, and here is the same thing, but with a raw string:
   wholeNum: {wholeNum},
   bigNum: {bigNum},
   positive: {positive},
   pif: {pif},
   pid: {pid},
   c: {c},
   and text: {text}.
   Have a nice day!
   """);
