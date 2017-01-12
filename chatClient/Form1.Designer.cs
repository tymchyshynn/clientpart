namespace chatClient
{
    partial class chatForm
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
            this.enterChat = new System.Windows.Forms.Button();
            this.gui_userName = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.chatBox = new System.Windows.Forms.TextBox();
            this.chat_msg = new System.Windows.Forms.TextBox();
            this.chat_send = new System.Windows.Forms.Button();
            this.gui_chat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterChat
            // 
            this.enterChat.Location = new System.Drawing.Point(232, 7);
            this.enterChat.Name = "enterChat";
            this.enterChat.Size = new System.Drawing.Size(156, 22);
            this.enterChat.TabIndex = 0;
            this.enterChat.Text = "Приєднатись до бесіди";
            this.enterChat.UseVisualStyleBackColor = true;
            this.enterChat.Click += new System.EventHandler(this.enterChat_Click);
            // 
            // gui_userName
            // 
            this.gui_userName.AutoSize = true;
            this.gui_userName.Location = new System.Drawing.Point(12, 14);
            this.gui_userName.Name = "gui_userName";
            this.gui_userName.Size = new System.Drawing.Size(99, 13);
            this.gui_userName.TabIndex = 1;
            this.gui_userName.Text = "Введіть Ваше ім\'я:";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(117, 9);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(100, 20);
            this.userName.TabIndex = 2;
            // 
            // chatBox
            // 
            this.chatBox.Enabled = false;
            this.chatBox.Location = new System.Drawing.Point(15, 62);
            this.chatBox.Multiline = true;
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(418, 163);
            this.chatBox.TabIndex = 0;
            // 
            // chat_msg
            // 
            this.chat_msg.Enabled = false;
            this.chat_msg.Location = new System.Drawing.Point(15, 231);
            this.chat_msg.Name = "chat_msg";
            this.chat_msg.Size = new System.Drawing.Size(275, 20);
            this.chat_msg.TabIndex = 4;
            // 
            // chat_send
            // 
            this.chat_send.Enabled = false;
            this.chat_send.Location = new System.Drawing.Point(312, 231);
            this.chat_send.Name = "chat_send";
            this.chat_send.Size = new System.Drawing.Size(121, 23);
            this.chat_send.TabIndex = 3;
            this.chat_send.Text = "Відправити";
            this.chat_send.UseVisualStyleBackColor = true;
            this.chat_send.Click += new System.EventHandler(this.chat_send_Click);
            // 
            // gui_chat
            // 
            this.gui_chat.AutoSize = true;
            this.gui_chat.Location = new System.Drawing.Point(188, 46);
            this.gui_chat.Name = "gui_chat";
            this.gui_chat.Size = new System.Drawing.Size(26, 13);
            this.gui_chat.TabIndex = 5;
            this.gui_chat.Text = "Чат";
            // 
            // chatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 281);
            this.Controls.Add(this.gui_chat);
            this.Controls.Add(this.chat_msg);
            this.Controls.Add(this.chat_send);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.gui_userName);
            this.Controls.Add(this.enterChat);
            this.Name = "chatForm";
            this.Text = "Чат";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterChat;
        private System.Windows.Forms.Label gui_userName;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox chatBox;
        private System.Windows.Forms.TextBox chat_msg;
        private System.Windows.Forms.Button chat_send;
        private System.Windows.Forms.Label gui_chat;
    }
}

