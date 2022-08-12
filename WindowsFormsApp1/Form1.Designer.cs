
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.iconBtn1 = new WindowsFormsApp1.IconBtn();
            this.iconBtn2 = new WindowsFormsApp1.IconBtn();
            this.iconBtn3 = new WindowsFormsApp1.IconBtn();
            this.iconBtn4 = new WindowsFormsApp1.IconBtn();
            this.iconBtn5 = new WindowsFormsApp1.IconBtn();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.iconBtn1);
            this.flowLayoutPanel1.Controls.Add(this.iconBtn2);
            this.flowLayoutPanel1.Controls.Add(this.iconBtn3);
            this.flowLayoutPanel1.Controls.Add(this.iconBtn4);
            this.flowLayoutPanel1.Controls.Add(this.iconBtn5);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(69, 535);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // iconBtn1
            // 
            this.iconBtn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.iconBtn1.KeyCode = WindowsFormsApp1.IconFont.IconFontE.LastArrow;
            this.iconBtn1.KeyCodeCustom = 0;
            this.iconBtn1.Location = new System.Drawing.Point(3, 3);
            this.iconBtn1.Name = "iconBtn1";
            this.iconBtn1.Size = new System.Drawing.Size(63, 63);
            this.iconBtn1.TabIndex = 0;
            this.iconBtn1.UseVisualStyleBackColor = true;
            // 
            // iconBtn2
            // 
            this.iconBtn2.ForeColor = System.Drawing.Color.Lime;
            this.iconBtn2.KeyCode = WindowsFormsApp1.IconFont.IconFontE.Edit;
            this.iconBtn2.KeyCodeCustom = 0;
            this.iconBtn2.Location = new System.Drawing.Point(3, 72);
            this.iconBtn2.Name = "iconBtn2";
            this.iconBtn2.Size = new System.Drawing.Size(63, 63);
            this.iconBtn2.TabIndex = 1;
            this.iconBtn2.UseVisualStyleBackColor = true;
            // 
            // iconBtn3
            // 
            this.iconBtn3.ForeColor = System.Drawing.Color.Red;
            this.iconBtn3.KeyCode = WindowsFormsApp1.IconFont.IconFontE.Setting;
            this.iconBtn3.KeyCodeCustom = 0;
            this.iconBtn3.Location = new System.Drawing.Point(3, 141);
            this.iconBtn3.Name = "iconBtn3";
            this.iconBtn3.Size = new System.Drawing.Size(63, 63);
            this.iconBtn3.TabIndex = 2;
            this.iconBtn3.UseVisualStyleBackColor = true;
            // 
            // iconBtn4
            // 
            this.iconBtn4.KeyCode = WindowsFormsApp1.IconFont.IconFontE.Custom;
            this.iconBtn4.KeyCodeCustom = 59157;
            this.iconBtn4.Location = new System.Drawing.Point(3, 210);
            this.iconBtn4.Name = "iconBtn4";
            this.iconBtn4.Size = new System.Drawing.Size(63, 63);
            this.iconBtn4.TabIndex = 3;
            this.iconBtn4.UseVisualStyleBackColor = true;
            // 
            // iconBtn5
            // 
            this.iconBtn5.KeyCodeCustom = 0;
            this.iconBtn5.Location = new System.Drawing.Point(3, 279);
            this.iconBtn5.Name = "iconBtn5";
            this.iconBtn5.Size = new System.Drawing.Size(63, 63);
            this.iconBtn5.TabIndex = 4;
            this.iconBtn5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 559);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private IconBtn iconBtn1;
        private IconBtn iconBtn2;
        private IconBtn iconBtn3;
        private IconBtn iconBtn4;
        private IconBtn iconBtn5;
    }
}

