/// Copyright (C) 2015 Kasper Kronborg Isager.
namespace Application.Foo

open Xunit;
open FsUnit.Xunit;

/// <summary>Example unit test module included for the purpose of demonstration.</summary>
module BarTest =
  [<Fact>]
  let Assertion() =
    let bar = new Bar()
    bar.Thing <- "Hello World!"
    bar |> should not' (be null)
    bar.Thing |> should equal "Hello World!"
