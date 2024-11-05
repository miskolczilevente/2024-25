using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace _2024_10_22_Tesztelesi
{
    internal class Aosztaly_Tesztelese
    {
        [TestFixture]
        class AosztalyTeszt
        {
            [Test]
            public void Metodus1Teszt_a34()
            {
                //Arrange
                int a = 34;
                int b = 17;

                //Act
                Aosztaly a1 = new Aosztaly();
                int eredmeny = a1.Osztas(a,b);

                //Assert
                Assert.Equals(10, eredmeny);
            }

            [Test]
            public void Osztasteszt_a12b6()
            {
                //Arrange
                int a = 12;
                int b = 6;
                Aosztaly a1 = new Aosztaly();

                //Act
                int eredmeny = a1.Osztas(a,b);

                //Assert
                //Assert.That(2, Is.EqualTo(eredmeny));
                ClassicAssert.AreEqual(2, eredmeny);
            }

            [Test]

            public void Hatvanyteszt_a2b2()
            {
                //Arrange
                int a = 2;
                int b = 2;
                Aosztaly a1 = new Aosztaly();

                //Act
                int eredmeny = a1.Hatvanyozas(a,b);

                //Assert
                ClassicAssert.AreEqual(4, eredmeny);
            }

            [Test]
            public void Hatvanyozas([Values(2,3,10)] int a, [Values(3,10,12)] int b)
            {
                //Arange
                Aosztaly a1 = new Aosztaly();

                //Act
                int eredmeny = a1.Hatvanyozas(a, b);

                //Assert
                try
                {
                    ClassicAssert.AreEqual(Math.Pow(a, b), eredmeny);
                }
                catch (StackOverflowException e) 
                {
                    StringAssert.Contains(e.Message, "A hatványozás eredménye túl nagy szám lenne!");
                    return;
                }
                catch (Exception e)
                {
                    StringAssert.Contains(e.Message, "az algoritmusban hiba van!");
                    return;
                }
            }
        }
    }
}
