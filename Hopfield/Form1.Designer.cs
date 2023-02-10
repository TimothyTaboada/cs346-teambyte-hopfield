namespace Hopfield
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
            this.topleft = new System.Windows.Forms.Button();
            this.midleft = new System.Windows.Forms.Button();
            this.botleft = new System.Windows.Forms.Button();
            this.topmid = new System.Windows.Forms.Button();
            this.midmid = new System.Windows.Forms.Button();
            this.botmid = new System.Windows.Forms.Button();
            this.topright = new System.Windows.Forms.Button();
            this.midright = new System.Windows.Forms.Button();
            this.botright = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.identify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topleft
            // 
            this.topleft.Location = new System.Drawing.Point(87, 75);
            this.topleft.Name = "topleft";
            this.topleft.Size = new System.Drawing.Size(58, 55);
            this.topleft.TabIndex = 0;
            this.topleft.UseVisualStyleBackColor = true;
            this.topleft.Click += new System.EventHandler(this.topleft_Click);
            // 
            // midleft
            // 
            this.midleft.Location = new System.Drawing.Point(87, 136);
            this.midleft.Name = "midleft";
            this.midleft.Size = new System.Drawing.Size(58, 55);
            this.midleft.TabIndex = 1;
            this.midleft.UseVisualStyleBackColor = true;
            this.midleft.Click += new System.EventHandler(this.midleft_Click);
            // 
            // botleft
            // 
            this.botleft.Location = new System.Drawing.Point(87, 197);
            this.botleft.Name = "botleft";
            this.botleft.Size = new System.Drawing.Size(58, 55);
            this.botleft.TabIndex = 2;
            this.botleft.UseVisualStyleBackColor = true;
            this.botleft.Click += new System.EventHandler(this.botleft_Click);
            // 
            // topmid
            // 
            this.topmid.Location = new System.Drawing.Point(151, 75);
            this.topmid.Name = "topmid";
            this.topmid.Size = new System.Drawing.Size(58, 55);
            this.topmid.TabIndex = 3;
            this.topmid.UseVisualStyleBackColor = true;
            this.topmid.Click += new System.EventHandler(this.topmid_Click);
            // 
            // midmid
            // 
            this.midmid.Location = new System.Drawing.Point(151, 136);
            this.midmid.Name = "midmid";
            this.midmid.Size = new System.Drawing.Size(58, 55);
            this.midmid.TabIndex = 4;
            this.midmid.UseVisualStyleBackColor = true;
            this.midmid.Click += new System.EventHandler(this.midmid_Click);
            // 
            // botmid
            // 
            this.botmid.Location = new System.Drawing.Point(151, 197);
            this.botmid.Name = "botmid";
            this.botmid.Size = new System.Drawing.Size(58, 55);
            this.botmid.TabIndex = 5;
            this.botmid.UseVisualStyleBackColor = true;
            this.botmid.Click += new System.EventHandler(this.botmid_Click);
            // 
            // topright
            // 
            this.topright.Location = new System.Drawing.Point(215, 75);
            this.topright.Name = "topright";
            this.topright.Size = new System.Drawing.Size(58, 55);
            this.topright.TabIndex = 6;
            this.topright.UseVisualStyleBackColor = true;
            this.topright.Click += new System.EventHandler(this.topright_Click);
            // 
            // midright
            // 
            this.midright.Location = new System.Drawing.Point(215, 136);
            this.midright.Name = "midright";
            this.midright.Size = new System.Drawing.Size(58, 55);
            this.midright.TabIndex = 7;
            this.midright.UseVisualStyleBackColor = true;
            this.midright.Click += new System.EventHandler(this.midright_Click);
            // 
            // botright
            // 
            this.botright.Location = new System.Drawing.Point(215, 197);
            this.botright.Name = "botright";
            this.botright.Size = new System.Drawing.Size(58, 55);
            this.botright.TabIndex = 8;
            this.botright.UseVisualStyleBackColor = true;
            this.botright.Click += new System.EventHandler(this.botright_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Output";
            // 
            // identify
            // 
            this.identify.Location = new System.Drawing.Point(87, 298);
            this.identify.Name = "identify";
            this.identify.Size = new System.Drawing.Size(186, 41);
            this.identify.TabIndex = 10;
            this.identify.Text = "Identify";
            this.identify.UseVisualStyleBackColor = true;
            this.identify.Click += new System.EventHandler(this.identify_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.identify);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botright);
            this.Controls.Add(this.midright);
            this.Controls.Add(this.topright);
            this.Controls.Add(this.botmid);
            this.Controls.Add(this.midmid);
            this.Controls.Add(this.topmid);
            this.Controls.Add(this.botleft);
            this.Controls.Add(this.midleft);
            this.Controls.Add(this.topleft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button topleft;
        private System.Windows.Forms.Button midleft;
        private System.Windows.Forms.Button botleft;
        private System.Windows.Forms.Button topmid;
        private System.Windows.Forms.Button midmid;
        private System.Windows.Forms.Button botmid;
        private System.Windows.Forms.Button topright;
        private System.Windows.Forms.Button midright;
        private System.Windows.Forms.Button botright;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button identify;
    }
}

