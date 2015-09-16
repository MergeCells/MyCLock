namespace MyClock
{
    partial class Display
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timeNow = new System.Windows.Forms.Label();
            this.secTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timeNow
            // 
            this.timeNow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeNow.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.timeNow.Location = new System.Drawing.Point(0, 0);
            this.timeNow.Name = "timeNow";
            this.timeNow.Size = new System.Drawing.Size(332, 86);
            this.timeNow.TabIndex = 0;
            this.timeNow.Text = "12時34分56秒";
            this.timeNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeNow.Click += new System.EventHandler(this.timeNow_Click);
            // 
            // secTimer
            // 
            this.secTimer.Enabled = true;
            this.secTimer.Interval = 1000;
            this.secTimer.Tick += new System.EventHandler(this.secTimer_Tick);
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 86);
            this.Controls.Add(this.timeNow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Display";
            this.Opacity = 0.5D;
            this.Text = "MyClock";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Display_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label timeNow;
        private System.Windows.Forms.Timer secTimer;
    }
}

