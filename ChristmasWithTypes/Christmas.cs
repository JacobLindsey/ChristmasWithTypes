﻿using System;
namespace ChristmasWithTypes
{
    public class Christmas
    {
        public string[] Presents;
        public string Santa { get; set; }
        public int? TreeHeight { get; set; } //DONE Make the Height property nullable

        //DONE Make the property, "Day", type enum
        public enum Day { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday /*Fill out the days of the week*/ };

    }
}
