#!/usr/bin/python3

class num():
    def k(self, m, n, k):
        table = [i*j for i in range(1, m+1) for j in range(1, n+1)]
        table.sort()
        print(table)
        return table[k-1]