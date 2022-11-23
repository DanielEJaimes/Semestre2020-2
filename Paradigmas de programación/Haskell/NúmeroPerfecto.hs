factores :: Integral a => a -> [a]
factores n = [ i | i <- [1..n-1], n`mod`i == 0]
perfecto :: Integral a => a -> Bool
perfecto n = if sum (factores n) == n then True
    else False
