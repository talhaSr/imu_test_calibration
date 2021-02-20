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
        /* Chart Variables */
        long xLimMax = 100, xLimMin = 0;
        long yLimMax = 4096, yLimMin = -4096;

        /* USB Variables */
        public string buffer;
        public string[] data = new string[10];
        public string[] comStatus = { "Disconnected", "Connected" };
        public f_main()
        {
            InitializeComponent();
            comboBox_comPorts.Items.AddRange(SerialPort.GetPortNames());
            /* Chart_1 Configuration */
            chart_1.ChartAreas[0].AxisX.Minimum = xLimMin;
            chart_1.ChartAreas[0].AxisX.Maximum = xLimMax;
            chart_1.ChartAreas[0].AxisY.Minimum = yLimMin; 
            chart_1.ChartAreas[0].AxisY.Maximum = yLimMax;

            chart_1.ChartAreas[0].AxisX.ScaleView.Zoom(xLimMin, xLimMax);

            /* Chart_2 Configuration */
            chart_2.ChartAreas[0].AxisX.Minimum = xLimMin;
            chart_2.ChartAreas[0].AxisX.Maximum = xLimMax;
            chart_2.ChartAreas[0].AxisY.Minimum = yLimMin;
            chart_2.ChartAreas[0].AxisY.Maximum = yLimMax;

            chart_2.ChartAreas[0].AxisX.ScaleView.Zoom(xLimMin, xLimMax);
        }

        private void comboBox_comPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort.PortName = comboBox_comPorts.SelectedItem.ToString();
        }

        private void comboBox_baudrates_SelectedIndexChanged(object sender, EventArgs e)
        {
            //serialPort.BaudRate = Convert.ToInt32(comboBox_baudrates.SelectedItem);
            serialPort.BaudRate = int.Parse(comboBox_baudrates.SelectedItem.ToString());
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

        private void timer_1_Tick(object sender, EventArgs e)
        {
            /* Chart Update */
            this.chart_1.Series[0].Points.AddXY((xLimMin + xLimMax) / 2, int.Parse(data[0]));
            xLimMax++; xLimMin++;
        }

        public void serial_veri(object sender, SerialDataReceivedEventArgs args)
        {
            buffer = serialPort.ReadLine().ToString();

            /* Split İşlemi Başlangıç */
            data = Utils.SplitString(',', buffer);
            /* Split İşlemi Bitiş */

            /* IMU Data Label Update */
            label_ax_val.Invoke(new MethodInvoker(delegate { label_ax_val.Text = data[0]; }));
            label_ay_val.Invoke(new MethodInvoker(delegate { label_ay_val.Text = data[1]; }));
            label_az_val.Invoke(new MethodInvoker(delegate { label_az_val.Text = data[2]; }));
            
            label_gx_val.Invoke(new MethodInvoker(delegate { label_gx_val.Text = data[3]; }));
            label_gy_val.Invoke(new MethodInvoker(delegate { label_gy_val.Text = data[4]; }));
            label_gz_val.Invoke(new MethodInvoker(delegate { label_gz_val.Text = data[5]; }));

            label_mx_val.Invoke(new MethodInvoker(delegate { label_mx_val.Text = data[6]; }));
            label_my_val.Invoke(new MethodInvoker(delegate { label_my_val.Text = data[7]; }));
            label_mz_val.Invoke(new MethodInvoker(delegate { label_mz_val.Text = data[8]; }));
            
            label_temp_val.Invoke(new MethodInvoker(delegate { label_temp_val.Text = data[9]; }));

            serialPort.DiscardInBuffer();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.DiscardInBuffer();
                serialPort.Close();
            }
            label_comStatus.Invoke(new MethodInvoker(delegate { label_comStatus.Text = comStatus[0]; label_comStatus.ForeColor = System.Drawing.Color.Red; }));
            textBox_log.Text = "Port: " + serialPort.PortName.ToString() + Environment.NewLine + "Baudrate: " + serialPort.BaudRate.ToString();
        }
    }
}
