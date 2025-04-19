public static List<List<int>> Permutations(List<int> lst) 

{ 

if (lst.Count == 0) 

{ 

        return new List<List<int>>(); 

} 

else if (lst.Count == 1) 

{ 

        return new List<List<int>> { lst }; 

} 

else 

{ 

        List<List<int>> result = new List<List<int>>(); 

        for (int I = 0; I < lst.Count; i++) 

        { 

            int temp = lst[i]; 

            List<int> remaining = new List<int>(lst); 

            remaining.RemoveAt(i); 

            foreach (List<int> p in Permutations(remaining)) 

            { 

                List<int> permutation = new List<int> { temp }; 

                permutation.AddRange(p); 

                result.Add(permutation); 

            } 

        } 

        return result; 

} 

}
