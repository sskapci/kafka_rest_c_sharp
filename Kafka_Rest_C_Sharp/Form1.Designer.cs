namespace Kafka_Rest_C_Sharp
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
            this.btn_send = new System.Windows.Forms.Button();
            this.txt_server = new System.Windows.Forms.TextBox();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_auto = new System.Windows.Forms.Button();
            this.btn_get = new System.Windows.Forms.Button();
            this.txt_info = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(254, 82);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 0;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // txt_server
            // 
            this.txt_server.Location = new System.Drawing.Point(136, 28);
            this.txt_server.Name = "txt_server";
            this.txt_server.Size = new System.Drawing.Size(193, 20);
            this.txt_server.TabIndex = 1;
            this.txt_server.Text = "http://localhost:8082/topics/test";
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(136, 56);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(193, 20);
            this.txt_message.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Server Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Message";
            // 
            // btn_auto
            // 
            this.btn_auto.Location = new System.Drawing.Point(254, 111);
            this.btn_auto.Name = "btn_auto";
            this.btn_auto.Size = new System.Drawing.Size(75, 23);
            this.btn_auto.TabIndex = 5;
            this.btn_auto.Text = "Auto Send";
            this.btn_auto.UseVisualStyleBackColor = true;
            this.btn_auto.Click += new System.EventHandler(this.btn_auto_Click);
            // 
            // btn_get
            // 
            this.btn_get.Location = new System.Drawing.Point(173, 82);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(75, 23);
            this.btn_get.TabIndex = 6;
            this.btn_get.Text = "Get Info";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // txt_info
            // 
            this.txt_info.Location = new System.Drawing.Point(12, 150);
            this.txt_info.Multiline = true;
            this.txt_info.Name = "txt_info";
            this.txt_info.ReadOnly = true;
            this.txt_info.Size = new System.Drawing.Size(317, 170);
            this.txt_info.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Get Info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 332);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_info);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.btn_auto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.txt_server);
            this.Controls.Add(this.btn_send);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(364, 371);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(364, 371);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kafka Rest Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox txt_server;
        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_auto;
        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.TextBox txt_info;
        private System.Windows.Forms.Label label3;
    }
}

