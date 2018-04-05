using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeEvaluator
{
    public class Node
    {
        private int _left;
        private int _right;

        //enum op { add = 1, mul, sub, div };
        public Node()
        {
            left = 0;
            right = 0;
        }

        public int id { get; set; }
        public int left
        {
            get { return _left; }
            set
            {
                int i;
                if (int.TryParse(value.ToString(), out i))
                {
                    _left = i;
                }
                else
                {
                    throw new ArgumentException("Left can not be string. It can only be an integer.");
                }
            }
        }
        public int right
        {
            get { return _right; }
            set
            {
                int i;
                if (int.TryParse(value.ToString(), out i))
                {
                    _right = i;
                }
                else
                {
                    throw new ArgumentException("Right can not be string. It can only be an integer.");
                }
            }
        }
        public string op { get; set; }
    }
}
