

--简单工厂模式
DesignPatternsDemo.SimpleFactory.Operation oper;
oper = DesignPatternsDemo.SimpleFactory.OperationFactory.createOperate("+");
oper.NumberA = 1;
oper.NumberB = 1;
double result = oper.GetResult();