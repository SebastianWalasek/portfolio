using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmDijkstry
{
    class Miasto
    {
        private string _nazwa;
        private double _x;
        private double _y;
        private bool _zaznaczony;

        public string Nazwa
        {
            get { return this._nazwa; }
            set { this._nazwa = value; }
        }

        public double x
        {
            get { return this._x; }
            set { this._x = value; }
        }

        public double y
        {
            get { return this._y; }
            set { this._y = value; }
        }

        public bool zazanczony
        {
            get { return this._zaznaczony; }
            set { this._zaznaczony = value; }
        }

    }
}
