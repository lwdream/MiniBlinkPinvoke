namespace MiniBlinkPinvoke
{
    partial class TransparentForm
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
            this.blinkBrowser1 = new MiniBlinkPinvoke.BlinkBrowser();
            this.SuspendLayout();
            // 
            // blinkBrowser1
            // 
            this.blinkBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blinkBrowser1.HTML = "";
            this.blinkBrowser1.JsGetValue = null;
            this.blinkBrowser1.Location = new System.Drawing.Point(0, 0);
            this.blinkBrowser1.Name = "blinkBrowser1";
            this.blinkBrowser1.Size = new System.Drawing.Size(740, 627);
            this.blinkBrowser1.TabIndex = 0;
            this.blinkBrowser1.Text = "blinkBrowser1";
            this.blinkBrowser1.Url = "";
            // 
            // TransparentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Magenta;
            this.ClientSize = new System.Drawing.Size(740, 627);
            this.Controls.Add(this.blinkBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransparentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransparentForm";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.ResumeLayout(false);

        }

        #endregion

        private BlinkBrowser blinkBrowser1;
    }
}