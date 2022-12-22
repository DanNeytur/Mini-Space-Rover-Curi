namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.up_button = new System.Windows.Forms.Button();
            this.down_button = new System.Windows.Forms.Button();
            this.right_button = new System.Windows.Forms.Button();
            this.left_button = new System.Windows.Forms.Button();
            this.dir_num = new System.Windows.Forms.TextBox();
            this.Live_Stream = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Snap_box = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cam_angle_bar = new System.Windows.Forms.VScrollBar();
            this.cam_angle_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.speed_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.speed = new System.Windows.Forms.TextBox();
            this.motor_info_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.shoot_button = new System.Windows.Forms.Button();
            this.Camera_Start = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label5 = new System.Windows.Forms.Label();
            this.IP_textbox = new System.Windows.Forms.TextBox();
            this.filterBox = new System.Windows.Forms.CheckBox();
            this.HP_box = new System.Windows.Forms.CheckBox();
            this.sobel_box = new System.Windows.Forms.CheckBox();
            this.scale_bar = new System.Windows.Forms.VScrollBar();
            this.Scale_label = new System.Windows.Forms.Label();
            this.Scale_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.servos34_text = new System.Windows.Forms.TextBox();
            this.servos12_text = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.arm_dir_text = new System.Windows.Forms.TextBox();
            this.arm_dir_bar = new System.Windows.Forms.VScrollBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.arm_claw_bar = new System.Windows.Forms.VScrollBar();
            this.arm_claw_text = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Reset_button = new System.Windows.Forms.Button();
            this.sharpening_box = new System.Windows.Forms.CheckBox();
            this.LPF_box = new System.Windows.Forms.CheckBox();
            this.color_worker = new System.ComponentModel.BackgroundWorker();
            this.search_box = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Live_Stream)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Snap_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // up_button
            // 
            this.up_button.Location = new System.Drawing.Point(113, 316);
            this.up_button.Name = "up_button";
            this.up_button.Size = new System.Drawing.Size(75, 23);
            this.up_button.TabIndex = 0;
            this.up_button.Text = "UP";
            this.up_button.UseVisualStyleBackColor = true;
            this.up_button.Click += new System.EventHandler(this.up_button_Click);
            // 
            // down_button
            // 
            this.down_button.Location = new System.Drawing.Point(113, 389);
            this.down_button.Name = "down_button";
            this.down_button.Size = new System.Drawing.Size(75, 23);
            this.down_button.TabIndex = 1;
            this.down_button.Text = "DOWN";
            this.down_button.UseVisualStyleBackColor = true;
            this.down_button.Click += new System.EventHandler(this.down_button_Click);
            // 
            // right_button
            // 
            this.right_button.Location = new System.Drawing.Point(210, 347);
            this.right_button.Name = "right_button";
            this.right_button.Size = new System.Drawing.Size(75, 23);
            this.right_button.TabIndex = 2;
            this.right_button.Text = "RIGHT";
            this.right_button.UseVisualStyleBackColor = true;
            this.right_button.Click += new System.EventHandler(this.right_button_Click);
            // 
            // left_button
            // 
            this.left_button.Location = new System.Drawing.Point(12, 347);
            this.left_button.Name = "left_button";
            this.left_button.Size = new System.Drawing.Size(75, 23);
            this.left_button.TabIndex = 3;
            this.left_button.Text = "LEFT";
            this.left_button.UseVisualStyleBackColor = true;
            this.left_button.Click += new System.EventHandler(this.left_button_Click);
            // 
            // dir_num
            // 
            this.dir_num.Location = new System.Drawing.Point(100, 458);
            this.dir_num.Name = "dir_num";
            this.dir_num.Size = new System.Drawing.Size(100, 20);
            this.dir_num.TabIndex = 4;
            this.dir_num.Text = "1111";
            // 
            // Live_Stream
            // 
            this.Live_Stream.Location = new System.Drawing.Point(12, 48);
            this.Live_Stream.Name = "Live_Stream";
            this.Live_Stream.Size = new System.Drawing.Size(283, 262);
            this.Live_Stream.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Live_Stream.TabIndex = 5;
            this.Live_Stream.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "תמונת זמן אמת";
            // 
            // Snap_box
            // 
            this.Snap_box.Location = new System.Drawing.Point(639, 48);
            this.Snap_box.Name = "Snap_box";
            this.Snap_box.Size = new System.Drawing.Size(283, 262);
            this.Snap_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Snap_box.TabIndex = 7;
            this.Snap_box.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(723, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "תמונה אחרונה שצולמה";
            // 
            // cam_angle_bar
            // 
            this.cam_angle_bar.LargeChange = 1;
            this.cam_angle_bar.Location = new System.Drawing.Point(43, 532);
            this.cam_angle_bar.Maximum = 7;
            this.cam_angle_bar.Name = "cam_angle_bar";
            this.cam_angle_bar.Size = new System.Drawing.Size(17, 80);
            this.cam_angle_bar.TabIndex = 9;
            this.cam_angle_bar.Value = 3;
            this.cam_angle_bar.ValueChanged += new System.EventHandler(this.cam_angle_bar_ValueChanged);
            // 
            // cam_angle_text
            // 
            this.cam_angle_text.Location = new System.Drawing.Point(12, 615);
            this.cam_angle_text.Name = "cam_angle_text";
            this.cam_angle_text.Size = new System.Drawing.Size(100, 20);
            this.cam_angle_text.TabIndex = 10;
            this.cam_angle_text.Text = "3  77";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "מנועים";
            // 
            // speed_button
            // 
            this.speed_button.Location = new System.Drawing.Point(294, 426);
            this.speed_button.Name = "speed_button";
            this.speed_button.Size = new System.Drawing.Size(44, 23);
            this.speed_button.TabIndex = 12;
            this.speed_button.Text = "Slow";
            this.speed_button.UseVisualStyleBackColor = true;
            this.speed_button.Click += new System.EventHandler(this.speed_button_Click);
            // 
            // stop_button
            // 
            this.stop_button.Location = new System.Drawing.Point(113, 347);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(75, 23);
            this.stop_button.TabIndex = 13;
            this.stop_button.Text = "Stop";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(294, 455);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(28, 20);
            this.speed.TabIndex = 14;
            this.speed.Text = "00";
            // 
            // motor_info_text
            // 
            this.motor_info_text.Location = new System.Drawing.Point(407, 91);
            this.motor_info_text.Name = "motor_info_text";
            this.motor_info_text.Size = new System.Drawing.Size(100, 20);
            this.motor_info_text.TabIndex = 15;
            this.motor_info_text.Text = "00001111   15";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(428, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "נשלח";
            // 
            // shoot_button
            // 
            this.shoot_button.Location = new System.Drawing.Point(940, 91);
            this.shoot_button.Name = "shoot_button";
            this.shoot_button.Size = new System.Drawing.Size(75, 23);
            this.shoot_button.TabIndex = 17;
            this.shoot_button.Text = "Shoot";
            this.shoot_button.UseVisualStyleBackColor = true;
            this.shoot_button.Click += new System.EventHandler(this.shoot_button_Click);
            // 
            // Camera_Start
            // 
            this.Camera_Start.Location = new System.Drawing.Point(533, 297);
            this.Camera_Start.Name = "Camera_Start";
            this.Camera_Start.Size = new System.Drawing.Size(75, 39);
            this.Camera_Start.TabIndex = 18;
            this.Camera_Start.Text = "Camera Start";
            this.Camera_Start.UseVisualStyleBackColor = true;
            this.Camera_Start.Click += new System.EventHandler(this.Camera_Start_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(530, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Camera IP";
            // 
            // IP_textbox
            // 
            this.IP_textbox.Location = new System.Drawing.Point(516, 389);
            this.IP_textbox.Name = "IP_textbox";
            this.IP_textbox.Size = new System.Drawing.Size(100, 20);
            this.IP_textbox.TabIndex = 15;
            this.IP_textbox.Text = "192.168.1.47";
            // 
            // filterBox
            // 
            this.filterBox.AutoSize = true;
            this.filterBox.Location = new System.Drawing.Point(940, 141);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(77, 17);
            this.filterBox.TabIndex = 21;
            this.filterBox.Text = "סינון צבע";
            this.filterBox.UseVisualStyleBackColor = true;
            this.filterBox.CheckedChanged += new System.EventHandler(this.filterBox_CheckedChanged);
            // 
            // HP_box
            // 
            this.HP_box.AutoSize = true;
            this.HP_box.Location = new System.Drawing.Point(940, 164);
            this.HP_box.Name = "HP_box";
            this.HP_box.Size = new System.Drawing.Size(47, 17);
            this.HP_box.TabIndex = 21;
            this.HP_box.Text = "HPF";
            this.HP_box.UseVisualStyleBackColor = true;
            this.HP_box.CheckedChanged += new System.EventHandler(this.HP_box_CheckedChanged);
            // 
            // sobel_box
            // 
            this.sobel_box.AutoSize = true;
            this.sobel_box.Location = new System.Drawing.Point(940, 187);
            this.sobel_box.Name = "sobel_box";
            this.sobel_box.Size = new System.Drawing.Size(72, 17);
            this.sobel_box.TabIndex = 21;
            this.sobel_box.Text = "קווי קצה";
            this.sobel_box.UseVisualStyleBackColor = true;
            this.sobel_box.CheckedChanged += new System.EventHandler(this.sobel_box_CheckedChanged);
            // 
            // scale_bar
            // 
            this.scale_bar.LargeChange = 1;
            this.scale_bar.Location = new System.Drawing.Point(953, 329);
            this.scale_bar.Maximum = 47;
            this.scale_bar.Minimum = 1;
            this.scale_bar.Name = "scale_bar";
            this.scale_bar.Size = new System.Drawing.Size(20, 111);
            this.scale_bar.TabIndex = 22;
            this.scale_bar.Value = 1;
            this.scale_bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scale_bar_Scroll);
            // 
            // Scale_label
            // 
            this.Scale_label.AutoSize = true;
            this.Scale_label.Location = new System.Drawing.Point(928, 297);
            this.Scale_label.Name = "Scale_label";
            this.Scale_label.Size = new System.Drawing.Size(60, 13);
            this.Scale_label.TabIndex = 11;
            this.Scale_label.Text = "Scale/Amp";
            // 
            // Scale_box
            // 
            this.Scale_box.Location = new System.Drawing.Point(940, 455);
            this.Scale_box.Name = "Scale_box";
            this.Scale_box.Size = new System.Drawing.Size(33, 20);
            this.Scale_box.TabIndex = 15;
            this.Scale_box.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(513, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = ": סרבו 4,3";
            // 
            // servos34_text
            // 
            this.servos34_text.Location = new System.Drawing.Point(407, 162);
            this.servos34_text.Name = "servos34_text";
            this.servos34_text.Size = new System.Drawing.Size(100, 20);
            this.servos34_text.TabIndex = 15;
            this.servos34_text.Text = "00001111   15";
            // 
            // servos12_text
            // 
            this.servos12_text.Location = new System.Drawing.Point(407, 125);
            this.servos12_text.Name = "servos12_text";
            this.servos12_text.Size = new System.Drawing.Size(100, 20);
            this.servos12_text.TabIndex = 15;
            this.servos12_text.Text = "00001111   15";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(513, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = ": סרבו 2,1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 508);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = ": סרבו מצלמה";
            // 
            // arm_dir_text
            // 
            this.arm_dir_text.Location = new System.Drawing.Point(185, 615);
            this.arm_dir_text.Name = "arm_dir_text";
            this.arm_dir_text.Size = new System.Drawing.Size(100, 20);
            this.arm_dir_text.TabIndex = 10;
            this.arm_dir_text.Text = "3  77";
            // 
            // arm_dir_bar
            // 
            this.arm_dir_bar.LargeChange = 1;
            this.arm_dir_bar.Location = new System.Drawing.Point(221, 532);
            this.arm_dir_bar.Maximum = 7;
            this.arm_dir_bar.Name = "arm_dir_bar";
            this.arm_dir_bar.Size = new System.Drawing.Size(17, 80);
            this.arm_dir_bar.TabIndex = 9;
            this.arm_dir_bar.Value = 4;
            this.arm_dir_bar.ValueChanged += new System.EventHandler(this.arm_dir_bar_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(392, 508);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = ":זרוע צבת";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(196, 508);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = ":זרוע כיוון";
            // 
            // arm_claw_bar
            // 
            this.arm_claw_bar.LargeChange = 1;
            this.arm_claw_bar.Location = new System.Drawing.Point(421, 532);
            this.arm_claw_bar.Maximum = 7;
            this.arm_claw_bar.Name = "arm_claw_bar";
            this.arm_claw_bar.Size = new System.Drawing.Size(17, 80);
            this.arm_claw_bar.TabIndex = 9;
            this.arm_claw_bar.Value = 4;
            this.arm_claw_bar.ValueChanged += new System.EventHandler(this.arm_claw_bar_ValueChanged);
            // 
            // arm_claw_text
            // 
            this.arm_claw_text.Location = new System.Drawing.Point(380, 615);
            this.arm_claw_text.Name = "arm_claw_text";
            this.arm_claw_text.Size = new System.Drawing.Size(100, 20);
            this.arm_claw_text.TabIndex = 10;
            this.arm_claw_text.Text = "3  77";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Reset_button
            // 
            this.Reset_button.Location = new System.Drawing.Point(737, 357);
            this.Reset_button.Name = "Reset_button";
            this.Reset_button.Size = new System.Drawing.Size(83, 35);
            this.Reset_button.TabIndex = 23;
            this.Reset_button.Text = "Reset";
            this.Reset_button.UseVisualStyleBackColor = true;
            this.Reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // sharpening_box
            // 
            this.sharpening_box.AutoSize = true;
            this.sharpening_box.Location = new System.Drawing.Point(940, 210);
            this.sharpening_box.Name = "sharpening_box";
            this.sharpening_box.Size = new System.Drawing.Size(57, 17);
            this.sharpening_box.TabIndex = 21;
            this.sharpening_box.Text = "חידוד";
            this.sharpening_box.UseVisualStyleBackColor = true;
            this.sharpening_box.CheckedChanged += new System.EventHandler(this.sharpening_box_CheckedChanged);
            // 
            // LPF_box
            // 
            this.LPF_box.AutoSize = true;
            this.LPF_box.Location = new System.Drawing.Point(940, 233);
            this.LPF_box.Name = "LPF_box";
            this.LPF_box.Size = new System.Drawing.Size(45, 17);
            this.LPF_box.TabIndex = 21;
            this.LPF_box.Text = "LPF";
            this.LPF_box.UseVisualStyleBackColor = true;
            this.LPF_box.CheckedChanged += new System.EventHandler(this.LPF_box_CheckedChanged);
            // 
            // color_worker
            // 
            this.color_worker.WorkerSupportsCancellation = true;
            this.color_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.color_worker_DoWork);
            // 
            // search_box
            // 
            this.search_box.AutoSize = true;
            this.search_box.Location = new System.Drawing.Point(940, 256);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(83, 17);
            this.search_box.TabIndex = 21;
            this.search_box.Text = "חיפוש צבע";
            this.search_box.UseVisualStyleBackColor = true;
            this.search_box.CheckedChanged += new System.EventHandler(this.search_box_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(622, 398);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 288);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1029, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(337, 694);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1378, 718);
            this.Controls.Add(this.Reset_button);
            this.Controls.Add(this.scale_bar);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.LPF_box);
            this.Controls.Add(this.sharpening_box);
            this.Controls.Add(this.sobel_box);
            this.Controls.Add(this.HP_box);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Camera_Start);
            this.Controls.Add(this.shoot_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Scale_box);
            this.Controls.Add(this.IP_textbox);
            this.Controls.Add(this.servos12_text);
            this.Controls.Add(this.servos34_text);
            this.Controls.Add(this.motor_info_text);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.speed_button);
            this.Controls.Add(this.Scale_label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.arm_claw_text);
            this.Controls.Add(this.arm_dir_text);
            this.Controls.Add(this.cam_angle_text);
            this.Controls.Add(this.arm_claw_bar);
            this.Controls.Add(this.arm_dir_bar);
            this.Controls.Add(this.cam_angle_bar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Snap_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Live_Stream);
            this.Controls.Add(this.dir_num);
            this.Controls.Add(this.left_button);
            this.Controls.Add(this.right_button);
            this.Controls.Add(this.down_button);
            this.Controls.Add(this.up_button);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "graphics";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Live_Stream)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Snap_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button up_button;
        private System.Windows.Forms.Button down_button;
        private System.Windows.Forms.Button right_button;
        private System.Windows.Forms.Button left_button;
        private System.Windows.Forms.TextBox dir_num;
        private System.Windows.Forms.PictureBox Live_Stream;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Snap_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.VScrollBar cam_angle_bar;
        private System.Windows.Forms.TextBox cam_angle_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button speed_button;
        private System.Windows.Forms.Button stop_button;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox speed;
        private System.Windows.Forms.TextBox motor_info_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button shoot_button;
        private System.Windows.Forms.Button Camera_Start;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IP_textbox;
        private System.Windows.Forms.CheckBox filterBox;
        private System.Windows.Forms.CheckBox HP_box;
        private System.Windows.Forms.CheckBox sobel_box;
        private System.Windows.Forms.VScrollBar scale_bar;
        private System.Windows.Forms.Label Scale_label;
        private System.Windows.Forms.TextBox Scale_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox servos34_text;
        private System.Windows.Forms.TextBox servos12_text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox arm_dir_text;
        private System.Windows.Forms.VScrollBar arm_dir_bar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.VScrollBar arm_claw_bar;
        private System.Windows.Forms.TextBox arm_claw_text;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Reset_button;
        private System.Windows.Forms.CheckBox sharpening_box;
        private System.Windows.Forms.CheckBox LPF_box;
        private System.ComponentModel.BackgroundWorker color_worker;
        private System.Windows.Forms.CheckBox search_box;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

