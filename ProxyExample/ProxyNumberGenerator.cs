namespace ProxyExample
{
    public class ProxyNumberGenerator: AbstractNumberGenerator
    {
        private NumberGenerator _numberGenerator;

        public override int GenerateNumber()
        {
            if (_numberGenerator == null)
            {
                _numberGenerator = new NumberGenerator();
            }

            return _numberGenerator.GenerateNumber();
        }
    }
}