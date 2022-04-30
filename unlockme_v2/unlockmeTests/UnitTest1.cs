using NUnit.Framework;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;
using unlockme;

namespace unlockmeTests
{

    public class Tests
    {
        
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckStrengthTest()
        {
            var model = new Model();

            List<unlockme.Field> pass = new List<unlockme.Field>();
            pass.Add(new unlockme.Field { X = 0, Y = 0 });
            pass.Add(new unlockme.Field { X = 1, Y = 0 });

            string result = model.CheckStrength(pass, 3);
            Assert.AreEqual("S³abe has³o", result);
        }

        [Test]
        public void ComparePatternsTest()
        {
            var model = new Model();
            StreamReader r = new StreamReader("Current Pattern.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(CurrentLockPattern));
            CurrentLockPattern pattern = (CurrentLockPattern)serializer.Deserialize(r);
            r.Close();
            Assert.AreEqual(true, model.ComparePatterns(pattern.Pattern));
        }

        [Test]
        public void ChangePasswordCompareTest()
        {
            var model = new Model();
            List<unlockme.Field> pass = new List<unlockme.Field>();
            pass.Add(new unlockme.Field { X = 0, Y = 0 });
            pass.Add(new unlockme.Field { X = 1, Y = 0 });

            Assert.AreEqual(true, model.ChangePasswordCompare(pass, pass));

            List<unlockme.Field> pass2 = new List<unlockme.Field>();
            pass2.Add(new unlockme.Field { X = 0, Y = 0 });
            pass2.Add(new unlockme.Field { X = 1, Y = 0 });
            pass2.Add(new unlockme.Field { X = 1, Y = 2 });
            Assert.AreEqual(false, model.ChangePasswordCompare(pass, pass2));
        }

        [Test]
        public void IsContinuousTest()
        {
            var model = new Model();
            List<unlockme.Field> pass = new List<unlockme.Field>();
            pass.Add(new unlockme.Field { X = 0, Y = 0 });
            pass.Add(new unlockme.Field { X = 1, Y = 0 });

            Assert.AreEqual(true, model.IsContinuous(pass));
        }

        [Test]
        public void StartsInCornerTest()
        {
            var model = new Model();
            List<unlockme.Field> pass = new List<unlockme.Field>();
            pass.Add(new unlockme.Field { X = 0, Y = 0 });
            pass.Add(new unlockme.Field { X = 1, Y = 0 });

            Assert.AreEqual(true, model.StartsInCorner(pass, 3));
        }

        [Test]
        public void CheckForUTest()
        {
            var model = new Model();
            List<unlockme.Field> pass = new List<unlockme.Field>();
            pass.Add(new unlockme.Field { X = 0, Y = 0 });
            pass.Add(new unlockme.Field { X = 1, Y = 0 });

            Assert.AreEqual(false, model.CheckForUx4(pass));
        }

        [Test]
        public void CheckForSTest()
        {
            var model = new Model();
            List<unlockme.Field> pass = new List<unlockme.Field>();
            pass.Add(new unlockme.Field { X = 0, Y = 0 });
            pass.Add(new unlockme.Field { X = 1, Y = 0 });

            Assert.AreEqual(false, model.CheckForS(pass));
        }

        [Test]
        public void CheckForNTest()
        {
            var model = new Model();
            List<unlockme.Field> pass = new List<unlockme.Field>();
            pass.Add(new unlockme.Field { X = 0, Y = 0 });
            pass.Add(new unlockme.Field { X = 1, Y = 0 });

            Assert.AreEqual(false, model.CheckForN(pass));
        }

        [Test]
        public void CheckForMTest()
        {
            var model = new Model();
            List<unlockme.Field> pass = new List<unlockme.Field>();
            pass.Add(new unlockme.Field { X = 0, Y = 0 });
            pass.Add(new unlockme.Field { X = 1, Y = 0 });

            Assert.AreEqual(false, model.CheckForM(pass));
        }

        [Test]
        public void CheckForCTest()
        {
            var model = new Model();
            List<unlockme.Field> pass = new List<unlockme.Field>();
            pass.Add(new unlockme.Field { X = 0, Y = 0 });
            pass.Add(new unlockme.Field { X = 1, Y = 0 });

            Assert.AreEqual(false, model.CheckForC(pass));
        }

        [Test]
        public void CheckForCx4Test()
        {
            var model = new Model();
            List<unlockme.Field> pass = new List<unlockme.Field>();
            pass.Add(new unlockme.Field { X = 0, Y = 0 });
            pass.Add(new unlockme.Field { X = 1, Y = 0 });

            Assert.AreEqual(false, model.CheckForCx4(pass));
        }

        [Test]
        public void CheckForLTest()
        {
            var model = new Model();
            List<unlockme.Field> pass = new List<unlockme.Field>();
            pass.Add(new unlockme.Field { X = 0, Y = 0 });
            pass.Add(new unlockme.Field { X = 1, Y = 0 });

            Assert.AreEqual(false, model.CheckForL(pass));
        }

        [Test]
        public void CheckForLx4Test()
        {
            var model = new Model();
            List<unlockme.Field> pass = new List<unlockme.Field>();
            pass.Add(new unlockme.Field { X = 0, Y = 0 });
            pass.Add(new unlockme.Field { X = 1, Y = 0 });

            Assert.AreEqual(false, model.CheckForLx4(pass));
        }

    }
}