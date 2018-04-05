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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageGenerics = new System.Windows.Forms.TabPage();
            this.tabPagePartialTypes = new System.Windows.Forms.TabPage();
            this.tabPageAnonymousMethods = new System.Windows.Forms.TabPage();
            this.tabPageIterators = new System.Windows.Forms.TabPage();
            this.tabPageNullableTypes = new System.Windows.Forms.TabPage();
            this.tabPageProperties = new System.Windows.Forms.TabPage();
            this.tabPageDelegates = new System.Windows.Forms.TabPage();
            this.tabPageCovariance = new System.Windows.Forms.TabPage();
            this.tabPageStaticClasses = new System.Windows.Forms.TabPage();
            this.labelGenerics = new System.Windows.Forms.Label();
            this.buttonGenerics = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.RichTextBox();
            this.tabControl.SuspendLayout();
            this.tabPageGenerics.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageGenerics);
            this.tabControl.Controls.Add(this.tabPagePartialTypes);
            this.tabControl.Controls.Add(this.tabPageAnonymousMethods);
            this.tabControl.Controls.Add(this.tabPageIterators);
            this.tabControl.Controls.Add(this.tabPageNullableTypes);
            this.tabControl.Controls.Add(this.tabPageProperties);
            this.tabControl.Controls.Add(this.tabPageDelegates);
            this.tabControl.Controls.Add(this.tabPageCovariance);
            this.tabControl.Controls.Add(this.tabPageStaticClasses);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(624, 150);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageGenerics
            // 
            this.tabPageGenerics.BackColor = System.Drawing.Color.Transparent;
            this.tabPageGenerics.Controls.Add(this.buttonGenerics);
            this.tabPageGenerics.Controls.Add(this.labelGenerics);
            this.tabPageGenerics.Location = new System.Drawing.Point(4, 22);
            this.tabPageGenerics.Name = "tabPageGenerics";
            this.tabPageGenerics.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGenerics.Size = new System.Drawing.Size(616, 124);
            this.tabPageGenerics.TabIndex = 0;
            this.tabPageGenerics.Text = "Generics";
            // 
            // tabPagePartialTypes
            // 
            this.tabPagePartialTypes.BackColor = System.Drawing.Color.Transparent;
            this.tabPagePartialTypes.Location = new System.Drawing.Point(4, 22);
            this.tabPagePartialTypes.Name = "tabPagePartialTypes";
            this.tabPagePartialTypes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePartialTypes.Size = new System.Drawing.Size(616, 124);
            this.tabPagePartialTypes.TabIndex = 1;
            this.tabPagePartialTypes.Text = "Partial types";
            // 
            // tabPageAnonymousMethods
            // 
            this.tabPageAnonymousMethods.BackColor = System.Drawing.Color.Transparent;
            this.tabPageAnonymousMethods.Location = new System.Drawing.Point(4, 22);
            this.tabPageAnonymousMethods.Name = "tabPageAnonymousMethods";
            this.tabPageAnonymousMethods.Size = new System.Drawing.Size(616, 416);
            this.tabPageAnonymousMethods.TabIndex = 2;
            this.tabPageAnonymousMethods.Text = "Anonymous methods";
            // 
            // tabPageIterators
            // 
            this.tabPageIterators.BackColor = System.Drawing.Color.Transparent;
            this.tabPageIterators.Location = new System.Drawing.Point(4, 22);
            this.tabPageIterators.Name = "tabPageIterators";
            this.tabPageIterators.Size = new System.Drawing.Size(616, 416);
            this.tabPageIterators.TabIndex = 3;
            this.tabPageIterators.Text = "Iterators";
            // 
            // tabPageNullableTypes
            // 
            this.tabPageNullableTypes.BackColor = System.Drawing.Color.Transparent;
            this.tabPageNullableTypes.Location = new System.Drawing.Point(4, 22);
            this.tabPageNullableTypes.Name = "tabPageNullableTypes";
            this.tabPageNullableTypes.Size = new System.Drawing.Size(616, 416);
            this.tabPageNullableTypes.TabIndex = 4;
            this.tabPageNullableTypes.Text = "Nullable types";
            // 
            // tabPageProperties
            // 
            this.tabPageProperties.BackColor = System.Drawing.Color.Transparent;
            this.tabPageProperties.Location = new System.Drawing.Point(4, 22);
            this.tabPageProperties.Name = "tabPageProperties";
            this.tabPageProperties.Size = new System.Drawing.Size(616, 416);
            this.tabPageProperties.TabIndex = 5;
            this.tabPageProperties.Text = "Properties";
            // 
            // tabPageDelegates
            // 
            this.tabPageDelegates.BackColor = System.Drawing.Color.Transparent;
            this.tabPageDelegates.Location = new System.Drawing.Point(4, 22);
            this.tabPageDelegates.Name = "tabPageDelegates";
            this.tabPageDelegates.Size = new System.Drawing.Size(616, 416);
            this.tabPageDelegates.TabIndex = 6;
            this.tabPageDelegates.Text = "Delegates";
            // 
            // tabPageCovariance
            // 
            this.tabPageCovariance.BackColor = System.Drawing.Color.Transparent;
            this.tabPageCovariance.Location = new System.Drawing.Point(4, 22);
            this.tabPageCovariance.Name = "tabPageCovariance";
            this.tabPageCovariance.Size = new System.Drawing.Size(616, 416);
            this.tabPageCovariance.TabIndex = 7;
            this.tabPageCovariance.Text = "Covariance";
            // 
            // tabPageStaticClasses
            // 
            this.tabPageStaticClasses.BackColor = System.Drawing.Color.Transparent;
            this.tabPageStaticClasses.Location = new System.Drawing.Point(4, 22);
            this.tabPageStaticClasses.Name = "tabPageStaticClasses";
            this.tabPageStaticClasses.Size = new System.Drawing.Size(616, 416);
            this.tabPageStaticClasses.TabIndex = 8;
            this.tabPageStaticClasses.Text = "StaticClasses";
            // 
            // labelGenerics
            // 
            this.labelGenerics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGenerics.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelGenerics.Location = new System.Drawing.Point(3, 3);
            this.labelGenerics.Name = "labelGenerics";
            this.labelGenerics.Size = new System.Drawing.Size(610, 30);
            this.labelGenerics.TabIndex = 0;
            this.labelGenerics.Text = "Generics";
            this.labelGenerics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonGenerics
            // 
            this.buttonGenerics.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGenerics.Location = new System.Drawing.Point(3, 33);
            this.buttonGenerics.Name = "buttonGenerics";
            this.buttonGenerics.Size = new System.Drawing.Size(610, 23);
            this.buttonGenerics.TabIndex = 1;
            this.buttonGenerics.Text = "Create and use";
            this.buttonGenerics.UseVisualStyleBackColor = true;
            this.buttonGenerics.Click += new System.EventHandler(this.buttonGenerics_Click);
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.SystemColors.Control;
            this.log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.log.Location = new System.Drawing.Point(0, 150);
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.Size = new System.Drawing.Size(624, 292);
            this.log.TabIndex = 3;
            this.log.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.log);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# version 2";
            this.tabControl.ResumeLayout(false);
            this.tabPageGenerics.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageGenerics;
        private System.Windows.Forms.TabPage tabPagePartialTypes;
        private System.Windows.Forms.TabPage tabPageAnonymousMethods;
        private System.Windows.Forms.TabPage tabPageIterators;
        private System.Windows.Forms.TabPage tabPageNullableTypes;
        private System.Windows.Forms.TabPage tabPageProperties;
        private System.Windows.Forms.TabPage tabPageDelegates;
        private System.Windows.Forms.TabPage tabPageCovariance;
        private System.Windows.Forms.TabPage tabPageStaticClasses;
        private System.Windows.Forms.Button buttonGenerics;
        private System.Windows.Forms.Label labelGenerics;
        private System.Windows.Forms.RichTextBox log;
    }
}

