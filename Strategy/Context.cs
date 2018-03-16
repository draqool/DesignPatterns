namespace Strategy
{
    public class Context
    {
        private IOperation _operation;

        public Context(IOperation operation)
        {
            _operation = operation;
        }

        public int executeStrategy(int num1, int num2)
        {
            return _operation.Calculate(num1, num2);
        }
    }
}