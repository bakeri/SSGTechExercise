using System;
using System.Collections.Generic;

namespace SSGTechExercise.BL
{
    public class Colour
    {


        public struct ColourStruct
        {
            public int red;
            public int green;
            public int blue;

        };

        private Dictionary<string, ColourStruct> ColourDict = new Dictionary<string, ColourStruct>();
        private Random randomColour = new Random();

        public string getRandomColour(string fullname)
        {
            string rgbColour;

            ColourStruct colour;
            if (ColourDict.ContainsKey(fullname))
            {
                colour = ColourDict[fullname];
            }
            else
            {
                colour = GetUniqueRandomColor(fullname);

            }

            rgbColour = colour.red.ToString() + "," + colour.green.ToString() + "," + colour.blue.ToString();

            return rgbColour;

        }

        private ColourStruct GetUniqueRandomColor(string fullname)
        {
            ColourStruct col;

            col.red = randomColour.Next(0, 255);
            col.green = randomColour.Next(0, 255);
            col.blue = randomColour.Next(0, 255);

            ColourDict.Add(fullname, col);
            return col;
        }

    }


}