namespace Hero_Quest
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
            NameText = new TextBox();
            Enteryourname = new Label();
            SetName = new Button();
            OutputLabel = new Label();
            SuspendLayout();
            // 
            // NameText
            // 
            NameText.Location = new Point(222, 43);
            NameText.Name = "NameText";
            NameText.Size = new Size(177, 27);
            NameText.TabIndex = 1;
            NameText.TextChanged += NameText_TextChanged;
            // 
            // Enteryourname
            // 
            Enteryourname.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Enteryourname.ForeColor = SystemColors.ButtonFace;
            Enteryourname.Location = new Point(12, 42);
            Enteryourname.Name = "Enteryourname";
            Enteryourname.Size = new Size(183, 34);
            Enteryourname.TabIndex = 3;
            Enteryourname.Text = "Enter Your Name";
            // 
            // SetName
            // 
            SetName.Location = new Point(239, 95);
            SetName.Name = "SetName";
            SetName.Size = new Size(150, 35);
            SetName.TabIndex = 5;
            SetName.Text = "SetName";
            SetName.UseVisualStyleBackColor = true;
            SetName.Click += SetName_Click;
            // 
            // OutputLabel
            // 
            OutputLabel.ForeColor = SystemColors.ButtonFace;
            OutputLabel.Location = new Point(224, 152);
            OutputLabel.Name = "OutputLabel";
            OutputLabel.Size = new Size(175, 38);
            OutputLabel.TabIndex = 6;
            OutputLabel.Text = "Output Label";
            OutputLabel.TextAlign = ContentAlignment.MiddleCenter;
            OutputLabel.Click += OutputLabel_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(723, 445);
            Controls.Add(OutputLabel);
            Controls.Add(SetName);
            Controls.Add(Enteryourname);
            Controls.Add(NameText);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameText;
        private Label Enteryourname;
        private Button SetName;
        private Label OutputLabel;
    }
}
