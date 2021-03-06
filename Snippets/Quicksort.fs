﻿module Quicksort

/////////////////
//  QUICKSORT  //
/////////////////

let rec qs inList =
    match inList with
    | [] -> []
    | hd::tail -> 
        let lessThan, greaterThan = List.partition ((>=)hd) tail
        qs lessThan @ [hd] @ qs greaterThan