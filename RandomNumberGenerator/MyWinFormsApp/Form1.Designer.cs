namespace MyWinFormsApp;

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
    /// 
    private void InitializeComponent()
    {

        // create the Label control
        System.Windows.Forms.Label myLabel = new System.Windows.Forms.Label();
        myLabel.Name = "myLabel";
        myLabel.Location = new System.Drawing.Point(10, 10);
        myLabel.AutoSize = true;

        this.generateButton = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // generateButton
        // 
        this.generateButton.Location = new System.Drawing.Point(99, 66);
        this.generateButton.Name = "generateButton";
        this.generateButton.Size = new System.Drawing.Size(100, 23);
        this.generateButton.TabIndex = 0;
        this.generateButton.Text = "Generate";
        this.generateButton.UseVisualStyleBackColor = true;
        this.generateButton.Click += new System.EventHandler(this.GenerateButton_Click);
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(284, 161);
        this.Controls.Add(this.generateButton);
        this.Name = "Form1";
        this.Text = "Random Number Generator";
        this.ResumeLayout(false);
        //
        // label
        //
        myLabel.Location = new Point(10, 10); // set the position of the label on the form
        this.Controls.Add(myLabel);

    }

    #endregion


    private System.Windows.Forms.Button generateButton;
}
