def permutations(lst): 

    if len(lst) == 0: 

        return [] 

    elif len(lst) == 1: 

        return [lst] 

    else: 

        result = [] 

        for i in range(len(lst)): 

            temp = lst[i] 

            remaining = lst[:i] + lst[i+1:] 

            for p in permutations(remaining): 

                result.append([temp] + p) 

        return result

