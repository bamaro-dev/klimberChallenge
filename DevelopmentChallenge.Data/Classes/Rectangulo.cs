namespace DevelopmentChallenge.Data.Classes
{
    public class Rectangulo : FormaGeometrica
    {
        private readonly decimal _lado;
        private readonly decimal _base;

        public Rectangulo(decimal ancho, decimal b) : base(ancho)
        {
            _lado = ancho;
            _base = b;
        }

        public override decimal CalcularArea()
        {
            return _base * _lado;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 2 + _base * 2;
        }

    }
}
