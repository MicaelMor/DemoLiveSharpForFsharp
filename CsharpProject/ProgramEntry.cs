using System;
using CsharpProject;
using FsharpProject;

namespace OrdenadosControlLibrary
{
    class ProgramEntry
    {
        [STAThread]
        static void Main(string[] args)
        {
            // This is the program entry which calls a function in the FsharpProject that is essentially the initialization of a ViewModel sort of thing.
            Elmish.WPF.Program.runWindow(new MainWindow(), ChangeCounterHere.Main(args));
        }
    }
}
