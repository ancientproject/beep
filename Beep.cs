using System;
using System.Runtime.InteropServices;
using System.Text;
using ancient.runtime;
using static System.Console;


[Guid("15A2AE41-975E-4FEA-9555-FBD380DB845B")]
public class BeepDevice : Device
{
    public override void write(long address, long data)
    {
        switch (address)
        {
            case 0xF:
                Console.Beep(2400, 1000);
                break;
        }
    }

    public override void shutdown() {}
    public BeepDevice() : base(0x5, "beep") { }
}
