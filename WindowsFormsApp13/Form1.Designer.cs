namespace WindowsFormsApp13
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("wstring");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("string");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("void");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("int");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("long");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("char");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("func+junk");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("bool");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("float");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Types", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numb = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.numb)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Type";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 40);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(783, 398);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numb
            // 
            this.numb.Location = new System.Drawing.Point(316, 13);
            this.numb.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numb.Name = "numb";
            this.numb.Size = new System.Drawing.Size(120, 20);
            this.numb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amount";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(675, 40);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "wstring";
            treeNode2.Name = "Node4";
            treeNode2.Text = "string";
            treeNode3.Name = "Node5";
            treeNode3.Text = "void";
            treeNode4.Name = "Node6";
            treeNode4.Text = "int";
            treeNode5.Name = "Node7";
            treeNode5.Text = "long";
            treeNode6.Name = "Node8";
            treeNode6.Text = "char";
            treeNode7.Name = "Node9";
            treeNode7.Text = "func+junk";
            treeNode8.Name = "Node10";
            treeNode8.Text = "bool";
            treeNode9.Name = "Node11";
            treeNode9.Text = "float";
            treeNode10.Name = "Node0";
            treeNode10.Text = "Types";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView treeView1;
    }
}

