using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UI_Gun_shoot_game;

namespace GunShoot_unitTesting
{
    [TestClass]
    public class UnitTest1
    {
        //class
        GSGClass myclass = new GSGClass();

        [TestMethod]
        //test method 1
        public void LoadGun()// loadgun testing

        {

            string Actual = myclass.LoadGun(out int num);
            string Expected = "Gun Is Reloaded ...Ready For Spin the Chamber";

            Assert.AreEqual(Expected, Actual);


        }
        //test method2 
        [TestMethod]
        public void Spin()// spin button testing
        {
            string Actual = myclass.spinchamber(out int value);
            string Expected = "Bullet is in the Chamber ....Ready for Fire";

            Assert.AreEqual(Expected, Actual);

        }
    }
}
