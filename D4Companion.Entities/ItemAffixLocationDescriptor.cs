﻿using System.Drawing;

namespace D4Companion.Entities
{
    public class ItemAffixLocationDescriptor
    {
        public double Similarity { get; set; } = 1;
        public Rectangle Location { get; set; } = Rectangle.Empty;
        public string Name { get; set; } = string.Empty;
    }
}
