namespace abstractfactory;

interface IProductA {
    public void DoSomething();
}

interface IProductB {
    public void DoSomething();
}

class ProductA1 : IProductA {
    public void DoSomething() {
        Console.WriteLine("ProductA1");
    }
}

class ProductA2 : IProductA {
    public void DoSomething() {
        Console.WriteLine("ProductA2");
    }
} 

class ProductB1 : IProductB {
    public void DoSomething() {
        Console.WriteLine("ProductB1");
    }
}

class ProductB2 : IProductB {
    public void DoSomething() {
        Console.WriteLine("ProductB2");
    }
}

interface IAbstractFactory {
    IProductA CreateProductA();
    IProductB CreateProductB();
}

class ConcreteFactory1 : IAbstractFactory {
    public IProductA CreateProductA() {
        return new ProductA1();
    }

    public IProductB CreateProductB() {
        return new ProductB1();
    }
}

class ConcreteFactory2 : IAbstractFactory {
    public IProductA CreateProductA() {
        return new ProductA2();
    }

    public IProductB CreateProductB() {
        return new ProductB2();
    }
}
    
