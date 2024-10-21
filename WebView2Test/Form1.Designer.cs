
namespace WebView2Test
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
            this.wv2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tbShowNRKIllustration = new System.Windows.Forms.TextBox();
            this.tbShowNRKIllustrationFocus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbEditorInfo = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnRun2 = new System.Windows.Forms.Button();
            this.tbKaleidoUrl = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.wv2)).BeginInit();
            this.SuspendLayout();
            // 
            // wv2
            // 
            this.wv2.AllowExternalDrop = true;
            this.wv2.CreationProperties = null;
            this.wv2.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wv2.Location = new System.Drawing.Point(0, 0);
            this.wv2.Name = "wv2";
            this.wv2.Size = new System.Drawing.Size(845, 379);
            this.wv2.Source = new System.Uri("https://www.vg.no", System.UriKind.Absolute);
            this.wv2.TabIndex = 0;
            this.wv2.ZoomFactor = 1D;
            // 
            // tbShowNRKIllustration
            // 
            this.tbShowNRKIllustration.Location = new System.Drawing.Point(12, 462);
            this.tbShowNRKIllustration.Name = "tbShowNRKIllustration";
            this.tbShowNRKIllustration.Size = new System.Drawing.Size(334, 20);
            this.tbShowNRKIllustration.TabIndex = 1;
            this.tbShowNRKIllustration.Text = "9u5a0oEENxvIq39RaTfqhA?w=1&h=0.9&x=0&y=0";
            // 
            // tbShowNRKIllustrationFocus
            // 
            this.tbShowNRKIllustrationFocus.Location = new System.Drawing.Point(12, 505);
            this.tbShowNRKIllustrationFocus.Name = "tbShowNRKIllustrationFocus";
            this.tbShowNRKIllustrationFocus.Size = new System.Drawing.Size(334, 20);
            this.tbShowNRKIllustrationFocus.TabIndex = 2;
            this.tbShowNRKIllustrationFocus.Text = "&focusx=0.5&focusy=0.5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "NRK.ILLUSTRATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NRK.ILLUSTRATIONCAPTION";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 555);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(334, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbEditorInfo
            // 
            this.tbEditorInfo.AutoSize = true;
            this.tbEditorInfo.Location = new System.Drawing.Point(15, 539);
            this.tbEditorInfo.Name = "tbEditorInfo";
            this.tbEditorInfo.Size = new System.Drawing.Size(51, 13);
            this.tbEditorInfo.TabIndex = 6;
            this.tbEditorInfo.Text = "editorInfo";
            this.tbEditorInfo.Click += new System.EventHandler(this.tbEditorInfo_Click);
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(12, 405);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(334, 20);
            this.tbUrl.TabIndex = 7;
            this.tbUrl.Text = "http://madigasweb02/bildebanken/index.html";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(12, 382);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(18, 13);
            this.lblUrl.TabIndex = 8;
            this.lblUrl.Text = "url";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(352, 403);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(109, 23);
            this.btnRun.TabIndex = 9;
            this.btnRun.Text = "Kjør";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnRun2
            // 
            this.btnRun2.Location = new System.Drawing.Point(352, 462);
            this.btnRun2.Name = "btnRun2";
            this.btnRun2.Size = new System.Drawing.Size(109, 23);
            this.btnRun2.TabIndex = 10;
            this.btnRun2.Text = "Kjør m/param";
            this.btnRun2.UseVisualStyleBackColor = true;
            this.btnRun2.Click += new System.EventHandler(this.btnRun2_Click);
            // 
            // tbKaleidoUrl
            // 
            this.tbKaleidoUrl.Location = new System.Drawing.Point(12, 600);
            this.tbKaleidoUrl.Name = "tbKaleidoUrl";
            this.tbKaleidoUrl.Size = new System.Drawing.Size(334, 20);
            this.tbKaleidoUrl.TabIndex = 11;
            this.tbKaleidoUrl.Text = "https://gfx.nrk.no/";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 702);
            this.Controls.Add(this.tbKaleidoUrl);
            this.Controls.Add(this.btnRun2);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.tbEditorInfo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbShowNRKIllustrationFocus);
            this.Controls.Add(this.tbShowNRKIllustration);
            this.Controls.Add(this.wv2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.wv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 wv2;
        private System.Windows.Forms.TextBox tbShowNRKIllustration;
        private System.Windows.Forms.TextBox tbShowNRKIllustrationFocus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label tbEditorInfo;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnRun2;
        private System.Windows.Forms.TextBox tbKaleidoUrl;
    }
}

