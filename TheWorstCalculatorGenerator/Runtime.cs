using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Mono.TextTemplating;
using Mono.Options;


internal class Generator
{
	private static readonly string[] _yesTypes = { "y", "yes", "", "yup" };
	private static Options _options = new Options
	{
		Operators = null,
		Input = null,
		Output = null,
		MaxNumber = 0
	};

	private static void Main(string[] args)
	{
		//Getting arguments
		bool help = false;
		OptionSet optionSet = new()
		{
			{ "m|max=", "Sets the maximum number", (value) => _options.MaxNumber = int.Parse(value) },
			{ "i|input=", "Input template file", (value) => _options.Input = value },
			{ "o|output=", "Output file (optional)", (value) => _options.Output = value },
			{ "p|operators=", "Sets operators (optional)", (value) => _options.Operators = value.ToLower().ToCharArray() },
			{ "h|help", "Show avalible commands (optional)", (value) => help = true }
		};

		try
		{
			optionSet.Parse(args);
			if(_options.Input is not null)
				File.Exists(_options.Input);
			if (_options.Output is not null)
				File.Exists(_options.Input);
		}
		catch(OptionException)
		{
			help = true;
		}
		catch(Exception e)
		{
			Console.WriteLine(e.Message);
			help = true;
		}

		if (help)
		{
			Console.WriteLine("Usage: command [OPTIONS]");
			foreach (var source in optionSet.ArgumentSources)
				Console.WriteLine($" - {string.Join(',', source.GetNames())}\t{source.Description}");
			return;
        }

		//Setting maximum number
		if (_options.MaxNumber == 0)
		{
			Console.Write("What will be the maximum number (1000 and above will take long time to generate): ");
			if(int.TryParse(Console.ReadLine(), out _options.MaxNumber))
				Console.Write("What will be the maximum number (1000 and above will take long time to generate): ");
		}
		_options.Operators ??= GetOperators();
	}

	private static void CreateFile(string filename)
	{
		Console.Write("\n\nCreating file...");
		TemplateGenerator templateGenerator = new();
		templateGenerator.TryAddParameter("MaxNumber=" + _options.MaxNumber);
		templateGenerator.TryAddParameter("Operators=" + _options.Output);
		//templateGenerator.ProcessTemplate(filename.);

	}

	private static char[] GetOperators()
	{
		List<char> options = new();

		if (CheckIf("Do you wanna include all math operations?"))
			return new[] { 'a', 's', 'm', 'd' };
		if (CheckIf("Do you wanna include ADDING?"))
			options.Add('a');
		if (CheckIf("Do you wanna include SUBTRACTION?"))
			options.Add('s');
		if (CheckIf("Do you wanna include MULTIPLYING?"))
			options.Add('m');
		if (CheckIf("Do you wanna include SUBTRACTION?"))
			options.Add('d');
		return options.ToArray();
	}

	private static bool CheckIf(string question)
	{
		Console.Write("\n" + question + " [Y/n]: ");
		return _yesTypes.Contains(Console.ReadLine().ToLower());
	}

	private static int GetNumber(char type, int a, int b) => type switch
	{
		'a' => a + b,
		's' => a - b,
		'm' => a * b,
		'd' => b == 0 ? 0 : a / b,
		_ => throw new ArgumentException("Wrong argument has been given")
	};

	private static string GetName(char type) => type switch
	{
		'a' => "Add",
		's' => "Subtract",
		'm' => "Multiple",
		'd' => "Divide",
		_ => throw new ArgumentException("Wrong argument has been given")
	};
}
	/*
	const string methodOffset = "\t\t";
	const string fileName = "Program.cs";
	string[] yesTypes = { "y", "yes", "" };

	Console.Write("How big number can be used (above 1000 will take more time to generate): ");
	int iterations = int.Parse(Console.ReadLine());
	char[] operators = args.Length == 1 ? args[0].ToLower().ToCharArray() : GetOperators();

	Console.Write("\n\nCreating file...");
	using (StreamWriter writer = new(File.Create(fileName)))
	{

		writer.AutoFlush = true;
		writer.Write("using System;\n\n");
		//Start of class
		writer.Write("public static class Calculator\n{\n");
		//Main method
		writer.Write("\tpublic static void Main(string[] args)\n\t{\n");
		writer.Write(methodOffset + $"Console.WriteLine(\"Max number: {iterations.ToString()}\");\n");
		writer.Write(methodOffset + "Console.WriteLine(\"First number: \");\n");
		writer.Write(methodOffset + "int a = int.Parse(Console.ReadLine());\n");
		writer.Write(methodOffset + "Console.WriteLine(\"Second number: \");\n");
		writer.Write(methodOffset + "int b = int.Parse(Console.ReadLine());\n");
		writer.Write(methodOffset + "Console.WriteLine(\"Do u wanna: a - Add, b - Subtract, c - Multiple, d - Divide\");\n");
		writer.Write(methodOffset + "char method = Console.ReadKey().KeyChar;\n");
		writer.Write(methodOffset + "int result = 69;\n"); //I wanna die
		writer.Write(methodOffset + $"if(method == 'a')\n{methodOffset}{{\n{methodOffset}\tresult = Add(a, b);\n{methodOffset}}}\n");
		writer.Write(methodOffset + $"else if(method == 'b')\n{methodOffset}{{\n{methodOffset}\tresult = Subtract(a, b);\n{methodOffset}}}\n");
		writer.Write(methodOffset + $"else if(method == 'c')\n{methodOffset}{{\n{methodOffset}\tresult = Multiple(a, b);\n{methodOffset}}}\n");
		writer.Write(methodOffset + $"else if(method == 'd')\n{methodOffset}{{\n{methodOffset}\tresult = Divide(a, b);\n{methodOffset}}}\n");
		writer.Write(methodOffset + "Console.WriteLine(\"\\nOutput: \" + result);\n");
		//End main method
		writer.Write("\t}\n");

		//Meth
		foreach(char opt in operators)
			Calc(writer, opt);

		//End of class
		writer.Write("}");
		writer.Flush();
		writer.Close();
	}

	Console.Write("\nFile will appear in: " + Path.Combine(Directory.GetCurrentDirectory(),fileName));

	void Calc(StreamWriter writer, char type)
	{

		writer.Write($"\n\tpublic static int {GetName(type)}(int a, int b)\n\t{{\n");
		writer.Write($"{methodOffset}if(a == 0 && b == 0)\n{methodOffset}{{\n{methodOffset}\treturn 0;\n{methodOffset}}}\n");

		//Yandere dev would be proud
		for (int a = 0; a <= iterations; a++)
		{
			for (int b = 0; b <= iterations; b++)
				writer.Write($"{methodOffset}else if(a == {a} && b == {b})\n{methodOffset}{{\n{methodOffset}\treturn {GetNumber(type,a,b)};\n{methodOffset}}}\n");
		}
		writer.Write($"{methodOffset}throw new Exception(\"Calculator cannot calculate this numbers ;-;\");\n");
		writer.Write("\t}\n");
	}

	int GetNumber(char type, int a, int b) => type switch
	{
		'a' => a + b,
		's' => a - b,
		'm' => a * b,
		'd' => b == 0 ? 0 : a / b,
		_ => throw new ArgumentException("Wrong argument has been given")
	};

	string GetName(char type) => type switch
	{
		'a' => "Add",
		's' => "Subtract",
		'm' => "Multiple",
		'd' => "Divide",
		_ => throw new ArgumentException("Wrong argument has been given")
	};
	*/