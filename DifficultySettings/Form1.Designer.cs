
namespace DifficultySettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nameLabel = new System.Windows.Forms.Label();
            this.userInput = new System.Windows.Forms.TextBox();
            this.difficultyMessage = new System.Windows.Forms.Label();
            this.easyButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(106, 33);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(225, 39);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Enter your name hero!";
            // 
            // userInput
            // 
            this.userInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInput.Location = new System.Drawing.Point(348, 33);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(175, 31);
            this.userInput.TabIndex = 1;
            // 
            // difficultyMessage
            // 
            this.difficultyMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyMessage.Location = new System.Drawing.Point(181, 100);
            this.difficultyMessage.Name = "difficultyMessage";
            this.difficultyMessage.Size = new System.Drawing.Size(255, 39);
            this.difficultyMessage.TabIndex = 2;
            this.difficultyMessage.Text = "Selct your difficulty level";
            // 
            // easyButton
            // 
            this.easyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.easyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyButton.Location = new System.Drawing.Point(186, 142);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(75, 44);
            this.easyButton.TabIndex = 3;
            this.easyButton.Text = "Easy";
            this.easyButton.UseVisualStyleBackColor = true;
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click);
            // 
            // hardButton
            // 
            this.hardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.hardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardButton.Location = new System.Drawing.Point(348, 142);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(75, 44);
            this.hardButton.TabIndex = 4;
            this.hardButton.Text = "Hard ";
            this.hardButton.UseVisualStyleBackColor = true;
            this.hardButton.Click += new System.EventHandler(this.hardButton_Click);
            // 
            // mediumButton
            // 
            this.mediumButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.mediumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mediumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumButton.Location = new System.Drawing.Point(267, 142);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(75, 44);
            this.mediumButton.TabIndex = 5;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = true;
            this.mediumButton.Click += new System.EventHandler(this.mediumButton_Click);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(186, 233);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(237, 53);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Begin";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(98, 333);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(455, 46);
            this.outputLabel.TabIndex = 7;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 459);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.easyButton);
            this.Controls.Add(this.difficultyMessage);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.nameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hero Quest ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.Label difficultyMessage;
        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button hardButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

