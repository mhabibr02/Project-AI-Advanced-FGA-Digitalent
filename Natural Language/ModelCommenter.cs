public static List<List<int>> Permutations(List<int> lst) 

{ 

// Check if the input list is empty 

if (lst.Count == 0) 

{ 

        return new List<List<int>>(); 

} 

// Check if the input list has only one element 

else if (lst.Count == 1) 

{ 

        return new List<List<int>> { lst }; 

} 

else 

{ 

        // Initialize an empty list to store permutations 

        List<List<int>> result = new List<List<int>>(); 

        // Iterate through each element of the input list 

        for (int I = 0; I < lst.Count; i++) 

        { 

            // Remove the current element from the list and store it in a variable 

            int temp = lst[i]; 

            List<int> remaining = new List<int>(lst); 

            remaining.RemoveAt(i); 

            // Recursively call the function on the remaining list 

            foreach (List<int> p in Permutations(remaining)) 

            { 

                // Append the current element to the beginning of each permutation and add it to the result list 

                List<int> permutation = new List<int> { temp }; 

                permutation.AddRange(p); 

                result.Add(permutation); 

            } 

        } 

        // Return the final list of permutations 

        return result; 

} 

}
