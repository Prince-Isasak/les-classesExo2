using System;
using System.Collections.Generic;
using System.Text;

namespace exercice_2
{
    class logique
    {
        public class TextStyle
        {
            public String content;
            public string color;
            public string font_family;
            public string font_weight;
            public int font_size;
            public string text_decoration;
        }

        public class SetBackground
        {
            public String background_color;
            public string background_image;
            public string background_size;
            public string background_position;
            public int background_attachement;
            public string background_;
        }
        public class BoxStyle : position
        {
            public String width;
            public string heigth;
            public string box_shadow;
            public string border;
            public int border_radius;
            public string border_color;
            public string border_style;
             void setbackground()
            {

            }
        }
        public class animation
        {
            public void Bounce()
            {
                Console.WriteLine();
            }
            public void bondcedUp()
            {
                Console.WriteLine();
            }
            public void boncedDown()
            {
                Console.WriteLine();
            }
            public void shake()
            {
                Console.WriteLine();
            }
            public void fadeln()
            {
                Console.WriteLine();
            }
        }
        public class position : Display
        {
            public string absolute;
            public string relative;
            public string left;
            public string right;
            public string center;
            public int nbr;
        }
        public class Display
        {
            public string none;
            public string block;
            public string inline;
            public string inline_block;
            public string grid;
            public int flex;
        }









    }
}
