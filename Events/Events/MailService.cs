using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class MailService
    {

        public void OnVideoEcoded(object source, EventArgs args)
        {
            Console.WriteLine("MailService: Sending a mail...");
        }
    }
}
