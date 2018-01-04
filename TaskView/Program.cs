using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput.Native;// Importante

namespace taskview
{
    class Program
    {
        static void Main(string[] args)
        {
            WindowsInput.InputSimulator kb = new WindowsInput.InputSimulator();
            kb.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LWIN, VirtualKeyCode.TAB);
            //Console.Read();// Keep console window open
        }
    }
}