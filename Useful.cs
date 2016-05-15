/*
如果要開n根號,可以寫
a^(1/n)
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
