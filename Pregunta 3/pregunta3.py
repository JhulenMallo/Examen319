# -*- coding: utf-8 -*-
"""
Created on Thu May 19 14:36:11 2022

@author: jm_vi
"""

#PYTHON Y PROLOG SIN ARCHIVO.PL
from pyswip import Prolog
prolog=Prolog()
prolog.assertz("padre(juan,julio)")
prolog.assertz("padre(juan,maria)")
prolog.assertz("padre(julio,carlos)")
prolog.assertz("padre(maria,marcela)")
prolog.assertz("padre(maria,pablo)")

for elem in prolog.query("padre(X,Y),padre(Y,Z)"):
    print(elem["X"], "es el abuelo de", elem["Z"])
print()
for elem in prolog.query("padre(X,Y),padre(Y,Z)"):
    print(elem["Z"], "es el nieto de", elem["X"])
print()
for elem in prolog.query("padre(Y,A),padre(Z,B),padre(X,Y),padre(X,Z),(Y\==Z)"):
    print(elem["A"], "es el primo de", elem["B"])
