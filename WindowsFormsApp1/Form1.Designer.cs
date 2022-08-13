
namespace WindowsFormsApp1
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.iconBtn1 = new WindowsFormsApp1.IconBtn();
            this.iconBtn2 = new WindowsFormsApp1.IconBtn();
            this.iconBtn3 = new WindowsFormsApp1.IconBtn();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 567);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1188, 22);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.iconBtn1);
            this.flowLayoutPanel1.Controls.Add(this.iconBtn2);
            this.flowLayoutPanel1.Controls.Add(this.iconBtn3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(56, 567);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(56, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.splitContainer1.Size = new System.Drawing.Size(1132, 567);
            this.splitContainer1.SplitterDistance = 927;
            this.splitContainer1.TabIndex = 2;
            // 
            // iconBtn1
            // 
            this.iconBtn1.FontChar = WindowsFormsApp1.FontCollection.SegMDL2.Edit;
            this.iconBtn1.FontCharCustom = 0;
            this.iconBtn1.FontSize = 18.5F;
            this.iconBtn1.FontStyle = System.Drawing.FontStyle.Bold;
            this.iconBtn1.Location = new System.Drawing.Point(3, 3);
            this.iconBtn1.Name = "iconBtn1";
            this.iconBtn1.Size = new System.Drawing.Size(50, 50);
            this.iconBtn1.TabIndex = 0;
            this.iconBtn1.UseVisualStyleBackColor = true;
            // 
            // iconBtn2
            // 
            this.iconBtn2.FontChar = WindowsFormsApp1.FontCollection.SegMDL2.LastArrow;
            this.iconBtn2.FontCharCustom = 0;
            this.iconBtn2.FontSize = 18.5F;
            this.iconBtn2.FontStyle = System.Drawing.FontStyle.Bold;
            this.iconBtn2.Location = new System.Drawing.Point(3, 59);
            this.iconBtn2.Name = "iconBtn2";
            this.iconBtn2.Size = new System.Drawing.Size(50, 50);
            this.iconBtn2.TabIndex = 1;
            this.iconBtn2.UseVisualStyleBackColor = true;
            // 
            // iconBtn3
            // 
            this.iconBtn3.FontChar = WindowsFormsApp1.FontCollection.SegMDL2.Save;
            this.iconBtn3.FontCharCustom = 0;
            this.iconBtn3.FontSize = 18.5F;
            this.iconBtn3.FontStyle = System.Drawing.FontStyle.Bold;
            this.iconBtn3.Location = new System.Drawing.Point(3, 115);
            this.iconBtn3.Name = "iconBtn3";
            this.iconBtn3.Size = new System.Drawing.Size(50, 50);
            this.iconBtn3.TabIndex = 2;
            this.iconBtn3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 589);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private IconBtn iconBtn1;
        private IconBtn iconBtn2;
        private IconBtn iconBtn3;
    }
}

