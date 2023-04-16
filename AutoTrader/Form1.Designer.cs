
namespace AutoTrader
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_access = new System.Windows.Forms.TextBox();
            this.textBox_secret = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.button_checkAccount = new System.Windows.Forms.Button();
            this.button_checkFee = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.86667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.13333F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_access, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_secret, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_login, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(376, 84);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "AccessKey";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(4, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "SecretKey";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_access
            // 
            this.textBox_access.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_access.Location = new System.Drawing.Point(86, 4);
            this.textBox_access.Name = "textBox_access";
            this.textBox_access.PasswordChar = '*';
            this.textBox_access.Size = new System.Drawing.Size(286, 21);
            this.textBox_access.TabIndex = 2;
            // 
            // textBox_secret
            // 
            this.textBox_secret.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_secret.Location = new System.Drawing.Point(86, 31);
            this.textBox_secret.Name = "textBox_secret";
            this.textBox_secret.PasswordChar = '*';
            this.textBox_secret.Size = new System.Drawing.Size(286, 21);
            this.textBox_secret.TabIndex = 2;
            // 
            // button_login
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.button_login, 2);
            this.button_login.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_login.Location = new System.Drawing.Point(4, 58);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(368, 22);
            this.button_login.TabIndex = 3;
            this.button_login.Text = "로그인";
            this.button_login.UseVisualStyleBackColor = true;
            // 
            // button_checkAccount
            // 
            this.button_checkAccount.Location = new System.Drawing.Point(12, 102);
            this.button_checkAccount.Name = "button_checkAccount";
            this.button_checkAccount.Size = new System.Drawing.Size(179, 43);
            this.button_checkAccount.TabIndex = 1;
            this.button_checkAccount.Text = "잔고확인";
            this.button_checkAccount.UseVisualStyleBackColor = true;
            // 
            // button_checkFee
            // 
            this.button_checkFee.Location = new System.Drawing.Point(210, 102);
            this.button_checkFee.Name = "button_checkFee";
            this.button_checkFee.Size = new System.Drawing.Size(178, 43);
            this.button_checkFee.TabIndex = 1;
            this.button_checkFee.Text = "수수료 확인";
            this.button_checkFee.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 157);
            this.Controls.Add(this.button_checkFee);
            this.Controls.Add(this.button_checkAccount);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_access;
        private System.Windows.Forms.TextBox textBox_secret;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_checkAccount;
        private System.Windows.Forms.Button button_checkFee;
    }
}

