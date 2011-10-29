:{
splitPair :: Eq a => [a] -> [a] -> Maybe ([a], [a])
splitPair find str = f str
    where
        f [] = Nothing
        f x  | isPrefixOf find x = Just ([], drop (length find) x)
             | otherwise = if isJust q then Just (head x:a, b) else Nothing
                where
                    q = f (tail x)
                    Just (a, b) = q
:}