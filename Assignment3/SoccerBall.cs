using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class SoccerBall
    {
        private string colour;
        private string shape;
        private string brand;

        public SoccerBall(string Colour, string Shape, string Brand) 
        {
            colour = Colour;
            shape = Shape;
            brand = Brand;
        }

        public string GetColour()
        {
            return colour;
        }
        public string GetShape()
        {
            return shape;
        }
        public string GetBrand()
        {
            return brand;
        }

        

    }

}
