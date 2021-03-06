/*
這裡是一段兩行的程式碼,他的用途是把一堆byte資料統整集合成一個int或其他整數型態
其原理為
假設要把 24 23 22 00 這四個byte整合成一個int
則把

第一個的二進位碼位移0 * 8 = 00 00 00 24(Hex)
第二個的二進位碼位移1 * 8 = 00 00 23 00(Hex)
第三個的二進位碼位移2 * 8 = 00 22 00 00(Hex)
第四個的二進位碼位移3 * 8 = 00 00 00 00(Hex)
最後把他們加起來就是答案    00 22 23 24

(用8是因為一個byte可容納256(16^2)個資料)
*/

//prepare
byte[] bytes = new byte[]{24,23,22,00};
int ans = 0;
//for 迴圈
for (int i = 0; i < 4; i++)
  ans += bytes[i] << i * 2 * 4;
//foreach
int t = 0;
foreach(var b in bytes)
  ans += bytes[i] << t++ * 2 * 4;
