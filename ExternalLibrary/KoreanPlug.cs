using System;

namespace ExternalLibrary
{
    public class KoreanPlug
    {
        private const int TargetVoltage = 220;

        public virtual bool ApplyPower(int voltage)
        {
            if (voltage > TargetVoltage)
                throw new Exception("Voltage too high!");

            if (voltage < TargetVoltage)
                throw new InvalidOperationException("Voltage too low!");

            return true;
        }
    }

    public class KoreanWallOutlet
    {
        private const int PowerOutput = 220;

        private KoreanPlug _plug;

        public void PlugIn(KoreanPlug plug)
        {
            _plug = plug;
        }

        public bool ApplyPower()
        {
            return _plug.ApplyPower(PowerOutput);
        }
    }
}
