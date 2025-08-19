namespace Demo_collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region tableau à plusieurs dimensions
            //// matrice
            //int[,] plateau = new int[10, 10];

            //for (int i = 0; i < plateau.GetLength(0); i++)
            //{
            //    for (int j = 0; j < plateau.GetLength(1); j++)
            //    {
            //        plateau[i, j] = 0;
            //    }
            //}

            //for (int i = 0; i < plateau.GetLength(0); i++)
            //{
            //    for (int j = 0; j < plateau.GetLength(1); j++)
            //    {
            //        Console.Write(plateau[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //// tableaux des tableaux
            //int[][] mesNombres = new int[2][];
            //mesNombres[0] = new int[5];
            //mesNombres[1] = new int[10];

            //for (int i = 0; i < mesNombres.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mesNombres[i].GetLength(0); j++)
            //    {
            //        mesNombres[i][j] = 0;
            //    }
            //}
            //for (int i = 0; i < mesNombres.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mesNombres[i].GetLength(0); j++)
            //    {
            //        Console.Write(plateau[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Les listes
            List<int> maListeDeNombre = new List<int>();
            //Console.WriteLine(maListeDeNombre.Count());

            maListeDeNombre.Add(10);
            //Console.WriteLine(maListeDeNombre[0]);
            maListeDeNombre.Add(5);
            maListeDeNombre.Add(5);
            //foreach (int nombre in maListeDeNombre.Distinct())
            //{
            //    Console.WriteLine(nombre);
            //}

            maListeDeNombre.Remove(5);
            foreach ((int valeur,int index) nombre in maListeDeNombre.Select((valeur,index)=> (valeur, index)))
            {
                // impossible de modifier une collection comme ceci avec un foreach
                // maListeDeNombre.Remove(nombre.valeur);
                Console.WriteLine($"{nombre.valeur} à l'index {nombre.index}");
            }

            // ressort la liste sous forme d'un tableau
            maListeDeNombre.ToArray();
            #endregion

            #region Les dictionnaires
            //Dictionary<string, float> conversionDepuisDollard = new Dictionary<string, float>();
            //conversionDepuisDollard.Add("Euro", 0.86f);
            //conversionDepuisDollard.Add("Yen", 147.70f);

            //float mesDollard = 17.5f;

            //Console.WriteLine($"{mesDollard * conversionDepuisDollard["Euro"]} Euros");

            //// Exception car la clé est déjà employée
            ////conversionDepuisDollard.Add("Euro", 0.5f);

            //// Exception car la clé n'est pas encore présente
            ////Console.WriteLine(conversionDepuisDollard["Dollard Canadien"]);

            //Console.WriteLine(conversionDepuisDollard.ContainsKey("Dollard Canadien"));

            //// boucler sur toute les clés
            //foreach (string key in conversionDepuisDollard.Keys)
            //{
            //    Console.WriteLine($"1 Dollars vaut {conversionDepuisDollard[key]} {key}");
            //}
            #endregion

            #region Les piles (LIFO)
            //Stack<int> maPile = new Stack<int>();
            //maPile.Push(1);
            //maPile.Push(2);
            //maPile.Push(3);

            //while (maPile.TryPop(out int pop))
            //{
            //    Console.WriteLine(pop);
            //}

            //// retirer le dernier élément
            //// Exception si notre tas est vide
            ////maPile.Pop();
            //// donne la dernière valeur sans la retirer
            //// même exception qu'ave le pop
            ////maPile.Peek();
            #endregion

            #region Les files (FIFO)
            //Queue<int> maFile = new Queue<int>();
            //maFile.Enqueue(1);
            //maFile.Enqueue(2);
            //maFile.Enqueue(3);

            //while (maFile.TryDequeue(out int result))
            //{
            //    Console.WriteLine(result);
            //}

            //// retire le premier élémént
            //// Exception si la file est vide
            //maFile.Dequeue();
            //// donne la prochaine valeur à sortir sans la retirer
            //// Exception si la file est vide
            //maFile.Peek();
            #endregion

        }
    }
}
