using TransportApp;

namespace Slassascas
{
    class Bicycle : Transport
    {
        public override string Type => "Bicycle";
        public override string LicenseCategory => "You do not need a license";
        public override int Wheels => 2;
        public override bool HasMotor => false;
    }
}
