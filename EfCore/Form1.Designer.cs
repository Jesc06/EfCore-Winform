namespace EfCore
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            name = new Label();
            Middlename = new Label();
            Lastname = new Label();
            addStudent = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(226, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 50);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(226, 182);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(296, 50);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(226, 273);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(296, 50);
            textBox3.TabIndex = 2;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name.Location = new Point(226, 48);
            name.Name = "name";
            name.Size = new Size(79, 32);
            name.TabIndex = 3;
            name.Text = "Name";
            // 
            // Middlename
            // 
            Middlename.AutoSize = true;
            Middlename.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Middlename.Location = new Point(226, 148);
            Middlename.Name = "Middlename";
            Middlename.Size = new Size(150, 32);
            Middlename.TabIndex = 4;
            Middlename.Text = "Middlename";
          
            // 
            // Lastname
            // 
            Lastname.AutoSize = true;
            Lastname.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lastname.Location = new Point(226, 238);
            Lastname.Name = "Lastname";
            Lastname.Size = new Size(119, 32);
            Lastname.TabIndex = 5;
            Lastname.Text = "Lastname";
            // 
            // addStudent
            // 
            addStudent.Location = new Point(222, 351);
            addStudent.Name = "addStudent";
            addStudent.Size = new Size(299, 65);
            addStudent.TabIndex = 6;
            addStudent.Text = "AddStudent";
            addStudent.UseVisualStyleBackColor = true;
            addStudent.Click += addStudent_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addStudent);
            Controls.Add(Lastname);
            Controls.Add(Middlename);
            Controls.Add(name);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
          
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label name;
        private Label Middlename;
        private Label Lastname;
        private Button addStudent;
    }
}
