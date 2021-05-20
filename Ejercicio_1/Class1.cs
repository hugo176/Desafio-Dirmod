using System;

namespace Ejercicio_1
{
    public class Class1
    {

        public String getCadenaNumerica(String texto)
        {

            String cadenaNumerica = "";

            //recorrer la cadena
            foreach (char caracter in texto)
            {
                switch (caracter)
                {
                    case ' ':
                        cadenaNumerica += "0";
                        break;
                    case 'a':
                        cadenaNumerica += "2";
                        break;
                    case 'b':
                        cadenaNumerica += "22";
                        break;
                    case 'c':
                        cadenaNumerica += "2";
                        break;
                    case 'd':
                        cadenaNumerica += "3";
                        break;
                    case 'e':
                        cadenaNumerica += "33";
                        break;
                    case 'f':
                        cadenaNumerica += "333";
                        break; ;
                    case 'g':
                        cadenaNumerica += "4";
                        break;
                    case 'h':
                        cadenaNumerica += "44";
                        break;
                    case 'i':
                        cadenaNumerica += "444";
                        break; ;
                    case 'j':
                        cadenaNumerica += "5";
                        break;
                    case 'k':
                        cadenaNumerica += "55";
                        break;
                    case 'l':
                        cadenaNumerica += "555";
                        break;
                    case 'm':
                        cadenaNumerica += "6";
                        break;
                    case 'n':
                        cadenaNumerica += "66";
                        break;
                    case 'o':
                        cadenaNumerica += "666";
                        break;
                    case 'p':
                        cadenaNumerica += "7";
                        break;
                    case 'q':
                        cadenaNumerica += "77";
                        break;
                    case 'r':
                        cadenaNumerica += "777";
                        break;
                    case 's':
                        cadenaNumerica += "7777";
                        break;
                    case 't':
                        cadenaNumerica += "8";
                        break;
                    case 'u':
                        cadenaNumerica += "88";
                        break;
                    case 'v':
                        cadenaNumerica += "888";
                        break;
                    case 'w':
                        cadenaNumerica += "9";
                        break;
                    case 'x':
                        cadenaNumerica += "99";
                        break;
                    case 'y':
                        cadenaNumerica += "999";
                        break;
                    case 'z':
                        cadenaNumerica += "9999";
                        break;
                    default:
                        cadenaNumerica += "#";
                        break;
                }
                cadenaNumerica += " ";
            }
            cadenaNumerica = cadenaNumerica.Remove(cadenaNumerica.Length - 1, 1);
            return cadenaNumerica;
        }
    }
}
