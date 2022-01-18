
namespace Lab_14FW
{
    partial class FormMain
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
            this.button_input = new System.Windows.Forms.Button();
            this.button_calc = new System.Windows.Forms.Button();
            this.button_quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_input
            // 
            this.button_input.Location = new System.Drawing.Point(31, 38);
            this.button_input.Name = "button_input";
            this.button_input.Size = new System.Drawing.Size(75, 23);
            this.button_input.TabIndex = 0;
            this.button_input.Text = "Input";
            this.button_input.UseVisualStyleBackColor = true;
            this.button_input.Click += new System.EventHandler(this.button_input_Click);
            // 
            // button_calc
            // 
            this.button_calc.Enabled = false;
            this.button_calc.Location = new System.Drawing.Point(151, 38);
            this.button_calc.Name = "button_calc";
            this.button_calc.Size = new System.Drawing.Size(75, 23);
            this.button_calc.TabIndex = 1;
            this.button_calc.Text = "Calc";
            this.button_calc.UseVisualStyleBackColor = true;
            this.button_calc.Click += new System.EventHandler(this.button_calc_Click);
            // 
            // button_quit
            // 
            this.button_quit.Location = new System.Drawing.Point(280, 38);
            this.button_quit.Name = "button_quit";
            this.button_quit.Size = new System.Drawing.Size(75, 23);
            this.button_quit.TabIndex = 2;
            this.button_quit.Text = "Quit";
            this.button_quit.UseVisualStyleBackColor = true;
            this.button_quit.Click += new System.EventHandler(this.button_quit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 111);
            this.Controls.Add(this.button_quit);
            this.Controls.Add(this.button_calc);
            this.Controls.Add(this.button_input);
            this.Name = "Form1";
            this.Text = "Евдоченко Антон Владимирович 6 вариант";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_input;
        private System.Windows.Forms.Button button_calc;
        private System.Windows.Forms.Button button_quit;
    }
}

