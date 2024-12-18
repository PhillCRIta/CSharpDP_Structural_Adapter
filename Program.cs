using System;

/* adapt the class to a different form
 * 
 * 
 */

namespace Structural_Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VideoEditor vEditor = new VideoEditor(new Video() { Name = "Video test 1"});
            //pass the external editor through constructor
            //rainbow color is a wrapper that translate one interface in another interface
			vEditor.ApplyColor(new RainbowColorAdapter(new ExternalPackageExample.Rainbow()));
			Console.WriteLine("*****************");
			vEditor.ApplyColor(new RainbowAdapterInheritance());
			Console.WriteLine("*****************");
			vEditor.ApplyColor(new BlackWhiteColor());
			Console.WriteLine("*****************");
			vEditor.ApplyColor(new MidnightColor());
			Console.WriteLine("*****************");
		}
	}
}
