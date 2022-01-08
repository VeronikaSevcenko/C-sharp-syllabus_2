

namespace AdApp
{
    class Poster : Advert
    {
        private int _number_of_copy;

        private int _dimensions;

        private int _rate;

        public Poster( int number_of_copy, int dimensions, int rate) 
        {
            _number_of_copy = number_of_copy;
            _dimensions = dimensions;
            _rate = rate;
        }

        public override int Cost()
        {
            return base.Cost() + _rate * (_number_of_copy * _dimensions); 
        }

        public override string ToString()
        {
            return base.ToString() + "Poster:  dimension = " + _dimensions + "rate = " + _rate * (_number_of_copy * _dimensions);
        }

    }
}
