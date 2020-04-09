namespace ChatDesktop
{
    partial class Form1
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.txtGrp = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.joinBtn = new System.Windows.Forms.Button();
            this.grpMsgBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(91, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 0;
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(91, 106);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(100, 22);
            this.txtMsg.TabIndex = 1;
            // 
            // txtGrp
            // 
            this.txtGrp.Location = new System.Drawing.Point(91, 178);
            this.txtGrp.Name = "txtGrp";
            this.txtGrp.Size = new System.Drawing.Size(100, 22);
            this.txtGrp.TabIndex = 2;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(275, 106);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 30);
            this.sendBtn.TabIndex = 3;
            this.sendBtn.Text = "send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // joinBtn
            // 
            this.joinBtn.Location = new System.Drawing.Point(275, 178);
            this.joinBtn.Name = "joinBtn";
            this.joinBtn.Size = new System.Drawing.Size(75, 32);
            this.joinBtn.TabIndex = 4;
            this.joinBtn.Text = "join";
            this.joinBtn.UseVisualStyleBackColor = true;
            this.joinBtn.Click += new System.EventHandler(this.joinBtn_Click);
            // 
            // grpMsgBtn
            // 
            this.grpMsgBtn.Location = new System.Drawing.Point(65, 260);
            this.grpMsgBtn.Name = "grpMsgBtn";
            this.grpMsgBtn.Size = new System.Drawing.Size(196, 38);
            this.grpMsgBtn.TabIndex = 5;
            this.grpMsgBtn.Text = "send to group";
            this.grpMsgBtn.UseVisualStyleBackColor = true;
            this.grpMsgBtn.Click += new System.EventHandler(this.grpMsgBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Group";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(22, 341);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(328, 132);
            this.listBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpMsgBtn);
            this.Controls.Add(this.joinBtn);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.txtGrp);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Chat App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.TextBox txtGrp;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button joinBtn;
        private System.Windows.Forms.Button grpMsgBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
    }
}

