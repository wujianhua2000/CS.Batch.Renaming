namespace FileNaming
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.button2 = new System.Windows.Forms.Button( );
            this.statusStrip1 = new System.Windows.Forms.StatusStrip( );
            this.DialogPath = new System.Windows.Forms.FolderBrowserDialog( );
            this.ButtonRuleMaking = new System.Windows.Forms.Button( );
            this.ButtonRuleNaming = new System.Windows.Forms.Button( );
            this.DialogFile = new System.Windows.Forms.OpenFileDialog( );
            this.SuspendLayout( );
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point( 251, 206 );
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size( 75, 23 );
            this.button2.TabIndex = 1;
            this.button2.Text = "close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler( this.ButtonExit_Click );
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point( 0, 244 );
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size( 341, 22 );
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ButtonRuleMaking
            // 
            this.ButtonRuleMaking.Location = new System.Drawing.Point( 12, 70 );
            this.ButtonRuleMaking.Name = "ButtonRuleMaking";
            this.ButtonRuleMaking.Size = new System.Drawing.Size( 314, 23 );
            this.ButtonRuleMaking.TabIndex = 4;
            this.ButtonRuleMaking.Text = "make old name and new name";
            this.ButtonRuleMaking.UseVisualStyleBackColor = true;
            this.ButtonRuleMaking.Click += new System.EventHandler( this.ButtonRuleMaking_Click );
            // 
            // ButtonRuleNaming
            // 
            this.ButtonRuleNaming.Location = new System.Drawing.Point( 12, 144 );
            this.ButtonRuleNaming.Name = "ButtonRuleNaming";
            this.ButtonRuleNaming.Size = new System.Drawing.Size( 314, 23 );
            this.ButtonRuleNaming.TabIndex = 5;
            this.ButtonRuleNaming.Text = "change file name using rule file";
            this.ButtonRuleNaming.UseVisualStyleBackColor = true;
            this.ButtonRuleNaming.Click += new System.EventHandler( this.ButtonRuleNaming_Click );
            // 
            // DialogFile
            // 
            this.DialogFile.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 12F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 341, 266 );
            this.Controls.Add( this.ButtonRuleNaming );
            this.Controls.Add( this.ButtonRuleMaking );
            this.Controls.Add( this.statusStrip1 );
            this.Controls.Add( this.button2 );
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batch rename files";
            this.Load += new System.EventHandler( this.FormMain_Load );
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.FolderBrowserDialog DialogPath;
        private System.Windows.Forms.Button ButtonRuleMaking;
        private System.Windows.Forms.Button ButtonRuleNaming;
        private System.Windows.Forms.OpenFileDialog DialogFile;
    }
}

