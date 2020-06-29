using System;

namespace final_project
{
    class Program
    {
        static void Main(string[] args)
        {
            bool judge = true; //作為是否選對選項的判斷
            int ans = 0;  //回答
            while (judge)
            {
                Console.WriteLine("世界上最難的10道選擇題");
                Console.WriteLine("1)Begin  2)Exit");
                ans = int.Parse(Console.ReadLine()); //將回答回傳到"回答"
                if(ans == 1 || ans == 2)
                {
                    judge = false; //用IF去判斷是否選對選項
                }
            }
            switch(ans)
            {
                case 1:
                    {
                        Console.WriteLine("---------------------------------------");
                        Toproblem();//進入問題
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Exit");//直接退出
                        break;
                    }
            }
            Console.WriteLine("結束囉！");//結束提醒
            Console.Read();//讓整個逞是在最後停一下
        }
        static int choose1 = 0;//計算選1的個數
        static int choose2 = 0;//計算選2的個數
        static void Toproblem()
        {
            int ans2;//用於存取答案的地方
            for (int i =1; i <11; i++)
            {
                switch (i)
                {
                    case 1:
                        {
                            Console.WriteLine("第一題");
                            Console.WriteLine("1)找到真愛  2)中10萬美元大獎");
                            ans2 = int.Parse(Console.ReadLine());//讀取答案並回傳到"答案2"
                            Console.WriteLine("---------------------------------------");
                            if (ans2 == 1)
                            {
                                choose1++;//回答1則選1的增加一個
                            }
                            else if (ans2 == 2)
                            {
                                choose2++;//回答2則選2的增加一個
                            }
                            else
                            {
                                Console.WriteLine("此題不算！");//若是選擇非1或2就不算數
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("第二題");
                            Console.WriteLine("1)將名字合法改為希特勒  2)再也不吃甜點");
                            ans2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("---------------------------------------");
                            if (ans2 == 1)
                            {
                                choose1++;
                            }
                            else if (ans2 == 2)
                            {
                                choose2++;
                            }
                            else
                            {
                                Console.WriteLine("此題不算！");
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("第三題");
                            Console.WriteLine("1)沒有網路  2)沒有朋友");
                            ans2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("---------------------------------------");
                            if (ans2 == 1)
                            {
                                choose1++;
                            }
                            else if (ans2 == 2)
                            {
                                choose2++;
                            }
                            else
                            {
                                Console.WriteLine("此題不算！");
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("第四題");
                            Console.WriteLine("1)被騙  2)騙人");
                            ans2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("---------------------------------------");
                            if (ans2 == 1)
                            {
                                choose1++;
                            }
                            else if (ans2 == 2)
                            {
                                choose2++;
                            }
                            else
                            {
                                Console.WriteLine("此題不算！");
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("第五題");
                            Console.WriteLine("1)通過自殺來拯救其他人  2)殺害其他人來拯救自己");
                            ans2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("---------------------------------------");
                            if (ans2 == 1)
                            {
                                choose1++;
                            }
                            else if (ans2 == 2)
                            {
                                choose2++;
                            }
                            else
                            {
                                Console.WriteLine("此題不算！");
                            }
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("第六題");
                            Console.WriteLine("1)患帕金森  2)殺死十隻小貓");
                            ans2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("---------------------------------------");
                            if (ans2 == 1)
                            {
                                choose1++;
                            }
                            else if (ans2 == 2)
                            {
                                choose2++;
                            }
                            else
                            {
                                Console.WriteLine("此題不算！");
                            }
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("第七題");
                            Console.WriteLine("1)一年不看自己喜歡的電視節目  2)一周只吃番茄醬");
                            ans2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("---------------------------------------");
                            if (ans2 == 1)
                            {
                                choose1++;
                            }
                            else if (ans2 == 2)
                            {
                                choose2++;
                            }
                            else
                            {
                                Console.WriteLine("此題不算！");
                            }
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("第八題");
                            Console.WriteLine("1)知道自己何時去世  2)知道自己如何去世");
                            ans2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("---------------------------------------");
                            if (ans2 == 1)
                            {
                                choose1++;
                            }
                            else if (ans2 == 2)
                            {
                                choose2++;
                            }
                            else
                            {
                                Console.WriteLine("此題不算！");
                            }
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("第九題");
                            Console.WriteLine("1)預知未來  2)改變過去");
                            ans2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("---------------------------------------");
                            if (ans2 == 1)
                            {
                                choose1++;
                            }
                            else if (ans2 == 2)
                            {
                                choose2++;
                            }
                            else
                            {
                                Console.WriteLine("此題不算！");
                            }
                            break;
                        }
                    case 10:
                        {
                            Console.WriteLine("第十題");
                            Console.WriteLine("1)一整天聞起來都像屎，但別人聞不到  2)聞起來像屎，但自己不知道");
                            ans2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("---------------------------------------");
                            if (ans2 == 1)
                            {
                                choose1++;
                            }
                            else if (ans2 == 2)
                            {
                                choose2++;
                            }
                            else
                            {
                                Console.WriteLine("此題不算！");
                            }
                            break;
                        }
                }
            }
            if(choose1+choose2 != 10)
            {
                Console.WriteLine("有題目不算，因此此次測驗不準確！");//如果選擇的結果不足10題，整個題組就不算數
            }
            if(choose1+choose2 ==10)//判斷是否有選滿10題
            {
                if (choose1 > choose2)
                {
                    Console.WriteLine("恭喜你，你是個無私的人，很會為別人考慮！");//如果選1的多於選2的則輸出結果
                }
                if (choose2 > choose1)
                {
                    Console.WriteLine("你是相對比較自私，自己的感受才是排第一的！");//如果選2的多於選1的則輸出結果
                }
                if (choose1 == choose2)
                {
                    Console.WriteLine("你是個在無私與自私之間拔河的人！");//如果選1跟選2的依樣多則輸出結果
                }
            }
        }
    }
}
