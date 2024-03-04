namespace CS220.Quiz1

open System
open Microsoft.VisualStudio.TestTools.UnitTesting

[<TestClass>]
type TestClass () =

  [<TestMethod; TestCategory "1">]
  member _.``Test1`` () =
    let result = Math.safeSub -1 1
    Assert.AreEqual (-2, result)

  [<TestMethod; TestCategory "2">]
  member _.``Test2-1`` () =
    let maxInt = System.Int32.MaxValue
    let result = Math.safeSub maxInt maxInt
    Assert.AreEqual (0, result)

  [<TestMethod; TestCategory "2";
    ExpectedException(typeof<OverflowException>)>]
  member _.``Test2-2`` () =
    let maxInt = System.Int32.MaxValue
    let result = Math.safeSub -2 maxInt
    Assert.Fail "Expected OverflowException"

  [<TestMethod; TestCategory "3">]
  member _.``Test3-1`` () =
    let minInt = System.Int32.MinValue
    let result = Math.safeSub minInt 0
    Assert.AreEqual (minInt, result)

  [<TestMethod; TestCategory "3";
    ExpectedException(typeof<OverflowException>)>]
  member _.``Test3-2`` () =
    let minInt = System.Int32.MinValue
    let result = Math.safeSub 1 minInt
    Assert.Fail "Expected OverflowException"

  [<TestMethod; TestCategory "3";
    ExpectedException(typeof<OverflowException>)>]
  member _.``Test3-3`` () =
    let minInt = System.Int32.MinValue
    let result = Math.safeSub minInt 1
    Assert.Fail "Expected OverflowException"
