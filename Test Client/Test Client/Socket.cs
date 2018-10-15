using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Net.Security;
using System.Windows.Forms;

namespace Test_Client
{
    public class Sock
    {
        public static void Connect(TcpClient client, NetworkStream stream)
        {
            client = new TcpClient("127.0.0.1", 777);
            stream = client.GetStream();
        }
        public static void Envoi(TcpClient client, NetworkStream stream, string sendbuf)
        {
            int byteCount = 0;
            byte[] sendData = new byte[byteCount];
            byteCount = Encoding.ASCII.GetByteCount(sendbuf + 0);
            sendData = Encoding.ASCII.GetBytes(sendbuf + 0);
            stream.Write(sendData, 0, sendData.Length);
        }
        public static void Recv(TcpClient client, NetworkStream stream)
        {
            
            byte[] receivedBuffer = new byte[2048];
            stream.Read(receivedBuffer, 0, receivedBuffer.Length);
            StringBuilder msg = new StringBuilder();
            foreach (byte b in receivedBuffer)
            {
                if (b.Equals(00))
                {
                    break;
                }
                else
                {
                    msg.Append(Convert.ToChar(b).ToString());
                }
            }
            System.Diagnostics.Process.Start("wordpad.exe", Convert.ToString(msg));
        }
        public static void Close(TcpClient client, NetworkStream stream)
        {
            int byteCount = 0;
            byte[] sendData = new byte[byteCount];
            sendData = Encoding.ASCII.GetBytes("");
            stream.Write(sendData, 0, sendData.Length);
            stream = client.GetStream();
            stream.Close();
            client.Close();
        }
    }
}
