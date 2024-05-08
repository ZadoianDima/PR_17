namespace WinFormsApp7
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
            lblAnime = new Label();
            lblCharacter = new Label();
            lblQuote = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblAnime
            // 
            lblAnime.AutoSize = true;
            lblAnime.Location = new Point(370, 41);
            lblAnime.Name = "lblAnime";
            lblAnime.Size = new Size(50, 20);
            lblAnime.TabIndex = 0;
            lblAnime.Text = "label1";
            // 
            // lblCharacter
            // 
            lblCharacter.AutoSize = true;
            lblCharacter.Location = new Point(369, 112);
            lblCharacter.Name = "lblCharacter";
            lblCharacter.Size = new Size(50, 20);
            lblCharacter.TabIndex = 1;
            lblCharacter.Text = "label2";
            // 
            // lblQuote
            // 
            lblQuote.AutoSize = true;
            lblQuote.Location = new Point(370, 180);
            lblQuote.Name = "lblQuote";
            lblQuote.Size = new Size(50, 20);
            lblQuote.TabIndex = 2;
            lblQuote.Text = "label3";
            // 
            // button1
            // 
            button1.Location = new Point(368, 262);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "reload";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(lblQuote);
            Controls.Add(lblCharacter);
            Controls.Add(lblAnime);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAnime;
        private Label lblCharacter;
        private Label lblQuote;
        private Button button1;
    }
}
