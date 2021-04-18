using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2.day12
{
    class PostIt
    {
        private string _backgroundColor;
        private string _text;
        private string _textColor;

        public PostIt(string backgroundColor, string text, string textColor)
        {
            _backgroundColor = backgroundColor;
            _text = text;
            _textColor = textColor;
        }
    }
}
