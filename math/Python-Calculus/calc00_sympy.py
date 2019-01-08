# -*- coding: utf-8 -*-
"""
Created on Fri Nov  9 17:14:23 2018

@author: rcorley
"""

import sympy as sp

# Declare variables
x,y,z = sp.symbols('x y z')

# Print x times y
#print(x*y)
#sp.pprint(x*y)

# Print some spaces to make things easy to read
#print()
#print()

# Print x squared
#print(x**2)
#sp.pprint(x**2)

# Store the function f(x) = x**2 - 2x + 1
f = x**2 - 2*x + 1
print()
print(f)
print()
sp.pretty_print(f)

#print("Evaluate at x=2")
#print(f.subs(x,2))
#print()
#print()
#print("Factor f(x)")
#sp.pprint(f.factor())
#print()
#print()

#print("Plot f(x)")
#sp.plot(f)
#print()
#print()
#
#print("Solve for f(x)=0")
#print("First, create and store the equation.")
#equation = sp.Eq(f, 0)
#print("The solution is: " + str(sp.solve(equation)))
#print()
#print()

print()
print()
print()

a,b,c = sp.symbols('a b c')

eq1 = sp.Eq(a+b+c, 2)
eq2 = sp.Eq(4*a+2*b+c, 4)
eq3 = sp.Eq(9*a+3*b+c, 7)

sp.pprint(sp.solve( [eq1,eq2,eq3] ))

