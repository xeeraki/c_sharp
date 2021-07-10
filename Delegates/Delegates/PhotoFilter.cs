﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    class PhotoFilter
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply brightness");
        }
        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply contrast");
        }
        public void ApplyResize(Photo photo)
        {
            Console.WriteLine("Resize photo");
        }
    }
}
