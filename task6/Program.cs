/*  - Use Big-O notation to estimate the time complexity of each of the follow algorithms (presented as
    code snippets). Note; variable n is a large positive number.
    - Your answer should include:
        - Big-O estimate.
        - Analysis to justify the above estimate.
*/

// 1.

for(int k = n; k > 0; k--){
  for(int i = 30; i > 0; i--){
    for(int j = n; j > 0; j--){
        WriteLine("*");
    }
  }
}


/* Analysis:

Code:                               Number of operations:

for(int k = n; k > 0; k--)          n

{
    for(int i = 30; i > 0; i--)     30
}

for(int j = n; j > 0; j--)          n

WriteLine("*");                     constant

T(n) = n x 30 x n x c => O(n^2) */

// 2. 

int count = n;
while(count > 1){
  count = count / 2;
}

/* Analysis:

Code:                       Number of operations:

int count = n;              constant = 1

while(count > 1){           log(n)  --  n/2^k = 1 =>  (n/2^k)x2^k = 1 x 2^k => n = 2^k => log(n) = log(2^k) => k = log(n)
    
    count = count / 2;      c
}

T(n) = c + log(n) x c => O(logn)  */

// 3. 

for(int i = 10; i > 0; i--){
  WriteLine("*");
}
for(int i = n; i > 0; i--){
  for(int j = n; j > 0; j--){
    WriteLine("*");
  }
}

/* Analysis:

Code:                               Number of operations:

for(int i = 10; i > 0; i--){        10
  
  WriteLine("*");                   c
}

for(int i = n; i > 0; i--){         n

  for(int j = n; j > 0; j--){       n
    
    WriteLine("*");                 c
  }
}

T(n) = 10c + n x n x c =>  n^2 => O(n^2)   */
