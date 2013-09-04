namespace XsltTransformer
{
    partial class Transformer
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
            this.btnTransform = new System.Windows.Forms.Button();
            this.rtbXsl = new System.Windows.Forms.RichTextBox();
            this.rtbXml = new System.Windows.Forms.RichTextBox();
            this.lblXml = new System.Windows.Forms.Label();
            this.lblXsl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTransform
            // 
            this.btnTransform.Location = new System.Drawing.Point(573, 378);
            this.btnTransform.Name = "btnTransform";
            this.btnTransform.Size = new System.Drawing.Size(75, 23);
            this.btnTransform.TabIndex = 3;
            this.btnTransform.Text = "Transform";
            this.btnTransform.UseVisualStyleBackColor = true;
            this.btnTransform.Click += new System.EventHandler(this.BtnTransformClick);
            // 
            // rtbXsl
            // 
            this.rtbXsl.Location = new System.Drawing.Point(12, 212);
            this.rtbXsl.Name = "rtbXsl";
            this.rtbXsl.Size = new System.Drawing.Size(636, 160);
            this.rtbXsl.TabIndex = 2;
            this.rtbXsl.Text = "";
            // 
            // rtbXml
            // 
            this.rtbXml.Location = new System.Drawing.Point(12, 19);
            this.rtbXml.Name = "rtbXml";
            this.rtbXml.Size = new System.Drawing.Size(636, 165);
            this.rtbXml.TabIndex = 1;
            this.rtbXml.Text = "";
            // 
            // lblXml
            // 
            this.lblXml.AutoSize = true;
            this.lblXml.Location = new System.Drawing.Point(13, 3);
            this.lblXml.Name = "lblXml";
            this.lblXml.Size = new System.Drawing.Size(24, 13);
            this.lblXml.TabIndex = 3;
            this.lblXml.Text = "Xml";
            // 
            // lblXsl
            // 
            this.lblXsl.AutoSize = true;
            this.lblXsl.Location = new System.Drawing.Point(9, 196);
            this.lblXsl.Name = "lblXsl";
            this.lblXsl.Size = new System.Drawing.Size(21, 13);
            this.lblXsl.TabIndex = 4;
            this.lblXsl.Text = "Xsl";
            // 
            // Transformer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 411);
            this.Controls.Add(this.lblXsl);
            this.Controls.Add(this.lblXml);
            this.Controls.Add(this.rtbXml);
            this.Controls.Add(this.rtbXsl);
            this.Controls.Add(this.btnTransform);
            this.Name = "Transformer";
            this.Text = "Transformer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTransform;
        private System.Windows.Forms.RichTextBox rtbXsl;
        private System.Windows.Forms.RichTextBox rtbXml;
        private System.Windows.Forms.Label lblXml;
        private System.Windows.Forms.Label lblXsl;
    }
}

