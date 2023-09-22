using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Section2;

namespace Section2Tests
{
    [TestFixture]
    public class StudentTest
    {
        [Test]
        public void TestStudentName()
        {
            Student student = new Student();
            student.Name = "Praveen";
            string studentName = student.Name;
            Assert.AreEqual("Praveen", studentName);
        }
        [Test]
        public void TestStudentClass()
        {
            Student student = new Student();
            student.Class = 12;
            int studentClass = student.Class;
            Assert.AreEqual(12, studentClass);
        }
        [Test]
        public void TestStudentSection()
        {
            Student student = new Student();
            student.Section = 'A';
            char studentSection = student.Section;
            Assert.AreEqual('A', studentSection);
        }
    }
}
