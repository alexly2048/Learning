#! /usr/bin/env python3
# -*- utf-8 -*-
def Fibonacci(n):
	"""Print a Fibonacci series up to n."""
	a,b = 0,1;
	while a < n:
		print(a,end=' ');
		a,b = b,a+b;
	print();