using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace C_Sharp_Dustin_Web_App
{
    public interface ICalculate
    {
        int Execute(int leftSide, int rightSide);
    }
    public class Calculator
    {

        public Calculator()
        {
            State = AddedStateInstance;
        }

        private ICalculate State;
        private AddedState AddedStateInstance = new AddedState();
        private Substract SubstractStateInstance = new Substract();
        private Divide DivideStateInstance = new Divide();
        private Multiply MultiplyStateInsance = new Multiply();

        private class AddedState : ICalculate
        {
            public int Execute(int leftSide, int rightSide)
            {
                return leftSide + rightSide;
            }
        }

        private class Substract : ICalculate
        {
            public int Execute(int leftSide, int rightSide)
            {
                return leftSide - rightSide;
            }
        }

        private class Divide : ICalculate
        {
            public int Execute(int leftSide, int rightSide)
            {
                return leftSide / rightSide;
            }
        }

        private class Multiply : ICalculate
        {
            public int Execute(int leftSide, int rightSide)
            {
                return leftSide * rightSide;
            }
        }
        public int Execute(int leftSide, int rightSide)
        {
            return State.Execute(leftSide, rightSide);
        }

        public void SetStateToAdded()
        { 
            State = AddedStateInstance;
        }

        public void SetStateToSubtract()
        {
            State = SubstractStateInstance;
        }

        public void SetStateToDivide()
        {
            State = DivideStateInstance;
        }

        public void SetStateToMultiply()
        {
            State = MultiplyStateInsance;
        }

    }
}