namespace Infix_to_Postfix
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtIn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPre = new System.Windows.Forms.TextBox();
            this.resInfix = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.InfixCheckBox = new System.Windows.Forms.CheckBox();
            this.PostfixCheckBox = new System.Windows.Forms.CheckBox();
            this.PrefixCheckBox = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.resPostfix = new System.Windows.Forms.TextBox();
            this.resPrefix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIn
            // 
            this.txtIn.BackColor = System.Drawing.Color.Black;
            this.txtIn.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIn.ForeColor = System.Drawing.Color.Yellow;
            this.txtIn.Location = new System.Drawing.Point(12, 48);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(878, 34);
            this.txtIn.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtIn, "Entry Infix");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Infix";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Postfix";
            // 
            // txtPost
            // 
            this.txtPost.BackColor = System.Drawing.Color.Black;
            this.txtPost.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPost.ForeColor = System.Drawing.Color.Yellow;
            this.txtPost.Location = new System.Drawing.Point(12, 120);
            this.txtPost.Name = "txtPost";
            this.txtPost.ReadOnly = true;
            this.txtPost.Size = new System.Drawing.Size(878, 34);
            this.txtPost.TabIndex = 2;
            this.txtPost.Text = "Disabled";
            this.toolTip1.SetToolTip(this.txtPost, "Entry Postfix");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prefix";
            // 
            // txtPre
            // 
            this.txtPre.BackColor = System.Drawing.Color.Black;
            this.txtPre.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPre.ForeColor = System.Drawing.Color.Yellow;
            this.txtPre.Location = new System.Drawing.Point(12, 191);
            this.txtPre.Name = "txtPre";
            this.txtPre.ReadOnly = true;
            this.txtPre.Size = new System.Drawing.Size(878, 34);
            this.txtPre.TabIndex = 4;
            this.txtPre.Text = "Disabled";
            this.toolTip1.SetToolTip(this.txtPre, "Entry Prefix");
            // 
            // resInfix
            // 
            this.resInfix.BackColor = System.Drawing.Color.Black;
            this.resInfix.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resInfix.ForeColor = System.Drawing.Color.Yellow;
            this.resInfix.Location = new System.Drawing.Point(180, 231);
            this.resInfix.Name = "resInfix";
            this.resInfix.ReadOnly = true;
            this.resInfix.Size = new System.Drawing.Size(710, 46);
            this.resInfix.TabIndex = 6;
            this.toolTip1.SetToolTip(this.resInfix, "Show result for users");
            // 
            // btnConvert
            // 
            this.btnConvert.FlatAppearance.BorderSize = 5;
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(666, 397);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(224, 81);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "Convert";
            this.toolTip1.SetToolTip(this.btnConvert, "Convert");
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            this.btnConvert.MouseLeave += new System.EventHandler(this.btnConvert_MouseLeave);
            this.btnConvert.MouseHover += new System.EventHandler(this.btnConvert_MouseHover);
            // 
            // InfixCheckBox
            // 
            this.InfixCheckBox.AutoSize = true;
            this.InfixCheckBox.Checked = true;
            this.InfixCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.InfixCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfixCheckBox.Location = new System.Drawing.Point(816, 23);
            this.InfixCheckBox.Name = "InfixCheckBox";
            this.InfixCheckBox.Size = new System.Drawing.Size(80, 21);
            this.InfixCheckBox.TabIndex = 8;
            this.InfixCheckBox.Text = "Enable";
            this.toolTip1.SetToolTip(this.InfixCheckBox, "Enabling Infix");
            this.InfixCheckBox.UseVisualStyleBackColor = true;
            this.InfixCheckBox.CheckedChanged += new System.EventHandler(this.InfixCheckBox_CheckedChanged);
            // 
            // PostfixCheckBox
            // 
            this.PostfixCheckBox.AutoSize = true;
            this.PostfixCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostfixCheckBox.Location = new System.Drawing.Point(816, 95);
            this.PostfixCheckBox.Name = "PostfixCheckBox";
            this.PostfixCheckBox.Size = new System.Drawing.Size(80, 21);
            this.PostfixCheckBox.TabIndex = 9;
            this.PostfixCheckBox.Text = "Enable";
            this.toolTip1.SetToolTip(this.PostfixCheckBox, "Enabling Postfix");
            this.PostfixCheckBox.UseVisualStyleBackColor = true;
            this.PostfixCheckBox.CheckedChanged += new System.EventHandler(this.PostfixCheckBox_CheckedChanged);
            // 
            // PrefixCheckBox
            // 
            this.PrefixCheckBox.AutoSize = true;
            this.PrefixCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrefixCheckBox.Location = new System.Drawing.Point(816, 166);
            this.PrefixCheckBox.Name = "PrefixCheckBox";
            this.PrefixCheckBox.Size = new System.Drawing.Size(80, 21);
            this.PrefixCheckBox.TabIndex = 10;
            this.PrefixCheckBox.Text = "Enable";
            this.toolTip1.SetToolTip(this.PrefixCheckBox, "Enabling Prefix");
            this.PrefixCheckBox.UseVisualStyleBackColor = true;
            this.PrefixCheckBox.CheckedChanged += new System.EventHandler(this.PrefixCheckBox_CheckedChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.White;
            this.toolTip1.ForeColor = System.Drawing.Color.Black;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.OwnerDraw = true;
            this.toolTip1.Tag = "";
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // resPostfix
            // 
            this.resPostfix.BackColor = System.Drawing.Color.Black;
            this.resPostfix.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resPostfix.ForeColor = System.Drawing.Color.Yellow;
            this.resPostfix.Location = new System.Drawing.Point(180, 288);
            this.resPostfix.Name = "resPostfix";
            this.resPostfix.ReadOnly = true;
            this.resPostfix.Size = new System.Drawing.Size(710, 46);
            this.resPostfix.TabIndex = 6;
            // 
            // resPrefix
            // 
            this.resPrefix.BackColor = System.Drawing.Color.Black;
            this.resPrefix.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resPrefix.ForeColor = System.Drawing.Color.Yellow;
            this.resPrefix.Location = new System.Drawing.Point(180, 345);
            this.resPrefix.Name = "resPrefix";
            this.resPrefix.ReadOnly = true;
            this.resPrefix.Size = new System.Drawing.Size(710, 46);
            this.resPrefix.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(5, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 40);
            this.label4.TabIndex = 1;
            this.label4.Text = "Infix  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(5, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 40);
            this.label5.TabIndex = 3;
            this.label5.Text = "Postfix:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(5, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 40);
            this.label6.TabIndex = 5;
            this.label6.Text = "Prefix :";
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 5;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(436, 397);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(224, 81);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseLeave += new System.EventHandler(this.btnClear_MouseLeave);
            this.btnClear.MouseHover += new System.EventHandler(this.btnClear_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = global::Infix_to_Postfix.Properties.Resources._3;
            this.pictureBox2.Location = new System.Drawing.Point(64, 432);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Infix_to_Postfix.Properties.Resources._1001;
            this.pictureBox1.Location = new System.Drawing.Point(12, 432);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 46);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Information this Application");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(902, 490);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.resPrefix);
            this.Controls.Add(this.resPostfix);
            this.Controls.Add(this.resInfix);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PrefixCheckBox);
            this.Controls.Add(this.PostfixCheckBox);
            this.Controls.Add(this.InfixCheckBox);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIn);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Infix Postfix Prefix";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPre;
        private System.Windows.Forms.TextBox resInfix;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.CheckBox InfixCheckBox;
        private System.Windows.Forms.CheckBox PostfixCheckBox;
        private System.Windows.Forms.CheckBox PrefixCheckBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox resPostfix;
        private System.Windows.Forms.TextBox resPrefix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

