namespace Project.UI
{
    partial class SignUpAdvisor
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
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.salary = new Guna.UI2.WinForms.Guna2TextBox();
            this.Date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.RollNumberAssign = new System.Windows.Forms.Label();
            this.Gender = new Guna.UI2.WinForms.Guna2TextBox();
            this.ContactBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.LastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.FirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailLogon = new Guna.UI2.WinForms.Guna2TextBox();
            this.changer = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.AutoSize = true;
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2CustomGradientPanel2);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Purple;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Navy;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1182, 753);
            this.guna2CustomGradientPanel1.TabIndex = 2;
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2CustomGradientPanel2.Controls.Add(this.guna2ComboBox1);
            this.guna2CustomGradientPanel2.Controls.Add(this.salary);
            this.guna2CustomGradientPanel2.Controls.Add(this.Date);
            this.guna2CustomGradientPanel2.Controls.Add(this.RollNumberAssign);
            this.guna2CustomGradientPanel2.Controls.Add(this.Gender);
            this.guna2CustomGradientPanel2.Controls.Add(this.ContactBox);
            this.guna2CustomGradientPanel2.Controls.Add(this.LastName);
            this.guna2CustomGradientPanel2.Controls.Add(this.guna2GradientButton1);
            this.guna2CustomGradientPanel2.Controls.Add(this.FirstName);
            this.guna2CustomGradientPanel2.Controls.Add(this.emailLogon);
            this.guna2CustomGradientPanel2.Controls.Add(this.changer);
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(388, 65);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(443, 636);
            this.guna2CustomGradientPanel2.TabIndex = 0;
            this.guna2CustomGradientPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2CustomGradientPanel2_Paint);
            // 
            // salary
            // 
            this.salary.BorderColor = System.Drawing.Color.LightGray;
            this.salary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.salary.DefaultText = "";
            this.salary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.salary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.salary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.salary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.salary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.salary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.salary.ForeColor = System.Drawing.Color.Black;
            this.salary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.salary.Location = new System.Drawing.Point(38, 416);
            this.salary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.salary.Name = "salary";
            this.salary.PasswordChar = '\0';
            this.salary.PlaceholderForeColor = System.Drawing.Color.Black;
            this.salary.PlaceholderText = "Salary";
            this.salary.SelectedText = "";
            this.salary.Size = new System.Drawing.Size(138, 43);
            this.salary.TabIndex = 11;
            this.salary.TextChanged += new System.EventHandler(this.guna2TextBox4_TextChanged);
            // 
            // Date
            // 
            this.Date.BackColor = System.Drawing.Color.Transparent;
            this.Date.Checked = true;
            this.Date.FillColor = System.Drawing.Color.Silver;
            this.Date.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Date.ForeColor = System.Drawing.Color.Black;
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Date.Location = new System.Drawing.Point(39, 261);
            this.Date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(374, 36);
            this.Date.TabIndex = 1;
            this.Date.Value = new System.DateTime(2024, 3, 3, 0, 16, 42, 5);
            // 
            // RollNumberAssign
            // 
            this.RollNumberAssign.AutoSize = true;
            this.RollNumberAssign.BackColor = System.Drawing.Color.Transparent;
            this.RollNumberAssign.Location = new System.Drawing.Point(54, 446);
            this.RollNumberAssign.Name = "RollNumberAssign";
            this.RollNumberAssign.Size = new System.Drawing.Size(0, 16);
            this.RollNumberAssign.TabIndex = 8;
            // 
            // Gender
            // 
            this.Gender.BorderColor = System.Drawing.Color.LightGray;
            this.Gender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Gender.DefaultText = "";
            this.Gender.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Gender.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Gender.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Gender.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Gender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Gender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Gender.ForeColor = System.Drawing.Color.Black;
            this.Gender.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Gender.Location = new System.Drawing.Point(38, 365);
            this.Gender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Gender.Name = "Gender";
            this.Gender.PasswordChar = '\0';
            this.Gender.PlaceholderForeColor = System.Drawing.Color.Black;
            this.Gender.PlaceholderText = "Gender";
            this.Gender.SelectedText = "";
            this.Gender.Size = new System.Drawing.Size(374, 43);
            this.Gender.TabIndex = 7;
            // 
            // ContactBox
            // 
            this.ContactBox.BorderColor = System.Drawing.Color.LightGray;
            this.ContactBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ContactBox.DefaultText = "";
            this.ContactBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ContactBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ContactBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ContactBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ContactBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ContactBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ContactBox.ForeColor = System.Drawing.Color.Black;
            this.ContactBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ContactBox.Location = new System.Drawing.Point(38, 310);
            this.ContactBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ContactBox.Name = "ContactBox";
            this.ContactBox.PasswordChar = '\0';
            this.ContactBox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.ContactBox.PlaceholderText = "Contact";
            this.ContactBox.SelectedText = "";
            this.ContactBox.Size = new System.Drawing.Size(374, 43);
            this.ContactBox.TabIndex = 6;
            // 
            // LastName
            // 
            this.LastName.BorderColor = System.Drawing.Color.LightGray;
            this.LastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LastName.DefaultText = "";
            this.LastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LastName.ForeColor = System.Drawing.Color.Black;
            this.LastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LastName.Location = new System.Drawing.Point(38, 204);
            this.LastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LastName.Name = "LastName";
            this.LastName.PasswordChar = '\0';
            this.LastName.PlaceholderForeColor = System.Drawing.Color.Black;
            this.LastName.PlaceholderText = "Last Name";
            this.LastName.SelectedText = "";
            this.LastName.Size = new System.Drawing.Size(374, 43);
            this.LastName.TabIndex = 4;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.AutoRoundedCorners = true;
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderRadius = 22;
            this.guna2GradientButton1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.Cyan;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Purple;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.Location = new System.Drawing.Point(38, 524);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(374, 46);
            this.guna2GradientButton1.TabIndex = 3;
            this.guna2GradientButton1.Text = "Sign In";
            this.guna2GradientButton1.UseTransparentBackground = true;
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // FirstName
            // 
            this.FirstName.BorderColor = System.Drawing.Color.LightGray;
            this.FirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FirstName.DefaultText = "";
            this.FirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FirstName.ForeColor = System.Drawing.Color.Black;
            this.FirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FirstName.Location = new System.Drawing.Point(38, 153);
            this.FirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FirstName.Name = "FirstName";
            this.FirstName.PasswordChar = '\0';
            this.FirstName.PlaceholderForeColor = System.Drawing.Color.Black;
            this.FirstName.PlaceholderText = "First Name";
            this.FirstName.SelectedText = "";
            this.FirstName.Size = new System.Drawing.Size(374, 43);
            this.FirstName.TabIndex = 2;
            // 
            // emailLogon
            // 
            this.emailLogon.BorderColor = System.Drawing.Color.LightGray;
            this.emailLogon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailLogon.DefaultText = "";
            this.emailLogon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailLogon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailLogon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailLogon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailLogon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailLogon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailLogon.ForeColor = System.Drawing.Color.Black;
            this.emailLogon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailLogon.Location = new System.Drawing.Point(38, 98);
            this.emailLogon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailLogon.Name = "emailLogon";
            this.emailLogon.PasswordChar = '\0';
            this.emailLogon.PlaceholderForeColor = System.Drawing.Color.Black;
            this.emailLogon.PlaceholderText = "Email";
            this.emailLogon.SelectedText = "";
            this.emailLogon.Size = new System.Drawing.Size(374, 43);
            this.emailLogon.TabIndex = 1;
            // 
            // changer
            // 
            this.changer.BorderColor = System.Drawing.Color.Transparent;
            this.changer.BorderThickness = 0;
            this.changer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.changer.DefaultText = "Look Up";
            this.changer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.changer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.changer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.changer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.changer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.changer.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold);
            this.changer.ForeColor = System.Drawing.Color.Black;
            this.changer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.changer.Location = new System.Drawing.Point(101, 6);
            this.changer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.changer.Name = "changer";
            this.changer.PasswordChar = '\0';
            this.changer.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.changer.PlaceholderText = "";
            this.changer.SelectedText = "";
            this.changer.Size = new System.Drawing.Size(240, 83);
            this.changer.TabIndex = 0;
            this.changer.TextChanged += new System.EventHandler(this.changer_TextChanged);
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Location = new System.Drawing.Point(182, 420);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(230, 36);
            this.guna2ComboBox1.TabIndex = 13;
            // 
            // SignUpAdvisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "SignUpAdvisor";
            this.Text = "SignUpAdvisor";
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2DateTimePicker Date;
        private System.Windows.Forms.Label RollNumberAssign;
        private Guna.UI2.WinForms.Guna2TextBox Gender;
        private Guna.UI2.WinForms.Guna2TextBox ContactBox;
        private Guna.UI2.WinForms.Guna2TextBox LastName;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2TextBox FirstName;
        private Guna.UI2.WinForms.Guna2TextBox emailLogon;
        private Guna.UI2.WinForms.Guna2TextBox changer;
        private Guna.UI2.WinForms.Guna2TextBox salary;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
    }
}