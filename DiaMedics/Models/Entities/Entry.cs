﻿using System;
using SkiaSharp;
namespace DiaMedics.Models.Entities
{
    public class Entry
    {
        public Entry(float value)
        {
            this.Value = value;
        }
        public float Value { get; }
       
        public string Label { get; set; }


        public string ValueLabel { get; set; }

       
        public SKColor Color { get; set; } = SKColors.Black;


        public SKColor TextColor { get; set; } = SKColors.Gray;
    }
}
