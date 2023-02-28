using System;

namespace demo20
{
    partial class login_form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            this.login_button = new System.Windows.Forms.Button();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.login_textbox = new System.Windows.Forms.TextBox();
            this.panel_top = new System.Windows.Forms.Panel();
            this.logo_pic = new System.Windows.Forms.PictureBox();
            this.label_name = new System.Windows.Forms.Label();
            this.panel_bot = new System.Windows.Forms.Panel();
            this.label_login = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.login_button.Location = new System.Drawing.Point(117, 372);
            this.login_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(176, 62);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "Войти.";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(72, 272);
            this.password_textbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(260, 28);
            this.password_textbox.TabIndex = 1;
            // 
            // login_textbox
            // 
            this.login_textbox.Location = new System.Drawing.Point(72, 176);
            this.login_textbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.login_textbox.Name = "login_textbox";
            this.login_textbox.Size = new System.Drawing.Size(260, 28);
            this.login_textbox.TabIndex = 2;
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.panel_top.Controls.Add(this.logo_pic);
            this.panel_top.Controls.Add(this.label_name);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(409, 123);
            this.panel_top.TabIndex = 3;
            // 
            // logo_pic
            // 
            this.logo_pic.Image = ((System.Drawing.Image)(resources.GetObject("logo_pic.Image")));
            this.logo_pic.Location = new System.Drawing.Point(0, 3);
            this.logo_pic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.logo_pic.Name = "logo_pic";
            this.logo_pic.Size = new System.Drawing.Size(119, 120);
            this.logo_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_pic.TabIndex = 1;
            this.logo_pic.TabStop = false;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name.Location = new System.Drawing.Point(152, 45);
            this.label_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(202, 32);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "ООО «Рыбалка»";
            // 
            // panel_bot
            // 
            this.panel_bot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.panel_bot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bot.Location = new System.Drawing.Point(0, 639);
            this.panel_bot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel_bot.Name = "panel_bot";
            this.panel_bot.Size = new System.Drawing.Size(409, 141);
            this.panel_bot.TabIndex = 4;
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(71, 152);
            this.label_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(127, 21);
            this.label_login.TabIndex = 5;
            this.label_login.Text = "Введите логин.";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(71, 234);
            this.label_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(135, 21);
            this.label_password.TabIndex = 6;
            this.label_password.Text = "Введите пароль.";
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.exit_button.Location = new System.Drawing.Point(117, 465);
            this.exit_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(176, 62);
            this.exit_button.TabIndex = 7;
            this.exit_button.Text = "Выход из программы.";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(409, 780);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.panel_bot);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.login_textbox);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.login_button);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "login_form";
            this.Text = "Вход.";
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.TextBox login_textbox;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.PictureBox logo_pic;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Panel panel_bot;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_password;
        private EventHandler label_name_Click;
        private System.Windows.Forms.Button exit_button;
    }
}

