namespace Version2
{
    partial class Form2
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
            this.buttonGenerics = new System.Windows.Forms.Button();
            this.buttonPartialTypes = new System.Windows.Forms.Button();
            this.buttonAnonymousMethods = new System.Windows.Forms.Button();
            this.buttonIterators = new System.Windows.Forms.Button();
            this.buttonNullableTypes = new System.Windows.Forms.Button();
            this.buttonProperties = new System.Windows.Forms.Button();
            this.buttonDelegates = new System.Windows.Forms.Button();
            this.buttonCovariance = new System.Windows.Forms.Button();
            this.buttonStaticClasses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.SystemColors.Control;
            this.log.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.log.Location = new System.Drawing.Point(0, 190);
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.log.Size = new System.Drawing.Size(684, 372);
            this.log.TabIndex = 3;
            this.log.Text = "";
            this.log.TextChanged += new System.EventHandler(this.log_TextChanged);
            // 
            // buttonGenerics
            // 
            this.buttonGenerics.Location = new System.Drawing.Point(10, 10);
            this.buttonGenerics.Name = "buttonGenerics";
            this.buttonGenerics.Size = new System.Drawing.Size(200, 23);
            this.buttonGenerics.TabIndex = 4;
            this.buttonGenerics.Text = "Generics";
            this.buttonGenerics.UseVisualStyleBackColor = true;
            this.buttonGenerics.Click += new System.EventHandler(this.ButtonGenerics_Click);
            // 
            // buttonPartialTypes
            // 
            this.buttonPartialTypes.Location = new System.Drawing.Point(10, 40);
            this.buttonPartialTypes.Name = "buttonPartialTypes";
            this.buttonPartialTypes.Size = new System.Drawing.Size(200, 23);
            this.buttonPartialTypes.TabIndex = 5;
            this.buttonPartialTypes.Text = "Partial types";
            this.buttonPartialTypes.UseVisualStyleBackColor = true;
            this.buttonPartialTypes.Click += new System.EventHandler(this.ButtonPartialTypes_Click);
            // 
            // buttonAnonymousMethods
            // 
            this.buttonAnonymousMethods.Enabled = false;
            this.buttonAnonymousMethods.Location = new System.Drawing.Point(10, 70);
            this.buttonAnonymousMethods.Name = "buttonAnonymousMethods";
            this.buttonAnonymousMethods.Size = new System.Drawing.Size(200, 23);
            this.buttonAnonymousMethods.TabIndex = 6;
            this.buttonAnonymousMethods.Text = "Anonymous methods";
            this.buttonAnonymousMethods.UseVisualStyleBackColor = true;
            // 
            // buttonIterators
            // 
            this.buttonIterators.Enabled = false;
            this.buttonIterators.Location = new System.Drawing.Point(240, 10);
            this.buttonIterators.Name = "buttonIterators";
            this.buttonIterators.Size = new System.Drawing.Size(200, 23);
            this.buttonIterators.TabIndex = 7;
            this.buttonIterators.Text = "Iterators";
            this.buttonIterators.UseVisualStyleBackColor = true;
            // 
            // buttonNullableTypes
            // 
            this.buttonNullableTypes.Enabled = false;
            this.buttonNullableTypes.Location = new System.Drawing.Point(240, 40);
            this.buttonNullableTypes.Name = "buttonNullableTypes";
            this.buttonNullableTypes.Size = new System.Drawing.Size(200, 23);
            this.buttonNullableTypes.TabIndex = 8;
            this.buttonNullableTypes.Text = "Nullable types";
            this.buttonNullableTypes.UseVisualStyleBackColor = true;
            // 
            // buttonProperties
            // 
            this.buttonProperties.Enabled = false;
            this.buttonProperties.Location = new System.Drawing.Point(240, 70);
            this.buttonProperties.Name = "buttonProperties";
            this.buttonProperties.Size = new System.Drawing.Size(200, 23);
            this.buttonProperties.TabIndex = 9;
            this.buttonProperties.Text = "Properties";
            this.buttonProperties.UseVisualStyleBackColor = true;
            // 
            // buttonDelegates
            // 
            this.buttonDelegates.Enabled = false;
            this.buttonDelegates.Location = new System.Drawing.Point(470, 10);
            this.buttonDelegates.Name = "buttonDelegates";
            this.buttonDelegates.Size = new System.Drawing.Size(200, 23);
            this.buttonDelegates.TabIndex = 10;
            this.buttonDelegates.Text = "Delegates";
            this.buttonDelegates.UseVisualStyleBackColor = true;
            // 
            // buttonCovariance
            // 
            this.buttonCovariance.Enabled = false;
            this.buttonCovariance.Location = new System.Drawing.Point(470, 40);
            this.buttonCovariance.Name = "buttonCovariance";
            this.buttonCovariance.Size = new System.Drawing.Size(200, 23);
            this.buttonCovariance.TabIndex = 11;
            this.buttonCovariance.Text = "Covariance";
            this.buttonCovariance.UseVisualStyleBackColor = true;
            // 
            // buttonStaticClasses
            // 
            this.buttonStaticClasses.Enabled = false;
            this.buttonStaticClasses.Location = new System.Drawing.Point(470, 70);
            this.buttonStaticClasses.Name = "buttonStaticClasses";
            this.buttonStaticClasses.Size = new System.Drawing.Size(200, 23);
            this.buttonStaticClasses.TabIndex = 12;
            this.buttonStaticClasses.Text = "StaticClasses";
            this.buttonStaticClasses.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 562);
            this.Controls.Add(this.buttonStaticClasses);
            this.Controls.Add(this.buttonCovariance);
            this.Controls.Add(this.buttonDelegates);
            this.Controls.Add(this.buttonProperties);
            this.Controls.Add(this.buttonNullableTypes);
            this.Controls.Add(this.buttonIterators);
            this.Controls.Add(this.buttonAnonymousMethods);
            this.Controls.Add(this.buttonPartialTypes);
            this.Controls.Add(this.buttonGenerics);
            this.Controls.Add(this.log);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# version 2";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.Button buttonGenerics;
        private System.Windows.Forms.Button buttonPartialTypes;
        private System.Windows.Forms.Button buttonAnonymousMethods;
        private System.Windows.Forms.Button buttonIterators;
        private System.Windows.Forms.Button buttonNullableTypes;
        private System.Windows.Forms.Button buttonProperties;
        private System.Windows.Forms.Button buttonDelegates;
        private System.Windows.Forms.Button buttonCovariance;
        private System.Windows.Forms.Button buttonStaticClasses;
    }
}

