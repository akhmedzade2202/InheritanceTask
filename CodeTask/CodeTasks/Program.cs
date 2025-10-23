using CodeAcaTasks;
using System.Data.SqlTypes;


Substring sub = new Substring();

string text = "Bu bir custom substring testidir.";

Console.WriteLine(sub.customSubstring(text, 3));
Console.WriteLine(sub.customSubstring(text, 6, 6));

Console.WriteLine("*****************************************");


CustomContains contains = new CustomContains();

string cumle = "Bu bir Custom Contains Methodudur";

Console.WriteLine(contains.customContains(cumle, "Bu"));
Console.WriteLine(contains.customContains(cumle, 'B'));