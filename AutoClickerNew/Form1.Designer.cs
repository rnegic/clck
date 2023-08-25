namespace AutoClickerNew
{
    partial class FormAutoClicker
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
            this.components = new System.ComponentModel.Container();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.trackBarText = new System.Windows.Forms.Label();
            this.AutoClicker = new System.Windows.Forms.Timer(this.components);
            this.labelAmountOfClicks = new System.Windows.Forms.Label();
            this.textBoxClickAmount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(73, 209);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(206, 64);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Thistle;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStop.Location = new System.Drawing.Point(419, 209);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(205, 64);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(118, 133);
            this.trackBar.Maximum = 50;
            this.trackBar.Minimum = 1;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(460, 45);
            this.trackBar.TabIndex = 2;
            this.trackBar.Value = 10;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // trackBarText
            // 
            this.trackBarText.AutoSize = true;
            this.trackBarText.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trackBarText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.trackBarText.Location = new System.Drawing.Point(323, 45);
            this.trackBarText.Name = "trackBarText";
            this.trackBarText.Size = new System.Drawing.Size(55, 39);
            this.trackBarText.TabIndex = 3;
            this.trackBarText.Text = "10";
            // 
            // AutoClicker
            // 
            this.AutoClicker.Interval = 1000;
            this.AutoClicker.Tick += new System.EventHandler(this.AutoClicker_Tick);
            // 
            // labelAmountOfClicks
            // 
            this.labelAmountOfClicks.AutoSize = true;
            this.labelAmountOfClicks.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAmountOfClicks.ForeColor = System.Drawing.Color.Snow;
            this.labelAmountOfClicks.Location = new System.Drawing.Point(221, 325);
            this.labelAmountOfClicks.Name = "labelAmountOfClicks";
            this.labelAmountOfClicks.Size = new System.Drawing.Size(252, 37);
            this.labelAmountOfClicks.TabIndex = 4;
            this.labelAmountOfClicks.Text = "Amount of clicks";
            // 
            // textBoxClickAmount
            // 
            this.textBoxClickAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBoxClickAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxClickAmount.Location = new System.Drawing.Point(228, 387);
            this.textBoxClickAmount.Name = "textBoxClickAmount";
            this.textBoxClickAmount.Size = new System.Drawing.Size(232, 40);
            this.textBoxClickAmount.TabIndex = 5;
            // 
            // FormAutoClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(684, 465);
            this.Controls.Add(this.textBoxClickAmount);
            this.Controls.Add(this.labelAmountOfClicks);
            this.Controls.Add(this.trackBarText);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Name = "FormAutoClicker";
            this.Text = "AutoClicker";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label trackBarText;
        private System.Windows.Forms.Timer AutoClicker;
        private System.Windows.Forms.Label labelAmountOfClicks;
        private System.Windows.Forms.TextBox textBoxClickAmount;
    }
}

