
namespace IMU_Test_Calibration
{
    partial class f_main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_main));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.picBox_logo_1 = new System.Windows.Forms.PictureBox();
            this.groupBox_imuData = new System.Windows.Forms.GroupBox();
            this.label_temp_val = new System.Windows.Forms.Label();
            this.label_mz_val = new System.Windows.Forms.Label();
            this.label_my_val = new System.Windows.Forms.Label();
            this.label_mx_val = new System.Windows.Forms.Label();
            this.label_gz_val = new System.Windows.Forms.Label();
            this.label_gy_val = new System.Windows.Forms.Label();
            this.label_gx_val = new System.Windows.Forms.Label();
            this.label_az_val = new System.Windows.Forms.Label();
            this.label_ay_val = new System.Windows.Forms.Label();
            this.label_ax_val = new System.Windows.Forms.Label();
            this.label_temp = new System.Windows.Forms.Label();
            this.label_Temparature = new System.Windows.Forms.Label();
            this.label_mz = new System.Windows.Forms.Label();
            this.label_my = new System.Windows.Forms.Label();
            this.label_mx = new System.Windows.Forms.Label();
            this.label_Magnetometer = new System.Windows.Forms.Label();
            this.label_gz = new System.Windows.Forms.Label();
            this.label_gy = new System.Windows.Forms.Label();
            this.label_gx = new System.Windows.Forms.Label();
            this.label_Gyroscope = new System.Windows.Forms.Label();
            this.label_az = new System.Windows.Forms.Label();
            this.label_ay = new System.Windows.Forms.Label();
            this.label_ax = new System.Windows.Forms.Label();
            this.label_Accelerometer = new System.Windows.Forms.Label();
            this.groupBox_com = new System.Windows.Forms.GroupBox();
            this.label_comStatus = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_connect = new System.Windows.Forms.Button();
            this.comboBox_baudrates = new System.Windows.Forms.ComboBox();
            this.label_baudrate = new System.Windows.Forms.Label();
            this.comboBox_comPorts = new System.Windows.Forms.ComboBox();
            this.label_comPort = new System.Windows.Forms.Label();
            this.groupBox_calibration = new System.Windows.Forms.GroupBox();
            this.groupBox_filter = new System.Windows.Forms.GroupBox();
            this.label_gamma_val = new System.Windows.Forms.Label();
            this.label_alpha_val = new System.Windows.Forms.Label();
            this.label_beta_val = new System.Windows.Forms.Label();
            this.label_gamma = new System.Windows.Forms.Label();
            this.label_beta = new System.Windows.Forms.Label();
            this.label_alpha = new System.Windows.Forms.Label();
            this.label_eulerAngles = new System.Windows.Forms.Label();
            this.label_q3_val = new System.Windows.Forms.Label();
            this.label_q2_val = new System.Windows.Forms.Label();
            this.label_q1_val = new System.Windows.Forms.Label();
            this.label_q0_val = new System.Windows.Forms.Label();
            this.label_q2 = new System.Windows.Forms.Label();
            this.label_q3 = new System.Windows.Forms.Label();
            this.label_q1 = new System.Windows.Forms.Label();
            this.label_q0 = new System.Windows.Forms.Label();
            this.label_quaternions = new System.Windows.Forms.Label();
            this.button_filterSelect = new System.Windows.Forms.Button();
            this.comboBox_filterList = new System.Windows.Forms.ComboBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.groupBox_graph = new System.Windows.Forms.GroupBox();
            this.chart_2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.timer_1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_logo_1)).BeginInit();
            this.groupBox_imuData.SuspendLayout();
            this.groupBox_com.SuspendLayout();
            this.groupBox_filter.SuspendLayout();
            this.groupBox_graph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_logo_1
            // 
            this.picBox_logo_1.Image = global::IMU_Test_Calibration.Properties.Resources.kuartek;
            resources.ApplyResources(this.picBox_logo_1, "picBox_logo_1");
            this.picBox_logo_1.Name = "picBox_logo_1";
            this.picBox_logo_1.TabStop = false;
            // 
            // groupBox_imuData
            // 
            this.groupBox_imuData.Controls.Add(this.label_temp_val);
            this.groupBox_imuData.Controls.Add(this.label_mz_val);
            this.groupBox_imuData.Controls.Add(this.label_my_val);
            this.groupBox_imuData.Controls.Add(this.label_mx_val);
            this.groupBox_imuData.Controls.Add(this.label_gz_val);
            this.groupBox_imuData.Controls.Add(this.label_gy_val);
            this.groupBox_imuData.Controls.Add(this.label_gx_val);
            this.groupBox_imuData.Controls.Add(this.label_az_val);
            this.groupBox_imuData.Controls.Add(this.label_ay_val);
            this.groupBox_imuData.Controls.Add(this.label_ax_val);
            this.groupBox_imuData.Controls.Add(this.label_temp);
            this.groupBox_imuData.Controls.Add(this.label_Temparature);
            this.groupBox_imuData.Controls.Add(this.label_mz);
            this.groupBox_imuData.Controls.Add(this.label_my);
            this.groupBox_imuData.Controls.Add(this.label_mx);
            this.groupBox_imuData.Controls.Add(this.label_Magnetometer);
            this.groupBox_imuData.Controls.Add(this.label_gz);
            this.groupBox_imuData.Controls.Add(this.label_gy);
            this.groupBox_imuData.Controls.Add(this.label_gx);
            this.groupBox_imuData.Controls.Add(this.label_Gyroscope);
            this.groupBox_imuData.Controls.Add(this.label_az);
            this.groupBox_imuData.Controls.Add(this.label_ay);
            this.groupBox_imuData.Controls.Add(this.label_ax);
            this.groupBox_imuData.Controls.Add(this.label_Accelerometer);
            this.groupBox_imuData.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.groupBox_imuData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.groupBox_imuData, "groupBox_imuData");
            this.groupBox_imuData.Name = "groupBox_imuData";
            this.groupBox_imuData.TabStop = false;
            // 
            // label_temp_val
            // 
            resources.ApplyResources(this.label_temp_val, "label_temp_val");
            this.label_temp_val.Name = "label_temp_val";
            // 
            // label_mz_val
            // 
            resources.ApplyResources(this.label_mz_val, "label_mz_val");
            this.label_mz_val.Name = "label_mz_val";
            // 
            // label_my_val
            // 
            resources.ApplyResources(this.label_my_val, "label_my_val");
            this.label_my_val.Name = "label_my_val";
            // 
            // label_mx_val
            // 
            resources.ApplyResources(this.label_mx_val, "label_mx_val");
            this.label_mx_val.Name = "label_mx_val";
            // 
            // label_gz_val
            // 
            resources.ApplyResources(this.label_gz_val, "label_gz_val");
            this.label_gz_val.Name = "label_gz_val";
            // 
            // label_gy_val
            // 
            resources.ApplyResources(this.label_gy_val, "label_gy_val");
            this.label_gy_val.Name = "label_gy_val";
            // 
            // label_gx_val
            // 
            resources.ApplyResources(this.label_gx_val, "label_gx_val");
            this.label_gx_val.Name = "label_gx_val";
            // 
            // label_az_val
            // 
            resources.ApplyResources(this.label_az_val, "label_az_val");
            this.label_az_val.Name = "label_az_val";
            // 
            // label_ay_val
            // 
            resources.ApplyResources(this.label_ay_val, "label_ay_val");
            this.label_ay_val.Name = "label_ay_val";
            // 
            // label_ax_val
            // 
            resources.ApplyResources(this.label_ax_val, "label_ax_val");
            this.label_ax_val.Name = "label_ax_val";
            // 
            // label_temp
            // 
            resources.ApplyResources(this.label_temp, "label_temp");
            this.label_temp.Name = "label_temp";
            // 
            // label_Temparature
            // 
            resources.ApplyResources(this.label_Temparature, "label_Temparature");
            this.label_Temparature.Name = "label_Temparature";
            // 
            // label_mz
            // 
            resources.ApplyResources(this.label_mz, "label_mz");
            this.label_mz.Name = "label_mz";
            // 
            // label_my
            // 
            resources.ApplyResources(this.label_my, "label_my");
            this.label_my.Name = "label_my";
            // 
            // label_mx
            // 
            resources.ApplyResources(this.label_mx, "label_mx");
            this.label_mx.Name = "label_mx";
            // 
            // label_Magnetometer
            // 
            resources.ApplyResources(this.label_Magnetometer, "label_Magnetometer");
            this.label_Magnetometer.Name = "label_Magnetometer";
            // 
            // label_gz
            // 
            resources.ApplyResources(this.label_gz, "label_gz");
            this.label_gz.Name = "label_gz";
            // 
            // label_gy
            // 
            resources.ApplyResources(this.label_gy, "label_gy");
            this.label_gy.Name = "label_gy";
            // 
            // label_gx
            // 
            resources.ApplyResources(this.label_gx, "label_gx");
            this.label_gx.Name = "label_gx";
            // 
            // label_Gyroscope
            // 
            resources.ApplyResources(this.label_Gyroscope, "label_Gyroscope");
            this.label_Gyroscope.Name = "label_Gyroscope";
            // 
            // label_az
            // 
            resources.ApplyResources(this.label_az, "label_az");
            this.label_az.Name = "label_az";
            // 
            // label_ay
            // 
            resources.ApplyResources(this.label_ay, "label_ay");
            this.label_ay.Name = "label_ay";
            // 
            // label_ax
            // 
            resources.ApplyResources(this.label_ax, "label_ax");
            this.label_ax.Name = "label_ax";
            // 
            // label_Accelerometer
            // 
            resources.ApplyResources(this.label_Accelerometer, "label_Accelerometer");
            this.label_Accelerometer.Name = "label_Accelerometer";
            // 
            // groupBox_com
            // 
            this.groupBox_com.Controls.Add(this.label_comStatus);
            this.groupBox_com.Controls.Add(this.label_status);
            this.groupBox_com.Controls.Add(this.button_cancel);
            this.groupBox_com.Controls.Add(this.button_connect);
            this.groupBox_com.Controls.Add(this.comboBox_baudrates);
            this.groupBox_com.Controls.Add(this.label_baudrate);
            this.groupBox_com.Controls.Add(this.comboBox_comPorts);
            this.groupBox_com.Controls.Add(this.label_comPort);
            resources.ApplyResources(this.groupBox_com, "groupBox_com");
            this.groupBox_com.Name = "groupBox_com";
            this.groupBox_com.TabStop = false;
            // 
            // label_comStatus
            // 
            resources.ApplyResources(this.label_comStatus, "label_comStatus");
            this.label_comStatus.Name = "label_comStatus";
            // 
            // label_status
            // 
            resources.ApplyResources(this.label_status, "label_status");
            this.label_status.Name = "label_status";
            // 
            // button_cancel
            // 
            resources.ApplyResources(this.button_cancel, "button_cancel");
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_connect
            // 
            resources.ApplyResources(this.button_connect, "button_connect");
            this.button_connect.Name = "button_connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // comboBox_baudrates
            // 
            resources.ApplyResources(this.comboBox_baudrates, "comboBox_baudrates");
            this.comboBox_baudrates.FormattingEnabled = true;
            this.comboBox_baudrates.Items.AddRange(new object[] {
            resources.GetString("comboBox_baudrates.Items"),
            resources.GetString("comboBox_baudrates.Items1"),
            resources.GetString("comboBox_baudrates.Items2"),
            resources.GetString("comboBox_baudrates.Items3"),
            resources.GetString("comboBox_baudrates.Items4")});
            this.comboBox_baudrates.Name = "comboBox_baudrates";
            this.comboBox_baudrates.SelectedIndexChanged += new System.EventHandler(this.comboBox_baudrates_SelectedIndexChanged);
            this.comboBox_baudrates.Click += new System.EventHandler(this.comboBox_baudrates_Click);
            // 
            // label_baudrate
            // 
            resources.ApplyResources(this.label_baudrate, "label_baudrate");
            this.label_baudrate.Name = "label_baudrate";
            // 
            // comboBox_comPorts
            // 
            resources.ApplyResources(this.comboBox_comPorts, "comboBox_comPorts");
            this.comboBox_comPorts.FormattingEnabled = true;
            this.comboBox_comPorts.Name = "comboBox_comPorts";
            this.comboBox_comPorts.SelectedIndexChanged += new System.EventHandler(this.comboBox_comPorts_SelectedIndexChanged);
            // 
            // label_comPort
            // 
            resources.ApplyResources(this.label_comPort, "label_comPort");
            this.label_comPort.Name = "label_comPort";
            // 
            // groupBox_calibration
            // 
            resources.ApplyResources(this.groupBox_calibration, "groupBox_calibration");
            this.groupBox_calibration.Name = "groupBox_calibration";
            this.groupBox_calibration.TabStop = false;
            // 
            // groupBox_filter
            // 
            this.groupBox_filter.Controls.Add(this.label_gamma_val);
            this.groupBox_filter.Controls.Add(this.label_alpha_val);
            this.groupBox_filter.Controls.Add(this.label_beta_val);
            this.groupBox_filter.Controls.Add(this.label_gamma);
            this.groupBox_filter.Controls.Add(this.label_beta);
            this.groupBox_filter.Controls.Add(this.label_alpha);
            this.groupBox_filter.Controls.Add(this.label_eulerAngles);
            this.groupBox_filter.Controls.Add(this.label_q3_val);
            this.groupBox_filter.Controls.Add(this.label_q2_val);
            this.groupBox_filter.Controls.Add(this.label_q1_val);
            this.groupBox_filter.Controls.Add(this.label_q0_val);
            this.groupBox_filter.Controls.Add(this.label_q2);
            this.groupBox_filter.Controls.Add(this.label_q3);
            this.groupBox_filter.Controls.Add(this.label_q1);
            this.groupBox_filter.Controls.Add(this.label_q0);
            this.groupBox_filter.Controls.Add(this.label_quaternions);
            this.groupBox_filter.Controls.Add(this.button_filterSelect);
            this.groupBox_filter.Controls.Add(this.comboBox_filterList);
            resources.ApplyResources(this.groupBox_filter, "groupBox_filter");
            this.groupBox_filter.Name = "groupBox_filter";
            this.groupBox_filter.TabStop = false;
            // 
            // label_gamma_val
            // 
            resources.ApplyResources(this.label_gamma_val, "label_gamma_val");
            this.label_gamma_val.Name = "label_gamma_val";
            // 
            // label_alpha_val
            // 
            resources.ApplyResources(this.label_alpha_val, "label_alpha_val");
            this.label_alpha_val.Name = "label_alpha_val";
            // 
            // label_beta_val
            // 
            resources.ApplyResources(this.label_beta_val, "label_beta_val");
            this.label_beta_val.Name = "label_beta_val";
            // 
            // label_gamma
            // 
            resources.ApplyResources(this.label_gamma, "label_gamma");
            this.label_gamma.Name = "label_gamma";
            // 
            // label_beta
            // 
            resources.ApplyResources(this.label_beta, "label_beta");
            this.label_beta.Name = "label_beta";
            // 
            // label_alpha
            // 
            resources.ApplyResources(this.label_alpha, "label_alpha");
            this.label_alpha.Name = "label_alpha";
            // 
            // label_eulerAngles
            // 
            resources.ApplyResources(this.label_eulerAngles, "label_eulerAngles");
            this.label_eulerAngles.Name = "label_eulerAngles";
            // 
            // label_q3_val
            // 
            resources.ApplyResources(this.label_q3_val, "label_q3_val");
            this.label_q3_val.Name = "label_q3_val";
            // 
            // label_q2_val
            // 
            resources.ApplyResources(this.label_q2_val, "label_q2_val");
            this.label_q2_val.Name = "label_q2_val";
            // 
            // label_q1_val
            // 
            resources.ApplyResources(this.label_q1_val, "label_q1_val");
            this.label_q1_val.Name = "label_q1_val";
            // 
            // label_q0_val
            // 
            resources.ApplyResources(this.label_q0_val, "label_q0_val");
            this.label_q0_val.Name = "label_q0_val";
            // 
            // label_q2
            // 
            resources.ApplyResources(this.label_q2, "label_q2");
            this.label_q2.Name = "label_q2";
            // 
            // label_q3
            // 
            resources.ApplyResources(this.label_q3, "label_q3");
            this.label_q3.Name = "label_q3";
            // 
            // label_q1
            // 
            resources.ApplyResources(this.label_q1, "label_q1");
            this.label_q1.Name = "label_q1";
            // 
            // label_q0
            // 
            resources.ApplyResources(this.label_q0, "label_q0");
            this.label_q0.Name = "label_q0";
            // 
            // label_quaternions
            // 
            resources.ApplyResources(this.label_quaternions, "label_quaternions");
            this.label_quaternions.Name = "label_quaternions";
            // 
            // button_filterSelect
            // 
            resources.ApplyResources(this.button_filterSelect, "button_filterSelect");
            this.button_filterSelect.Name = "button_filterSelect";
            this.button_filterSelect.UseVisualStyleBackColor = true;
            // 
            // comboBox_filterList
            // 
            resources.ApplyResources(this.comboBox_filterList, "comboBox_filterList");
            this.comboBox_filterList.FormattingEnabled = true;
            this.comboBox_filterList.Name = "comboBox_filterList";
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            this.serialPort.PortName = "COM7";
            this.serialPort.ReadTimeout = 150;
            // 
            // textBox_log
            // 
            resources.ApplyResources(this.textBox_log, "textBox_log");
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.TextChanged += new System.EventHandler(this.textBox_log_TextChanged);
            // 
            // groupBox_graph
            // 
            this.groupBox_graph.Controls.Add(this.chart_2);
            this.groupBox_graph.Controls.Add(this.chart_1);
            resources.ApplyResources(this.groupBox_graph, "groupBox_graph");
            this.groupBox_graph.Name = "groupBox_graph";
            this.groupBox_graph.TabStop = false;
            // 
            // chart_2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_2.ChartAreas.Add(chartArea1);
            this.chart_2.Cursor = System.Windows.Forms.Cursors.Cross;
            legend1.Name = "Legend1";
            this.chart_2.Legends.Add(legend1);
            resources.ApplyResources(this.chart_2, "chart_2");
            this.chart_2.Name = "chart_2";
            this.chart_2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "x";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "y";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "z";
            this.chart_2.Series.Add(series1);
            this.chart_2.Series.Add(series2);
            this.chart_2.Series.Add(series3);
            // 
            // chart_1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_1.ChartAreas.Add(chartArea2);
            this.chart_1.Cursor = System.Windows.Forms.Cursors.Cross;
            legend2.Name = "Legend1";
            this.chart_1.Legends.Add(legend2);
            resources.ApplyResources(this.chart_1, "chart_1");
            this.chart_1.Name = "chart_1";
            this.chart_1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "x";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "y";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "z";
            this.chart_1.Series.Add(series4);
            this.chart_1.Series.Add(series5);
            this.chart_1.Series.Add(series6);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // timer_1
            // 
            this.timer_1.Interval = 10;
            this.timer_1.Tick += new System.EventHandler(this.timer_1_Tick);
            // 
            // f_main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_graph);
            this.Controls.Add(this.textBox_log);
            this.Controls.Add(this.groupBox_filter);
            this.Controls.Add(this.groupBox_calibration);
            this.Controls.Add(this.groupBox_com);
            this.Controls.Add(this.groupBox_imuData);
            this.Controls.Add(this.picBox_logo_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "f_main";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_logo_1)).EndInit();
            this.groupBox_imuData.ResumeLayout(false);
            this.groupBox_imuData.PerformLayout();
            this.groupBox_com.ResumeLayout(false);
            this.groupBox_com.PerformLayout();
            this.groupBox_filter.ResumeLayout(false);
            this.groupBox_filter.PerformLayout();
            this.groupBox_graph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_logo_1;
        private System.Windows.Forms.GroupBox groupBox_imuData;
        private System.Windows.Forms.Label label_Accelerometer;
        private System.Windows.Forms.Label label_az;
        private System.Windows.Forms.Label label_ay;
        private System.Windows.Forms.Label label_ax;
        private System.Windows.Forms.Label label_temp;
        private System.Windows.Forms.Label label_Temparature;
        private System.Windows.Forms.Label label_mz;
        private System.Windows.Forms.Label label_my;
        private System.Windows.Forms.Label label_mx;
        private System.Windows.Forms.Label label_Magnetometer;
        private System.Windows.Forms.Label label_gz;
        private System.Windows.Forms.Label label_gy;
        private System.Windows.Forms.Label label_gx;
        private System.Windows.Forms.Label label_Gyroscope;
        private System.Windows.Forms.Label label_az_val;
        private System.Windows.Forms.Label label_ay_val;
        private System.Windows.Forms.Label label_ax_val;
        private System.Windows.Forms.Label label_temp_val;
        private System.Windows.Forms.Label label_mz_val;
        private System.Windows.Forms.Label label_my_val;
        private System.Windows.Forms.Label label_mx_val;
        private System.Windows.Forms.Label label_gz_val;
        private System.Windows.Forms.Label label_gy_val;
        private System.Windows.Forms.Label label_gx_val;
        private System.Windows.Forms.GroupBox groupBox_com;
        private System.Windows.Forms.ComboBox comboBox_comPorts;
        private System.Windows.Forms.Label label_comPort;
        private System.Windows.Forms.ComboBox comboBox_baudrates;
        private System.Windows.Forms.Label label_baudrate;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label_comStatus;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.GroupBox groupBox_calibration;
        private System.Windows.Forms.GroupBox groupBox_filter;
        private System.Windows.Forms.Button button_filterSelect;
        private System.Windows.Forms.ComboBox comboBox_filterList;
        private System.Windows.Forms.Label label_quaternions;
        private System.Windows.Forms.Label label_q2;
        private System.Windows.Forms.Label label_q3;
        private System.Windows.Forms.Label label_q1;
        private System.Windows.Forms.Label label_q0;
        private System.Windows.Forms.Label label_q3_val;
        private System.Windows.Forms.Label label_q2_val;
        private System.Windows.Forms.Label label_q1_val;
        private System.Windows.Forms.Label label_q0_val;
        private System.Windows.Forms.Label label_gamma;
        private System.Windows.Forms.Label label_beta;
        private System.Windows.Forms.Label label_alpha;
        private System.Windows.Forms.Label label_eulerAngles;
        private System.Windows.Forms.Label label_gamma_val;
        private System.Windows.Forms.Label label_alpha_val;
        private System.Windows.Forms.Label label_beta_val;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.GroupBox groupBox_graph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Timer timer_1;
    }
}

