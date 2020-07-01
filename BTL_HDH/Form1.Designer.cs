namespace BTL_HDH
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Name", System.Windows.Forms.HorizontalAlignment.Left);
            this.bt_Start = new System.Windows.Forms.Button();
            this.bt_End = new System.Windows.Forms.Button();
            this.Start_TextBox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Start
            // 
            this.bt_Start.Location = new System.Drawing.Point(12, 52);
            this.bt_Start.Name = "bt_Start";
            this.bt_Start.Size = new System.Drawing.Size(100, 45);
            this.bt_Start.TabIndex = 0;
            this.bt_Start.Text = "Khởi động";
            this.bt_Start.UseVisualStyleBackColor = true;
            this.bt_Start.Click += new System.EventHandler(this.bt_Start_Click);
            // 
            // bt_End
            // 
            this.bt_End.Location = new System.Drawing.Point(12, 204);
            this.bt_End.Name = "bt_End";
            this.bt_End.Size = new System.Drawing.Size(100, 40);
            this.bt_End.TabIndex = 1;
            this.bt_End.Text = "Dừng";
            this.bt_End.UseVisualStyleBackColor = true;
            this.bt_End.Click += new System.EventHandler(this.bt_End_Click);
            // 
            // Start_TextBox
            // 
            this.Start_TextBox.Location = new System.Drawing.Point(12, 138);
            this.Start_TextBox.Name = "Start_TextBox";
            this.Start_TextBox.Size = new System.Drawing.Size(181, 22);
            this.Start_TextBox.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Right;
            listViewGroup1.Header = "Name";
            listViewGroup1.Name = "Name";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(199, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(601, 450);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_Start);
            this.panel1.Controls.Add(this.Start_TextBox);
            this.panel1.Controls.Add(this.bt_End);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 450);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Process";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Start;
        private System.Windows.Forms.Button bt_End;
        private System.Windows.Forms.TextBox Start_TextBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
    }
}

