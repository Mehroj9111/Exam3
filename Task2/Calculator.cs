public class Calculator
{
     private double _num1;
     private double _num2;

public Calculator(int _num1 ,int _num2)
{
    this._num1 = _num1;
    this._num2 = _num2;

}
     public double Add()
     {
        return _num1 + _num2;
     }
     public double Substract()
     {
        return _num2 - _num1;
     }
     public double Multiply()
     {
        return _num1 * _num2;
     }
     public double Divide()
     {
        return _num2 / _num1;
     }

}