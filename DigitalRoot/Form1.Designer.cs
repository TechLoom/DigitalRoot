namespace DigitalRoot
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
            this.RunBTN = new System.Windows.Forms.Button();
            this.DigitalRootResult = new System.Windows.Forms.Label();
            this.NumberField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RunBTN
            // 
            this.RunBTN.Location = new System.Drawing.Point(279, 10);
            this.RunBTN.Name = "RunBTN";
            this.RunBTN.Size = new System.Drawing.Size(75, 23);
            this.RunBTN.TabIndex = 0;
            this.RunBTN.Text = "RUN";
            this.RunBTN.UseVisualStyleBackColor = true;
            this.RunBTN.Click += new System.EventHandler(this.RunBTN_Click);
            // 
            // DigitalRootResult
            // 
            this.DigitalRootResult.AutoSize = true;
            this.DigitalRootResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DigitalRootResult.Location = new System.Drawing.Point(12, 43);
            this.DigitalRootResult.Name = "DigitalRootResult";
            this.DigitalRootResult.Size = new System.Drawing.Size(63, 20);
            this.DigitalRootResult.TabIndex = 1;
            this.DigitalRootResult.Text = "Result :";
            // 
            // NumberField
            // 
            this.NumberField.Location = new System.Drawing.Point(12, 12);
            this.NumberField.Name = "NumberField";
            this.NumberField.Size = new System.Drawing.Size(243, 20);
            this.NumberField.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 72);
            this.Controls.Add(this.NumberField);
            this.Controls.Add(this.DigitalRootResult);
            this.Controls.Add(this.RunBTN);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "DigitalRoot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RunBTN;
        private System.Windows.Forms.Label DigitalRootResult;
        private System.Windows.Forms.TextBox NumberField;
    }
}

