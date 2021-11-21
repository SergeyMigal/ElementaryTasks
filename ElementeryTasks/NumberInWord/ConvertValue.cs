using System;
using System.Collections.Generic;
using System.Text;

namespace NumberInWord
{
    class ConvertValue
    {
        Dictionary<int, string> numberStrings = new Dictionary<int, string>()
        {
            {1,"один" },
            {2,"два" },
            {3,"три" },
            {4,"четыре" },
            {5,"пять" },
            {6,"шесть" },
            {7,"семь" },
            {8,"восемь" },
            {9,"девять" },
            {10,"десять" },
            {11,"одинадцать" },
            {12,"двенадцать" },
            {13,"тринадцать" },
            {14,"четырнадцать" },
            {15,"пятнадцать" },
            {16,"шестнадцать" },
            {17,"семнадцать" },
            {18,"восемнадцать" },
            {19,"девятнадцать" },

            {20,"двадцать" },
            {30,"тридцать" },
            {40,"сорок" },
            {50,"пятьдесят" },
            {60,"шестьдесят" },
            {70,"семьдесят" },
            {80,"восемьдесят" },
            {90,"девяносто" },

            {100,"сто" },
            {200,"двести" },
            {300,"триста" },
            {400,"четыреста" },
            {500,"пятьсот" },
            {600,"шестьсот" },
            {700,"семьсот" },
            {800,"восемьсот" },
            {900,"девятьсот" },

            {1000,"одна тысяча" },
            {2000, "две тысячи" },
            {3000, "три тысячи" },
            {4000, "четыре тысячи" },

            {1000000,"один миллион" },
            {2000000,"два миллиона" },
            {3000000,"три миллиона" },
            {4000000,"четыре миллиона" }
        };
        Dictionary<int, int> numberOfDigitsDividers = new Dictionary<int, int>()
        {
            {2,10 },
            {3,100 },
            {4,1000 },
            {5,1000 },
            {6,1000 },
            {7,1000000 },
            {8,1000000 },
            {9,1000000 }
        };
        Dictionary<int, string> dividerEndings = new Dictionary<int, string>()
        {
            {1000,"тысяч" },
            {1000000,"миллионов" },
        };
        Dictionary<int, string> dividerAlternativeEndings = new Dictionary<int, string>()
        {
            {1000,"тысячи" },
            {1000000,"миллиона" },
        };
        public string GetNumberStringPresentation(int inputValue)
        {
            if (inputValue == 0)
            {
                return "";
            }
            else if (inputValue >= 1 && inputValue <= 19)
            {
                return numberStrings[inputValue];
            }

            var divider = GetNumberDivider(inputValue);

            if (inputValue >= 20 && inputValue <= 999)
            {
                int remainderValue = inputValue % divider;
                int integerValue = inputValue - remainderValue;
                return numberStrings[integerValue] + " " + GetNumberStringPresentation(remainderValue);
            }
            else
            {
                int quotientValue = inputValue / divider;
                int remainderValue = inputValue % divider;
                int integerValue = inputValue - remainderValue;
                if (numberStrings.ContainsKey(integerValue))
                {
                    return numberStrings[integerValue] + " " + GetNumberStringPresentation(remainderValue);
                }
                else
                {
                    return GetNumberStringPresentation(quotientValue) + " " + GetNumberDividerEnding(quotientValue, divider) + " " + GetNumberStringPresentation(remainderValue);
                }
            }
        }
        public int GetNumberDivider(int inputValue)
        {
            int numberOfDigits = inputValue.ToString().Length;
            return numberOfDigitsDividers[numberOfDigits];
        }

        public string GetNumberDividerEnding(int quotientValue, int divider)
        {
            string inputString = quotientValue.ToString();

            if (inputString.EndsWith("2") || inputString.EndsWith("3") || inputString.EndsWith("4"))
            {
                return dividerAlternativeEndings[divider];
            }
            else
            {
                return dividerEndings[divider];
            }
        }
    }
}
