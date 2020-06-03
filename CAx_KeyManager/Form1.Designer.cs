using System.Windows.Forms.VisualStyles;

namespace CAx_KeyManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TextBox_Student = new MetroFramework.Controls.MetroTextBox();
            this.Btn_AddOwner = new MetroFramework.Controls.MetroButton();
            this.RoomID_Input = new MetroFramework.Controls.MetroTextBox();
            this.OwnerDropDown = new MetroFramework.Controls.MetroComboBox();
            this.AddKey_Button = new MetroFramework.Controls.MetroButton();
            this.DeleteKey_Button = new MetroFramework.Controls.MetroButton();
            this.DataGrid_Key = new MetroFramework.Controls.MetroGrid();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Key)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(326, 108);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(103, 25);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Add Owner";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // TextBox_Student
            // 
            // 
            // 
            // 
            this.TextBox_Student.CustomButton.Image = null;
            this.TextBox_Student.CustomButton.Location = new System.Drawing.Point(87, 1);
            this.TextBox_Student.CustomButton.Name = "";
            this.TextBox_Student.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBox_Student.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_Student.CustomButton.TabIndex = 1;
            this.TextBox_Student.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_Student.CustomButton.UseSelectable = true;
            this.TextBox_Student.CustomButton.Visible = false;
            this.TextBox_Student.Lines = new string[0];
            this.TextBox_Student.Location = new System.Drawing.Point(330, 136);
            this.TextBox_Student.MaxLength = 32767;
            this.TextBox_Student.Name = "TextBox_Student";
            this.TextBox_Student.PasswordChar = '\0';
            this.TextBox_Student.PromptText = "Enter Last Name";
            this.TextBox_Student.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_Student.SelectedText = "";
            this.TextBox_Student.SelectionLength = 0;
            this.TextBox_Student.SelectionStart = 0;
            this.TextBox_Student.ShortcutsEnabled = true;
            this.TextBox_Student.Size = new System.Drawing.Size(109, 23);
            this.TextBox_Student.TabIndex = 8;
            this.TextBox_Student.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBox_Student.UseSelectable = true;
            this.TextBox_Student.WaterMark = "Enter Last Name";
            this.TextBox_Student.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_Student.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Btn_AddOwner
            // 
            this.Btn_AddOwner.Location = new System.Drawing.Point(330, 165);
            this.Btn_AddOwner.Name = "Btn_AddOwner";
            this.Btn_AddOwner.Size = new System.Drawing.Size(75, 23);
            this.Btn_AddOwner.TabIndex = 9;
            this.Btn_AddOwner.Text = "Add";
            this.Btn_AddOwner.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Btn_AddOwner.UseSelectable = true;
            this.Btn_AddOwner.Click += new System.EventHandler(this.Btn_AddOwner_Click);
            // 
            // RoomID_Input
            // 
            // 
            // 
            // 
            this.RoomID_Input.CustomButton.Image = null;
            this.RoomID_Input.CustomButton.Location = new System.Drawing.Point(81, 1);
            this.RoomID_Input.CustomButton.Name = "";
            this.RoomID_Input.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.RoomID_Input.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RoomID_Input.CustomButton.TabIndex = 1;
            this.RoomID_Input.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RoomID_Input.CustomButton.UseSelectable = true;
            this.RoomID_Input.CustomButton.Visible = false;
            this.RoomID_Input.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.RoomID_Input.Lines = new string[0];
            this.RoomID_Input.Location = new System.Drawing.Point(197, 42);
            this.RoomID_Input.MaxLength = 32767;
            this.RoomID_Input.Name = "RoomID_Input";
            this.RoomID_Input.PasswordChar = '\0';
            this.RoomID_Input.PromptText = "Enter Room Name";
            this.RoomID_Input.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RoomID_Input.SelectedText = "";
            this.RoomID_Input.SelectionLength = 0;
            this.RoomID_Input.SelectionStart = 0;
            this.RoomID_Input.ShortcutsEnabled = true;
            this.RoomID_Input.Size = new System.Drawing.Size(109, 29);
            this.RoomID_Input.TabIndex = 10;
            this.RoomID_Input.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RoomID_Input.UseSelectable = true;
            this.RoomID_Input.WaterMark = "Enter Room Name";
            this.RoomID_Input.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RoomID_Input.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // OwnerDropDown
            // 
            this.OwnerDropDown.FormattingEnabled = true;
            this.OwnerDropDown.ItemHeight = 23;
            this.OwnerDropDown.Location = new System.Drawing.Point(16, 42);
            this.OwnerDropDown.Name = "OwnerDropDown";
            this.OwnerDropDown.Size = new System.Drawing.Size(121, 29);
            this.OwnerDropDown.TabIndex = 11;
            this.OwnerDropDown.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.OwnerDropDown.UseSelectable = true;
            // 
            // AddKey_Button
            // 
            this.AddKey_Button.Location = new System.Drawing.Point(16, 77);
            this.AddKey_Button.Name = "AddKey_Button";
            this.AddKey_Button.Size = new System.Drawing.Size(75, 23);
            this.AddKey_Button.TabIndex = 12;
            this.AddKey_Button.Text = "Add";
            this.AddKey_Button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AddKey_Button.UseSelectable = true;
            this.AddKey_Button.Click += new System.EventHandler(this.AddKey_Button_Click);
            // 
            // DeleteKey_Button
            // 
            this.DeleteKey_Button.Location = new System.Drawing.Point(197, 77);
            this.DeleteKey_Button.Name = "DeleteKey_Button";
            this.DeleteKey_Button.Size = new System.Drawing.Size(75, 23);
            this.DeleteKey_Button.TabIndex = 13;
            this.DeleteKey_Button.Text = "Delete Key";
            this.DeleteKey_Button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DeleteKey_Button.UseSelectable = true;
            this.DeleteKey_Button.Click += new System.EventHandler(this.DeleteKey_Button_Click);
            // 
            // DataGrid_Key
            // 
            this.DataGrid_Key.AllowUserToAddRows = false;
            this.DataGrid_Key.AllowUserToResizeColumns = false;
            this.DataGrid_Key.AllowUserToResizeRows = false;
            this.DataGrid_Key.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGrid_Key.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid_Key.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGrid_Key.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_Key.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_Key.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid_Key.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid_Key.EnableHeadersVisualStyles = false;
            this.DataGrid_Key.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataGrid_Key.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGrid_Key.Location = new System.Drawing.Point(15, 108);
            this.DataGrid_Key.Name = "DataGrid_Key";
            this.DataGrid_Key.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_Key.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid_Key.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGrid_Key.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_Key.Size = new System.Drawing.Size(300, 230);
            this.DataGrid_Key.TabIndex = 14;
            this.DataGrid_Key.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_Key_CellValueChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(10, 16);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(162, 25);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Owner (Last Name)";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(190, 16);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(83, 25);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "Room ID";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.DataGrid_Key);
            this.Controls.Add(this.DeleteKey_Button);
            this.Controls.Add(this.AddKey_Button);
            this.Controls.Add(this.OwnerDropDown);
            this.Controls.Add(this.RoomID_Input);
            this.Controls.Add(this.Btn_AddOwner);
            this.Controls.Add(this.TextBox_Student);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Form1";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Key)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void DataGrid_Key_CellValueChanged1(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TextBox_Student;
        private MetroFramework.Controls.MetroButton Btn_AddOwner;
        private MetroFramework.Controls.MetroTextBox RoomID_Input;
        private MetroFramework.Controls.MetroComboBox OwnerDropDown;
        private MetroFramework.Controls.MetroButton AddKey_Button;
        private MetroFramework.Controls.MetroButton DeleteKey_Button;
        private MetroFramework.Controls.MetroGrid DataGrid_Key;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}

