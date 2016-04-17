namespace WindowsFormsApplication2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.regfolder = new System.Windows.Forms.TextBox();
            this.regname = new System.Windows.Forms.TextBox();
            this.regvalue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.createbutton = new System.Windows.Forms.Button();
            this.debug = new System.Windows.Forms.Label();
            this.getregname = new System.Windows.Forms.TextBox();
            this.getregfolder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.findbutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.refreshbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reg Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reg Name";
            // 
            // regfolder
            // 
            this.regfolder.Location = new System.Drawing.Point(12, 25);
            this.regfolder.Name = "regfolder";
            this.regfolder.Size = new System.Drawing.Size(100, 20);
            this.regfolder.TabIndex = 2;
            // 
            // regname
            // 
            this.regname.Location = new System.Drawing.Point(12, 64);
            this.regname.Name = "regname";
            this.regname.Size = new System.Drawing.Size(100, 20);
            this.regname.TabIndex = 3;
            // 
            // regvalue
            // 
            this.regvalue.Location = new System.Drawing.Point(12, 103);
            this.regvalue.Name = "regvalue";
            this.regvalue.Size = new System.Drawing.Size(100, 20);
            this.regvalue.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Reg Value";
            // 
            // createbutton
            // 
            this.createbutton.Location = new System.Drawing.Point(12, 129);
            this.createbutton.Name = "createbutton";
            this.createbutton.Size = new System.Drawing.Size(100, 31);
            this.createbutton.TabIndex = 6;
            this.createbutton.Text = "Create";
            this.createbutton.UseVisualStyleBackColor = true;
            this.createbutton.Click += new System.EventHandler(this.createbutton_Click);
            // 
            // debug
            // 
            this.debug.AutoSize = true;
            this.debug.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.debug.Location = new System.Drawing.Point(12, 163);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(54, 15);
            this.debug.TabIndex = 7;
            this.debug.Text = "Welcome";
            // 
            // getregname
            // 
            this.getregname.Location = new System.Drawing.Point(147, 64);
            this.getregname.Name = "getregname";
            this.getregname.Size = new System.Drawing.Size(100, 20);
            this.getregname.TabIndex = 11;
            // 
            // getregfolder
            // 
            this.getregfolder.Location = new System.Drawing.Point(147, 25);
            this.getregfolder.Name = "getregfolder";
            this.getregfolder.Size = new System.Drawing.Size(100, 20);
            this.getregfolder.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Reg Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Reg Folder";
            // 
            // findbutton
            // 
            this.findbutton.Location = new System.Drawing.Point(147, 90);
            this.findbutton.Name = "findbutton";
            this.findbutton.Size = new System.Drawing.Size(100, 31);
            this.findbutton.TabIndex = 12;
            this.findbutton.Text = "Find Value";
            this.findbutton.UseVisualStyleBackColor = true;
            this.findbutton.Click += new System.EventHandler(this.findbutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "© Aaron Hands 2015";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(253, 24);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(325, 226);
            this.treeView1.TabIndex = 14;
            // 
            // refreshbutton
            // 
            this.refreshbutton.Location = new System.Drawing.Point(167, 224);
            this.refreshbutton.Name = "refreshbutton";
            this.refreshbutton.Size = new System.Drawing.Size(80, 26);
            this.refreshbutton.TabIndex = 15;
            this.refreshbutton.Text = "Refresh";
            this.refreshbutton.UseVisualStyleBackColor = true;
            this.refreshbutton.Click += new System.EventHandler(this.refreshbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(590, 262);
            this.Controls.Add(this.refreshbutton);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.findbutton);
            this.Controls.Add(this.getregname);
            this.Controls.Add(this.getregfolder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.createbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.regvalue);
            this.Controls.Add(this.regname);
            this.Controls.Add(this.regfolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "RegEdit 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox regfolder;
        private System.Windows.Forms.TextBox regname;
        private System.Windows.Forms.TextBox regvalue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createbutton;
        private System.Windows.Forms.Label debug;
        private System.Windows.Forms.TextBox getregname;
        private System.Windows.Forms.TextBox getregfolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button findbutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button refreshbutton;
    }
}

