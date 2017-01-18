using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SoundClipDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to start...");
            Console.ReadKey();

            for (int i = 1; i < 2000; i++)
            {
                var cli = new WebClient();                
                cli.DownloadFile("http://abcradiomodhls.abc-cdn.net.au/i/local_adelaide/audio/aae-2017-01-17.m4a/segment" + i + "_0_a.ts?null=0", "segment" + i + "_0_a.ts");
            }
        }
    }
}
