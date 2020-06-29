namespace WindowsFormsApp5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownNumberOfUsers = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownUser = new System.Windows.Forms.NumericUpDown();
            this.radioButtonChatVisibility = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSetSpeed = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownTypingSpeed = new System.Windows.Forms.NumericUpDown();
            this.textBoxChat = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUser)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTypingSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Чатик";
            // 
            // numericUpDownNumberOfUsers
            // 
            this.numericUpDownNumberOfUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownNumberOfUsers.Location = new System.Drawing.Point(607, 59);
            this.numericUpDownNumberOfUsers.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownNumberOfUsers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumberOfUsers.Name = "numericUpDownNumberOfUsers";
            this.numericUpDownNumberOfUsers.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownNumberOfUsers.TabIndex = 2;
            this.numericUpDownNumberOfUsers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumberOfUsers.ValueChanged += new System.EventHandler(this.numericUpDownNumberOfUsers_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(607, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество Пользователей";
            // 
            // numericUpDownUser
            // 
            this.numericUpDownUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownUser.Location = new System.Drawing.Point(9, 35);
            this.numericUpDownUser.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.numericUpDownUser.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownUser.Name = "numericUpDownUser";
            this.numericUpDownUser.Size = new System.Drawing.Size(77, 20);
            this.numericUpDownUser.TabIndex = 4;
            this.numericUpDownUser.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radioButtonChatVisibility
            // 
            this.radioButtonChatVisibility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonChatVisibility.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonChatVisibility.AutoSize = true;
            this.radioButtonChatVisibility.Checked = true;
            this.radioButtonChatVisibility.Location = new System.Drawing.Point(631, 192);
            this.radioButtonChatVisibility.MinimumSize = new System.Drawing.Size(99, 23);
            this.radioButtonChatVisibility.Name = "radioButtonChatVisibility";
            this.radioButtonChatVisibility.Size = new System.Drawing.Size(99, 23);
            this.radioButtonChatVisibility.TabIndex = 6;
            this.radioButtonChatVisibility.TabStop = true;
            this.radioButtonChatVisibility.Text = "Отобразить Чат";
            this.radioButtonChatVisibility.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonChatVisibility.UseVisualStyleBackColor = true;
            this.radioButtonChatVisibility.CheckedChanged += new System.EventHandler(this.radioButtonChatVisibility_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(631, 221);
            this.radioButton1.MinimumSize = new System.Drawing.Size(99, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(99, 23);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.Text = "Скрыть Чат";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButtonChatInvisibility_CheckedChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(680, 401);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(96, 48);
            this.buttonStart.TabIndex = 8;
            this.buttonStart.Text = "Начать Симуляцию Чата";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSetSpeed);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDownTypingSpeed);
            this.groupBox1.Controls.Add(this.numericUpDownUser);
            this.groupBox1.Location = new System.Drawing.Point(585, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 86);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Скорость Печати (сообщ/мин)";
            // 
            // buttonSetSpeed
            // 
            this.buttonSetSpeed.Location = new System.Drawing.Point(105, 57);
            this.buttonSetSpeed.Name = "buttonSetSpeed";
            this.buttonSetSpeed.Size = new System.Drawing.Size(75, 23);
            this.buttonSetSpeed.TabIndex = 8;
            this.buttonSetSpeed.Text = "Задать";
            this.buttonSetSpeed.UseVisualStyleBackColor = true;
            this.buttonSetSpeed.Click += new System.EventHandler(this.buttonTypingSpeed_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Скорость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пользователь";
            // 
            // numericUpDownTypingSpeed
            // 
            this.numericUpDownTypingSpeed.Location = new System.Drawing.Point(91, 35);
            this.numericUpDownTypingSpeed.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownTypingSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTypingSpeed.Name = "numericUpDownTypingSpeed";
            this.numericUpDownTypingSpeed.Size = new System.Drawing.Size(89, 20);
            this.numericUpDownTypingSpeed.TabIndex = 5;
            this.numericUpDownTypingSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // textBoxChat
            // 
            this.textBoxChat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxChat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxChat.Location = new System.Drawing.Point(12, 40);
            this.textBoxChat.Name = "textBoxChat";
            this.textBoxChat.ReadOnly = true;
            this.textBoxChat.Size = new System.Drawing.Size(567, 409);
            this.textBoxChat.TabIndex = 10;
            this.textBoxChat.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.textBoxChat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButtonChatVisibility);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownNumberOfUsers);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Some Program";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUser)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTypingSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberOfUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownUser;
        private System.Windows.Forms.RadioButton radioButtonChatVisibility;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSetSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownTypingSpeed;
        private System.Windows.Forms.RichTextBox textBoxChat;
    }
}

