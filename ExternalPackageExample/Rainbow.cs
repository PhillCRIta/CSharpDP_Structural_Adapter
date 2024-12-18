using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Adapter.ExternalPackageExample
{
	internal class Rainbow
	{
		public void Setup()
		{
			//this is an example
			Console.WriteLine("I'm settin up the rainbox filter");
		}
		public void Update(Video video)
		{
			Console.WriteLine("I'm applying a special external filter Rainbow to a video " + video.Name);
		}
	}
}
