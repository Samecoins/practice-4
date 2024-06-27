using System.Data;

namespace Practic4
{
    public partial class FormPractic4 : Form
    {
        public FormPractic4()
        {
            InitializeComponent();
            textBoxForMessage.Enabled = false;
            textBoxForMessage.Text = "���������� ������� �������� ����������� �� �������� �� ����� ������� � ������� �� ����� ���������� ��� �������� �� 15Ѱ �� 38Ѱ � ����� 1Ѱ (������� �������������� �� ������� F = 1,8C�+32)";
        }
        private void buttonRunning_Click(object sender, EventArgs e)
        {
            textBoxForMessage.Visible = false;

            DataTable table = new DataTable();
            table.Columns.Add("�C", typeof(string));
            table.Columns.Add("�C >= 15?", typeof(char));
            table.Columns.Add("�C <= 38?", typeof(char));
            table.Columns.Add("�F", typeof(string));

            string C = "13";
            char pusto = ' ';
            char minus = '-';
            char plus = '+';

            table.Rows.Add(C, pusto, pusto, pusto);
            while (Convert.ToInt32(C) <= 39)
            {
                if (Convert.ToInt32(C) >= 15)
                {
                    table.Rows.Add(pusto, plus, pusto, pusto);
                    table.Rows.Add(pusto, pusto, plus, pusto);
                    table.Rows.Add(pusto, pusto, pusto, Convert.ToString((1.8 * Convert.ToInt32(C)) + 32));
                    table.Rows.Add(C, pusto, pusto, pusto);
                    C = Convert.ToString(Convert.ToInt32(C) + 1);


                }
                else
                {
                    table.Rows.Add(pusto, minus, pusto, pusto);
                    C = Convert.ToString(Convert.ToInt32(C) + 1);
                    table.Rows.Add(C, pusto, pusto, pusto);
                }
            }
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                if ((e.Value != null))
                {
                    e.CellStyle.BackColor = Color.Pink;
                }
            }
        }
    }
}
