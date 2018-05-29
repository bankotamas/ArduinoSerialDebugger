namespace SerialDebugger
{
    partial class DataSetControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataSetName = new System.Windows.Forms.GroupBox();
            this.Value = new System.Windows.Forms.TextBox();
            this.Unit = new System.Windows.Forms.Label();
            this.MessageID = new System.Windows.Forms.TextBox();
            this.dataSetName.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSetName
            // 
            this.dataSetName.Controls.Add(this.MessageID);
            this.dataSetName.Controls.Add(this.Unit);
            this.dataSetName.Controls.Add(this.Value);
            this.dataSetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataSetName.Location = new System.Drawing.Point(0, 3);
            this.dataSetName.Name = "dataSetName";
            this.dataSetName.Size = new System.Drawing.Size(154, 58);
            this.dataSetName.TabIndex = 0;
            this.dataSetName.TabStop = false;
            this.dataSetName.Text = "groupBox1";
            // 
            // Value
            // 
            this.Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Value.Location = new System.Drawing.Point(6, 19);
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Size = new System.Drawing.Size(100, 20);
            this.Value.TabIndex = 0;
            // 
            // Unit
            // 
            this.Unit.AutoSize = true;
            this.Unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Unit.Location = new System.Drawing.Point(112, 22);
            this.Unit.Name = "Unit";
            this.Unit.Size = new System.Drawing.Size(35, 13);
            this.Unit.TabIndex = 1;
            this.Unit.Text = "label1";
            // 
            // MessageID
            // 
            this.MessageID.Location = new System.Drawing.Point(6, 45);
            this.MessageID.Name = "MessageID";
            this.MessageID.Size = new System.Drawing.Size(12, 22);
            this.MessageID.TabIndex = 2;
            this.MessageID.Visible = false;
            // 
            // DataSetControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataSetName);
            this.Name = "DataSetControl";
            this.Size = new System.Drawing.Size(160, 66);
            this.dataSetName.ResumeLayout(false);
            this.dataSetName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox dataSetName;
        public System.Windows.Forms.TextBox MessageID;
        public System.Windows.Forms.Label Unit;
        public System.Windows.Forms.TextBox Value;
    }
}
