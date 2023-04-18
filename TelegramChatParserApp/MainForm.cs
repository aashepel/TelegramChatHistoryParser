using System.Text.RegularExpressions;
using System.Windows.Forms;
using TelegramChatHistoryParser;
using TelegramChatHistoryParser.Models;

namespace TelegramChatParserApp;

public partial class MainForm : Form
{
    private TelegramHistoryParser _telegramHistoryParser = new TelegramHistoryParser();
    private FileEntity? _fileEntity = null;

    public MainForm()
    {
        InitializeComponent();
    }

    private void button_openFile_Click(object sender, EventArgs e)
    {
        button_searchedOk.Enabled = true;
        OpenFileDialog openFileDialog = new OpenFileDialog();
        if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            return;

        string filePath = openFileDialog.FileName;
        label_filePath.Text = filePath;
        try
        {
            string text = File.ReadAllText(filePath);
            _fileEntity = _telegramHistoryParser.Parse(text);
            dataGridView1.DataSource = null;
            if (_fileEntity.Messages.Count < 20000)
                dataGridView1.DataSource = _fileEntity.Messages;

            MessageBox.Show("Успешно", "Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
            button_searchedOk.Enabled = true;
        }
        catch (Exception ex)
        {
            label_countRowsValue.Text = "0";
            button_searchedOk.Enabled = false;
            MessageBox.Show($"Ошибка: {ex.Message}", "Dialog", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void button_searchedOk_Click(object sender, EventArgs e)
    {
        dataGridView1.DataSource = null;

        if (textBox_searchedText.Text.Length < 3)
            return;

        Regex regex = new Regex(textBox_searchedText.Text, RegexOptions.IgnoreCase);
        var messages = _fileEntity.Messages.Where(p => regex.IsMatch(p.Text)).ToList();
        if (messages.Any())
        {
            dataGridView1.DataSource = messages;
            label_countRowsValue.Text = messages.Count.ToString();
        }
        else
        {
            MessageBox.Show("По запросу ничего не найдено", "Dialog", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            label_countRowsValue.Text = "0";
        }
            
    }

    private void dataGridView1_SelectionChanged(object sender, EventArgs e)
    {
        richTextBox_messageInfo.Text = dataGridView1.CurrentCell.Value.ToString();
    }
}
