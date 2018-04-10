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

        // Generics
        private void buttonGenerics_Click(object sender, EventArgs e)
        {
            log.Clear();

            log.AppendText(@"private class GenericList<T>
{
    public void Add(T input) { }
}" + Environment.NewLine);
            log.AppendText("private class SomeClass { }" + Environment.NewLine + Environment.NewLine);

            log.AppendText("var listInt = new GenericList<int>();" + Environment.NewLine);
            log.AppendText("listInt.Add(10);" + Environment.NewLine + Environment.NewLine);

            log.AppendText("var listStr = new GenericList<string>();" + Environment.NewLine);
            log.AppendText("listStr.Add(\"some string\");" + Environment.NewLine + Environment.NewLine);

            log.AppendText("var listSomeClass = new GenericList<SomeClass>();" + Environment.NewLine);
            log.AppendText("listSomeClass.Add(new SomeClass());" + Environment.NewLine + Environment.NewLine);
        }

        public partial class Employee
        {
            public void DoWork()
            {
            }
        }

        public partial class Employee
        {
            public void GoToLunch()
            {
            }
        }
        
        // Partial Classes and Methods
        private void buttonPartialTypes_Click(object sender, EventArgs e)
        {
            log.Clear();

            log.AppendText(
@"public partial class Employee
{
    public void DoWork()
    {
    }
}

public partial class Employee
{
    public void GoToLunch()
    {
    }
}

----------------------------------------------------------------------

[SerializableAttribute]
partial class Moon { }

[ObsoleteAttribute]
partial class Moon { }

They are equivalent to the following declarations:
--------------------------------------------------
[SerializableAttribute]
[ObsoleteAttribute]
class Moon { }

----------------------------------------------------------------------

partial class Earth : Planet, IRotate { }
partial class Earth : IRevolve { }

They are equivalent to the following declarations:
--------------------------------------------------
class Earth : Planet, IRotate, IRevolve { }

----------------------------------------------------------------------
partial class ClassWithNestedClass
{
    partial class NestedClass { }
}

partial class ClassWithNestedClass
{
    partial class NestedClass { }
}
");

        }
    }


    #endregion
}
