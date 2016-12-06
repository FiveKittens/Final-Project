namespace FrmLogin.View
{
    partial class Form5
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PF Encore Sans Pro Medium", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "1 Suara Untuk  :";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox1.Font = new System.Drawing.Font("PF Encore Sans Pro Medium", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(119, 94);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 198);
            this.textBox1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(411, 372);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel3.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnSubmit, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 322);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(405, 47);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bebas Neue Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(273, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Bebas Neue Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(3, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(129, 41);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FrmLogin.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(435, 396);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSubmit;
    }
}