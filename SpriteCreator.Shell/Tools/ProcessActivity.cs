using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpriteCreator.Shell.Tools
{
	/// <summary>
	/// Centralizes and processes all activity reports
	/// </summary>
	public static class ProcessActivity
	{

		public static void CreateDirectoryAccessDenied()
		{
			Error("Access restrictions prevented the process to create the destination directory.");
			Environment.Exit((int)ExitCodes.CreateDirectoryAccessDenied);
		}

		public static void CreateFileAccessDenied()
		{
			Error("Access restrictions prevented the process to create the result files.");
			Environment.Exit((int)ExitCodes.CreateFilesAccessDenied);
		}

		public static void DestinationDirectoryDoesNotExist()
		{
			Error("The destination directory does not exist. Use /D if you want to create it automatically");
			Environment.Exit((int)ExitCodes.CreateDirectoryAccessDenied);
		}

		public static void FileAlreadyExists()
		{
			Error("Cannot create file because file already exists. Use the /F argument if you want to override.");
			Environment.Exit((int)ExitCodes.FileAlreadyExists);
		}

		public static void InvalidSourceDirectory()
		{
			Error("Invalid source directory command input.");
			Environment.Exit((int)ExitCodes.InvalidSourceDirectory);
		}

		public static void InvalidDestinationDirectory()
		{
			Error("Invalid destination directory command input.");
			Environment.Exit((int)ExitCodes.InvalidDestinationDirectory);
		}

		public static void InvalidDestinationFileName()
		{
			Error("Invalid destination file name command input.");
			Environment.Exit((int)ExitCodes.InvalidDestinationFileName);
		}

		public static void InvalidCSSClassPrefix()
		{
			Error("Invalid CSS class prefix command input.");
			Environment.Exit((int)ExitCodes.InvalidCSSClassPrefix);
		}

		public static void InvalidBinPackingLevel()
		{
			Error("Invalid Bin Packing level command input.");
			Environment.Exit((int)ExitCodes.InvalidBinPackingLevel);
		}

		public static void UnhandledError(string where)
		{
			if (string.IsNullOrEmpty(where))
				where = "unknown";

			Error(string.Format("An unhandled error occurred on {0}", where));
			Environment.Exit((int)ExitCodes.UnhandledError);
		}

		public static void ProcessEndedSuccessfully()
		{
			Success("Finished!");
			Environment.Exit((int)ExitCodes.Success);
		}




		public static void Error(string message)
		{
			var prevColor = Console.ForegroundColor;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(message);
			Console.ForegroundColor = prevColor;
		}

		public static void Warning(string message)
		{
			var prevColor = Console.ForegroundColor;
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine(message);
			Console.ForegroundColor = prevColor;
		}

		public static void Information(string message)
		{
			var prevColor = Console.ForegroundColor;
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(message);
			Console.ForegroundColor = prevColor;
		}

		public static void Success(string message)
		{
			var prevColor = Console.ForegroundColor;
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(message);
			Console.ForegroundColor = prevColor;
		}

	}
}
