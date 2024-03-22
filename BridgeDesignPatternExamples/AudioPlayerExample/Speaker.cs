using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayerExample
{
    public class Speaker : IAudioDevices
    {
        public void Connect()
        {
            Console.WriteLine("Connecting to Speaker...");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnecting Speaker...");
        }
    }
}
