using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using log4net;

namespace MissionPlanner.Utilities
{
    public class Tracking
    {
        enum type
        {
            pageview,
            event_,
            transaction,
            item,
            social,
            exception,
            timing,

            appview      ,

        }

        public static bool OptOut = false;

        public static Guid cid
        {
            get => _cid;
            set
            {
                _cid = value;
            }
        }

        static bool sessionstart = false;

        private static Guid _cid = new Guid();

        static Tracking()
        {
        }

        public static void AddEvent(string cat, string action, string label, string value)
        {
        }

        public static string productVersion
        {
            get; set;
        }

        public static string productName
        {
            get; set;
        }

        public static int boundsHeight
        {
            get; set;
        }

        public static int boundsWidth
        {
            get; set;
        }

        public static int primaryScreenBitsPerPixel
        {
            get; set;
        }

        public static string currentCultureName { get; set; }

        public static void AddPage(string page, string title)
        {
        }

        public static void AddFW(string name, string board)
        {
        }

        public static void AddTiming(string cat, string name, double timeinms, string label)
        {
        }

        static void track(object temp)
        {
        }
    }
}
