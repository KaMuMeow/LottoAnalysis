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
namespace LottoAnalysis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NumberBall[] NumberList;
        int[] Future;
        string[] NumberSerial = new string[100];
        private void Start_Analysis()
        {
            int NumberSum = 49;
            switch (comboBox1.SelectedItem.ToString())
            {
                case "大樂透":
                    NumberSum = 49;
                    break;
                case "威力彩":
                    NumberSum = 38;
                    break;
                case "大福彩":
                    NumberSum = 40;
                    break;
                case "今彩539":
                    NumberSum = 39;
                    break;
                case "雙贏彩":
                    NumberSum = 24;
                    break;
            }

            //用來分析準確度使用，若沒有要分析準確度則不管她
            if (Text_FutureNumber.Text != "")
            {
                string[] Tmp = Text_FutureNumber.Text.Split(',');
                Future = new int[Tmp.Length];
                for (int i = 0; i < Tmp.Length; i++)
                    Future[i] = int.Parse(Tmp[i]);
            }

            NumberList = new NumberBall[NumberSum + 1];
            for (int i = 0; i <= NumberSum; i++)
            {
                NumberList[i] = new NumberBall();
                NumberList[i].Number = i;
            }
            StreamReader Read = new StreamReader(openFileDialog1.FileName);
            int Serial = 0;//紀錄目前期數
            string s = "";
            int TmpCount = 0;
            while (Read.Peek() != -1)
            {
                s = Read.ReadLine();
                NumberSerial[TmpCount] = s;
                TmpCount++;
                if (TmpCount == NumberSerial.Length)
                {
                    Array.Resize(ref NumberSerial, NumberSerial.Length + 100);
                }
            }
            int ProcessSerial = 0;
            if (Text_ProcessSerial.Text != "")
            {
                ProcessSerial = int.Parse(Text_ProcessSerial.Text);
                if (ProcessSerial > TmpCount)
                {
                    ProcessSerial = 0;
                    MessageBox.Show("總期數小於要處理的期數", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else ProcessSerial = TmpCount - ProcessSerial;

            }
            for (int i = ProcessSerial; i < TmpCount; i++)
            {
                s = NumberSerial[i];
                //僅取出有Number序列的才做字串分割
                if (s.IndexOf("Number") != -1)
                {
                    Serial++;
                    s = s.Substring(s.IndexOf(":") + 1, s.Length - s.IndexOf(":") - 1);
                    string[] result = s.Replace("#", "").Split(',');
                    for (int x = 0; x < result.Length; x++)
                    {
                        int Tmps = int.Parse(result[x]);
                        NumberList[Tmps].sum++;
                        if (NumberList[Tmps].lastFound == 0)
                        {
                            //若還沒出現週期則記錄下來
                            NumberList[Tmps].lastFound = Serial;
                        }
                        else
                        {
                            //將最後出現的週期與現在的週期相減，放入週期序列內
                            NumberList[Tmps].Cycle((Serial - NumberList[Tmps].lastFound).ToString());
                            NumberList[Tmps].lastFound = Serial;
                        }
                    }
                }
            }
            int TmpAverage = 0;
            int TmpMaxSum = NumberList[1].sum;
            int TmpMinSum = NumberList[1].sum;
            //更新最後一次出現的位置
            for (int i = 1; i <= NumberSum; i++)
            {
                //順便計算所有次數的加總
                TmpAverage += NumberList[i].sum;

                NumberList[i].Cycle((Serial - NumberList[i].lastFound).ToString());
                if (NumberList[i].sum < TmpMinSum)
                    TmpMinSum = NumberList[i].sum;
                if (NumberList[i].sum > TmpMaxSum)
                    TmpMaxSum = NumberList[i].sum;
            }
            TmpAverage /= NumberSum;
            //將加總平均值放入給每一顆球
            for (int i = 1; i < NumberSum; i++)
            {
                NumberList[i].averageSum = TmpAverage;
            }
            Show_Result.Items.Clear();
            int count = 0;
            TmpCount = 0;//計算預測成功的球數
            //將最後出現的數字記錄下來
            for (int i = 1; i <= NumberSum; i++)
            {
                int number = NumberList[i].analysis();
                if (number != 0 && NumberList[i].lastFound - Serial != 0)
                {
                    Show_Result.Items.Add(number.ToString("00") + "號" + " 出現次數為: " + NumberList[i].sum);
                    count++;
                    if (Future != null)
                        for (int x = 0; x < Future.Length; x++)
                        {
                            if (Future[x] == number)
                                TmpCount++;

                        }
                }
                else
                {
                    NumberList[i].Last = true;
                }
            }

            Show_AverageSum.Text = TmpAverage.ToString();
            Show_MaxSum.Text = TmpMaxSum.ToString();
            Show_MinSum.Text = TmpMinSum.ToString();
            Show_Count.Text = count.ToString();
            Show_Future.Text = TmpCount.ToString();
            Read.Close();
        }

        private void Btn_Open_Click(object sender, EventArgs e)
        {
            DialogResult YesOrNo = openFileDialog1.ShowDialog();
            if (YesOrNo == DialogResult.OK)
            {
                Start_Analysis();
            }
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            Start_Analysis();
        }

        private void Show_Result_SelectedIndexChanged(object sender, EventArgs e)
        {
            //顯示數字的週期
            if (Show_Result.SelectedIndex != -1)
            {
                Show_Cycle.Items.Clear();
                //取出要看的號碼
                int tmpNumber = int.Parse(Show_Result.SelectedItem.ToString().Substring(0, 2));
                foreach (int C in NumberList[tmpNumber].GetCycle())
                {
                    if (C != 0)
                    {
                        Show_Cycle.Items.Add(C);
                    }
                }
            }
        }

    }
}
