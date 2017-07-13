using System;
using System.Net;
using System.Net.Sockets;
using Common.Logging;

namespace mechatronika_net.illumiwifi.led
{
    internal sealed class UdpConnection
    {
        private UdpClient _udp;
        private readonly ILog _log;

        public UdpConnection()
        {
            _log = LogManager.GetLogger(GetType());
        }

        public bool Connect(string host, int port)
        {
            try
            {
                _udp = new UdpClient { Client = { ReceiveTimeout = 200 } };
                _udp.Connect(host, port);
            }
            catch (Exception ex)
            {
                _log.Error(ex);
                return false;
            }

            return true;
        }

        public bool Disconnect()
        {
            try
            {
                _udp.Close();
            }
            catch (Exception ex)
            {
                _log.Error(ex);
                return false;
            }
            return true;
        }

        public void Send(byte[] buf, int length)
        {
            try
            {
                _udp.Send(buf, length);
            }
            catch (Exception ex)
            {
                _log.Error(ex);
            }
        }

        public void Receive(ref byte[] buf)
        {
            var allRemoteHosts = new IPEndPoint(IPAddress.Any, 0);

            try
            {
                buf = _udp.Receive(ref allRemoteHosts);
            }
            catch (Exception ex)
            {
                _log.Error(ex);
            }
        }

    }
}
