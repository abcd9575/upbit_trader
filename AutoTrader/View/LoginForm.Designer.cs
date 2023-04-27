
using System.Windows.Forms;

namespace AutoTrader.View
{
    partial class LoginForm
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (textBox_Access.Text != Properties.Settings.Default.access)
                Properties.Settings.Default.access = textBox_Access.Text;
            if (textBox_Secert.Text != Properties.Settings.Default.secret)
                Properties.Settings.Default.secret = textBox_Secert.Text;
            Properties.Settings.Default.Save();
            base.OnFormClosing(e);
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Access = new System.Windows.Forms.TextBox();
            this.textBox_Secert = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_Login = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.48677F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.51323F));
            this.tableLayoutPanel1.Controls.Add(this.textBox_Access, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Secert, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 5);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(415, 68);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox_Access
            // 
            this.textBox_Access.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Access.Location = new System.Drawing.Point(97, 6);
            this.textBox_Access.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox_Access.Name = "textBox_Access";
            this.textBox_Access.PasswordChar = '*';
            this.textBox_Access.Size = new System.Drawing.Size(314, 25);
            this.textBox_Access.TabIndex = 0;
            this.textBox_Access.Text = global::AutoTrader.Properties.Settings.Default.access;
            // 
            // textBox_Secert
            // 
            this.textBox_Secert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Secert.Location = new System.Drawing.Point(97, 39);
            this.textBox_Secert.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox_Secert.Name = "textBox_Secert";
            this.textBox_Secert.PasswordChar = '*';
            this.textBox_Secert.Size = new System.Drawing.Size(314, 25);
            this.textBox_Secert.TabIndex = 1;
            this.textBox_Secert.Text = global::AutoTrader.Properties.Settings.Default.secret;
            this.textBox_Secert.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Secert_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "AccessKey";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "SecertKey";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_Login, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.94215F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.05785F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(421, 117);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // button_Login
            // 
            this.button_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Login.Location = new System.Drawing.Point(3, 81);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(415, 33);
            this.button_Login.TabIndex = 1;
            this.button_Login.Text = "로그인";
            this.button_Login.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 117);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox_Access;
        private System.Windows.Forms.TextBox textBox_Secert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_Login;
    }
}