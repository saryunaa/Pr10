using TransportApp;

namespace Slassascas
{
    class Scooter : Transport
    {
        public override string Type => "Scooter";
    public override string LicenseCategory => "You do not need a license";
    public override int Wheels => 2;
    public override bool HasMotor => true;
    }
}