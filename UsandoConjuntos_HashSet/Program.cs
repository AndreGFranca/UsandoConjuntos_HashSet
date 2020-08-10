using System;
using System.Collections.Generic;

namespace UsandoConjuntos_HashSet {
    class Program {
        static void Main(string[] args) {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();
            Console.Write("How many students for course A: ");
            int nStudents = int.Parse(Console.ReadLine());
            for (int i = 0; i < nStudents; i++) {
                A.Add(int.Parse(Console.ReadLine()));
            }
            Console.Write("How many students for course B: ");
            nStudents = int.Parse(Console.ReadLine());
            for (int i = 0; i < nStudents; i++) {
                B.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("How many students for course C: ");
            nStudents = int.Parse(Console.ReadLine());
            for (int i = 0; i < nStudents; i++) {
                C.Add(int.Parse(Console.ReadLine()));
            }
            HashSet<int> allStudents = new HashSet<int>(A);

            allStudents.UnionWith(B);
            allStudents.UnionWith(C);
            Console.WriteLine("Total Students: " + allStudents.Count);

        }
    }
}
