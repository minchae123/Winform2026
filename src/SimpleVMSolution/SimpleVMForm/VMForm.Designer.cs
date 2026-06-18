namespace SimpleVMForm
{
    partial class VMForm
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
            this.btnCoin = new System.Windows.Forms.Button();
            this.cbCoin = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChanges = new System.Windows.Forms.Button();
            this.lbChangesValue = new System.Windows.Forms.Label();
            this.lbChanges = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCoffee700 = new System.Windows.Forms.Button();
            this.btnCider300 = new System.Windows.Forms.Button();
            this.btnCoke500 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCoin);
            this.panel1.Controls.Add(this.cbCoin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 57);
            this.panel1.TabIndex = 0;
            // 
            // btnCoin
            // 
            this.btnCoin.Location = new System.Drawing.Point(327, 16);
            this.btnCoin.Name = "btnCoin";
            this.btnCoin.Size = new System.Drawing.Size(75, 23);
            this.btnCoin.TabIndex = 1;
            this.btnCoin.Text = "투입";
            this.btnCoin.UseVisualStyleBackColor = true;
            this.btnCoin.Click += new System.EventHandler(this.btnCoin_Click);
            // 
            // cbCoin
            // 
            this.cbCoin.FormattingEnabled = true;
            this.cbCoin.Location = new System.Drawing.Point(37, 18);
            this.cbCoin.Name = "cbCoin";
            this.cbCoin.Size = new System.Drawing.Size(239, 20);
            this.cbCoin.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnChanges);
            this.panel2.Controls.Add(this.lbChangesValue);
            this.panel2.Controls.Add(this.lbChanges);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 48);
            this.panel2.TabIndex = 1;
            // 
            // btnChanges
            // 
            this.btnChanges.Location = new System.Drawing.Point(327, 12);
            this.btnChanges.Name = "btnChanges";
            this.btnChanges.Size = new System.Drawing.Size(75, 23);
            this.btnChanges.TabIndex = 2;
            this.btnChanges.Text = "환전";
            this.btnChanges.UseVisualStyleBackColor = true;
            this.btnChanges.Click += new System.EventHandler(this.btnChanges_Click);
            // 
            // lbChangesValue
            // 
            this.lbChangesValue.AutoSize = true;
            this.lbChangesValue.Location = new System.Drawing.Point(88, 17);
            this.lbChangesValue.Name = "lbChangesValue";
            this.lbChangesValue.Size = new System.Drawing.Size(11, 12);
            this.lbChangesValue.TabIndex = 1;
            this.lbChangesValue.Text = "-";
            // 
            // lbChanges
            // 
            this.lbChanges.AutoSize = true;
            this.lbChanges.Location = new System.Drawing.Point(35, 17);
            this.lbChanges.Name = "lbChanges";
            this.lbChanges.Size = new System.Drawing.Size(41, 12);
            this.lbChanges.TabIndex = 0;
            this.lbChanges.Text = "잔액 : ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCoffee700);
            this.panel3.Controls.Add(this.btnCider300);
            this.panel3.Controls.Add(this.btnCoke500);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(455, 152);
            this.panel3.TabIndex = 2;
            // 
            // btnCoffee700
            // 
            this.btnCoffee700.Location = new System.Drawing.Point(327, 31);
            this.btnCoffee700.Name = "btnCoffee700";
            this.btnCoffee700.Size = new System.Drawing.Size(91, 93);
            this.btnCoffee700.TabIndex = 2;
            this.btnCoffee700.Text = "커피 700원";
            this.btnCoffee700.UseVisualStyleBackColor = true;
            this.btnCoffee700.Click += new System.EventHandler(this.btnCoffee700_Click);
            // 
            // btnCider300
            // 
            this.btnCider300.Location = new System.Drawing.Point(185, 31);
            this.btnCider300.Name = "btnCider300";
            this.btnCider300.Size = new System.Drawing.Size(91, 93);
            this.btnCider300.TabIndex = 1;
            this.btnCider300.Text = "사이다 300원";
            this.btnCider300.UseVisualStyleBackColor = true;
            this.btnCider300.Click += new System.EventHandler(this.btnCider300_Click);
            // 
            // btnCoke500
            // 
            this.btnCoke500.Location = new System.Drawing.Point(37, 31);
            this.btnCoke500.Name = "btnCoke500";
            this.btnCoke500.Size = new System.Drawing.Size(91, 93);
            this.btnCoke500.TabIndex = 0;
            this.btnCoke500.Text = "콜라 500원";
            this.btnCoke500.UseVisualStyleBackColor = true;
            this.btnCoke500.Click += new System.EventHandler(this.btnCoke500_Click);
            // 
            // VMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 257);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "VMForm";
            this.Text = "202530416 이민채";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCoin;
        private System.Windows.Forms.ComboBox cbCoin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCoffee700;
        private System.Windows.Forms.Button btnCider300;
        private System.Windows.Forms.Button btnCoke500;
        private System.Windows.Forms.Label lbChanges;
        private System.Windows.Forms.Label lbChangesValue;
        private System.Windows.Forms.Button btnChanges;
    }
}

