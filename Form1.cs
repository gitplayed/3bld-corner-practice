using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace this_one
{
    public partial class Form1 : Form
    {

        Random r;
        alg currentalg;        
        bool timerrunning;
        // int[] letters;
        bool listening;
        double time1m;
        double time1s;
        double time1min;
        double time2m;
        double time2s;
        double time2min;
        double time;
        bool paintwholecube;
        cube foo;       
        alg[,] allalgs;
        bool[,] drill;
        List<alg> algs;
        String fcolor;
        String ucolor;
        String rcolor;
        String location;
        String[] letterscheme;
        String[] alphabet;
        String buffer;
        int bufferindex;
        String filename;
        Boolean adddate;
        public Form1()
        {



            paintwholecube = false;
            //configures variables
            fcolor = "b";
            ucolor = "y";
            rcolor = "r";
            if (this_one.Properties.Settings.Default.settingfcolor != "")
            {
                fcolor = this_one.Properties.Settings.Default.settingfcolor;
                ucolor = this_one.Properties.Settings.Default.settingucolor;
                rcolor = this_one.Properties.Settings.Default.settingrcolor;
            }

            if(this_one.Properties.Settings.Default.settingalgs == "")
            {
                drill = new bool[21, 18];
          
            }
                
            else
            {
                drill = new bool[21, 18];
                char[] tsandfs= this_one.Properties.Settings.Default.settingalgs.ToCharArray();
                int x = 0;
                for(int i = 0; i < 21; i++)
                    for(int j = 0; j < 18; j++)
                    {
                        if (tsandfs[x] == 't')
                            drill[i, j] = true;
                        else
                            drill[i, j] = false;
                        x++;

                    }

                    

            }



            filename = "algtimes";
            
          string docPath =
          Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
          location = docPath;

            adddate = true;
            buffer = "C";
            

            if (this_one.Properties.Settings.Default.settingletterscheme != "")
            {
                letterscheme = this_one.Properties.Settings.Default.settingletterscheme.Split(",");
            }
            else
            {
               letterscheme = new string[] {"A", "B", "C", "D", "I", "J", "K", "L", "M", "N",
                                            "O", "P", "Q", "R", "S", "T", "E", "F", "G",
                                            "H", "U", "V", "W", "X"};
            }

            buffer = this_one.Properties.Settings.Default.settingbuffer;


            //letterscheme = new string[] {"a", "b", "c", "d", "e", "f", "g",
            //                              "h", "i", "j", "k", "l", "m", "n",
            //                                "o", "p", "q", "r", "s", "t", "u",
            //                                 "v", "w", "x" };



            listening = false;
            timerrunning = false;           
            time1m = 0;
            time1s = 0;
            time1min = 0;
            time2m = 0;
            time2s = 0;
            time2min = 0;
            
             foo = new cube(fcolor, ucolor, rcolor, letterscheme, buffer);
            
            r = new Random();
             
             time = 0;
            
            //String[] alphabet = new string[] { "A", "B", "C", "D", "U", "V", "W", "X",
            //                                   "Q", "M", "I", "E", "H", "G", "P", "O",
            //                                   "N", "J", "F", "R", "S", "L", "K", "T"};
            alphabet = new string[] 
            { letterscheme[0], letterscheme[1], letterscheme[2], letterscheme[3], letterscheme[20], letterscheme[21], letterscheme[22], letterscheme[23],
              letterscheme[16], letterscheme[12], letterscheme[7], letterscheme[4], letterscheme[7], letterscheme[6], letterscheme[15], letterscheme[14],
              letterscheme[13], letterscheme[9], letterscheme[5], letterscheme[17], letterscheme[18], letterscheme[11], letterscheme[10], letterscheme[19]};

            bufferindex = Array.IndexOf(alphabet, buffer);
            if (bufferindex < 0)
                bufferindex = 2;
            bufferindex = bufferindex % 8;

            String[] temp = new string[21];
            int w = 0;
            for(int i = 0; i < 24; i++)
            {
                if(i % 8 != bufferindex)
                {
                    temp[w] = alphabet[i];
                    w++;
                }
            }
            alphabet = temp;
            
            
            

            allalgs = new alg[21, 18];
            
            

            //creates a master list of every possible alg
            int l = 0;
            for (int i = 0; i < 21; i++)
            {
                int k = 0;
               // if(i % 8 != bufferindex)
                //{
                    for (int j = 0; j < 21; j++)
                    //if (i % 8 != j % 8 & j % 8 != bufferindex)
                    if (i % 7 != j % 7)
                    {

                            allalgs[l, k] = new alg(alphabet[i], alphabet[j]);
                            //MessageBox.Show(alphabet[i] + alphabet[j]);
                            k++;

                        }
                    l++;
              //  }
                
            }
            //MessageBox.Show("foo");
            algs = createlist();
            InitializeComponent();
            //sets up event handlers for buttons and keys
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            this.KeyDown += Form1_KeyUp;
            button1.Click += new EventHandler(this.Click);
            button2.Click += new EventHandler(this.Click2);
            button3.Click += new EventHandler(this.Click3);
            button4.Click += new EventHandler(this.Click4);
            button5.Click += new EventHandler(this.Click5);
            button6.Click += new EventHandler(this.Click6);
            button7.Click += new EventHandler(this.Click7);
            button8.Click += new EventHandler(this.Click8);
            button9.Click += new EventHandler(this.Click9);
            button10.Click += new EventHandler(this.Click10);
            button11.Click += new EventHandler(this.Click11);
            button12.Click += new EventHandler(this.Click12);
            button13.Click += new EventHandler(this.Click13);
            button14.Click += new EventHandler(this.Click14);
            button15.Click += new EventHandler(this.Click15);
            button16.Click += new EventHandler(this.Click16);
            button17.Click += new EventHandler(this.Click17);
            button18.Click += new EventHandler(this.Click18);
            button19.Click += new EventHandler(this.Click19);
            button20.Click += new EventHandler(this.Click20);
            button21.Click += new EventHandler(this.Click21);
            button22.Click += new EventHandler(this.Click22);           
            button23.Click += new EventHandler(this.Click23);
            button24.Click += new EventHandler(this.Click24);
            button25.Click += new EventHandler(this.Click25);
            button26.Click += new EventHandler(this.Click26);
            button27.Click += new EventHandler(this.Click27);
            button28.Click += new EventHandler(this.Click28);
            button29.Click += new EventHandler(this.Click29);
            button30.Click += new EventHandler(this.Click30);
            button31.Click += new EventHandler(this.Click31);
            button32.Click += new EventHandler(this.Click32);
            button33.Click += new EventHandler(this.Click33);
            button34.Click += new EventHandler(this.Click34);
            button35.Click += new EventHandler(this.Click35);
            button36.Click += new EventHandler(this.Click36);
            button37.Click += new EventHandler(this.Click37);
            button38.Click += new EventHandler(this.Click38);
            button39.Click += new EventHandler(this.Click39);
            button40.Click += new EventHandler(this.Click40);
            button41.Click += new EventHandler(this.Click41);
            button42.Click += new EventHandler(this.Click42);
            //button43.Click += new EventHandler(this.Click43);
            button44.Click += new EventHandler(this.Click44);
            button45.Click += new EventHandler(this.Click45);
            button46.Click += new EventHandler(this.Click46);
            button47.Click += new EventHandler(this.Click47);
            button48.Click += new EventHandler(this.Click48);
            button49.Click += new EventHandler(this.Click49);
            button50.Click += new EventHandler(this.Click50);
            button51.Click += new EventHandler(this.Click51);
            button52.Click += new EventHandler(this.Click52);
            button53.Click += new EventHandler(this.Click53);
            button54.Click += new EventHandler(this.Click54);
            button55.Click += new EventHandler(this.Click55);

            currentalg = new alg("", "");
            panel1.Visible = true;
            adjustbuttoncolors();
            this.Text = "3bld corners practice";
        }



        //actually don't need this method
        public void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)

        {
           // keypressed = true;
        }     
                    
        
        
        public void Form1_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        
        {     
            if(listening)
                keychangetoup();
          
        }
            
        //the reset button
        void Click(Object sender, EventArgs e)
        {
            
           if(e is System.Windows.Forms.MouseEventArgs)
            {
                foo.reset();
                Refresh();
            }

        }        

        //the print button
        void Click2(Object sender, EventArgs e)
        {
           
            if (e is System.Windows.Forms.MouseEventArgs)
            {
                StringBuilder s = new StringBuilder();
                String delim = ",";
          
                for (int i = 0; i < 21; i++)
                {
                    for (int j = 0; j < 18; j++)
                    {

                        if (allalgs[i, j].times.Count == 0)
                            continue;


                        s.Append(allalgs[i, j].fir);                        
                        s.Append(allalgs[i, j].sec);                        
                        s.Append(delim);
                        foreach (double x in allalgs[i, j].times)
                        {
                            
                            s.Append(x.ToString("0.###"));                           
                            s.Append(delim);
                        }

                        s.Append("\n");

                    }

                    
                }

                String name;
                if (adddate)
                    name = filename + DateTime.Now.Month + "-" + DateTime.Now.Day + ".csv";
                else
                    name = filename + ".csv";

                StreamWriter outputFile = new StreamWriter(Path.Combine(location, name));
                outputFile.Write(s.ToString());
                outputFile.Close();
                
                String message = "file created in " + location;
                MessageBox.Show(message);
                

            }



        }

        //the remove previous time button
        void Click3(Object sender, EventArgs e)
        {

            if (e is System.Windows.Forms.MouseEventArgs)
            {
                if(currentalg.times.Count - 1 >= 0)
                {
                    //MessageBox.Show(currentalg.times[currentalg.times.Count - 1].ToString("0.###"));
                    currentalg.times.RemoveAt(currentalg.times.Count - 1);
                    algs.Add(currentalg);

                    Refresh();
                }
                
            }

        }



        //All of the buttons for the first letter of the algs being selected in the panel
        void Click4(Object sender, EventArgs e)
        {

           
            int i = 0;
            int x = Array.IndexOf(alphabet, button4.Text);
            bool check = false;
            for (int l = 0; l < 18; l++)
                if (drill[x, l])
                {
                    check = true;
                    break;
                }
            if(!check)
            {
                for (int l = 0; l < 18; l++)
                    drill[x, l] = true;
            }
            
            x = x % 7;
            String[] aa = new string[18];
            for(int j = 0; j < 21; j++)
            {
               if(j % 7 != x)
                {
                    aa[i] = alphabet[j];
                    i++;
                }


            }

            button25.Text = button4.Text + aa[0];
            button26.Text = button4.Text + aa[1];
            button27.Text = button4.Text + aa[2];
            button28.Text = button4.Text + aa[3];
            button29.Text = button4.Text + aa[4];
            button30.Text = button4.Text + aa[5];
            button31.Text = button4.Text + aa[6];
            button32.Text = button4.Text + aa[7];
            button33.Text = button4.Text + aa[8];
            button34.Text = button4.Text + aa[9];
            button35.Text = button4.Text + aa[10]; 
            button36.Text = button4.Text + aa[11]; 
            button37.Text = button4.Text + aa[12];
            button38.Text = button4.Text + aa[13];
            button39.Text = button4.Text + aa[14];
            button40.Text = button4.Text + aa[15];
            button41.Text = button4.Text + aa[16];
            button42.Text = button4.Text + aa[17];
            adjustbuttoncolors();
           
        }

        void Click5(Object sender, EventArgs e)
        {
            int i = 0;
            int x = Array.IndexOf(alphabet, button5.Text);
            bool check = false;
            for (int l = 0; l < 18; l++)
                if (drill[x, l])
                {
                    check = true;
                    break;
                }
            if (!check)
            {
                for (int l = 0; l < 18; l++)
                    drill[x, l] = true;
            }
            x = x % 7;
            String[] aa = new string[18];
            for (int j = 0; j < 21; j++)
            {
                if (j % 7 != x)
                {
                    aa[i] = alphabet[j];
                    i++;
                }


            }

            button25.Text = button5.Text + aa[0];
            button26.Text = button5.Text + aa[1];
            button27.Text = button5.Text + aa[2];
            button28.Text = button5.Text + aa[3];
            button29.Text = button5.Text + aa[4];
            button30.Text = button5.Text + aa[5];
            button31.Text = button5.Text + aa[6];
            button32.Text = button5.Text + aa[7];
            button33.Text = button5.Text + aa[8];
            button34.Text = button5.Text + aa[9];
            button35.Text = button5.Text + aa[10];
            button36.Text = button5.Text + aa[11];
            button37.Text = button5.Text + aa[12];
            button38.Text = button5.Text + aa[13];
            button39.Text = button5.Text + aa[14];
            button40.Text = button5.Text + aa[15];
            button41.Text = button5.Text + aa[16];
            button42.Text = button5.Text + aa[17];
            adjustbuttoncolors();


        }

        void Click6(Object sender, EventArgs e)
        {
            int i = 0;
            int x = Array.IndexOf(alphabet, button6.Text);
            bool check = false;
            for (int l = 0; l < 18; l++)
                if (drill[x, l])
                {
                    check = true;
                    break;
                }
            if (!check)
            {
                for (int l = 0; l < 18; l++)
                    drill[x, l] = true;
            }
            x = x % 7;
            String[] aa = new string[18];
            for (int j = 0; j < 21; j++)
            {
                if (j % 7 != x)
                {
                    aa[i] = alphabet[j];
                    i++;
                }


            }

            button25.Text = button6.Text + aa[0];
            button26.Text = button6.Text + aa[1];
            button27.Text = button6.Text + aa[2];
            button28.Text = button6.Text + aa[3];
            button29.Text = button6.Text + aa[4];
            button30.Text = button6.Text + aa[5];
            button31.Text = button6.Text + aa[6];
            button32.Text = button6.Text + aa[7];
            button33.Text = button6.Text + aa[8];
            button34.Text = button6.Text + aa[9];
            button35.Text = button6.Text + aa[10];
            button36.Text = button6.Text + aa[11];
            button37.Text = button6.Text + aa[12];
            button38.Text = button6.Text + aa[13];
            button39.Text = button6.Text + aa[14];
            button40.Text = button6.Text + aa[15];
            button41.Text = button6.Text + aa[16];
            button42.Text = button6.Text + aa[17];
            adjustbuttoncolors();


        }

        void Click7(Object sender, EventArgs e)
        {
            int i = 0;
            int x = Array.IndexOf(alphabet, button7.Text);
            bool check = false;
            for (int l = 0; l < 18; l++)
                if (drill[x, l])
                {
                    check = true;
                    break;
                }
            if (!check)
            {
                for (int l = 0; l < 18; l++)
                    drill[x, l] = true;
            }
            x = x % 7;
            String[] aa = new string[18];
            for (int j = 0; j < 21; j++)
            {
                if (j % 7 != x)
                {
                    aa[i] = alphabet[j];
                    i++;
                }


            }

            button25.Text = button7.Text + aa[0];
            button26.Text = button7.Text + aa[1];
            button27.Text = button7.Text + aa[2];
            button28.Text = button7.Text + aa[3];
            button29.Text = button7.Text + aa[4];
            button30.Text = button7.Text + aa[5];
            button31.Text = button7.Text + aa[6];
            button32.Text = button7.Text + aa[7];
            button33.Text = button7.Text + aa[8];
            button34.Text = button7.Text + aa[9];
            button35.Text = button7.Text + aa[10];
            button36.Text = button7.Text + aa[11];
            button37.Text = button7.Text + aa[12];
            button38.Text = button7.Text + aa[13];
            button39.Text = button7.Text + aa[14];
            button40.Text = button7.Text + aa[15];
            button41.Text = button7.Text + aa[16];
            button42.Text = button7.Text + aa[17];
            adjustbuttoncolors();


        }
        void Click8(Object sender, EventArgs e)
        {
            int i = 0;
            int x = Array.IndexOf(alphabet, button8.Text);
            bool check = false;
            for (int l = 0; l < 18; l++)
                if (drill[x, l])
                {
                    check = true;
                    break;
                }
            if (!check)
            {
                for (int l = 0; l < 18; l++)
                    drill[x, l] = true;
            }
            x = x % 7;
            String[] aa = new string[18];
            for (int j = 0; j < 21; j++)
            {
                if (j % 7 != x)
                {
                    aa[i] = alphabet[j];
                    i++;
                }


            }

            button25.Text = button8.Text + aa[0];
            button26.Text = button8.Text + aa[1];
            button27.Text = button8.Text + aa[2];
            button28.Text = button8.Text + aa[3];
            button29.Text = button8.Text + aa[4];
            button30.Text = button8.Text + aa[5];
            button31.Text = button8.Text + aa[6];
            button32.Text = button8.Text + aa[7];
            button33.Text = button8.Text + aa[8];
            button34.Text = button8.Text + aa[9];
            button35.Text = button8.Text + aa[10];
            button36.Text = button8.Text + aa[11];
            button37.Text = button8.Text + aa[12];
            button38.Text = button8.Text + aa[13];
            button39.Text = button8.Text + aa[14];
            button40.Text = button8.Text + aa[15];
            button41.Text = button8.Text + aa[16];
            button42.Text = button8.Text + aa[17];
            adjustbuttoncolors();


        }
        void Click9(Object sender, EventArgs e)
        {
            int i = 0;
            int x = Array.IndexOf(alphabet, button9.Text);
            bool check = false;
            for (int l = 0; l < 18; l++)
                if (drill[x, l])
                {
                    check = true;
                    break;
                }
            if (!check)
            {
                for (int l = 0; l < 18; l++)
                    drill[x, l] = true;
            }
            x = x % 7;
            String[] aa = new string[18];
            for (int j = 0; j < 21; j++)
            {
                if (j % 7 != x)
                {
                    aa[i] = alphabet[j];
                    i++;
                }


            }

            button25.Text = button9.Text + aa[0];
            button26.Text = button9.Text + aa[1];
            button27.Text = button9.Text + aa[2];
            button28.Text = button9.Text + aa[3];
            button29.Text = button9.Text + aa[4];
            button30.Text = button9.Text + aa[5];
            button31.Text = button9.Text + aa[6];
            button32.Text = button9.Text + aa[7];
            button33.Text = button9.Text + aa[8];
            button34.Text = button9.Text + aa[9];
            button35.Text = button9.Text + aa[10];
            button36.Text = button9.Text + aa[11];
            button37.Text = button9.Text + aa[12];
            button38.Text = button9.Text + aa[13];
            button39.Text = button9.Text + aa[14];
            button40.Text = button9.Text + aa[15];
            button41.Text = button9.Text + aa[16];
            button42.Text = button9.Text + aa[17];
            adjustbuttoncolors();


        }
        void Click10(Object sender, EventArgs e)
        {
            int i = 0;
            int x = Array.IndexOf(alphabet, button10.Text);
            bool check = false;
            for (int l = 0; l < 18; l++)
                if (drill[x, l])
                {
                    check = true;
                    break;
                }
            if (!check)
            {
                for (int l = 0; l < 18; l++)
                    drill[x, l] = true;
            }
            x = x % 7;
            String[] aa = new string[18];
            for (int j = 0; j < 21; j++)
            {
                if (j % 7 != x)
                {
                    aa[i] = alphabet[j];
                    i++;
                }


            }

            button25.Text = button10.Text + aa[0];
            button26.Text = button10.Text + aa[1];
            button27.Text = button10.Text + aa[2];
            button28.Text = button10.Text + aa[3];
            button29.Text = button10.Text + aa[4];
            button30.Text = button10.Text + aa[5];
            button31.Text = button10.Text + aa[6];
            button32.Text = button10.Text + aa[7];
            button33.Text = button10.Text + aa[8];
            button34.Text = button10.Text + aa[9];
            button35.Text = button10.Text + aa[10];
            button36.Text = button10.Text + aa[11];
            button37.Text = button10.Text + aa[12];
            button38.Text = button10.Text + aa[13];
            button39.Text = button10.Text + aa[14];
            button40.Text = button10.Text + aa[15];
            button41.Text = button10.Text + aa[16];
            button42.Text = button10.Text + aa[17];
            adjustbuttoncolors();


        }
        void Click11(Object sender, EventArgs e)
        {
            int i = 0;
            int x = Array.IndexOf(alphabet, button11.Text);
            bool check = false;
            for (int l = 0; l < 18; l++)
                if (drill[x, l])
                {
                    check = true;
                    break;
                }
            if (!check)
            {
                for (int l = 0; l < 18; l++)
                    drill[x, l] = true;
            }
            x = x % 7;
            String[] aa = new string[18];
            for (int j = 0; j < 21; j++)
            {
                if (j % 7 != x)
                {
                    aa[i] = alphabet[j];
                    i++;
                }


            }

            button25.Text = button11.Text + aa[0];
            button26.Text = button11.Text + aa[1];
            button27.Text = button11.Text + aa[2];
            button28.Text = button11.Text + aa[3];
            button29.Text = button11.Text + aa[4];
            button30.Text = button11.Text + aa[5];
            button31.Text = button11.Text + aa[6];
            button32.Text = button11.Text + aa[7];
            button33.Text = button11.Text + aa[8];
            button34.Text = button11.Text + aa[9];
            button35.Text = button11.Text + aa[10];
            button36.Text = button11.Text + aa[11];
            button37.Text = button11.Text + aa[12];
            button38.Text = button11.Text + aa[13];
            button39.Text = button11.Text + aa[14];
            button40.Text = button11.Text + aa[15];
            button41.Text = button11.Text + aa[16];
            button42.Text = button11.Text + aa[17];
            adjustbuttoncolors();



        }
        void Click12(Object sender, EventArgs e)
        {
            int i = 0;
            int x = Array.IndexOf(alphabet, button12.Text);
            bool check = false;
            for (int l = 0; l < 18; l++)
                if (drill[x, l])
                {
                    check = true;
                    break;
                }
            if (!check)
            {
                for (int l = 0; l < 18; l++)
                    drill[x, l] = true;
            }
            x = x % 7;
            String[] aa = new string[18];
            for (int j = 0; j < 21; j++)
            {
                if (j % 7 != x)
                {
                    aa[i] = alphabet[j];
                    i++;
                }


            }

            button25.Text = button12.Text + aa[0];
            button26.Text = button12.Text + aa[1];
            button27.Text = button12.Text + aa[2];
            button28.Text = button12.Text + aa[3];
            button29.Text = button12.Text + aa[4];
            button30.Text = button12.Text + aa[5];
            button31.Text = button12.Text + aa[6];
            button32.Text = button12.Text + aa[7];
            button33.Text = button12.Text + aa[8];
            button34.Text = button12.Text + aa[9];
            button35.Text = button12.Text + aa[10];
            button36.Text = button12.Text + aa[11];
            button37.Text = button12.Text + aa[12];
            button38.Text = button12.Text + aa[13];
            button39.Text = button12.Text + aa[14];
            button40.Text = button12.Text + aa[15];
            button41.Text = button12.Text + aa[16];
            button42.Text = button12.Text + aa[17];
            adjustbuttoncolors();



        }
        void Click13(Object sender, EventArgs e)
        {
            int i = 0;
            int x = Array.IndexOf(alphabet, button13.Text);
            bool check = false;
            for (int l = 0; l < 18; l++)
                if (drill[x, l])
                {
                    check = true;
                    break;
                }
            if (!check)
            {
                for (int l = 0; l < 18; l++)
                    drill[x, l] = true;
            }
            x = x % 7;
            String[] aa = new string[18];
            for (int j = 0; j < 21; j++)
            {
                if (j % 7 != x)
                {
                    aa[i] = alphabet[j];
                    i++;
                }


            }

            button25.Text = button13.Text + aa[0];
            button26.Text = button13.Text + aa[1];
            button27.Text = button13.Text + aa[2];
            button28.Text = button13.Text + aa[3];
            button29.Text = button13.Text + aa[4];
            button30.Text = button13.Text + aa[5];
            button31.Text = button13.Text + aa[6];
            button32.Text = button13.Text + aa[7];
            button33.Text = button13.Text + aa[8];
            button34.Text = button13.Text + aa[9];
            button35.Text = button13.Text + aa[10];
            button36.Text = button13.Text + aa[11];
            button37.Text = button13.Text + aa[12];
            button38.Text = button13.Text + aa[13];
            button39.Text = button13.Text + aa[14];
            button40.Text = button13.Text + aa[15];
            button41.Text = button13.Text + aa[16];
            button42.Text = button13.Text + aa[17];
            adjustbuttoncolors();



        }
        void Click14(Object sender, EventArgs e)
        {
            int i = 0;
            int x = Array.IndexOf(alphabet, button14.Text);
            bool check = false;
            for (int l = 0; l < 18; l++)
                if (drill[x, l])
                {
                    check = true;
                    break;
                }
            if (!check)
            {
                for (int l = 0; l < 18; l++)
                    drill[x, l] = true;
            }
            x = x % 7;
            String[] aa = new string[18];
            for (int j = 0; j < 21; j++)
            {
                if (j % 7 != x)
                {
                    aa[i] = alphabet[j];
                    i++;
                }


            }

            button25.Text = button14.Text + aa[0];
            button26.Text = button14.Text + aa[1];
            button27.Text = button14.Text + aa[2];
            button28.Text = button14.Text + aa[3];
            button29.Text = button14.Text + aa[4];
            button30.Text = button14.Text + aa[5];
            button31.Text = button14.Text + aa[6];
            button32.Text = button14.Text + aa[7];
            button33.Text = button14.Text + aa[8];
            button34.Text = button14.Text + aa[9];
            button35.Text = button14.Text + aa[10];
            button36.Text = button14.Text + aa[11];
            button37.Text = button14.Text + aa[12];
            button38.Text = button14.Text + aa[13];
            button39.Text = button14.Text + aa[14];
            button40.Text = button14.Text + aa[15];
            button41.Text = button14.Text + aa[16];
            button42.Text = button14.Text + aa[17];
            adjustbuttoncolors();



        }
        void Click15(Object sender, EventArgs e)
        {
            int i = 0;
            int x = Array.IndexOf(alphabet, button15.Text);
            bool check = false;
            for (int l = 0; l < 18; l++)
                if (drill[x, l])
                {
                    check = true;
                    break;
                }
            if (!check)
            {
                for (int l = 0; l < 18; l++)
                    drill[x, l] = true;
            }
            x = x % 7;
            String[] aa = new string[18];
            for (int j = 0; j < 21; j++)
            {
                if (j % 7 != x)
                {
                    aa[i] = alphabet[j];
                    i++;
                }


            }

            button25.Text = button15.Text + aa[0];
            button26.Text = button15.Text + aa[1];
            button27.Text = button15.Text + aa[2];
            button28.Text = button15.Text + aa[3];
            button29.Text = button15.Text + aa[4];
            button30.Text = button15.Text + aa[5];
            button31.Text = button15.Text + aa[6];
            button32.Text = button15.Text + aa[7];
            button33.Text = button15.Text + aa[8];
            button34.Text = button15.Text + aa[9];
            button35.Text = button15.Text + aa[10];
            button36.Text = button15.Text + aa[11];
            button37.Text = button15.Text + aa[12];
            button38.Text = button15.Text + aa[13];
            button39.Text = button15.Text + aa[14];
            button40.Text = button15.Text + aa[15];
            button41.Text = button15.Text + aa[16];
            button42.Text = button15.Text + aa[17];
            adjustbuttoncolors();



        }
        void Click16(Object sender, EventArgs e)
        {
            int i = 0;
            int x = Array.IndexOf(alphabet, button16.Text);
            bool check = false;
            for (int l = 0; l < 18; l++)
                if (drill[x, l])
                {
                    check = true;
                    break;
                }
            if (!check)
            {
                for (int l = 0; l < 18; l++)
                    drill[x, l] = true;
            }
            x = x % 7;
            String[] aa = new string[18];
            for (int j = 0; j < 21; j++)
            {
                if (j % 7 != x)
                {
                    aa[i] = alphabet[j];
                    i++;
                }


            }

            button25.Text = button16.Text + aa[0];
            button26.Text = button16.Text + aa[1];
            button27.Text = button16.Text + aa[2];
            button28.Text = button16.Text + aa[3];
            button29.Text = button16.Text + aa[4];
            button30.Text = button16.Text + aa[5];
            button31.Text = button16.Text + aa[6];
            button32.Text = button16.Text + aa[7];
            button33.Text = button16.Text + aa[8];
            button34.Text = button16.Text + aa[9];
            button35.Text = button16.Text + aa[10];
            button36.Text = button16.Text + aa[11];
            button37.Text = button16.Text + aa[12];
            button38.Text = button16.Text + aa[13];
            button39.Text = button16.Text + aa[14];
            button40.Text = button16.Text + aa[15];
            button41.Text = button16.Text + aa[16];
            button42.Text = button16.Text + aa[17];
            adjustbuttoncolors();



        }
        void Click17(Object sender, EventArgs e)
        {
            int i = 0;
            int x = Array.IndexOf(alphabet, button17.Text);
            bool check = false;
            for (int l = 0; l < 18; l++)
                if (drill[x, l])
                {
                    check = true;
                    break;
                }
            if (!check)
            {
                for (int l = 0; l < 18; l++)
                    drill[x, l] = true;
            }
            x = x % 7;
            String[] aa = new string[18];
            for (int j = 0; j < 21; j++)
            {
                if (j % 7 != x)
                {
                    aa[i] = alphabet[j];
                    i++;
                }


            }

            button25.Text = button17.Text + aa[0];
            button26.Text = button17.Text + aa[1];
            button27.Text = button17.Text + aa[2];
            button28.Text = button17.Text + aa[3];
            button29.Text = button17.Text + aa[4];
            button30.Text = button17.Text + aa[5];
            button31.Text = button17.Text + aa[6];
            button32.Text = button17.Text + aa[7];
            button33.Text = button17.Text + aa[8];
            button34.Text = button17.Text + aa[9];
            button35.Text = button17.Text + aa[10];
            button36.Text = button17.Text + aa[11];
            button37.Text = button17.Text + aa[12];
            button38.Text = button17.Text + aa[13];
            button39.Text = button17.Text + aa[14];
            button40.Text = button17.Text + aa[15];
            button41.Text = button17.Text + aa[16];
            button42.Text = button17.Text + aa[17];
            adjustbuttoncolors();



        }
        void Click18(Object sender, EventArgs e)
        {
            int i = 0;
            int x = Array.IndexOf(alphabet, button18.Text);
            bool check = false;
            for (int l = 0; l < 18; l++)
                if (drill[x, l])
                {
                    check = true;
                    break;
                }
            if (!check)
            {
                for (int l = 0; l < 18; l++)
                    drill[x, l] = true;
            }
            x = x % 7;
            String[] aa = new string[18];
            for (int j = 0; j < 21; j++)
            {
                if (j % 7 != x)
                {
                    aa[i] = alphabet[j];
                    i++;
                }


            }

            button25.Text = button18.Text + aa[0];
            button26.Text = button18.Text + aa[1];
            button27.Text = button18.Text + aa[2];
            button28.Text = button18.Text + aa[3];
            button29.Text = button18.Text + aa[4];
            button30.Text = button18.Text + aa[5];
            button31.Text = button18.Text + aa[6];
            button32.Text = button18.Text + aa[7];
            button33.Text = button18.Text + aa[8];
            button34.Text = button18.Text + aa[9];
            button35.Text = button18.Text + aa[10];
            button36.Text = button18.Text + aa[11];
            button37.Text = button18.Text + aa[12];
            button38.Text = button18.Text + aa[13];
            button39.Text = button18.Text + aa[14];
            button40.Text = button18.Text + aa[15];
            button41.Text = button18.Text + aa[16];
            button42.Text = button18.Text + aa[17];
            adjustbuttoncolors();



        }
        void Click19(Object sender, EventArgs e)
        {
            int i = 0;
            int x = Array.IndexOf(alphabet, button19.Text);
            bool check = false;
            for (int l = 0; l < 18; l++)
                if (drill[x, l])
                {
                    check = true;
                    break;
                }
            if (!check)
            {
                for (int l = 0; l < 18; l++)
                    drill[x, l] = true;
            }
            x = x % 7;
            String[] aa = new string[18];
            for (int j = 0; j < 21; j++)
            {
                if (j % 7 != x)
                {
                    aa[i] = alphabet[j];
                    i++;
                }


            }

            button25.Text = button19.Text + aa[0];
            button26.Text = button19.Text + aa[1];
            button27.Text = button19.Text + aa[2];
            button28.Text = button19.Text + aa[3];
            button29.Text = button19.Text + aa[4];
            button30.Text = button19.Text + aa[5];
            button31.Text = button19.Text + aa[6];
            button32.Text = button19.Text + aa[7];
            button33.Text = button19.Text + aa[8];
            button34.Text = button19.Text + aa[9];
            button35.Text = button19.Text + aa[10];
            button36.Text = button19.Text + aa[11];
            button37.Text = button19.Text + aa[12];
            button38.Text = button19.Text + aa[13];
            button39.Text = button19.Text + aa[14];
            button40.Text = button19.Text + aa[15];
            button41.Text = button19.Text + aa[16];
            button42.Text = button19.Text + aa[17];
            adjustbuttoncolors();



        }
        void Click20(Object sender, EventArgs e)
        {
            int i = 0;
            int x = Array.IndexOf(alphabet, button20.Text);
            bool check = false;
            for (int l = 0; l < 18; l++)
                if (drill[x, l])
                {
                    check = true;
                    break;
                }
            if (!check)
            {
                for (int l = 0; l < 18; l++)
                    drill[x, l] = true;
            }
            x = x % 7;
            String[] aa = new string[18];
            for (int j = 0; j < 21; j++)
            {
                if (j % 7 != x)
                {
                    aa[i] = alphabet[j];
                    i++;
                }


            }

            button25.Text = button20.Text + aa[0];
            button26.Text = button20.Text + aa[1];
            button27.Text = button20.Text + aa[2];
            button28.Text = button20.Text + aa[3];
            button29.Text = button20.Text + aa[4];
            button30.Text = button20.Text + aa[5];
            button31.Text = button20.Text + aa[6];
            button32.Text = button20.Text + aa[7];
            button33.Text = button20.Text + aa[8];
            button34.Text = button20.Text + aa[9];
            button35.Text = button20.Text + aa[10];
            button36.Text = button20.Text + aa[11];
            button37.Text = button20.Text + aa[12];
            button38.Text = button20.Text + aa[13];
            button39.Text = button20.Text + aa[14];
            button40.Text = button20.Text + aa[15];
            button41.Text = button20.Text + aa[16];
            button42.Text = button20.Text + aa[17];
            adjustbuttoncolors();



        }
        void Click21(Object sender, EventArgs e)
        {
            int i = 0;
            int x = Array.IndexOf(alphabet, button21.Text);
            bool check = false;
            for (int l = 0; l < 18; l++)
                if (drill[x, l])
                {
                    check = true;
                    break;
                }
            if (!check)
            {
                for (int l = 0; l < 18; l++)
                    drill[x, l] = true;
            }
            x = x % 7;
            String[] aa = new string[18];
            for (int j = 0; j < 21; j++)
            {
                if (j % 7 != x)
                {
                    aa[i] = alphabet[j];
                    i++;
                }


            }

            button25.Text = button21.Text + aa[0];
            button26.Text = button21.Text + aa[1];
            button27.Text = button21.Text + aa[2];
            button28.Text = button21.Text + aa[3];
            button29.Text = button21.Text + aa[4];
            button30.Text = button21.Text + aa[5];
            button31.Text = button21.Text + aa[6];
            button32.Text = button21.Text + aa[7];
            button33.Text = button21.Text + aa[8];
            button34.Text = button21.Text + aa[9];
            button35.Text = button21.Text + aa[10];
            button36.Text = button21.Text + aa[11];
            button37.Text = button21.Text + aa[12];
            button38.Text = button21.Text + aa[13];
            button39.Text = button21.Text + aa[14];
            button40.Text = button21.Text + aa[15];
            button41.Text = button21.Text + aa[16];
            button42.Text = button21.Text + aa[17];
            adjustbuttoncolors();

        }
        void Click22(Object sender, EventArgs e)
        {
            int i = 0;
            int x = Array.IndexOf(alphabet, button22.Text);
            bool check = false;
            for (int l = 0; l < 18; l++)
                if (drill[x, l])
                {
                    check = true;
                    break;
                }
            if (!check)
            {
                for (int l = 0; l < 18; l++)
                    drill[x, l] = true;
            }
            x = x % 7;
            String[] aa = new string[18];
            for (int j = 0; j < 21; j++)
            {
                if (j % 7 != x)
                {
                    aa[i] = alphabet[j];
                    i++;
                }


            }

            button25.Text = button22.Text + aa[0];
            button26.Text = button22.Text + aa[1];
            button27.Text = button22.Text + aa[2];
            button28.Text = button22.Text + aa[3];
            button29.Text = button22.Text + aa[4];
            button30.Text = button22.Text + aa[5];
            button31.Text = button22.Text + aa[6];
            button32.Text = button22.Text + aa[7];
            button33.Text = button22.Text + aa[8];
            button34.Text = button22.Text + aa[9];
            button35.Text = button22.Text + aa[10];
            button36.Text = button22.Text + aa[11];
            button37.Text = button22.Text + aa[12];
            button38.Text = button22.Text + aa[13];
            button39.Text = button22.Text + aa[14];
            button40.Text = button22.Text + aa[15];
            button41.Text = button22.Text + aa[16];
            button42.Text = button22.Text + aa[17];
            adjustbuttoncolors();


        }
        void Click23(Object sender, EventArgs e)
        {
            int i = 0;
            int x = Array.IndexOf(alphabet, button23.Text);
            bool check = false;
            for (int l = 0; l < 18; l++)
                if (drill[x, l])
                {
                    check = true;
                    break;
                }
            if (!check)
            {
                for (int l = 0; l < 18; l++)
                    drill[x, l] = true;
            }
            x = x % 7;
            String[] aa = new string[18];
            for (int j = 0; j < 21; j++)
            {
                if (j % 7 != x)
                {
                    aa[i] = alphabet[j];
                    i++;
                }


            }

            button25.Text = button23.Text + aa[0];
            button26.Text = button23.Text + aa[1];
            button27.Text = button23.Text + aa[2];
            button28.Text = button23.Text + aa[3];
            button29.Text = button23.Text + aa[4];
            button30.Text = button23.Text + aa[5];
            button31.Text = button23.Text + aa[6];
            button32.Text = button23.Text + aa[7];
            button33.Text = button23.Text + aa[8];
            button34.Text = button23.Text + aa[9];
            button35.Text = button23.Text + aa[10];
            button36.Text = button23.Text + aa[11];
            button37.Text = button23.Text + aa[12];
            button38.Text = button23.Text + aa[13];
            button39.Text = button23.Text + aa[14];
            button40.Text = button23.Text + aa[15];
            button41.Text = button23.Text + aa[16];
            button42.Text = button23.Text + aa[17];
            adjustbuttoncolors();


        }
        void Click24(Object sender, EventArgs e)
        {
            int i = 0;
            int x = Array.IndexOf(alphabet, button24.Text);
            bool check = false;
            for (int l = 0; l < 18; l++)
                if (drill[x, l])
                {
                    check = true;
                    break;
                }
            if (!check)
            {
                for (int l = 0; l < 18; l++)
                    drill[x, l] = true;
            }
            x = x % 7;

            String[] aa = new string[18];
            for (int j = 0; j < 21; j++)
            {
                if (j % 7 != x)
                {
                    aa[i] = alphabet[j];
                    i++;
                }


            }

            button25.Text = button24.Text + aa[0];
            button26.Text = button24.Text + aa[1];
            button27.Text = button24.Text + aa[2];
            button28.Text = button24.Text + aa[3];
            button29.Text = button24.Text + aa[4];
            button30.Text = button24.Text + aa[5];
            button31.Text = button24.Text + aa[6];
            button32.Text = button24.Text + aa[7];
            button33.Text = button24.Text + aa[8];
            button34.Text = button24.Text + aa[9];
            button35.Text = button24.Text + aa[10];
            button36.Text = button24.Text + aa[11];
            button37.Text = button24.Text + aa[12];
            button38.Text = button24.Text + aa[13];
            button39.Text = button24.Text + aa[14];
            button40.Text = button24.Text + aa[15];
            button41.Text = button24.Text + aa[16];
            button42.Text = button24.Text + aa[17];

            adjustbuttoncolors();
           


        }

        //All of the buttons for the second letter of the algs being selected in the panel
        void Click25(Object sender, EventArgs e)
        {

            for(int i = 0; i < 21; i++)
                for(int j = 0; j < 18; j++)
                    if((allalgs[i,j].fir + allalgs[i, j].sec).Equals(button25.Text))
                    {
                        drill[i, j] = !drill[i, j];
                    }
            adjustbuttoncolors();

        }
        void Click26(Object sender, EventArgs e)
        {
            for (int i = 0; i < 21; i++)
                for (int j = 0; j < 18; j++)
                    if ((allalgs[i, j].fir + allalgs[i, j].sec).Equals(button26.Text))
                    {
                        drill[i, j] = !drill[i, j];
                    }
            adjustbuttoncolors();

        }
        void Click27(Object sender, EventArgs e)
        {
            for (int i = 0; i < 21; i++)
                for (int j = 0; j < 18; j++)
                    if ((allalgs[i, j].fir + allalgs[i, j].sec).Equals(button27.Text))
                    {
                        drill[i, j] = !drill[i, j];
                    }
            adjustbuttoncolors();

        }
        void Click28(Object sender, EventArgs e)
        {
            for (int i = 0; i < 21; i++)
                for (int j = 0; j < 18; j++)
                    if ((allalgs[i, j].fir + allalgs[i, j].sec).Equals(button28.Text))
                    {
                        drill[i, j] = !drill[i, j];
                    }
            adjustbuttoncolors();


        }
        void Click29(Object sender, EventArgs e)
        {
            for (int i = 0; i < 21; i++)
                for (int j = 0; j < 18; j++)
                    if ((allalgs[i, j].fir + allalgs[i, j].sec).Equals(button29.Text))
                    {
                        drill[i, j] = !drill[i, j];
                    }
            adjustbuttoncolors();

        }
        void Click30(Object sender, EventArgs e)
        {
            for (int i = 0; i < 21; i++)
                for (int j = 0; j < 18; j++)
                    if ((allalgs[i, j].fir + allalgs[i, j].sec).Equals(button30.Text))
                    {
                        drill[i, j] = !drill[i, j];
                    }
            adjustbuttoncolors();
        }

        void Click31(Object sender, EventArgs e)
        {

            for (int i = 0; i < 21; i++)
                for (int j = 0; j < 18; j++)
                    if ((allalgs[i, j].fir + allalgs[i, j].sec).Equals(button31.Text))
                    {
                        drill[i, j] = !drill[i, j];
                    }
            adjustbuttoncolors();

        }
        void Click32(Object sender, EventArgs e)
        {
            for (int i = 0; i < 21; i++)
                for (int j = 0; j < 18; j++)
                    if ((allalgs[i, j].fir + allalgs[i, j].sec).Equals(button32.Text))
                    {
                        drill[i, j] = !drill[i, j];
                    }
            adjustbuttoncolors();

        }
        void Click33(Object sender, EventArgs e)
        {

            for (int i = 0; i < 21; i++)
                for (int j = 0; j < 18; j++)
                    if ((allalgs[i, j].fir + allalgs[i, j].sec).Equals(button33.Text))
                    {
                        drill[i, j] = !drill[i, j];
                    }
            adjustbuttoncolors();
        }
        void Click34(Object sender, EventArgs e)
        {

            for (int i = 0; i < 21; i++)
                for (int j = 0; j < 18; j++)
                    if ((allalgs[i, j].fir + allalgs[i, j].sec).Equals(button34.Text))
                    {
                        drill[i, j] = !drill[i, j];
                    }
            adjustbuttoncolors();
        }

        void Click35(Object sender, EventArgs e)
        {

            for (int i = 0; i < 21; i++)
                for (int j = 0; j < 18; j++)
                    if ((allalgs[i, j].fir + allalgs[i, j].sec).Equals(button35.Text))
                    {
                        drill[i, j] = !drill[i, j];
                    }
            adjustbuttoncolors();
        }

        void Click36(Object sender, EventArgs e)
        {
            for (int i = 0; i < 21; i++)
                for (int j = 0; j < 18; j++)
                    if ((allalgs[i, j].fir + allalgs[i, j].sec).Equals(button36.Text))
                    {
                        drill[i, j] = !drill[i, j];
                    }
            adjustbuttoncolors();

        }

        void Click37(Object sender, EventArgs e)
        {
            for (int i = 0; i < 21; i++)
                for (int j = 0; j < 18; j++)
                    if ((allalgs[i, j].fir + allalgs[i, j].sec).Equals(button37.Text))
                    {
                        drill[i, j] = !drill[i, j];
                    }

            adjustbuttoncolors();
        }
        void Click38(Object sender, EventArgs e)
        {
            for (int i = 0; i < 21; i++)
                for (int j = 0; j < 18; j++)
                    if ((allalgs[i, j].fir + allalgs[i, j].sec).Equals(button38.Text))
                    {
                        drill[i, j] = !drill[i, j];
                    }

            adjustbuttoncolors();
        }
        void Click39(Object sender, EventArgs e)
        {

            for (int i = 0; i < 21; i++)
                for (int j = 0; j < 18; j++)
                    if ((allalgs[i, j].fir + allalgs[i, j].sec).Equals(button39.Text))
                    {
                        drill[i, j] = !drill[i, j];
                    }
            adjustbuttoncolors();
        }
        void Click40(Object sender, EventArgs e)
        {
            for (int i = 0; i < 21; i++)
                for (int j = 0; j < 18; j++)
                    if ((allalgs[i, j].fir + allalgs[i, j].sec).Equals(button40.Text))
                    {
                        drill[i, j] = !drill[i, j];
                    }

            adjustbuttoncolors();
        }
        void Click41(Object sender, EventArgs e)
        {
            for (int i = 0; i < 21; i++)
                for (int j = 0; j < 18; j++)
                    if ((allalgs[i, j].fir + allalgs[i, j].sec).Equals(button41.Text))
                    {
                        drill[i, j] = !drill[i, j];
                    }

            adjustbuttoncolors();
        }
        void Click42(Object sender, EventArgs e)
        {
            for (int i = 0; i < 21; i++)
                for (int j = 0; j < 18; j++)
                    if ((allalgs[i, j].fir + allalgs[i, j].sec).Equals(button42.Text))
                    {
                        drill[i, j] = !drill[i, j];
                    }

            adjustbuttoncolors();
        }
        //void Click43(Object sender, EventArgs e)

        //the first clear button which clears everything
        void Click44(Object sender, EventArgs e)
        {

            drill = new bool[21, 18];
            adjustbuttoncolors();

        }

        //the second clear button which clears all of the options under the given letter
        void Click45(Object sender, EventArgs e)
        {

            String s = button35.Text.Substring(0, 1);
            int x = Array.IndexOf(alphabet, s);
            for (int i = 0; i < 18; i++)
                drill[x, i] = false;
            adjustbuttoncolors();



        }

        //the save button for selecting algs
        void Click46(Object sender, EventArgs e)
        {

           
            savecubeorientation();
            String s = "";
            for (int i = 0; i < 21; i++)
                for (int j = 0; j < 18; j++)
                    if (drill[i, j])
                        s += "t";
                    else
                        s += "f";
            this_one.Properties.Settings.Default.settingalgs = s;
            panel1.Visible = false;

            this_one.Properties.Settings.Default.Save();
            listening = true;
            //Refresh();
            


        }

        void Click47(Object sender, EventArgs e)
        {
            foo.rotatex(true);
            fcolor = foo.fcolor;
            ucolor = foo.ucolor;
            rcolor = foo.rcolor;
            Refresh();
        }
        void Click48(Object sender, EventArgs e)
        {
            foo.rotatex(false);
            fcolor = foo.fcolor;
            ucolor = foo.ucolor;
            rcolor = foo.rcolor;
            Refresh();
        }

        void Click49(Object sender, EventArgs e)
        {
            foo.rotatey(true);
            fcolor = foo.fcolor;
            ucolor = foo.ucolor;
            rcolor = foo.rcolor;
            Refresh();
        }

        void Click50(Object sender, EventArgs e)
        {
            foo.rotatey(false);
            fcolor = foo.fcolor;
            ucolor = foo.ucolor;
            rcolor = foo.rcolor;
            Refresh();
        }
        void Click51(Object sender, EventArgs e)
        {
            foo.rotatez(true);
            fcolor = foo.fcolor;
            ucolor = foo.ucolor;
            rcolor = foo.rcolor;
            Refresh();
        }
        void Click52(Object sender, EventArgs e)
        {
            foo.rotatez(false);
            fcolor = foo.fcolor;
            ucolor = foo.ucolor;
            rcolor = foo.rcolor;
            Refresh();
           
        }
        void Click53(Object sender, EventArgs e)
        {
            this_one.Properties.Settings.Default.settingletterscheme =
                textbox1.Text + "," + textbox2.Text + "," + textbox3.Text + "," + textbox4.Text + "," + textbox5.Text + "," + textbox6.Text + "," +
                textbox7.Text + "," + textbox8.Text + "," + textbox9.Text + "," + textbox10.Text + "," + textbox11.Text + "," + textbox12.Text + "," +
                textbox13.Text + "," + textbox14.Text + "," + textbox15.Text + "," + textbox16.Text + "," + textbox17.Text + "," + textbox18.Text + "," +
                textbox19.Text + "," + textbox20.Text + "," + textbox21.Text + "," + textbox22.Text + "," + textbox23.Text + "," + textbox24.Text;
            this_one.Properties.Settings.Default.settingbuffer = textbox25.Text;
            this_one.Properties.Settings.Default.Save();
            MessageBox.Show("Your letter scheme has been saved. Restart program to apply changes.");


        }
        void Click54(Object sender, EventArgs e)
        {
            panel1.Visible = false;
            listening = true;
            savecubeorientation();
        }

        void Click55(Object sender, EventArgs e)
        {
            if (e is System.Windows.Forms.MouseEventArgs)
            {
                paintwholecube = !paintwholecube;
                Refresh();
            }
                
        }
        //highlights the appropriate buttons
        public void adjustbuttoncolors()
        {
            if(button35.Text != "")
            {
                String s = button35.Text.Substring(0, 1);
                int x = Array.IndexOf(alphabet, s);
                if (drill[x, 0])
                    button25.BackColor = Color.Yellow;
                else
                    button25.BackColor = button46.BackColor;
                if (drill[x, 1])
                    button26.BackColor = Color.Yellow;
                else
                    button26.BackColor = button46.BackColor;
                if (drill[x, 2])
                    button27.BackColor = Color.Yellow;
                else
                    button27.BackColor = button46.BackColor;
                if (drill[x, 3])
                    button28.BackColor = Color.Yellow;
                else
                    button28.BackColor = button46.BackColor;
                if (drill[x, 4])
                    button29.BackColor = Color.Yellow;
                else
                    button29.BackColor = button46.BackColor;
                if (drill[x, 5])
                    button30.BackColor = Color.Yellow;
                else
                    button30.BackColor = button46.BackColor;
                if (drill[x, 6])
                    button31.BackColor = Color.Yellow;
                else
                    button31.BackColor = button46.BackColor;
                if (drill[x, 7])
                    button32.BackColor = Color.Yellow;
                else
                    button32.BackColor = button46.BackColor;
                if (drill[x, 8])
                    button33.BackColor = Color.Yellow;
                else
                    button33.BackColor = button46.BackColor;
                if (drill[x, 9])
                    button34.BackColor = Color.Yellow;
                else
                    button34.BackColor = button46.BackColor;
                if (drill[x, 10])
                    button35.BackColor = Color.Yellow;
                else
                    button35.BackColor = button46.BackColor;
                if (drill[x, 11])
                    button36.BackColor = Color.Yellow;
                else
                    button36.BackColor = button46.BackColor;
                if (drill[x, 12])
                    button37.BackColor = Color.Yellow;
                else
                    button37.BackColor = button46.BackColor;
                if (drill[x, 13])
                    button38.BackColor = Color.Yellow;
                else
                    button38.BackColor = button46.BackColor;
                if (drill[x, 14])
                    button39.BackColor = Color.Yellow;
                else
                    button39.BackColor = button46.BackColor;
                if (drill[x, 15])
                    button40.BackColor = Color.Yellow;
                else
                    button40.BackColor = button46.BackColor;
                if (drill[x, 16])
                    button41.BackColor = Color.Yellow;
                else
                    button41.BackColor = button46.BackColor;
                if (drill[x, 17])
                    button42.BackColor = Color.Yellow;
                else
                    button42.BackColor = button46.BackColor;

                
            }


            Button[] whatever = new Button[] {button4, button5, button6, button7, button8, button9, button10, button11,
                                                button12, button13, button14, button15, button16, button17, button18, button19,
                                                button20, button21, button22, button23, button24};
            for (int i = 0; i < 21; i++)
            {
                bool check = false;
                for (int j = 0; j < 18; j++)
                    if (drill[i, j])
                    {
                        check = true;
                        break;
                    }
                        
                if(!check)
                    whatever[i].BackColor = button46.BackColor;
                else
                    whatever[i].BackColor = Color.Yellow;

            }
              

            
            Refresh();
        }

        public void savecubeorientation()
        {
            this_one.Properties.Settings.Default.settingfcolor = fcolor;
            this_one.Properties.Settings.Default.settingucolor = ucolor;
            this_one.Properties.Settings.Default.settingrcolor = rcolor;
            
        }


    }
}
