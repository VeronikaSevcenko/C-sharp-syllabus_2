using NUnit.Framework;
using Animals_and_Food;
using System;

namespace AnimalAndFood.Test
{
    public class Tests
    {
        [Test]
        public void MakeNoise_TigerRex_ResultROAAAAAAAAAAAAAAAAAAAR()
        {
            //Arrange
            Animal animalTiger = new Tiger("Rex", "White", 168.2, 0, "Asia");
            //Act
            string result = animalTiger.MakeNoise();
            //Assert
            Assert.AreEqual("ROAAAAAAAAAAAAAAAAAAAR", result);
        }

        [Test]
        public void ToStringInfo_TigerRex_ResultTiger()
        {
            //Arrange
            Animal animalTiger = new Tiger("Rex", "White", 168.2, 0, "Asia");
            //Act
            string result = animalTiger.ToString();
            //Assert
            Assert.AreEqual("Rex, White, 168.2, 0, Asia", result);
        }

        [Test]
        public void TheTigerEatMeat_TigerFoodMeat_ResultMeat()
        {
            //Arrange
            Animal animalTiger = new Tiger("Rex", "White", 168.2, 0, "Asia");
            Food food = new Meat(8);
            //Act
            var result2 = animalTiger.Eat(food);
            //Assert
            Assert.AreEqual(8, result2);
        }

        [Test]
        public void TigerAndVegetable_TigerFoodVegetable_ResultNotEat()
        {
            //Arrange
            Animal animalTiger = new Tiger("Rex", "White", 168.2, 0, "Asia");
            Food food = new Vegetable(8);
            //Act
            void P() => animalTiger.Eat(food);
            //Assert
            Assert.AreEqual("Rex this animal are not eating this food food!", Assert.Throws< ArgumentException>(P).Message);
        }

        [Test]
        public void SoundCat_CatGarfild_ResultMeowwwwWwhereIsyfoodHuman()
        {
            //Arrange
            Animal animalCat = new Cat("Garfild", "Gray", 1.8, 4, "Persian", "Flat");
            //Act
            string result = animalCat.MakeNoise();
            //Assert
            Assert.AreEqual(" Meowwww, where is my food,human! ", result);
        }

        [Test]
        public void ToStringInfo_CatGarfild_ResultCat()
        {
            //Arrange
            Animal animalCat = new Cat("Garfild", "Gray", 1.8, 4, "Persian", "Flat");
            //Act
            string result = animalCat.ToString();
            //Assert
            Assert.AreEqual("Garfild, Gray, 1.8, 4, Persian, Flat", result);
        }

        [Test]
        public void TheCatEatVegetable_CatFoodVegtable_ResultVegetable()
        {
            //Arrange
            Animal animalCat = new Cat("Garfild", "Gray", 1.8, 0, "Persian", "Flat");
            Food food = new Vegetable(3);
            //Act
            var result = animalCat.Eat(food);
            //Assert
            Assert.AreEqual(3, result);
        }
    }
}