/// Copyright (C) 2015 Kasper Kronborg Isager.
namespace Application

open Application.Foo

/// <summary>The type that contains the main entry point.</summary>
type public Program() =
  /// <summary>The main entry point to the application.</summary>
  member this.Main() =
    let bar = new Bar()
    bar.Thing <- "Hello World!"
    bar.Baz bar.Thing
