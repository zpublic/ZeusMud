﻿namespace zeus_mud.dialog
{
    partial class GameChatPanel
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSendContent = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.wbWorldChat = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // txtSendContent
            // 
            this.txtSendContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSendContent.Location = new System.Drawing.Point(3, 62);
            this.txtSendContent.Name = "txtSendContent";
            this.txtSendContent.Size = new System.Drawing.Size(187, 21);
            this.txtSendContent.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(196, 62);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(46, 21);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // wbWorldChat
            // 
            this.wbWorldChat.AllowWebBrowserDrop = false;
            this.wbWorldChat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbWorldChat.IsWebBrowserContextMenuEnabled = false;
            this.wbWorldChat.Location = new System.Drawing.Point(3, 4);
            this.wbWorldChat.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbWorldChat.Name = "wbWorldChat";
            this.wbWorldChat.Size = new System.Drawing.Size(239, 52);
            this.wbWorldChat.TabIndex = 3;
            this.wbWorldChat.WebBrowserShortcutsEnabled = false;
            // 
            // GameChatPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.wbWorldChat);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSendContent);
            this.Name = "GameChatPanel";
            this.Size = new System.Drawing.Size(298, 117);
            this.Load += new System.EventHandler(this.GameChatPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSendContent;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.WebBrowser wbWorldChat;

    }
}