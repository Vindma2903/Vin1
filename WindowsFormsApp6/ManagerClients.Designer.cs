namespace WindowsFormsApp6
{
    partial class ManagerClients
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ButAddClients = new System.Windows.Forms.Button();
            this.ButEditClients = new System.Windows.Forms.Button();
            this.ButDeliteClients = new System.Windows.Forms.Button();
            this.ButCanselClients = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.listBox1.ForeColor = System.Drawing.Color.Blue;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Иванов Дмитрий Сергеевич",
            "Самойлов Алексей Геннадьевич",
            "Пономарёв Дмитрий Сергеевич",
            "Пономоренко Дмитрий Георгиевич",
            "Лозовой Сергей Викторович",
            "Пушкин Константин Викторович",
            "Чайковский Илья Георгиевич",
            "Панков Даниил Сергеевич",
            "Смоленский Дмитрий Георгиевич",
            "Смольский Денис Максимович",
            "Пожарский Даниил Ильдарович",
            "",
            ""});
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(224, 160);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ButAddClients
            // 
            this.ButAddClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ButAddClients.Location = new System.Drawing.Point(81, 178);
            this.ButAddClients.Name = "ButAddClients";
            this.ButAddClients.Size = new System.Drawing.Size(75, 23);
            this.ButAddClients.TabIndex = 1;
            this.ButAddClients.Text = "Добавить";
            this.ButAddClients.UseVisualStyleBackColor = true;
            this.ButAddClients.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButEditClients
            // 
            this.ButEditClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ButEditClients.Location = new System.Drawing.Point(81, 207);
            this.ButEditClients.Name = "ButEditClients";
            this.ButEditClients.Size = new System.Drawing.Size(75, 23);
            this.ButEditClients.TabIndex = 2;
            this.ButEditClients.Text = "Изменить";
            this.ButEditClients.UseVisualStyleBackColor = true;
            // 
            // ButDeliteClients
            // 
            this.ButDeliteClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ButDeliteClients.Location = new System.Drawing.Point(81, 236);
            this.ButDeliteClients.Name = "ButDeliteClients";
            this.ButDeliteClients.Size = new System.Drawing.Size(75, 23);
            this.ButDeliteClients.TabIndex = 3;
            this.ButDeliteClients.Text = "Удалить";
            this.ButDeliteClients.UseVisualStyleBackColor = true;
            this.ButDeliteClients.Click += new System.EventHandler(this.button3_Click);
            // 
            // ButCanselClients
            // 
            this.ButCanselClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ButCanselClients.Location = new System.Drawing.Point(81, 265);
            this.ButCanselClients.Name = "ButCanselClients";
            this.ButCanselClients.Size = new System.Drawing.Size(75, 23);
            this.ButCanselClients.TabIndex = 4;
            this.ButCanselClients.Text = "Отмена";
            this.ButCanselClients.UseVisualStyleBackColor = true;
            this.ButCanselClients.Click += new System.EventHandler(this.button4_Click);
            // 
            // ManagerClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(271, 308);
            this.Controls.Add(this.ButCanselClients);
            this.Controls.Add(this.ButDeliteClients);
            this.Controls.Add(this.ButEditClients);
            this.Controls.Add(this.ButAddClients);
            this.Controls.Add(this.listBox1);
            this.Name = "ManagerClients";
            this.Text = "ManagerClients";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ButAddClients;
        private System.Windows.Forms.Button ButEditClients;
        private System.Windows.Forms.Button ButDeliteClients;
        private System.Windows.Forms.Button ButCanselClients;
    }
}