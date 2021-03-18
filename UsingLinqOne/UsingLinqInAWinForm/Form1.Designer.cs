
namespace UsingLinqInAWinForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.filteredPeopleList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.allPeopleDropdown = new System.Windows.Forms.ComboBox();
            this.firstTestScorePicker = new System.Windows.Forms.NumericUpDown();
            this.updatePersonButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.firstTestScorePicker)).BeginInit();
            this.SuspendLayout();
            // 
            // filteredPeopleList
            // 
            this.filteredPeopleList.FormattingEnabled = true;
            this.filteredPeopleList.ItemHeight = 16;
            this.filteredPeopleList.Location = new System.Drawing.Point(526, 94);
            this.filteredPeopleList.Name = "filteredPeopleList";
            this.filteredPeopleList.Size = new System.Drawing.Size(220, 212);
            this.filteredPeopleList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "All People";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Test Score";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filtered List";
            // 
            // allPeopleDropdown
            // 
            this.allPeopleDropdown.FormattingEnabled = true;
            this.allPeopleDropdown.Location = new System.Drawing.Point(84, 80);
            this.allPeopleDropdown.Name = "allPeopleDropdown";
            this.allPeopleDropdown.Size = new System.Drawing.Size(121, 24);
            this.allPeopleDropdown.TabIndex = 7;
            this.allPeopleDropdown.SelectedIndexChanged += new System.EventHandler(this.allPeopleDropdown_SelectedIndexChanged);
            // 
            // firstTestScorePicker
            // 
            this.firstTestScorePicker.Location = new System.Drawing.Point(84, 234);
            this.firstTestScorePicker.Name = "firstTestScorePicker";
            this.firstTestScorePicker.Size = new System.Drawing.Size(120, 22);
            this.firstTestScorePicker.TabIndex = 8;
            // 
            // updatePersonButton
            // 
            this.updatePersonButton.Location = new System.Drawing.Point(84, 327);
            this.updatePersonButton.Name = "updatePersonButton";
            this.updatePersonButton.Size = new System.Drawing.Size(157, 23);
            this.updatePersonButton.TabIndex = 9;
            this.updatePersonButton.Text = "Update";
            this.updatePersonButton.UseVisualStyleBackColor = true;
            this.updatePersonButton.Click += new System.EventHandler(this.updatePersonButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updatePersonButton);
            this.Controls.Add(this.firstTestScorePicker);
            this.Controls.Add(this.allPeopleDropdown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filteredPeopleList);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.firstTestScorePicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox filteredPeopleList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox allPeopleDropdown;
        private System.Windows.Forms.NumericUpDown firstTestScorePicker;
        private System.Windows.Forms.Button updatePersonButton;
    }
}

