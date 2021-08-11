using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class MessageService
    {

        public void OnVideoEncoded(object source , EventArgs args)
        {
            Console.WriteLine("MessageService: sending messages");
        }
    }
}
