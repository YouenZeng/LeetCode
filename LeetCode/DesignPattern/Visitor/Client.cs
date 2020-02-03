using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.DesignPattern.Visitor
{
    public class Client
    {
        public void Go()
        {
            Element eleA = new ElementA();
            Visitor v = new VisitorOtherImpl();
            eleA.Accept(v); 
            
            Element eleB = new ElementB();
            eleB.Accept(v);
        }
    }
}
