using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SpriteCreator.Tools.BinPacking
{
	public class Tests
	{

		public void Test1()
		{
			CygonRectanglePacker packer = new CygonRectanglePacker(1024, 1024);
			
			// Find a place for a rectangle of size 30x20 in the packing area
			Point placement;
			if (packer.TryPack(30, 20, out placement))
			{
				// Successfully packed, placement contains position of upper left corner
			}
			else
			{
				// Packer ran out of space
			}
		}

	}
}
