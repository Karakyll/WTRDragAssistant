namespace WTRDragAssistant
{
    partial class PortNameRequest
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
            this.labelPortName = new System.Windows.Forms.Label();
            this.textBoxPortName = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPortName
            // 
            this.labelPortName.AutoSize = true;
            this.labelPortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPortName.Location = new System.Drawing.Point(12, 47);
            this.labelPortName.Name = "labelPortName";
            this.labelPortName.Size = new System.Drawing.Size(149, 25);
            this.labelPortName.TabIndex = 0;
            this.labelPortName.Text = "Input Port name";
            this.labelPortName.Click += new System.EventHandler(this.labelPortName_Click);
            // 
            // textBoxPortName
            // 
            this.textBoxPortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPortName.Location = new System.Drawing.Point(178, 43);
            this.textBoxPortName.Name = "textBoxPortName";
            this.textBoxPortName.Size = new System.Drawing.Size(144, 32);
            this.textBoxPortName.TabIndex = 1;
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(79, 104);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(196, 44);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // PortNameRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 190);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxPortName);
            this.Controls.Add(this.labelPortName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(370, 237);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(370, 237);
            this.Name = "PortNameRequest";
            this.Text = "PortNameRequest";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PortNameRequest_FormClosing);
            this.Load += new System.EventHandler(this.PortNameRequest_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PortNameRequest_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPortName;
        private System.Windows.Forms.TextBox textBoxPortName;
        private System.Windows.Forms.Button buttonOK;
    }
}