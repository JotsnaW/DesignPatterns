namespace AccessToNetflixAccount
{
    internal class Program
    {
        public static void Main()
        {
            DeviceManager deviceManager = DeviceManager.GetNetflixInstance();

            string Oppodevice = "OppoMobile";
            string Samsungdevice = "SamsungMobile";

            deviceManager.GiveAccess(Oppodevice);
            deviceManager.GiveAccess(Samsungdevice);
            deviceManager.RevokeAccess();

            deviceManager.GiveAccess(Samsungdevice);
            deviceManager.RevokeAccess();
        }
    }
}
