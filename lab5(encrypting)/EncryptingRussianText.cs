using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab5_encrypting_
{
    class EncryptingRussianText
    {
        public struct HelpStruct
        {
            public char simbol;
            public int period; 
        }

        private string text;
        private string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        private string natural = "отеаинрвслкпдмуыьчбзгяжхчюэшйщцфё";
        private HelpStruct[] helpStruct = new HelpStruct[33];
        public EncryptingRussianText(string text)
        {
            this.text = text.ToLower();
        }
        public string Encrypting()
        {
            //вычисление частоты встречаемости букв в тексте
            for (int i = 0; i < alphabet.Length; i++)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    if (text[j]==alphabet[i])
                    {
                        helpStruct[i].simbol = alphabet[i];
                        helpStruct[i].period++;
                    }
                }
            }
            //сортировка структуры по частоте
            for(int i = 0; i < helpStruct.Length; i++)
            {
                for(int j = 0; j<helpStruct.Length - i - 1; j++)
                {
                    if (helpStruct[j].period < helpStruct[j + 1].period)
                    {
                        HelpStruct temp = helpStruct[j];
                        helpStruct[j] = helpStruct[j + 1];
                        helpStruct[j + 1] = temp;
                    }
                }
            }
            natural = natural.ToUpper();
            //замена символов
            for(int i = 0; i<helpStruct.Length; i++)
            {
                text = text.Replace(helpStruct[i].simbol, natural[i]);
                Console.WriteLine("{0} | {1}", helpStruct[i].simbol, natural[i]);
            }
            text = text.ToLower();

            return text;
        }

    }
}
