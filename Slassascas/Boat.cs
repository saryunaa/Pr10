using TransportApp;

namespace Slassascas
{
    class Boat : Transport
    {
        public override string Type => "Boat";
        public override string LicenseCategory => "You do not need a license";
        public override int Wheels => 0;
        public override bool HasMotor => true;
    }
}
