namespace WeatherStationV10
{
    /// <summary>
    ///  Simple barometer, measuring pressure in hPa (hectopascal)
    /// </summary>
    public class Barometer
    {
        #region Instance fields
        private double _pressureInHPa;
        #endregion

        #region Constructor
        public Barometer()
        {
            _pressureInHPa = 1000.0;
        }
        #endregion

        #region Properties
        public double Pressure
        {
            get { return _pressureInHPa; }
            set { _pressureInHPa = value; }
        }

        public string WeatherDescription
        {
            get { 
                if(_pressureInHPa < 980){
                    return "Stormy";
                } else if(980 < _pressureInHPa && _pressureInHPa < 1000){
                    return "Rainy";
                } else if(1000 <= _pressureInHPa && _pressureInHPa <= 1020){
                    return "Changing";
                } else if(1020 < _pressureInHPa && _pressureInHPa <= 1040){
                    return "Fair";
                } else if(1040 < _pressureInHPa){
                    return "Very Dry";
                }
                return "lol"; 
                }
        }
        #endregion
    }
}