/*
如果要開n根號,可以寫
a^(1.0/n)
需要注意"項次"的部分,被除數ㄧ定要轉浮點,用整數處理會永遠為0
*/
double result0 = Math.Pow( Input , (1.0 / 8) );

/*
要取顯示某數到小數點第N(2)位,可以寫
會自動四捨五入
*/
double Data;
string result1 = String.Format("{0:F2}",Data);
string result2 = Data.ToString("0.00");

/*
在C#中使用部件 DataGridView ,想要限制其Column不能排序
*/
this.dataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;

/*
擴展方法:
在C#中,要給一個現成的物件多一些function,如給string增加東西
可利用擴展方法
*/
public static void ExtensionFunc(this string s){
  Console.WriteLine("[{0}]This is a Extension function.",s);
}
string str = "666";
str.ExtensionFunc();

/*
如果有複雜的運算式,如Bitwise
可以選擇把他們分行運算,避免運算符優先順序導致錯誤
或是太多括弧看到眼花
*/
int dat = 666;
int a1 = 1 << (32 - basic);
a1--;
a1 = ~a1;
a1 = dat & a1;

/*
Graphic繪圖
如果繪圖時,發現有數字或任何東西畫到圖片範圍之外,想要不動大部分程式碼修正
可以使用重新定義Transform還有擴大圖片大小
*/
Bitmap bmp = new Bitmap(400+10,380);   //擴大你的圖片
g.TranslateTransform(10, 0, System.Drawing.Drawing2D.MatrixOrder.Append); //更改起點座標

/*
Graphic.DrawString
可以定義要以置左對齊還是置右置中
Far 置右
Near 置左(預設)
Center 置中
如果要控制 垂直方向 ,更改LineAlignment
*/
g.DrawString("HelloWorld", this.Font, Brushes.Black, 30, p.Y,
              new StringFormat() { Alignment = StringAlignment.Far});

/*
階乘 自動增長table版本
*/
static List<double> table = new List<double>()
{
  1
};
 static double fiaction(int sec)
{
    //如果值已經存在,直接套用
     if (table.Count > sec)
         return table[sec];
    //不存在則一直創建直到到達
    int index = table.Count-1;
    while (index <= sec)
      table.Add(table[index] * ++index);
    return table[sec];
}
