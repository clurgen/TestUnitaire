using Test_unitaire;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestUnitaireTest
{
    
    
    /// <summary>
    ///Classe de test pour Ean13Test, destinée à contenir tous
    ///les tests unitaires Ean13Test
    ///</summary>
    [TestClass()]
    public class Ean13Test
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active ainsi que ses fonctionnalités.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Attributs de tests supplémentaires
        // 
        //Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        //Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test dans la classe
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Utilisez ClassCleanup pour exécuter du code après que tous les tests ont été exécutés dans une classe
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Test pour Constructeur Ean13
        ///</summary>
        [TestMethod()]
        public void Ean13ConstructorTest()
        {
            Ean13 target = new Ean13(new int[] { 0,0,0,0,0,0,0,0,0,0,0,9 });
            //Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible");
        }

        /// <summary>
        ///Test pour Constructeur Ean13
        ///</summary>
        [TestMethod()]
        public void Ean13ConstructorTest0a9()
        {
            try
            {
                Ean13 target = new Ean13(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,9 });
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, "Les élements du Gencode doivent être compris entre 0 et 9");
                return;
            }
            Assert.Fail("Les élements du Gencode sont compris entre 0 et 9");
        }

        /// <summary>
        ///Test pour Constructeur Ean13
        ///</summary>
        [TestMethod()]
        public void Ean13ConstructorTest_13()
        {
            try
            {
                Ean13 target = new Ean13(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 7 });
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, "Le code Ean 13 ne contient pas 12 entiers");
                return;
            }
            Assert.Fail("Le code Ean 13 contient 12 entiers");
        }
        /// <summary>
        ///Test pour Constructeur Ean13
        ///</summary>
        [TestMethod()]
        public void Ean13ConstructorTest_11()
        {
            try
            {
                Ean13 target = new Ean13(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, "Le code Ean 13 ne contient pas 12 entiers");
               return;
            }
            Assert.Fail("Le code Ean 13 contient 12 entiers");
        }
        /// <summary>
        ///Test pour PoidsImpair
        ///</summary>
        [TestMethod()]
        public void PoidsImpairTest()
        {
            Ean13 target = new Ean13(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }); // TODO: initialisez à une valeur appropriée
            int expected = 0; // TODO: initialisez à une valeur appropriée
            int actual;
            actual = target.PoidsImpair();
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour PoidsPair
        ///</summary>
        [TestMethod()]
        public void PoidsPairTest()
        {
            Ean13 target = new Ean13(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }); // TODO: initialisez à une valeur appropriée
            int expected = 0; // TODO: initialisez à une valeur appropriée
            int actual;
            actual = target.PoidsPair();
            Assert.AreEqual(expected, actual);
           // Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour Reste
        ///</summary>
        [TestMethod()]
        public void ResteTest()
        {
            Ean13 target = new Ean13(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }); // TODO: initialisez à une valeur appropriée
            int expected = 0; // TODO: initialisez à une valeur appropriée
            int actual;
            actual = target.Reste();
            Assert.AreEqual(expected, actual);
            // Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour Cle
        ///</summary>
        [TestMethod()]
        public void CleTest()
        {
            Ean13 target = new Ean13(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }); // TODO: initialisez à une valeur appropriée
            int expected = 0; // TODO: initialisez à une valeur appropriée
            int actual;
            actual = target.Cle();
            Assert.AreEqual(expected, actual);
            // Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour ToString
        ///</summary>
        [TestMethod()]
        public void ToStringTest()
        {
            Ean13 target = new Ean13(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }); // TODO: initialisez à une valeur appropriée
            string expected = "0000-0000-0000-0"; // TODO: initialisez à une valeur appropriée
            string actual = target.ToString();
            Assert.AreEqual(expected, actual);
            // Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }
    }
}
