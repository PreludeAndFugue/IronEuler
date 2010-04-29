/*
 * Created by SharpDevelop.
 * User: ags97128
 * Date: 23/04/2010
 * Time: 10:22
 * 
 * Definitions of number types, eg complex numbers
 */
using System;
using System.Collections.Generic;
using NumberTheory;

namespace NumberTypes
{
	public struct Fraction : IComparable
	{
		// denominator and numerator
		int d, n;
			
		public Fraction(int x, int y)
		{
			// Denominator cannot be 0.
			if (y == 0)
				throw new ArgumentException();
			/* Normalise the sign of n and d. If d is negative, multiply both n and d by
			 * -1 to move the sign to the numerator. */
			if (y < 0)
			{
				x *= -1;
				y *= -1;
			}
			// Reduce fraction to lowest common factors.
			int divisor = Factorisation.gcd(Math.Abs(x), Math.Abs(y));
			n = x/divisor;
			d = y/divisor;
		}
		
		public int num {
			get {return n;}
		}
		
		public int den {
			get {return d;}
		}
		
		public override string ToString()
		{
			return n.ToString() + "/" + d.ToString();
		}
		
		public int CompareTo(object o)
		{
			if (o is Fraction)
			{
				Fraction f = (Fraction)o;
				if (n*f.d > d*f.n)
				{
					return 1;
				}
				else if (n*f.d < d*f.n)
				{
					return -1;
				}
				else
				{
					return 0;
				}
			}
			else if (o is int)
			{
			    int i = (int)o;
			    if (n > i*d)
			    {
			        return 1;
			    }
			    else if (n < i*d)
			    {
			        return -1;
			    }
			    else
			    {
			        return 0;
			    }
			}
			else
			{
				throw new ArgumentException();
			}
		}
		
		#region Fraction-Fraction comparisons
		public static bool operator >(Fraction f1, Fraction f2)
		{
			return f1.CompareTo(f2) > 0;
		}
		
		public static bool operator <(Fraction f1, Fraction f2)
		{
			return f1.CompareTo(f2) < 0;
		}
		
		public static bool operator <=(Fraction f1, Fraction f2)
		{
			return f1.CompareTo(f2) <= 0;
		}
		
		public static bool operator >=(Fraction f1, Fraction f2)
		{
			return f1.CompareTo(f2) >= 0;
		}
		
		public static bool operator ==(Fraction f1, Fraction f2)
		{
			return f1.CompareTo(f2) == 0;
		}
		
		public static bool operator !=(Fraction f1, Fraction f2)
		{
			return f1.CompareTo(f2) != 0;
		}
		#endregion
		
		#region Fraction-int comparisons
		public static bool operator >(Fraction f, int i)
		{
		    return f.CompareTo(i) > 0;
		}
		
		public static bool operator <(Fraction f, int i)
		{
		    return f.CompareTo(i) < 0;
		}
		
		public static bool operator <=(Fraction f, int i)
		{
		    return f.CompareTo(i) <= 0;
		}
		
		public static bool operator >=(Fraction f, int i)
		{
		    return f.CompareTo(i) >= 0;
		}
		
		public static bool operator ==(Fraction f, int i)
		{
		    return f.CompareTo(i) == 0;
		}
		
		public static bool operator !=(Fraction f, int i)
		{
		    return f.CompareTo(i) != 0;
		}
		#endregion
		
		public override bool Equals(object o)
		{
			if (o is Fraction)
			{
				Fraction f = (Fraction)o;
				return this.CompareTo(f) == 0;
			}
			else
			{
				throw new ArgumentException();
			}
		}
		
		public override int GetHashCode()
		{
			// different strings return unique hash codes
			return this.ToString().GetHashCode();
		}
		
		public static Fraction operator -(Fraction f)
		{
		    return new Fraction(-f.n, f.d);
		}
		
		#region Fraction-Fraction maths operators
		public static Fraction operator +(Fraction f1, Fraction f2)
		{
			return new Fraction(f1.n*f2.d + f1.d*f2.n, f1.d*f2.d);
		}
		
		public static Fraction operator -(Fraction f1, Fraction f2)
		{
			return new Fraction(f1.n*f2.d - f1.d*f2.n, f1.d*f2.d);
		}
		
		public static Fraction operator *(Fraction f1, Fraction f2)
		{
			return new Fraction(f1.n*f2.n, f1.d*f2.d);
		}
		
		public static Fraction operator /(Fraction f1, Fraction f2)
		{
			return new Fraction(f1.n*f2.d, f1.d*f2.n);
		}
		#endregion
		
		#region Fraction-int maths operators
		public static Fraction operator +(Fraction f, int n)
		{
		    return new Fraction(f.n + n*f.d, f.d);
		}
		
		public static Fraction operator -(Fraction f, int n)
		{
		    return new Fraction(f.n - n*f.d, f.d);
		}
		
		public static Fraction operator *(Fraction f, int n)
		{
		    return new Fraction(f.n*n, f.d);
		}
		
		public static Fraction operator /(Fraction f, int n)
		{
		    return new Fraction(f.n, f.d*n);
		}
		#endregion
		
		#region int-Fraction maths operators
		public static Fraction operator +(int n, Fraction f)
		{
		    return f + n;
		}
		
		public static Fraction operator -(int n, Fraction f)
		{
		    return -f + n;
		}
		
		public static Fraction operator *(int n, Fraction f)
		{
		    return f*n;
		}
		
		public static Fraction operator /(int n, Fraction f)
		{
		    return new Fraction(n*f.d, f.n);
		}
		#endregion
	}
	
	
    /// <summary>
    /// A ListNumber stores large numbers in a List<int> type. Each int in the
    /// List is a digit (0 <= i <= 9).
    /// </summary>
    public class ListNumber : List<int>, IComparable
    {
        public ListNumber()
        {}
        
        public ListNumber(int n)
        {
            while (n != 0)
            {
                this.Add(n%10);
                n /= 10;
            }
        }
        
        public ListNumber(List<int> number)
        {
            number.Reverse();
            this.AddRange(number);
        }
        
        public ListNumber(ListNumber n)
        {
            this.AddRange(n);
        }
        
        public static ListNumber operator *(ListNumber number, int multiple)
        {
            int tens = 0;
            ListNumber answer = new ListNumber();
            foreach (int n in number)
            {
                int new_n = n*multiple + tens;
                answer.Add(new_n%10);
                tens = new_n/10;
            }
            while (tens != 0)
            {
                answer.Add(tens%10);
                tens /= 10;
            }
            //answer.Reverse();
            return answer;
        }
        
        public static ListNumber operator *(int multiple, ListNumber number)
        {
            return number*multiple;
        }
        
        public static ListNumber operator *(ListNumber n1, ListNumber n2)
        {
            ListNumber answer = new ListNumber();
            for (int i = 0; i < n2.Count; i++)
            {
                answer += n1._multiplyByPowerOfTen(i)*n2[i];
            }
            return answer;
        }
        
        public ListNumber Pow(int n)
        {
            ListNumber answer = new ListNumber(1);
            for (int i = 0; i < n; i++)
            {
                answer *= this;
            }
            return answer;
        }
        
        public static ListNumber operator +(ListNumber n1, ListNumber n2)
        {
            int tens = 0;
            ListNumber answer = new ListNumber();
            
            if (n1 == n2)
            {
                return n1*2;
            }
            
            ListNumber n_small = n1 < n2 ? n1 : n2;
            ListNumber n_large = n1 < n2 ? n2 : n1;
            
            for (int i = 0; i < n_small.Count; i++)
            {
                int n = n1[i] + n2[i] + tens;
                answer.Add(n%10);
                tens = n/10;
            }
            
            for (int i = n_small.Count; i < n_large.Count; i++)
            {
                int n = n_large[i] + tens;
                answer.Add(n%10);
                tens = n/10;
            }
            
            while (tens > 0)
            {
                answer.Add(tens%10);
                tens /= 10;
            }
            
            return answer;            
        }
        
        public static bool operator >(ListNumber n1, ListNumber n2)
        {
            return n1.CompareTo(n2) > 0;
        }
        
        public static bool operator <(ListNumber n1, ListNumber n2)
        {
            return n1.CompareTo(n2) < 0;
        }
        
        public static bool operator >=(ListNumber n1, ListNumber n2)
        {
            return n1.CompareTo(n2) >= 0;
        }
        
        public static bool operator <=(ListNumber n1, ListNumber n2)
        {
            return n1.CompareTo(n2) <= 0;
        }
        
        public static bool operator ==(ListNumber n1, ListNumber n2)
        {
            return n1.CompareTo(n2) == 0;
        }
        
        public static bool operator !=(ListNumber n1, ListNumber n2)
        {
            return n1.CompareTo(n2) != 0;
        }
        
        public int CompareTo(object o)
        {
            if (o is ListNumber)
            {
                ListNumber n = (ListNumber)o;
                if (this.Count > n.Count)
                {
                    return 1;
                }
                else if (this.Count < n.Count)
                {
                    return -1;
                }
                else
                {
                    for (int i = n.Count - 1; i >= 0; i--)
                    {
                        if (this[i] > n[i])
                        {
                            return 1;
                        }
                        else if (this[i] < n[i])
                        {
                            return -1;
                        }
                    }
                }
                return 0;
            }
            else
            {
                throw new ArgumentException();
            }
        }
        
        public override bool Equals(object o)
        {
            if (o is ListNumber)
            {
                ListNumber n = (ListNumber)o;
                return this.CompareTo(n) == 0;
            }
            else
            {
                throw new ArgumentException();
            }
        }
        
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        
        public int DigitSum()
        {
            int answer = 0;
            foreach (int i in this)
            {
                answer += i;
            }
            return answer;
        }
        
        public override string ToString()
        {
            string answer = "";
            
            foreach (int i in this)
            {
                answer = i.ToString() + answer;
            }
            return answer;
        }
        
        public ListNumber _multiplyByPowerOfTen(int n)
        {
            ListNumber answer = new ListNumber(this);
            for (int i = 0; i < n; i++)
            {
                answer.Insert(0, 0);
            }
            return answer;
        }
    }
    
    public class ComplexNumber
    {
        
    }
}