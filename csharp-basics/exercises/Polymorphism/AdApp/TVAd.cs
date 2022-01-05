namespace AdApp
{
    public class TVAd: Advert
    {
        private int _rate;

        private int _timeInSec;

        private bool _peak;

        public TVAd(int fee, int rate, int time_in_sec, bool peak) : base(fee)
        {
            _rate = rate;
            _timeInSec = time_in_sec;
            _peak = peak;
        }
        
        public override int Cost() 
        {
            return base.Cost() + _timeInSec * (_peak ? _rate*2 : _rate);
        }

        public override string ToString() 
        {
            return base.ToString() + "TV ad: time in second = " + _timeInSec + "rate = " + (_peak ? _rate * 2 : _rate);
        }
    }
}