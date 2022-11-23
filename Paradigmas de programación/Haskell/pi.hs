funcion_pi :: Floating a => a -> a
funcion_pi n = (-1)**n/(2*n+1) 

calcularPi :: (Eq p, Floating p) => p -> p
calcularPi n = if n == 0 then 0
    else calcularPi (n-1) + 4*(funcion_pi (n-1))