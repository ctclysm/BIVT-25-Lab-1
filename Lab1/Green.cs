﻿namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            answer = Math.Abs(d)>=1;
            // end

            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            // code here
            answer = ((d + f) / 2.0) > 0;
            Console.WriteLine(answer);
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            answer = (a + b)>(Math.Abs(a) + Math.Abs(b))/2;
            Console.WriteLine(answer);
            // end

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            // code here
            if ((a >= b) && (a >= c))
            {
                answer = a;
            }
            else if ((b >= c) && (b >= a))
            {
                answer = b;
            }
            else
            {
                answer = c;
            }
                    // end

                    return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (Math.Abs(x) > 1)
            {
                answer = 0;
            }
            else
            {
                answer = (x * x) - 1;
            }
            // end

            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here
            if (x < 0)
            {
                answer = y <= (1 + x);
            }
            else
            {
                answer = y <= (1 - x);
            }
            
            if (y<0)
            {
                answer = false;
            }
            if (x<-1 || x>1)
            {
                answer = false;
            }
          
             // end

                return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            // code here
            if (n<0)
            {
                answer = false;
            }
            else if (n%2==0)
            {
                answer = false;
            }
                // end

                return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            // code her

            int days = 0;

            if (X % 2 == 0)
            {
                days = X / 2;
            }
            else
            {
                days = X / 2 + 1;
            }

            if (X >= 7 && (240 <= (days * Y)) && (360 >= (days * Y)))
            {
                answer = true;
            }

            // end

                return answer;
        }
    }
}