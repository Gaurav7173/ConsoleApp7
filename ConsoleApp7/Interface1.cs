using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace InterFaceDemo
{
    interface IOne
    {
        void ONE();   
    }
    interface ITwo
    {
        void TWO();
    }
    interface IThree : IOne
    {
        void THREE();
    }
    interface IFour
    {
        void FOUR();
    }
    interface IFive : IThree
    {
        void FIVE();
    }
    interface IEVEN : ITwo, IFour { }
    class ODDEVEN : IEVEN, IFive
    {
        public void ONE()   
        {
            Console.WriteLine("This is ONE");
        }
        public void TWO()
        {
            Console.WriteLine("This is TWO");
        }
        public void THREE()
        {
            Console.WriteLine("This is THERE");
        }
        public void FOUR()
        {
            Console.WriteLine("This is FOUR");
        }
        public void FIVE()
        {
            Console.WriteLine("This is FIVE");
        }
    }
}