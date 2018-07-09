namespace Version7
{
    partial class Form7
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.log = new System.Windows.Forms.RichTextBox();
            this.buttonOutVariables = new System.Windows.Forms.Button();
            this.buttonOutVariablesDiscards = new System.Windows.Forms.Button();
            this.buttonImprovingNumericLiterals = new System.Windows.Forms.Button();
            this.buttonPatternMatchingIs = new System.Windows.Forms.Button();
            this.buttonPatternMatchingSwitch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.SystemColors.Control;
            this.log.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.log.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log.Location = new System.Drawing.Point(0, 102);
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.log.Size = new System.Drawing.Size(684, 460);
            this.log.TabIndex = 5;
            this.log.Text = "";
            // 
            // buttonOutVariables
            // 
            this.buttonOutVariables.Location = new System.Drawing.Point(10, 40);
            this.buttonOutVariables.Name = "buttonOutVariables";
            this.buttonOutVariables.Size = new System.Drawing.Size(200, 23);
            this.buttonOutVariables.TabIndex = 6;
            this.buttonOutVariables.Text = "Out variables";
            this.buttonOutVariables.UseVisualStyleBackColor = true;
            this.buttonOutVariables.Click += new System.EventHandler(this.buttonOutVariables_Click);
            // 
            // buttonOutVariablesDiscards
            // 
            this.buttonOutVariablesDiscards.Location = new System.Drawing.Point(10, 70);
            this.buttonOutVariablesDiscards.Name = "buttonOutVariablesDiscards";
            this.buttonOutVariablesDiscards.Size = new System.Drawing.Size(200, 23);
            this.buttonOutVariablesDiscards.TabIndex = 7;
            this.buttonOutVariablesDiscards.Text = "Out variables - discards";
            this.buttonOutVariablesDiscards.UseVisualStyleBackColor = true;
            this.buttonOutVariablesDiscards.Click += new System.EventHandler(this.buttonOutVariablesDiscards_Click);
            // 
            // buttonImprovingNumericLiterals
            // 
            this.buttonImprovingNumericLiterals.Location = new System.Drawing.Point(10, 10);
            this.buttonImprovingNumericLiterals.Name = "buttonImprovingNumericLiterals";
            this.buttonImprovingNumericLiterals.Size = new System.Drawing.Size(200, 23);
            this.buttonImprovingNumericLiterals.TabIndex = 8;
            this.buttonImprovingNumericLiterals.Text = "Improving numeric literals";
            this.buttonImprovingNumericLiterals.UseVisualStyleBackColor = true;
            this.buttonImprovingNumericLiterals.Click += new System.EventHandler(this.buttonImprovingNumericLiterals_Click);
            // 
            // buttonPatternMatchingIs
            // 
            this.buttonPatternMatchingIs.Location = new System.Drawing.Point(240, 10);
            this.buttonPatternMatchingIs.Name = "buttonPatternMatchingIs";
            this.buttonPatternMatchingIs.Size = new System.Drawing.Size(200, 23);
            this.buttonPatternMatchingIs.TabIndex = 9;
            this.buttonPatternMatchingIs.Text = "Pattern matching is";
            this.buttonPatternMatchingIs.UseVisualStyleBackColor = true;
            this.buttonPatternMatchingIs.Click += new System.EventHandler(this.buttonPatternMatchingIs_Click);
            // 
            // buttonPatternMatchingSwitch
            // 
            this.buttonPatternMatchingSwitch.Location = new System.Drawing.Point(240, 40);
            this.buttonPatternMatchingSwitch.Name = "buttonPatternMatchingSwitch";
            this.buttonPatternMatchingSwitch.Size = new System.Drawing.Size(200, 23);
            this.buttonPatternMatchingSwitch.TabIndex = 10;
            this.buttonPatternMatchingSwitch.Text = "Pattern matching switch";
            this.buttonPatternMatchingSwitch.UseVisualStyleBackColor = true;
            this.buttonPatternMatchingSwitch.Click += new System.EventHandler(this.buttonPatternMatchingSwitch_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 562);
            this.Controls.Add(this.buttonPatternMatchingSwitch);
            this.Controls.Add(this.buttonPatternMatchingIs);
            this.Controls.Add(this.buttonImprovingNumericLiterals);
            this.Controls.Add(this.buttonOutVariablesDiscards);
            this.Controls.Add(this.buttonOutVariables);
            this.Controls.Add(this.log);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# version 7";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.Button buttonOutVariables;
        private System.Windows.Forms.Button buttonOutVariablesDiscards;
        private System.Windows.Forms.Button buttonImprovingNumericLiterals;
        private System.Windows.Forms.Button buttonPatternMatchingIs;
        private System.Windows.Forms.Button buttonPatternMatchingSwitch;
    }
}

