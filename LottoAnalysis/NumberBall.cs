using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoAnalysis
{
    class NumberBall
    {
        private int number; //紀錄號碼
        public int sum;//紀錄出現次數
        public int averageSum = 0;//記錄所有球的平均出現次數
        private int averageLong; //紀錄長週期的平均長度
        private int averageShort; //記錄短周期的平均長度
        private int longCount; //計算長周期出現的次數
        private int shortCount; //計算短周期出現的次數
        private int maxLong;//紀錄最長周期
        private int minShort;//紀錄最短周期
        private int maxTwoLong;
        private int minCount;//計算短周期出現的次數
        private int minTwoShort;
        private string cycle; //紀錄週期
        private int[] CycleValue;
        public int lastFound;//計算最後出現的位置
        private bool last;//紀錄是否最後有出現
        private bool recent;//最近是否出現過1周內出現;
        public NumberBall()
        {
            number = 0;
            sum = 0;
            averageSum = 0;
            averageLong = 0;
            averageShort = 0;
            longCount = 0;
            shortCount = 0;
            maxLong = 0;
            minShort = 0;
            minCount = 0;
            lastFound = 0;
            last = false;
            cycle="";
        }

        public bool Last
        {
            get
            {
                return last;
            }
            set
            {
                last = value;
            }
        }

        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
        //回傳數值陣列型態的週期表
        public int[] GetCycle()
        {
            if (CycleValue != null)
            {
                return CycleValue;
            }
            else
                return null;
        }
        public void Cycle(string s)
        {
            cycle+=s+",";
        }
        //開始分析現有的資料
        public int analysis()
        {
            //先將週期的字串分割
            string[] CycleSplit = cycle.Split(',');
            //將存放週期數值的陣列初始化
            CycleValue = new int[CycleSplit.Length];
            int Tmp=0;
            foreach(string C in CycleSplit)
            {
                try
                {
                    //將字串型態的週期轉換成數字型態放入陣列
                    CycleValue[Tmp] = int.Parse(C);
                    Tmp++;
                }catch
                {

                }
            }
            //開始找尋最大週期以及最小週期
            //找尋第二大的周期以及第二小的周期
            maxLong = CycleValue[0];
            minShort = CycleValue[0];
            maxTwoLong = CycleValue[0];
            minTwoShort = CycleValue[0];
            foreach(int C in CycleValue)
            {
                if(C>maxLong)
                {
                    maxLong = C;
                }
                if(C<minShort)
                {
                    minShort = C;
                }

                if(C>maxTwoLong && C<maxLong)
                {
                    maxTwoLong = C;
                }

                if(C<minTwoShort && C>minShort)
                {
                    minTwoShort = C;
                }
            }
            //將最大最小週期以及第二大二小周期都相加除二，取出最中間的值
            int average = ((maxLong + minShort) / 2 + (maxTwoLong+minTwoShort)/2)/2;
            int tmpCountMin=0;
            //計算最大的平均週期以及最小的平均週期
            foreach(int C in CycleValue)
            {
                //若都不相等則將兩周期都相加這次週期
                if(C>average)
                {
                    averageLong+=C;
                    longCount++;
                    tmpCountMin = 0;
                }else if(C<average)
                {
                    averageShort+=C;
                    shortCount++;
                    tmpCountMin++;
                    if (tmpCountMin > minCount)
                        minCount = tmpCountMin;
                }else
                {
                    averageLong += C;
                    averageShort += C;
                    longCount++;
                    shortCount++;
                }
            }
            //找尋最近5期內是否有連續出現過1若則近期內可能再次出現
            int tmpCount = 0;
            //週期數大於5才執行這一段
            if (CycleValue.Length > 5)
            {
                for (int i = 1; i <= 5; i++)
                {
                    if (CycleValue[CycleValue.Length - 1 - i] == 1)
                    {
                        tmpCount++;
                    }
                    else
                        tmpCount = 0;
                    if (tmpCount >= 2)
                    {
                        recent = true;
                    }
                }
            }else
            {
                recent = false; 
            }
            averageLong /= longCount;
            averageShort /= shortCount;
            int LastCycle = CycleValue[CycleValue.Length - 2];
            //若最後的出現週期，只要不是最後一次出現的次數，且週期大於最大平均周期或最小平均週期就輸出
            if (LastCycle - averageLong>=-1 && !last)
            {
                return number;
            }
            else if (recent||LastCycle - averageShort<=5 && LastCycle>=averageShort && !last)
            {
                return number;
            }
            else
                return 0;
        }


    }
}
