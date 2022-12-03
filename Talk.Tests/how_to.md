# Peel

This is for a method where the blocking part is at the outside
(top or bottom) of the method

1. [ ] Call the Method 
      Example: `method(param1)`
2. [ ] Select everything that isn't the problem
3. [ ] Extract into public method called `method2`
4. [ ] Call  `method2` instead
      Example:`method2(newParams)`

# Slice

This is for method where the blocking part is in the middle of the method

1. [ ] Call the Method
   Example: `method(param1)`
2. [ ] See the failing error:  
       Example: Error when calling `object.method(param1,param2);`
3. [ ] Pass in a mock for the `object` where the call is failing
4. [ ] See the new failing error:  
       Example: Unexpected call to `object.method(param1,param2);`
5. [ ] add Mock behavior for that call
6. [ ] repeat 


# Peel & Slice

1. [ ] Call Method
2. [ ] See Problem
3. [ ] Solve Problem
   1. If at **Top** or **Bottom**
      1. [ ] Peel
   2. If in **Middle** 
      1. [ ] Slice
4. [ ] Repeat until done