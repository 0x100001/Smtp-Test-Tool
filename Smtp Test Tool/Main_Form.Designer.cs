namespace Smtp_Test_Tool
{
    partial class Main_Form
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.smtp_send_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.smtp_username_textbox = new System.Windows.Forms.TextBox();
            this.smtp_password_textbox = new System.Windows.Forms.TextBox();
            this.smtp_server_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.smtp_port_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.smtp_empfänger_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.secure_checkbox = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // smtp_send_button
            // 
            this.smtp_send_button.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.smtp_send_button.Location = new System.Drawing.Point(12, 211);
            this.smtp_send_button.Name = "smtp_send_button";
            this.smtp_send_button.Size = new System.Drawing.Size(427, 33);
            this.smtp_send_button.TabIndex = 0;
            this.smtp_send_button.Text = "Send";
            this.smtp_send_button.UseVisualStyleBackColor = true;
            this.smtp_send_button.Click += new System.EventHandler(this.smtp_send_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // smtp_username_textbox
            // 
            this.smtp_username_textbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smtp_username_textbox.Location = new System.Drawing.Point(102, 9);
            this.smtp_username_textbox.Name = "smtp_username_textbox";
            this.smtp_username_textbox.Size = new System.Drawing.Size(337, 25);
            this.smtp_username_textbox.TabIndex = 4;
            // 
            // smtp_password_textbox
            // 
            this.smtp_password_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smtp_password_textbox.Location = new System.Drawing.Point(102, 40);
            this.smtp_password_textbox.Name = "smtp_password_textbox";
            this.smtp_password_textbox.Size = new System.Drawing.Size(337, 29);
            this.smtp_password_textbox.TabIndex = 5;
            this.smtp_password_textbox.UseSystemPasswordChar = true;
            // 
            // smtp_server_textbox
            // 
            this.smtp_server_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smtp_server_textbox.Location = new System.Drawing.Point(102, 75);
            this.smtp_server_textbox.Name = "smtp_server_textbox";
            this.smtp_server_textbox.Size = new System.Drawing.Size(337, 29);
            this.smtp_server_textbox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Server:";
            // 
            // smtp_port_textbox
            // 
            this.smtp_port_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smtp_port_textbox.Location = new System.Drawing.Point(102, 110);
            this.smtp_port_textbox.Name = "smtp_port_textbox";
            this.smtp_port_textbox.Size = new System.Drawing.Size(337, 29);
            this.smtp_port_textbox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Port:";
            // 
            // smtp_empfänger_textbox
            // 
            this.smtp_empfänger_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smtp_empfänger_textbox.Location = new System.Drawing.Point(102, 145);
            this.smtp_empfänger_textbox.Name = "smtp_empfänger_textbox";
            this.smtp_empfänger_textbox.Size = new System.Drawing.Size(337, 29);
            this.smtp_empfänger_textbox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Recipient:";
            // 
            // secure_checkbox
            // 
            this.secure_checkbox.AutoSize = true;
            this.secure_checkbox.Checked = true;
            this.secure_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.secure_checkbox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.secure_checkbox.Location = new System.Drawing.Point(363, 180);
            this.secure_checkbox.Name = "secure_checkbox";
            this.secure_checkbox.Size = new System.Drawing.Size(76, 25);
            this.secure_checkbox.TabIndex = 12;
            this.secure_checkbox.Text = "Secure";
            this.secure_checkbox.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(215, 252);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(224, 13);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/0x100001/Smtp-Test-Tool";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 274);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.secure_checkbox);
            this.Controls.Add(this.smtp_empfänger_textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.smtp_port_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.smtp_server_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.smtp_password_textbox);
            this.Controls.Add(this.smtp_username_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.smtp_send_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMTP Test Tool";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button smtp_send_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox smtp_username_textbox;
        private System.Windows.Forms.TextBox smtp_password_textbox;
        private System.Windows.Forms.TextBox smtp_server_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox smtp_port_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox smtp_empfänger_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox secure_checkbox;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

