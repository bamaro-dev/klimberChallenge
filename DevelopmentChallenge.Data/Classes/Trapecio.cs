namespace DevelopmentChallenge.Data.Classes
{
    public class Trapecio : FormaGeometrica
    {
        private readonly decimal _lado;
        private readonly decimal _lado2;
        private readonly decimal _baseGrande;
        private readonly decimal _baseChica;
        private readonly decimal _altura;

        public Trapecio(decimal l1, decimal l2, decimal baseGrande, decimal baseChica, decimal altura) : base(altura)
        {
            _lado = l1;
            _lado2 = l2;
            _baseGrande = baseGrande;
            _baseChica = baseChica;
            _altura = altura;
        }

        public override decimal CalcularArea()
        {
            return (_baseChica + _baseGrande) / 2 * _altura;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado + _lado2 + _baseChica + _baseGrande;
        }

    }
}
