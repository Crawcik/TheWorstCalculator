using System;
using System.IO;

int iterations = int.Parse(Console.ReadLine());
int divide = iterations / 100;
Console.WriteLine();
using (StreamWriter writer = new StreamWriter(File.Create("Pomocy.cs")))
{
	writer.AutoFlush = true;
	writer.Write("using System;\n\n");
	writer.Write("Console.WriteLine(\"Max number: " + iterations.ToString() + "\");\n");
	writer.Write("Console.WriteLine(\"First number: \");\n");
	writer.Write("int a = int.Parse(Console.ReadLine());\n");
	writer.Write("Console.WriteLine(\"Second number: \");\n");
	writer.Write("int b = int.Parse(Console.ReadLine());");
	writer.Write("Console.WriteLine(\"Output:\");\n");
	writer.Write("if(a == 0 && b == 0)\n{\n\tConsole.WriteLine(0);\n}\n");
	for (int a = 0; a < iterations; a++)
	{
		Console.SetCursorPosition(0, 1);
		Console.Write((a / divide).ToString() + "%");
		for (int b = 0; b < iterations; b++)
		{
			writer.Write("else if(a == " +a+" && b == "+b+")\n{\n\tConsole.WriteLine("+ (a + b) + ");\n}\n");
			writer.Write(string.Concat(new string[]
			{
					"else if(a == ",
					a.ToString(),
					" && b == ",
					b.ToString(),
					")\n{\n\tConsole.WriteLine(",
					(a + b).ToString(),
					");\n}\n"
			}));
		}
	}
	writer.Flush();
	writer.Close();
}