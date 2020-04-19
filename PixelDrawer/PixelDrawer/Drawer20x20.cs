using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelDrawer
{
    public partial class Drawer20x20 : Form
    {
        Color colorDraw = Color.White;

        public Drawer20x20()
        {
            InitializeComponent();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.BackColor = colorDraw;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int button_id = 1;
            ColorFunc(button_id);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int button_id = 2;
            ColorFunc(button_id);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int button_id = 3;
            ColorFunc(button_id);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int button_id = 4;
            ColorFunc(button_id);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int button_id = 5;
            ColorFunc(button_id);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int button_id = 6;
            ColorFunc(button_id);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int button_id = 7;
            ColorFunc(button_id);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int button_id = 8;
            ColorFunc(button_id);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int button_id = 9;
            ColorFunc(button_id);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int button_id = 10;
            ColorFunc(button_id);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int button_id = 11;
            ColorFunc(button_id);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int button_id = 12;
            ColorFunc(button_id);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int button_id = 13;
            ColorFunc(button_id);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int button_id = 14;
            ColorFunc(button_id);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int button_id = 15;
            ColorFunc(button_id);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int button_id = 16;
            ColorFunc(button_id);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int button_id = 17;
            ColorFunc(button_id);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int button_id = 18;
            ColorFunc(button_id);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int button_id = 19;
            ColorFunc(button_id);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int button_id = 20;
            ColorFunc(button_id);
        }

        public void ColorFunc(int button_id)
        {
            Button button = new Button();
            
            switch(button_id)
            {
                case 1:
                    button = button1;
                    break;

                case 2:
                    button = button2;
                    break;

                case 3:
                    button = button3;
                    break;

                case 4:
                    button = button4;
                    break;

                case 5:
                    button = button5;
                    break;

                case 6:
                    button = button6;
                    break;

                case 7:
                    button = button7;
                    break;

                case 8:
                    button = button8;
                    break;

                case 9:
                    button = button9;
                    break;

                case 10:
                    button = button10;
                    break;

                case 11:
                    button = button11;
                    break;

                case 12:
                    button = button12;
                    break;

                case 13:
                    button = button13;
                    break;

                case 14:
                    button = button14;
                    break;

                case 15:
                    button = button15;
                    break;

                case 16:
                    button = button16;
                    break;

                case 17:
                    button = button17;
                    break;

                case 18:
                    button = button18;
                    break;

                case 19:
                    button = button19;
                    break;

                case 20:
                    button = button20;
                    break;

            }

            button21.BackColor = button.BackColor;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            pictureBox1.BackColor = button21.BackColor;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            pictureBox2.BackColor = button21.BackColor;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.BackColor = button21.BackColor;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.BackColor = button21.BackColor;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.BackColor = button21.BackColor;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.BackColor = button21.BackColor;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.BackColor = button21.BackColor;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.BackColor = button21.BackColor;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.BackColor = button21.BackColor;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.BackColor = button21.BackColor;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.BackColor = button21.BackColor;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox12.BackColor = button21.BackColor;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox13.BackColor = button21.BackColor;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox14.BackColor = button21.BackColor;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pictureBox15.BackColor = button21.BackColor;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox16.BackColor = button21.BackColor;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            pictureBox17.BackColor = button21.BackColor;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            pictureBox18.BackColor = button21.BackColor;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            pictureBox19.BackColor = button21.BackColor;
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            pictureBox20.BackColor = button21.BackColor;
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            pictureBox21.BackColor = button21.BackColor;
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            pictureBox22.BackColor = button21.BackColor;
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            pictureBox23.BackColor = button21.BackColor;
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            pictureBox24.BackColor = button21.BackColor;
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            pictureBox25.BackColor = button21.BackColor;
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            pictureBox26.BackColor = button21.BackColor;
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            pictureBox27.BackColor = button21.BackColor;
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            pictureBox28.BackColor = button21.BackColor;
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            pictureBox29.BackColor = button21.BackColor;
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            pictureBox30.BackColor = button21.BackColor;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            pictureBox31.BackColor = button21.BackColor;
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            pictureBox32.BackColor = button21.BackColor;
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            pictureBox33.BackColor = button21.BackColor;
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            pictureBox34.BackColor = button21.BackColor;
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            pictureBox35.BackColor = button21.BackColor;
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            pictureBox36.BackColor = button21.BackColor;
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            pictureBox37.BackColor = button21.BackColor;
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            pictureBox38.BackColor = button21.BackColor;
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            pictureBox39.BackColor = button21.BackColor;
        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {
            pictureBox40.BackColor = button21.BackColor;
        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {
            pictureBox41.BackColor = button21.BackColor;
        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {
            pictureBox42.BackColor = button21.BackColor;
        }

        private void pictureBox43_Click(object sender, EventArgs e)
        {
            pictureBox43.BackColor = button21.BackColor;
        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {
            pictureBox44.BackColor = button21.BackColor;
        }

        private void pictureBox45_Click(object sender, EventArgs e)
        {
            pictureBox45.BackColor = button21.BackColor;
        }

        private void pictureBox46_Click(object sender, EventArgs e)
        {
            pictureBox46.BackColor = button21.BackColor;
        }

        private void pictureBox47_Click(object sender, EventArgs e)
        {
            pictureBox47.BackColor = button21.BackColor;
        }

        private void pictureBox48_Click(object sender, EventArgs e)
        {
            pictureBox48.BackColor = button21.BackColor;
        }

        private void pictureBox49_Click(object sender, EventArgs e)
        {
            pictureBox49.BackColor = button21.BackColor;
        }

        private void pictureBox50_Click(object sender, EventArgs e)
        {
            pictureBox50.BackColor = button21.BackColor;
        }

        private void pictureBox51_Click(object sender, EventArgs e)
        {
            pictureBox51.BackColor = button21.BackColor;
        }

        private void pictureBox52_Click(object sender, EventArgs e)
        {
            pictureBox52.BackColor = button21.BackColor;
        }

        private void pictureBox53_Click(object sender, EventArgs e)
        {
            pictureBox53.BackColor = button21.BackColor;
        }

        private void pictureBox54_Click(object sender, EventArgs e)
        {
            pictureBox54.BackColor = button21.BackColor;
        }

        private void pictureBox55_Click(object sender, EventArgs e)
        {
            pictureBox55.BackColor = button21.BackColor;
        }

        private void pictureBox56_Click(object sender, EventArgs e)
        {
            pictureBox56.BackColor = button21.BackColor;
        }

        private void pictureBox57_Click(object sender, EventArgs e)
        {
            pictureBox57.BackColor = button21.BackColor;
        }

        private void pictureBox58_Click(object sender, EventArgs e)
        {
            pictureBox58.BackColor = button21.BackColor;
        }

        private void pictureBox59_Click(object sender, EventArgs e)
        {
            pictureBox59.BackColor = button21.BackColor;
        }

        private void pictureBox60_Click(object sender, EventArgs e)
        {
            pictureBox60.BackColor = button21.BackColor;
        }

        private void pictureBox61_Click(object sender, EventArgs e)
        {
            pictureBox61.BackColor = button21.BackColor;
        }

        private void pictureBox62_Click(object sender, EventArgs e)
        {
            pictureBox62.BackColor = button21.BackColor;
        }

        private void pictureBox63_Click(object sender, EventArgs e)
        {
            pictureBox63.BackColor = button21.BackColor;
        }

        private void pictureBox64_Click(object sender, EventArgs e)
        {
            pictureBox64.BackColor = button21.BackColor;
        }

        private void pictureBox65_Click(object sender, EventArgs e)
        {
            pictureBox65.BackColor = button21.BackColor;
        }

        private void pictureBox66_Click(object sender, EventArgs e)
        {
            pictureBox66.BackColor = button21.BackColor;
        }

        private void pictureBox67_Click(object sender, EventArgs e)
        {
            pictureBox67.BackColor = button21.BackColor;
        }

        private void pictureBox68_Click(object sender, EventArgs e)
        {
            pictureBox68.BackColor = button21.BackColor;
        }

        private void pictureBox69_Click(object sender, EventArgs e)
        {
            pictureBox69.BackColor = button21.BackColor;
        }

        private void pictureBox70_Click(object sender, EventArgs e)
        {
            pictureBox70.BackColor = button21.BackColor;
        }

        private void pictureBox71_Click(object sender, EventArgs e)
        {
            pictureBox71.BackColor = button21.BackColor;
        }

        private void pictureBox72_Click(object sender, EventArgs e)
        {
            pictureBox72.BackColor = button21.BackColor;
        }

        private void pictureBox73_Click(object sender, EventArgs e)
        {
            pictureBox73.BackColor = button21.BackColor;
        }

        private void pictureBox74_Click(object sender, EventArgs e)
        {
            pictureBox74.BackColor = button21.BackColor;
        }

        private void pictureBox75_Click(object sender, EventArgs e)
        {
            pictureBox75.BackColor = button21.BackColor;
        }

        private void pictureBox76_Click(object sender, EventArgs e)
        {
            pictureBox76.BackColor = button21.BackColor;
        }

        private void pictureBox77_Click(object sender, EventArgs e)
        {
            pictureBox77.BackColor = button21.BackColor;
        }

        private void pictureBox78_Click(object sender, EventArgs e)
        {
            pictureBox78.BackColor = button21.BackColor;
        }

        private void pictureBox79_Click(object sender, EventArgs e)
        {
            pictureBox79.BackColor = button21.BackColor;
        }

        private void pictureBox80_Click(object sender, EventArgs e)
        {
            pictureBox80.BackColor = button21.BackColor;
        }

        private void pictureBox81_Click(object sender, EventArgs e)
        {
            pictureBox81.BackColor = button21.BackColor;
        }

        private void pictureBox82_Click(object sender, EventArgs e)
        {
            pictureBox82.BackColor = button21.BackColor;
        }

        private void pictureBox83_Click(object sender, EventArgs e)
        {
            pictureBox83.BackColor = button21.BackColor;
        }

        private void pictureBox84_Click(object sender, EventArgs e)
        {
            pictureBox84.BackColor = button21.BackColor;
        }

        private void pictureBox85_Click(object sender, EventArgs e)
        {
            pictureBox85.BackColor = button21.BackColor;
        }

        private void pictureBox86_Click(object sender, EventArgs e)
        {
            pictureBox86.BackColor = button21.BackColor;
        }

        private void pictureBox87_Click(object sender, EventArgs e)
        {
            pictureBox87.BackColor = button21.BackColor;
        }

        private void pictureBox88_Click(object sender, EventArgs e)
        {
            pictureBox88.BackColor = button21.BackColor;
        }

        private void pictureBox89_Click(object sender, EventArgs e)
        {
            pictureBox89.BackColor = button21.BackColor;
        }

        private void pictureBox90_Click(object sender, EventArgs e)
        {
            pictureBox90.BackColor = button21.BackColor;
        }

        private void pictureBox91_Click(object sender, EventArgs e)
        {
            pictureBox91.BackColor = button21.BackColor;
        }

        private void pictureBox92_Click(object sender, EventArgs e)
        {
            pictureBox92.BackColor = button21.BackColor;
        }

        private void pictureBox93_Click(object sender, EventArgs e)
        {
            pictureBox93.BackColor = button21.BackColor;
        }

        private void pictureBox94_Click(object sender, EventArgs e)
        {
            pictureBox94.BackColor = button21.BackColor;
        }

        private void pictureBox95_Click(object sender, EventArgs e)
        {
            pictureBox95.BackColor = button21.BackColor;
        }

        private void pictureBox96_Click(object sender, EventArgs e)
        {
            pictureBox96.BackColor = button21.BackColor;
        }

        private void pictureBox97_Click(object sender, EventArgs e)
        {
            pictureBox97.BackColor = button21.BackColor;
        }

        private void pictureBox98_Click(object sender, EventArgs e)
        {
            pictureBox98.BackColor = button21.BackColor;
        }

        private void pictureBox99_Click(object sender, EventArgs e)
        {
            pictureBox99.BackColor = button21.BackColor;
        }

        private void pictureBox100_Click(object sender, EventArgs e)
        {
            pictureBox100.BackColor = button21.BackColor;
        }

        private void pictureBox101_Click(object sender, EventArgs e)
        {
            pictureBox101.BackColor = button21.BackColor;
        }

        private void pictureBox102_Click(object sender, EventArgs e)
        {
            pictureBox102.BackColor = button21.BackColor;
        }

        private void pictureBox103_Click(object sender, EventArgs e)
        {
            pictureBox103.BackColor = button21.BackColor;
        }

        private void pictureBox104_Click(object sender, EventArgs e)
        {
            pictureBox104.BackColor = button21.BackColor;
        }

        private void pictureBox105_Click(object sender, EventArgs e)
        {
            pictureBox105.BackColor = button21.BackColor;
        }

        private void pictureBox106_Click(object sender, EventArgs e)
        {
            pictureBox106.BackColor = button21.BackColor;
        }

        private void pictureBox107_Click(object sender, EventArgs e)
        {
            pictureBox107.BackColor = button21.BackColor;
        }

        private void pictureBox108_Click(object sender, EventArgs e)
        {
            pictureBox108.BackColor = button21.BackColor;
        }

        private void pictureBox109_Click(object sender, EventArgs e)
        {
            pictureBox109.BackColor = button21.BackColor;
        }

        private void pictureBox110_Click(object sender, EventArgs e)
        {
            pictureBox110.BackColor = button21.BackColor;
        }

        private void pictureBox111_Click(object sender, EventArgs e)
        {
            pictureBox111.BackColor = button21.BackColor;
        }

        private void pictureBox112_Click(object sender, EventArgs e)
        {
            pictureBox112.BackColor = button21.BackColor;
        }

        private void pictureBox113_Click(object sender, EventArgs e)
        {
            pictureBox113.BackColor = button21.BackColor;
        }

        private void pictureBox114_Click(object sender, EventArgs e)
        {
            pictureBox114.BackColor = button21.BackColor;
        }

        private void pictureBox115_Click(object sender, EventArgs e)
        {
            pictureBox115.BackColor = button21.BackColor;
        }

        private void pictureBox116_Click(object sender, EventArgs e)
        {
            pictureBox116.BackColor = button21.BackColor;
        }

        private void pictureBox117_Click(object sender, EventArgs e)
        {
            pictureBox117.BackColor = button21.BackColor;
        }

        private void pictureBox118_Click(object sender, EventArgs e)
        {
            pictureBox118.BackColor = button21.BackColor;
        }

        private void pictureBox119_Click(object sender, EventArgs e)
        {
            pictureBox119.BackColor = button21.BackColor;
        }

        private void pictureBox120_Click(object sender, EventArgs e)
        {
            pictureBox120.BackColor = button21.BackColor;
        }

        private void pictureBox121_Click(object sender, EventArgs e)
        {
            pictureBox121.BackColor = button21.BackColor;
        }

        private void pictureBox122_Click(object sender, EventArgs e)
        {
            pictureBox122.BackColor = button21.BackColor;
        }

        private void pictureBox123_Click(object sender, EventArgs e)
        {
            pictureBox123.BackColor = button21.BackColor;
        }

        private void pictureBox124_Click(object sender, EventArgs e)
        {
            pictureBox124.BackColor = button21.BackColor;
        }

        private void pictureBox125_Click(object sender, EventArgs e)
        {
            pictureBox125.BackColor = button21.BackColor;
        }

        private void pictureBox126_Click(object sender, EventArgs e)
        {
            pictureBox126.BackColor = button21.BackColor;
        }

        private void pictureBox127_Click(object sender, EventArgs e)
        {
            pictureBox127.BackColor = button21.BackColor;
        }

        private void pictureBox128_Click(object sender, EventArgs e)
        {
            pictureBox128.BackColor = button21.BackColor;
        }

        private void pictureBox129_Click(object sender, EventArgs e)
        {
            pictureBox129.BackColor = button21.BackColor;
        }

        private void pictureBox130_Click(object sender, EventArgs e)
        {
            pictureBox130.BackColor = button21.BackColor;
        }

        private void pictureBox131_Click(object sender, EventArgs e)
        {
            pictureBox131.BackColor = button21.BackColor;
        }

        private void pictureBox132_Click(object sender, EventArgs e)
        {
            pictureBox132.BackColor = button21.BackColor;
        }

        private void pictureBox133_Click(object sender, EventArgs e)
        {
            pictureBox133.BackColor = button21.BackColor;
        }

        private void pictureBox134_Click(object sender, EventArgs e)
        {
            pictureBox134.BackColor = button21.BackColor;
        }

        private void pictureBox135_Click(object sender, EventArgs e)
        {
            pictureBox135.BackColor = button21.BackColor;
        }

        private void pictureBox136_Click(object sender, EventArgs e)
        {
            pictureBox136.BackColor = button21.BackColor;
        }

        private void pictureBox137_Click(object sender, EventArgs e)
        {
            pictureBox137.BackColor = button21.BackColor;
        }

        private void pictureBox138_Click(object sender, EventArgs e)
        {
            pictureBox138.BackColor = button21.BackColor;
        }

        private void pictureBox139_Click(object sender, EventArgs e)
        {
            pictureBox139.BackColor = button21.BackColor;
        }

        private void pictureBox140_Click(object sender, EventArgs e)
        {
            pictureBox140.BackColor = button21.BackColor;
        }

        private void pictureBox141_Click(object sender, EventArgs e)
        {
            pictureBox141.BackColor = button21.BackColor;
        }

        private void pictureBox142_Click(object sender, EventArgs e)
        {
            pictureBox142.BackColor = button21.BackColor;
        }

        private void pictureBox143_Click(object sender, EventArgs e)
        {
            pictureBox143.BackColor = button21.BackColor;
        }

        private void pictureBox144_Click(object sender, EventArgs e)
        {
            pictureBox144.BackColor = button21.BackColor;
        }

        private void pictureBox145_Click(object sender, EventArgs e)
        {
            pictureBox145.BackColor = button21.BackColor;
        }

        private void pictureBox146_Click(object sender, EventArgs e)
        {
            pictureBox146.BackColor = button21.BackColor;
        }

        private void pictureBox147_Click(object sender, EventArgs e)
        {
            pictureBox147.BackColor = button21.BackColor;
        }

        private void pictureBox148_Click(object sender, EventArgs e)
        {
            pictureBox148.BackColor = button21.BackColor;
        }

        private void pictureBox149_Click(object sender, EventArgs e)
        {
            pictureBox149.BackColor = button21.BackColor;
        }

        private void pictureBox150_Click(object sender, EventArgs e)
        {
            pictureBox150.BackColor = button21.BackColor;
        }

        private void pictureBox151_Click(object sender, EventArgs e)
        {
            pictureBox151.BackColor = button21.BackColor;
        }

        private void pictureBox152_Click(object sender, EventArgs e)
        {
            pictureBox152.BackColor = button21.BackColor;
        }

        private void pictureBox153_Click(object sender, EventArgs e)
        {
            pictureBox153.BackColor = button21.BackColor;
        }

        private void pictureBox154_Click(object sender, EventArgs e)
        {
            pictureBox154.BackColor = button21.BackColor;
        }

        private void pictureBox155_Click(object sender, EventArgs e)
        {
            pictureBox155.BackColor = button21.BackColor;
        }

        private void pictureBox156_Click(object sender, EventArgs e)
        {
            pictureBox156.BackColor = button21.BackColor;
        }

        private void pictureBox157_Click(object sender, EventArgs e)
        {
            pictureBox157.BackColor = button21.BackColor;
        }

        private void pictureBox158_Click(object sender, EventArgs e)
        {
            pictureBox158.BackColor = button21.BackColor;
        }

        private void pictureBox159_Click(object sender, EventArgs e)
        {
            pictureBox159.BackColor = button21.BackColor;
        }

        private void pictureBox160_Click(object sender, EventArgs e)
        {
            pictureBox160.BackColor = button21.BackColor;
        }

        private void pictureBox161_Click(object sender, EventArgs e)
        {
            pictureBox161.BackColor = button21.BackColor;
        }

        private void pictureBox162_Click(object sender, EventArgs e)
        {
            pictureBox162.BackColor = button21.BackColor;
        }

        private void pictureBox163_Click(object sender, EventArgs e)
        {
            pictureBox163.BackColor = button21.BackColor;
        }

        private void pictureBox164_Click(object sender, EventArgs e)
        {
            pictureBox164.BackColor = button21.BackColor;
        }

        private void pictureBox165_Click(object sender, EventArgs e)
        {
            pictureBox165.BackColor = button21.BackColor;
        }

        private void pictureBox166_Click(object sender, EventArgs e)
        {
            pictureBox166.BackColor = button21.BackColor;
        }

        private void pictureBox167_Click(object sender, EventArgs e)
        {
            pictureBox167.BackColor = button21.BackColor;
        }

        private void pictureBox168_Click(object sender, EventArgs e)
        {
            pictureBox168.BackColor = button21.BackColor;
        }

        private void pictureBox169_Click(object sender, EventArgs e)
        {
            pictureBox169.BackColor = button21.BackColor;
        }

        private void pictureBox170_Click(object sender, EventArgs e)
        {
            pictureBox170.BackColor = button21.BackColor;
        }

        private void pictureBox171_Click(object sender, EventArgs e)
        {
            pictureBox171.BackColor = button21.BackColor;
        }

        private void pictureBox172_Click(object sender, EventArgs e)
        {
            pictureBox172.BackColor = button21.BackColor;
        }

        private void pictureBox173_Click(object sender, EventArgs e)
        {
            pictureBox173.BackColor = button21.BackColor;
        }

        private void pictureBox174_Click(object sender, EventArgs e)
        {
            pictureBox174.BackColor = button21.BackColor;
        }

        private void pictureBox175_Click(object sender, EventArgs e)
        {
            pictureBox175.BackColor = button21.BackColor;
        }

        private void pictureBox176_Click(object sender, EventArgs e)
        {
            pictureBox176.BackColor = button21.BackColor;
        }

        private void pictureBox177_Click(object sender, EventArgs e)
        {
            pictureBox177.BackColor = button21.BackColor;
        }

        private void pictureBox178_Click(object sender, EventArgs e)
        {
            pictureBox178.BackColor = button21.BackColor;
        }

        private void pictureBox179_Click(object sender, EventArgs e)
        {
            pictureBox179.BackColor = button21.BackColor;
        }

        private void pictureBox180_Click(object sender, EventArgs e)
        {
            pictureBox180.BackColor = button21.BackColor;
        }

        private void pictureBox181_Click(object sender, EventArgs e)
        {
            pictureBox181.BackColor = button21.BackColor;
        }

        private void pictureBox182_Click(object sender, EventArgs e)
        {
            pictureBox182.BackColor = button21.BackColor;
        }

        private void pictureBox183_Click(object sender, EventArgs e)
        {
            pictureBox183.BackColor = button21.BackColor;
        }

        private void pictureBox184_Click(object sender, EventArgs e)
        {
            pictureBox184.BackColor = button21.BackColor;
        }

        private void pictureBox185_Click(object sender, EventArgs e)
        {
            pictureBox185.BackColor = button21.BackColor;
        }

        private void pictureBox186_Click(object sender, EventArgs e)
        {
            pictureBox186.BackColor = button21.BackColor;
        }

        private void pictureBox187_Click(object sender, EventArgs e)
        {
            pictureBox187.BackColor = button21.BackColor;
        }

        private void pictureBox188_Click(object sender, EventArgs e)
        {
            pictureBox188.BackColor = button21.BackColor;
        }

        private void pictureBox189_Click(object sender, EventArgs e)
        {
            pictureBox189.BackColor = button21.BackColor;
        }

        private void pictureBox190_Click(object sender, EventArgs e)
        {
            pictureBox190.BackColor = button21.BackColor;
        }

        private void pictureBox191_Click(object sender, EventArgs e)
        {
            pictureBox191.BackColor = button21.BackColor;
        }

        private void pictureBox192_Click(object sender, EventArgs e)
        {
            pictureBox192.BackColor = button21.BackColor;
        }

        private void pictureBox193_Click(object sender, EventArgs e)
        {
            pictureBox193.BackColor = button21.BackColor;
        }

        private void pictureBox194_Click(object sender, EventArgs e)
        {
            pictureBox194.BackColor = button21.BackColor;
        }

        private void pictureBox195_Click(object sender, EventArgs e)
        {
            pictureBox195.BackColor = button21.BackColor;
        }

        private void pictureBox196_Click(object sender, EventArgs e)
        {
            pictureBox196.BackColor = button21.BackColor;
        }

        private void pictureBox197_Click(object sender, EventArgs e)
        {
            pictureBox197.BackColor = button21.BackColor;
        }

        private void pictureBox198_Click(object sender, EventArgs e)
        {
            pictureBox198.BackColor = button21.BackColor;
        }

        private void pictureBox199_Click(object sender, EventArgs e)
        {
            pictureBox199.BackColor = button21.BackColor;
        }

        private void pictureBox200_Click(object sender, EventArgs e)
        {
            pictureBox200.BackColor = button21.BackColor;
        }

        private void pictureBox201_Click(object sender, EventArgs e)
        {
            pictureBox201.BackColor = button21.BackColor;
        }

        private void pictureBox202_Click(object sender, EventArgs e)
        {
            pictureBox202.BackColor = button21.BackColor;
        }

        private void pictureBox203_Click(object sender, EventArgs e)
        {
            pictureBox203.BackColor = button21.BackColor;
        }

        private void pictureBox204_Click(object sender, EventArgs e)
        {
            pictureBox204.BackColor = button21.BackColor;
        }

        private void pictureBox205_Click(object sender, EventArgs e)
        {
            pictureBox205.BackColor = button21.BackColor;
        }

        private void pictureBox206_Click(object sender, EventArgs e)
        {
            pictureBox206.BackColor = button21.BackColor;
        }

        private void pictureBox207_Click(object sender, EventArgs e)
        {
            pictureBox207.BackColor = button21.BackColor;
        }

        private void pictureBox208_Click(object sender, EventArgs e)
        {
            pictureBox208.BackColor = button21.BackColor;
        }

        private void pictureBox209_Click(object sender, EventArgs e)
        {
            pictureBox209.BackColor = button21.BackColor;
        }

        private void pictureBox210_Click(object sender, EventArgs e)
        {
            pictureBox210.BackColor = button21.BackColor;
        }

        private void pictureBox211_Click(object sender, EventArgs e)
        {
            pictureBox211.BackColor = button21.BackColor;
        }

        private void pictureBox212_Click(object sender, EventArgs e)
        {
            pictureBox212.BackColor = button21.BackColor;
        }

        private void pictureBox213_Click(object sender, EventArgs e)
        {
            pictureBox213.BackColor = button21.BackColor;
        }

        private void pictureBox214_Click(object sender, EventArgs e)
        {
            pictureBox214.BackColor = button21.BackColor;
        }

        private void pictureBox215_Click(object sender, EventArgs e)
        {
            pictureBox215.BackColor = button21.BackColor;
        }

        private void pictureBox216_Click(object sender, EventArgs e)
        {
            pictureBox216.BackColor = button21.BackColor;
        }

        private void pictureBox217_Click(object sender, EventArgs e)
        {
            pictureBox217.BackColor = button21.BackColor;
        }

        private void pictureBox218_Click(object sender, EventArgs e)
        {
            pictureBox218.BackColor = button21.BackColor;
        }

        private void pictureBox219_Click(object sender, EventArgs e)
        {
            pictureBox219.BackColor = button21.BackColor;
        }

        private void pictureBox220_Click(object sender, EventArgs e)
        {
            pictureBox220.BackColor = button21.BackColor;
        }

        private void pictureBox221_Click(object sender, EventArgs e)
        {
            pictureBox221.BackColor = button21.BackColor;
        }

        private void pictureBox222_Click(object sender, EventArgs e)
        {
            pictureBox222.BackColor = button21.BackColor;
        }

        private void pictureBox223_Click(object sender, EventArgs e)
        {
            pictureBox223.BackColor = button21.BackColor;
        }

        private void pictureBox224_Click(object sender, EventArgs e)
        {
            pictureBox224.BackColor = button21.BackColor;
        }

        private void pictureBox225_Click(object sender, EventArgs e)
        {
            pictureBox225.BackColor = button21.BackColor;
        }

        private void pictureBox226_Click(object sender, EventArgs e)
        {
            pictureBox226.BackColor = button21.BackColor;
        }

        private void pictureBox227_Click(object sender, EventArgs e)
        {
            pictureBox227.BackColor = button21.BackColor;
        }

        private void pictureBox228_Click(object sender, EventArgs e)
        {
            pictureBox228.BackColor = button21.BackColor;
        }

        private void pictureBox229_Click(object sender, EventArgs e)
        {
            pictureBox229.BackColor = button21.BackColor;
        }

        private void pictureBox230_Click(object sender, EventArgs e)
        {
            pictureBox230.BackColor = button21.BackColor;
        }

        private void pictureBox231_Click(object sender, EventArgs e)
        {
            pictureBox231.BackColor = button21.BackColor;
        }

        private void pictureBox232_Click(object sender, EventArgs e)
        {
            pictureBox232.BackColor = button21.BackColor;
        }

        private void pictureBox233_Click(object sender, EventArgs e)
        {
            pictureBox233.BackColor = button21.BackColor;
        }

        private void pictureBox234_Click(object sender, EventArgs e)
        {
            pictureBox234.BackColor = button21.BackColor;
        }

        private void pictureBox235_Click(object sender, EventArgs e)
        {
            pictureBox235.BackColor = button21.BackColor;
        }

        private void pictureBox236_Click(object sender, EventArgs e)
        {
            pictureBox236.BackColor = button21.BackColor;
        }

        private void pictureBox237_Click(object sender, EventArgs e)
        {
            pictureBox237.BackColor = button21.BackColor;
        }

        private void pictureBox238_Click(object sender, EventArgs e)
        {
            pictureBox238.BackColor = button21.BackColor;
        }

        private void pictureBox239_Click(object sender, EventArgs e)
        {
            pictureBox239.BackColor = button21.BackColor;
        }

        private void pictureBox240_Click(object sender, EventArgs e)
        {
            pictureBox240.BackColor = button21.BackColor;
        }

        private void pictureBox241_Click(object sender, EventArgs e)
        {
            pictureBox241.BackColor = button21.BackColor;
        }

        private void pictureBox242_Click(object sender, EventArgs e)
        {
            pictureBox242.BackColor = button21.BackColor;
        }

        private void pictureBox243_Click(object sender, EventArgs e)
        {
            pictureBox243.BackColor = button21.BackColor;
        }

        private void pictureBox244_Click(object sender, EventArgs e)
        {
            pictureBox244.BackColor = button21.BackColor;
        }

        private void pictureBox245_Click(object sender, EventArgs e)
        {
            pictureBox245.BackColor = button21.BackColor;
        }

        private void pictureBox246_Click(object sender, EventArgs e)
        {
            pictureBox246.BackColor = button21.BackColor;
        }

        private void pictureBox247_Click(object sender, EventArgs e)
        {
            pictureBox247.BackColor = button21.BackColor;
        }

        private void pictureBox248_Click(object sender, EventArgs e)
        {
            pictureBox248.BackColor = button21.BackColor;
        }

        private void pictureBox249_Click(object sender, EventArgs e)
        {
            pictureBox249.BackColor = button21.BackColor;
        }

        private void pictureBox250_Click(object sender, EventArgs e)
        {
            pictureBox250.BackColor = button21.BackColor;
        }

        private void pictureBox251_Click(object sender, EventArgs e)
        {
            pictureBox251.BackColor = button21.BackColor;
        }

        private void pictureBox252_Click(object sender, EventArgs e)
        {
            pictureBox252.BackColor = button21.BackColor;
        }

        private void pictureBox253_Click(object sender, EventArgs e)
        {
            pictureBox253.BackColor = button21.BackColor;
        }

        private void pictureBox254_Click(object sender, EventArgs e)
        {
            pictureBox254.BackColor = button21.BackColor;
        }

        private void pictureBox255_Click(object sender, EventArgs e)
        {
            pictureBox255.BackColor = button21.BackColor;
        }

        private void pictureBox256_Click(object sender, EventArgs e)
        {
            pictureBox256.BackColor = button21.BackColor;
        }

        private void pictureBox257_Click(object sender, EventArgs e)
        {
            pictureBox257.BackColor = button21.BackColor;
        }

        private void pictureBox258_Click(object sender, EventArgs e)
        {
            pictureBox258.BackColor = button21.BackColor;
        }

        private void pictureBox259_Click(object sender, EventArgs e)
        {
            pictureBox259.BackColor = button21.BackColor;
        }

        private void pictureBox260_Click(object sender, EventArgs e)
        {
            pictureBox260.BackColor = button21.BackColor;
        }

        private void pictureBox261_Click(object sender, EventArgs e)
        {
            pictureBox261.BackColor = button21.BackColor;
        }

        private void pictureBox262_Click(object sender, EventArgs e)
        {
            pictureBox262.BackColor = button21.BackColor;
        }

        private void pictureBox263_Click(object sender, EventArgs e)
        {
            pictureBox263.BackColor = button21.BackColor;
        }

        private void pictureBox264_Click(object sender, EventArgs e)
        {
            pictureBox264.BackColor = button21.BackColor;
        }

        private void pictureBox265_Click(object sender, EventArgs e)
        {
            pictureBox265.BackColor = button21.BackColor;
        }

        private void pictureBox266_Click(object sender, EventArgs e)
        {
            pictureBox266.BackColor = button21.BackColor;
        }

        private void pictureBox267_Click(object sender, EventArgs e)
        {
            pictureBox267.BackColor = button21.BackColor;
        }

        private void pictureBox268_Click(object sender, EventArgs e)
        {
            pictureBox268.BackColor = button21.BackColor;
        }

        private void pictureBox269_Click(object sender, EventArgs e)
        {
            pictureBox269.BackColor = button21.BackColor;
        }

        private void pictureBox270_Click(object sender, EventArgs e)
        {
            pictureBox270.BackColor = button21.BackColor;
        }

        private void pictureBox271_Click(object sender, EventArgs e)
        {
            pictureBox271.BackColor = button21.BackColor;
        }

        private void pictureBox272_Click(object sender, EventArgs e)
        {
            pictureBox272.BackColor = button21.BackColor;
        }

        private void pictureBox273_Click(object sender, EventArgs e)
        {
            pictureBox273.BackColor = button21.BackColor;
        }

        private void pictureBox274_Click(object sender, EventArgs e)
        {
            pictureBox274.BackColor = button21.BackColor;
        }

        private void pictureBox275_Click(object sender, EventArgs e)
        {
            pictureBox275.BackColor = button21.BackColor;
        }

        private void pictureBox276_Click(object sender, EventArgs e)
        {
            pictureBox276.BackColor = button21.BackColor;
        }

        private void pictureBox277_Click(object sender, EventArgs e)
        {
            pictureBox277.BackColor = button21.BackColor;
        }

        private void pictureBox278_Click(object sender, EventArgs e)
        {
            pictureBox278.BackColor = button21.BackColor;
        }

        private void pictureBox279_Click(object sender, EventArgs e)
        {
            pictureBox279.BackColor = button21.BackColor;
        }

        private void pictureBox280_Click(object sender, EventArgs e)
        {
            pictureBox280.BackColor = button21.BackColor;
        }

        private void pictureBox281_Click(object sender, EventArgs e)
        {
            pictureBox281.BackColor = button21.BackColor;
        }

        private void pictureBox282_Click(object sender, EventArgs e)
        {
            pictureBox282.BackColor = button21.BackColor;
        }

        private void pictureBox283_Click(object sender, EventArgs e)
        {
            pictureBox283.BackColor = button21.BackColor;
        }

        private void pictureBox284_Click(object sender, EventArgs e)
        {
            pictureBox284.BackColor = button21.BackColor;
        }

        private void pictureBox285_Click(object sender, EventArgs e)
        {
            pictureBox285.BackColor = button21.BackColor;
        }

        private void pictureBox286_Click(object sender, EventArgs e)
        {
            pictureBox286.BackColor = button21.BackColor;
        }

        private void pictureBox287_Click(object sender, EventArgs e)
        {
            pictureBox287.BackColor = button21.BackColor;
        }

        private void pictureBox288_Click(object sender, EventArgs e)
        {
            pictureBox288.BackColor = button21.BackColor;
        }

        private void pictureBox289_Click(object sender, EventArgs e)
        {
            pictureBox289.BackColor = button21.BackColor;
        }

        private void pictureBox290_Click(object sender, EventArgs e)
        {
            pictureBox290.BackColor = button21.BackColor;
        }

        private void pictureBox291_Click(object sender, EventArgs e)
        {
            pictureBox291.BackColor = button21.BackColor;
        }

        private void pictureBox292_Click(object sender, EventArgs e)
        {
            pictureBox292.BackColor = button21.BackColor;
        }

        private void pictureBox293_Click(object sender, EventArgs e)
        {
            pictureBox293.BackColor = button21.BackColor;
        }

        private void pictureBox294_Click(object sender, EventArgs e)
        {
            pictureBox294.BackColor = button21.BackColor;
        }

        private void pictureBox295_Click(object sender, EventArgs e)
        {
            pictureBox295.BackColor = button21.BackColor;
        }

        private void pictureBox296_Click(object sender, EventArgs e)
        {
            pictureBox296.BackColor = button21.BackColor;
        }

        private void pictureBox297_Click(object sender, EventArgs e)
        {
            pictureBox297.BackColor = button21.BackColor;
        }

        private void pictureBox298_Click(object sender, EventArgs e)
        {
            pictureBox298.BackColor = button21.BackColor;
        }

        private void pictureBox299_Click(object sender, EventArgs e)
        {
            pictureBox299.BackColor = button21.BackColor;
        }

        private void pictureBox300_Click(object sender, EventArgs e)
        {
            pictureBox300.BackColor = button21.BackColor;
        }

        private void pictureBox301_Click(object sender, EventArgs e)
        {
            pictureBox301.BackColor = button21.BackColor;
        }

        private void pictureBox302_Click(object sender, EventArgs e)
        {
            pictureBox302.BackColor = button21.BackColor;
        }

        private void pictureBox303_Click(object sender, EventArgs e)
        {
            pictureBox303.BackColor = button21.BackColor;
        }

        private void pictureBox304_Click(object sender, EventArgs e)
        {
            pictureBox304.BackColor = button21.BackColor;
        }

        private void pictureBox305_Click(object sender, EventArgs e)
        {
            pictureBox305.BackColor = button21.BackColor;
        }

        private void pictureBox306_Click(object sender, EventArgs e)
        {
            pictureBox306.BackColor = button21.BackColor;
        }

        private void pictureBox307_Click(object sender, EventArgs e)
        {
            pictureBox307.BackColor = button21.BackColor;
        }

        private void pictureBox308_Click(object sender, EventArgs e)
        {
            pictureBox308.BackColor = button21.BackColor;
        }

        private void pictureBox309_Click(object sender, EventArgs e)
        {
            pictureBox309.BackColor = button21.BackColor;
        }

        private void pictureBox310_Click(object sender, EventArgs e)
        {
            pictureBox310.BackColor = button21.BackColor;
        }

        private void pictureBox311_Click(object sender, EventArgs e)
        {
            pictureBox311.BackColor = button21.BackColor;
        }

        private void pictureBox312_Click(object sender, EventArgs e)
        {
            pictureBox312.BackColor = button21.BackColor;
        }

        private void pictureBox313_Click(object sender, EventArgs e)
        {
            pictureBox313.BackColor = button21.BackColor;
        }

        private void pictureBox314_Click(object sender, EventArgs e)
        {
            pictureBox314.BackColor = button21.BackColor;
        }

        private void pictureBox315_Click(object sender, EventArgs e)
        {
            pictureBox315.BackColor = button21.BackColor;
        }

        private void pictureBox316_Click(object sender, EventArgs e)
        {
            pictureBox316.BackColor = button21.BackColor;
        }

        private void pictureBox317_Click(object sender, EventArgs e)
        {
            pictureBox317.BackColor = button21.BackColor;
        }

        private void pictureBox318_Click(object sender, EventArgs e)
        {
            pictureBox318.BackColor = button21.BackColor;
        }

        private void pictureBox319_Click(object sender, EventArgs e)
        {
            pictureBox319.BackColor = button21.BackColor;
        }

        private void pictureBox320_Click(object sender, EventArgs e)
        {
            pictureBox320.BackColor = button21.BackColor;
        }

        private void pictureBox321_Click(object sender, EventArgs e)
        {
            pictureBox321.BackColor = button21.BackColor;
        }

        private void pictureBox322_Click(object sender, EventArgs e)
        {
            pictureBox322.BackColor = button21.BackColor;
        }

        private void pictureBox323_Click(object sender, EventArgs e)
        {
            pictureBox323.BackColor = button21.BackColor;
        }

        private void pictureBox324_Click(object sender, EventArgs e)
        {
            pictureBox324.BackColor = button21.BackColor;
        }

        private void pictureBox325_Click(object sender, EventArgs e)
        {
            pictureBox325.BackColor = button21.BackColor;
        }

        private void pictureBox326_Click(object sender, EventArgs e)
        {
            pictureBox326.BackColor = button21.BackColor;
        }

        private void pictureBox327_Click(object sender, EventArgs e)
        {
            pictureBox327.BackColor = button21.BackColor;
        }

        private void pictureBox328_Click(object sender, EventArgs e)
        {
            pictureBox328.BackColor = button21.BackColor;
        }

        private void pictureBox329_Click(object sender, EventArgs e)
        {
            pictureBox329.BackColor = button21.BackColor;
        }

        private void pictureBox330_Click(object sender, EventArgs e)
        {
            pictureBox330.BackColor = button21.BackColor;
        }

        private void pictureBox331_Click(object sender, EventArgs e)
        {
            pictureBox331.BackColor = button21.BackColor;
        }

        private void pictureBox332_Click(object sender, EventArgs e)
        {
            pictureBox332.BackColor = button21.BackColor;
        }

        private void pictureBox333_Click(object sender, EventArgs e)
        {
            pictureBox333.BackColor = button21.BackColor;
        }

        private void pictureBox334_Click(object sender, EventArgs e)
        {
            pictureBox334.BackColor = button21.BackColor;
        }

        private void pictureBox335_Click(object sender, EventArgs e)
        {
            pictureBox335.BackColor = button21.BackColor;
        }

        private void pictureBox336_Click(object sender, EventArgs e)
        {
            pictureBox336.BackColor = button21.BackColor;
        }

        private void pictureBox337_Click(object sender, EventArgs e)
        {
            pictureBox337.BackColor = button21.BackColor;
        }

        private void pictureBox338_Click(object sender, EventArgs e)
        {
            pictureBox338.BackColor = button21.BackColor;
        }

        private void pictureBox339_Click(object sender, EventArgs e)
        {
            pictureBox339.BackColor = button21.BackColor;
        }

        private void pictureBox340_Click(object sender, EventArgs e)
        {
            pictureBox340.BackColor = button21.BackColor;
        }

        private void pictureBox341_Click(object sender, EventArgs e)
        {
            pictureBox341.BackColor = button21.BackColor;
        }

        private void pictureBox342_Click(object sender, EventArgs e)
        {
            pictureBox342.BackColor = button21.BackColor;
        }

        private void pictureBox343_Click(object sender, EventArgs e)
        {
            pictureBox343.BackColor = button21.BackColor;
        }

        private void pictureBox344_Click(object sender, EventArgs e)
        {
            pictureBox344.BackColor = button21.BackColor;
        }

        private void pictureBox345_Click(object sender, EventArgs e)
        {
            pictureBox345.BackColor = button21.BackColor;
        }

        private void pictureBox346_Click(object sender, EventArgs e)
        {
            pictureBox346.BackColor = button21.BackColor;
        }

        private void pictureBox347_Click(object sender, EventArgs e)
        {
            pictureBox347.BackColor = button21.BackColor;
        }

        private void pictureBox348_Click(object sender, EventArgs e)
        {
            pictureBox348.BackColor = button21.BackColor;
        }

        private void pictureBox349_Click(object sender, EventArgs e)
        {
            pictureBox349.BackColor = button21.BackColor;
        }

        private void pictureBox350_Click(object sender, EventArgs e)
        {
            pictureBox350.BackColor = button21.BackColor;
        }

        private void pictureBox351_Click(object sender, EventArgs e)
        {
            pictureBox351.BackColor = button21.BackColor;
        }

        private void pictureBox352_Click(object sender, EventArgs e)
        {
            pictureBox352.BackColor = button21.BackColor;
        }

        private void pictureBox353_Click(object sender, EventArgs e)
        {
            pictureBox353.BackColor = button21.BackColor;
        }

        private void pictureBox354_Click(object sender, EventArgs e)
        {
            pictureBox354.BackColor = button21.BackColor;
        }

        private void pictureBox355_Click(object sender, EventArgs e)
        {
            pictureBox355.BackColor = button21.BackColor;
        }

        private void pictureBox356_Click(object sender, EventArgs e)
        {
            pictureBox356.BackColor = button21.BackColor;
        }

        private void pictureBox357_Click(object sender, EventArgs e)
        {
            pictureBox357.BackColor = button21.BackColor;
        }

        private void pictureBox358_Click(object sender, EventArgs e)
        {
            pictureBox358.BackColor = button21.BackColor;
        }

        private void pictureBox359_Click(object sender, EventArgs e)
        {
            pictureBox359.BackColor = button21.BackColor;
        }

        private void pictureBox360_Click(object sender, EventArgs e)
        {
            pictureBox360.BackColor = button21.BackColor;
        }

        private void pictureBox361_Click(object sender, EventArgs e)
        {
            pictureBox361.BackColor = button21.BackColor;
        }

        private void pictureBox362_Click(object sender, EventArgs e)
        {
            pictureBox362.BackColor = button21.BackColor;
        }

        private void pictureBox363_Click(object sender, EventArgs e)
        {
            pictureBox363.BackColor = button21.BackColor;
        }

        private void pictureBox364_Click(object sender, EventArgs e)
        {
            pictureBox364.BackColor = button21.BackColor;
        }

        private void pictureBox365_Click(object sender, EventArgs e)
        {
            pictureBox365.BackColor = button21.BackColor;
        }

        private void pictureBox366_Click(object sender, EventArgs e)
        {
            pictureBox366.BackColor = button21.BackColor;
        }

        private void pictureBox367_Click(object sender, EventArgs e)
        {
            pictureBox367.BackColor = button21.BackColor;
        }

        private void pictureBox368_Click(object sender, EventArgs e)
        {
            pictureBox368.BackColor = button21.BackColor;
        }

        private void pictureBox369_Click(object sender, EventArgs e)
        {
            pictureBox369.BackColor = button21.BackColor;
        }

        private void pictureBox370_Click(object sender, EventArgs e)
        {
            pictureBox370.BackColor = button21.BackColor;
        }

        private void pictureBox371_Click(object sender, EventArgs e)
        {
            pictureBox371.BackColor = button21.BackColor;
        }

        private void pictureBox372_Click(object sender, EventArgs e)
        {
            pictureBox372.BackColor = button21.BackColor;
        }

        private void pictureBox373_Click(object sender, EventArgs e)
        {
            pictureBox373.BackColor = button21.BackColor;
        }

        private void pictureBox374_Click(object sender, EventArgs e)
        {
            pictureBox374.BackColor = button21.BackColor;
        }

        private void pictureBox375_Click(object sender, EventArgs e)
        {
            pictureBox375.BackColor = button21.BackColor;
        }

        private void pictureBox376_Click(object sender, EventArgs e)
        {
            pictureBox376.BackColor = button21.BackColor;
        }

        private void pictureBox377_Click(object sender, EventArgs e)
        {
            pictureBox377.BackColor = button21.BackColor;
        }

        private void pictureBox378_Click(object sender, EventArgs e)
        {
            pictureBox38.BackColor = button21.BackColor;
        }

        private void pictureBox379_Click(object sender, EventArgs e)
        {
            pictureBox379.BackColor = button21.BackColor;
        }

        private void pictureBox380_Click(object sender, EventArgs e)
        {
            pictureBox380.BackColor = button21.BackColor;
        }

        private void pictureBox381_Click(object sender, EventArgs e)
        {
            pictureBox381.BackColor = button21.BackColor;
        }

        private void pictureBox382_Click(object sender, EventArgs e)
        {
            pictureBox382.BackColor = button21.BackColor;
        }

        private void pictureBox383_Click(object sender, EventArgs e)
        {
            pictureBox383.BackColor = button21.BackColor;
        }

        private void pictureBox384_Click(object sender, EventArgs e)
        {
            pictureBox384.BackColor = button21.BackColor;
        }

        private void pictureBox385_Click(object sender, EventArgs e)
        {
            pictureBox385.BackColor = button21.BackColor;
        }

        private void pictureBox386_Click(object sender, EventArgs e)
        {
            pictureBox386.BackColor = button21.BackColor;
        }

        private void pictureBox387_Click(object sender, EventArgs e)
        {
            pictureBox387.BackColor = button21.BackColor;
        }

        private void pictureBox388_Click(object sender, EventArgs e)
        {
            pictureBox388.BackColor = button21.BackColor;
        }

        private void pictureBox389_Click(object sender, EventArgs e)
        {
            pictureBox389.BackColor = button21.BackColor;
        }

        private void pictureBox390_Click(object sender, EventArgs e)
        {
            pictureBox390.BackColor = button21.BackColor;
        }

        private void pictureBox391_Click(object sender, EventArgs e)
        {
            pictureBox391.BackColor = button21.BackColor;
        }

        private void pictureBox392_Click(object sender, EventArgs e)
        {
            pictureBox392.BackColor = button21.BackColor;
        }

        private void pictureBox393_Click(object sender, EventArgs e)
        {
            pictureBox393.BackColor = button21.BackColor;
        }

        private void pictureBox394_Click(object sender, EventArgs e)
        {
            pictureBox394.BackColor = button21.BackColor;
        }

        private void pictureBox395_Click(object sender, EventArgs e)
        {
            pictureBox395.BackColor = button21.BackColor;
        }

        private void pictureBox396_Click(object sender, EventArgs e)
        {
            pictureBox396.BackColor = button21.BackColor;
        }

        private void pictureBox397_Click(object sender, EventArgs e)
        {
            pictureBox397.BackColor = button21.BackColor;
        }

        private void pictureBox398_Click(object sender, EventArgs e)
        {
            pictureBox398.BackColor = button21.BackColor;
        }

        private void pictureBox399_Click(object sender, EventArgs e)
        {
            pictureBox399.BackColor = button21.BackColor;
        }

        private void pictureBox400_Click(object sender, EventArgs e)
        {
            pictureBox400.BackColor = button21.BackColor;
        }
    }


}
