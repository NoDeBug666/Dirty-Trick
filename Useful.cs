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
