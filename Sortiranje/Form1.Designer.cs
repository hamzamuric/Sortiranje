namespace Sortiranje
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
            this.txtMakeList = new System.Windows.Forms.TextBox();
            this.btnRandomize = new System.Windows.Forms.Button();
            this.btnBubble = new System.Windows.Forms.Button();
            this.btnQuick = new System.Windows.Forms.Button();
            this.btnBST = new System.Windows.Forms.Button();
            this.btnMakeList = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMakeList
            // 
            this.txtMakeList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMakeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMakeList.Location = new System.Drawing.Point(12, 377);
            this.txtMakeList.Name = "txtMakeList";
            this.txtMakeList.Size = new System.Drawing.Size(570, 32);
            this.txtMakeList.TabIndex = 0;
            // 
            // btnRandomize
            // 
            this.btnRandomize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRandomize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRandomize.Location = new System.Drawing.Point(12, 415);
            this.btnRandomize.MaximumSize = new System.Drawing.Size(200, 30);
            this.btnRandomize.MinimumSize = new System.Drawing.Size(50, 30);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(130, 30);
            this.btnRandomize.TabIndex = 1;
            this.btnRandomize.Text = "Randomize";
            this.btnRandomize.UseVisualStyleBackColor = true;
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // btnBubble
            // 
            this.btnBubble.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBubble.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBubble.Location = new System.Drawing.Point(145, 415);
            this.btnBubble.MaximumSize = new System.Drawing.Size(200, 30);
            this.btnBubble.MinimumSize = new System.Drawing.Size(50, 30);
            this.btnBubble.Name = "btnBubble";
            this.btnBubble.Size = new System.Drawing.Size(130, 30);
            this.btnBubble.TabIndex = 1;
            this.btnBubble.Text = "Bubble Sort";
            this.btnBubble.UseVisualStyleBackColor = true;
            this.btnBubble.Click += new System.EventHandler(this.btnBubble_Click);
            // 
            // btnQuick
            // 
            this.btnQuick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnQuick.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQuick.Location = new System.Drawing.Point(281, 415);
            this.btnQuick.MaximumSize = new System.Drawing.Size(200, 30);
            this.btnQuick.MinimumSize = new System.Drawing.Size(50, 30);
            this.btnQuick.Name = "btnQuick";
            this.btnQuick.Size = new System.Drawing.Size(131, 30);
            this.btnQuick.TabIndex = 1;
            this.btnQuick.Text = "Quick Sort";
            this.btnQuick.UseVisualStyleBackColor = true;
            this.btnQuick.Click += new System.EventHandler(this.btnQuick_Click);
            // 
            // btnBST
            // 
            this.btnBST.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBST.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBST.Location = new System.Drawing.Point(418, 415);
            this.btnBST.MaximumSize = new System.Drawing.Size(200, 30);
            this.btnBST.MinimumSize = new System.Drawing.Size(50, 30);
            this.btnBST.Name = "btnBST";
            this.btnBST.Size = new System.Drawing.Size(131, 30);
            this.btnBST.TabIndex = 1;
            this.btnBST.Text = "BST Sort";
            this.btnBST.UseVisualStyleBackColor = true;
            this.btnBST.Click += new System.EventHandler(this.btnBST_Click);
            // 
            // btnMakeList
            // 
            this.btnMakeList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMakeList.Location = new System.Drawing.Point(588, 377);
            this.btnMakeList.Name = "btnMakeList";
            this.btnMakeList.Size = new System.Drawing.Size(96, 32);
            this.btnMakeList.TabIndex = 1;
            this.btnMakeList.Text = "Make List";
            this.btnMakeList.UseVisualStyleBackColor = true;
            this.btnMakeList.Click += new System.EventHandler(this.btnMakeList_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStop.Location = new System.Drawing.Point(553, 415);
            this.btnStop.MaximumSize = new System.Drawing.Size(200, 30);
            this.btnStop.MinimumSize = new System.Drawing.Size(50, 30);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(131, 30);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tbSpeed
            // 
            this.tbSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSpeed.Location = new System.Drawing.Point(115, 326);
            this.tbSpeed.Maximum = 150;
            this.tbSpeed.Minimum = 10;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(569, 45);
            this.tbSpeed.TabIndex = 3;
            this.tbSpeed.Value = 10;
            this.tbSpeed.Scroll += new System.EventHandler(this.tbSpeed_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Speed:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(696, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnMakeList);
            this.Controls.Add(this.btnBST);
            this.Controls.Add(this.btnQuick);
            this.Controls.Add(this.btnBubble);
            this.Controls.Add(this.btnRandomize);
            this.Controls.Add(this.txtMakeList);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMakeList;
        private System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.Button btnBubble;
        private System.Windows.Forms.Button btnQuick;
        private System.Windows.Forms.Button btnBST;
        private System.Windows.Forms.Button btnMakeList;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.Label label1;
    }
}

