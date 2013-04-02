using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpriteCreator.Shell.Tools
{
	public enum ExitCodes : int
	{
		Success = 0,

		// Command arguments errors
		InvalidSourceDirectory = 101,
		InvalidDestinationDirectory = 102,
		InvalidDestinationFileName = 103,
		InvalidCSSClassPrefix = 104,
		InvalidBinPackingLevel = 105,

		// IO Problems (class 2 errors) //
		DestinationDirectoryDoesNotExist = 201,
		CreateDirectoryAccessDenied = 202,
		CreateFilesAccessDenied = 203,
		FileAlreadyExists = 204,

		// Bin packing errors
		

		// Unhandled errors (class 9)
		UnhandledError = 901
	}
}
