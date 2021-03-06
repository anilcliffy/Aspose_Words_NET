using Helpers;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;
using Description = Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute;

namespace Examples.ProgrammingWithDocuments.WorkingWithFields
{
    [TestClass, TestFixture]
    public class WorkingWithFieldsExamples
    {	
        [TestMethod, Test, Owner("Console")]
        public void ReplaceFieldsWithStaticText()
        {
            TestHelper.SetDataDir("ProgrammingWithDocuments/WorkingWithFields/ReplaceFieldsWithStaticText");

            ReplaceFieldsWithStaticTextExample.Program.Main();
        }

        [TestMethod, Test, Owner("Console")]
        public void InsertNestedFields()
        {
            TestHelper.SetDataDir("ProgrammingWithDocuments/WorkingWithFields/InsertNestedFields");

            InsertNestedFieldsExample.Program.Main();
        }

        [TestMethod, Test, Owner("Console")]
        public void RemoveField()
        {
            TestHelper.SetDataDir("ProgrammingWithDocuments/WorkingWithFields/RemoveField");

            RemoveFieldExample.Program.Main();
        }

    }
}
