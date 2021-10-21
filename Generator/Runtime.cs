using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Mono.TextTemplating;
using Mono.Options;


internal class Generator
{
	private static readonly string[] _yesTypes = { "y", "yes", "", "yup" };
	private static readonly char[] _defaultOperators = { 'a', 's' };
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
		bool autorun = true;
		bool inputIsFile = true;
		bool outputIsGenerated = false;

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
			foreach (var source in optionSet)
				Console.WriteLine($" - {string.Join(", ", source.GetNames())}\t{source.Description}");
			return;
        }
		
		//Preparing options
		if (_options.MaxNumber <= 0)
		{
			autorun = false;
			Console.Write("What will be the maximum number (1000 and above will take long time to generate): ");
			if(!int.TryParse(Console.ReadLine(), out _options.MaxNumber))
			{
				Console.Write("\nWrong or too big number!\n");
				return;
			}
		}
		
		string path = _options.Input;

		CheckFile:
		if(File.Exists(path))
		{
			inputIsFile = true;
		}
		else if(Directory.Exists(path))
		{
			inputIsFile = false;
		}
		else if(_options.Input is not null)
		{
			Console.WriteLine("Wrong path to file or directory!");
			return;
		}
		else
		{

			if(path is null)
			{
				path = Path.Combine(Directory.GetCurrentDirectory(), "..", "Templates");
				if(Directory.Exists(path))
				{
					if(CheckIf("Do you wanna generate default templates?"))
						goto CheckFile;
				}
			}
			autorun = false;
			Console.Write("\nPlease enter template file path (e.g. cs.tt - CSharp template): ");
			path = Console.ReadLine();
			goto CheckFile;
		}

		_options.Input = path;
		_options.Operators ??= autorun ? _defaultOperators : GetOperators();

		if(!autorun || _options.Output is null)
		{
			outputIsGenerated = true;
			_options.Output = Directory.GetCurrentDirectory();
		}

		//Generating file/files
		Console.Write("\nGenerating code...");
		if(inputIsFile)
		{
			GenerateCode(_options.Input, _options.Output, outputIsGenerated);
			return;
		}

		IEnumerable<string> files = Directory.GetFiles(_options.Output).Where(x=>x.EndsWith(".tt"));
		foreach(string file in files)
			GenerateCode(file, _options.Output, outputIsGenerated);

	}

	private static void GenerateCode(string input, string output, bool outputIsGenerated)
	{
		if(outputIsGenerated || Directory.Exists(output))
			_options.Output = Path.Combine(output, "calculator." + Path.GetFileNameWithoutExtension(_options.Input));
		TemplateGenerator templateGenerator = new();
		templateGenerator.TryAddParameter("MaxNumber=" + _options.MaxNumber);
		templateGenerator.TryAddParameter("Operators=" + _options.Output);
		Console.WriteLine((templateGenerator.ProcessTemplate(input, output) 
		? "\n - Created: "
		: "\n - Something went wrong creating: ")
		+ Path.GetRelativePath(Directory.GetCurrentDirectory(), output));
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
}