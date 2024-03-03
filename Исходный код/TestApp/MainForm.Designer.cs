using System.Windows.Forms;

namespace TestApp
{
    partial class MainForm
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
            this.ReceptionFieldLabel = new System.Windows.Forms.Label();
            this.ShipmentFiledLabel = new System.Windows.Forms.Label();
            this.ReceptionTextBox = new System.Windows.Forms.TextBox();
            this.ShipmentTextBox = new System.Windows.Forms.TextBox();
            this.ReceptionLabel = new System.Windows.Forms.Label();
            this.ShipmentLabel = new System.Windows.Forms.Label();
            this.ReceptionDataGridView = new System.Windows.Forms.DataGridView();
            this.ReceptionObjName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceptionObjAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipmentDataGridView = new System.Windows.Forms.DataGridView();
            this.ShipmentObjName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShimpentObjAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DirectoryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReceptionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShipmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ReceptionFieldLabel
            // 
            this.ReceptionFieldLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReceptionFieldLabel.AutoSize = true;
            this.ReceptionFieldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReceptionFieldLabel.Location = new System.Drawing.Point(137, 42);
            this.ReceptionFieldLabel.Name = "ReceptionFieldLabel";
            this.ReceptionFieldLabel.Size = new System.Drawing.Size(307, 25);
            this.ReceptionFieldLabel.TabIndex = 0;
            this.ReceptionFieldLabel.Text = "Поле ввода данных для приёма";
            // 
            // ShipmentFiledLabel
            // 
            this.ShipmentFiledLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShipmentFiledLabel.AutoSize = true;
            this.ShipmentFiledLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShipmentFiledLabel.Location = new System.Drawing.Point(763, 42);
            this.ShipmentFiledLabel.Name = "ShipmentFiledLabel";
            this.ShipmentFiledLabel.Size = new System.Drawing.Size(319, 25);
            this.ShipmentFiledLabel.TabIndex = 1;
            this.ShipmentFiledLabel.Text = "Поле ввода данных для отгрузки";
            // 
            // ReceptionTextBox
            // 
            this.ReceptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReceptionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ReceptionTextBox.Location = new System.Drawing.Point(142, 70);
            this.ReceptionTextBox.Name = "ReceptionTextBox";
            this.ReceptionTextBox.Size = new System.Drawing.Size(302, 22);
            this.ReceptionTextBox.TabIndex = 2;
            this.ReceptionTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReceptionTextBox_KeyDown);
            // 
            // ShipmentTextBox
            // 
            this.ShipmentTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShipmentTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ShipmentTextBox.Location = new System.Drawing.Point(768, 70);
            this.ShipmentTextBox.Name = "ShipmentTextBox";
            this.ShipmentTextBox.Size = new System.Drawing.Size(314, 22);
            this.ShipmentTextBox.TabIndex = 3;
            this.ShipmentTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShipmentTextBox_KeyDown);
            // 
            // ReceptionLabel
            // 
            this.ReceptionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReceptionLabel.AutoSize = true;
            this.ReceptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReceptionLabel.Location = new System.Drawing.Point(237, 119);
            this.ReceptionLabel.Name = "ReceptionLabel";
            this.ReceptionLabel.Size = new System.Drawing.Size(81, 25);
            this.ReceptionLabel.TabIndex = 4;
            this.ReceptionLabel.Text = "ПРИЁМ";
            // 
            // ShipmentLabel
            // 
            this.ShipmentLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShipmentLabel.AutoSize = true;
            this.ShipmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShipmentLabel.Location = new System.Drawing.Point(883, 119);
            this.ShipmentLabel.Name = "ShipmentLabel";
            this.ShipmentLabel.Size = new System.Drawing.Size(113, 25);
            this.ShipmentLabel.TabIndex = 5;
            this.ShipmentLabel.Text = "ОТГРУЗКА";
            // 
            // ReceptionDataGridView
            // 
            this.ReceptionDataGridView.AllowUserToAddRows = false;
            this.ReceptionDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReceptionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReceptionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReceptionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReceptionObjName,
            this.ReceptionObjAmount});
            this.ReceptionDataGridView.Location = new System.Drawing.Point(12, 147);
            this.ReceptionDataGridView.Name = "ReceptionDataGridView";
            this.ReceptionDataGridView.ReadOnly = true;
            this.ReceptionDataGridView.RowHeadersVisible = false;
            this.ReceptionDataGridView.RowHeadersWidth = 51;
            this.ReceptionDataGridView.RowTemplate.Height = 24;
            this.ReceptionDataGridView.Size = new System.Drawing.Size(550, 300);
            this.ReceptionDataGridView.TabIndex = 13;
            // 
            // ReceptionObjName
            // 
            this.ReceptionObjName.HeaderText = "Наименование";
            this.ReceptionObjName.MinimumWidth = 6;
            this.ReceptionObjName.Name = "ReceptionObjName";
            this.ReceptionObjName.ReadOnly = true;
            // 
            // ReceptionObjAmount
            // 
            this.ReceptionObjAmount.FillWeight = 50F;
            this.ReceptionObjAmount.HeaderText = "Количество";
            this.ReceptionObjAmount.MinimumWidth = 6;
            this.ReceptionObjAmount.Name = "ReceptionObjAmount";
            this.ReceptionObjAmount.ReadOnly = true;
            // 
            // ShipmentDataGridView
            // 
            this.ShipmentDataGridView.AllowUserToAddRows = false;
            this.ShipmentDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShipmentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ShipmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShipmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShipmentObjName,
            this.ShimpentObjAmount});
            this.ShipmentDataGridView.Location = new System.Drawing.Point(624, 147);
            this.ShipmentDataGridView.Name = "ShipmentDataGridView";
            this.ShipmentDataGridView.ReadOnly = true;
            this.ShipmentDataGridView.RowHeadersVisible = false;
            this.ShipmentDataGridView.RowHeadersWidth = 51;
            this.ShipmentDataGridView.RowTemplate.Height = 24;
            this.ShipmentDataGridView.Size = new System.Drawing.Size(550, 300);
            this.ShipmentDataGridView.TabIndex = 14;
            // 
            // ShipmentObjName
            // 
            this.ShipmentObjName.HeaderText = "Наименование";
            this.ShipmentObjName.MinimumWidth = 6;
            this.ShipmentObjName.Name = "ShipmentObjName";
            this.ShipmentObjName.ReadOnly = true;
            // 
            // ShimpentObjAmount
            // 
            this.ShimpentObjAmount.FillWeight = 50F;
            this.ShimpentObjAmount.HeaderText = "Количество";
            this.ShimpentObjAmount.MinimumWidth = 6;
            this.ShimpentObjAmount.Name = "ShimpentObjAmount";
            this.ShimpentObjAmount.ReadOnly = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ClearButton.AutoSize = true;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(12, 453);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(182, 44);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DirectoryButton
            // 
            this.DirectoryButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DirectoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DirectoryButton.Location = new System.Drawing.Point(1017, 453);
            this.DirectoryButton.Name = "DirectoryButton";
            this.DirectoryButton.Size = new System.Drawing.Size(157, 44);
            this.DirectoryButton.TabIndex = 15;
            this.DirectoryButton.Text = "Справочник";
            this.DirectoryButton.UseVisualStyleBackColor = true;
            this.DirectoryButton.Click += new System.EventHandler(this.DirectoryButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 508);
            this.Controls.Add(this.DirectoryButton);
            this.Controls.Add(this.ShipmentDataGridView);
            this.Controls.Add(this.ReceptionDataGridView);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ShipmentLabel);
            this.Controls.Add(this.ReceptionLabel);
            this.Controls.Add(this.ShipmentTextBox);
            this.Controls.Add(this.ReceptionTextBox);
            this.Controls.Add(this.ShipmentFiledLabel);
            this.Controls.Add(this.ReceptionFieldLabel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.ReceptionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShipmentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReceptionFieldLabel;
        private System.Windows.Forms.Label ShipmentFiledLabel;
        private System.Windows.Forms.TextBox ReceptionTextBox;
        private System.Windows.Forms.TextBox ShipmentTextBox;
        private System.Windows.Forms.Label ReceptionLabel;
        private System.Windows.Forms.Label ShipmentLabel;
        private DataGridView ReceptionDataGridView;
        private DataGridViewTextBoxColumn Naming;
        private DataGridView ShipmentDataGridView;
        private Button ClearButton;
        private DataGridViewTextBoxColumn ReceptionObjName;
        private DataGridViewTextBoxColumn ReceptionObjAmount;
        private DataGridViewTextBoxColumn ShipmentObjName;
        private DataGridViewTextBoxColumn ShimpentObjAmount;
        private Button DirectoryButton;
    }
}

