        void DrawScreen()
        {
            plist.Add(new PointF(1000, 1000));
            plist.Add(new PointF(0, 0));
            var bmp = new Bitmap(500, 500);
            var g = Graphics.FromImage(bmp);

            float bound = 20;
            int DatMaximum = 1000;
            float Trans = 460f / DatMaximum;   // 畫布大小 / 原始大小 = 調整倍率

            //Basic screen
            g.Clear(Color.Gray);
            g.FillRectangle(Brushes.White, bound, bound, 500 - bound * 2, 500 - bound * 2);
            g.DrawRectangle(Pens.Black, bound, bound, 500 - bound * 2, 500 - bound * 2);

            //轉換
            var arr = plist.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].X = bound + arr[i].X * Trans;
                arr[i].Y = 500 - bound - (arr[i].Y * Trans);
            }
            //數據尺度
            Pen pe = new Pen(Brushes.Black){ DashStyle = System.Drawing.Drawing2D.DashStyle.Dash};
            for (int i = 0,t = 0; i <= DatMaximum; i+=50,t++)
            {
                float ft = 480 - (i * Trans);
                g.DrawLine(pe, 20,ft, 480,ft);
                g.DrawString(String.Format("{0,4}", i), this.Font, Brushes.Black, -2, ft - 5);
                if (i == 0)
                    continue;
                ft = i*Trans+20;
                g.DrawLine(pe,ft,20, ft,480);
                g.DrawString(String.Format("{0}", i), this.Font, Brushes.Black,ft-(int)(Math.Log10(i)+1)*4,485);
            }


            //如要由左至右連線,先Sort
            Array.Sort(arr, delegate(PointF a, PointF b) { return a.X.CompareTo(b.X); });

            //Inner
            PointF last = new PointF(-1, -1);
            foreach (var p in arr)
            {
                //X座標 = Bound + Position * Trans - CircleSize
                //Y座標 = 500 - Bound - ( Position * Trans + CircleSize)
                g.DrawEllipse(Pens.Black, p.X - 3, p.Y - 3, 6, 6);
                if (last.X != -1)
                    g.DrawLine(Pens.Black, last, p);
                last = p;
            }

            //Release
            g.Dispose();
            pictureBox1.Image = bmp;
        }
        void DrawScreen2()
        {
            Bitmap bmp = new Bitmap(500, 500);
            var g = Graphics.FromImage(bmp);

            // bound = 20
            float Trans = 460f / 1000f;

            g.Clear(Color.Gray);
            g.FillRectangle(Brushes.White, 20, 20, 460, 460);
            g.DrawRectangle(Pens.Black, 20, 20, 460, 460);

            //grand
            Pen pe = new Pen(Color.Black) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash };
            for (int i = 0, t = 0; i <= 1000; i += 50, t++)
            {
                float ft = 480 - (i * Trans);
                g.DrawLine(pe, 20, ft, 480, ft);
                g.DrawString(String.Format("{0,4}", i), this.Font, Brushes.Black, -2, ft);
                if (i == 0)
                    continue;
                ft = i * Trans+20;
                g.DrawLine(pe, ft, 20, ft, 480);
                g.DrawString(String.Format("{0}", i), this.Font, Brushes.Black, ft-(int)(Math.Log10(i)+1)*4,485);
            }

            //array
            var arr = plist.ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].X = arr[i].X * Trans + 20;
                arr[i].Y = 480 - (arr[i].Y * Trans);
            }

            //sort
            Array.Sort(arr, delegate(PointF p1, PointF p2)
            {
                return p1.X.CompareTo(p2.X);
            });

            //dot on
            PointF last = new PointF(-1, -1);
            foreach (var p in arr)
            {
                g.DrawEllipse(Pens.Red, p.X - 3, p.Y - 3, 6, 6);
                if (last.X != -1)
                    g.DrawLine(Pens.Blue, last, p);
                last = p;
            }

            g.Dispose();
            pictureBox1.Image = bmp;
        }
        void DrawScreen3(int sight = 1000)
        {
            //bmp
            var bmp = new Bitmap(500, 500);
            var g = Graphics.FromImage(bmp);
            float trans = 500f / 2f / sight;
                
            //background
            g.Clear(Color.White);
            g.DrawLine(Pens.Black, 0, 250, 500, 250);
            g.DrawLine(Pens.Black, 250, 0, 250, 500);

            //draw
            PointF last = new PointF(1 << 30, 0);
            for (int i = 0; i <= 500; i++)
            {
                float y = 0;
                if (trans > 1)
                {
                    int j = 0;
                    for(j = 0;j < trans;j++)
                        y += function((i-250) * trans + j);
                    y /= j;
                }
                else
                    y = function((i-250) * trans);
                PointF p = new PointF(i, 250 - y);
                if (last.X != 1 << 30)
                    g.DrawLine(Pens.Red, p, last);
                last = p;
               
            }

                //finish
            g.Dispose();
            pictureBox1.Image = bmp;
        }
