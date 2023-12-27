﻿using System.Drawing;

namespace D4Companion.Entities
{
    public class ItemAspectLocationDescriptor
    {
        public double Similarity { get; set; } = 1;
        public Rectangle Location { get; set; } = Rectangle.Empty;
    }
}
