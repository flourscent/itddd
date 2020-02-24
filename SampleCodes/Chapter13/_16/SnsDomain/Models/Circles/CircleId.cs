﻿using System;

namespace _16.SnsDomain.Models.Circles
{
    public class CircleId
    {
        public CircleId(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));

            Value = value;
        }
        public string Value { get; }
    }
}
