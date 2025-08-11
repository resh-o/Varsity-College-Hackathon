namespace MusicSuggester
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbEmotion = new ComboBox();
            lblMood = new Label();
            btnSuggest = new Button();
            btnClear = new Button();
            lbOutput = new ListBox();
            SuspendLayout();
            // 
            // cmbEmotion
            // 
            cmbEmotion.FormattingEnabled = true;
            cmbEmotion.Location = new Point(292, 434);
            cmbEmotion.Name = "cmbEmotion";
            cmbEmotion.Size = new Size(182, 33);
            cmbEmotion.TabIndex = 0;
            // 
            // lblMood
            // 
            lblMood.AutoSize = true;
            lblMood.Location = new Point(39, 442);
            lblMood.Name = "lblMood";
            lblMood.Size = new Size(65, 25);
            lblMood.TabIndex = 1;
            lblMood.Text = "Mood:";
            // 
            // btnSuggest
            // 
            btnSuggest.Location = new Point(39, 505);
            btnSuggest.Name = "btnSuggest";
            btnSuggest.Size = new Size(112, 34);
            btnSuggest.TabIndex = 2;
            btnSuggest.Text = "Suggest";
            btnSuggest.UseVisualStyleBackColor = true;
            btnSuggest.Click += btnSuggest_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(362, 505);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lbOutput
            // 
            lbOutput.FormattingEnabled = true;
            lbOutput.ItemHeight = 25;
            lbOutput.Location = new Point(39, 46);
            lbOutput.Name = "lbOutput";
            lbOutput.Size = new Size(438, 329);
            lbOutput.TabIndex = 4;
            lbOutput.SelectedIndexChanged += lbOutput_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 557);
            Controls.Add(lbOutput);
            Controls.Add(btnClear);
            Controls.Add(btnSuggest);
            Controls.Add(lblMood);
            Controls.Add(cmbEmotion);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbEmotion;
        private Label lblMood;
        private Button btnSuggest;
        private Button btnClear;
        private ListBox lbOutput;
    }
}
