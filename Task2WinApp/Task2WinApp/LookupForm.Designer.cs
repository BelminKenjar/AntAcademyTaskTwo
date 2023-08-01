namespace Task2WinApp
{
    partial class LookupForm
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
            this.components = new System.ComponentModel.Container();
            this.btnLookup = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtLookupPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblObject = new System.Windows.Forms.Label();
            this.err1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.err1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLookup
            // 
            this.btnLookup.Location = new System.Drawing.Point(387, 12);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(134, 23);
            this.btnLookup.TabIndex = 5;
            this.btnLookup.Text = "Look up";
            this.btnLookup.UseVisualStyleBackColor = true;
            this.btnLookup.Click += new System.EventHandler(this.btnLookup_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(12, 57);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 15);
            this.lblResult.TabIndex = 4;
            // 
            // txtLookupPath
            // 
            this.txtLookupPath.Location = new System.Drawing.Point(12, 12);
            this.txtLookupPath.Name = "txtLookupPath";
            this.txtLookupPath.PlaceholderText = "Enter your desired lookup path here";
            this.txtLookupPath.Size = new System.Drawing.Size(369, 23);
            this.txtLookupPath.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Result:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Object to lookup:";
            // 
            // lblObject
            // 
            this.lblObject.AutoSize = true;
            this.lblObject.Location = new System.Drawing.Point(12, 118);
            this.lblObject.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblObject.Name = "lblObject";
            this.lblObject.Size = new System.Drawing.Size(0, 15);
            this.lblObject.TabIndex = 8;
            // 
            // err1
            // 
            this.err1.ContainerControl = this;
            // 
            // LookupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 201);
            this.Controls.Add(this.lblObject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLookup);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtLookupPath);
            this.Name = "LookupForm";
            this.Text = "LookupForm";
            this.Load += new System.EventHandler(this.LookupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLookup;
        private Label lblResult;
        private TextBox txtLookupPath;
        private Label label1;
        private Label label2;
        private Label lblObject;
        private ErrorProvider err1;
    }
}