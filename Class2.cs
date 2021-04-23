using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;


namespace this_one
{
     class cube
    {

       public String fcolor;
       public String ucolor;
       public String rcolor;
        String lcolor;
        String dcolor;
        String bcolor;
        sticker[] allstickers;
        sticker ubl;
        sticker ubr;
        sticker ufr;
        sticker ufl;
        sticker ful;
        sticker fur;
        sticker fdr;
        sticker fdl;
        sticker ruf;
        sticker rub;
        sticker rdb;
        sticker rdf;
        sticker bur;
        sticker bul;
        sticker bdl;
        sticker bdr;
        sticker lub;
        sticker luf;
        sticker ldf;
        sticker ldb;
        sticker dfl;
        sticker dfr;
        sticker dbr;
        sticker dbl;
        sticker buffer;



        public cube(String f, String u, String r, String[] scheme, String bufferletter)
        {
            fcolor = f;
            ucolor = u;
            rcolor = r;
            lcolor = oppositecolor(rcolor);
            dcolor = oppositecolor(ucolor);
            bcolor = oppositecolor(fcolor);
            allstickers = new sticker[24];



            ubl = new sticker(ucolor, scheme[0]);
            allstickers[0] = ubl;
            ubr = new sticker(ucolor, scheme[1]);
            allstickers[1] = ubr;
            ufr = new sticker(ucolor, scheme[2]);
            allstickers[2] = ufr;
            ufl = new sticker(ucolor, scheme[3]);
            allstickers[3] = ufl;
            ful = new sticker(fcolor, scheme[4]);
            allstickers[4] = ful;
            fur = new sticker(fcolor, scheme[5]);
            allstickers[5] = fur;
            fdr = new sticker(fcolor, scheme[6]);
            allstickers[6] = fdr;
            fdl = new sticker(fcolor, scheme[7]);
            allstickers[7] = fdl;
            ruf = new sticker(rcolor, scheme[8]);
            allstickers[8] = ruf;
            rub = new sticker(rcolor, scheme[9]);
            allstickers[9] = rub;
            rdb = new sticker(rcolor, scheme[10]);
            allstickers[10] = rdb;
            rdf = new sticker(rcolor, scheme[11]);
            allstickers[11] = rdf;
            bur = new sticker(bcolor, scheme[12]);
            allstickers[12] = bur;
            bul = new sticker(bcolor, scheme[13]);
            allstickers[13] = bul;
            bdl = new sticker(bcolor, scheme[14]);
            allstickers[14] = bdl;
            bdr = new sticker(bcolor, scheme[15]);
            allstickers[15] = bdr;
            lub = new sticker(lcolor, scheme[16]);
            allstickers[16] = lub;
            luf = new sticker(lcolor, scheme[17]);
            allstickers[17] = luf;
            ldf = new sticker(lcolor, scheme[18]);
            allstickers[18] = ldf;
            ldb = new sticker(lcolor, scheme[19]);
            allstickers[19] = ldb;
            dfl = new sticker(dcolor, scheme[20]);
            allstickers[20] = dfl;
            dfr = new sticker(dcolor, scheme[21]);
            allstickers[21] = dfr;
            dbr = new sticker(dcolor, scheme[22]);
            allstickers[22] = dbr;
            dbl = new sticker(dcolor, scheme[23]);
            allstickers[23] = dbl;

            int x = Array.IndexOf(scheme, bufferletter);
            buffer = ufr;
            if(x >= 0)
                buffer = allstickers[x];
            

            ubl.next = lub;
            lub.next = bul;
            bul.next = ubl;

            ubr.next = bur;
            bur.next = rub;
            rub.next = ubr;

            ufr.next = ruf;
            ruf.next = fur;
            fur.next = ufr;

            ufl.next = ful;
            ful.next = luf;
            luf.next = ufl;

            dfl.next = ldf;
            ldf.next = fdl;
            fdl.next = dfl;

            dfr.next = fdr;
            fdr.next = rdf;
            rdf.next = dfr;

            dbr.next = rdb;
            rdb.next = bdr;
            bdr.next = dbr;

            dbl.next = bdl;
            bdl.next = ldb;
            ldb.next = dbl;

        }
        public void doalg(string f, string s)
        {
            
            string temp1 = "";
            string temp2 = "";
            string temp3 = "";

            sticker first = ufr;
            sticker second = ufr;

            for(int i = 0; i < allstickers.Length; i++)
            {
                if (f == allstickers[i].id)
                    first = allstickers[i];
                if (s == allstickers[i].id)
                    second = allstickers[i];

            }

            temp1 = buffer.color;
            temp2 = buffer.next.color;
            temp3 = buffer.next.next.color;
            buffer.color = second.color;
            buffer.next.color = second.next.color;
            buffer.next.next.color = second.next.next.color;
            second.color = first.color;
            second.next.color = first.next.color;
            second.next.next.color = first.next.next.color;
            first.color = temp1;
            first.next.color = temp2;
            first.next.next.color = temp3;
        }

        public void reset()
        {
            ubl.color = ucolor;
            ubr.color = ucolor;
            ufr.color = ucolor;
            ufl.color = ucolor;
            ful.color = fcolor;
            fur.color = fcolor;
            fdr.color = fcolor;
            fdl.color = fcolor;
            ruf.color = rcolor;
            rub.color = rcolor;
            rdb.color = rcolor;
            rdf.color = rcolor;
            lub.color = lcolor;
            luf.color = lcolor;
            ldf.color = lcolor;
            ldb.color = lcolor;
            bur.color = bcolor;
            bul.color = bcolor;
            bdl.color = bcolor;
            bdr.color = bcolor;
            dfl.color = dcolor;
            dfr.color = dcolor;
            dbr.color = dcolor;
            dbl.color = dcolor;

        }

        public void draw(Graphics g, bool wholecube)
        {
            int initialx = 1400;
            int initialy = 600;
            int width = 80;
            int border = 8;
            if (wholecube)
            {
                width = 50;
                border = 5;
                initialx = 1375;
                initialy = 500;
                Pen pen = new Pen(Color.Black, 3);
                int rectwidth = 3 * width + 4 * border;
                g.DrawRectangle(pen, new Rectangle(initialx - border, initialy - border, rectwidth, rectwidth ));
                g.DrawRectangle(pen, new Rectangle(initialx - border, initialy - 5 * border  - 3 * width, rectwidth, rectwidth));
                g.DrawRectangle(pen, new Rectangle(initialx - border, initialy + 3 * border  + 3 * width, rectwidth, rectwidth));
                g.DrawRectangle(pen, new Rectangle(initialx - 5 * border - 3 * width, initialy - border, rectwidth, rectwidth));
                g.DrawRectangle(pen, new Rectangle(initialx + 3 * border + 3 * width, initialy - border, rectwidth, rectwidth));
                g.DrawRectangle(pen, new Rectangle(initialx + 7 * border + 6 * width, initialy - border, rectwidth, rectwidth));



                int y = initialy - 3 * width - 4 * border;

                // uface

                drawsquare(g, ubl.color, initialx, y, width);
                drawsquare(g, ucolor, initialx + border + width, y, width);
                drawsquare(g, ubr.color, initialx + 2 * (border + width), y, width);

                y = y + border + width;

                drawsquare(g, ucolor, initialx, y, width);
                drawsquare(g, ucolor, initialx + border + width, y, width);
                drawsquare(g, ucolor, initialx + 2 * (border + width), y, width);

                y = y + border + width;

                drawsquare(g, ufl.color, initialx, y, width);
                drawsquare(g, ucolor, initialx + border + width, y, width);
                drawsquare(g, ufr.color, initialx + 2 * border + 2 * width, y, width);

                y = y + border + width;

                //f face

                y = y + border;

                int yf = y;

                drawsquare(g, ful.color, initialx, y, width);
                drawsquare(g, fcolor, initialx + border + width,y, width);
                drawsquare(g, fur.color, initialx + 2 * border + 2 * width, y, width);

                y = y + border + width;

                drawsquare(g, fcolor, initialx, y, width);
                drawsquare(g, fcolor, initialx + border + width, y, width);
                drawsquare(g, fcolor, initialx + 2 * border + 2 * width, y, width);

                y = y + border + width;

                drawsquare(g, fdl.color, initialx, y, width);
                drawsquare(g, fcolor, initialx + border + width, y, width);
                drawsquare(g, fdr.color, initialx + 2 * border + 2 * width, y , width);

                y = y + border + width;

                //dface

                y = y + border;

                drawsquare(g, dfl.color, initialx, y, width);
                drawsquare(g, dcolor, initialx + border + width, y, width);
                drawsquare(g, dfr.color, initialx + 2 * border + 2 * width, y, width);

                y = y + border + width;

                drawsquare(g, dcolor, initialx, y, width);
                drawsquare(g, dcolor, initialx + border + width, y, width);
                drawsquare(g, dcolor, initialx + 2 * border + 2 * width, y, width);

                y = y + border + width;

                drawsquare(g, dbl.color, initialx, y, width);
                drawsquare(g, dcolor, initialx + border + width, y, width);
                drawsquare(g, dbr.color, initialx + 2 * border + 2 * width, y, width);

                //lface

                y = yf;

                drawsquare(g, lub.color, initialx - 4 * border - 3 * width, y, width);
                drawsquare(g, lcolor, initialx - 3 * border - 2 * width, y, width);
                drawsquare(g, luf.color, initialx - 2 * border - width, y, width);

                y = y + border + width;

                drawsquare(g, lcolor, initialx - 4 * border - 3 * width, y, width);
                drawsquare(g, lcolor, initialx - 3 * border - 2 * width, y, width);
                drawsquare(g, lcolor, initialx - 2 * border - width, y, width);

                y = y + border + width;

                drawsquare(g, ldb.color, initialx - 4 * border - 3 * width, y, width);
                drawsquare(g, lcolor, initialx - 3 * border - 2 * width, y, width);
                drawsquare(g, ldf.color, initialx - 2 * border - width, y, width);

                //rface

                y = yf;

                drawsquare(g, ruf.color, initialx + 3 * width + 4 * border, y, width);
                drawsquare(g, rcolor, initialx + 4 * width + 5 * border, y, width);
                drawsquare(g, rub.color, initialx + 5 * width + 6 * border, y, width);

                y = y + border + width;

                drawsquare(g, rcolor, initialx + 3 * width + 4 * border, y, width);
                drawsquare(g, rcolor, initialx + 4 * width + 5 * border, y, width);
                drawsquare(g, rcolor, initialx + 5 * width + 6 * border, y, width);

                y = y + border + width;

                drawsquare(g, rdf.color, initialx + 3 * width + 4 * border, y, width);
                drawsquare(g, rcolor, initialx + 4 * width + 5 * border, y, width);
                drawsquare(g, rdb.color, initialx + 5 * width + 6 * border, y, width);

                //bface

                y = yf;

                drawsquare(g, bur.color, initialx + 6 * width + 8 * border, y, width);
                drawsquare(g, bcolor, initialx + 7 * width + 9 * border, y, width);
                drawsquare(g, bul.color, initialx + 8 * width + 10 * border, y, width);

                y = y + border + width;

                drawsquare(g, bcolor, initialx + 6 * width + 8 * border, y, width);
                drawsquare(g, bcolor, initialx + 7 * width + 9 * border, y, width);
                drawsquare(g, bcolor, initialx + 8 * width + 10 * border, y, width);

                y = y + border + width;

                drawsquare(g, bdr.color, initialx + 6 * width + 8 * border, y, width);
                drawsquare(g, bcolor, initialx + 7 * width + 9 * border, y, width);
                drawsquare(g, bdl.color, initialx + 8 * width + 10 * border, y, width);





            }
            else
            {
                drawsquare(g, ful.color, initialx, initialy, width);
                drawsquare(g, fcolor, initialx + width + border, initialy, width);
                drawsquare(g, fur.color, initialx + width + border + width + border, initialy, width);
                drawsquare(g, fcolor, initialx, initialy + width + border, width);
                drawsquare(g, fcolor, initialx + width + border, initialy + width + border, width);
                drawsquare(g, fcolor, initialx + width + border + width + border, initialy + width + border, width);
                drawsquare(g, fdl.color, initialx, initialy + width + border + width + border, width);
                drawsquare(g, fcolor, initialx + width + border, initialy + width + border + width + border, width);
                drawsquare(g, fdr.color, initialx + width + border + width + border, initialy + width + border + width + border, width);



                if (buffer == ufl)
                {
                    drawrect(g, ufl.color, initialx, initialy - border - width / 2, width, width / 2);
                    drawrect(g, luf.color, initialx - width / 2 - border, initialy, width / 2, width);
                }
                else
                {
                    drawrect(g, ufr.color, initialx + width + border + width + border, initialy - border - width / 2, width, width / 2);
                    drawrect(g, ruf.color, initialx + width + border + width + border + width + border, initialy, width / 2, width);
                }

            }






        }

        public void drawsquare(Graphics g, string x, int startx, int starty, int width)
        {
            string s = x;
            SolidBrush brush = new SolidBrush(Color.Red);
            if (s == "b")
                brush = new SolidBrush(Color.Blue);
            if (s == "o")
                brush = new SolidBrush(Color.Orange);
            if (s == "y")
                brush = new SolidBrush(Color.Yellow);
            if (s == "g")
                brush = new SolidBrush(Color.Green);
            if (s == "w")
                brush = new SolidBrush(Color.White);

            g.FillRectangle(brush, startx, starty, width, width);

        }
        public void drawrect(Graphics g, string x, int startx, int starty, int width, int height)
        {
            string s = x;
            SolidBrush brush = new SolidBrush(Color.Red);
            if (s == "b")
                brush = new SolidBrush(Color.Blue);
            if (s == "o")
                brush = new SolidBrush(Color.Orange);
            if (s == "y")
                brush = new SolidBrush(Color.Yellow);
            if (s == "g")
                brush = new SolidBrush(Color.Green);
            if (s == "w")
                brush = new SolidBrush(Color.White);

            g.FillRectangle(brush, startx, starty, width, height);

        }

        public void rotatex(bool direction) 
        {
            if(direction)
            {
                String temp = fcolor;
                fcolor = dcolor;
                dcolor = bcolor;
                bcolor = ucolor;
                ucolor = temp;
            }
            else
            {
                String temp = fcolor;
                fcolor = ucolor;
                ucolor = bcolor;
                bcolor = dcolor;
                dcolor = temp;
            }

            reset();
            

        }

        public void rotatey(bool direction)
        {
            if (direction)
            {
                String temp = fcolor;
                fcolor = rcolor;
                rcolor = bcolor;
                bcolor = lcolor;
                lcolor = temp;
            }
            else
            {
                String temp = fcolor;
                fcolor = lcolor;
                lcolor = bcolor;
                bcolor = rcolor;
                rcolor = temp;
            }

            reset();
        }

        public void rotatez(bool direction)
        {
            if (direction)
            {
                String temp = ucolor;
                ucolor = lcolor;
                lcolor = dcolor;
                dcolor = rcolor;
                rcolor = temp;
            }
            else
            {
                String temp = ucolor;
                ucolor = rcolor;
                rcolor = dcolor;
                dcolor = lcolor;
                lcolor = temp;
            }

            reset();
        }

        public String oppositecolor(String s)
        {
            if (s == "r")
                return "o";
            else if (rcolor == "o")
                return "r";
            else if (s == "y")
                return "w";
            else if (s == "w")
                return "y";
            else if (s == "b")
                return "g";
            else
                return "b";
        }



    }
}
