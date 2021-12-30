namespace AdApp
{
    public class TVAd: Advert
    {
        private int _rate;

        private int _time_in_sec;

        private bool _peak;

        public TVAd(int fee, int rate, int time_in_sec, bool peak) : base(fee)
        {
            _rate = rate;
            _time_in_sec = time_in_sec;
            _peak = peak;
        }
        
        public override int Cost() 
        {
            return base.Cost() + _time_in_sec * (_peak ? _rate*2 : _rate);
        }

        public override string ToString() 
        {
            return base.ToString() + "TV ad: time in second = " + _time_in_sec + "rate = " + (_peak ? _rate * 2 : _rate);
        }
    }
}