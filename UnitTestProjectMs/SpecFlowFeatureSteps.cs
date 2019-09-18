using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetCoreCalculator;
using NetCoreCalculator.Controllers;
using NetCoreCalculator.Models;
using System;
using TechTalk.SpecFlow;

namespace UnitTestProjectMs
{
    [Binding]
    public class SpecFlowFeatureSteps
    {
        Calculatrice calculatrice = new Calculatrice();
        HomeController homeController = new HomeController();
        Operation model = new Operation();


        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p_Numbre1)
        {
           
            model.NumberA = p_Numbre1;

        }

        [Given(@"I have entered Also (.*) into the calculator")]
        public void GivenIHaveEnteredAlsoIntoTheCalculator(int p_Numbre2)
        {
            
            model.NumberB = p_Numbre2;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            model.OperationType = OperationType.Addition;
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p_resultat)
        {
            homeController.Index(model);
            Assert.AreEqual(model.Result, p_resultat);
            if (p_resultat == model.Result)
            {
                Console.WriteLine("Le resultat: " + model.Result + " ,le test a été passé avec succès");
            }
            else
            {
                Console.WriteLine("Le resultat: " + model.Result + " ,le test a été échoué");
            }
        }
        [When(@"I press delete")]
        public void WhenIPressDelete()
        {
            model.OperationType = OperationType.Subtraction;

        }
        
        [Then(@"the result of delete should be (.*) into the calculator")]
        public void ThenTheResultOfDeleteShouldBeIntoTheCalculator(int p_resultat)
        {
            homeController.Index(model);
            Assert.AreEqual(model.Result, p_resultat);
            if (p_resultat == model.Result)
            {
                Console.WriteLine("Le resultat: " + model.Result + " ,le test a été passé avec succès");
            }
            else
            {
                Console.WriteLine("Le resultat: " + model.Result + " ,le test a été échoué");
            }
        }

        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            model.OperationType = OperationType.Multiplication;
        }
       
        [Then(@"the result of multiply should be (.*) into the calculator")]
        public void ThenTheResultOfMultiplyShouldBeIntoTheCalculator(int p_resultat)
        {
            homeController.Index(model);
            Assert.AreEqual(model.Result, p_resultat);
            if (p_resultat == model.Result)
            {
                Console.WriteLine("Le resultat: " + model.Result + " ,le test a été passé avec succès");
            }
            else
            {
                Console.WriteLine("Le resultat: " + model.Result + " ,le test a été échoué");
            }
        }

        [When(@"I press divide")]
        public void WhenIPressDivide()
        {
            model.OperationType = OperationType.Division;
        }
   
        [Then(@"the result  of divieshould be (.*) into the calculator")]
        public void ThenTheResultOfDivieshouldBeIntoTheCalculator(int p_resultat)
        {
            homeController.Index(model);
            Assert.AreEqual(model.Result, p_resultat);

            if (p_resultat == model.Result)
            {
                Console.WriteLine("Le resultat: " + model.Result + " ,le test a été passé avec succès");
            }
            else
            {
                Console.WriteLine("Le resultat: " + model.Result + " ,le test a été échoué");
            }
        }
    }

}
