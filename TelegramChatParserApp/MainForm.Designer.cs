namespace TelegramChatParserApp;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        button_openFile = new Button();
        textBox_searchedText = new TextBox();
        button_searchedOk = new Button();
        label_filePath = new Label();
        dataGridView1 = new DataGridView();
        richTextBox_messageInfo = new RichTextBox();
        label_countRowsTitle = new Label();
        label_countRowsValue = new Label();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // button_openFile
        // 
        button_openFile.Location = new Point(12, 12);
        button_openFile.Name = "button_openFile";
        button_openFile.Size = new Size(75, 23);
        button_openFile.TabIndex = 0;
        button_openFile.Text = "Open File";
        button_openFile.UseVisualStyleBackColor = true;
        button_openFile.Click += button_openFile_Click;
        // 
        // textBox_searchedText
        // 
        textBox_searchedText.Location = new Point(12, 41);
        textBox_searchedText.Name = "textBox_searchedText";
        textBox_searchedText.Size = new Size(273, 23);
        textBox_searchedText.TabIndex = 2;
        // 
        // button_searchedOk
        // 
        button_searchedOk.Enabled = false;
        button_searchedOk.Location = new Point(291, 41);
        button_searchedOk.Name = "button_searchedOk";
        button_searchedOk.Size = new Size(49, 23);
        button_searchedOk.TabIndex = 3;
        button_searchedOk.Text = "Find";
        button_searchedOk.UseVisualStyleBackColor = true;
        button_searchedOk.Click += button_searchedOk_Click;
        // 
        // label_filePath
        // 
        label_filePath.AutoSize = true;
        label_filePath.Location = new Point(93, 16);
        label_filePath.Name = "label_filePath";
        label_filePath.Size = new Size(97, 15);
        label_filePath.TabIndex = 4;
        label_filePath.Text = "Файл не выбран";
        // 
        // dataGridView1
        // 
        dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(12, 222);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.ReadOnly = true;
        dataGridView1.RowTemplate.Height = 25;
        dataGridView1.Size = new Size(1049, 259);
        dataGridView1.TabIndex = 5;
        dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        // 
        // richTextBox_messageInfo
        // 
        richTextBox_messageInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        richTextBox_messageInfo.Location = new Point(12, 83);
        richTextBox_messageInfo.Name = "richTextBox_messageInfo";
        richTextBox_messageInfo.ReadOnly = true;
        richTextBox_messageInfo.Size = new Size(1049, 115);
        richTextBox_messageInfo.TabIndex = 6;
        richTextBox_messageInfo.Text = "";
        // 
        // label_countRowsTitle
        // 
        label_countRowsTitle.AutoSize = true;
        label_countRowsTitle.Location = new Point(346, 45);
        label_countRowsTitle.Name = "label_countRowsTitle";
        label_countRowsTitle.Size = new Size(163, 15);
        label_countRowsTitle.TabIndex = 7;
        label_countRowsTitle.Text = "Кол-во найденных записей: ";
        // 
        // label_countRowsValue
        // 
        label_countRowsValue.AutoSize = true;
        label_countRowsValue.Location = new Point(515, 45);
        label_countRowsValue.Name = "label_countRowsValue";
        label_countRowsValue.Size = new Size(0, 15);
        label_countRowsValue.TabIndex = 8;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1073, 493);
        Controls.Add(label_countRowsValue);
        Controls.Add(label_countRowsTitle);
        Controls.Add(richTextBox_messageInfo);
        Controls.Add(dataGridView1);
        Controls.Add(label_filePath);
        Controls.Add(button_searchedOk);
        Controls.Add(textBox_searchedText);
        Controls.Add(button_openFile);
        Name = "MainForm";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button_openFile;
    private TextBox textBox_searchedText;
    private Button button_searchedOk;
    private Label label_filePath;
    private DataGridView dataGridView1;
    private RichTextBox richTextBox_messageInfo;
    private Label label_countRowsTitle;
    private Label label_countRowsValue;
}
