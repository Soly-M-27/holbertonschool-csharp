#!/usr/bin/python3
from errno import ESTALE


str_1 = "abcd"

str_e = ""

for x in str_1[::-1]:
    str_e += x;
    
print(str_e)
print(str_1)

for a in str_1:
    if str_e[-1] != a:
        str_e += a

print(str_e)
