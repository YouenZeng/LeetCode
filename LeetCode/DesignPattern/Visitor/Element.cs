using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.DesignPattern.Visitor
{
    abstract class Element
    {
        public abstract void Accept(Visitor visitor);

    }

    class ElementA: Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    } 
    
    class ElementB: Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
