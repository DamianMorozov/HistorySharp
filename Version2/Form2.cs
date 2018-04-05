using System;
using System.Windows.Forms;

namespace Version2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        #region Generics

        // declare generic class
        private class GenericList<T>
        {
            public void Add(T input) { }
        }

        private class SomeClass { }

        private void buttonGenerics_Click(object sender, EventArgs e)
        {
            log.Clear();

            log.AppendText(@"private class GenericList<T>
{
    public void Add(T input) { }
}" + Environment.NewLine);
            log.AppendText("private class SomeClass { }" + Environment.NewLine + Environment.NewLine);

            var listInt = new GenericList<int>();
            listInt.Add(10);
            log.AppendText("var listInt = new GenericList<int>();" + Environment.NewLine);
            log.AppendText("listInt.Add(10);" + Environment.NewLine + Environment.NewLine);

            var listStr = new GenericList<string>();
            listStr.Add("some string");
            log.AppendText("var listStr = new GenericList<string>();" + Environment.NewLine);
            log.AppendText("listStr.Add(\"some string\");" + Environment.NewLine + Environment.NewLine);

            var listSomeClass = new GenericList<SomeClass>();
            listSomeClass.Add(new SomeClass());
            log.AppendText("var listSomeClass = new GenericList<SomeClass>();" + Environment.NewLine);
            log.AppendText("listSomeClass.Add(new SomeClass());" + Environment.NewLine + Environment.NewLine);
        }

        #endregion

    }
}
