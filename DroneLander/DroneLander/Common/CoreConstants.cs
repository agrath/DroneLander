using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneLander.Common
{
    public static class CoreConstants
    {
        public const double Gravity = 3.711;      // Mars gravity (m/s2)
        public const double LanderMass = 17198.0; // Lander mass (kg)
        public const int PollingIncrement = 500;

        public const double StartingAltitude = 5000.0;
        public const double StartingVelocity = 0.0;
        public const double StartingFuel = 1000.0;
        public const double StartingThrust = 0.0;
    }

    public static class MobileCenterConstants
    {
        public const string AndroidAppId = "a3bba16b-dfd9-4c45-8096-91cedc0f3952";
        public const string iOSAppId = "";
    }

    public static class MobileServiceConstants
    {
        public const string AppUrl = "https://dronelandermobile002.azurewebsites.net";
    }

    public static class TelemetryConstants
    {
        public const string DisplayName = "Team404-Table1";
        public const string Tagline = "#WinterOfXamarin17";
    }
}
