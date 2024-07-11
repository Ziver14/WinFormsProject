namespace WinFormsProject
{
    partial class FormMain
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
            btnTest = new Button();
            BtnTest2 = new Button();
            LblTest = new Label();
            textBox1 = new TextBox();
            groupCheck = new GroupBox();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            checkBox3 = new CheckBox();
            MenuTest = new MenuStrip();
            менюToolStripMenuItem = new ToolStripMenuItem();
            меню1ToolStripMenuItem = new ToolStripMenuItem();
            меню2ToolStripMenuItem = new ToolStripMenuItem();
            видToolStripMenuItem = new ToolStripMenuItem();
            openDialog = new OpenFileDialog();
            saveDialog = new SaveFileDialog();
            btnOpen = new Button();
            btnSave = new Button();
            btnRun = new Button();
            groupCheck.SuspendLayout();
            MenuTest.SuspendLayout();
            SuspendLayout();
            // 
            // btnTest
            // 
            btnTest.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnTest.Location = new Point(775, 604);
            btnTest.Margin = new Padding(3, 4, 3, 4);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(131, 49);
            btnTest.TabIndex = 0;
            btnTest.Text = "1";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += TextChange;
            // 
            // BtnTest2
            // 
            BtnTest2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnTest2.Location = new Point(26, 622);
            BtnTest2.Margin = new Padding(3, 4, 3, 4);
            BtnTest2.Name = "BtnTest2";
            BtnTest2.Size = new Size(86, 31);
            BtnTest2.TabIndex = 1;
            BtnTest2.Text = "PushTo";
            BtnTest2.UseVisualStyleBackColor = true;
            BtnTest2.Click += TextChange;
            // 
            // LblTest
            // 
            LblTest.AutoSize = true;
            LblTest.Location = new Point(14, 57);
            LblTest.Name = "LblTest";
            LblTest.Size = new Size(70, 20);
            LblTest.TabIndex = 2;
            LblTest.Text = "Подпись";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(111, 57);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(244, 473);
            textBox1.TabIndex = 3;
            // 
            // groupCheck
            // 
            groupCheck.Controls.Add(radioButton6);
            groupCheck.Controls.Add(radioButton5);
            groupCheck.Controls.Add(radioButton4);
            groupCheck.Location = new Point(362, 88);
            groupCheck.Margin = new Padding(3, 4, 3, 4);
            groupCheck.Name = "groupCheck";
            groupCheck.Padding = new Padding(3, 4, 3, 4);
            groupCheck.Size = new Size(184, 223);
            groupCheck.TabIndex = 4;
            groupCheck.TabStop = false;
            groupCheck.Text = "groupBox1";
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(17, 101);
            radioButton6.Margin = new Padding(3, 4, 3, 4);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(117, 24);
            radioButton6.TabIndex = 2;
            radioButton6.TabStop = true;
            radioButton6.Text = "radioButton6";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(17, 68);
            radioButton5.Margin = new Padding(3, 4, 3, 4);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(117, 24);
            radioButton5.TabIndex = 1;
            radioButton5.TabStop = true;
            radioButton5.Text = "radioButton5";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(17, 37);
            radioButton4.Margin = new Padding(3, 4, 3, 4);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(117, 24);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(591, 123);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 24);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(591, 156);
            radioButton2.Margin = new Padding(3, 4, 3, 4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(117, 24);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(591, 189);
            radioButton3.Margin = new Padding(3, 4, 3, 4);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(117, 24);
            radioButton3.TabIndex = 6;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(379, 55);
            checkBox3.Margin = new Padding(3, 4, 3, 4);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(101, 24);
            checkBox3.TabIndex = 7;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // MenuTest
            // 
            MenuTest.Dock = DockStyle.None;
            MenuTest.ImageScalingSize = new Size(20, 20);
            MenuTest.Items.AddRange(new ToolStripItem[] { менюToolStripMenuItem, видToolStripMenuItem });
            MenuTest.Location = new Point(0, 0);
            MenuTest.Name = "MenuTest";
            MenuTest.Padding = new Padding(7, 3, 0, 3);
            MenuTest.Size = new Size(123, 30);
            MenuTest.TabIndex = 8;
            MenuTest.Text = "Файл";
            MenuTest.ItemClicked += MenuTest_ItemClicked;
            // 
            // менюToolStripMenuItem
            // 
            менюToolStripMenuItem.Checked = true;
            менюToolStripMenuItem.CheckState = CheckState.Checked;
            менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { меню1ToolStripMenuItem, меню2ToolStripMenuItem });
            менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            менюToolStripMenuItem.Size = new Size(65, 24);
            менюToolStripMenuItem.Text = "Меню";
            // 
            // меню1ToolStripMenuItem
            // 
            меню1ToolStripMenuItem.Checked = true;
            меню1ToolStripMenuItem.CheckState = CheckState.Checked;
            меню1ToolStripMenuItem.Name = "меню1ToolStripMenuItem";
            меню1ToolStripMenuItem.Size = new Size(142, 26);
            меню1ToolStripMenuItem.Text = "Меню1";
            // 
            // меню2ToolStripMenuItem
            // 
            меню2ToolStripMenuItem.Name = "меню2ToolStripMenuItem";
            меню2ToolStripMenuItem.Size = new Size(142, 26);
            меню2ToolStripMenuItem.Text = "Меню2";
            // 
            // видToolStripMenuItem
            // 
            видToolStripMenuItem.Name = "видToolStripMenuItem";
            видToolStripMenuItem.Size = new Size(49, 24);
            видToolStripMenuItem.Text = "Вид";
            // 
            // openDialog
            // 
            openDialog.DefaultExt = "txt";
            openDialog.FileName = "openFileDialog1";
            openDialog.Filter = "Текстовые файлы(*.txt)|*.txt";
            // 
            // saveDialog
            // 
            saveDialog.DefaultExt = "txt";
            saveDialog.Filter = "Текстовые файлы(*.txt)|*.txt";
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(637, 289);
            btnOpen.Margin = new Padding(3, 4, 3, 4);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(86, 31);
            btnOpen.TabIndex = 9;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(639, 328);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 31);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnRun
            // 
            btnRun.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRun.Location = new Point(379, 613);
            btnRun.Margin = new Padding(3, 4, 3, 4);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(145, 31);
            btnRun.TabIndex = 11;
            btnRun.Text = "Поймай";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.MouseMove += btnRun_MouseMove;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 669);
            Controls.Add(btnRun);
            Controls.Add(btnSave);
            Controls.Add(btnOpen);
            Controls.Add(checkBox3);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(groupCheck);
            Controls.Add(textBox1);
            Controls.Add(LblTest);
            Controls.Add(BtnTest2);
            Controls.Add(btnTest);
            Controls.Add(MenuTest);
            MainMenuStrip = MenuTest;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            Text = "Тестовое приложение";
            WindowState = FormWindowState.Maximized;
            groupCheck.ResumeLayout(false);
            groupCheck.PerformLayout();
            MenuTest.ResumeLayout(false);
            MenuTest.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTest;
        private Button BtnTest2;
        private Label LblTest;
        private TextBox textBox1;
        private GroupBox groupCheck;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private CheckBox checkBox3;
        private RadioButton radioButton6;
        private MenuStrip MenuTest;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem меню1ToolStripMenuItem;
        private ToolStripMenuItem меню2ToolStripMenuItem;
        private OpenFileDialog openDialog;
        private SaveFileDialog saveDialog;
        private ToolStripMenuItem видToolStripMenuItem;
        private Button btnOpen;
        private Button btnSave;
        private Button btnRun;
    }
}
