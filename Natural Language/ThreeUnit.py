def test_binary_search(): 

    # Test case 1: Target element is in the middle of the array 

    arr1 = [1, 2, 3, 4, 5, 6] 

    target1 = 4 

    assert binary_search(arr1, target1) == 3 

 

    # Test case 2: Target element is at the beginning of the array 

    arr2 = [1, 2, 3, 4, 5, 6] 

    target2 = 1 

    assert binary_search(arr2, target2) == 0 

 

    # Test case 3: Target element is not in the array 

    arr3 = [1, 2, 3, 4, 5, 6] 

    target3 = 7 

    assert binary_search(arr3, target3) == -1
