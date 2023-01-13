namespace NbtStudio.UI
{
    partial class ExportWindow
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
            this.components = new System.ComponentModel.Container();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.RadioSnbt = new System.Windows.Forms.RadioButton();
            this.RadioNbt = new System.Windows.Forms.RadioButton();
            this.CheckMinify = new System.Windows.Forms.CheckBox();
            this.CheckLittleEndian = new System.Windows.Forms.CheckBox();
            this.CompressionBox = new System.Windows.Forms.ComboBox();
            this.CheckJson = new System.Windows.Forms.CheckBox();
            this.CheckBedrockHeader = new System.Windows.Forms.CheckBox();
            this.Tooltips = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(240, 271);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(138, 42);
            this.ButtonCancel.TabIndex = 8;
            this.ButtonCancel.Text = "取消";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // ButtonOk
            // 
            this.ButtonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOk.Location = new System.Drawing.Point(91, 271);
            this.ButtonOk.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(138, 42);
            this.ButtonOk.TabIndex = 7;
            this.ButtonOk.Text = "完成";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // RadioSnbt
            // 
            this.RadioSnbt.AutoSize = true;
            this.RadioSnbt.Location = new System.Drawing.Point(22, 164);
            this.RadioSnbt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RadioSnbt.Name = "RadioSnbt";
            this.RadioSnbt.Size = new System.Drawing.Size(81, 28);
            this.RadioSnbt.TabIndex = 4;
            this.RadioSnbt.Text = "SNBT";
            this.RadioSnbt.UseVisualStyleBackColor = true;
            // 
            // RadioNbt
            // 
            this.RadioNbt.AutoSize = true;
            this.RadioNbt.Location = new System.Drawing.Point(22, 22);
            this.RadioNbt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RadioNbt.Name = "RadioNbt";
            this.RadioNbt.Size = new System.Drawing.Size(71, 28);
            this.RadioNbt.TabIndex = 0;
            this.RadioNbt.Text = "NBT";
            this.RadioNbt.UseVisualStyleBackColor = true;
            this.RadioNbt.CheckedChanged += new System.EventHandler(this.RadioNbt_CheckedChanged);
            // 
            // CheckMinify
            // 
            this.CheckMinify.AutoSize = true;
            this.CheckMinify.Location = new System.Drawing.Point(138, 166);
            this.CheckMinify.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CheckMinify.Name = "CheckMinify";
            this.CheckMinify.Size = new System.Drawing.Size(108, 28);
            this.CheckMinify.TabIndex = 5;
            this.CheckMinify.Text = "缩简文本";
            this.CheckMinify.UseVisualStyleBackColor = true;
            // 
            // CheckLittleEndian
            // 
            this.CheckLittleEndian.AutoSize = true;
            this.CheckLittleEndian.Location = new System.Drawing.Point(138, 70);
            this.CheckLittleEndian.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CheckLittleEndian.Name = "CheckLittleEndian";
            this.CheckLittleEndian.Size = new System.Drawing.Size(230, 28);
            this.CheckLittleEndian.TabIndex = 2;
            this.CheckLittleEndian.Text = "小端模式(Little-Endian)";
            this.CheckLittleEndian.UseVisualStyleBackColor = true;
            // 
            // CompressionBox
            // 
            this.CompressionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CompressionBox.FormattingEnabled = true;
            this.CompressionBox.Location = new System.Drawing.Point(138, 20);
            this.CompressionBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CompressionBox.Name = "CompressionBox";
            this.CompressionBox.Size = new System.Drawing.Size(186, 32);
            this.CompressionBox.TabIndex = 1;
            // 
            // CheckJson
            // 
            this.CheckJson.AutoSize = true;
            this.CheckJson.Location = new System.Drawing.Point(138, 209);
            this.CheckJson.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CheckJson.Name = "CheckJson";
            this.CheckJson.Size = new System.Drawing.Size(83, 28);
            this.CheckJson.TabIndex = 6;
            this.CheckJson.Text = "JSON";
            this.CheckJson.UseVisualStyleBackColor = true;
            // 
            // CheckBedrockHeader
            // 
            this.CheckBedrockHeader.AutoSize = true;
            this.CheckBedrockHeader.Location = new System.Drawing.Point(138, 113);
            this.CheckBedrockHeader.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CheckBedrockHeader.Name = "CheckBedrockHeader";
            this.CheckBedrockHeader.Size = new System.Drawing.Size(180, 28);
            this.CheckBedrockHeader.TabIndex = 3;
            this.CheckBedrockHeader.Text = "使用基岩版头格式";
            this.CheckBedrockHeader.UseVisualStyleBackColor = true;
            // 
            // ExportWindow
            // 
            this.AcceptButton = this.ButtonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(399, 336);
            this.Controls.Add(this.CheckBedrockHeader);
            this.Controls.Add(this.CheckJson);
            this.Controls.Add(this.CompressionBox);
            this.Controls.Add(this.CheckLittleEndian);
            this.Controls.Add(this.CheckMinify);
            this.Controls.Add(this.RadioNbt);
            this.Controls.Add(this.RadioSnbt);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "导出设置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.RadioButton RadioSnbt;
        private System.Windows.Forms.RadioButton RadioNbt;
        private System.Windows.Forms.CheckBox CheckMinify;
        private System.Windows.Forms.CheckBox CheckLittleEndian;
        private System.Windows.Forms.ComboBox CompressionBox;
        private System.Windows.Forms.CheckBox CheckJson;
        private System.Windows.Forms.CheckBox CheckBedrockHeader;
        private System.Windows.Forms.ToolTip Tooltips;
    }
}