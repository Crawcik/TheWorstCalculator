using System;
using System.IO;

const string methodOffset = "\t\t";
int iterations = int.Parse(Console.ReadLine());
Console.WriteLine();

using (StreamWriter writer = new StreamWriter(File.Create("Pomocy.cs")))
{

	writer.AutoFlush = true;
	writer.Write("using System;\n\n");
	writer.Write("public static class Calculator\n{\n");
	writer.Write("\tpublic static void Main(string[] args)\n\t{\n");
	writer.Write(methodOffset + $"Console.WriteLine(\"Max number: {iterations.ToString()}\");\n");
	writer.Write(methodOffset + "Console.WriteLine(\"First number: \");\n");
	writer.Write(methodOffset + "int a = int.Parse(Console.ReadLine());\n");
	writer.Write(methodOffset + "Console.WriteLine(\"Second number: \");\n");
	writer.Write(methodOffset + "int b = int.Parse(Console.ReadLine());\n");
	writer.Write(methodOffset + "Console.WriteLine(\"Do u wanna: a - Add, b - Subtract\");\n");
	writer.Write(methodOffset + "char method = Console.ReadKey().KeyChar\t\n");
	writer.Write(methodOffset + "int result;\n");
	writer.Write(methodOffset + $"if(method == 'a')\n{methodOffset}{{\n{methodOffset}\tresult = Add(a, b);\n{methodOffset}}}\n");
	writer.Write(methodOffset + $"else if(method == 'b')\n{methodOffset}{{\n{methodOffset}\tresult = Subtract(a, b);\n{methodOffset}}}\n");
	writer.Write(methodOffset + "Console.WriteLine(\"Output: \" + result);\n");

	//End method
	writer.Write("\t}\n");

	//Adding
	Adding(writer);
	Subtraction(writer);

	//End class
	writer.Write("}");
	writer.Flush();
	writer.Close();
}

void Adding(StreamWriter writer)
{

	writer.Write($"\n\tpublic static int Add(int a, int b)\n\t{{\n");
	writer.Write($"{methodOffset}if(a == 0 && b == 0)\n{methodOffset}{{\n{methodOffset}\treturn 0;\n{methodOffset}}}\n");

	//Yandere dev would be proud
	for (int a = 0; a <= iterations; a++)
	{
		for (int b = 0; b <= iterations; b++)
			writer.Write($"{methodOffset}else if(a == {a} && b == {b})\n{methodOffset}{{\n{methodOffset}\treturn {a+b};\n{methodOffset}}}\n");
	}
	writer.Write($"{methodOffset}throw new Exception(\"Calculator cannot calculate this numbers ;-;\")\n");
	writer.Write("\t}\n");
}

void Subtraction(StreamWriter writer)
{

	writer.Write($"\n\tpublic static int Subtract(int a, int b)\n\t{{\n");
	writer.Write($"{methodOffset}if(a == 0 && b == 0)\n{methodOffset}{{\n{methodOffset}\treturn 0;\n{methodOffset}}}\n");

	//Adding
	for (int a = 0; a <= iterations; a++)
	{
		for (int b = 0; b <= iterations; b++)
			writer.Write($"{methodOffset}else if(a == {a} && b == {b})\n{methodOffset}{{\n{methodOffset}\treturn {a - b};\n{methodOffset}}}\n");
	}
	writer.Write($"{methodOffset}throw new Exception(\"Calculator cannot calculate this numbers ;-;\")\n");
	writer.Write("\t}\n");

}