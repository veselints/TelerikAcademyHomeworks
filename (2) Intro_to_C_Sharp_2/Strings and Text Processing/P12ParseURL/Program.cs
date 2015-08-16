﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12ParseURL
{
    class Program
    {
        static void Main()
        {
            string url = "http://telerikacademy.com/Courses/Courses/Details/212";
            Console.WriteLine("[protocol] = {0}", GetProtocol(url));
            Console.WriteLine("[server] = {0}", GetServer(url));
            Console.WriteLine("[resource] = {0}", GetResource(url));
        }

        static string GetProtocol(string url)
        {
            int endOfProtocolIndex = url.IndexOf("//");

            string protocol = url.Substring(0, endOfProtocolIndex);

            return protocol;
        }

        static string GetServer(string url)
        {
            int indexAfterProtocol = url.IndexOf("//") + 2;
            int indexOfSlashAfterServer = url.IndexOf("/", indexAfterProtocol);

            string server = url.Substring(indexAfterProtocol, indexOfSlashAfterServer - indexAfterProtocol);

            return server;
        }

        static string GetResource(string url)
        {
            int startIndex = url.IndexOf("/", url.IndexOf("//") + 2);
            string resource = url.Substring(startIndex);

            return resource;
        }
    }
}
