using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Input;
using System.Security.Permissions;

namespace this_one
{

    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        UserControl1 control1 = new UserControl1();
        

        



        










        /// <summary>
        ///  Clean up any resources being used.
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

        protected override void OnPaint(PaintEventArgs e)
        {
            
            Graphics g = e.Graphics;
            foo.draw(g, paintwholecube);
            //if(time == 0)
            //    g.DrawString( currentalg.fir + currentalg.sec, new Font("Ariel", 50), new SolidBrush(Color.Red), new PointF(900, 300));
            //else
            //    g.DrawString(currentalg.fir + currentalg.sec, new Font("Ariel", 50), new SolidBrush(Color.Black), new PointF(900, 300));
            g.DrawString(currentalg.fir + currentalg.sec, new Font("Ariel", 50), new SolidBrush(Color.Black), new PointF(900, 300));
            if (time == 0)
                g.DrawString("---", new Font("Ariel", 50), new SolidBrush(Color.Red), new PointF(900, 500));
            else
                g.DrawString(time.ToString("0.###"), new Font("Ariel", 50), new SolidBrush(Color.Black), new PointF(900, 500));
            String s = "";
            foreach (double i in currentalg.times)
            {
                s += i.ToString("0.###");
                s += "   ";
            }

            g.DrawString(s, new Font("Ariel", 25), new SolidBrush(Color.Black), new PointF(0, 100));

            

        }

        public void keychangetoup()
        {
            
            
            
            if (timerrunning == false)
            {
                time1m = DateTime.Now.Millisecond;
                time1s = DateTime.Now.Second;
                time1min = DateTime.Now.Minute;
                timerrunning = true;
                time = 0;
                nextalg();
                Refresh();
                //MessageBox.Show(key + "   " + e.KeyValue);
            }

            else
            {
                time2m = DateTime.Now.Millisecond;
                time2s = DateTime.Now.Second;
                time2min = DateTime.Now.Minute;
                double time1 = time1m / 1000 + time1s + time1min * 60;
                double time2 = time2m / 1000 + time2s + time2min * 60;

                time = (time2 - time1);
                if (time < 0)
                    time += 3600;
                //times[fir, sec].Add(time);
                currentalg.times.Add(time);
                

                timerrunning = false;
                Refresh();

            }
        }


      
       

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.textbox2 = new System.Windows.Forms.TextBox();
            this.textbox3 = new System.Windows.Forms.TextBox();
            this.textbox4 = new System.Windows.Forms.TextBox();
            this.textbox5 = new System.Windows.Forms.TextBox();
            this.textbox6 = new System.Windows.Forms.TextBox();
            this.textbox7 = new System.Windows.Forms.TextBox();
            this.textbox8 = new System.Windows.Forms.TextBox();
            this.textbox9 = new System.Windows.Forms.TextBox();
            this.textbox10 = new System.Windows.Forms.TextBox();
            this.textbox11 = new System.Windows.Forms.TextBox();
            this.textbox12 = new System.Windows.Forms.TextBox();
            this.textbox13 = new System.Windows.Forms.TextBox();
            this.textbox14 = new System.Windows.Forms.TextBox();
            this.textbox15 = new System.Windows.Forms.TextBox();
            this.textbox16 = new System.Windows.Forms.TextBox();
            this.textbox17 = new System.Windows.Forms.TextBox();
            this.textbox18 = new System.Windows.Forms.TextBox();
            this.textbox19 = new System.Windows.Forms.TextBox();
            this.textbox20 = new System.Windows.Forms.TextBox();
            this.textbox21 = new System.Windows.Forms.TextBox();
            this.textbox22 = new System.Windows.Forms.TextBox();
            this.textbox23 = new System.Windows.Forms.TextBox();
            this.textbox24 = new System.Windows.Forms.TextBox();
            this.textbox25 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.button42 = new System.Windows.Forms.Button();
            //this.button43 = new System.Windows.Forms.Button();
            this.button44 = new System.Windows.Forms.Button();
            this.button45 = new System.Windows.Forms.Button();
            this.button46 = new System.Windows.Forms.Button();
            this.button47 = new System.Windows.Forms.Button();
            this.button48 = new System.Windows.Forms.Button();
            this.button49 = new System.Windows.Forms.Button();
            this.button50 = new System.Windows.Forms.Button();
            this.button51 = new System.Windows.Forms.Button();
            this.button52 = new System.Windows.Forms.Button();
            this.button53 = new System.Windows.Forms.Button();
            this.button54 = new System.Windows.Forms.Button();
            this.button55 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1480, 880);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "reset";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "print times";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(149, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "remove previous time";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label25);
            //this.panel1.Controls.Add(this.button55);
            this.panel1.Controls.Add(this.button54);
            this.panel1.Controls.Add(this.button53);
            this.panel1.Controls.Add(this.button52);
            this.panel1.Controls.Add(this.button51);
            this.panel1.Controls.Add(this.button50);
            this.panel1.Controls.Add(this.button49);
            this.panel1.Controls.Add(this.button48);
            this.panel1.Controls.Add(this.button47);
            this.panel1.Controls.Add(this.button46);
            this.panel1.Controls.Add(this.button45);
            this.panel1.Controls.Add(this.button44);
            //this.panel1.Controls.Add(this.button43);
            this.panel1.Controls.Add(this.button42);
            this.panel1.Controls.Add(this.button41);
            this.panel1.Controls.Add(this.button40);
            this.panel1.Controls.Add(this.button39);
            this.panel1.Controls.Add(this.button38);
            this.panel1.Controls.Add(this.button37);
            this.panel1.Controls.Add(this.button36);
            this.panel1.Controls.Add(this.button35);
            this.panel1.Controls.Add(this.button34);
            this.panel1.Controls.Add(this.button33);
            this.panel1.Controls.Add(this.button32);
            this.panel1.Controls.Add(this.button31);
            this.panel1.Controls.Add(this.button30);
            this.panel1.Controls.Add(this.button29);
            this.panel1.Controls.Add(this.button28);
            this.panel1.Controls.Add(this.button27);
            this.panel1.Controls.Add(this.button26);
            this.panel1.Controls.Add(this.button25);
            this.panel1.Controls.Add(this.button24);
            this.panel1.Controls.Add(this.button23);
            this.panel1.Controls.Add(this.button22);
            this.panel1.Controls.Add(this.button21);
            this.panel1.Controls.Add(this.button20);
            this.panel1.Controls.Add(this.button19);
            this.panel1.Controls.Add(this.button18);
            this.panel1.Controls.Add(this.button17);
            this.panel1.Controls.Add(this.button16);
            this.panel1.Controls.Add(this.button15);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.textbox1);
            this.panel1.Controls.Add(this.textbox2);
            this.panel1.Controls.Add(this.textbox3);
            this.panel1.Controls.Add(this.textbox4);
            this.panel1.Controls.Add(this.textbox5);
            this.panel1.Controls.Add(this.textbox6);
            this.panel1.Controls.Add(this.textbox7);
            this.panel1.Controls.Add(this.textbox8);
            this.panel1.Controls.Add(this.textbox9);
            this.panel1.Controls.Add(this.textbox10);
            this.panel1.Controls.Add(this.textbox11);
            this.panel1.Controls.Add(this.textbox12);
            this.panel1.Controls.Add(this.textbox13);
            this.panel1.Controls.Add(this.textbox14);
            this.panel1.Controls.Add(this.textbox15);
            this.panel1.Controls.Add(this.textbox16);
            this.panel1.Controls.Add(this.textbox17);
            this.panel1.Controls.Add(this.textbox18);
            this.panel1.Controls.Add(this.textbox19);
            this.panel1.Controls.Add(this.textbox20);
            this.panel1.Controls.Add(this.textbox21);
            this.panel1.Controls.Add(this.textbox22);
            this.panel1.Controls.Add(this.textbox23);
            this.panel1.Controls.Add(this.textbox24);
            this.panel1.Controls.Add(this.textbox25);

            this.panel1.Location = new System.Drawing.Point(91, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1332, 467);
            this.panel1.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(57, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 0;
            this.button4.Text = alphabet[0];
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(57, 65);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 29);
            this.button5.TabIndex = 1;
            this.button5.Text = alphabet[1];
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(57, 100);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 29);
            this.button6.TabIndex = 2;
            this.button6.Text = alphabet[2];
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(57, 135);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 29);
            this.button7.TabIndex = 3;
            this.button7.Text = alphabet[3];
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(57, 170);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(94, 29);
            this.button8.TabIndex = 4;
            this.button8.Text = alphabet[4];
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(57, 205);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(94, 29);
            this.button9.TabIndex = 5;
            this.button9.Text = alphabet[5];
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(57, 240);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(94, 29);
            this.button10.TabIndex = 6;
            this.button10.Text = alphabet[6];
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(57, 275);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(94, 29);
            this.button11.TabIndex = 7;
            this.button11.Text = alphabet[7];
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(57, 310);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(94, 29);
            this.button12.TabIndex = 8;
            this.button12.Text = alphabet[8];
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(57, 345);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(94, 29);
            this.button13.TabIndex = 9;
            this.button13.Text = alphabet[9];
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(57, 380);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(94, 29);
            this.button14.TabIndex = 10;
            this.button14.Text = alphabet[10];
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(57, 415);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(94, 29);
            this.button15.TabIndex = 11;
            this.button15.Text = alphabet[11];
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(157, 30);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(94, 29);
            this.button16.TabIndex = 12;
            this.button16.Text = alphabet[12];
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(157, 65);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(94, 29);
            this.button17.TabIndex = 13;
            this.button17.Text = alphabet[13];
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(157, 100);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(94, 29);
            this.button18.TabIndex = 14;
            this.button18.Text = alphabet[14];
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(157, 135);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(94, 29);
            this.button19.TabIndex = 15;
            this.button19.Text = alphabet[15];
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(157, 170);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(94, 29);
            this.button20.TabIndex = 16;
            this.button20.Text = alphabet[16];
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(157, 205);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(94, 29);
            this.button21.TabIndex = 17;
            this.button21.Text = alphabet[17];
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(157, 240);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(94, 29);
            this.button22.TabIndex = 18;
            this.button22.Text = alphabet[18];
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(157, 275);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(94, 29);
            this.button23.TabIndex = 19;
            this.button23.Text = alphabet[19];
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(157, 310);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(94, 29);
            this.button24.TabIndex = 20;
            this.button24.Text = alphabet[20];
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(328, 30);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(94, 29);
            this.button25.TabIndex = 21;
            this.button25.Text = "";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(328, 65);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(94, 29);
            this.button26.TabIndex = 22;
            this.button26.Text = "";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(328, 100);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(94, 29);
            this.button27.TabIndex = 23;
            this.button27.Text = "";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(328, 135);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(94, 29);
            this.button28.TabIndex = 24;
            this.button28.Text = "";
            this.button28.UseVisualStyleBackColor = true;
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(328, 170);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(94, 29);
            this.button29.TabIndex = 25;
            this.button29.Text = "";
            this.button29.UseVisualStyleBackColor = true;
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(328, 205);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(94, 29);
            this.button30.TabIndex = 26;
            this.button30.Text = "";
            this.button30.UseVisualStyleBackColor = true;
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(328, 240);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(94, 29);
            this.button31.TabIndex = 27;
            this.button31.Text = "";
            this.button31.UseVisualStyleBackColor = true;
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(328, 275);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(94, 29);
            this.button32.TabIndex = 28;
            this.button32.Text = "";
            this.button32.UseVisualStyleBackColor = true;
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(328, 310);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(94, 29);
            this.button33.TabIndex = 29;
            this.button33.Text = "";
            this.button33.UseVisualStyleBackColor = true;
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(328, 345);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(94, 29);
            this.button34.TabIndex = 30;
            this.button34.Text = "";
            this.button34.UseVisualStyleBackColor = true;
            // 
            // button35
            // 
            this.button35.Location = new System.Drawing.Point(328, 380);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(94, 29);
            this.button35.TabIndex = 31;
            this.button35.Text = "";
            this.button35.UseVisualStyleBackColor = true;
            // 
            // button36
            // 
            this.button36.Location = new System.Drawing.Point(328, 415);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(94, 29);
            this.button36.TabIndex = 32;
            this.button36.Text = "";
            this.button36.UseVisualStyleBackColor = true;
            // 
            // button37
            // 
            this.button37.Location = new System.Drawing.Point(428, 30);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(94, 29);
            this.button37.TabIndex = 33;
            this.button37.Text = "";
            this.button37.UseVisualStyleBackColor = true;
            // 
            // button38
            // 
            this.button38.Location = new System.Drawing.Point(428, 65);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(94, 29);
            this.button38.TabIndex = 34;
            this.button38.Text = "";
            this.button38.UseVisualStyleBackColor = true;
            // 
            // button39
            // 
            this.button39.Location = new System.Drawing.Point(428, 100);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(94, 29);
            this.button39.TabIndex = 35;
            this.button39.Text = "";
            this.button39.UseVisualStyleBackColor = true;
            // 
            // button40
            // 
            this.button40.Location = new System.Drawing.Point(428, 135);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(94, 29);
            this.button40.TabIndex = 36;
            this.button40.Text = "";
            this.button40.UseVisualStyleBackColor = true;
            // 
            // button41
            // 
            this.button41.Location = new System.Drawing.Point(428, 170);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(94, 29);
            this.button41.TabIndex = 37;
            this.button41.Text = "";
            this.button41.UseVisualStyleBackColor = true;
            // 
            // button42
            // 
            this.button42.Location = new System.Drawing.Point(428, 205);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(94, 29);
            this.button42.TabIndex = 38;
            this.button42.Text = "";
            this.button42.UseVisualStyleBackColor = true;// 
            // button43
            // 
            //this.button43.Location = new System.Drawing.Point(428, 240);
            //this.button43.Name = "button43";
            //this.button43.Size = new System.Drawing.Size(94, 29);
            //this.button43.TabIndex = 39;
            //this.button43.Text = "button43";
            //this.button43.UseVisualStyleBackColor = true;
            // 
            // button44
            // 
            this.button44.Location = new System.Drawing.Point(157, 415);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(94, 29);
            this.button44.TabIndex = 40;
            this.button44.Text = "clear";
            this.button44.UseVisualStyleBackColor = true;
            // 
            // button45
            // 
            this.button45.Location = new System.Drawing.Point(428, 380);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(94, 29);
            this.button45.TabIndex = 41;
            this.button45.Text = "clear";
            this.button45.UseVisualStyleBackColor = true;
            // 
            // button46
            // 
            this.button46.Location = new System.Drawing.Point(428, 415);
            this.button46.Name = "button46";
            this.button46.Size = new System.Drawing.Size(94, 29);
            this.button46.TabIndex = 42;
            this.button46.Text = "save";
            this.button46.UseVisualStyleBackColor = true;
            // 
            // button47
            // 
            this.button47.Location = new System.Drawing.Point(1100, 200);
            this.button47.Name = "button47";
            this.button47.Size = new System.Drawing.Size(94, 29);
            this.button47.TabIndex = 43;
            this.button47.Text = "x";
            this.button47.UseVisualStyleBackColor = true;
            // 
            // button48
            // 
            this.button48.Location = new System.Drawing.Point(1200, 200);
            this.button48.Name = "button48";
            this.button48.Size = new System.Drawing.Size(94, 29);
            this.button48.TabIndex = 44;
            this.button48.Text = "x'";
            this.button48.UseVisualStyleBackColor = true;
            //
            // button49
            // 
            this.button49.Location = new System.Drawing.Point(1100, 235);
            this.button49.Name = "button49";
            this.button49.Size = new System.Drawing.Size(94, 29);
            this.button49.TabIndex = 45;
            this.button49.Text = "y";
            this.button49.UseVisualStyleBackColor = true;
            // 
            // button50
            // 
            this.button50.Location = new System.Drawing.Point(1200, 235);
            this.button50.Name = "button50";
            this.button50.Size = new System.Drawing.Size(94, 29);
            this.button50.TabIndex = 42;
            this.button50.Text = "y'";
            this.button50.UseVisualStyleBackColor = true;
            // 
            // button51
            // 
            this.button51.Location = new System.Drawing.Point(1100, 270);
            this.button51.Name = "button51";
            this.button51.Size = new System.Drawing.Size(94, 29);
            this.button51.TabIndex = 42;
            this.button51.Text = "z";
            this.button51.UseVisualStyleBackColor = true;
            // 
            // button52
            // 
            this.button52.Location = new System.Drawing.Point(1200, 270);
            this.button52.Name = "button52";
            this.button52.Size = new System.Drawing.Size(94, 29);
            this.button52.TabIndex = 42;
            this.button52.Text = "z'";
            this.button52.UseVisualStyleBackColor = true;
            // 
            // button53
            // 
            this.button53.Location = new System.Drawing.Point(920, 415);
            this.button53.Name = "button53";
            this.button53.Size = new System.Drawing.Size(94, 29);
            this.button53.TabIndex = 42;
            this.button53.Text = "apply";
            this.button53.UseVisualStyleBackColor = true;
            // 
            // button54
            // 
            this.button54.Location = new System.Drawing.Point(1150, 400);
            this.button54.Name = "button54";
            this.button54.Size = new System.Drawing.Size(94, 29);
            this.button54.TabIndex = 42;
            this.button54.Text = "start";
            this.button54.UseVisualStyleBackColor = true;
            // 
            // button55
            // 
            this.button55.Location = new System.Drawing.Point(1427, 915);
            this.button55.Name = "button55";
            this.button55.Size = new System.Drawing.Size(200, 29);
            this.button55.TabIndex = 3;
            this.button55.Text = "show whole cube";
            this.button55.UseVisualStyleBackColor = true;
            //
            //textbox1
            //
            this.textbox1.Location = new System.Drawing.Point(650, 30);
            this.textbox1.Size = new System.Drawing.Size(94, 29);
            this.textbox1.TabIndex = 101;
            this.textbox1.Name = "textbox1";
            this.label1.Location = new System.Drawing.Point(600, 30);
            this.label1.Size = new System.Drawing.Size(50, 29);
            this.label1.Text = "UBL:";
            //
            //textbox2
            //
            this.textbox2.Location = new System.Drawing.Point(650, 65);
            this.textbox2.Size = new System.Drawing.Size(94, 29);
            this.textbox2.TabIndex = 102;
            this.label2.Location = new System.Drawing.Point(600, 65);
            this.label2.Size = new System.Drawing.Size(50, 29);
            this.label2.Text = "UBR:";
            //
            //textbox3
            //
            this.textbox3.Location = new System.Drawing.Point(650, 100);
            this.textbox3.Size = new System.Drawing.Size(94, 29);
            this.textbox3.TabIndex = 103;
            this.label3.Location = new System.Drawing.Point(600, 100);
            this.label3.Size = new System.Drawing.Size(50, 29);
            this.label3.Text = "UFR:";
            //
            //textbox4
            //
            this.textbox4.Location = new System.Drawing.Point(650, 135);
            this.textbox4.Size = new System.Drawing.Size(94, 29);
            this.textbox4.TabIndex = 104;
            this.label4.Location = new System.Drawing.Point(600, 135);
            this.label4.Size = new System.Drawing.Size(50, 29);
            this.label4.Text = "UFL:";
            //
            //textbox5
            //
            this.textbox5.Location = new System.Drawing.Point(650, 170);
            this.textbox5.Size = new System.Drawing.Size(94, 29);
            this.textbox5.TabIndex = 105;
            this.label5.Location = new System.Drawing.Point(600, 170);
            this.label5.Size = new System.Drawing.Size(50, 29);
            this.label5.Text = "FUL:";
            //
            //textbox6
            //
            this.textbox6.Location = new System.Drawing.Point(650, 205);
            this.textbox6.Size = new System.Drawing.Size(94, 29);
            this.textbox6.TabIndex = 106;
            this.label6.Location = new System.Drawing.Point(600, 205);
            this.label6.Size = new System.Drawing.Size(50, 29);
            this.label6.Text = "FUR:";
            //
            //textbox7
            //
            this.textbox7.Location = new System.Drawing.Point(650, 240);
            this.textbox7.Size = new System.Drawing.Size(94, 29);
            this.textbox7.TabIndex = 107;
            this.label7.Location = new System.Drawing.Point(600, 240);
            this.label7.Size = new System.Drawing.Size(50, 29);
            this.label7.Text = "FDR:";
            //
            //textbox8
            //
            this.textbox8.Location = new System.Drawing.Point(650, 275);
            this.textbox8.Size = new System.Drawing.Size(94, 29);
            this.textbox8.TabIndex = 108;
            this.label8.Location = new System.Drawing.Point(600, 275);
            this.label8.Size = new System.Drawing.Size(50, 29);
            this.label8.Text = "FDL:";
            //
            //textbox9
            //
            this.textbox9.Location = new System.Drawing.Point(650, 310);
            this.textbox9.Size = new System.Drawing.Size(94, 29);
            this.textbox9.TabIndex = 109;
            this.label9.Location = new System.Drawing.Point(600, 310);
            this.label9.Size = new System.Drawing.Size(50, 29);
            this.label9.Text = "RUF:";
            //
            //textbox10
            //
            this.textbox10.Location = new System.Drawing.Point(650, 345);
            this.textbox10.Size = new System.Drawing.Size(94, 29);
            this.textbox10.TabIndex = 110;
            this.label10.Location = new System.Drawing.Point(600, 345);
            this.label10.Size = new System.Drawing.Size(50, 29);
            this.label10.Text = "RUB:";
            //
            //textbox11
            //
            this.textbox11.Location = new System.Drawing.Point(650, 380);
            this.textbox11.Size = new System.Drawing.Size(94, 29);
            this.textbox11.TabIndex = 111;
            this.label11.Location = new System.Drawing.Point(600, 380);
            this.label11.Size = new System.Drawing.Size(50, 29);
            this.label11.Text = "RDB:";
            //
            //textbox12
            //
            this.textbox12.Location = new System.Drawing.Point(650, 415);
            this.textbox12.Size = new System.Drawing.Size(94, 29);
            this.textbox12.TabIndex = 112;
            this.label12.Location = new System.Drawing.Point(600, 415);
            this.label12.Size = new System.Drawing.Size(50, 29);
            this.label12.Text = "RDF:";
            //
            //textbox13
            //
            this.textbox13.Location = new System.Drawing.Point(820, 30);
            this.textbox13.Size = new System.Drawing.Size(94, 29);
            this.textbox13.TabIndex = 113;
            this.label13.Location = new System.Drawing.Point(770, 30);
            this.label13.Size = new System.Drawing.Size(50, 29);
            this.label13.Text = "BUR:";
            //
            //textbox14
            //
            this.textbox14.Location = new System.Drawing.Point(820, 65);
            this.textbox14.Size = new System.Drawing.Size(94, 29);
            this.textbox14.TabIndex = 114;
            this.label14.Location = new System.Drawing.Point(770, 65);
            this.label14.Size = new System.Drawing.Size(50, 29);
            this.label14.Text = "BUL:";
            //
            //textbox15
            //
            this.textbox15.Location = new System.Drawing.Point(820, 100);
            this.textbox15.Size = new System.Drawing.Size(94, 29);
            this.textbox15.TabIndex = 115;
            this.label15.Location = new System.Drawing.Point(770, 100);
            this.label15.Size = new System.Drawing.Size(50, 29);
            this.label15.Text = "BDL:";
            //
            //textbox16
            //
            this.textbox16.Location = new System.Drawing.Point(820, 135);
            this.textbox16.Size = new System.Drawing.Size(94, 29);
            this.textbox16.TabIndex = 116;
            this.label16.Location = new System.Drawing.Point(770, 135);
            this.label16.Size = new System.Drawing.Size(50, 29);
            this.label16.Text = "BDR:";
            //
            //textbox17
            //
            this.textbox17.Location = new System.Drawing.Point(820, 170);
            this.textbox17.Size = new System.Drawing.Size(94, 29);
            this.textbox17.TabIndex = 117;
            this.label17.Location = new System.Drawing.Point(770, 170);
            this.label17.Size = new System.Drawing.Size(50, 29);
            this.label17.Text = "LUB:";
            //
            //textbox18
            //
            this.textbox18.Location = new System.Drawing.Point(820, 205);
            this.textbox18.Size = new System.Drawing.Size(94, 29);
            this.textbox18.TabIndex = 118;
            this.label18.Location = new System.Drawing.Point(770, 205);
            this.label18.Size = new System.Drawing.Size(50, 29);
            this.label18.Text = "LUF:";
            //
            //textbox19
            //
            this.textbox19.Location = new System.Drawing.Point(820, 240);
            this.textbox19.Size = new System.Drawing.Size(94, 29);
            this.textbox19.TabIndex = 119;
            this.label19.Location = new System.Drawing.Point(770, 240);
            this.label19.Size = new System.Drawing.Size(50, 29);
            this.label19.Text = "LDF:";
            //
            //textbox20
            //
            this.textbox20.Location = new System.Drawing.Point(820, 275);
            this.textbox20.Size = new System.Drawing.Size(94, 29);
            this.textbox20.TabIndex = 120;
            this.label20.Location = new System.Drawing.Point(770, 275);
            this.label20.Size = new System.Drawing.Size(50, 29);
            this.label20.Text = "LDB:";
            //
            //textbox21
            //
            this.textbox21.Location = new System.Drawing.Point(820, 310);
            this.textbox21.Size = new System.Drawing.Size(94, 29);
            this.textbox21.TabIndex = 121;
            this.label21.Location = new System.Drawing.Point(770, 310);
            this.label21.Size = new System.Drawing.Size(50, 29);
            this.label21.Text = "DFL:";
            //
            //textbox22
            //
            this.textbox22.Location = new System.Drawing.Point(820, 345);
            this.textbox22.Size = new System.Drawing.Size(94, 29);
            this.textbox22.TabIndex = 122;
            this.label22.Location = new System.Drawing.Point(770, 345);
            this.label22.Size = new System.Drawing.Size(50, 29);
            this.label22.Text = "DFR:";
            //
            //textbox23
            //
            this.textbox23.Location = new System.Drawing.Point(820, 380);
            this.textbox23.Size = new System.Drawing.Size(94, 29);
            this.textbox23.TabIndex = 123;
            this.label23.Location = new System.Drawing.Point(770, 380);
            this.label23.Size = new System.Drawing.Size(50, 29);
            this.label23.Text = "DBR:";
            //
            //textbox24
            //
            this.textbox24.Location = new System.Drawing.Point(820, 415);
            this.textbox24.Size = new System.Drawing.Size(94, 29);
            this.textbox24.TabIndex = 124;
            this.label24.Location = new System.Drawing.Point(770, 415);
            this.label24.Size = new System.Drawing.Size(50, 29);
            this.label24.Text = "DBL:";
            //
            //textbox25
            //
            this.textbox25.Location = new System.Drawing.Point(920, 380);
            this.textbox25.Size = new System.Drawing.Size(94, 29);
            this.textbox25.TabIndex = 125;
            this.label25.Location = new System.Drawing.Point(920, 350);
            this.label25.Size = new System.Drawing.Size(75, 29);
            this.label25.Text = "Buffer:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 707);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button55);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        public void nextalg ()
        {

            if (algs.Count() == 0)
                algs = createlist();
            currentalg = algs[0];
            algs.RemoveAt(0);            
            foo.doalg(currentalg.fir, currentalg.sec);
           


        }

        public List<alg> createlist()
        {
            List<alg> a = new List<alg>();
            List<alg> r = new List<alg>();
            for (int i = 0; i < 21; i++)
                for (int j = 0; j < 18; j++)
                    if(drill[i,j])
                        a.Add(allalgs[i, j]);




            //for (int i = 0; i < 18; i++)
            //{
            //    if (!letters.Contains(i))
            //        continue;
            //    for (int j = 0; j < 18; j++)
            //    {
            //        a.Add(allalgs[i, j]);
            //        //MessageBox.Show(allalgs[i, j].fir + allalgs[i, j].sec);
            //    }
                    
            //}
                
            Random rand = new Random();
            while(a.Count > 0)
            {
                int i = rand.Next(0, a.Count);
                r.Add(a[i]);
                a.RemoveAt(i);
            }
            //MessageBox.Show("" + r.Count);
            return r;
        }




        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private TextBox textbox1;
        private TextBox textbox2;
        private TextBox textbox3;
        private TextBox textbox4;
        private TextBox textbox5;
        private TextBox textbox6;
        private TextBox textbox7;
        private TextBox textbox8;
        private TextBox textbox9;
        private TextBox textbox10;
        private TextBox textbox11;
        private TextBox textbox12;
        private TextBox textbox13;
        private TextBox textbox14;
        private TextBox textbox15;
        private TextBox textbox16;
        private TextBox textbox17;
        private TextBox textbox18;
        private TextBox textbox19;
        private TextBox textbox20;
        private TextBox textbox21;
        private TextBox textbox22;
        private TextBox textbox23;
        private TextBox textbox24;
        private TextBox textbox25;
        private Button button55;
        private Button button54;
        private Button button53;
        private Button button52;
        private Button button51;
        private Button button50;
        private Button button49;
        private Button button48;
        private Button button47;
        private Button button46;
        private Button button45;
        private Button button44;
        //private Button button43;
        private Button button42;
        private Button button41;
        private Button button40;
        private Button button39;
        private Button button38;
        private Button button37;
        private Button button36;
        private Button button35;
        private Button button34;
        private Button button33;
        private Button button32;
        private Button button31;
        private Button button30;
        private Button button29;
        private Button button28;
        private Button button27;
        private Button button26;
        private Button button25;
        private Button button24;
        private Button button23;
        private Button button22;
        private Button button21;
        private Button button20;
        private Button button19;
        private Button button18;
        private Button button17;
        private Button button16;
        private Button button15;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;

    }
}

