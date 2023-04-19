// See https://aka.ms/new-console-template for more information

using DecoratorPattern;

ConcereteComponent concereteComponent =new ConcereteComponent();

ConcreteDecorator concerete=new ConcreteDecorator(concereteComponent);
concerete.operation();

Console.ReadKey();