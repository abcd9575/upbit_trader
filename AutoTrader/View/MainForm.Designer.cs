
namespace AutoTrader.View
{
    partial class MainForm
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
            this.button_1min = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_1min
            // 
            this.button_1min.Location = new System.Drawing.Point(238, 257);
            this.button_1min.Name = "button_1min";
            this.button_1min.Size = new System.Drawing.Size(310, 79);
            this.button_1min.TabIndex = 0;
            this.button_1min.Text = "1분 캔들 가져오기";
            this.button_1min.UseVisualStyleBackColor = true;
            this.button_1min.Click += new System.EventHandler(this.button_1min_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_1min);
            this.Name = "MainForm";
            this.Text = "MainForm1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_1min;
    }
}