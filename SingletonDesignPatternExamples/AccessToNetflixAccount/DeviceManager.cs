using System;

namespace AccessToNetflixAccount
{
    public class DeviceManager
    {
        private static readonly object m_lockObject = new object();
        private static DeviceManager m_instance = null;
        private static string m_currentDevice;

        // private constructor
        private DeviceManager()
        {
            m_currentDevice = null;
        }

        // public method to get Instance
        public static DeviceManager GetNetflixInstance()
        {
            lock (m_lockObject)
            {
                if (m_instance == null)
                {
                    m_instance = new DeviceManager();
                }
                return m_instance;
            }
        }

        //method to give access to device
        public void GiveAccess(string device)
        {
            if (m_currentDevice == null)
            {
                m_currentDevice = device;
                Console.WriteLine($"Netfix access is given to: {m_currentDevice}");
            }
            else
            {
                Console.WriteLine($"Netfix is currently accessed by: {m_currentDevice}");
            }
        }

        // Revoke access method
        public void RevokeAccess()
        {
            Console.WriteLine($"Netfix access is Revoked from {m_currentDevice}");
            m_currentDevice = null;
        }
    }
}
