using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Construtores
{
    internal class ExemploConstrutor : Executor
    {
        public override void Executar()
        {
            var computadorJose = new Computador(
                "Intel Core i5 11º Geração",
                MemoriaRamEnum.Memoria32GB,
                500,
                1024);

            var computadorLeilane = new Computador(
                "Intel Core i7",
                MemoriaRamEnum.Memoria32GB,
                1000,
                512);

            var computadorLuiz = new Computador(
                "Intel Core i5 7º Geração",
                MemoriaRamEnum.Memoria16GB,
                500,
                2048);
        }
    }
}
