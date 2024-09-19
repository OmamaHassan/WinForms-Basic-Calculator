namespace WinFormsAppCalculator
{
    partial class BasicCalculator
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtResult = new TextBox();
            comboOpe = new ComboBox();
            btnClear = new Button();
            btnOK = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(158, 9);
            label1.Name = "label1";
            label1.Size = new Size(220, 37);
            label1.TabIndex = 0;
            label1.Text = "Basic Calculator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 97);
            label2.Name = "label2";
            label2.Size = new Size(127, 30);
            label2.TabIndex = 1;
            label2.Text = "1st Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 173);
            label3.Name = "label3";
            label3.Size = new Size(135, 30);
            label3.TabIndex = 2;
            label3.Text = "2nd Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(52, 250);
            label4.Name = "label4";
            label4.Size = new Size(111, 30);
            label4.TabIndex = 3;
            label4.Text = "Operation:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(52, 320);
            label5.Name = "label5";
            label5.Size = new Size(74, 30);
            label5.TabIndex = 4;
            label5.Text = "Result:";
            // 
            // txtNum1
            // 
            txtNum1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNum1.Location = new Point(214, 94);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(242, 33);
            txtNum1.TabIndex = 5;
            txtNum1.KeyPress += txtNum1_KeyPress;
            // 
            // txtNum2
            // 
            txtNum2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNum2.Location = new Point(214, 170);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(242, 33);
            txtNum2.TabIndex = 6;
            txtNum2.KeyPress += txtNum2_KeyPress;
            // 
            // txtResult
            // 
            txtResult.BackColor = Color.DimGray;
            txtResult.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResult.ForeColor = Color.White;
            txtResult.Location = new Point(214, 321);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(242, 33);
            txtResult.TabIndex = 7;
            // 
            // comboOpe
            // 
            comboOpe.DropDownStyle = ComboBoxStyle.DropDownList;
            comboOpe.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboOpe.FormattingEnabled = true;
            comboOpe.Items.AddRange(new object[] { "Add", "Subtract", "Multiply", "Divide" });
            comboOpe.Location = new Point(214, 247);
            comboOpe.Name = "comboOpe";
            comboOpe.Size = new Size(242, 33);
            comboOpe.TabIndex = 8;
            comboOpe.SelectedIndexChanged += comboOpe_SelectedIndexChanged;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(317, 407);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(101, 38);
            btnClear.TabIndex = 9;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnOK
            // 
            btnOK.BackColor = SystemColors.ControlText;
            btnOK.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOK.ForeColor = Color.White;
            btnOK.Location = new Point(109, 407);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(101, 38);
            btnOK.TabIndex = 10;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // BasicCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(538, 472);
            Controls.Add(btnOK);
            Controls.Add(btnClear);
            Controls.Add(comboOpe);
            Controls.Add(txtResult);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BasicCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BasicCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtResult;
        private ComboBox comboOpe;
        private Button btnClear;
        private Button btnOK;
    }
}
