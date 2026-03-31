using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using CSdllMightyZap;

namespace MightyZapDemo_CS2010
{
    public partial class Form1 : Form
    {
        MightyZap MZap = new MightyZap();
        byte Servo_ID=0;
        int error=0;
        int connection = 0;
        public Form1()
        {
            InitializeComponent();
            string[] portName;
            portName = SerialPort.GetPortNames();
            comboBox1.Items.Clear();   // 리스트 박스 초기화
            foreach (var item in portName)
            {
                comboBox1.Items.Add(item);
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            int Position;
            Servo_ID = (byte)Convert.ToInt16(mServoID.Text.ToString());
            Position = MZap.PresentPosition(Servo_ID);

            textPresentPosition.Clear();
            textPresentPosition.AppendText(Position.ToString());
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            string portName, buadRate;
            int baud, temp;
            if (connection == 0)
            {
                portName = comboBox1.SelectedItem as string;
                buadRate = comboBox2.SelectedItem as string;
                baud = Convert.ToInt32(buadRate);
                MZap.OpenMightyZap(portName, baud);
                
                // Read Data
                temp = MZap.Read_Addr(Servo_ID, 140, 2);
                textPosition.Clear();
                textPresentPosition.Clear();
                textPosition.AppendText(temp.ToString());
                textPresentPosition.AppendText(temp.ToString());

                temp = MZap.Read_Addr(Servo_ID, 6, 2);
                textShortLimit.Clear();
                textShortLimit.AppendText(temp.ToString());

                temp = MZap.Read_Addr(Servo_ID, 8, 2);
                textLongLimit.Clear();
                textLongLimit.AppendText(temp.ToString());

                temp = MZap.Read_Addr(Servo_ID, 0x15, 2);
                textSpeed.Clear();
                textSpeed.AppendText(temp.ToString());

                Connect.Text = "Disconnect";
                connection = 1;
            }
            else
            {
                
                MZap.CloseMightyZap();
                Connect.Text = "Connect";
                connection = 0;
            }
        }

        private void GoalPosition_Click(object sender, EventArgs e)
        {
            short Position;
            Servo_ID = (byte)Convert.ToInt16(mServoID.Text.ToString());            
            Position = (short)Convert.ToInt16(textPosition.Text.ToString());            
            MZap.GoalPosition(Servo_ID, Position);

            ErrorRead();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            short StrokeLimit;
            Servo_ID = (byte)Convert.ToInt16(mServoID.Text.ToString());
            StrokeLimit = (short)Convert.ToInt16(textShortLimit.Text.ToString());
            MZap.Write_Addr(Servo_ID, 0x06, 2, StrokeLimit);

            ErrorRead();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            short StrokeLimit;
            Servo_ID = (byte)Convert.ToInt16(mServoID.Text.ToString());
            StrokeLimit = (short)Convert.ToInt16(textLongLimit.Text.ToString());
            MZap.Write_Addr(Servo_ID, 0x08, 2, StrokeLimit);

            ErrorRead();
        }

        private void AddrWrite_Click(object sender, EventArgs e)
        {
            byte addr, bytes;
            short data;
            Servo_ID = (byte)Convert.ToInt16(mServoID.Text.ToString());
            addr = (byte)Convert.ToInt16(textWriteAddr.Text.ToString());
            bytes = (byte)Convert.ToInt16(textWriteBytes.Text.ToString());
            data = (short)Convert.ToInt16(textWriteData.Text.ToString());
            MZap.Write_Addr(Servo_ID, addr, bytes, data);

            ErrorRead();
        }

        private void AddrRead_Click(object sender, EventArgs e)
        {
            byte addr, bytes;
            int  data;
            Servo_ID = (byte)Convert.ToInt16(mServoID.Text.ToString());
            addr = (byte)Convert.ToInt16(textReadAddr.Text.ToString());
            bytes = (byte)Convert.ToInt16(textReadBytes.Text.ToString());            
            data = MZap.Read_Addr(Servo_ID, addr, bytes);
            data = MZap.Read_Addr(Servo_ID, addr, bytes);
            data = MZap.Read_Addr(Servo_ID, addr, bytes);
            textReadData.Clear();
            textReadData.AppendText(data.ToString());

            ErrorRead();
        }

        void ErrorRead()
        {
            error = MZap.ReadError(Servo_ID);
            if ((error & 0x40) == 0x40) InsError.Checked = true;
            else InsError.Checked = false;
            if ((error & 0x10) == 0x20) OverloadError.Checked = true;
            else OverloadError.Checked = false;
            if ((error & 0x10) == 0x10) ChecksumError.Checked = true;
            else ChecksumError.Checked = false;
            if ((error & 0x08) == 0x08) RangeError.Checked = true;
            else RangeError.Checked = false;
            if ((error & 0x02) == 0x02) StrokeError.Checked = true;
            else StrokeError.Checked = false;
            if ((error & 0x01) == 0x01) VoltageError.Checked = true;
            else VoltageError.Checked = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {            
            ErrorRead();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int sdAlarm;
            sdAlarm = MZap.GetShutDownEnable(Servo_ID);

            if ((sdAlarm & 0x40) == 0x40) InsErrorSD.Checked = true;
            else InsErrorSD.Checked = false;
            if ((sdAlarm & 0x20) == 0x20) OverloadErrorSD.Checked = true;
            else OverloadErrorSD.Checked = false;
            if ((sdAlarm & 0x10) == 0x10) CheckSumErrorSD.Checked = true;
            else CheckSumErrorSD.Checked = false;
            if ((error & 0x08) == 0x08) RangeErrorSD.Checked = true;
            else RangeErrorSD.Checked = false;
            if ((sdAlarm & 0x02) == 0x02) StrokeErrorSD.Checked = true;
            else StrokeErrorSD.Checked = false;
            if ((sdAlarm & 0x01) == 0x01) VoltageErrorSD.Checked = true;
            else VoltageErrorSD.Checked = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            short Speed;
            Servo_ID = (byte)Convert.ToInt16(mServoID.Text.ToString());
            Speed = (short)Convert.ToInt16(textSpeed.Text.ToString());
            MZap.Write_Addr(Servo_ID, 0x15, 2, Speed);

            ErrorRead();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            byte Alarm=0;

            if (InsErrorSD.Checked == true) Alarm |= 0x40;
            if (OverloadErrorSD.Checked == true) Alarm |= 0x20;
            if (CheckSumErrorSD.Checked == true) Alarm |= 0x10;
            if (RangeErrorSD.Checked == true) Alarm |= 0x08;
            if (StrokeErrorSD.Checked == true) Alarm |= 0x02;
            if (VoltageErrorSD.Checked == true) Alarm |= 0x01;

            MZap.SetShutDownEnable(Servo_ID,Alarm);
        }
    }
}
