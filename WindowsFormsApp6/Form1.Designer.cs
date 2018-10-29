namespace WindowsFormsApp6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButWorkClients = new System.Windows.Forms.Button();
            this.ButWorkAgent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButWorkClients
            // 
            this.ButWorkClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ButWorkClients.Location = new System.Drawing.Point(135, 149);
            this.ButWorkClients.Name = "ButWorkClients";
            this.ButWorkClients.Size = new System.Drawing.Size(123, 42);
            this.ButWorkClients.TabIndex = 0;
            this.ButWorkClients.Text = "Работа с клиентами";
            this.ButWorkClients.UseVisualStyleBackColor = true;
            this.ButWorkClients.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButWorkAgent
            // 
            this.ButWorkAgent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ButWorkAgent.Location = new System.Drawing.Point(135, 91);
            this.ButWorkAgent.Name = "ButWorkAgent";
            this.ButWorkAgent.Size = new System.Drawing.Size(121, 39);
            this.ButWorkAgent.TabIndex = 1;
            this.ButWorkAgent.Text = "Работа с Агентами";
            this.ButWorkAgent.UseVisualStyleBackColor = true;
            this.ButWorkAgent.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(374, 321);
            this.Controls.Add(this.ButWorkAgent);
            this.Controls.Add(this.ButWorkClients);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButWorkClients;
        private System.Windows.Forms.Button ButWorkAgent;
    }
}

