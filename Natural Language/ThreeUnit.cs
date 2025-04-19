[Test] 

public void TestBinarySearch1() 

{ 

    int[] arr = { 1, 2, 3, 4, 5 }; 

    int target = 3; 

    int expected = 2; 

    int result = BinarySearch(arr, target); 

    Assert.AreEqual(expected, result); 

} 

 

[Test] 

public void TestBinarySearch2() 

{ 

    int[] arr = { 10, 20, 30, 40, 50 }; 

    int target = 35; 

    int expected = -1; 

    int result = BinarySearch(arr, target); 

    Assert.AreEqual(expected, result); 

} 

 

[Test] 

public void TestBinarySearch3() 

{ 

    int[] arr = { 3, 6, 9, 12, 15 }; 

    int target = 6; 

    int expected = 1; 

    int result = BinarySearch(arr, target); 

    Assert.AreEqual(expected, result); 

}

