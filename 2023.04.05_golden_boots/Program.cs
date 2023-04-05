using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace goldenBoots
{
    public class Program
    {
static List<int> read()
{
    List<int> lista = new List<int>();
    
    string elso_sor = Console.ReadLine();
    
    string[] sortomb = elso_sor.Split(' ');
    
    int N = int.Parse(sortomb[0]);
    
    //lista.Add(N);
    
    for (int i = 0; i < N; i++)
    {
        lista.Add(int.Parse(Console.ReadLine()));
    }
    return lista;
}

        public static void Main(string[] args)
        {
            List<int> list = read();
            Dictionary<string, int> result = new Dictionary<string, int>();

            for (int i = 0; i < list.Count; i++)
            {
                
            }
        }
    }
}