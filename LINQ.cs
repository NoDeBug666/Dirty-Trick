/*
LINQ 可用於快速的針對支援的儲存物件進行查詢
*/
int[] score = 
{
  1,20,53,23,12,45,98,
  35,65,84,95,12,45,45,
  56,56,87,87,78,42,12
};
IEnumerable<int> data = 
  from res in score
  where res >= 60
  orderby res
  select res;
/*
from res 解釋做接下來讀取的資料代名為res
in score 解釋做資料來自score陣列
where res >= 60 解釋做從資料來源中抓取滿組 res >= 60的資料
orderby res 解釋做由res做排序
select res 解釋做結束查詢
*/

/*
LINQ的查詢可以是動態的,這意味著如果你先設好了LINQ查詢,
後面資料來源如果發生了甚麼變動,LINQ的呼叫結果也會跟著改變,
注意如對LINQ查詢用函式 ToArray() ToList() ToEnumerable() 會切斷和資料源的關聯
*/

