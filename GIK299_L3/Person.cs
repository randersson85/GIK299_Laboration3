﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIK299_L3
{
    public class Person
    {
        public string Name { get; private set; }
        public Gender Gender { get; private set; }
        public Hair Hair { get; private set; }
        public string EyeColor { get; private set; }
        public DateTime BirthDate { get; private set; }

        public Person(string name, Gender gender, string eyeColor, Hair hair, DateTime birthDate)
        {
            Name = name;
            Gender = gender;
            EyeColor = eyeColor;
            Hair = hair;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return $"Namn: {Name}" +
                   $"\n Kön: {Gender}" +
                   $"\n Ögonfärg {EyeColor}" +
                   $"\n Hår: {Hair.Haircolor},{Hair.HairLength}" +
                   $"\n Födelsedatum: {BirthDate:yyyy/MM/dd}";

        }
    }
}
