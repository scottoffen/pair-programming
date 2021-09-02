using System;

namespace IpFilter
{
    public class Program
    {
        private static string[] _ipRules = {
            "10.0.1.2;ALLOW",
            "32.123.45.6;DENY",
            "192.168.0.234;ALLOW"
        };

        /*
            1. Implement the IsAllowed method
            2. Finish the Main method by iterating over the testIps and writing the result to the console.

            Expected output:

            10.0.1.2 is Allowed
            32.123.45.6 is Denied
            192.168.0.234 is Allowed
            10.10.1.2 is Denied
        */
        public static void Main(string[] args)
        {
            string[] testIps = {
                "10.0.1.2",
                "32.123.45.6",
                "192.168.0.234",
                "10.10.1.2"
            };

            Console.WriteLine("Finish me!");
        }

        /// <summary>
        /// Checks if an IP address is allowed or denied.
        /// If the IP is not found in the list of rules, then it is denied.
        /// </summary>
        /// <param name="ip">An IP address expressed as a string</param>
        /// <returns>True = the IP is allowed. False = the IP is denied</returns>
        public static bool IsAllowed(string ip)
        {
            throw new NotImplementedException();
        }
    }
}
