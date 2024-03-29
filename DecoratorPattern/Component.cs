﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Component
    {
        public abstract void operation();
    }

    public abstract class Decorator: Component
    {
        private readonly Component _component;
        public Decorator(Component component)
        {
            _component = component;
        }
        public override void operation()
        {
            _component.operation();
        }
    }
    public class ConcreteDecorator:Decorator
    {
        public ConcreteDecorator(Component component):base(component) 
        {

        }
        public override void operation()
        {
            base.operation();
            NewFeature();
        }
        public void NewFeature()
        {
            Console.WriteLine("Decoratoe new feature");
        }
    }
}
