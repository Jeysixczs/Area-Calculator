namespace Area_Calculator
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
            this.txtlength = new System.Windows.Forms.TextBox();
            this.txtwidth = new System.Windows.Forms.TextBox();
            this.txtradius = new System.Windows.Forms.TextBox();
            this.txtbase = new System.Windows.Forms.TextBox();
            this.txtheight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnrectangle = new System.Windows.Forms.Button();
            this.btncircle = new System.Windows.Forms.Button();
            this.btntriangle = new System.Windows.Forms.Button();
            this.listresult = new System.Windows.Forms.ListBox();
            this.txtrecent = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtlength
            // 
            this.txtlength.Location = new System.Drawing.Point(219, 34);
            this.txtlength.Name = "txtlength";
            this.txtlength.Size = new System.Drawing.Size(292, 22);
            this.txtlength.TabIndex = 0;
            // 
            // txtwidth
            // 
            this.txtwidth.Location = new System.Drawing.Point(219, 74);
            this.txtwidth.Name = "txtwidth";
            this.txtwidth.Size = new System.Drawing.Size(292, 22);
            this.txtwidth.TabIndex = 1;
            // 
            // txtradius
            // 
            this.txtradius.Location = new System.Drawing.Point(219, 116);
            this.txtradius.Name = "txtradius";
            this.txtradius.Size = new System.Drawing.Size(292, 22);
            this.txtradius.TabIndex = 2;
            // 
            // txtbase
            // 
            this.txtbase.Location = new System.Drawing.Point(219, 162);
            this.txtbase.Name = "txtbase";
            this.txtbase.Size = new System.Drawing.Size(292, 22);
            this.txtbase.TabIndex = 3;
            // 
            // txtheight
            // 
            this.txtheight.Location = new System.Drawing.Point(219, 209);
            this.txtheight.Name = "txtheight";
            this.txtheight.Size = new System.Drawing.Size(292, 22);
            this.txtheight.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Radius";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(148, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Base";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(147, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Height";
            // 
            // btnrectangle
            // 
            this.btnrectangle.Location = new System.Drawing.Point(78, 297);
            this.btnrectangle.Name = "btnrectangle";
            this.btnrectangle.Size = new System.Drawing.Size(145, 46);
            this.btnrectangle.TabIndex = 10;
            this.btnrectangle.Text = "Rectangle";
            this.btnrectangle.UseVisualStyleBackColor = true;
            this.btnrectangle.Click += new System.EventHandler(this.btnrectangle_Click);
            // 
            // btncircle
            // 
            this.btncircle.Location = new System.Drawing.Point(273, 297);
            this.btncircle.Name = "btncircle";
            this.btncircle.Size = new System.Drawing.Size(145, 46);
            this.btncircle.TabIndex = 11;
            this.btncircle.Text = "Circle";
            this.btncircle.UseVisualStyleBackColor = true;
            this.btncircle.Click += new System.EventHandler(this.btncircle_Click);
            // 
            // btntriangle
            // 
            this.btntriangle.Location = new System.Drawing.Point(455, 297);
            this.btntriangle.Name = "btntriangle";
            this.btntriangle.Size = new System.Drawing.Size(145, 46);
            this.btntriangle.TabIndex = 12;
            this.btntriangle.Text = "Triangle";
            this.btntriangle.UseVisualStyleBackColor = true;
            this.btntriangle.Click += new System.EventHandler(this.btntriangle_Click);
            // 
            // listresult
            // 
            this.listresult.FormattingEnabled = true;
            this.listresult.ItemHeight = 16;
            this.listresult.Location = new System.Drawing.Point(641, 32);
            this.listresult.Name = "listresult";
            this.listresult.Size = new System.Drawing.Size(377, 212);
            this.listresult.TabIndex = 13;
            // 
            // txtrecent
            // 
            this.txtrecent.Location = new System.Drawing.Point(730, 285);
            this.txtrecent.Name = "txtrecent";
            this.txtrecent.Size = new System.Drawing.Size(229, 22);
            this.txtrecent.TabIndex = 14;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(273, 362);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(145, 44);
            this.btnclear.TabIndex = 15;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(786, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Most Recent";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1130, 471);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.txtrecent);
            this.Controls.Add(this.listresult);
            this.Controls.Add(this.btntriangle);
            this.Controls.Add(this.btncircle);
            this.Controls.Add(this.btnrectangle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtheight);
            this.Controls.Add(this.txtbase);
            this.Controls.Add(this.txtradius);
            this.Controls.Add(this.txtwidth);
            this.Controls.Add(this.txtlength);
            this.Name = "Form1";
            this.Text = "Area Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtlength;
        private System.Windows.Forms.TextBox txtwidth;
        private System.Windows.Forms.TextBox txtradius;
        private System.Windows.Forms.TextBox txtbase;
        private System.Windows.Forms.TextBox txtheight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnrectangle;
        private System.Windows.Forms.Button btncircle;
        private System.Windows.Forms.Button btntriangle;
        private System.Windows.Forms.ListBox listresult;
        private System.Windows.Forms.TextBox txtrecent;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label6;
    }
}

