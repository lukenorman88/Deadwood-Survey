using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace deadwood_app.Models
{
    public class ConnectionValidator
    {
        public bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
