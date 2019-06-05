namespace SimpleReflexVacuumAgent
{
    partial class AI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AI));
            this.left = new System.Windows.Forms.PictureBox();
            this.right = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.vacuumRight = new System.Windows.Forms.PictureBox();
            this.vacuumLeft = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacuumRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacuumLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // left
            // 
            this.left.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("left.BackgroundImage")));
            this.left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.left.InitialImage = null;
            this.left.Location = new System.Drawing.Point(58, 284);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(215, 84);
            this.left.TabIndex = 0;
            this.left.TabStop = false;
            this.left.Visible = false;
            // 
            // right
            // 
            this.right.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("right.BackgroundImage")));
            this.right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.right.Location = new System.Drawing.Point(312, 284);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(215, 84);
            this.right.TabIndex = 1;
            this.right.TabStop = false;
            this.right.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(533, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(627, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // vacuumRight
            // 
            this.vacuumRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vacuumRight.BackgroundImage")));
            this.vacuumRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vacuumRight.InitialImage = null;
            this.vacuumRight.Location = new System.Drawing.Point(349, 63);
            this.vacuumRight.Name = "vacuumRight";
            this.vacuumRight.Size = new System.Drawing.Size(150, 215);
            this.vacuumRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vacuumRight.TabIndex = 5;
            this.vacuumRight.TabStop = false;
            this.vacuumRight.Visible = false;
            // 
            // vacuumLeft
            // 
            this.vacuumLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vacuumLeft.BackgroundImage")));
            this.vacuumLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vacuumLeft.InitialImage = null;
            this.vacuumLeft.Location = new System.Drawing.Point(90, 63);
            this.vacuumLeft.Name = "vacuumLeft";
            this.vacuumLeft.Size = new System.Drawing.Size(150, 215);
            this.vacuumLeft.TabIndex = 6;
            this.vacuumLeft.TabStop = false;
            this.vacuumLeft.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(533, 63);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 305);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Left Room";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Right Room";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Environment 1",
            "Environment 2",
            "Environment 3",
            "Environment 4",
            "Environment 5",
            "Environment 6"});
            this.checkedListBox1.Location = new System.Drawing.Point(708, 198);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 11;
            // 
            // AI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 409);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.vacuumLeft);
            this.Controls.Add(this.vacuumRight);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Name = "AI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacuumRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacuumLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        protected System.Windows.Forms.PictureBox left;
        protected System.Windows.Forms.PictureBox right;
        public System.Windows.Forms.PictureBox vacuumRight;
        public System.Windows.Forms.PictureBox vacuumLeft;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

