using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpriteCreator.Shell.Tools;

namespace SpriteCreator.Shell
{
	class Program
	{
		static void Main(string[] args)
		{
			SCEngineOptions options = new SCEngineOptions();

			if (args !=  null && args.Length > 0)
			{
				for (int i = 0; i < args.Length; i++)
				{
					switch (args[i])
					{
						case "/?":
						case "/h":
						case "/help":
							Console.WriteLine("/source		:: Source dir path.");
							Console.WriteLine("/destination	:: Destination dir path.");
							Console.WriteLine("/classprefix	:: Class name prefix.");
							return;
						case "/s":	// source directory path
							if (args.Length >= i)
							{
								options.SourceDirectory = args[i + 1];
								i++;
							}
							else
								ProcessActivity.InvalidSourceDirectory();
							break;
						case "/d":	// destination directory path
						case "/D":	// capital D means create if it doesn't exist
							if (args.Length >= i)
							{
								if (args[i] == "/D")
									options.CreateDirectory = true;

								options.DestinationDirectory = args[i + 1];
								i++;
							}
							else
								ProcessActivity.InvalidDestinationDirectory();
							break;
						case "/f":	// destination files name (lower-case means no override)
						case "/F":	// capital F means override current files
							if (args.Length >= i)
							{
								if (args[i] == "/F")
									options.Override = true;

								options.FilesName = args[i + 1];
								i++;
							}
							else
								ProcessActivity.InvalidDestinationFileName();
							break;
						case "/cp":	// class prefix
							if (args.Length >= i)
								options.CssClassPrefix = args[i + 1];
							else
								ProcessActivity.InvalidCSSClassPrefix();
							break;
						case "/pl":	// bin packing level
							if (args.Length >= i)
							{
								int pl = 2;
								int.TryParse(args[i + 1], out pl);
								options.BinPackingLevel = pl;
							}
							else
								ProcessActivity.InvalidBinPackingLevel();
							break;
						default:
							break;
					}
				}
			}

			SCEngine engine = new SCEngine();
			try
			{
				engine.GenerateSprite(options);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
