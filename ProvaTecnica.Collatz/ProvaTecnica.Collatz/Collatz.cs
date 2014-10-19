using System;
using System.Collections.Generic;
using System.Diagnostics;
using ProvaTecnica.Collatz.Interface;
using System.Linq;
using System.Text;

namespace ProvaTecnica.Collatz
{
    class Collatz : InterfaceCollatz
    {
        private const int limite = 100000;

        public string exCollatz() {
            try  {
                    int inicio = 0;
                    int maior = 0;
                    int index;

                for (int i = 2; i <= limite; i++) {
                    int tamanho = 1;
                    index = i;

                    while (index != 1) {
                        if ((index % 2) == 0 ) {
                            index = index / 2;
                        } else {
                            index = index * 3 + 1;
                            tamanho++;
                        }
                    }

                    if (tamanho > inicio) {
                        inicio = tamanho;
                        maior = i;
                    }
                }

            return string.Format("o que gera maior sequencia é:  {0}", maior);
            }

            catch(Exception e) {
               return string.Concat("erro", e.Message);
                throw;
            }
        }
    }
}
