using System;
using System.Windows.Forms;

// ReSharper disable SuggestVarOrType_BuiltInTypes
// ReSharper disable UnusedVariable
// ReSharper disable ConditionIsAlwaysTrueOrFalse
#pragma warning disable 219

namespace Version7
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void buttonImprovingNumericLiterals_Click(object sender, EventArgs e)
        {
            log.Clear();

            int someValue = 1_234_567;
            log.AppendText(@"int someValue = 1_234_567;" + Environment.NewLine);
        }

        private void buttonOutVariables_Click(object sender, EventArgs e)
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

        private static void someMethod(out int i1, out int i2)
        {
            i1 = 1;
            i2 = 1;
        }

        private void buttonOutVariablesDiscards_Click(object sender, EventArgs e)
        {
            log.Clear();

            someMethod(out int i1, out _);
            var getValue = i1;

            log.AppendText(@"private static void someMethod(out int i1, out int i2)" + Environment.NewLine);
            log.AppendText(@"{" + Environment.NewLine);
            log.AppendText(@"   i1 = 1;" + Environment.NewLine);
            log.AppendText(@"   i2 = 1;" + Environment.NewLine);
            log.AppendText(@"}" + Environment.NewLine);
            log.AppendText(Environment.NewLine);
            log.AppendText(@"SomeMethod(out int i1, out _);" + Environment.NewLine);
            log.AppendText(@"var getValue = i1;" + Environment.NewLine);
        }

        private void buttonPatternMatchingIs_Click(object sender, EventArgs e)
        {
            log.Clear();

            object obj = "some string";
            if (obj is string str)
            {
                var newStr = str;
            }

            log.AppendText(@"object obj = ""some string"";" + Environment.NewLine);
            log.AppendText(@"if (obj is string str)" + Environment.NewLine);
            log.AppendText(@"{" + Environment.NewLine);
            log.AppendText(@"   var newStr = str;" + Environment.NewLine);
            log.AppendText(@"}" + Environment.NewLine);
        }

        private void buttonPatternMatchingSwitch_Click(object sender, EventArgs e)
        {
            log.Clear();

            switch (sender)
            {
                case int i:
                    Console.WriteLine(@"It is integer number");
                    break;
                case string s:
                    Console.WriteLine(@"It is string");
                    break;
                case bool b when b == true:
                    Console.WriteLine(@"It is boolean and value is true");
                    break;
                case null:
                    Console.WriteLine(@"It is null");
                    break;
            }

            log.AppendText(@"switch (sender)" + Environment.NewLine);
            log.AppendText(@"{" + Environment.NewLine);
            log.AppendText(@"   case int i:" + Environment.NewLine);
            log.AppendText(@"       Console.WriteLine(@""It is integer number"");" + Environment.NewLine);
            log.AppendText(@"       break;" + Environment.NewLine);
            log.AppendText(@"   case string s:" + Environment.NewLine);
            log.AppendText(@"       Console.WriteLine(@""It is string"");" + Environment.NewLine);
            log.AppendText(@"       break;" + Environment.NewLine);
            log.AppendText(@"   case bool b when b == true:" + Environment.NewLine);
            log.AppendText(@"       Console.WriteLine(@""It is boolean and value is true"");" + Environment.NewLine);
            log.AppendText(@"       break;" + Environment.NewLine);
            log.AppendText(@"   case null:" + Environment.NewLine);
            log.AppendText(@"       Console.WriteLine(@""It is null"");" + Environment.NewLine);
            log.AppendText(@"       break;" + Environment.NewLine);
            log.AppendText(@"}" + Environment.NewLine);
        }
    }
}
