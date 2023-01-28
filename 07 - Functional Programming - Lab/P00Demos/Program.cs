using System;


Predicate<int> predicate = n =>
{
return n * n % 2 == 0;
};