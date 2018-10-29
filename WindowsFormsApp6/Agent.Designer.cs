namespace WindowsFormsApp6
{
    partial class Agent
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
            this.ButAddAgent = new System.Windows.Forms.Button();
            this.ButEditAgent = new System.Windows.Forms.Button();
            this.ButDeliteAgent = new System.Windows.Forms.Button();
            this.ButClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.listBox1.ForeColor = System.Drawing.Color.Blue;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Панкратов Илья Максимович",
            "Лозовой Дмитрий Сергеевич",
            "Макеев Максим Сергеевич",
            "Сергеечева Наталья Викторовна",
            "Пономоренко Лариса Георгиевна",
            "Антипова Светлана Георгиевна",
            "Смольская Екатерина Сергеевна",
            "Пожарский Максим Георгиевич",
            "Смоленский Дмитрий Максимович",
            "Прокудин Виктор Георгиевич",
            "Пономарёва Мария Максимовна",
            "Беляева Марья Семёновна",
            "Панькина Екатерина Сергеевна",
            "Панькина Елизавета Сергеевна"});
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(171, 199);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ButAddAgent
            // 
            this.ButAddAgent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ButAddAgent.Location = new System.Drawing.Point(213, 38);
            this.ButAddAgent.Name = "ButAddAgent";
            this.ButAddAgent.Size = new System.Drawing.Size(75, 23);
            this.ButAddAgent.TabIndex = 1;
            this.ButAddAgent.Text = "Добавить";
            this.ButAddAgent.UseVisualStyleBackColor = true;
            this.ButAddAgent.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButEditAgent
            // 
            this.ButEditAgent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ButEditAgent.Location = new System.Drawing.Point(213, 82);
            this.ButEditAgent.Name = "ButEditAgent";
            this.ButEditAgent.Size = new System.Drawing.Size(75, 23);
            this.ButEditAgent.TabIndex = 2;
            this.ButEditAgent.Text = "Изменить";
            this.ButEditAgent.UseVisualStyleBackColor = true;
            // 
            // ButDeliteAgent
            // 
            this.ButDeliteAgent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ButDeliteAgent.Location = new System.Drawing.Point(213, 124);
            this.ButDeliteAgent.Name = "ButDeliteAgent";
            this.ButDeliteAgent.Size = new System.Drawing.Size(75, 23);
            this.ButDeliteAgent.TabIndex = 3;
            this.ButDeliteAgent.Text = "Удалить";
            this.ButDeliteAgent.UseVisualStyleBackColor = true;
            this.ButDeliteAgent.Click += new System.EventHandler(this.button3_Click);
            // 
            // ButClose
            // 
            this.ButClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ButClose.Location = new System.Drawing.Point(213, 162);
            this.ButClose.Name = "ButClose";
            this.ButClose.Size = new System.Drawing.Size(75, 23);
            this.ButClose.TabIndex = 4;
            this.ButClose.Text = "Отмена";
            this.ButClose.UseVisualStyleBackColor = true;
            this.ButClose.Click += new System.EventHandler(this.button4_Click);
            // 
            // Agent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(309, 325);
            this.Controls.Add(this.ButClose);
            this.Controls.Add(this.ButDeliteAgent);
            this.Controls.Add(this.ButEditAgent);
            this.Controls.Add(this.ButAddAgent);
            this.Controls.Add(this.listBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Agent";
            this.Text = "Agent";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ButAddAgent;
        private System.Windows.Forms.Button ButEditAgent;
        private System.Windows.Forms.Button ButDeliteAgent;
        private System.Windows.Forms.Button ButClose;
    }
}