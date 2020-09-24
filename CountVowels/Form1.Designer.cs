namespace CountVowels
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtParagraph = new System.Windows.Forms.RichTextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.txtVowels = new System.Windows.Forms.TextBox();
            this.vowels = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a paragraph of text. All vowels, upper and lower";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = " case will be counted. Y is not considered a vowel.";
            // 
            // txtParagraph
            // 
            this.txtParagraph.Location = new System.Drawing.Point(20, 71);
            this.txtParagraph.Name = "txtParagraph";
            this.txtParagraph.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.txtParagraph.Size = new System.Drawing.Size(308, 214);
            this.txtParagraph.TabIndex = 2;
            this.txtParagraph.Text = "";
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(20, 291);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(100, 27);
            this.btnCount.TabIndex = 3;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // txtVowels
            // 
            this.txtVowels.Location = new System.Drawing.Point(131, 296);
            this.txtVowels.Name = "txtVowels";
            this.txtVowels.ReadOnly = true;
            this.txtVowels.Size = new System.Drawing.Size(86, 20);
            this.txtVowels.TabIndex = 4;
            // 
            // vowels
            // 
            this.vowels.AutoSize = true;
            this.vowels.Location = new System.Drawing.Point(226, 299);
            this.vowels.Name = "vowels";
            this.vowels.Size = new System.Drawing.Size(40, 13);
            this.vowels.TabIndex = 5;
            this.vowels.Text = "vowels";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 344);
            this.Controls.Add(this.vowels);
            this.Controls.Add(this.txtVowels);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.txtParagraph);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Vowel Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtParagraph;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.TextBox txtVowels;
        private System.Windows.Forms.Label vowels;
    }
}

