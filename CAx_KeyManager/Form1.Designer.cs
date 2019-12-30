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
            this.Owner_Label = new System.Windows.Forms.Label();
            this.RoomID_Label = new System.Windows.Forms.Label();
            this.Owner_Input = new System.Windows.Forms.TextBox();
            this.RoomID_Input = new System.Windows.Forms.TextBox();
            this.DataGrid_Key = new System.Windows.Forms.DataGridView();
            this.Owner_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomID_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddName_Button = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Key)).BeginInit();
            this.SuspendLayout();
            // 
            // Owner_Label
            // 
            this.Owner_Label.AutoSize = true;
            this.Owner_Label.Location = new System.Drawing.Point(12, 9);
            this.Owner_Label.Name = "Owner_Label";
            this.Owner_Label.Size = new System.Drawing.Size(98, 13);
            this.Owner_Label.TabIndex = 0;
            this.Owner_Label.Text = "Owner (Last Name)";
            // 
            // RoomID_Label
            // 
            this.RoomID_Label.AutoSize = true;
            this.RoomID_Label.Location = new System.Drawing.Point(173, 9);
            this.RoomID_Label.Name = "RoomID_Label";
            this.RoomID_Label.Size = new System.Drawing.Size(49, 13);
            this.RoomID_Label.TabIndex = 1;
            this.RoomID_Label.Text = "Room ID";
            // 
            // Owner_Input
            // 
            this.Owner_Input.Location = new System.Drawing.Point(15, 25);
            this.Owner_Input.Name = "Owner_Input";
            this.Owner_Input.Size = new System.Drawing.Size(100, 20);
            this.Owner_Input.TabIndex = 2;
            // 
            // RoomID_Input
            // 
            this.RoomID_Input.Location = new System.Drawing.Point(176, 25);
            this.RoomID_Input.Name = "RoomID_Input";
            this.RoomID_Input.Size = new System.Drawing.Size(100, 20);
            this.RoomID_Input.TabIndex = 3;
            // 
            // DataGrid_Key
            // 
            this.DataGrid_Key.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Key.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Owner_Column,
            this.ID_Column,
            this.RoomID_Column});
            this.DataGrid_Key.Location = new System.Drawing.Point(1, 85);
            this.DataGrid_Key.Name = "DataGrid_Key";
            this.DataGrid_Key.Size = new System.Drawing.Size(340, 233);
            this.DataGrid_Key.TabIndex = 4;
            // 
            // Owner_Column
            // 
            this.Owner_Column.HeaderText = "Owner";
            this.Owner_Column.Name = "Owner_Column";
            this.Owner_Column.ReadOnly = true;
            // 
            // ID_Column
            // 
            this.ID_Column.HeaderText = "ID";
            this.ID_Column.Name = "ID_Column";
            this.ID_Column.ReadOnly = true;
            // 
            // RoomID_Column
            // 
            this.RoomID_Column.HeaderText = "Room ID";
            this.RoomID_Column.Name = "RoomID_Column";
            this.RoomID_Column.ReadOnly = true;
            // 
            // AddName_Button
            // 
            this.AddName_Button.Location = new System.Drawing.Point(15, 53);
            this.AddName_Button.Name = "AddName_Button";
            this.AddName_Button.Size = new System.Drawing.Size(75, 23);
            this.AddName_Button.TabIndex = 5;
            this.AddName_Button.Text = "Ok";
            this.AddName_Button.UseVisualStyleBackColor = true;
            this.AddName_Button.Click += new System.EventHandler(this.AddName_Button_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(176, 53);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 330);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.AddName_Button);
            this.Controls.Add(this.DataGrid_Key);
            this.Controls.Add(this.RoomID_Input);
            this.Controls.Add(this.Owner_Input);
            this.Controls.Add(this.RoomID_Label);
            this.Controls.Add(this.Owner_Label);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Key)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Owner_Label;
        private System.Windows.Forms.Label RoomID_Label;
        private System.Windows.Forms.TextBox Owner_Input;
        private System.Windows.Forms.TextBox RoomID_Input;
        private System.Windows.Forms.DataGridView DataGrid_Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owner_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomID_Column;
        private System.Windows.Forms.Button AddName_Button;
        private System.Windows.Forms.Button ClearButton;
    }
}

