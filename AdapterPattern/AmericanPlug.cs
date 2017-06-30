using System;

namespace AdapterPattern
{
    public class AmericanPlug
    {
        private const int TargetVoltage = 120;

        public bool On(int volts)
        {
            if(volts > TargetVoltage)
                throw new InvalidOperationException("Your device just exploded!");

            if(volts < TargetVoltage)
                throw new InvalidOperationException("Voltage is too low!");

            return true;
        }
    }
}
