
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_logo_1)).BeginInit();
            this.groupBox_imuData.SuspendLayout();
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
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // f_main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_imuData);
            this.Controls.Add(this.picBox_logo_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "f_main";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_logo_1)).EndInit();
            this.groupBox_imuData.ResumeLayout(false);
            this.groupBox_imuData.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

