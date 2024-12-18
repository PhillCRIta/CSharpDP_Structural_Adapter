using Structural_Adapter.ExternalPackageExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Adapter
{
	internal class RainbowColorAdapter : IColor
	{
		//RAINBOW COLOR ADAPTER INHERIT FROM OR IS-A  IColor OBJECT (extends IColor)
		//RAINBOW COLOR ADAPTER IS COMPOSED  OR HAS-A REFERENCE TO RAINBOW OBJECT
		//this solution is based on COMPOSITION
		private Rainbow _ranibow;

		public RainbowColorAdapter(Rainbow ranibow)
		{
			_ranibow = ranibow;
		}

		public void Apply(Video video)
		{
			//third part operation (external package)
			_ranibow.Setup();
			_ranibow.Update(video);
		}
	}
}
