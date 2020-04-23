namespace SortingAndBinarySearch_Project
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
            this.button_Selection = new System.Windows.Forms.Button();
            this.button_Insertion = new System.Windows.Forms.Button();
            this.button_Merge = new System.Windows.Forms.Button();
            this.label_DisplayOriginal = new System.Windows.Forms.Label();
            this.label_DisplaySorted = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Selection
            // 
            this.button_Selection.Location = new System.Drawing.Point(71, 126);
            this.button_Selection.Name = "button_Selection";
            this.button_Selection.Size = new System.Drawing.Size(134, 48);
            this.button_Selection.TabIndex = 1;
            this.button_Selection.Text = "Selection Sort";
            this.button_Selection.UseVisualStyleBackColor = true;
            this.button_Selection.Click += new System.EventHandler(this.Button_Selection_Click);
            // 
            // button_Insertion
            // 
            this.button_Insertion.Location = new System.Drawing.Point(71, 200);
            this.button_Insertion.Name = "button_Insertion";
            this.button_Insertion.Size = new System.Drawing.Size(134, 51);
            this.button_Insertion.TabIndex = 2;
            this.button_Insertion.Text = "Insertion Sort";
            this.button_Insertion.UseVisualStyleBackColor = true;
            this.button_Insertion.Click += new System.EventHandler(this.Button_Insertion_Click);
            // 
            // button_Merge
            // 
            this.button_Merge.Location = new System.Drawing.Point(71, 281);
            this.button_Merge.Name = "button_Merge";
            this.button_Merge.Size = new System.Drawing.Size(134, 49);
            this.button_Merge.TabIndex = 3;
            this.button_Merge.Text = "Merge Sort";
            this.button_Merge.UseVisualStyleBackColor = true;
            // 
            // label_DisplayOriginal
            // 
            this.label_DisplayOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_DisplayOriginal.Location = new System.Drawing.Point(374, 126);
            this.label_DisplayOriginal.Name = "label_DisplayOriginal";
            this.label_DisplayOriginal.Size = new System.Drawing.Size(265, 94);
            this.label_DisplayOriginal.TabIndex = 4;
            // 
            // label_DisplaySorted
            // 
            this.label_DisplaySorted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_DisplaySorted.Location = new System.Drawing.Point(374, 236);
            this.label_DisplaySorted.Name = "label_DisplaySorted";
            this.label_DisplaySorted.Size = new System.Drawing.Size(265, 94);
            this.label_DisplaySorted.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 376);
            this.Controls.Add(this.label_DisplaySorted);
            this.Controls.Add(this.label_DisplayOriginal);
            this.Controls.Add(this.button_Merge);
            this.Controls.Add(this.button_Insertion);
            this.Controls.Add(this.button_Selection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Selection;
        private System.Windows.Forms.Button button_Insertion;
        private System.Windows.Forms.Button button_Merge;
        private System.Windows.Forms.Label label_DisplayOriginal;
        private System.Windows.Forms.Label label_DisplaySorted;
    }
}

