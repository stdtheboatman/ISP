using System;
using System.Text.RegularExpressions;

namespace FractionLab
{
    public class Fraction : IFormattable, IComparable<Fraction>
    {
        public Fraction(int numerator, int denominator)
        {
            _sign = getSign(numerator, denominator);

            _numerator = MyMath.Abs(numerator);
            _denominator = MyMath.Abs(denominator);

            Reduction();
        }

        private Fraction()
        {
            _isBadFraction = true;
        }

        public Fraction(string fractionString)
        {
            Match match = _regexDecimalFraction.Match(fractionString);

            if (match.Success && match.Groups[0].Length == fractionString.Length)
            {
                var fractionParts = _regexDecimalFraction.Split(fractionString);

                if (fractionParts[1] == "-")
                {
                    _sign = -1;
                }
                else
                {
                    _sign = 1;
                }


                _numerator = Int32.Parse(fractionParts[2] + fractionParts[3]);
                _denominator = MyMath.Pow(10, fractionParts[3].Length);

                Reduction();
            }
            else
            {
                match = _regexFraction.Match(fractionString);

                if (match.Success && match.Groups[0].Length == fractionString.Length)
                {
                    var fractionParts = _regexFraction.Split(fractionString);

                    Fraction a = new Fraction(fractionParts[1]);
                    Fraction b = new Fraction(fractionParts[2]);

                    a = a / b;

                    if (a._denominator == 0 || b._denominator == 0)
                    {
                        a._isBadFraction = true;
                    }
                    
                    this._numerator = a._numerator;
                    this._denominator = a._denominator;
                    this._sign = a._sign;
                    this._isBadFraction = a._isBadFraction;
                }
                else
                {
                    _isBadFraction = true;
                }
            }
        }

        private int getSign(int numerator, int denominator)
        {
            return numerator * denominator < 0 ? -1 : 1;
        }

        private void Reduction()
        {
            if (_isBadFraction)
            {
                return;
            }
            
            int gcd = MyMath.Gcd(_numerator, _denominator);

            _numerator /= gcd;
            _denominator /= gcd;
        }

        private string ToStringStd()
        {
            return (_sign < 0 ? "-" : "+") + $"{_numerator}/{_denominator}";
        }

        private double ToDouble()
        {
            return _sign * (double) _numerator / _denominator;
        }

        private string ToStringDouble()
        {
            return ToDouble().ToString();
        }

        private int ToInt() 
        {
            return _sign * _numerator / _denominator;
        }
            
        private string ToStringInt()
        {
            return ToInt().ToString();
        }
        
        
        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            if (_isBadFraction)
            {
                return "not a fraction";
            }
            
            if (String.IsNullOrEmpty(format))
            {
                format = "Std";
            }
            
            switch (format)
            {
                case "Std":
                    return ToStringStd();
                case "Double":
                    return ToStringDouble();
                case "Int":
                    return ToStringInt();
                    
                default:
                    throw new FormatException("The {format} format string is not supported.");
            }

            return "r";
        }
        
        private int _numerator;
        private int _denominator;
        private int _sign;
        private bool _isBadFraction = false;

        private Regex _regexDecimalFraction = new Regex(@"([+\-]?)(\d+)[.,]?(\d*)");
        private Regex _regexFraction = new Regex(@"(.*)/(.*)");


        public int CompareTo(Fraction? other)
        {
            if (other == null)
            {
                return 1;
            }

            int a = _numerator * other._denominator;
            int b = _denominator * other._numerator;

            return a.CompareTo(b);
        }

        public override bool Equals(object obj)
        {
            if (obj == this)
            {
                return true;
            }
            if (obj == null || obj.GetType() != GetType())
            {
                return false;
            }

            Fraction fraction = (Fraction) obj;

            return _numerator == fraction._numerator && _denominator == fraction._denominator;
        }
        
        
        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (a._isBadFraction || b._isBadFraction)
            {
                return new Fraction();
            }

            return new Fraction(a._numerator * b._denominator * a._sign * b._sign, a._denominator * b._numerator);
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            if (a._isBadFraction || b._isBadFraction)
            {
                return new Fraction();
            }

            return new Fraction(a._numerator * b._numerator * a._sign * b._sign, a._denominator * b._denominator);
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            if (a._isBadFraction || b._isBadFraction)
            {
                return new Fraction();
            }

            int newDenominator = MyMath.Lcm(a._denominator, b._denominator);

            return new Fraction(
                a._numerator * newDenominator / a._denominator * a._sign +
                b._numerator * newDenominator / b._denominator * b._sign,
                newDenominator
            );
        }
        
        public static Fraction operator -(Fraction a, Fraction b)
        {
            if (a._isBadFraction || b._isBadFraction)
            {
                return new Fraction();
            }

            int newDenominator = MyMath.Lcm(a._denominator, b._denominator);

            return new Fraction(
                a._numerator * newDenominator / a._denominator * a._sign -
                b._numerator * newDenominator / b._denominator * b._sign,
                newDenominator
            );
        }

        public static bool operator ==(Fraction a, Fraction b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Fraction a, Fraction b)
        {
            return !(a == b);
        }

        public static bool operator <(Fraction a, Fraction b)
        {
            return a.CompareTo(b) < 0;
        }

        public static bool operator <=(Fraction a, Fraction b)
        {
            return a.CompareTo(b) <= 0;
        }

        public static bool operator >=(Fraction a, Fraction b)
        {
            return !(a < b);
        }

        public static bool operator >(Fraction a, Fraction b)
        {
            return !(a <= b);
        }

        public static implicit operator int(Fraction a)
        {
            return a.ToInt();
        }

        public static explicit operator Fraction(int a)
        {
            return new Fraction(a, 1);
        }
        
        public static implicit operator double(Fraction a)
        {
            return a.ToDouble();
        }

        public static explicit operator Fraction(double a)
        {
            return new Fraction(a.ToString());
        }
        
        public static implicit operator string(Fraction a)
        {
            return a.ToStringStd();
        }

        public static explicit operator Fraction(string a)
        {
            return new Fraction(a);
        }
        
        
    }
}