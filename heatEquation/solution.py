# -*- coding: utf-8 -*-
import math
#preferences
T = 10.0 #time maximum
n = 10 #number of separations
m = 10000 #time nodes 
l = 1.0 #interval len

h = l/n #grid
tao = T/float(m) #time grid

print 'Grid step: %s' % h
print 'Time step %s' % tao

start_condition = lambda x: 0 #math.sin(x)
left_border = lambda t: 5
right_border = lambda t: 1

def naive_calculation():
    '''
    Calculate surface produced by equation in [x, y, t] space
    Uses O(m) memory
    '''
    M = []
    for t in range(0, m + 1):
        M.append([float(0)]*(n+1))

    #Start condition
    Sc = []
    for x in range(0, n+1):
        M[0][x] = start_condition(h*x)

    #Border condition
    for t in range(0, m+1):
        M[t][0] = left_border(tao*t)
        M[t][n] = right_border(tao*t)

    #Calculations
    for t in range(0, m):
        for x in range(1, n):
            M[t+1][x] = M[t][x] + tao * (M[t][x-1] - 2*M[t][x] + M[t][x+1]) / (h*h)

    #Output
    for t in range(m - 20, m):
        print M[t]

def step_by_step_calculation(iteration_count, start_time = 0):
    '''
    Calculate function value by known time
    Uses O(1) memory
    '''
    C = [float(0)]*(n+1)
    N = [float(0)]*(n+1)
    for x in range(1, n):
        C[x] = start_condition(h*x)

    for t in range(iteration_count):
        C[0] = left_border(start_time + tao * t)
        C[n] = right_border(start_time + tao * t)

        for x in range(1,n):
            N[x] = C[x] + tao * (C[x - 1] - 2*C[x] + C[x+1]) / (h*h)
        
        #swap buffers
        N, C = C, N
    return C

print step_by_step_calculation(m)
