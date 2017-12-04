namespace Cwiczenia9
{
    partial class DelegateTest
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
            this.checkBoxDialog = new System.Windows.Forms.CheckBox();
            this.checkBoxSave = new System.Windows.Forms.CheckBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.radioButtonOneArg = new System.Windows.Forms.RadioButton();
            this.radioButtonTwoArgs = new System.Windows.Forms.RadioButton();
            this.textBoxRight = new System.Windows.Forms.TextBox();
            this.textBoxLeft = new System.Windows.Forms.TextBox();
            this.comboBoxOperation = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // checkBoxDialog
            // 
            this.checkBoxDialog.AutoSize = true;
            this.checkBoxDialog.Location = new System.Drawing.Point(50, 162);
            this.checkBoxDialog.Name = "checkBoxDialog";
            this.checkBoxDialog.Size = new System.Drawing.Size(86, 17);
            this.checkBoxDialog.TabIndex = 0;
            this.checkBoxDialog.Text = "Show Dialog";
            this.checkBoxDialog.UseVisualStyleBackColor = true;
            this.checkBoxDialog.CheckedChanged += new System.EventHandler(this.checkBoxDialog_CheckedChanged);
            // 
            // checkBoxSave
            // 
            this.checkBoxSave.AutoSize = true;
            this.checkBoxSave.Location = new System.Drawing.Point(50, 185);
            this.checkBoxSave.Name = "checkBoxSave";
            this.checkBoxSave.Size = new System.Drawing.Size(86, 17);
            this.checkBoxSave.TabIndex = 1;
            this.checkBoxSave.Text = "Save To File";
            this.checkBoxSave.UseVisualStyleBackColor = true;
            this.checkBoxSave.CheckedChanged += new System.EventHandler(this.checkBoxSave_CheckedChanged);
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(160, 154);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(48, 48);
            this.buttonGo.TabIndex = 2;
            this.buttonGo.Text = "Go!";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // radioButtonOneArg
            // 
            this.radioButtonOneArg.AutoSize = true;
            this.radioButtonOneArg.Checked = true;
            this.radioButtonOneArg.Location = new System.Drawing.Point(24, 47);
            this.radioButtonOneArg.Name = "radioButtonOneArg";
            this.radioButtonOneArg.Size = new System.Drawing.Size(93, 17);
            this.radioButtonOneArg.TabIndex = 3;
            this.radioButtonOneArg.TabStop = true;
            this.radioButtonOneArg.Text = "One Argument";
            this.radioButtonOneArg.UseVisualStyleBackColor = true;
            this.radioButtonOneArg.CheckedChanged += new System.EventHandler(this.radioButtonOneArg_CheckedChanged);
            // 
            // radioButtonTwoArgs
            // 
            this.radioButtonTwoArgs.AutoSize = true;
            this.radioButtonTwoArgs.Location = new System.Drawing.Point(160, 47);
            this.radioButtonTwoArgs.Name = "radioButtonTwoArgs";
            this.radioButtonTwoArgs.Size = new System.Drawing.Size(98, 17);
            this.radioButtonTwoArgs.TabIndex = 4;
            this.radioButtonTwoArgs.Text = "Two arguments";
            this.radioButtonTwoArgs.UseVisualStyleBackColor = true;
            this.radioButtonTwoArgs.CheckedChanged += new System.EventHandler(this.radioButtonTwoArgs_CheckedChanged);
            // 
            // textBoxRight
            // 
            this.textBoxRight.Location = new System.Drawing.Point(172, 88);
            this.textBoxRight.Name = "textBoxRight";
            this.textBoxRight.Size = new System.Drawing.Size(68, 20);
            this.textBoxRight.TabIndex = 5;
            // 
            // textBoxLeft
            // 
            this.textBoxLeft.Location = new System.Drawing.Point(24, 88);
            this.textBoxLeft.Name = "textBoxLeft";
            this.textBoxLeft.Size = new System.Drawing.Size(65, 20);
            this.textBoxLeft.TabIndex = 6;
            // 
            // comboBoxOperation
            // 
            this.comboBoxOperation.FormattingEnabled = true;
            this.comboBoxOperation.Location = new System.Drawing.Point(95, 88);
            this.comboBoxOperation.Name = "comboBoxOperation";
            this.comboBoxOperation.Size = new System.Drawing.Size(71, 21);
            this.comboBoxOperation.TabIndex = 7;
            this.comboBoxOperation.SelectedIndexChanged += new System.EventHandler(this.comboBoxOperation_SelectedIndexChanged);
            // 
            // DelegateTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.comboBoxOperation);
            this.Controls.Add(this.textBoxLeft);
            this.Controls.Add(this.textBoxRight);
            this.Controls.Add(this.radioButtonTwoArgs);
            this.Controls.Add(this.radioButtonOneArg);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.checkBoxSave);
            this.Controls.Add(this.checkBoxDialog);
            this.Name = "DelegateTest";
            this.Text = "DelegateTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxDialog;
        private System.Windows.Forms.CheckBox checkBoxSave;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.RadioButton radioButtonOneArg;
        private System.Windows.Forms.RadioButton radioButtonTwoArgs;
        private System.Windows.Forms.TextBox textBoxRight;
        private System.Windows.Forms.TextBox textBoxLeft;
        private System.Windows.Forms.ComboBox comboBoxOperation;
    }
}

