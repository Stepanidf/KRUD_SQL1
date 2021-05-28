
namespace visual_and_bd
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addBd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.editbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(498, 212);
            this.dataGridView1.TabIndex = 0;
            // 
            // addBd
            // 
            this.addBd.Location = new System.Drawing.Point(22, 246);
            this.addBd.Name = "addBd";
            this.addBd.Size = new System.Drawing.Size(75, 43);
            this.addBd.TabIndex = 1;
            this.addBd.Text = "добавить";
            this.addBd.UseVisualStyleBackColor = true;
            this.addBd.Click += new System.EventHandler(this.addBd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // editbutton
            // 
            this.editbutton.Location = new System.Drawing.Point(186, 246);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(113, 43);
            this.editbutton.TabIndex = 3;
            this.editbutton.Text = "Редакировать";
            this.editbutton.UseVisualStyleBackColor = true;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 322);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addBd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "   ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addBd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button editbutton;
    }
}

