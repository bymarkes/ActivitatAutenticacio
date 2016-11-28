namespace ActivitatAutenticacio
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
            this.logName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logPass = new System.Windows.Forms.TextBox();
            this.signPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.signName = new System.Windows.Forms.TextBox();
            this.signPass2 = new System.Windows.Forms.TextBox();
            this.logButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logName
            // 
            this.logName.Location = new System.Drawing.Point(89, 54);
            this.logName.Name = "logName";
            this.logName.Size = new System.Drawing.Size(100, 20);
            this.logName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOG IN";
            // 
            // logPass
            // 
            this.logPass.Location = new System.Drawing.Point(89, 94);
            this.logPass.Name = "logPass";
            this.logPass.PasswordChar = '*';
            this.logPass.Size = new System.Drawing.Size(100, 20);
            this.logPass.TabIndex = 2;
            // 
            // signPass
            // 
            this.signPass.Location = new System.Drawing.Point(89, 220);
            this.signPass.Name = "signPass";
            this.signPass.PasswordChar = '*';
            this.signPass.Size = new System.Drawing.Size(100, 20);
            this.signPass.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(100, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "SIGN UP";
            // 
            // signName
            // 
            this.signName.Location = new System.Drawing.Point(89, 180);
            this.signName.Name = "signName";
            this.signName.Size = new System.Drawing.Size(100, 20);
            this.signName.TabIndex = 3;
            // 
            // signPass2
            // 
            this.signPass2.Location = new System.Drawing.Point(89, 259);
            this.signPass2.Name = "signPass2";
            this.signPass2.PasswordChar = '*';
            this.signPass2.Size = new System.Drawing.Size(100, 20);
            this.signPass2.TabIndex = 6;
            // 
            // logButton
            // 
            this.logButton.Location = new System.Drawing.Point(244, 71);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(75, 23);
            this.logButton.TabIndex = 7;
            this.logButton.Text = "LOG IN";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "User";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Password";
            // 
            // signUpButton
            // 
            this.signUpButton.Location = new System.Drawing.Point(244, 217);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(75, 23);
            this.signUpButton.TabIndex = 14;
            this.signUpButton.Text = "SIGNUP";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 322);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.signPass2);
            this.Controls.Add(this.signPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.signName);
            this.Controls.Add(this.logPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox logPass;
        private System.Windows.Forms.TextBox signPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox signName;
        private System.Windows.Forms.TextBox signPass2;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button signUpButton;
    }
}

