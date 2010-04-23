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

namespace NumberTypes
{
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
            return base.GetHashCode();
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
        
    }
    
    public class ComplexNumber
    {
        
    }
}