namespace LMC_FBLProject
{
    partial class MainForm
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MiddlePanel = new System.Windows.Forms.Panel();
            this.istActivities = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbActivity = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtLearned = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.TopPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.MiddlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TopPanel.Controls.Add(this.Title);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(775, 61);
            this.TopPanel.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Title.Location = new System.Drawing.Point(290, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(160, 37);
            this.Title.TabIndex = 0;
            this.Title.Text = "활동 정리🏠";
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RightPanel.Controls.Add(this.btnDelete);
            this.RightPanel.Controls.Add(this.btnEdit);
            this.RightPanel.Controls.Add(this.txtLearned);
            this.RightPanel.Controls.Add(this.txtContent);
            this.RightPanel.Controls.Add(this.label5);
            this.RightPanel.Controls.Add(this.label4);
            this.RightPanel.Controls.Add(this.label3);
            this.RightPanel.Controls.Add(this.lbDate);
            this.RightPanel.Controls.Add(this.lbActivity);
            this.RightPanel.Controls.Add(this.lbCategory);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(475, 61);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(300, 361);
            this.RightPanel.TabIndex = 1;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.btnLoad);
            this.LeftPanel.Controls.Add(this.btnSave);
            this.LeftPanel.Controls.Add(this.btnAdd);
            this.LeftPanel.Controls.Add(this.btnAll);
            this.LeftPanel.Controls.Add(this.label1);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LeftPanel.Location = new System.Drawing.Point(0, 61);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(145, 361);
            this.LeftPanel.TabIndex = 2;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLoad.Location = new System.Drawing.Point(12, 252);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(122, 47);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "불러오기";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(12, 199);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 47);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "저장하기";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAdd.Location = new System.Drawing.Point(12, 146);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 47);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+ 새 활동";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnAll
            // 
            this.btnAll.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAll.Location = new System.Drawing.Point(12, 42);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(122, 47);
            this.btnAll.TabIndex = 1;
            this.btnAll.Text = "전체 활동";
            this.btnAll.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "활동 관리";
            // 
            // MiddlePanel
            // 
            this.MiddlePanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MiddlePanel.Controls.Add(this.istActivities);
            this.MiddlePanel.Controls.Add(this.label2);
            this.MiddlePanel.Controls.Add(this.cboCategory);
            this.MiddlePanel.Controls.Add(this.txtSearch);
            this.MiddlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiddlePanel.Location = new System.Drawing.Point(145, 61);
            this.MiddlePanel.Name = "MiddlePanel";
            this.MiddlePanel.Size = new System.Drawing.Size(330, 361);
            this.MiddlePanel.TabIndex = 3;
            // 
            // istActivities
            // 
            this.istActivities.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.istActivities.FormattingEnabled = true;
            this.istActivities.ItemHeight = 12;
            this.istActivities.Location = new System.Drawing.Point(29, 156);
            this.istActivities.Name = "istActivities";
            this.istActivities.ScrollAlwaysVisible = true;
            this.istActivities.Size = new System.Drawing.Size(276, 184);
            this.istActivities.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "활동 목록";
            // 
            // cboCategory
            // 
            this.cboCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(29, 92);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(276, 20);
            this.cboCategory.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(29, 33);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(276, 40);
            this.txtSearch.TabIndex = 0;
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbCategory.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbCategory.Location = new System.Drawing.Point(7, 7);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(49, 11);
            this.lbCategory.TabIndex = 0;
            this.lbCategory.Text = "카테고리";
            // 
            // lbActivity
            // 
            this.lbActivity.AutoSize = true;
            this.lbActivity.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbActivity.Location = new System.Drawing.Point(6, 24);
            this.lbActivity.Name = "lbActivity";
            this.lbActivity.Size = new System.Drawing.Size(81, 16);
            this.lbActivity.TabIndex = 1;
            this.lbActivity.Text = "활동 제목";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbDate.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbDate.Location = new System.Drawing.Point(7, 46);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(59, 11);
            this.lbDate.TabIndex = 2;
            this.lbDate.Text = "2026.01.01";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "---------------------------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(7, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 11);
            this.label4.TabIndex = 4;
            this.label4.Text = "활동 내용";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(7, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 11);
            this.label5.TabIndex = 5;
            this.label5.Text = "배운 점";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(9, 93);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(269, 76);
            this.txtContent.TabIndex = 6;
            // 
            // txtLearned
            // 
            this.txtLearned.Location = new System.Drawing.Point(9, 190);
            this.txtLearned.Multiline = true;
            this.txtLearned.Name = "txtLearned";
            this.txtLearned.Size = new System.Drawing.Size(269, 76);
            this.txtLearned.TabIndex = 7;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEdit.Location = new System.Drawing.Point(9, 272);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(127, 35);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "수정";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete.Location = new System.Drawing.Point(151, 272);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 35);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 422);
            this.Controls.Add(this.MiddlePanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.TopPanel);
            this.Name = "MainForm";
            this.Text = "활동 정리🏠";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            this.RightPanel.PerformLayout();
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.MiddlePanel.ResumeLayout(false);
            this.MiddlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel MiddlePanel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ListBox istActivities;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbActivity;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtLearned;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

