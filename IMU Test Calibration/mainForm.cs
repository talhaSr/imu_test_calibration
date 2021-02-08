using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace IMU_Test_Calibration
{
    public partial class f_main : Form
    {
        public string[] acc = new string[3];
        public string[] gyro = new string[3];
        public string[] mag = new string[3];
        public string temp;
        public string[] comStatus = { "Not Connected", "Connected" };
        public f_main()
        {
            InitializeComponent();
            comboBox_comPorts.Items.AddRange(SerialPort.GetPortNames());
        }

        private void comboBox_comPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort.PortName = comboBox_comPorts.SelectedItem.ToString();
        }

        private void comboBox_baudrates_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort.BaudRate = Convert.ToInt32(comboBox_baudrates.SelectedItem);
        }

        private void textBox_log_TextChanged(object sender, EventArgs e)
        {
            textBox_log.SelectionStart = textBox_log.Text.Length;
            textBox_log.ScrollToCaret();
        }

        private void comboBox_baudrates_Click(object sender, EventArgs e)
        {
            comboBox_comPorts.Items.AddRange(SerialPort.GetPortNames());
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Open();
                textBox_log.Text = "Port: " + serialPort.PortName.ToString() + Environment.NewLine + "Baudrate: " + serialPort.BaudRate.ToString();
                serialPort.DataReceived += new SerialDataReceivedEventHandler(serial_veri);
                label_comStatus.Invoke(new MethodInvoker(delegate { label_comStatus.Text = comStatus[1]; label_comStatus.ForeColor = System.Drawing.Color.Green; }));
            }
            #region
            catch (UnauthorizedAccessException SerialException)
            {
                /* İşletim sistemi yetkilendirme hatası */
                MessageBox.Show(SerialException.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_log.Text = "Port: " + serialPort.PortName.ToString() + Environment.NewLine + "Baudrate: " + serialPort.BaudRate.ToString();
                textBox_log.Text += Environment.NewLine + SerialException.ToString();
                serialPort.Close();
                label_comStatus.Invoke(new MethodInvoker(delegate { label_comStatus.Text = comStatus[0]; label_comStatus.ForeColor = System.Drawing.Color.Red; }));
            }
            catch (System.IO.IOException SerialException)
            {
                /* Port durum hatası */
                MessageBox.Show(SerialException.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_log.Text = "Port: " + serialPort.PortName.ToString() + Environment.NewLine + "Baudrate: " + serialPort.BaudRate.ToString();
                textBox_log.Text += Environment.NewLine + SerialException.ToString();
                serialPort.Close();
                label_comStatus.Invoke(new MethodInvoker(delegate { label_comStatus.Text = comStatus[0]; label_comStatus.ForeColor = System.Drawing.Color.Red; }));
            }
            catch (InvalidOperationException SerialException)
            {
                /* Port başka bir birim tarafından kullanılıyorsa */
                MessageBox.Show(SerialException.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_log.Text = "Port: " + serialPort.PortName.ToString() + Environment.NewLine + "Baudrate: " + serialPort.BaudRate.ToString();
                textBox_log.Text += Environment.NewLine + SerialException.ToString();
                serialPort.Close();
                label_comStatus.Invoke(new MethodInvoker(delegate { label_comStatus.Text = comStatus[0]; label_comStatus.ForeColor = System.Drawing.Color.Red; }));
            }
            catch
            {
                MessageBox.Show("Port açılırken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                serialPort.Close();
                label_comStatus.Invoke(new MethodInvoker(delegate { label_comStatus.Text = comStatus[0]; label_comStatus.ForeColor = System.Drawing.Color.Red; }));
            }
            #endregion
        }

        public void serial_veri(object sender, SerialDataReceivedEventArgs args)
        {

        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            serialPort.Close();
            label_comStatus.Invoke(new MethodInvoker(delegate { label_comStatus.Text = comStatus[0]; label_comStatus.ForeColor = System.Drawing.Color.Red; }));
            textBox_log.Text = "Port: " + serialPort.PortName.ToString() + Environment.NewLine + "Baudrate: " + serialPort.BaudRate.ToString();
        }
    }
}
