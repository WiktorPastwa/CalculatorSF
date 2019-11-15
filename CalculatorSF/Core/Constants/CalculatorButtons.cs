using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorSF.Model;

namespace CalculatorSF.Core.Constants
{
    public static class CalculatorButtons
    {
        public static Button[] ScientificCalculator => new Button[]
        {
            SuperScriptButton.Create("X", "2", "2", 1),
            SuperScriptButton.Create("X", "Y", "y", 2),
            Model.CalculatorButtons.Create("sin", "sin", 3),
            Model.CalculatorButtons.Create("cos", "cos", 4),
            Model.CalculatorButtons.Create("tan", "tan", 5),
            Model.CalculatorButtons.Create("√", "sqrt", 6),
            SuperScriptButton.Create("10", "sn", "x", 7),
            Model.CalculatorButtons.Create("log", "log", 8),
            Model.CalculatorButtons.Create("Exp", "Exp", 9),
            Model.CalculatorButtons.Create("Mod", "Mod", 10),
            Model.CalculatorButtons.Create("CE", "CE", 11),
            Model.CalculatorButtons.Create("Undo", "Undo", 12),
            Model.CalculatorButtons.Create("π", "PI", 13),
            Model.CalculatorButtons.Create("C", "C", 14),
            Model.CalculatorButtons.Create(".", ".", 15),
            Model.CalculatorButtons.Create("7", "7", 16),
            Model.CalculatorButtons.Create("8", "8", 17),
            Model.CalculatorButtons.Create("9", "9", 18),
            Model.CalculatorButtons.Create("*", "*", 19),
            Model.CalculatorButtons.Create("±", "negate", 20),
            Model.CalculatorButtons.Create("4", "4", 21),
            Model.CalculatorButtons.Create("5", "5", 22),
            Model.CalculatorButtons.Create("6", "6", 23),
            Model.CalculatorButtons.Create("(", "(", 24),
            Model.CalculatorButtons.Create(")", ")", 25),
            Model.CalculatorButtons.Create("1", "1", 26),
            Model.CalculatorButtons.Create("2", "2", 27),
            Model.CalculatorButtons.Create("3", "3", 28),
            Model.CalculatorButtons.Create("+", "+", 29),
            Model.CalculatorButtons.Create("-", "-", 30),
            Model.CalculatorButtons.Create("0", "0", 31),

        }.OrderBy(x => x.Order).ToArray();
    }
}
