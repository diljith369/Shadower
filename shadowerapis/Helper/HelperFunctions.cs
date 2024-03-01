using System.Security.Cryptography;

namespace shadowerapis.Helper
{
    public static class HelperFunctions
    {
        public static string? GetConnectionString()
        {
            //return Environment.GetEnvironmentVariable("shadowerdb-win");
            string? strConnection = @"Host=192.168.1.155;Username=shadoweradmin;Password=newPass$123;Database=shadower";
            return strConnection;

        }

        public static Dictionary<string, string> CreateServerKeyPair()
        {
            Dictionary<string, string> keypair = new Dictionary<string, string>();

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(4096);

            string pvtKey = rsa.ToXmlString(true);
            string pubkey = rsa.ToXmlString(false);

            byte[] pvtkeybytes = System.Text.Encoding.UTF8.GetBytes(pvtKey);
            byte[] pubkeykeybytes = System.Text.Encoding.UTF8.GetBytes(pubkey);
            keypair.Add("PUBKEY", Convert.ToBase64String(pubkeykeybytes));
            keypair.Add("PVTKEY", Convert.ToBase64String(pvtkeybytes));

            return keypair;
        }
    }
}
