namespace LottoAnalysis
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Open = new System.Windows.Forms.Button();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Show_Result = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Show_Count = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Show_Cycle = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Show_AverageSum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Show_MinSum = new System.Windows.Forms.TextBox();
            this.Show_MaxSum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Text_FutureNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Show_Future = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Text_ProcessSerial = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Open
            // 
            this.Btn_Open.Location = new System.Drawing.Point(9, 27);
            this.Btn_Open.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Open.Name = "Btn_Open";
            this.Btn_Open.Size = new System.Drawing.Size(56, 18);
            this.Btn_Open.TabIndex = 0;
            this.Btn_Open.Text = "Open";
            this.Btn_Open.UseVisualStyleBackColor = true;
            this.Btn_Open.Click += new System.EventHandler(this.Btn_Open_Click);
            // 
            // Btn_Start
            // 
            this.Btn_Start.Location = new System.Drawing.Point(9, 58);
            this.Btn_Start.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(56, 18);
            this.Btn_Start.TabIndex = 1;
            this.Btn_Start.Text = "Start";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Show_Result
            // 
            this.Show_Result.FormattingEnabled = true;
            this.Show_Result.ItemHeight = 12;
            this.Show_Result.Location = new System.Drawing.Point(110, 27);
            this.Show_Result.Margin = new System.Windows.Forms.Padding(2);
            this.Show_Result.Name = "Show_Result";
            this.Show_Result.Size = new System.Drawing.Size(190, 280);
            this.Show_Result.TabIndex = 2;
            this.Show_Result.SelectedIndexChanged += new System.EventHandler(this.Show_Result_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "結果顯示";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "可能球數";
            // 
            // Show_Count
            // 
            this.Show_Count.Enabled = false;
            this.Show_Count.Location = new System.Drawing.Point(306, 25);
            this.Show_Count.Margin = new System.Windows.Forms.Padding(2);
            this.Show_Count.Name = "Show_Count";
            this.Show_Count.Size = new System.Drawing.Size(76, 22);
            this.Show_Count.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "大樂透",
            "大福彩",
            "威力彩",
            "今彩539",
            "雙贏彩"});
            this.comboBox1.Location = new System.Drawing.Point(9, 103);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(57, 20);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "大樂透";
            // 
            // Show_Cycle
            // 
            this.Show_Cycle.FormattingEnabled = true;
            this.Show_Cycle.ItemHeight = 12;
            this.Show_Cycle.Location = new System.Drawing.Point(402, 25);
            this.Show_Cycle.Margin = new System.Windows.Forms.Padding(2);
            this.Show_Cycle.Name = "Show_Cycle";
            this.Show_Cycle.Size = new System.Drawing.Size(144, 280);
            this.Show_Cycle.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "週期顯示";
            // 
            // Show_AverageSum
            // 
            this.Show_AverageSum.Enabled = false;
            this.Show_AverageSum.Location = new System.Drawing.Point(306, 67);
            this.Show_AverageSum.Margin = new System.Windows.Forms.Padding(2);
            this.Show_AverageSum.Name = "Show_AverageSum";
            this.Show_AverageSum.Size = new System.Drawing.Size(76, 22);
            this.Show_AverageSum.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "平均出球數";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "最低出球數";
            // 
            // Show_MinSum
            // 
            this.Show_MinSum.Enabled = false;
            this.Show_MinSum.Location = new System.Drawing.Point(306, 107);
            this.Show_MinSum.Margin = new System.Windows.Forms.Padding(2);
            this.Show_MinSum.Name = "Show_MinSum";
            this.Show_MinSum.Size = new System.Drawing.Size(76, 22);
            this.Show_MinSum.TabIndex = 12;
            // 
            // Show_MaxSum
            // 
            this.Show_MaxSum.Enabled = false;
            this.Show_MaxSum.Location = new System.Drawing.Point(306, 150);
            this.Show_MaxSum.Margin = new System.Windows.Forms.Padding(2);
            this.Show_MaxSum.Name = "Show_MaxSum";
            this.Show_MaxSum.Size = new System.Drawing.Size(76, 22);
            this.Show_MaxSum.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 136);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "最大出球數";
            // 
            // Text_FutureNumber
            // 
            this.Text_FutureNumber.Location = new System.Drawing.Point(96, 335);
            this.Text_FutureNumber.Name = "Text_FutureNumber";
            this.Text_FutureNumber.Size = new System.Drawing.Size(298, 22);
            this.Text_FutureNumber.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "預計出現的球";
            // 
            // Show_Future
            // 
            this.Show_Future.Enabled = false;
            this.Show_Future.Location = new System.Drawing.Point(306, 197);
            this.Show_Future.Name = "Show_Future";
            this.Show_Future.Size = new System.Drawing.Size(76, 22);
            this.Show_Future.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(306, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "推測成功球數";
            // 
            // Text_ProcessSerial
            // 
            this.Text_ProcessSerial.Location = new System.Drawing.Point(9, 168);
            this.Text_ProcessSerial.Name = "Text_ProcessSerial";
            this.Text_ProcessSerial.Size = new System.Drawing.Size(65, 22);
            this.Text_ProcessSerial.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 20;
            this.label9.Text = "要處理的期數";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 473);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Text_ProcessSerial);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Show_Future);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Text_FutureNumber);
            this.Controls.Add(this.Show_MaxSum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Show_MinSum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Show_AverageSum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Show_Cycle);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Show_Count);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Show_Result);
            this.Controls.Add(this.Btn_Start);
            this.Controls.Add(this.Btn_Open);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Open;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox Show_Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Show_Count;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox Show_Cycle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Show_AverageSum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Show_MinSum;
        private System.Windows.Forms.TextBox Show_MaxSum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Text_FutureNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Show_Future;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Text_ProcessSerial;
        private System.Windows.Forms.Label label9;
    }
}

