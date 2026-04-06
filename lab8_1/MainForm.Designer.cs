namespace lab8_1
{
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
            arrTLP = new TableLayoutPanel();
            arrLabel = new Label();
            arrBox = new TextBox();
            genBtn = new Button();
            sepPanel = new Panel();
            resTLP = new TableLayoutPanel();
            resBox = new TextBox();
            resLabel = new Label();
            btnsTLP = new TableLayoutPanel();
            countBtn = new Button();
            avgBtn = new Button();
            sumBtn = new Button();
            nBox = new TextBox();
            arrTLP.SuspendLayout();
            resTLP.SuspendLayout();
            btnsTLP.SuspendLayout();
            SuspendLayout();
            // 
            // arrTLP
            // 
            arrTLP.ColumnCount = 3;
            arrTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            arrTLP.ColumnStyles.Add(new ColumnStyle());
            arrTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            arrTLP.Controls.Add(arrLabel, 1, 0);
            arrTLP.Controls.Add(arrBox, 1, 1);
            arrTLP.Controls.Add(genBtn, 1, 2);
            arrTLP.Dock = DockStyle.Top;
            arrTLP.Location = new Point(0, 0);
            arrTLP.Name = "arrTLP";
            arrTLP.RowCount = 3;
            arrTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            arrTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            arrTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            arrTLP.Size = new Size(696, 165);
            arrTLP.TabIndex = 0;
            // 
            // arrLabel
            // 
            arrLabel.Anchor = AnchorStyles.None;
            arrLabel.AutoSize = true;
            arrLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            arrLabel.Location = new Point(308, 15);
            arrLabel.Name = "arrLabel";
            arrLabel.Size = new Size(78, 25);
            arrLabel.TabIndex = 0;
            arrLabel.Text = "Массив";
            // 
            // arrBox
            // 
            arrBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            arrBox.BackColor = Color.FromArgb(255, 249, 240);
            arrBox.BorderStyle = BorderStyle.FixedSingle;
            arrBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            arrBox.ForeColor = Color.FromArgb(45, 45, 45);
            arrBox.Location = new Point(115, 68);
            arrBox.Name = "arrBox";
            arrBox.ReadOnly = true;
            arrBox.Size = new Size(465, 29);
            arrBox.TabIndex = 1;
            arrBox.TextAlign = HorizontalAlignment.Center;
            // 
            // genBtn
            // 
            genBtn.Anchor = AnchorStyles.None;
            genBtn.BackColor = Color.FromArgb(255, 152, 0);
            genBtn.Cursor = Cursors.Hand;
            genBtn.FlatAppearance.BorderSize = 0;
            genBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 193, 7);
            genBtn.FlatStyle = FlatStyle.Flat;
            genBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            genBtn.Location = new Point(281, 121);
            genBtn.Name = "genBtn";
            genBtn.Size = new Size(132, 33);
            genBtn.TabIndex = 2;
            genBtn.Text = "Сгенерировать";
            genBtn.UseVisualStyleBackColor = false;
            genBtn.Click += genBtn_Click;
            // 
            // sepPanel
            // 
            sepPanel.Dock = DockStyle.Top;
            sepPanel.Location = new Point(0, 165);
            sepPanel.Name = "sepPanel";
            sepPanel.Size = new Size(696, 10);
            sepPanel.TabIndex = 1;
            sepPanel.Paint += sepPanel_Paint;
            // 
            // resTLP
            // 
            resTLP.BackColor = Color.White;
            resTLP.ColumnCount = 3;
            resTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            resTLP.ColumnStyles.Add(new ColumnStyle());
            resTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            resTLP.Controls.Add(nBox, 1, 0);
            resTLP.Controls.Add(resBox, 1, 2);
            resTLP.Controls.Add(resLabel, 1, 1);
            resTLP.Dock = DockStyle.Fill;
            resTLP.Location = new Point(0, 238);
            resTLP.Name = "resTLP";
            resTLP.RowCount = 3;
            resTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            resTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            resTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            resTLP.Size = new Size(696, 130);
            resTLP.TabIndex = 2;
            // 
            // resBox
            // 
            resBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            resBox.BackColor = Color.FromArgb(255, 249, 240);
            resBox.BorderStyle = BorderStyle.FixedSingle;
            resBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            resBox.ForeColor = Color.FromArgb(45, 45, 45);
            resBox.Location = new Point(115, 93);
            resBox.Name = "resBox";
            resBox.ReadOnly = true;
            resBox.Size = new Size(465, 29);
            resBox.TabIndex = 2;
            resBox.TextAlign = HorizontalAlignment.Center;
            // 
            // resLabel
            // 
            resLabel.Anchor = AnchorStyles.None;
            resLabel.AutoSize = true;
            resLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            resLabel.Location = new Point(299, 52);
            resLabel.Name = "resLabel";
            resLabel.Size = new Size(96, 25);
            resLabel.TabIndex = 3;
            resLabel.Text = "Результат";
            // 
            // btnsTLP
            // 
            btnsTLP.ColumnCount = 3;
            btnsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            btnsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            btnsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            btnsTLP.Controls.Add(countBtn, 2, 0);
            btnsTLP.Controls.Add(avgBtn, 1, 0);
            btnsTLP.Controls.Add(sumBtn, 0, 0);
            btnsTLP.Dock = DockStyle.Top;
            btnsTLP.Location = new Point(0, 175);
            btnsTLP.Name = "btnsTLP";
            btnsTLP.RowCount = 1;
            btnsTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            btnsTLP.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            btnsTLP.Size = new Size(696, 63);
            btnsTLP.TabIndex = 3;
            // 
            // countBtn
            // 
            countBtn.Anchor = AnchorStyles.None;
            countBtn.BackColor = Color.FromArgb(255, 152, 0);
            countBtn.Cursor = Cursors.Hand;
            countBtn.FlatAppearance.BorderSize = 0;
            countBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 193, 7);
            countBtn.FlatStyle = FlatStyle.Flat;
            countBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            countBtn.Location = new Point(514, 15);
            countBtn.Name = "countBtn";
            countBtn.Size = new Size(132, 33);
            countBtn.TabIndex = 5;
            countBtn.Text = "Количество";
            countBtn.UseVisualStyleBackColor = false;
            countBtn.Click += countBtn_Click;
            // 
            // avgBtn
            // 
            avgBtn.Anchor = AnchorStyles.None;
            avgBtn.BackColor = Color.FromArgb(255, 152, 0);
            avgBtn.Cursor = Cursors.Hand;
            avgBtn.FlatAppearance.BorderSize = 0;
            avgBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 193, 7);
            avgBtn.FlatStyle = FlatStyle.Flat;
            avgBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            avgBtn.Location = new Point(265, 15);
            avgBtn.Name = "avgBtn";
            avgBtn.Size = new Size(165, 33);
            avgBtn.TabIndex = 4;
            avgBtn.Text = "Ср. арифметическое";
            avgBtn.UseVisualStyleBackColor = false;
            avgBtn.Click += avgBtn_Click;
            // 
            // sumBtn
            // 
            sumBtn.Anchor = AnchorStyles.None;
            sumBtn.BackColor = Color.FromArgb(255, 152, 0);
            sumBtn.Cursor = Cursors.Hand;
            sumBtn.FlatAppearance.BorderSize = 0;
            sumBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 193, 7);
            sumBtn.FlatStyle = FlatStyle.Flat;
            sumBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sumBtn.Location = new Point(50, 15);
            sumBtn.Name = "sumBtn";
            sumBtn.Size = new Size(132, 33);
            sumBtn.TabIndex = 3;
            sumBtn.Text = "Сумма";
            sumBtn.UseVisualStyleBackColor = false;
            sumBtn.Click += sumBtn_Click;
            // 
            // nBox
            // 
            nBox.Anchor = AnchorStyles.None;
            nBox.BackColor = Color.FromArgb(255, 249, 240);
            nBox.BorderStyle = BorderStyle.FixedSingle;
            nBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nBox.ForeColor = Color.FromArgb(45, 45, 45);
            nBox.Location = new Point(290, 7);
            nBox.Name = "nBox";
            nBox.PlaceholderText = "N = ";
            nBox.Size = new Size(115, 29);
            nBox.TabIndex = 5;
            nBox.TextAlign = HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(696, 368);
            Controls.Add(resTLP);
            Controls.Add(btnsTLP);
            Controls.Add(sepPanel);
            Controls.Add(arrTLP);
            ForeColor = Color.FromArgb(45, 45, 45);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Часть 1";
            arrTLP.ResumeLayout(false);
            arrTLP.PerformLayout();
            resTLP.ResumeLayout(false);
            resTLP.PerformLayout();
            btnsTLP.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel arrTLP;
        private Label arrLabel;
        private TextBox arrBox;
        private Button genBtn;
        private Panel sepPanel;
        private TableLayoutPanel resTLP;
        private TextBox resBox;
        private Label resLabel;
        private TableLayoutPanel btnsTLP;
        private Button countBtn;
        private Button avgBtn;
        private Button sumBtn;
        private TextBox nBox;
    }
}
