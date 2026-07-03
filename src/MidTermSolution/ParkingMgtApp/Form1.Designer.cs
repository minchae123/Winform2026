namespace ParkingMgtApp
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbBox_CarList = new System.Windows.Forms.ComboBox();
            this.btn_CarIn = new System.Windows.Forms.Button();
            this.btn_CarOut = new System.Windows.Forms.Button();
            this.lbCnt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.recordList = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_CarOut);
            this.panel1.Controls.Add(this.btn_CarIn);
            this.panel1.Controls.Add(this.cbBox_CarList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 36);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.recordList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(505, 342);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lbCnt);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 349);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(505, 29);
            this.panel3.TabIndex = 2;
            // 
            // cbBox_CarList
            // 
            this.cbBox_CarList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBox_CarList.FormattingEnabled = true;
            this.cbBox_CarList.Location = new System.Drawing.Point(204, 7);
            this.cbBox_CarList.Name = "cbBox_CarList";
            this.cbBox_CarList.Size = new System.Drawing.Size(128, 20);
            this.cbBox_CarList.TabIndex = 0;
            // 
            // btn_CarIn
            // 
            this.btn_CarIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CarIn.Location = new System.Drawing.Point(338, 5);
            this.btn_CarIn.Name = "btn_CarIn";
            this.btn_CarIn.Size = new System.Drawing.Size(75, 23);
            this.btn_CarIn.TabIndex = 1;
            this.btn_CarIn.Text = "입차";
            this.btn_CarIn.UseVisualStyleBackColor = true;
            // 
            // btn_CarOut
            // 
            this.btn_CarOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CarOut.Location = new System.Drawing.Point(419, 5);
            this.btn_CarOut.Name = "btn_CarOut";
            this.btn_CarOut.Size = new System.Drawing.Size(75, 23);
            this.btn_CarOut.TabIndex = 2;
            this.btn_CarOut.Text = "출차";
            this.btn_CarOut.UseVisualStyleBackColor = true;
            // 
            // lbCnt
            // 
            this.lbCnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCnt.AutoSize = true;
            this.lbCnt.Location = new System.Drawing.Point(478, 8);
            this.lbCnt.Name = "lbCnt";
            this.lbCnt.Size = new System.Drawing.Size(11, 12);
            this.lbCnt.TabIndex = 0;
            this.lbCnt.Text = "-";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "현재 차량 대수 : ";
            // 
            // recordList
            // 
            this.recordList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recordList.FormattingEnabled = true;
            this.recordList.HorizontalScrollbar = true;
            this.recordList.ItemHeight = 12;
            this.recordList.Location = new System.Drawing.Point(0, 0);
            this.recordList.Name = "recordList";
            this.recordList.Size = new System.Drawing.Size(505, 342);
            this.recordList.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 378);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "202530416 이민채";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbBox_CarList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_CarIn;
        private System.Windows.Forms.Button btn_CarOut;
        private System.Windows.Forms.Label lbCnt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox recordList;
    }
}

