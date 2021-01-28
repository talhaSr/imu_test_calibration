
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_main));
            this.picBox_logo_1 = new System.Windows.Forms.PictureBox();
            this.groupBox_imuData = new System.Windows.Forms.GroupBox();
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
            this.label_gx_val = new System.Windows.Forms.Label();
            this.label_gy_val = new System.Windows.Forms.Label();
            this.label_gz_val = new System.Windows.Forms.Label();
            this.label_mx_val = new System.Windows.Forms.Label();
            this.label_my_val = new System.Windows.Forms.Label();
            this.label_mz_val = new System.Windows.Forms.Label();
            this.label_temp_val = new System.Windows.Forms.Label();
            this.groupBox_com = new System.Windows.Forms.GroupBox();
            this.comboBox_comPorts = new System.Windows.Forms.ComboBox();
            this.label_comPort = new System.Windows.Forms.Label();
            this.label_baudrate = new System.Windows.Forms.Label();
            this.comboBox_baudrates = new System.Windows.Forms.ComboBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label_status = new System.Windows.Forms.Label();
            this.label_comStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_filterList = new System.Windows.Forms.ComboBox();
            this.button_filterSelect = new System.Windows.Forms.Button();
            this.label_quaternions = new System.Windows.Forms.Label();
            this.label_q0 = new System.Windows.Forms.Label();
            this.label_q1 = new System.Windows.Forms.Label();
            this.label_q3 = new System.Windows.Forms.Label();
            this.label_q2 = new System.Windows.Forms.Label();
            this.label_q0_val = new System.Windows.Forms.Label();
            this.label_q1_val = new System.Windows.Forms.Label();
            this.label_q2_val = new System.Windows.Forms.Label();
            this.label_q3_val = new System.Windows.Forms.Label();
            this.label_eulerAngles = new System.Windows.Forms.Label();
            this.label_alpha = new System.Windows.Forms.Label();
            this.label_beta = new System.Windows.Forms.Label();
            this.label_gamma = new System.Windows.Forms.Label();
            this.label_beta_val = new System.Windows.Forms.Label();
            this.label_alpha_val = new System.Windows.Forms.Label();
            this.label_gamma_val = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_logo_1)).BeginInit();
            this.groupBox_imuData.SuspendLayout();
            this.groupBox_com.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // label_gx_val
            // 
            resources.ApplyResources(this.label_gx_val, "label_gx_val");
            this.label_gx_val.Name = "label_gx_val";
            // 
            // label_gy_val
            // 
            resources.ApplyResources(this.label_gy_val, "label_gy_val");
            this.label_gy_val.Name = "label_gy_val";
            // 
            // label_gz_val
            // 
            resources.ApplyResources(this.label_gz_val, "label_gz_val");
            this.label_gz_val.Name = "label_gz_val";
            // 
            // label_mx_val
            // 
            resources.ApplyResources(this.label_mx_val, "label_mx_val");
            this.label_mx_val.Name = "label_mx_val";
            // 
            // label_my_val
            // 
            resources.ApplyResources(this.label_my_val, "label_my_val");
            this.label_my_val.Name = "label_my_val";
            // 
            // label_mz_val
            // 
            resources.ApplyResources(this.label_mz_val, "label_mz_val");
            this.label_mz_val.Name = "label_mz_val";
            // 
            // label_temp_val
            // 
            resources.ApplyResources(this.label_temp_val, "label_temp_val");
            this.label_temp_val.Name = "label_temp_val";
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
            // comboBox_comPorts
            // 
            resources.ApplyResources(this.comboBox_comPorts, "comboBox_comPorts");
            this.comboBox_comPorts.FormattingEnabled = true;
            this.comboBox_comPorts.Name = "comboBox_comPorts";
            // 
            // label_comPort
            // 
            resources.ApplyResources(this.label_comPort, "label_comPort");
            this.label_comPort.Name = "label_comPort";
            // 
            // label_baudrate
            // 
            resources.ApplyResources(this.label_baudrate, "label_baudrate");
            this.label_baudrate.Name = "label_baudrate";
            // 
            // comboBox_baudrates
            // 
            resources.ApplyResources(this.comboBox_baudrates, "comboBox_baudrates");
            this.comboBox_baudrates.FormattingEnabled = true;
            this.comboBox_baudrates.Name = "comboBox_baudrates";
            // 
            // button_connect
            // 
            resources.ApplyResources(this.button_connect, "button_connect");
            this.button_connect.Name = "button_connect";
            this.button_connect.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            resources.ApplyResources(this.button_cancel, "button_cancel");
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // label_status
            // 
            resources.ApplyResources(this.label_status, "label_status");
            this.label_status.Name = "label_status";
            // 
            // label_comStatus
            // 
            resources.ApplyResources(this.label_comStatus, "label_comStatus");
            this.label_comStatus.Name = "label_comStatus";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_gamma_val);
            this.groupBox2.Controls.Add(this.label_alpha_val);
            this.groupBox2.Controls.Add(this.label_beta_val);
            this.groupBox2.Controls.Add(this.label_gamma);
            this.groupBox2.Controls.Add(this.label_beta);
            this.groupBox2.Controls.Add(this.label_alpha);
            this.groupBox2.Controls.Add(this.label_eulerAngles);
            this.groupBox2.Controls.Add(this.label_q3_val);
            this.groupBox2.Controls.Add(this.label_q2_val);
            this.groupBox2.Controls.Add(this.label_q1_val);
            this.groupBox2.Controls.Add(this.label_q0_val);
            this.groupBox2.Controls.Add(this.label_q2);
            this.groupBox2.Controls.Add(this.label_q3);
            this.groupBox2.Controls.Add(this.label_q1);
            this.groupBox2.Controls.Add(this.label_q0);
            this.groupBox2.Controls.Add(this.label_quaternions);
            this.groupBox2.Controls.Add(this.button_filterSelect);
            this.groupBox2.Controls.Add(this.comboBox_filterList);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // comboBox_filterList
            // 
            resources.ApplyResources(this.comboBox_filterList, "comboBox_filterList");
            this.comboBox_filterList.FormattingEnabled = true;
            this.comboBox_filterList.Name = "comboBox_filterList";
            // 
            // button_filterSelect
            // 
            resources.ApplyResources(this.button_filterSelect, "button_filterSelect");
            this.button_filterSelect.Name = "button_filterSelect";
            this.button_filterSelect.UseVisualStyleBackColor = true;
            // 
            // label_quaternions
            // 
            resources.ApplyResources(this.label_quaternions, "label_quaternions");
            this.label_quaternions.Name = "label_quaternions";
            // 
            // label_q0
            // 
            resources.ApplyResources(this.label_q0, "label_q0");
            this.label_q0.Name = "label_q0";
            // 
            // label_q1
            // 
            resources.ApplyResources(this.label_q1, "label_q1");
            this.label_q1.Name = "label_q1";
            // 
            // label_q3
            // 
            resources.ApplyResources(this.label_q3, "label_q3");
            this.label_q3.Name = "label_q3";
            // 
            // label_q2
            // 
            resources.ApplyResources(this.label_q2, "label_q2");
            this.label_q2.Name = "label_q2";
            // 
            // label_q0_val
            // 
            resources.ApplyResources(this.label_q0_val, "label_q0_val");
            this.label_q0_val.Name = "label_q0_val";
            // 
            // label_q1_val
            // 
            resources.ApplyResources(this.label_q1_val, "label_q1_val");
            this.label_q1_val.Name = "label_q1_val";
            // 
            // label_q2_val
            // 
            resources.ApplyResources(this.label_q2_val, "label_q2_val");
            this.label_q2_val.Name = "label_q2_val";
            // 
            // label_q3_val
            // 
            resources.ApplyResources(this.label_q3_val, "label_q3_val");
            this.label_q3_val.Name = "label_q3_val";
            // 
            // label_eulerAngles
            // 
            resources.ApplyResources(this.label_eulerAngles, "label_eulerAngles");
            this.label_eulerAngles.Name = "label_eulerAngles";
            // 
            // label_alpha
            // 
            resources.ApplyResources(this.label_alpha, "label_alpha");
            this.label_alpha.Name = "label_alpha";
            // 
            // label_beta
            // 
            resources.ApplyResources(this.label_beta, "label_beta");
            this.label_beta.Name = "label_beta";
            // 
            // label_gamma
            // 
            resources.ApplyResources(this.label_gamma, "label_gamma");
            this.label_gamma.Name = "label_gamma";
            // 
            // label_beta_val
            // 
            resources.ApplyResources(this.label_beta_val, "label_beta_val");
            this.label_beta_val.Name = "label_beta_val";
            // 
            // label_alpha_val
            // 
            resources.ApplyResources(this.label_alpha_val, "label_alpha_val");
            this.label_alpha_val.Name = "label_alpha_val";
            // 
            // label_gamma_val
            // 
            resources.ApplyResources(this.label_gamma_val, "label_gamma_val");
            this.label_gamma_val.Name = "label_gamma_val";
            // 
            // f_main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
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
    }
}

