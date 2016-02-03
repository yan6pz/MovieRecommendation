namespace MovieRecommendation
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMovies = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.realValue = new System.Windows.Forms.Label();
            this.percent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Location = new System.Drawing.Point(188, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "run";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(188, 34);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(78, 20);
            this.txtUserId.TabIndex = 1;
            this.txtUserId.TextChanged += new System.EventHandler(this.userId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "userId:";
            // 
            // txtMovies
            // 
            this.txtMovies.Location = new System.Drawing.Point(188, 69);
            this.txtMovies.Name = "txtMovies";
            this.txtMovies.Size = new System.Drawing.Size(247, 20);
            this.txtMovies.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "MoviesId separeted with comma:";
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(188, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Measure:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.Color.Orange;
            this.resultLabel.Location = new System.Drawing.Point(56, 247);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(39, 42);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.Text = "0";
            this.resultLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // realValue
            // 
            this.realValue.AutoSize = true;
            this.realValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realValue.ForeColor = System.Drawing.Color.RoyalBlue;
            this.realValue.Location = new System.Drawing.Point(227, 247);
            this.realValue.Name = "realValue";
            this.realValue.Size = new System.Drawing.Size(39, 42);
            this.realValue.TabIndex = 8;
            this.realValue.Text = "0";
            // 
            // percent
            // 
            this.percent.AutoSize = true;
            this.percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percent.ForeColor = System.Drawing.Color.ForestGreen;
            this.percent.Location = new System.Drawing.Point(384, 247);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(72, 42);
            this.percent.TabIndex = 9;
            this.percent.Text = "0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 346);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.realValue);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMovies);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "MovieRecommend";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMovies;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label realValue;
        private System.Windows.Forms.Label percent;
    }
}

