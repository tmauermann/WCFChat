﻿namespace WCFChatClient
{
    partial class ChatroomUnisex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatroomUnisex));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHistory = new System.Windows.Forms.TextBox();
            this.checkBoxAutoRefresh = new System.Windows.Forms.CheckBox();
            this.pictureBoxSend = new System.Windows.Forms.PictureBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.pictureBoxRefresh = new System.Windows.Forms.PictureBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.textBoxChat = new System.Windows.Forms.TextBox();
            this.pictureBoxMessage = new System.Windows.Forms.PictureBox();
            this.labelChatID = new System.Windows.Forms.Label();
            this.pictureBoxBin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(620, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Chat History";
            // 
            // textBoxHistory
            // 
            this.textBoxHistory.BackColor = System.Drawing.Color.DarkGray;
            this.textBoxHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHistory.Location = new System.Drawing.Point(579, 43);
            this.textBoxHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxHistory.Multiline = true;
            this.textBoxHistory.Name = "textBoxHistory";
            this.textBoxHistory.ReadOnly = true;
            this.textBoxHistory.Size = new System.Drawing.Size(201, 260);
            this.textBoxHistory.TabIndex = 15;
            // 
            // checkBoxAutoRefresh
            // 
            this.checkBoxAutoRefresh.AutoSize = true;
            this.checkBoxAutoRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxAutoRefresh.Location = new System.Drawing.Point(61, 14);
            this.checkBoxAutoRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxAutoRefresh.Name = "checkBoxAutoRefresh";
            this.checkBoxAutoRefresh.Size = new System.Drawing.Size(109, 21);
            this.checkBoxAutoRefresh.TabIndex = 14;
            this.checkBoxAutoRefresh.Text = "Auto Refresh";
            this.checkBoxAutoRefresh.UseVisualStyleBackColor = true;
            // 
            // pictureBoxSend
            // 
            this.pictureBoxSend.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSend.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSend.Image")));
            this.pictureBoxSend.Location = new System.Drawing.Point(736, 342);
            this.pictureBoxSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxSend.Name = "pictureBoxSend";
            this.pictureBoxSend.Size = new System.Drawing.Size(43, 39);
            this.pictureBoxSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSend.TabIndex = 13;
            this.pictureBoxSend.TabStop = false;
            this.pictureBoxSend.Click += new System.EventHandler(this.pictureBoxSend_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(63, 322);
            this.labelMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(65, 17);
            this.labelMessage.TabIndex = 12;
            this.labelMessage.Text = "Message";
            // 
            // pictureBoxRefresh
            // 
            this.pictureBoxRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRefresh.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRefresh.Image")));
            this.pictureBoxRefresh.Location = new System.Drawing.Point(16, 7);
            this.pictureBoxRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxRefresh.Name = "pictureBoxRefresh";
            this.pictureBoxRefresh.Size = new System.Drawing.Size(37, 32);
            this.pictureBoxRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRefresh.TabIndex = 11;
            this.pictureBoxRefresh.TabStop = false;
            this.pictureBoxRefresh.Click += new System.EventHandler(this.pictureBoxRefresh_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMessage.Location = new System.Drawing.Point(67, 342);
            this.textBoxMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMessage.Size = new System.Drawing.Size(667, 39);
            this.textBoxMessage.TabIndex = 10;
            // 
            // textBoxChat
            // 
            this.textBoxChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxChat.Location = new System.Drawing.Point(16, 43);
            this.textBoxChat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxChat.Multiline = true;
            this.textBoxChat.Name = "textBoxChat";
            this.textBoxChat.ReadOnly = true;
            this.textBoxChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxChat.Size = new System.Drawing.Size(554, 260);
            this.textBoxChat.TabIndex = 9;
            // 
            // pictureBoxMessage
            // 
            this.pictureBoxMessage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMessage.Image")));
            this.pictureBoxMessage.Location = new System.Drawing.Point(16, 342);
            this.pictureBoxMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxMessage.Name = "pictureBoxMessage";
            this.pictureBoxMessage.Size = new System.Drawing.Size(43, 39);
            this.pictureBoxMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMessage.TabIndex = 18;
            this.pictureBoxMessage.TabStop = false;
            // 
            // labelChatID
            // 
            this.labelChatID.AutoSize = true;
            this.labelChatID.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChatID.Location = new System.Drawing.Point(719, 7);
            this.labelChatID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChatID.Name = "labelChatID";
            this.labelChatID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelChatID.Size = new System.Drawing.Size(60, 15);
            this.labelChatID.TabIndex = 19;
            this.labelChatID.Text = "Chat ID: 2";
            // 
            // pictureBoxBin
            // 
            this.pictureBoxBin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBin.Image")));
            this.pictureBoxBin.Location = new System.Drawing.Point(579, 7);
            this.pictureBoxBin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxBin.Name = "pictureBoxBin";
            this.pictureBoxBin.Size = new System.Drawing.Size(37, 32);
            this.pictureBoxBin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBin.TabIndex = 20;
            this.pictureBoxBin.TabStop = false;
            this.pictureBoxBin.Click += new System.EventHandler(this.pictureBoxBin_Click);
            // 
            // ChatroomUnisex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 393);
            this.Controls.Add(this.pictureBoxBin);
            this.Controls.Add(this.labelChatID);
            this.Controls.Add(this.pictureBoxMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxHistory);
            this.Controls.Add(this.checkBoxAutoRefresh);
            this.Controls.Add(this.pictureBoxSend);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.pictureBoxRefresh);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.textBoxChat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChatroomUnisex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chatroom - Unisex";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHistory;
        private System.Windows.Forms.CheckBox checkBoxAutoRefresh;
        private System.Windows.Forms.PictureBox pictureBoxSend;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.PictureBox pictureBoxRefresh;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.TextBox textBoxChat;
        private System.Windows.Forms.PictureBox pictureBoxMessage;
        private System.Windows.Forms.Label labelChatID;
        private System.Windows.Forms.PictureBox pictureBoxBin;
    }
}