namespace Practic4
{
    partial class FormPractic4
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
            dataGridView1 = new DataGridView();
            buttonRunning = new Button();
            textBoxForMessage = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(459, 233);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // buttonRunning
            // 
            buttonRunning.BackColor = SystemColors.ActiveCaption;
            buttonRunning.Location = new Point(135, 240);
            buttonRunning.Name = "buttonRunning";
            buttonRunning.Size = new Size(178, 39);
            buttonRunning.TabIndex = 1;
            buttonRunning.Text = "Запустить";
            buttonRunning.UseVisualStyleBackColor = false;
            buttonRunning.Click += buttonRunning_Click;
            // 
            // textBoxForMessage
            // 
            textBoxForMessage.Location = new Point(-1, 1);
            textBoxForMessage.Multiline = true;
            textBoxForMessage.Name = "textBoxForMessage";
            textBoxForMessage.Size = new Size(438, 233);
            textBoxForMessage.TabIndex = 2;
            // 
            // FormPractic4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 291);
            Controls.Add(textBoxForMessage);
            Controls.Add(buttonRunning);
            Controls.Add(dataGridView1);
            Name = "FormPractic4";
            Text = "Практика 4";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonRunning;
        private TextBox textBoxForMessage;
    }
}
