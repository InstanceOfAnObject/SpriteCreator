﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpriteCreator.Shell
{
	public class SCEngineOptions
	{

		private string _sourceDirectory;
		private string _destinationDirectory;
		private string _filesName = Guid.NewGuid().ToString();

		/// <summary>
		/// Directory to get the images from
		/// </summary>
		public string SourceDirectory
		{
			get 
			{
				if (string.IsNullOrEmpty(_sourceDirectory))
				{
					_sourceDirectory = Environment.CurrentDirectory;
				}
				return _sourceDirectory;
			}
			set { _sourceDirectory = value; }
		}

		/// <summary>
		/// Directory where to put the process result (sprite, css and demo html file)
		/// </summary>
		public string DestinationDirectory
		{
			get 
			{
				if (string.IsNullOrEmpty(_destinationDirectory))
				{
					_destinationDirectory = SourceDirectory;
				}
				return _destinationDirectory; }
			set { _destinationDirectory = value; }
		}

		/// <summary>
		/// prefix used before every css class
		/// </summary>
		public string CssClassPrefix { get; set; }

		/// <summary>
		/// specify packing complexity level (1 to 3)
		/// </summary>
		public int BinPackingLevel { get; set; }

		/// <summary>
		/// The name of the files being generated.
		/// Three files are being generated: the sprite, the css and a demo html.
		/// All of them will have the same name and different file extensions.
		/// By default this is a GUID.
		/// </summary>
		public string FilesName 
		{
			get
			{
				return _filesName;
			}
			set
			{
				_filesName = value;
			}
		}

		/// <summary>
		/// Gets or sets whether the process creates destination directory if doesn't exist or not
		/// </summary>
		public bool CreateDirectory { get; set; }

		/// <summary>
		/// Gets or set whether the process should override existing files or not
		/// </summary>
		public bool Override { get; set; }

	}
}
