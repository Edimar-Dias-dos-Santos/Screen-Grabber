namespace ScreenGrabberV2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.grabBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.grabWindowBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.grabBtn);
            this.panel1.Controls.Add(this.clearBtn);
            this.panel1.Controls.Add(this.grabWindowBtn);
            this.panel1.Location = new System.Drawing.Point(567, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 250);
            this.panel1.TabIndex = 0;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.saveBtn.Location = new System.Drawing.Point(58, 164);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(106, 27);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // grabBtn
            // 
            this.grabBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grabBtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.grabBtn.Location = new System.Drawing.Point(58, 34);
            this.grabBtn.Name = "grabBtn";
            this.grabBtn.Size = new System.Drawing.Size(106, 27);
            this.grabBtn.TabIndex = 2;
            this.grabBtn.Text = "Grab Screen";
            this.grabBtn.UseVisualStyleBackColor = false;
            this.grabBtn.Click += new System.EventHandler(this.GrabBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Crimson;
            this.clearBtn.Location = new System.Drawing.Point(58, 122);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(106, 27);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // grabWindowBtn
            // 
            this.grabWindowBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.grabWindowBtn.Location = new System.Drawing.Point(58, 78);
            this.grabWindowBtn.Name = "grabWindowBtn";
            this.grabWindowBtn.Size = new System.Drawing.Size(106, 27);
            this.grabWindowBtn.TabIndex = 3;
            this.grabWindowBtn.Text = "Grab Window";
            this.grabWindowBtn.UseVisualStyleBackColor = false;
            this.grabWindowBtn.Click += new System.EventHandler(this.GrabWindowBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Screen Grabber Version 2";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button grabWindowBtn;
        private System.Windows.Forms.Button grabBtn;
    }
}

