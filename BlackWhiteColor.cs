using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Adapter
{
	internal class BlackWhiteColor : IColor
	{
		public void Apply(Video video)
		{
			Console.WriteLine("I'm applying a Black and white filter to a video " + video.Name);
		}
	}
}
