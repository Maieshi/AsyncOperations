
namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.ActiveClients = new System.Windows.Forms.ListBox();
            this.ServerValueLog = new System.Windows.Forms.ListBox();
            this.ClientsLog = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Get = new System.Windows.Forms.Label();
            this.Set = new System.Windows.Forms.Label();
            this.ClientCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AsyncCaller = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Star/Stop Server";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ActiveClients
            // 
            this.ActiveClients.FormattingEnabled = true;
            this.ActiveClients.Location = new System.Drawing.Point(302, 41);
            this.ActiveClients.Name = "ActiveClients";
            this.ActiveClients.Size = new System.Drawing.Size(197, 381);
            this.ActiveClients.TabIndex = 1;
            // 
            // ServerValueLog
            // 
            this.ServerValueLog.FormattingEnabled = true;
            this.ServerValueLog.Location = new System.Drawing.Point(542, 41);
            this.ServerValueLog.Name = "ServerValueLog";
            this.ServerValueLog.Size = new System.Drawing.Size(197, 381);
            this.ServerValueLog.TabIndex = 2;
            // 
            // ClientsLog
            // 
            this.ClientsLog.FormattingEnabled = true;
            this.ClientsLog.Location = new System.Drawing.Point(56, 41);
            this.ClientsLog.Name = "ClientsLog";
            this.ClientsLog.Size = new System.Drawing.Size(197, 381);
            this.ClientsLog.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(495, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Get";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(593, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Set";
            // 
            // Get
            // 
            this.Get.AutoSize = true;
            this.Get.Location = new System.Drawing.Point(525, 17);
            this.Get.Name = "Get";
            this.Get.Size = new System.Drawing.Size(13, 13);
            this.Get.TabIndex = 6;
            this.Get.Text = "1";
            // 
            // Set
            // 
            this.Set.AutoSize = true;
            this.Set.Location = new System.Drawing.Point(622, 17);
            this.Set.Name = "Set";
            this.Set.Size = new System.Drawing.Size(13, 13);
            this.Set.TabIndex = 7;
            this.Set.Text = "1";
            // 
            // ClientCount
            // 
            this.ClientCount.AutoSize = true;
            this.ClientCount.Location = new System.Drawing.Point(711, 17);
            this.ClientCount.Name = "ClientCount";
            this.ClientCount.Size = new System.Drawing.Size(13, 13);
            this.ClientCount.TabIndex = 9;
            this.ClientCount.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(667, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Clients";
            // 
            // AsyncCaller
            // 
            this.AsyncCaller.Location = new System.Drawing.Point(45, 7);
            this.AsyncCaller.Name = "AsyncCaller";
            this.AsyncCaller.Size = new System.Drawing.Size(75, 23);
            this.AsyncCaller.TabIndex = 10;
            this.AsyncCaller.Text = "Async Caller";
            this.AsyncCaller.UseVisualStyleBackColor = true;
            this.AsyncCaller.Click += new System.EventHandler(this.AsyncCaller_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AsyncCaller);
            this.Controls.Add(this.ClientCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Set);
            this.Controls.Add(this.Get);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClientsLog);
            this.Controls.Add(this.ServerValueLog);
            this.Controls.Add(this.ActiveClients);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox ActiveClients;
        private System.Windows.Forms.ListBox ServerValueLog;
        private System.Windows.Forms.ListBox ClientsLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Get;
        private System.Windows.Forms.Label Set;
        private System.Windows.Forms.Label ClientCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AsyncCaller;
    }
}

