namespace FirstFormsApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.form_num1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.form_num2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.form_operation = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.form_answer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // form_num1
            // 
            this.form_num1.Location = new System.Drawing.Point(694, 223);
            this.form_num1.Name = "form_num1";
            this.form_num1.Size = new System.Drawing.Size(225, 43);
            this.form_num1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(478, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Second Number";
            // 
            // form_num2
            // 
            this.form_num2.Location = new System.Drawing.Point(694, 297);
            this.form_num2.Name = "form_num2";
            this.form_num2.Size = new System.Drawing.Size(225, 43);
            this.form_num2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Operation";
            // 
            // form_operation
            // 
            this.form_operation.Location = new System.Drawing.Point(694, 379);
            this.form_operation.Name = "form_operation";
            this.form_operation.Size = new System.Drawing.Size(225, 43);
            this.form_operation.TabIndex = 4;
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(576, 470);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(291, 58);
            this.btn_calculate.TabIndex = 6;
            this.btn_calculate.Text = "Calculate Answer";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // form_answer
            // 
            this.form_answer.AutoSize = true;
            this.form_answer.Location = new System.Drawing.Point(663, 579);
            this.form_answer.Name = "form_answer";
            this.form_answer.Size = new System.Drawing.Size(103, 37);
            this.form_answer.TabIndex = 7;
            this.form_answer.Text = "Answer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 829);
            this.Controls.Add(this.form_answer);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.form_operation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.form_num2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.form_num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox form_num1;
        private Label label1;
        private Label label2;
        private TextBox form_num2;
        private Label label3;
        private TextBox form_operation;
        private Button btn_calculate;
        private Label form_answer;
    }
}