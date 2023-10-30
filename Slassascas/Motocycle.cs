using TransportApp;

namespace Slassascas
{
    class Motorcycle : Transport
    {
        public override string Type => "Motorcycle";
        public override string LicenseCategory => "A";
        public override int Wheels => 2;
        public override bool HasMotor => true;
    }
}
