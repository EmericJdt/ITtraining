using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace Test_Client
{
    class Corps
    {
        public static int nbCorp;
        public static string[] Name = new string[10];
        public static int[] Id = new int[10];
        public static bool[] numRD = new bool[10];
        public static int tour = 0;
    }
    
    class Regs
    {
        public static int nbReg;
        public static string[] Name = new string[10];
        public static int[] Id = new int[10];
    }

    class Trans
    {
        public static string[] Name = new string[10];
        public static int[] Id = new int[10];
    }

    class Timestamp
    {
        public static int nbTour;
        public static int acTour = 1;
    }

    class SocketInfos
    {
        public static TcpClient client = new TcpClient("127.0.0.1", 777);
        public static NetworkStream stream = client.GetStream();
    }
}

        
