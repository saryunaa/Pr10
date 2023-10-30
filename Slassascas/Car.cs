using TransportApp;

namespace Slassascas
{
    class Car : Transport
    {
        public override string Type => "Car";
        public override string LicenseCategory => "B";
        public override int Wheels => 4;
        public override bool HasMotor => true;
    }
}
