namespace PsVDecrypt
{
    partial class MainGui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGui));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.InputPathButton = new System.Windows.Forms.Button();
            this.inputPathLabel = new System.Windows.Forms.Label();
            this.outputPathLabel = new System.Windows.Forms.Label();
            this.sameLocationAskingLabal = new System.Windows.Forms.Label();
            this.OutPutPathButton = new System.Windows.Forms.Button();
            this.InputPathTextBox = new System.Windows.Forms.TextBox();
            this.OutPutPathText = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.convertButton = new System.Windows.Forms.Button();
            this.listCousesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.availableCourseNoticeLabel = new System.Windows.Forms.Label();
            this.srcOpenButton = new System.Windows.Forms.Button();
            this.selectNoticeLabel = new System.Windows.Forms.Label();
            this.dstOpenButton = new System.Windows.Forms.Button();
            this.LabelBak01 = new System.Windows.Forms.Label();
            this.LabelBak3 = new System.Windows.Forms.Label();
            this.sameLocationCheck = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.coursesListBox = new System.Windows.Forms.ListBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.LabelBak2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.72727F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.54546F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.72727F));
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.InputPathButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.inputPathLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.outputPathLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.sameLocationAskingLabal, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.OutPutPathButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.InputPathTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.OutPutPathText, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.LabelBak01, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.LabelBak3, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.sameLocationCheck, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.LabelBak2, 1, 5);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(883, 626);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.nameLabel, 3);
            this.nameLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(3, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(877, 16);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "PsvDecryptor GUI";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputPathButton
            // 
            this.InputPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputPathButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputPathButton.Location = new System.Drawing.Point(773, 19);
            this.InputPathButton.Name = "InputPathButton";
            this.InputPathButton.Size = new System.Drawing.Size(107, 26);
            this.InputPathButton.TabIndex = 1;
            this.InputPathButton.Text = "Browse...";
            this.InputPathButton.UseVisualStyleBackColor = true;
            this.InputPathButton.Click += new System.EventHandler(this.InputPathButton_Click);
            // 
            // inputPathLabel
            // 
            this.inputPathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPathLabel.AutoSize = true;
            this.inputPathLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPathLabel.Location = new System.Drawing.Point(3, 16);
            this.inputPathLabel.Name = "inputPathLabel";
            this.inputPathLabel.Size = new System.Drawing.Size(106, 32);
            this.inputPathLabel.TabIndex = 2;
            this.inputPathLabel.Text = "Input Folder";
            this.inputPathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputPathLabel
            // 
            this.outputPathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputPathLabel.AutoSize = true;
            this.outputPathLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputPathLabel.Location = new System.Drawing.Point(3, 74);
            this.outputPathLabel.Name = "outputPathLabel";
            this.outputPathLabel.Size = new System.Drawing.Size(106, 32);
            this.outputPathLabel.TabIndex = 3;
            this.outputPathLabel.Text = "Output Folder";
            this.outputPathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sameLocationAskingLabal
            // 
            this.sameLocationAskingLabal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sameLocationAskingLabal.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.sameLocationAskingLabal, 2);
            this.sameLocationAskingLabal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sameLocationAskingLabal.Location = new System.Drawing.Point(3, 48);
            this.sameLocationAskingLabal.Name = "sameLocationAskingLabal";
            this.sameLocationAskingLabal.Size = new System.Drawing.Size(764, 26);
            this.sameLocationAskingLabal.TabIndex = 4;
            this.sameLocationAskingLabal.Text = "The same location for both input and output folder?";
            this.sameLocationAskingLabal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OutPutPathButton
            // 
            this.OutPutPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutPutPathButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutPutPathButton.Location = new System.Drawing.Point(773, 77);
            this.OutPutPathButton.Name = "OutPutPathButton";
            this.OutPutPathButton.Size = new System.Drawing.Size(107, 26);
            this.OutPutPathButton.TabIndex = 6;
            this.OutPutPathButton.Text = "Browse...";
            this.OutPutPathButton.UseVisualStyleBackColor = true;
            this.OutPutPathButton.Click += new System.EventHandler(this.OutPutPathButton_Click);
            // 
            // InputPathTextBox
            // 
            this.InputPathTextBox.AllowDrop = true;
            this.InputPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputPathTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputPathTextBox.Location = new System.Drawing.Point(115, 19);
            this.InputPathTextBox.Name = "InputPathTextBox";
            this.InputPathTextBox.Size = new System.Drawing.Size(652, 26);
            this.InputPathTextBox.TabIndex = 7;
            this.InputPathTextBox.WordWrap = false;
            // 
            // OutPutPathText
            // 
            this.OutPutPathText.AllowDrop = true;
            this.OutPutPathText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutPutPathText.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutPutPathText.Location = new System.Drawing.Point(115, 77);
            this.OutPutPathText.Name = "OutPutPathText";
            this.OutPutPathText.Size = new System.Drawing.Size(652, 26);
            this.OutPutPathText.TabIndex = 8;
            this.OutPutPathText.WordWrap = false;
            this.OutPutPathText.TextChanged += new System.EventHandler(this.OutPutPathText_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.convertButton, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.listCousesButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.exitButton, 0, 2);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(773, 109);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(107, 490);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // convertButton
            // 
            this.convertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.convertButton.Enabled = false;
            this.convertButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Location = new System.Drawing.Point(3, 150);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(101, 239);
            this.convertButton.TabIndex = 7;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // listCousesButton
            // 
            this.listCousesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listCousesButton.Enabled = false;
            this.listCousesButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCousesButton.Location = new System.Drawing.Point(3, 3);
            this.listCousesButton.Name = "listCousesButton";
            this.listCousesButton.Size = new System.Drawing.Size(101, 141);
            this.listCousesButton.TabIndex = 7;
            this.listCousesButton.Text = "List courses";
            this.listCousesButton.UseVisualStyleBackColor = true;
            this.listCousesButton.Click += new System.EventHandler(this.listCousesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(3, 395);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(101, 92);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.availableCourseNoticeLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.srcOpenButton, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.selectNoticeLabel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dstOpenButton, 0, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 109);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(106, 490);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // availableCourseNoticeLabel
            // 
            this.availableCourseNoticeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.availableCourseNoticeLabel.AutoSize = true;
            this.availableCourseNoticeLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableCourseNoticeLabel.Location = new System.Drawing.Point(3, 0);
            this.availableCourseNoticeLabel.Name = "availableCourseNoticeLabel";
            this.availableCourseNoticeLabel.Size = new System.Drawing.Size(100, 122);
            this.availableCourseNoticeLabel.TabIndex = 10;
            this.availableCourseNoticeLabel.Text = "Available course(s)";
            this.availableCourseNoticeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // srcOpenButton
            // 
            this.srcOpenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.srcOpenButton.Enabled = false;
            this.srcOpenButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srcOpenButton.Location = new System.Drawing.Point(3, 247);
            this.srcOpenButton.Name = "srcOpenButton";
            this.srcOpenButton.Size = new System.Drawing.Size(100, 116);
            this.srcOpenButton.TabIndex = 7;
            this.srcOpenButton.Text = "Source folder";
            this.srcOpenButton.UseVisualStyleBackColor = true;
            this.srcOpenButton.Click += new System.EventHandler(this.srcOpenButton_Click);
            // 
            // selectNoticeLabel
            // 
            this.selectNoticeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectNoticeLabel.AutoSize = true;
            this.selectNoticeLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectNoticeLabel.Location = new System.Drawing.Point(3, 122);
            this.selectNoticeLabel.Name = "selectNoticeLabel";
            this.selectNoticeLabel.Size = new System.Drawing.Size(100, 122);
            this.selectNoticeLabel.TabIndex = 12;
            this.selectNoticeLabel.Text = "Select course(s)\r\nto convert";
            this.selectNoticeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dstOpenButton
            // 
            this.dstOpenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dstOpenButton.Enabled = false;
            this.dstOpenButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dstOpenButton.Location = new System.Drawing.Point(3, 369);
            this.dstOpenButton.Name = "dstOpenButton";
            this.dstOpenButton.Size = new System.Drawing.Size(100, 118);
            this.dstOpenButton.TabIndex = 7;
            this.dstOpenButton.Text = "Converted folder";
            this.dstOpenButton.UseVisualStyleBackColor = true;
            // 
            // LabelBak01
            // 
            this.LabelBak01.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelBak01.AutoSize = true;
            this.LabelBak01.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBak01.Location = new System.Drawing.Point(3, 606);
            this.LabelBak01.Name = "LabelBak01";
            this.LabelBak01.Size = new System.Drawing.Size(106, 16);
            this.LabelBak01.TabIndex = 3;
            this.LabelBak01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelBak3
            // 
            this.LabelBak3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelBak3.AutoSize = true;
            this.LabelBak3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBak3.Location = new System.Drawing.Point(773, 606);
            this.LabelBak3.Name = "LabelBak3";
            this.LabelBak3.Size = new System.Drawing.Size(107, 16);
            this.LabelBak3.TabIndex = 3;
            this.LabelBak3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sameLocationCheck
            // 
            this.sameLocationCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sameLocationCheck.AutoSize = true;
            this.sameLocationCheck.Location = new System.Drawing.Point(773, 51);
            this.sameLocationCheck.Name = "sameLocationCheck";
            this.sameLocationCheck.Size = new System.Drawing.Size(107, 20);
            this.sameLocationCheck.TabIndex = 14;
            this.sameLocationCheck.Text = "NO";
            this.sameLocationCheck.UseVisualStyleBackColor = true;
            this.sameLocationCheck.CheckStateChanged += new System.EventHandler(this.sameLocationCheck_CheckStateChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.coursesListBox, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.searchBox, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(115, 109);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(652, 490);
            this.tableLayoutPanel4.TabIndex = 15;
            // 
            // coursesListBox
            // 
            this.coursesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coursesListBox.Enabled = false;
            this.coursesListBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursesListBox.FormattingEnabled = true;
            this.coursesListBox.ItemHeight = 16;
            this.coursesListBox.Location = new System.Drawing.Point(0, 0);
            this.coursesListBox.Margin = new System.Windows.Forms.Padding(0);
            this.coursesListBox.Name = "coursesListBox";
            this.coursesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.coursesListBox.Size = new System.Drawing.Size(652, 452);
            this.coursesListBox.TabIndex = 9;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Enabled = false;
            this.searchBox.Location = new System.Drawing.Point(0, 466);
            this.searchBox.Margin = new System.Windows.Forms.Padding(0);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(652, 23);
            this.searchBox.TabIndex = 10;
            this.searchBox.Text = "Typing to search";
            this.searchBox.WordWrap = false;
            this.searchBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.searchBox_MouseDown);
            // 
            // LabelBak2
            // 
            this.LabelBak2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelBak2.AutoSize = true;
            this.LabelBak2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBak2.Location = new System.Drawing.Point(115, 606);
            this.LabelBak2.Name = "LabelBak2";
            this.LabelBak2.Size = new System.Drawing.Size(652, 16);
            this.LabelBak2.TabIndex = 3;
            this.LabelBak2.Text = "Welcome to PsVDecrypt!";
            this.LabelBak2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 636);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainGui";
            this.Text = "PsvDecryptor GUI";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button InputPathButton;
        private System.Windows.Forms.Label inputPathLabel;
        private System.Windows.Forms.Label outputPathLabel;
        private System.Windows.Forms.Label sameLocationAskingLabal;
        private System.Windows.Forms.Button OutPutPathButton;
        private System.Windows.Forms.TextBox InputPathTextBox;
        private System.Windows.Forms.TextBox OutPutPathText;
        private System.Windows.Forms.ListBox coursesListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label selectNoticeLabel;
        private System.Windows.Forms.Label availableCourseNoticeLabel;
        private System.Windows.Forms.Button listCousesButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label LabelBak2;
        private System.Windows.Forms.Label LabelBak01;
        private System.Windows.Forms.Label LabelBak3;
        private System.Windows.Forms.CheckBox sameLocationCheck;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button srcOpenButton;
        private System.Windows.Forms.Button dstOpenButton;
    }
}

