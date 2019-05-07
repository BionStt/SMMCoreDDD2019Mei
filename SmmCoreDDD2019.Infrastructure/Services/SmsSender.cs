using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Options;
using System.IO.Ports;
using System.IO;
using System.Threading;

namespace SmmCoreDDD2019.Infrastructure.Services
{
    public class SmsSender : ISmsSender
    {
        public SerialPort _serialPort;
        private ManualResetEvent receiveNow;
        private System.Threading.AutoResetEvent receiveNow1;

        public Task SendSmsAsync(string number, string message)
        {
            // throw new NotImplementedException();
            // Plug in your SMS service here to send a text message.

            // Please check MessageServices_twilio.cs or MessageServices_ASPSMS.cs
            // for implementation details.
            _serialPort = new SerialPort("COM4", 115200, Parity.None, 8, StopBits.One);
            _serialPort.Handshake = Handshake.None;
            _serialPort.Encoding = Encoding.GetEncoding("iso-8859-1");
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(Port_DataReceived);
            _serialPort.ReadTimeout = 2000;
            _serialPort.WriteTimeout = 2000;

            try
            {
                _serialPort.Open();
                if (!_serialPort.IsOpen)
                    _serialPort.Open();
                _serialPort.Write("AT+CMGF=1\r\n");
                Thread.Sleep(1000);
                _serialPort.Write("AT+CSCA=SERVICE\r\n");// Service Center  
                Thread.Sleep(1000);
                _serialPort.Write("AT+CMGS=\"" + number + "\"" + Environment.NewLine);
                _serialPort.Write(message + char.ConvertFromUtf32(26) + Environment.NewLine);
                Thread.Sleep(1000);
                _serialPort.Write("AT+CMGD=1,4\r\n");
                _serialPort.Close();

            }
            catch (Exception ex)
            {

            }                       
            return Task.FromResult(0);
            // return Task.CompletedTask;
            // throw new NotImplementedException();

        }
        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (e.EventType != SerialData.Chars)
                return;
            this.receiveNow.Set();
        }

        public SerialPort OpenPort(string p_strPortName, int p_uBaudRate, int p_uDataBits, int p_uReadTimeout, int p_uWriteTimeout)
        {
            receiveNow1 = new AutoResetEvent(false);
            SerialPort port = new SerialPort();

            try
            {
                port.PortName = p_strPortName;                 //COM1
                port.BaudRate = p_uBaudRate;                   //9600
                port.DataBits = p_uDataBits;                   //8
                port.StopBits = StopBits.One;                  //1
                port.Parity = Parity.None;                     //None
                port.ReadTimeout = p_uReadTimeout;             //300
                port.WriteTimeout = p_uWriteTimeout;           //300
                port.Encoding = Encoding.GetEncoding("iso-8859-1");
                port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
                port.Open();
                port.DtrEnable = true;
                port.RtsEnable = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return port;
        }

        public void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (e.EventType == SerialData.Chars)
                    receiveNow.Set();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
