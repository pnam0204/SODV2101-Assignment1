namespace Assignment1
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(116, 25);
            label1.TabIndex = 0;
            label1.Text = "Player 1: 0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.Location = new Point(445, 15);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 1;
            label2.Text = "Player 2: 0";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            button1.Location = new Point(60, 45);
            button1.Name = "button1";
            button1.Size = new Size(140, 140);
            button1.TabIndex = 2;
            button1.Tag = "";
            button1.UseVisualStyleBackColor = true;
            button1.Click += playerClick;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            button2.Location = new Point(216, 45);
            button2.Name = "button2";
            button2.Size = new Size(140, 140);
            button2.TabIndex = 3;
            button2.Tag = "";
            button2.UseVisualStyleBackColor = true;
            button2.Click += playerClick;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            button3.Location = new Point(372, 45);
            button3.Name = "button3";
            button3.Size = new Size(140, 140);
            button3.TabIndex = 4;
            button3.Tag = "";
            button3.UseVisualStyleBackColor = true;
            button3.Click += playerClick;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            button4.Location = new Point(60, 201);
            button4.Name = "button4";
            button4.Size = new Size(140, 140);
            button4.TabIndex = 7;
            button4.Tag = "";
            button4.UseVisualStyleBackColor = true;
            button4.Click += playerClick;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            button5.Location = new Point(216, 201);
            button5.Name = "button5";
            button5.Size = new Size(140, 140);
            button5.TabIndex = 6;
            button5.Tag = "";
            button5.UseVisualStyleBackColor = true;
            button5.Click += playerClick;
            // 
            // button6
            // 
            button6.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            button6.Location = new Point(372, 201);
            button6.Name = "button6";
            button6.Size = new Size(140, 140);
            button6.TabIndex = 5;
            button6.Tag = "";
            button6.UseVisualStyleBackColor = true;
            button6.Click += playerClick;
            // 
            // button7
            // 
            button7.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            button7.Location = new Point(60, 357);
            button7.Name = "button7";
            button7.Size = new Size(140, 140);
            button7.TabIndex = 10;
            button7.Tag = "";
            button7.UseVisualStyleBackColor = true;
            button7.Click += playerClick;
            // 
            // button8
            // 
            button8.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            button8.Location = new Point(216, 357);
            button8.Name = "button8";
            button8.Size = new Size(140, 140);
            button8.TabIndex = 9;
            button8.Tag = "";
            button8.UseVisualStyleBackColor = true;
            button8.Click += playerClick;
            // 
            // button9
            // 
            button9.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            button9.Location = new Point(372, 357);
            button9.Name = "button9";
            button9.Size = new Size(140, 140);
            button9.TabIndex = 8;
            button9.Tag = "";
            button9.UseVisualStyleBackColor = true;
            button9.Click += playerClick;
            // 
            // button10
            // 
            button10.Location = new Point(240, 512);
            button10.Name = "button10";
            button10.Size = new Size(94, 29);
            button10.TabIndex = 11;
            button10.Text = "Restart";
            button10.UseVisualStyleBackColor = true;
            button10.Click += restartGame;
            // 
            // button11
            // 
            button11.Location = new Point(467, 512);
            button11.Name = "button11";
            button11.Size = new Size(94, 29);
            button11.TabIndex = 12;
            button11.Text = "Reset Score";
            button11.UseVisualStyleBackColor = true;
            button11.Click += resetScore;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 553);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tic Tac Toe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
    }
}
