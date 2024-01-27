namespace WFConsumer
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.txt_group = new System.Windows.Forms.TextBox();
            this.btn_join = new System.Windows.Forms.Button();
            this.btn_sendgroup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_mess = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(519, 12);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(208, 38);
            this.txt_name.TabIndex = 0;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(537, 214);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(151, 40);
            this.btn_send.TabIndex = 1;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(223, 214);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(199, 38);
            this.txt_message.TabIndex = 2;
            // 
            // txt_group
            // 
            this.txt_group.Location = new System.Drawing.Point(223, 276);
            this.txt_group.Name = "txt_group";
            this.txt_group.Size = new System.Drawing.Size(201, 38);
            this.txt_group.TabIndex = 3;
            // 
            // btn_join
            // 
            this.btn_join.Location = new System.Drawing.Point(534, 277);
            this.btn_join.Name = "btn_join";
            this.btn_join.Size = new System.Drawing.Size(151, 37);
            this.btn_join.TabIndex = 5;
            this.btn_join.Text = "Join";
            this.btn_join.UseVisualStyleBackColor = true;
            this.btn_join.Click += new System.EventHandler(this.btn_join_Click);
            // 
            // btn_sendgroup
            // 
            this.btn_sendgroup.Location = new System.Drawing.Point(319, 369);
            this.btn_sendgroup.Name = "btn_sendgroup";
            this.btn_sendgroup.Size = new System.Drawing.Size(233, 71);
            this.btn_sendgroup.TabIndex = 6;
            this.btn_sendgroup.Text = "Send To Group";
            this.btn_sendgroup.UseVisualStyleBackColor = true;
            this.btn_sendgroup.Click += new System.EventHandler(this.btn_sendgroup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "group";
            // 
            // lb_mess
            // 
            this.lb_mess.FormattingEnabled = true;
            this.lb_mess.ItemHeight = 31;
            this.lb_mess.Location = new System.Drawing.Point(77, 477);
            this.lb_mess.Name = "lb_mess";
            this.lb_mess.Size = new System.Drawing.Size(1069, 283);
            this.lb_mess.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 776);
            this.Controls.Add(this.lb_mess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sendgroup);
            this.Controls.Add(this.btn_join);
            this.Controls.Add(this.txt_group);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.TextBox txt_group;
        private System.Windows.Forms.Button btn_join;
        private System.Windows.Forms.Button btn_sendgroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lb_mess;
    }
}

