suma :: (Num p, Ord p) => p -> p -> p
suma a b = if a==b+1 then 0
    else  a + suma(a+1) b