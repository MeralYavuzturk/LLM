namespace LLM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rtbChat = new RichTextBox();
            txtInput = new TextBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // rtbChat
            // 
            rtbChat.BackColor = SystemColors.Info;
            rtbChat.Location = new Point(0, 0);
            rtbChat.Name = "rtbChat";
            rtbChat.Size = new Size(392, 449);
            rtbChat.TabIndex = 0;
            rtbChat.Text = "";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(0, 422);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(314, 27);
            txtInput.TabIndex = 1;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.NavajoWhite;
            btnSend.Location = new Point(314, 422);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(69, 27);
            btnSend.TabIndex = 2;
            btnSend.Text = "Gönder";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSend);
            Controls.Add(txtInput);
            Controls.Add(rtbChat);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbChat;
        private TextBox txtInput;
        private Button btnSend;
    }
}
