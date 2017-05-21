namespace WindowsFormsApplication1
{
    partial class Say
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Say));
            this.hi = new System.Windows.Forms.Button();
            this.howAreYou = new System.Windows.Forms.Button();
            this.myName = new System.Windows.Forms.Button();
            this.good = new System.Windows.Forms.Button();
            this.Ilive = new System.Windows.Forms.Button();
            this.Goodbye = new System.Windows.Forms.Button();
            this.bye = new System.Windows.Forms.Button();
            this.soso = new System.Windows.Forms.Button();
            this.thankYou = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // hi
            // 
            resources.ApplyResources(this.hi, "hi");
            this.hi.Name = "hi";
            this.hi.UseVisualStyleBackColor = true;
            this.hi.Click += new System.EventHandler(this.hi_Click);
            // 
            // howAreYou
            // 
            resources.ApplyResources(this.howAreYou, "howAreYou");
            this.howAreYou.Name = "howAreYou";
            this.howAreYou.UseVisualStyleBackColor = true;
            this.howAreYou.Click += new System.EventHandler(this.howAreYou_Click);
            // 
            // myName
            // 
            resources.ApplyResources(this.myName, "myName");
            this.myName.Name = "myName";
            this.myName.UseVisualStyleBackColor = true;
            this.myName.Click += new System.EventHandler(this.myName_Click);
            // 
            // good
            // 
            resources.ApplyResources(this.good, "good");
            this.good.Name = "good";
            this.good.UseVisualStyleBackColor = true;
            this.good.Click += new System.EventHandler(this.good_Click);
            // 
            // Ilive
            // 
            resources.ApplyResources(this.Ilive, "Ilive");
            this.Ilive.Name = "Ilive";
            this.Ilive.UseVisualStyleBackColor = true;
            this.Ilive.Click += new System.EventHandler(this.Ilive_Click);
            // 
            // Goodbye
            // 
            resources.ApplyResources(this.Goodbye, "Goodbye");
            this.Goodbye.Name = "Goodbye";
            this.Goodbye.UseVisualStyleBackColor = true;
            this.Goodbye.Click += new System.EventHandler(this.Goodbye_Click);
            // 
            // bye
            // 
            resources.ApplyResources(this.bye, "bye");
            this.bye.Name = "bye";
            this.bye.UseVisualStyleBackColor = true;
            this.bye.Click += new System.EventHandler(this.bye_Click);
            // 
            // soso
            // 
            resources.ApplyResources(this.soso, "soso");
            this.soso.Name = "soso";
            this.soso.UseVisualStyleBackColor = true;
            this.soso.Click += new System.EventHandler(this.soso_Click);
            // 
            // thankYou
            // 
            resources.ApplyResources(this.thankYou, "thankYou");
            this.thankYou.Name = "thankYou";
            this.thankYou.UseVisualStyleBackColor = true;
            this.thankYou.Click += new System.EventHandler(this.thankYou_Click);
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Say
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.thankYou);
            this.Controls.Add(this.soso);
            this.Controls.Add(this.bye);
            this.Controls.Add(this.Goodbye);
            this.Controls.Add(this.Ilive);
            this.Controls.Add(this.good);
            this.Controls.Add(this.myName);
            this.Controls.Add(this.howAreYou);
            this.Controls.Add(this.hi);
            this.Name = "Say";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hi;
        private System.Windows.Forms.Button howAreYou;
        private System.Windows.Forms.Button myName;
        private System.Windows.Forms.Button good;
        private System.Windows.Forms.Button Ilive;
        private System.Windows.Forms.Button Goodbye;
        private System.Windows.Forms.Button bye;
        private System.Windows.Forms.Button soso;
        private System.Windows.Forms.Button thankYou;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

