using Cor_with_UT;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Cor_with_UT;

namespace UnitTestProject1
{

    [TestClass]
    public class UnitTest1
    {/*
      * 
            Handler_ Filter = new Is_this_question_normal();
            Handler_ AtoM = new FromAtoM();
            Handler_ NtoZ = new FromNtoZ();
      */
        [TestMethod]
        public void Test_NtoZ()
        {
            Handler_ Filter = new Is_this_question_normal();
            Handler_ NtoZ = new FromNtoZ();

            Filter.setNext(NtoZ);
            Assert.AreEqual(NtoZ.request("ntp"), Filter.request("ntp"), "N to Z не спрацював");

        }
        [TestMethod]
        public void Test_AtoM()
        {
            Handler_ Filter = new Is_this_question_normal();
            Handler_ AtoM = new FromAtoM();

            Filter.setNext(AtoM);
            Assert.AreEqual(AtoM.request("ABC"), Filter.request("ABC"), "A to M не спрацював");

        }
        [TestMethod]
        public void Test_AtoM2()
        {
            Handler_ Filter = new Is_this_question_normal();
            Handler_ AtoM = new FromAtoM();

            Filter.setNext(AtoM);
            Assert.AreEqual(AtoM.request("ntp"), Filter.request("ntp"), "A to M не спрацював");

        }
        [TestMethod]
        public void Try_questions()
        {
            Handler_ Filter = new Is_this_question_normal();
            Handler_ Filter2 = new Is_this_question_normal();
            Handler_ AtoM = new FromAtoM();
            Handler_ NtoZ = new FromNtoZ();

            Filter.setNext(AtoM);
            AtoM.setNext(NtoZ);
            Assert.AreEqual(Filter2.request("ABC?"), Filter.request("ABC?"), "Проблеми із \"?\"");
        }
        [TestMethod]
        public void Try_questions2()
        {
            Handler_ Filter = new Is_this_question_normal();
            Handler_ Filter2 = new Is_this_question_normal();
            Handler_ AtoM = new FromAtoM();
            Handler_ NtoZ = new FromNtoZ();

            Filter.setNext(AtoM);
            AtoM.setNext(NtoZ);
            Assert.AreEqual(Filter2.request(" ABC"), Filter.request(" ABC"), "Проблеми із \" \"");

        }
    }
}
