namespace TestApp
{
    partial class Directory
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
            this.DirectoryLabel = new System.Windows.Forms.Label();
            this.DirectoryDataGridView = new System.Windows.Forms.DataGridView();
            this.ObjName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamingTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.NamingLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DirectoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DirectoryLabel
            // 
            this.DirectoryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DirectoryLabel.AutoSize = true;
            this.DirectoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DirectoryLabel.Location = new System.Drawing.Point(469, 54);
            this.DirectoryLabel.Name = "DirectoryLabel";
            this.DirectoryLabel.Size = new System.Drawing.Size(121, 25);
            this.DirectoryLabel.TabIndex = 0;
            this.DirectoryLabel.Text = "Справочник";
            // 
            // DirectoryDataGridView
            // 
            this.DirectoryDataGridView.AllowUserToAddRows = false;
            this.DirectoryDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DirectoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DirectoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DirectoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ObjName,
            this.ID});
            this.DirectoryDataGridView.Location = new System.Drawing.Point(195, 224);
            this.DirectoryDataGridView.Name = "DirectoryDataGridView";
            this.DirectoryDataGridView.RowHeadersVisible = false;
            this.DirectoryDataGridView.RowHeadersWidth = 51;
            this.DirectoryDataGridView.RowTemplate.Height = 24;
            this.DirectoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DirectoryDataGridView.Size = new System.Drawing.Size(659, 250);
            this.DirectoryDataGridView.TabIndex = 1;
            // 
            // ObjName
            // 
            this.ObjName.HeaderText = "Наименование";
            this.ObjName.MinimumWidth = 6;
            this.ObjName.Name = "ObjName";
            // 
            // ID
            // 
            this.ID.HeaderText = "Идентификатор";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // NamingTextBox
            // 
            this.NamingTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NamingTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NamingTextBox.Location = new System.Drawing.Point(374, 126);
            this.NamingTextBox.Name = "NamingTextBox";
            this.NamingTextBox.Size = new System.Drawing.Size(286, 22);
            this.NamingTextBox.TabIndex = 2;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.IDTextBox.Location = new System.Drawing.Point(374, 169);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(286, 22);
            this.IDTextBox.TabIndex = 3;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddButton.AutoSize = true;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(740, 140);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(114, 35);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // NamingLabel
            // 
            this.NamingLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NamingLabel.AutoSize = true;
            this.NamingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NamingLabel.Location = new System.Drawing.Point(190, 122);
            this.NamingLabel.Name = "NamingLabel";
            this.NamingLabel.Size = new System.Drawing.Size(149, 25);
            this.NamingLabel.TabIndex = 5;
            this.NamingLabel.Text = "Наименование";
            // 
            // IDLabel
            // 
            this.IDLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDLabel.Location = new System.Drawing.Point(190, 165);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(167, 25);
            this.IDLabel.TabIndex = 6;
            this.IDLabel.Text = "Идентификатор";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteButton.Location = new System.Drawing.Point(753, 509);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(101, 35);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveButton.AutoSize = true;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(195, 509);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(121, 35);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Directory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 567);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.NamingLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.NamingTextBox);
            this.Controls.Add(this.DirectoryDataGridView);
            this.Controls.Add(this.DirectoryLabel);
            this.Name = "Directory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Directory";
            this.Load += new System.EventHandler(this.Directory_Load);
            this.Resize += new System.EventHandler(this.Directory_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.DirectoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DirectoryLabel;
        private System.Windows.Forms.DataGridView DirectoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.TextBox NamingTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label NamingLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SaveButton;
    }
}