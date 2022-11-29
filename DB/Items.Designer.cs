namespace DB
{
    partial class Items
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
            this.panel15 = new System.Windows.Forms.Panel();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.textBox49 = new System.Windows.Forms.TextBox();
            this.textBox50 = new System.Windows.Forms.TextBox();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel15.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.textBox39);
            this.panel15.Controls.Add(this.label43);
            this.panel15.Controls.Add(this.textBox49);
            this.panel15.Controls.Add(this.textBox50);
            this.panel15.Controls.Add(this.label79);
            this.panel15.Controls.Add(this.label80);
            this.panel15.Location = new System.Drawing.Point(49, 68);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(456, 108);
            this.panel15.TabIndex = 42;
            // 
            // textBox39
            // 
            this.textBox39.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.textBox39.Location = new System.Drawing.Point(144, 74);
            this.textBox39.Name = "textBox39";
            this.textBox39.Size = new System.Drawing.Size(213, 25);
            this.textBox39.TabIndex = 43;
            this.textBox39.TextChanged += new System.EventHandler(this.textBox39_TextChanged);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(78)))));
            this.label43.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label43.ForeColor = System.Drawing.Color.White;
            this.label43.Location = new System.Drawing.Point(4, 78);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(104, 17);
            this.label43.TabIndex = 42;
            this.label43.Text = "Преподователи";
            // 
            // textBox49
            // 
            this.textBox49.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.textBox49.Location = new System.Drawing.Point(144, 12);
            this.textBox49.Name = "textBox49";
            this.textBox49.Size = new System.Drawing.Size(213, 25);
            this.textBox49.TabIndex = 8;
            // 
            // textBox50
            // 
            this.textBox50.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.textBox50.Location = new System.Drawing.Point(144, 43);
            this.textBox50.Name = "textBox50";
            this.textBox50.Size = new System.Drawing.Size(213, 25);
            this.textBox50.TabIndex = 9;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(78)))));
            this.label79.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label79.ForeColor = System.Drawing.Color.White;
            this.label79.Location = new System.Drawing.Point(3, 43);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(97, 17);
            this.label79.TabIndex = 13;
            this.label79.Text = "Оплата за час";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(78)))));
            this.label80.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label80.ForeColor = System.Drawing.Color.White;
            this.label80.Location = new System.Drawing.Point(4, 12);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(131, 17);
            this.label80.TabIndex = 14;
            this.label80.Text = "Название предмета";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(173, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 24);
            this.label7.TabIndex = 43;
            this.label7.Text = "Добавление записи:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(193, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 37);
            this.button1.TabIndex = 44;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(548, 272);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel15);
            this.Name = "Items";
            this.Text = "Items";
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox textBox49;
        private System.Windows.Forms.TextBox textBox50;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox39;
        private System.Windows.Forms.Label label43;
    }
}