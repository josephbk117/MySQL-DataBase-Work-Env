namespace MySQLDataBaseInterface
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.commandTextBox = new System.Windows.Forms.TextBox();
            this.commandButton = new System.Windows.Forms.Button();
            this.result_richText = new System.Windows.Forms.RichTextBox();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.panelTableData = new System.Windows.Forms.Panel();
            this.labelTableName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelDatabaseName = new System.Windows.Forms.Label();
            this.textBoxDatabase = new System.Windows.Forms.TextBox();
            this.panelTableData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // commandTextBox
            // 
            this.commandTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commandTextBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F);
            this.commandTextBox.Location = new System.Drawing.Point(13, 45);
            this.commandTextBox.Name = "commandTextBox";
            this.commandTextBox.Size = new System.Drawing.Size(772, 26);
            this.commandTextBox.TabIndex = 0;
            // 
            // commandButton
            // 
            this.commandButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.commandButton.Font = new System.Drawing.Font("Camp", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandButton.Location = new System.Drawing.Point(793, 48);
            this.commandButton.Name = "commandButton";
            this.commandButton.Size = new System.Drawing.Size(75, 23);
            this.commandButton.TabIndex = 1;
            this.commandButton.Text = "SEND";
            this.commandButton.UseVisualStyleBackColor = true;
            this.commandButton.Click += new System.EventHandler(this.commandButton_Click);
            // 
            // result_richText
            // 
            this.result_richText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result_richText.BackColor = System.Drawing.Color.Gray;
            this.result_richText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result_richText.DetectUrls = false;
            this.result_richText.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_richText.ForeColor = System.Drawing.Color.White;
            this.result_richText.Location = new System.Drawing.Point(12, 77);
            this.result_richText.Name = "result_richText";
            this.result_richText.ReadOnly = true;
            this.result_richText.Size = new System.Drawing.Size(856, 177);
            this.result_richText.TabIndex = 2;
            this.result_richText.Text = "";
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userIdTextBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F);
            this.userIdTextBox.Location = new System.Drawing.Point(173, 13);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.Size = new System.Drawing.Size(200, 26);
            this.userIdTextBox.TabIndex = 3;
            this.userIdTextBox.Text = "User Id";
            this.userIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userIdTextBox.Click += new System.EventHandler(this.OnClick_RemoveText);
            // 
            // connectButton
            // 
            this.connectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.connectButton.Font = new System.Drawing.Font("Camp", 12F);
            this.connectButton.Location = new System.Drawing.Point(793, 13);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 6;
            this.connectButton.Text = "CONNECT";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F);
            this.passwordTextBox.Location = new System.Drawing.Point(379, 13);
            this.passwordTextBox.MaxLength = 35;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(200, 26);
            this.passwordTextBox.TabIndex = 5;
            this.passwordTextBox.Text = "Password";
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.Click += new System.EventHandler(this.OnClick_RemoveText);
            // 
            // panelTableData
            // 
            this.panelTableData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTableData.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelTableData.Controls.Add(this.labelTableName);
            this.panelTableData.Controls.Add(this.dataGridView1);
            this.panelTableData.Controls.Add(this.labelDatabaseName);
            this.panelTableData.Location = new System.Drawing.Point(12, 260);
            this.panelTableData.Name = "panelTableData";
            this.panelTableData.Size = new System.Drawing.Size(856, 146);
            this.panelTableData.TabIndex = 7;
            // 
            // labelTableName
            // 
            this.labelTableName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelTableName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTableName.Location = new System.Drawing.Point(351, 39);
            this.labelTableName.Name = "labelTableName";
            this.labelTableName.Size = new System.Drawing.Size(156, 18);
            this.labelTableName.TabIndex = 2;
            this.labelTableName.Text = "Table Name : NULL";
            this.labelTableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(3, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(850, 83);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowValidated);
            // 
            // labelDatabaseName
            // 
            this.labelDatabaseName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDatabaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatabaseName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDatabaseName.Location = new System.Drawing.Point(330, 12);
            this.labelDatabaseName.Name = "labelDatabaseName";
            this.labelDatabaseName.Size = new System.Drawing.Size(193, 18);
            this.labelDatabaseName.TabIndex = 0;
            this.labelDatabaseName.Text = "Data Base Name : NULL";
            this.labelDatabaseName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDatabase
            // 
            this.textBoxDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDatabase.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F);
            this.textBoxDatabase.Location = new System.Drawing.Point(585, 13);
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.Size = new System.Drawing.Size(200, 26);
            this.textBoxDatabase.TabIndex = 8;
            this.textBoxDatabase.Text = "Database";
            this.textBoxDatabase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDatabase.Click += new System.EventHandler(this.OnClick_RemoveText);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(880, 408);
            this.Controls.Add(this.textBoxDatabase);
            this.Controls.Add(this.panelTableData);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userIdTextBox);
            this.Controls.Add(this.result_richText);
            this.Controls.Add(this.commandButton);
            this.Controls.Add(this.commandTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MySQL Database Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panelTableData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox commandTextBox;
        private System.Windows.Forms.Button commandButton;
        private System.Windows.Forms.RichTextBox result_richText;
        private System.Windows.Forms.TextBox userIdTextBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Panel panelTableData;
        private System.Windows.Forms.Label labelDatabaseName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxDatabase;
        private System.Windows.Forms.Label labelTableName;
    }
}

