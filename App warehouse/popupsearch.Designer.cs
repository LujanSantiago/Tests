namespace App_warehouse
{
    partial class popupsearch
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
            this.textboxid = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.delete1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.idtxt = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.Label();
            this.amounttxt = new System.Windows.Forms.Label();
            this.desctxt = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Search by ID";
            // 
            // textboxid
            // 
            this.textboxid.Location = new System.Drawing.Point(12, 40);
            this.textboxid.Name = "textboxid";
            this.textboxid.Size = new System.Drawing.Size(331, 20);
            this.textboxid.TabIndex = 11;
            this.textboxid.TextChanged += new System.EventHandler(this.textboxid_TextChanged);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(167, 202);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(103, 36);
            this.cancel.TabIndex = 10;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // delete1
            // 
            this.delete1.Location = new System.Drawing.Point(377, 31);
            this.delete1.Name = "delete1";
            this.delete1.Size = new System.Drawing.Size(103, 36);
            this.delete1.TabIndex = 9;
            this.delete1.Text = "Search";
            this.delete1.UseVisualStyleBackColor = true;
            this.delete1.Click += new System.EventHandler(this.delete1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "id";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "uname";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "amount";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "description";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.idtxt, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nametxt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.amounttxt, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.desctxt, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 83);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.69663F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.30337F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(476, 100);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // idtxt
            // 
            this.idtxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idtxt.AutoSize = true;
            this.idtxt.Location = new System.Drawing.Point(42, 21);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(10, 13);
            this.idtxt.TabIndex = 17;
            this.idtxt.Text = " ";
            // 
            // nametxt
            // 
            this.nametxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nametxt.AutoSize = true;
            this.nametxt.Location = new System.Drawing.Point(137, 21);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(10, 13);
            this.nametxt.TabIndex = 18;
            this.nametxt.Text = " ";
            // 
            // amounttxt
            // 
            this.amounttxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.amounttxt.AutoSize = true;
            this.amounttxt.Location = new System.Drawing.Point(232, 21);
            this.amounttxt.Name = "amounttxt";
            this.amounttxt.Size = new System.Drawing.Size(10, 13);
            this.amounttxt.TabIndex = 19;
            this.amounttxt.Text = " ";
            this.amounttxt.Click += new System.EventHandler(this.label8_Click);
            // 
            // desctxt
            // 
            this.desctxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.desctxt.AutoSize = true;
            this.desctxt.Location = new System.Drawing.Point(375, 21);
            this.desctxt.Name = "desctxt";
            this.desctxt.Size = new System.Drawing.Size(10, 13);
            this.desctxt.TabIndex = 20;
            this.desctxt.Text = " ";
            this.desctxt.Click += new System.EventHandler(this.desctxt_Click);
            // 
            // popupsearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxid);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.delete1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "popupsearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "popupsearch";
            this.Load += new System.EventHandler(this.popupsearch_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxid;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button delete1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label idtxt;
        private System.Windows.Forms.Label nametxt;
        private System.Windows.Forms.Label amounttxt;
        private System.Windows.Forms.Label desctxt;
    }
}