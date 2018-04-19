using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catalogoVectores
{
    class Registro
    {
        private string[] auto;
        private string datos;
        private int contador;

        public Registro()
        {
            datos = "";
            auto = new string[15];
            contador = 0;
        }

        public void Agregar (string Placa, string Marca, string Modelo, string Año, string Telefono)
        {
            datos = Placa + " " + Marca + " " + Modelo + " " + Año + " " + Telefono + " " + Environment.NewLine;
            auto[contador] = datos;
            contador++;
        }

        public void Buscar(string placa)
        {
            bool Encontrado = false;
            for(int x = 0; x < contador; x++)
            {
                if (auto[x]==placa)
                {
                    Encontrado = true;
                }
            }
        }

        public void eliminar(string placa)
        {
            for (int x = 0; x < contador; x++)
            {
                if (auto[x].Contains(placa))
                {

                    while (x < contador)
                    {
                        auto[x] = auto[x + 1];
                        x++;
                    }

                }
            }
            contador--;
        }

        public void insertar(string Placa, string Marca, string Modelo, string Año, string Telefono)
        {
            for (int x = 0; x < contador; x++)
            {
                if (auto[x].Contains(Telefono))
                {
                    datos = " ";
                    datos += Placa + " " + Marca + " " + Modelo + " " + Año + " " + Telefono + " " + Environment.NewLine;
                    auto[x] = datos;
                }
            }
        }

        public string listar()
        {
            string lista = "";
            for (int x = 0; x < contador; x++)
            {
                lista += auto[x] + Environment.NewLine;

            }
            return lista;
        }
    }
}
