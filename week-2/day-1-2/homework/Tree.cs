using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Tree
    {
        private string _treeType;
        private string _leafColor;
        private int _age;
        private string _sex;

        public Tree(int age, string leafColor, string sex, string treeType)
        {
            _treeType = treeType;
            _leafColor = leafColor;
            _age = age;
            _sex = sex;
        }
    }
}