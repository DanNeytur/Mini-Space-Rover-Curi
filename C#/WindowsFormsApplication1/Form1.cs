using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.IO;
using System.IO.Ports;
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.Structure;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        bool front = false, back = false, right = false, left = false;
        bool CheckboxCheck = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void speed_button_Click(object sender, EventArgs e)
        {
            if (speed_button.Text == "Fast")
            {
                speed_button.Text = "Slow";
                speed.Text = "00";
                
            }
            else
            {
                speed_button.Text = "Fast";
                speed.Text = "11";
            }
            motor_info_text.Text = "00" + speed.Text + dir_num.Text;
            send_data(motor_info_text.Text);
        }

        private void down_button_Click(object sender, EventArgs e)
        {
            dir_num.Text = "1010";
            motor_info_text.Text = "00" + speed.Text + dir_num.Text;
            send_data(motor_info_text.Text);
        }

        


        private void up_button_Click(object sender, EventArgs e)
        {
            dir_num.Text = "0101";
            motor_info_text.Text = "00" + speed.Text + dir_num.Text;
            send_data(motor_info_text.Text);
        }

        private void left_button_Click(object sender, EventArgs e)
        {
            dir_num.Text = "0100";
            motor_info_text.Text = "00" + speed.Text + dir_num.Text;
            send_data(motor_info_text.Text);
        }

        private void right_button_Click(object sender, EventArgs e)
        {
            dir_num.Text = "0001";
            motor_info_text.Text = "00" + speed.Text + dir_num.Text;
            send_data(motor_info_text.Text);
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            dir_num.Text = "1111";
            motor_info_text.Text = "00" + speed.Text + dir_num.Text;
            send_data(motor_info_text.Text);
        }

        public void down_button_Click()
        {
            dir_num.Text = "1010";
        }
        public void up_button_Click()
        {
            dir_num.Text = "0101";
        }

        public void left_button_Click()
        {
            dir_num.Text = "0110";
        }

        public void stop_button_Click()
        {
            dir_num.Text = "1111";
            motor_info_text.Text = "00" + speed.Text + dir_num.Text;
            send_data(motor_info_text.Text);
        }

        public void right_button_Click()
        {
            dir_num.Text = "1001";
        }

        private void cam_angle_bar_ValueChanged(object sender, EventArgs e)
        {
            cam_angle_text.Text = (7 - cam_angle_bar.Value).ToString();// +"    " + ((7 - cam_angle_bar.Value) * 180 / 7).ToString();
            servos12_text.Text = "01" + dec2bin(arm_dir_text.Text) + dec2bin(cam_angle_text.Text);
            send_data(servos12_text.Text);
        }

       
        private void arm_dir_bar_ValueChanged(object sender, EventArgs e)
        {
            arm_dir_text.Text = (arm_dir_bar.Value).ToString();// +"    " + ((arm_dir_bar.Value) * 180 / 7).ToString();
            servos12_text.Text = "01" + dec2bin(arm_dir_text.Text) + dec2bin(cam_angle_text.Text);
            send_data(servos12_text.Text);
        }

        private void arm_claw_bar_ValueChanged(object sender, EventArgs e)
        {
            arm_claw_text.Text = (arm_claw_bar.Value).ToString();// +"    " + ((arm_claw_bar.Value) * 180 / 7).ToString();
            servos34_text.Text = "10" + "000" + dec2bin(arm_claw_text.Text);
            send_data(servos34_text.Text);
        }

       
        public void closeSerial()
        {
            serialPort1.Close();
        }
        private void send_data(string data)
        {
            
            byte[] info_ser= new byte[1];
            
            info_ser[0] = (byte)bin2dec(data);
            //info_text.Text = speed.Text + dec2bin(cam_angle.Text) + dir_num.Text;
            //this.SetinfoText(speed.Text + dec2bin(cam_angle.Text) + dir_num.Text + "   "+((int)info_ser[0]).ToString());
            
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(info_ser, 0, 1);
            }
        }

        private int bin2dec(string str)
        {
            int info_ser_tmp=0;
            for (int i = 0; i < 8; i++)
            {
                info_ser_tmp += (int)(str[i] - '0') * (int)Math.Pow(2.0, (double)(7-i));
            }
            return info_ser_tmp;
        }

        private string dec2bin(string str)
        {
            char tmp2;
            string ret="";
            int tmp;
            tmp = str[0] - '0';
            for (int i = 2; i >=0; i--)
            {
                tmp2 = (char)(((tmp / Math.Pow(2.0, (double)i)) % 2 + '0'));
                ret += tmp2;//.ToString();
            }
            return ret;
        }

        public void start_SerialPort()
        {
            serialPort1.BaudRate = 9600;
            serialPort1.PortName = "com23";
            serialPort1.DataBits = 8;
            serialPort1.Encoding = new UnicodeEncoding();// otherwise if the output is larger then 127 it will send 63('?')
            serialPort1.Parity = System.IO.Ports.Parity.None;
            serialPort1.StopBits = System.IO.Ports.StopBits.One;
            serialPort1.Handshake = System.IO.Ports.Handshake.None;
            serialPort1.WriteTimeout = 500;
            serialPort1.Open();
        }

        private void Camera_Start_Click(object sender, EventArgs e)
        {
            if(backgroundWorker1.IsBusy==false)
            {
                if (IP_textbox.Text != "")
                {
                    backgroundWorker1.RunWorkerAsync();
                    Camera_Start.Text = "Camera Stop";
                }
                else
                {
                    MessageBox.Show("FORGOT TO ENTER IP");
                }
            }
            else
            {
                
                backgroundWorker1.CancelAsync();
                Camera_Start.Text = "Camera Start";
            }

        }

        

        private Bitmap GetImage()
        {
            string sourceUrl = "http://"+IP_textbox.Text+"/snapshot.cgi?user=admin&pwd=";

            byte[] buffer = new byte[1280 * 960];
            int read, total = 0;

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(sourceUrl);
            WebResponse resp;
            req.Timeout = 3000;
            resp = req.GetResponse();

            Stream stream = resp.GetResponseStream();

            /*while ((read = stream.Read(buffer, total, 1000)) != 0)
            {
                total += read;
            }*/
            Bitmap bmp;

            bmp = (Bitmap)Bitmap.FromStream(stream);//new MemoryStream(buffer, 0, total));
                
            return bmp;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            VideoCapture capture = new VideoCapture(); //create a camera capture
            //Bitmap image = capture.QueryFrame().Bitmap; //take a picture

            

            
            BackgroundWorker worker = sender as BackgroundWorker;
            Image<Bgr, Byte> img,img3=new Image<Bgr, byte>(640, 480, new Bgr(255,255,255));
            Image<Hsv, Byte> img2;
            Hsv high2 = new Hsv(255, 255, 255), low2 = new Hsv(0, 0, 0);
            bool FirstScan = true;//false-not first scan, true-first scan
            while (worker.CancellationPending != true)
            {
                try
                {
                    img = new Image<Bgr, Byte>(capture.QueryFrame().Bitmap);//capture.QueryFrame().Bitmap);//GetImage());
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show(ex.Message);
                    backgroundWorker1.CancelAsync();
                    this.Invoke(new MethodInvoker(delegate
                    {
                        Camera_Start.Text = "Camera Start";
                    }));

                    img = new Image<Bgr, byte>(640, 480, new Bgr(255,255,255));
                }

                    if (sharpening_box.Checked == true)
                    {
                        img3 = sharpening_convert(img.Clone());
                    }
                    else if (LPF_box.Checked == true)
                    {
                        img3 = LPF_convert(img.Clone());
                    }
                    else if (HP_box.Checked == true)
                    {
                        img3 = HPF_convert(img);
                    }
                    else if (sobel_box.Checked == true)
                    {
                        img3 = sobel_convert(img);
                    }
                    else if (filterBox.Checked == true)
                    {
                        img2 = img.Convert<Hsv, Byte>();
                        if(FirstScan==true)
                        {
                            FirstScan = false;
                            img.Draw(new Rectangle(320 - scale_bar.Value * 5, 240 - scale_bar.Value * 5, scale_bar.Value * 10, scale_bar.Value * 10), new Bgr(0, 0, 255), 1);//this function creates rectangle that represent the area of pixels scaned
                            
                            low2.Hue = GetHueLow(img2)-5;
                            high2.Hue = GetHueHigh(img2)+5;

                            Live_Stream.Image = img.ToBitmap();
                            Thread.Sleep(5000);
                        }
                        else
                        {
                            img3=img.And(img2.InRange(low2, high2).Convert<Bgr, Byte>());//.ToBitmap();
                            //Thread.Sleep(100);//delete this-----------------------------------------------------------------------------
                        }

                       
                    }
                    else
                    {
                        FirstScan = true;
                        CheckboxCheck = false;
                    }
                    
                    if(search_box.Checked)
                    {
                        Live_Stream.Image = img3.ToBitmap();
                    }
                    else if (CheckboxCheck)
                    {
                        Snap_box.Image = img3.ToBitmap();
                        Live_Stream.Image = img.ToBitmap();
                    }
                    else
                    {
                        Live_Stream.Image = img.ToBitmap();
                    }

                    img.Dispose();
                


            }
            e.Cancel = true;

            capture.Dispose();
        }

        private Image<Bgr, Byte> ColorFilter(Bgr high, Bgr low, Image<Bgr, Byte> img)
        {
            Image<Gray, Byte> filtered =new Image<Gray, Byte>(640, 480, new Gray(255));
            filtered = img.InRange(low, high);
            //filtered = img.InRange(new Bgr(0,0,0), new Bgr(50,50,255));
            //Snap_box.Image =LPF_convert(new Image<Bgr,Byte>(filtered.ToBitmap())).ToBitmap();
            //filtered = LPF_convert(new Image<Bgr, Byte>(filtered.ToBitmap())).Convert<Gray, Byte>();
            //Snap_box.Image = filtered.ToBitmap();
            //filtered.ThresholdToZero(new Gray(254));
            
            
            
            img = img.And(filtered.Convert<Bgr,Byte>());
            return img;
        }


        private void shoot_button_Click(object sender, EventArgs e)
        {
            //Image<Bgr, Byte> img;
            //Bitmap tmp;
            try
            {
                //tmp = GetImage();
                //img =new Image<Bgr,Byte>(tmp);
                //LineSegment2D lineX1=new LineSegment2D(new Point(200, 133), new Point(400, 133));
                //LineSegment2D lineX2 = new LineSegment2D(new Point(200, 133), new Point(400, 133));
                //img.Draw(new Rectangle(200, 133, 200, 133), new Bgr(0, 0, 255), 1);
                //img.Draw(lineX1, new Bgr(0, 0, 255), 5);

                Snap_box.Image = GetImage();//img.ToBitmap();
                
                //img.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Bgr GetBgrLow(Image<Bgr,Byte> img)
        {
            Bgr Low = new Bgr(255, 255, 255);
            for (int x = 320 - scale_bar.Value*5; x < 320 + scale_bar.Value*5; x++)
            {
                for (int y = 240 - scale_bar.Value*5; y < 240 + scale_bar.Value*5; y++)
                {
                    if(Low.Blue>img[y,x].Blue)
                    {
                        Low.Blue = img[y, x].Blue;
                    }
                    if (Low.Green > img[y, x].Green)
                    {
                        Low.Green = img[y, x].Green;
                    }
                    if (Low.Red > img[y, x].Red)
                    {
                        Low.Red = img[y, x].Red;
                    }
                }
            }
            return Low;
        }


        private Bgr GetBgrHigh(Image<Bgr, Byte> img)
        {
            Bgr high = new Bgr(0, 0, 0);
            for (int x = 320 - scale_bar.Value*5; x < 320 + scale_bar.Value*5; x++)
            {
                for (int y = 240 - scale_bar.Value*5; y < 240 + scale_bar.Value*5; y++)
                {
                    if (high.Blue < img[y, x].Blue)
                    {
                        high.Blue = img[y, x].Blue;
                    }
                    if (high.Green < img[y, x].Green)
                    {
                        high.Green = img[y, x].Green;
                    }
                    if (high.Red < img[y, x].Red)
                    {
                        high.Red = img[y, x].Red;
                    }
                }
            }
            return high;
        }

        private double GetHueLow(Image<Hsv, Byte> img)
        {
            double Hue = 255;
            for (int x = 320 - scale_bar.Value * 5; x < 320 + scale_bar.Value * 5; x++)
            {
                for (int y = 240 - scale_bar.Value * 5; y < 240 + scale_bar.Value * 5; y++)
                {
                    if (Hue > img[y, x].Hue)
                    {
                        Hue = img[y, x].Hue;
                    }
                }
            }
            return Hue;
        }

        private double GetHueHigh(Image<Hsv, Byte> img)
        {
            double Hue = 0;
            for (int x = 320 - scale_bar.Value * 5; x < 320 + scale_bar.Value * 5; x++)
            {
                for (int y = 240 - scale_bar.Value * 5; y < 240 + scale_bar.Value * 5; y++)
                {
                    if (Hue < img[y, x].Hue)
                    {
                        Hue = img[y, x].Hue;
                    }
                }
            }
            return Hue;
        }

        private double GetHueAvg(Image<Hsv, Byte> img)
        {
            double avg = 0; ;

            for (int x = 320 - scale_bar.Value * 5; x < 320 + scale_bar.Value * 5; x++)
            {
                for (int y = 240 - scale_bar.Value * 5; y < 240 + scale_bar.Value * 5; y++)
                {
                    avg += img[y, x].Hue / ((double)scale_bar.Value * scale_bar.Value*10);
                }
            }
            return avg;
        }

         /*private Hsv GetHsvLow(Image<Hsv, Byte> img)
        {
            Hsv Low = new Hsv(255, 255, 255);
            for (int x = 320 - scale_bar.Value * 5; x < 320 + scale_bar.Value * 5; x++)
            {
                for (int y = 240 - scale_bar.Value * 5; y < 240 + scale_bar.Value * 5; y++)
                {
                    if (Low.Hue > img[y, x].Hue)
                    {
                        Low.Hue = img[y, x].Hue;
                    }
                    if (Low.Satuation > img[y, x].Satuation)
                    {
                        Low.Green = img[y, x].Green;
                    }
                    if (Low.Red > img[y, x].Red)
                    {
                        Low.Red = img[y, x].Red;
                    }
                }
            }
            return Low;
        }*/


        private Image<Bgr,Byte> HPF_convert(Image<Bgr,Byte> img)
        {
            Image<Gray, float> kernel = new Image<Gray, float>(3,3,new Gray(-1));
            kernel[1,1] = new Gray(8);
            kernel *= scale_bar.Value/8.0;
            Image<Gray,Byte> img2 = img.Convert<Gray, Byte>();
            CvInvoke.Filter2D(img2, img2, kernel, new Point(-1, -1), 0, Emgu.CV.CvEnum.BorderType.Default);

            return img2.Convert<Bgr, Byte>();//new Image<Bgr,Byte>(img2.ToBitmap());
        }

        private Image<Bgr, Byte> LPF_convert(Image<Bgr, Byte> img)
        {
            int len = scale_bar.Value * 2 + 1;
            Image<Gray, float> kernel = new Image<Gray, float>(len, len, new Gray(1 / ((double)len*len)));//99
           
            //kernel /= ((double)(scale_bar.Value * 2 + 1)*(scale_bar.Value * 2 + 1));//81.0
            //Image<Gray, Byte> img2 = img.Convert<Gray, Byte>();
            CvInvoke.Filter2D(img, img, kernel, new Point(-1, -1), 0, Emgu.CV.CvEnum.BorderType.Default);
            return img;
        }

        private Image<Bgr, Byte> sharpening_convert(Image<Bgr, Byte> img)
        {
            Image<Gray, float> kernel = new Image<Gray, float>(3, 3,new Gray(-1));
            kernel[1, 1] = new Gray(9);
            /*kernel[0, 0] = new Gray(-1); kernel[0, 1] = new Gray(-1); kernel[0, 2] = new Gray(-1);
            kernel[1, 0] = new Gray(-1); kernel[1, 1] = new Gray(9); kernel[1, 2] = new Gray(-1);
            kernel[2, 0] = new Gray(-1); kernel[2, 1] = new Gray(-1); kernel[2, 2] = new Gray(-1);*/
           
            kernel *= scale_bar.Value/8.0;
            CvInvoke.Filter2D(img, img, kernel, new Point(-1, -1), 0, Emgu.CV.CvEnum.BorderType.Default);

            return img;
        }

        private Image<Bgr,Byte> sobel_convert(Image<Bgr,Byte> img)
        {
            Image<Gray, float> kernel = new Image<Gray, float>(3, 3);//Gx/y
            Image<Gray, Byte> Gx1,Gx2;// = new Image<Gray, Byte>(640, 480);
            Image<Gray, Byte> Gy1,Gy2;// = new Image<Gray, Byte>(640, 480);
            Image<Gray, Byte> G = new Image<Gray, Byte>(640, 480);
            kernel[0, 0] = new Gray(1); kernel[0, 1] = new Gray(0); kernel[0, 2] = new Gray(-1);//Hx
            kernel[1, 0] = new Gray(2); kernel[1, 1] = new Gray(0); kernel[1, 2] = new Gray(-2);
            kernel[2, 0] = new Gray(1); kernel[2, 1] = new Gray(0); kernel[2, 2] = new Gray(-1);
            kernel *= scale_bar.Value;
            Gx1 = img.Convert<Gray, Byte>();
            Gx2 = img.Convert<Gray, Byte>();
            CvInvoke.Filter2D(Gx1, Gx1, kernel, new Point(-1, -1), 0, Emgu.CV.CvEnum.BorderType.Default);//Gx
            CvInvoke.Filter2D(Gx2, Gx2, kernel*(-1), new Point(-1, -1), 0, Emgu.CV.CvEnum.BorderType.Default);//Gx
            
            kernel[0, 0] = new Gray(1); kernel[0, 1] = new Gray(2); kernel[0, 2] = new Gray(1);//Hy
            kernel[1, 0] = new Gray(0); kernel[1, 1] = new Gray(0); kernel[1, 2] = new Gray(0);
            kernel[2, 0] = new Gray(-1); kernel[2, 1] = new Gray(-2); kernel[2, 2] = new Gray(-1);
            kernel *= scale_bar.Value;
            Gy1 = img.Convert<Gray, Byte>();
            Gy2 = img.Convert<Gray, Byte>();
            CvInvoke.Filter2D(Gy1, Gy1, kernel, new Point(-1, -1), 0, Emgu.CV.CvEnum.BorderType.Default);//Gy
            CvInvoke.Filter2D(Gy2, Gy2, -1*kernel, new Point(-1, -1), 0, Emgu.CV.CvEnum.BorderType.Default);//Gy
            Gy1 = Gy1.Add(Gy2);
            Gx1 = Gx1.Add(Gx2);
            G = Gy1.Add(Gx1);
            //CvInvoke.Add(Gx, Gy, G);
            //CvInvoke.BitwiseOr(Gx, Gy, G);
            //G=G.AbsDiff(new Gray(0));
            return G.Convert<Bgr, Byte>();
        }

        private void HP_box_CheckedChanged(object sender, EventArgs e)
        {
            if (HP_box.Checked)
            {
                filterBox.Checked = false;
                sobel_box.Checked = false;
                sharpening_box.Checked = false;
                LPF_box.Checked = false;

                CheckboxCheck = true;
            }
        }



        private void filterBox_CheckedChanged(object sender, EventArgs e)
        {
            if(filterBox.Checked)
            {
                HP_box.Checked = false;
                sobel_box.Checked = false;
                sharpening_box.Checked = false;
                LPF_box.Checked = false;

                CheckboxCheck = true;
            }
            else
            {
                search_box.Checked = false;
            }
        }

        

        private void sobel_box_CheckedChanged(object sender, EventArgs e)
        {
            if (sobel_box.Checked)
            {
                HP_box.Checked = false;
                filterBox.Checked = false;
                sharpening_box.Checked = false;
                LPF_box.Checked = false;

                CheckboxCheck = true;
            }

        }

        private void LPF_box_CheckedChanged(object sender, EventArgs e)
        {
            if(LPF_box.Checked)
            {
                sharpening_box.Checked = false;
                filterBox.Checked = false;
                sobel_box.Checked = false;
                HP_box.Checked = false;

                CheckboxCheck = true;
            }
        }

        private void sharpening_box_CheckedChanged(object sender, EventArgs e)
        {
            if(sharpening_box.Checked)
            {
                LPF_box.Checked = false;
                filterBox.Checked = false;
                sobel_box.Checked = false;
                HP_box.Checked = false;

                CheckboxCheck = true;
            }
        }


        private void scale_bar_Scroll(object sender, ScrollEventArgs e)
        {
            Scale_box.Text = scale_bar.Value.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.W)
            {
                front = true;
            }
            else if (e.KeyCode == Keys.A)
            {
                left=true;
            }
            else if (e.KeyCode == Keys.S)
            {
                back = true;
            }
            else if (e.KeyCode == Keys.D)
            {
                right = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                front = false;
            }
            else if (e.KeyCode == Keys.A)
            {
                left = false;
            }
            else if (e.KeyCode == Keys.S)
            {
                back = false;
            }
            else if (e.KeyCode == Keys.D)
            {
                right = false;
            }

            if((right || left || front || back)==false)
            {
                stop_button_Click();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string turn_Speed=speed.Text;

            if(front)
            {
                up_button_Click();
                if (left)
                    turn_Speed = "01";
                else if (right)
                    turn_Speed = "10";
            }
            else if(back)
            {
                down_button_Click();
                if (left)
                    turn_Speed = "01";
                else if (right)
                    turn_Speed = "10";
            }
            else if(left)
            {
                left_button_Click();
            }
            else if(right)
            {
                right_button_Click();
            }
            
            if(front || back || left || right)
            {
                motor_info_text.Text = "00" + turn_Speed + dir_num.Text;
                send_data(motor_info_text.Text);
            }

        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            stop_button_Click();
            Thread.Sleep(100);
            cam_angle_bar.Value = 7;
            Thread.Sleep(100);
            arm_dir_bar.Value = 0;
            Thread.Sleep(100);
            arm_claw_bar.Value = 0;
            Thread.Sleep(100);
        }

        private void search_box_CheckedChanged(object sender, EventArgs e)
        {
            if(filterBox.Checked==false || search_box.Checked==false)
            {
                search_box.Checked = false;
                color_worker.CancelAsync();
                Thread.Sleep(1000);
                stop_button_Click();
                timer1.Interval = 200;
            }
            else if(search_box.Checked==true)
            {
                color_worker.RunWorkerAsync();
                timer1.Interval = 500;
            }
        }

        private void color_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            Image<Hsv, Byte> image;
            LineSegment2D lineX;
            while(worker.CancellationPending==false)
            {
                try
                {

                    image = new Image<Hsv, byte>((Bitmap)Live_Stream.Image.Clone());
                    lineX = object_search(image);
                    image.Draw(lineX, new Hsv(50, 255, 255), 2);
                    process_line(lineX);
                    Snap_box.Image = image.ToBitmap();
                    image.Dispose();
                }
                catch(Exception ex)
                {
                    //MessageBox.Show(ex.Message + "\n" + ex.Data);
                    //worker.CancelAsync();
                }
            }
            right = false;
            left = false;
            front = false;
            back = false;
        }
        private LineSegment2D object_search(Image<Hsv, Byte> img)
        {
            int x, y,cnt=0,xmax=-1,y2=-1,line=0;
            LineSegment2D lineX1;
            for (y = 0; y < img.Height; y++)
            {
                for (x = 0; x < img.Width; x=x+2) 
                {
                   if(x<img.Width-1 && img[y,x].Value!=0)//if the pixel is not black
                   {
                       cnt=cnt+2;
                   }
                   else
                   {
                       if(cnt>line)
                       {
                           xmax = x;
                           line = cnt;
                           y2 = y;
                       }
                       cnt = 0;
                   }
                }

            }
            if(line>0)
            {
                lineX1 = new LineSegment2D(new Point(xmax - line, y2), new Point(xmax, y2));

                //MessageBox.Show(xmax.ToString() + "\n" + y2.ToString());
                //img.Draw(lineX1, new Hsv(50, 255, 255), 2);
            }
            else
            {
                lineX1 = new LineSegment2D(new Point(img.Width / 2, img.Height / 2), new Point(img.Width / 2, img.Height / 2));
            }
            return lineX1;
        }

        private void process_line(LineSegment2D lineX)
        {
            int xCenter;
            xCenter = (lineX.P1.X + lineX.P2.X) / 2;
            if(xCenter<270)//320-50//320 centerX
            {
                front = false;
                back = false;
                right = false;
                left = true;
            }
            else if(xCenter>370)
            {
                front = false;
                back = false;
                left = false;
                right = true;
            }
            else if(lineX.P1.Y<200)//240-40//240 centerY
            {
                back = false;
                right = false;
                left = false;
                front = true;
            }
            else if(lineX.P1.Y>280)
            {
                right = false;
                left = false;
                front = false;
                back = true;
            }
            else
            {
                right = false;
                left = false;
                front = false;
                back = false;
                if (dir_num.Text != "1111")
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        stop_button_Click();
                    }));
                }
            }
        }

        
    }
}



/*
 *  string sourceUrl = "http://10.0.0.1/snapshot.cgi?user=admin&pwd=";

                byte[] buffer = new byte[1280 * 800];
                int read, total = 0;

                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(sourceUrl);
                WebResponse resp;
                try
                {
                    resp = req.GetResponse();
                }
                catch (WebException ex)
                {
                    Socket_status.Text = ex.Message;
                    return;
                }

                Stream stream = resp.GetResponseStream();

                while ((read = stream.Read(buffer, total, 1000)) != 0)
                {
                    total += read;
                }
                Bitmap bmp;
                try
                {
                    bmp = (Bitmap)Bitmap.FromStream(new MemoryStream(buffer, 0, total));
                }
                catch (ArgumentException ex)
                {
                    Socket_status.Text = ex.Message;
                    return;
                }
                //Snap_box.Image = bmp;
 * /




/* try {

                System.Net.Sockets.TcpClient tcpclnt = new System.Net.Sockets.TcpClient();
                Socket_status.Text = "Connecting.....";
                tcpclnt.Connect("10.0.2.12", 80);
                // use the ipaddress as in the server program

                Socket_status.Text+="Connected";
                Console.Write("Enter the string to be transmitted : ");

                String str = Console.ReadLine();
                Stream stm = tcpclnt.GetStream();

                ASCIIEncoding asen = new ASCIIEncoding();
                byte[] ba = asen.GetBytes(str);
                Console.WriteLine("Transmitting.....");

                stm.Write(ba, 0, ba.Length);

                byte[] bb = new byte[100];
                int k = stm.Read(bb, 0, 100);

                for (int i = 0; i < k; i++)
                    Console.Write(Convert.ToChar(bb[i]));

                tcpclnt.Close();
            }

            catch (Exception e) {
                Console.WriteLine("Error..... " + e.StackTrace);
            }*/
