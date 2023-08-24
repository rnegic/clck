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
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(61, 275);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(206, 64);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Thistle;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStop.Location = new System.Drawing.Point(407, 275);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(205, 64);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = false;
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(105, 176);
            this.trackBar.Maximum = 50;
            this.trackBar.Minimum = 1;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(460, 45);
            this.trackBar.TabIndex = 2;
            this.trackBar.Value = 10;
            // 
            // trackBarText
            // 
            this.trackBarText.AutoSize = true;
            this.trackBarText.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trackBarText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.trackBarText.Location = new System.Drawing.Point(317, 75);
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
            // FormAutoClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(684, 398);
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
    }
}

