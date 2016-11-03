using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class ExpressionHolder
    {
        private string[] expression;//An array that holds the expression to be evaluated
        private int currentInput;//Element to add to next

        public ExpressionHolder()
        {
            expression = new string[51];
            currentInput = 1;//Skip the first element in the array
            resetExpression();
        }

        public void addToExpression(string addedElement)
        {

            if (currentInput <= 51)
            {
                expression[currentInput] = addedElement;
                currentInput = currentInput + 1;
            }
            Console.WriteLine(expression[currentInput-1]);
        }//addToExpression

        public void getExpression()
        {

        }//Retrieves the expression

        public void resetExpression()
        {
            for (int i = 0; i <=50; i++)
            {
                expression[i] = null;
            }
            currentInput = 1;
        }//Sets the exprssion to be empty

    }//ExpressionHolder
}//SimpleCalculator
