namespace Sortiranje
{
    partial class SortTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumbers = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTestVremena = new System.Windows.Forms.DataGridView();
            this.btnTestSorts = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBubbleTime = new System.Windows.Forms.Label();
            this.lblQuickTime = new System.Windows.Forms.Label();
            this.lblBstTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestVremena)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter numbers:";
            // 
            // tbNumbers
            // 
            this.tbNumbers.Location = new System.Drawing.Point(179, 15);
            this.tbNumbers.Name = "tbNumbers";
            this.tbNumbers.Size = new System.Drawing.Size(512, 20);
            this.tbNumbers.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "eg.:   1,2,3,4 ...";
            // 
            // dgvTestVremena
            // 
            this.dgvTestVremena.AllowUserToAddRows = false;
            this.dgvTestVremena.AllowUserToDeleteRows = false;
            this.dgvTestVremena.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTestVremena.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestVremena.Location = new System.Drawing.Point(17, 143);
            this.dgvTestVremena.Name = "dgvTestVremena";
            this.dgvTestVremena.ReadOnly = true;
            this.dgvTestVremena.Size = new System.Drawing.Size(674, 270);
            this.dgvTestVremena.TabIndex = 3;
            // 
            // btnTestSorts
            // 
            this.btnTestSorts.Location = new System.Drawing.Point(616, 41);
            this.btnTestSorts.Name = "btnTestSorts";
            this.btnTestSorts.Size = new System.Drawing.Size(75, 23);
            this.btnTestSorts.TabIndex = 4;
            this.btnTestSorts.Text = "Test";
            this.btnTestSorts.UseVisualStyleBackColor = true;
            this.btnTestSorts.Click += new System.EventHandler(this.BtnTestSorts_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bubble:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(223, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quick:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(428, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "BST:";
            // 
            // lblBubbleTime
            // 
            this.lblBubbleTime.AutoSize = true;
            this.lblBubbleTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBubbleTime.Location = new System.Drawing.Point(104, 97);
            this.lblBubbleTime.Name = "lblBubbleTime";
            this.lblBubbleTime.Size = new System.Drawing.Size(24, 26);
            this.lblBubbleTime.TabIndex = 0;
            this.lblBubbleTime.Text = "0";
            // 
            // lblQuickTime
            // 
            this.lblQuickTime.AutoSize = true;
            this.lblQuickTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuickTime.Location = new System.Drawing.Point(303, 97);
            this.lblQuickTime.Name = "lblQuickTime";
            this.lblQuickTime.Size = new System.Drawing.Size(24, 26);
            this.lblQuickTime.TabIndex = 0;
            this.lblQuickTime.Text = "0";
            // 
            // lblBstTime
            // 
            this.lblBstTime.AutoSize = true;
            this.lblBstTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBstTime.Location = new System.Drawing.Point(494, 97);
            this.lblBstTime.Name = "lblBstTime";
            this.lblBstTime.Size = new System.Drawing.Size(24, 26);
            this.lblBstTime.TabIndex = 0;
            this.lblBstTime.Text = "0";
            // 
            // SortTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(713, 450);
            this.Controls.Add(this.btnTestSorts);
            this.Controls.Add(this.dgvTestVremena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNumbers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBstTime);
            this.Controls.Add(this.lblQuickTime);
            this.Controls.Add(this.lblBubbleTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "SortTest";
            this.Text = "SortTest";
            this.Load += new System.EventHandler(this.SortTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestVremena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumbers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTestVremena;
        private System.Windows.Forms.Button btnTestSorts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBubbleTime;
        private System.Windows.Forms.Label lblQuickTime;
        private System.Windows.Forms.Label lblBstTime;
    }
}