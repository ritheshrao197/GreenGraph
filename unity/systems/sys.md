# Object Pooling System

## Problem
Frequent instantiate/destroy causes GC spikes

## Solution
- Prewarm objects
- Reuse instances

## Implementation
- PoolManager
- IPoolable interface