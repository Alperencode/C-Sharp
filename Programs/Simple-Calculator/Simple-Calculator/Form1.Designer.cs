namespace Calculator
{
    partial class Calculator
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.btn_nm7 = new System.Windows.Forms.Button();
            this.btn_nm8 = new System.Windows.Forms.Button();
            this.btn_op_divide = new System.Windows.Forms.Button();
            this.btn_num9 = new System.Windows.Forms.Button();
            this.btn_op_CE = new System.Windows.Forms.Button();
            this.btn_op_C = new System.Windows.Forms.Button();
            this.btn_nm6 = new System.Windows.Forms.Button();
            this.btn_op_multiplication = new System.Windows.Forms.Button();
            this.btn_nm5 = new System.Windows.Forms.Button();
            this.btn_nm4 = new System.Windows.Forms.Button();
            this.btn_nm3 = new System.Windows.Forms.Button();
            this.btn_op_minus = new System.Windows.Forms.Button();
            this.btn_nm2 = new System.Windows.Forms.Button();
            this.btn_nm1 = new System.Windows.Forms.Button();
            this.btn_nm0 = new System.Windows.Forms.Button();
            this.btn_op_add = new System.Windows.Forms.Button();
            this.btn_op_equal = new System.Windows.Forms.Button();
            this.btn_op_point = new System.Windows.Forms.Button();
            this.result_text = new System.Windows.Forms.TextBox();
            this.prev_operation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_nm7
            // 
            this.btn_nm7.BackColor = System.Drawing.Color.Bisque;
            this.btn_nm7.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_nm7.Location = new System.Drawing.Point(17, 87);
            this.btn_nm7.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nm7.Name = "btn_nm7";
            this.btn_nm7.Size = new System.Drawing.Size(60, 55);
            this.btn_nm7.TabIndex = 0;
            this.btn_nm7.Text = "7";
            this.btn_nm7.UseVisualStyleBackColor = false;
            this.btn_nm7.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn_nm8
            // 
            this.btn_nm8.BackColor = System.Drawing.Color.Bisque;
            this.btn_nm8.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_nm8.Location = new System.Drawing.Point(85, 87);
            this.btn_nm8.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nm8.Name = "btn_nm8";
            this.btn_nm8.Size = new System.Drawing.Size(60, 55);
            this.btn_nm8.TabIndex = 1;
            this.btn_nm8.Text = "8";
            this.btn_nm8.UseVisualStyleBackColor = false;
            this.btn_nm8.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn_op_divide
            // 
            this.btn_op_divide.BackColor = System.Drawing.Color.Bisque;
            this.btn_op_divide.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_op_divide.Location = new System.Drawing.Point(221, 87);
            this.btn_op_divide.Margin = new System.Windows.Forms.Padding(4);
            this.btn_op_divide.Name = "btn_op_divide";
            this.btn_op_divide.Size = new System.Drawing.Size(60, 55);
            this.btn_op_divide.TabIndex = 2;
            this.btn_op_divide.Text = "/";
            this.btn_op_divide.UseVisualStyleBackColor = false;
            this.btn_op_divide.Click += new System.EventHandler(this.Operator_click_Event);
            // 
            // btn_num9
            // 
            this.btn_num9.BackColor = System.Drawing.Color.Bisque;
            this.btn_num9.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_num9.Location = new System.Drawing.Point(153, 87);
            this.btn_num9.Margin = new System.Windows.Forms.Padding(4);
            this.btn_num9.Name = "btn_num9";
            this.btn_num9.Size = new System.Drawing.Size(60, 55);
            this.btn_num9.TabIndex = 3;
            this.btn_num9.Text = "9";
            this.btn_num9.UseVisualStyleBackColor = false;
            this.btn_num9.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn_op_CE
            // 
            this.btn_op_CE.BackColor = System.Drawing.Color.Bisque;
            this.btn_op_CE.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_op_CE.Location = new System.Drawing.Point(289, 87);
            this.btn_op_CE.Margin = new System.Windows.Forms.Padding(4);
            this.btn_op_CE.Name = "btn_op_CE";
            this.btn_op_CE.Size = new System.Drawing.Size(60, 55);
            this.btn_op_CE.TabIndex = 4;
            this.btn_op_CE.Text = "CE";
            this.btn_op_CE.UseVisualStyleBackColor = false;
            this.btn_op_CE.Click += new System.EventHandler(this.op_CE_Click);
            // 
            // btn_op_C
            // 
            this.btn_op_C.BackColor = System.Drawing.Color.Bisque;
            this.btn_op_C.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_op_C.Location = new System.Drawing.Point(289, 150);
            this.btn_op_C.Margin = new System.Windows.Forms.Padding(4);
            this.btn_op_C.Name = "btn_op_C";
            this.btn_op_C.Size = new System.Drawing.Size(60, 55);
            this.btn_op_C.TabIndex = 9;
            this.btn_op_C.Text = "C";
            this.btn_op_C.UseVisualStyleBackColor = false;
            this.btn_op_C.Click += new System.EventHandler(this.op_C_Click);
            // 
            // btn_nm6
            // 
            this.btn_nm6.BackColor = System.Drawing.Color.Bisque;
            this.btn_nm6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_nm6.Location = new System.Drawing.Point(153, 150);
            this.btn_nm6.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nm6.Name = "btn_nm6";
            this.btn_nm6.Size = new System.Drawing.Size(60, 55);
            this.btn_nm6.TabIndex = 8;
            this.btn_nm6.Text = "6";
            this.btn_nm6.UseVisualStyleBackColor = false;
            this.btn_nm6.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn_op_multiplication
            // 
            this.btn_op_multiplication.BackColor = System.Drawing.Color.Bisque;
            this.btn_op_multiplication.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_op_multiplication.Location = new System.Drawing.Point(221, 150);
            this.btn_op_multiplication.Margin = new System.Windows.Forms.Padding(4);
            this.btn_op_multiplication.Name = "btn_op_multiplication";
            this.btn_op_multiplication.Size = new System.Drawing.Size(60, 55);
            this.btn_op_multiplication.TabIndex = 7;
            this.btn_op_multiplication.Text = "*";
            this.btn_op_multiplication.UseVisualStyleBackColor = false;
            this.btn_op_multiplication.Click += new System.EventHandler(this.Operator_click_Event);
            // 
            // btn_nm5
            // 
            this.btn_nm5.BackColor = System.Drawing.Color.Bisque;
            this.btn_nm5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_nm5.Location = new System.Drawing.Point(85, 150);
            this.btn_nm5.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nm5.Name = "btn_nm5";
            this.btn_nm5.Size = new System.Drawing.Size(60, 55);
            this.btn_nm5.TabIndex = 6;
            this.btn_nm5.Text = "5";
            this.btn_nm5.UseVisualStyleBackColor = false;
            this.btn_nm5.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn_nm4
            // 
            this.btn_nm4.BackColor = System.Drawing.Color.Bisque;
            this.btn_nm4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_nm4.Location = new System.Drawing.Point(17, 150);
            this.btn_nm4.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nm4.Name = "btn_nm4";
            this.btn_nm4.Size = new System.Drawing.Size(60, 55);
            this.btn_nm4.TabIndex = 5;
            this.btn_nm4.Text = "4";
            this.btn_nm4.UseVisualStyleBackColor = false;
            this.btn_nm4.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn_nm3
            // 
            this.btn_nm3.BackColor = System.Drawing.Color.Bisque;
            this.btn_nm3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_nm3.Location = new System.Drawing.Point(153, 213);
            this.btn_nm3.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nm3.Name = "btn_nm3";
            this.btn_nm3.Size = new System.Drawing.Size(60, 55);
            this.btn_nm3.TabIndex = 13;
            this.btn_nm3.Text = "3";
            this.btn_nm3.UseVisualStyleBackColor = false;
            this.btn_nm3.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn_op_minus
            // 
            this.btn_op_minus.BackColor = System.Drawing.Color.Bisque;
            this.btn_op_minus.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_op_minus.Location = new System.Drawing.Point(221, 213);
            this.btn_op_minus.Margin = new System.Windows.Forms.Padding(4);
            this.btn_op_minus.Name = "btn_op_minus";
            this.btn_op_minus.Size = new System.Drawing.Size(60, 55);
            this.btn_op_minus.TabIndex = 12;
            this.btn_op_minus.Text = "-";
            this.btn_op_minus.UseVisualStyleBackColor = false;
            this.btn_op_minus.Click += new System.EventHandler(this.Operator_click_Event);
            // 
            // btn_nm2
            // 
            this.btn_nm2.BackColor = System.Drawing.Color.Bisque;
            this.btn_nm2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_nm2.Location = new System.Drawing.Point(85, 213);
            this.btn_nm2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nm2.Name = "btn_nm2";
            this.btn_nm2.Size = new System.Drawing.Size(60, 55);
            this.btn_nm2.TabIndex = 11;
            this.btn_nm2.Text = "2";
            this.btn_nm2.UseVisualStyleBackColor = false;
            this.btn_nm2.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn_nm1
            // 
            this.btn_nm1.BackColor = System.Drawing.Color.Bisque;
            this.btn_nm1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_nm1.Location = new System.Drawing.Point(17, 213);
            this.btn_nm1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nm1.Name = "btn_nm1";
            this.btn_nm1.Size = new System.Drawing.Size(60, 55);
            this.btn_nm1.TabIndex = 10;
            this.btn_nm1.Text = "1";
            this.btn_nm1.UseVisualStyleBackColor = false;
            this.btn_nm1.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn_nm0
            // 
            this.btn_nm0.BackColor = System.Drawing.Color.Bisque;
            this.btn_nm0.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_nm0.Location = new System.Drawing.Point(17, 276);
            this.btn_nm0.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nm0.Name = "btn_nm0";
            this.btn_nm0.Size = new System.Drawing.Size(128, 55);
            this.btn_nm0.TabIndex = 15;
            this.btn_nm0.Text = "0";
            this.btn_nm0.UseVisualStyleBackColor = false;
            this.btn_nm0.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn_op_add
            // 
            this.btn_op_add.BackColor = System.Drawing.Color.Bisque;
            this.btn_op_add.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_op_add.Location = new System.Drawing.Point(221, 276);
            this.btn_op_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_op_add.Name = "btn_op_add";
            this.btn_op_add.Size = new System.Drawing.Size(60, 55);
            this.btn_op_add.TabIndex = 17;
            this.btn_op_add.Text = "+";
            this.btn_op_add.UseVisualStyleBackColor = false;
            this.btn_op_add.Click += new System.EventHandler(this.Operator_click_Event);
            // 
            // btn_op_equal
            // 
            this.btn_op_equal.BackColor = System.Drawing.Color.Bisque;
            this.btn_op_equal.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_op_equal.Location = new System.Drawing.Point(289, 213);
            this.btn_op_equal.Margin = new System.Windows.Forms.Padding(4);
            this.btn_op_equal.Name = "btn_op_equal";
            this.btn_op_equal.Size = new System.Drawing.Size(60, 118);
            this.btn_op_equal.TabIndex = 19;
            this.btn_op_equal.Text = "=";
            this.btn_op_equal.UseVisualStyleBackColor = false;
            this.btn_op_equal.Click += new System.EventHandler(this.equal_op_Click);
            // 
            // btn_op_point
            // 
            this.btn_op_point.BackColor = System.Drawing.Color.Bisque;
            this.btn_op_point.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_op_point.Location = new System.Drawing.Point(153, 276);
            this.btn_op_point.Margin = new System.Windows.Forms.Padding(4);
            this.btn_op_point.Name = "btn_op_point";
            this.btn_op_point.Size = new System.Drawing.Size(60, 55);
            this.btn_op_point.TabIndex = 18;
            this.btn_op_point.Text = ".";
            this.btn_op_point.UseVisualStyleBackColor = false;
            this.btn_op_point.Click += new System.EventHandler(this.Number_Click);
            // 
            // result_text
            // 
            this.result_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.result_text.Location = new System.Drawing.Point(20, 30);
            this.result_text.Margin = new System.Windows.Forms.Padding(4);
            this.result_text.Name = "result_text";
            this.result_text.Size = new System.Drawing.Size(330, 30);
            this.result_text.TabIndex = 20;
            this.result_text.Text = "0";
            this.result_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // prev_operation
            // 
            this.prev_operation.AutoSize = true;
            this.prev_operation.Location = new System.Drawing.Point(17, 10);
            this.prev_operation.Name = "prev_operation";
            this.prev_operation.Size = new System.Drawing.Size(0, 17);
            this.prev_operation.TabIndex = 21;
            this.prev_operation.Click += new System.EventHandler(this.label1_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(375, 350);
            this.Controls.Add(this.prev_operation);
            this.Controls.Add(this.result_text);
            this.Controls.Add(this.btn_op_equal);
            this.Controls.Add(this.btn_op_point);
            this.Controls.Add(this.btn_op_add);
            this.Controls.Add(this.btn_nm0);
            this.Controls.Add(this.btn_nm3);
            this.Controls.Add(this.btn_op_minus);
            this.Controls.Add(this.btn_nm2);
            this.Controls.Add(this.btn_nm1);
            this.Controls.Add(this.btn_op_C);
            this.Controls.Add(this.btn_nm6);
            this.Controls.Add(this.btn_op_multiplication);
            this.Controls.Add(this.btn_nm5);
            this.Controls.Add(this.btn_nm4);
            this.Controls.Add(this.btn_op_CE);
            this.Controls.Add(this.btn_num9);
            this.Controls.Add(this.btn_op_divide);
            this.Controls.Add(this.btn_nm8);
            this.Controls.Add(this.btn_nm7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btn_nm7;
        private System.Windows.Forms.Button btn_nm8;
        private System.Windows.Forms.Button btn_op_divide;
        private System.Windows.Forms.Button btn_num9;
        private System.Windows.Forms.Button btn_op_CE;
        private System.Windows.Forms.Button btn_op_C;
        private System.Windows.Forms.Button btn_nm6;
        private System.Windows.Forms.Button btn_op_multiplication;
        private System.Windows.Forms.Button btn_nm5;
        private System.Windows.Forms.Button btn_nm4;
        private System.Windows.Forms.Button btn_nm3;
        private System.Windows.Forms.Button btn_op_minus;
        private System.Windows.Forms.Button btn_nm2;
        private System.Windows.Forms.Button btn_nm1;
        private System.Windows.Forms.Button btn_nm0;
        private System.Windows.Forms.Button btn_op_add;
        private System.Windows.Forms.Button btn_op_equal;
        private System.Windows.Forms.Button btn_op_point;
        private System.Windows.Forms.TextBox result_text;
        private System.Windows.Forms.Label prev_operation;
    }
}
