namespace Test_Program
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
            label1 = new Label();
            bttnAdd = new Button();
            lstNames = new ListBox();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Names";
            // 
            // bttnAdd
            // 
            bttnAdd.Location = new Point(138, 55);
            bttnAdd.Name = "bttnAdd";
            bttnAdd.Size = new Size(100, 31);
            bttnAdd.TabIndex = 1;
            bttnAdd.Text = "Add Name";
            bttnAdd.UseVisualStyleBackColor = true;
            bttnAdd.Click += bttnAdd_Click;
            // 
            // lstNames
            // 
            lstNames.FormattingEnabled = true;
            lstNames.Location = new Point(12, 27);
            lstNames.Name = "lstNames";
            lstNames.Size = new Size(106, 104);
            lstNames.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(138, 26);
            txtName.MaximumSize = new Size(100, 23);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 27);
            txtName.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 133);
            Controls.Add(txtName);
            Controls.Add(lstNames);
            Controls.Add(bttnAdd);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Names";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button bttnAdd;
        private ListBox lstNames;
        private TextBox txtName;
    }
}
