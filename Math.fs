module CS220.Quiz1.Math

open System

let overflow () =
  raise <| OverflowException ()

/// Modify the function `safeSub` in such a way that the function takes in two
/// 32-bit integers a and b, and returns "a - b" as output.
///   - In normal cases, it should return the resulting number.
///   - In error cases, i.e., overflow cases, it should raise
///     OverflowException. (Use `overflow ()`)
///   - Your function should have the type: "int -> int -> int".
let safeSub lhs rhs =
  0
