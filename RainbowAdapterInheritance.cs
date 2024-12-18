using Structural_Adapter.ExternalPackageExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Adapter
{
	internal class RainbowAdapterInheritance : Rainbow, IColor
	{
		//in this case I use the inheritance
		//and in the method interface Apply, I call the method of parent class
		//this solution is based on INHERITANCE
		//IT'S LESS FLEXIBLE THAN COMPOSITION
		public void Apply(Video video)
		{
			Setup();
			Update(video);
		}
	}
}
