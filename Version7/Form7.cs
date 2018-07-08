using System;
using System.Windows.Forms;
// ReSharper disable SuggestVarOrType_BuiltInTypes
// ReSharper disable UnusedVariable
#pragma warning disable 219

namespace Version7
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void ButtonImprovingNumericLiterals_Click(object sender, EventArgs e)
        {
            log.Clear();

            int someValue = 1_234_567;
            log.AppendText(@"int someValue = 1_234_567;" + Environment.NewLine);
        }

        private void ButtonOutVariables_Click(object sender, EventArgs e)
        {
            log.Clear();

            if (int.TryParse("123", out int result))
            {
                var newValue = result;
            }

            log.AppendText(@"if (int.TryParse(""123"", out int result))" + Environment.NewLine);
            log.AppendText(@"{" + Environment.NewLine);
            log.AppendText(@"   var newValue = result;" + Environment.NewLine);
            log.AppendText(@"}" + Environment.NewLine);
        }

        private static void SomeMethod(out int i1, out int i2)
        {
            i1 = 1;
            i2 = 1;
        }

        private void ButtonOutVariablesDiscards_Click(object sender, EventArgs e)
        {
            log.Clear();

            SomeMethod(out int i1, out _);
            var getValue = i1;

            log.AppendText(@"private static void SomeMethod(out int i1, out int i2)" + Environment.NewLine);
            log.AppendText(@"{" + Environment.NewLine);
            log.AppendText(@"   i1 = 1;" + Environment.NewLine);
            log.AppendText(@"   i2 = 1;" + Environment.NewLine);
            log.AppendText(@"}" + Environment.NewLine);
            log.AppendText(@"" + Environment.NewLine);
            log.AppendText(@"SomeMethod(out int i1, out _);" + Environment.NewLine);
            log.AppendText(@"var getValue = i1;" + Environment.NewLine);
        }
    }
}
