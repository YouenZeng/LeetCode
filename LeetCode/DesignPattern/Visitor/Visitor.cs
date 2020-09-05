using System;

namespace LeetCode.DesignPattern.Visitor
{
    class Visitor
    {
        public virtual void Visit(ElementA element)
        {
            Console.WriteLine("Base visit A");
        }
        public virtual void Visit(ElementB element)
        {
            Console.WriteLine("Base visit B");
        }
    }

    class VisitorOtherImpl : Visitor
    {
        public override void Visit(ElementA element)
        {
            Console.WriteLine("Impl visitor A");
            base.Visit(element);
        }
    }
}
